Public Class FormAccueil

    Private Sub FormAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnJouer.Enabled = False
        ChargerJoueurs()
        For Each j In ListeJoueurs
            ComboBoxPrenom.Items.Add(j.nom)
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPrenom.TextChanged
        If ComboBoxPrenom.Text.Length < 3 Then
            BtnJouer.Enabled = False
        Else
            BtnJouer.Enabled = True
        End If
    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        Dim reponse As Integer
        reponse = MsgBox("Voulez-vous vraiment quitter le jeu ?", vbYesNo, "Confirmation")

        If reponse = vbYes Then
            Application.Exit()
        End If
    End Sub
    Private Sub BtnJouer_Click(sender As Object, e As EventArgs) Handles BtnJouer.Click
        Me.Hide()
        Dim nouvellePartie As New FormMemory()
        nouvellePartie.LabelJoueurP.Text = ComboBoxPrenom.Text
        nouvellePartie.Show()
    End Sub
    Private Sub BtnScore_Click(sender As Object, e As EventArgs) Handles BtnScore.Click
        Me.Hide()
        ChargerJoueurs()
        Dim stats As New FormStats()
        stats.Show()
    End Sub
End Class
