Public Class FormStats
    Dim triDecroissant As Boolean = True

    Private Sub FormStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AfficherStats()

    End Sub

    Private Sub AfficherStats()
        ' Vider les listes
        ListBoxNom.Items.Clear()
        ListBoxScore.Items.Clear()
        ListBoxTempsMin.Items.Clear()
        ListBoxNbParties.Items.Clear()
        ListBoxTempsTotal.Items.Clear()
        ComboBoxRecherche.Items.Clear()

        ' Trier la liste des joueurs
        Dim joueursTries = ListeJoueurs.OrderBy(Function(j) j.meilleurScore).ThenBy(Function(j) j.tempsMin).ToList()
        If triDecroissant Then
            joueursTries.Reverse()
        End If

        ' Afficher dans les ListBox
        For Each joueur In joueursTries
            ListBoxNom.Items.Add(joueur.nom)
            ListBoxScore.Items.Add(joueur.meilleurScore)
            ListBoxTempsMin.Items.Add(joueur.tempsMin)
            ListBoxNbParties.Items.Add(joueur.nbParties)
            ListBoxTempsTotal.Items.Add(joueur.tempsTotal)
            ComboBoxRecherche.Items.Add(joueur.nom)
        Next
    End Sub

    Private Sub ListBoxNom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNom.SelectedIndexChanged
        Dim index = ListBoxNom.SelectedIndex
        ListBoxScore.SelectedIndex = index
        ListBoxTempsMin.SelectedIndex = index
        ListBoxNbParties.SelectedIndex = index
        ListBoxTempsTotal.SelectedIndex = index
    End Sub

    Private Sub BtnTri_Click(sender As Object, e As EventArgs) Handles BtnTri.Click
        triDecroissant = Not triDecroissant
        BtnTri.Text = If(triDecroissant, "Trier croissant", "Trier décroissant")
        AfficherStats()
    End Sub

    Private Sub BtnAfficher_Click(sender As Object, e As EventArgs) Handles BtnAfficher.Click
        Dim nomRecherche = ComboBoxRecherche.Text
        Dim joueur = ListeJoueurs.Find(Function(j) j.nom = nomRecherche)

        If joueur IsNot Nothing Then
            MsgBox("Nom : " & joueur.nom & vbCrLf &
                   "Score : " & joueur.meilleurScore & vbCrLf &
                   "Temps min : " & joueur.tempsMin & vbCrLf &
                   "Parties : " & joueur.nbParties & vbCrLf &
                   "Temps total : " & joueur.tempsTotal)
        Else
            MsgBox("Joueur non trouvé.")
        End If
    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Me.Close()
        FormAccueil.Show()
    End Sub
End Class