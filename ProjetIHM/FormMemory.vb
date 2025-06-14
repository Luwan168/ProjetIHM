﻿

Imports System.IO

Public Class FormMemory
    Private tempsRestant As Integer = tempsLimite
    Private tempsEcoule As Integer
    Private compteurCarre As Integer = 0
    Private Cartes As New List(Of Label)
    Private listeCartesRetournees As New List(Of Label)
    Private listeCartes As New List(Of String)
    Private valeursRetournees As New List(Of String) '
    Private WithEvents Chronometre As New Timer() With {.Interval = 1000}
    Private WithEvents TpsFace As New Timer() With {.Interval = 750} ' Le temps d'affichage de la carte avant son retournement en cas d'erreur
    Private partieTerminee As Boolean = False
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Nécessaire au redémarrage de la partie
        listeCartes.Clear()
        For Each lbl In Cartes
            lbl.Enabled = True ' On rend les labels (cartes) actifs
        Next

        ' Initialisation du chrono

        LabelChrono.Text = "Temps restant : " & tempsRestant & "s"
        Chronometre.Start()
        Dim labels() As Label = {Label1, Label2, Label3, Label4, Label5,
                         Label6, Label7, Label8, Label9, Label10,
                         Label11, Label12, Label13, Label14, Label15,
                         Label16, Label17, Label18, Label19, Label20}
        Cartes = labels.ToList()

        For i As Integer = 0 To labels.Length - 1
            labels(i).Image = Image.FromFile("Images\\" & dosCarte)
        Next
        ' On initialise les cartes du jeu

        listeCartes.Clear()

        If dosCarte = "Dos1.png" Then
            For i As Integer = 1 To 5
                For j As Integer = 1 To 4
                    listeCartes.Add("card" & i & ".png")
                Next
            Next
        ElseIf dosCarte = "Dos2.png" Then
            For i As Integer = 1 To 5
                For j As Integer = 1 To 4
                    listeCartes.Add("perso" & i & ".png")
                Next
            Next
        ElseIf dosCarte = "Dos3.png" Then
            For i As Integer = 1 To 5
                For j As Integer = 1 To 4
                    listeCartes.Add("uno" & i & ".png") ' Exemple
                Next
            Next
        End If

        ' Mélange des cartes
        Dim rand As New Random()
        listeCartes = listeCartes.OrderBy(Function(x) rand.Next()).ToList() 'Tri aléatoire par clé donnée aléatoirement via Function(x)

        For i As Integer = 0 To labels.Length - 1
            'Ajout d'un event click à tous les labels pour retourner la carte
            AddHandler labels(i).Click, AddressOf RetournerCarteFace
        Next


        If theme = "sombre" Then
            Me.BackColor = Color.Black
            Me.ForeColor = Color.White
            For Each ctrl As Control In Me.Controls
                ctrl.BackColor = Color.Black
                ctrl.ForeColor = Color.White
            Next
        Else
            Me.BackColor = SystemColors.Control
            Me.ForeColor = Color.Black
            For Each ctrl As Control In Me.Controls
                ctrl.BackColor = SystemColors.Control
                ctrl.ForeColor = Color.Black
            Next
        End If
    End Sub

    Private Sub RetournerCarteFace(sender As Object, e As EventArgs)
        Dim label As Label = CType(sender, Label)
        Dim index As Integer = Integer.Parse(label.Name.Replace("Label", "")) - 1

        ' Si la carte est déjà retournée ou validée, on ignore le clic
        If listeCartesRetournees.Contains(label) OrElse label.Enabled = False Then
            Exit Sub
        End If

        ' On retourne la carte
        label.Image = Image.FromFile("Images\" & listeCartes(index))

        ' On enregistre la carte retournée
        listeCartesRetournees.Add(label)
        valeursRetournees.Add(listeCartes(index))

        If listeCartesRetournees.Count = 4 Then
            For Each lbl In Cartes
                RemoveHandler lbl.Click, AddressOf RetournerCarteFace
            Next
            If valeursRetournees.All(Function(c) c = valeursRetournees(0)) Then
                'Les 4 cartes sont identiques
                compteurCarre = compteurCarre + 1
                For Each lbl In listeCartesRetournees
                    lbl.Enabled = False ' On rend les labels (cartes) inactifs
                Next
                For Each lbl In Cartes
                    If Not listeCartesRetournees.Contains(lbl) Then
                        AddHandler lbl.Click, AddressOf RetournerCarteFace
                    End If
                Next
                listeCartesRetournees.Clear()
                valeursRetournees.Clear()
                If compteurCarre = 5 Then
                    Chronometre.Stop()
                    tempsEcoule = 60 - tempsRestant
                    MessageBox.Show("Bravo ! Vous avez trouvé les 5 carrés en " & tempsEcoule & " secondes.")

                    ' ⬇️ ENREGISTREMENT DU SCORE
                    MettreAJourStats(LabelJoueurP.Text, compteurCarre, tempsEcoule)
                    SauvegarderJoueurs()

                    FormAccueil.Show()
                    Me.Hide()
                End If
            Else
                TpsFace.Start()
            End If
        ElseIf listeCartesRetournees.Count > 1 Then
            ' Vérifie si la dernière carte est identique aux précédentes
            If valeursRetournees.Last() <> valeursRetournees(0) Then
                For Each lbl In Cartes
                    RemoveHandler lbl.Click, AddressOf RetournerCarteFace
                Next
                TpsFace.Start()
            End If
        End If
    End Sub

    Private Sub timerRetour_Tick(sender As Object, e As EventArgs) Handles TpsFace.Tick
        TpsFace.Stop()

        ' Remettre les cartes face cachée
        For Each lbl In listeCartesRetournees
            lbl.Image = Image.FromFile("Images\\" & dosCarte)
        Next

        ' Réactiver uniquement les labels encore actifs
        For Each lbl In Cartes
            If lbl.Enabled = False And Not listeCartesRetournees.Contains(lbl) Then
                ' ne pas réactiver ceux qui sont déjà validés
            Else
                AddHandler lbl.Click, AddressOf RetournerCarteFace
            End If
        Next

        listeCartesRetournees.Clear()
        valeursRetournees.Clear()
    End Sub

    Private Sub BtnAbandon_Click(sender As Object, e As EventArgs) Handles BtnAbandon.Click
        Dim reponse As Integer
        reponse = MsgBox("Voulez-vous vraiment abandonner ?", vbYesNo, "Confirmation")

        If reponse = vbYes Then
            Me.Hide()
            Chronometre.Stop()
            MessageBox.Show("vous avez abandonné et trouvé " & compteurCarre & " carrés !")

            ' ⬇️ ENREGISTREMENT DU SCORE
            tempsEcoule = 60 - tempsRestant
            MettreAJourStats(LabelJoueurP.Text, compteurCarre, tempsEcoule)
            SauvegarderJoueurs()

            FormAccueil.Show()
        End If
    End Sub

    Private Sub timerChrono_Tick(sender As Object, e As EventArgs) Handles Chronometre.Tick
        If partieTerminee Then

            Exit Sub
        End If
        tempsRestant = tempsRestant - 1
        LabelChrono.Text = "Temps restant : " & tempsRestant & "s"
        ' Fin de partie
        If tempsRestant = 0 Then
            Chronometre.Stop()
            MessageBox.Show("Temps écoulé ! C'est perdu, vous avez mis 60s à identifier " & compteurCarre & " carrés !")

            ' ⬇️ ENREGISTREMENT DU SCORE
            MettreAJourStats(LabelJoueurP.Text, compteurCarre, 60)
            SauvegarderJoueurs()

            Me.Hide()
            FormAccueil.Show()
        End If
    End Sub

End Class

