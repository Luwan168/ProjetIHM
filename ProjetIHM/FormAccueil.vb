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

    Private Sub FormAccueil_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ComboBoxPrenom.Items.Clear()
        For Each j In ListeJoueurs
            If Not ComboBoxPrenom.Items.Contains(j.nom) Then
                ComboBoxPrenom.Items.Add(j.nom)
            End If
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
    Private Sub FormAccueil_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MsgBox("Sauvegarde en cours...")
        SauvegarderJoueurs()
    End Sub

    Private Sub BtnOption_Click(sender As Object, e As EventArgs) Handles BtnOption.Click
        Me.Hide()
        FormOption.Show()
    End Sub
End Class
