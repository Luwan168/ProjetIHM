Public Class FormOption
    Private Sub FormOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Appliquer les valeurs actuelles
        If theme = "clair" Then RadioClair.Checked = True
        If theme = "sombre" Then RadioSombre.Checked = True

        ComboTemps.Items.AddRange(New Object() {"30", "60", "90"})
        ComboTemps.SelectedItem = tempsLimite.ToString()

        Select Case dosCarte
            Case "Dos1.png" : RadioDos1.Checked = True
            Case "Dos2.png" : RadioDos2.Checked = True
            Case "Dos3.png" : RadioDos3.Checked = True
        End Select

        UpdatePreview()
    End Sub

    Private Sub BtnValider_Click(sender As Object, e As EventArgs) Handles BtnValider.Click
        If RadioClair.Checked Then theme = "clair"
        If RadioSombre.Checked Then theme = "sombre"

        If ComboTemps.SelectedItem IsNot Nothing Then
            tempsLimite = Integer.Parse(ComboTemps.SelectedItem.ToString())
        End If

        If RadioDos1.Checked Then dosCarte = "Dos1.png"
        If RadioDos2.Checked Then dosCarte = "Dos2.png"
        If RadioDos3.Checked Then dosCarte = "Dos3.png"

        Me.Close()
        FormAccueil.Show()
    End Sub

    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click
        Me.Close()
        FormAccueil.Show()
    End Sub

    Private Sub RadioDos_CheckedChanged(sender As Object, e As EventArgs) Handles RadioDos1.CheckedChanged, RadioDos2.CheckedChanged, RadioDos3.CheckedChanged
        UpdatePreview()
    End Sub

    Private Sub UpdatePreview()
        Dim fichier As String = ""
        If RadioDos1.Checked Then fichier = "Dos1.png"
        If RadioDos2.Checked Then fichier = "Dos2.png"
        If RadioDos3.Checked Then fichier = "Dos3.png"

        Try
            PicturePreview.Image = Image.FromFile("Images\\" & fichier)
        Catch
            PicturePreview.Image = Nothing
        End Try
    End Sub
End Class