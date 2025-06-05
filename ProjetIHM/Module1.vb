Imports System.IO

Public Class Joueur
    Public nom As String
    Public meilleurScore As Integer
    Public tempsMin As Integer
    Public nbParties As Integer
    Public tempsTotal As Integer
End Class

Public Module Module1

    Public ListeJoueurs As New List(Of Joueur)

    ' Options temporaires du jeu
    Public theme As String = "clair"
    Public tempsLimite As Integer = 60
    Public dosCarte As String = "Dos1.png"

    Public Sub SauvegarderJoueurs()
        Try
            ' Crée le dossier si nécessaire
            Dim dossier As String = Path.Combine(Application.StartupPath, "donnees")
            If Not Directory.Exists(dossier) Then
                Directory.CreateDirectory(dossier)
            End If

            ' Chemin du fichier à créer
            Dim chemin As String = Path.Combine(dossier, "joueurs.txt")

            Using sw As New StreamWriter(chemin, False)
                For Each j In ListeJoueurs
                    sw.WriteLine(j.nom & ";" & j.meilleurScore & ";" & j.tempsMin & ";" & j.nbParties & ";" & j.tempsTotal)
                Next
            End Using
        Catch ex As Exception
            MsgBox("Erreur lors de la sauvegarde : " & ex.Message)
        End Try
    End Sub

    Public Sub ChargerJoueurs()
        Dim chemin As String = Path.Combine(Application.StartupPath, "donnees\joueurs.txt")
        If File.Exists(chemin) Then
            ListeJoueurs.Clear()
            Using sr As New StreamReader(chemin)
                While Not sr.EndOfStream
                    Dim ligne = sr.ReadLine()
                    Dim champs = ligne.Split(";"c)
                    If champs.Length = 5 Then
                        Dim j As New Joueur
                        j.nom = champs(0)
                        j.meilleurScore = Integer.Parse(champs(1))
                        j.tempsMin = Integer.Parse(champs(2))
                        j.nbParties = Integer.Parse(champs(3))
                        j.tempsTotal = Integer.Parse(champs(4))
                        ListeJoueurs.Add(j)
                    End If
                End While
            End Using
        Else
            MsgBox("Fichier non trouvé à : " & chemin)
        End If
    End Sub

    Public Sub MettreAJourStats(nom As String, nbCarres As Integer, temps As Integer)
        Dim joueur = ListeJoueurs.Find(Function(j) j.nom = nom)

        If joueur IsNot Nothing Then
            If nbCarres > joueur.meilleurScore Then
                joueur.meilleurScore = nbCarres
                joueur.tempsMin = temps
            ElseIf nbCarres = joueur.meilleurScore AndAlso temps < joueur.tempsMin Then
                joueur.tempsMin = temps
            End If
            joueur.nbParties += 1
            joueur.tempsTotal += temps
        Else
            Dim nouveauJoueur As New Joueur
            nouveauJoueur.nom = nom
            nouveauJoueur.meilleurScore = nbCarres
            nouveauJoueur.tempsMin = temps
            nouveauJoueur.nbParties = 1
            nouveauJoueur.tempsTotal = temps
            ListeJoueurs.Add(nouveauJoueur)
        End If
    End Sub

End Module
