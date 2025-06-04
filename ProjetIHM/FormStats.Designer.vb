<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStats
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        BtnTri = New Button()
        Label1 = New Label()
        LabelNom = New Label()
        LabelScore = New Label()
        LabelTemps = New Label()
        LabelParties = New Label()
        LabelTotal = New Label()
        BtnFermer = New Button()
        BtnAfficher = New Button()
        ComboBoxRecherche = New ComboBox()
        ListBoxNom = New ListBox()
        ListBoxScore = New ListBox()
        ListBoxTempsMin = New ListBox()
        ListBoxNbParties = New ListBox()
        ListBoxTempsTotal = New ListBox()
        SuspendLayout()
        ' 
        ' BtnTri
        ' 
        BtnTri.Location = New Point(58, 465)
        BtnTri.Name = "BtnTri"
        BtnTri.Size = New Size(150, 46)
        BtnTri.TabIndex = 0
        BtnTri.Text = "Tri"
        BtnTri.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(426, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(201, 32)
        Label1.TabIndex = 5
        Label1.Text = "Statistique joueur"
        ' 
        ' LabelNom
        ' 
        LabelNom.AutoSize = True
        LabelNom.Location = New Point(39, 226)
        LabelNom.Name = "LabelNom"
        LabelNom.Size = New Size(67, 32)
        LabelNom.TabIndex = 6
        LabelNom.Text = "Nom"
        ' 
        ' LabelScore
        ' 
        LabelScore.AutoSize = True
        LabelScore.Location = New Point(222, 226)
        LabelScore.Name = "LabelScore"
        LabelScore.Size = New Size(73, 32)
        LabelScore.TabIndex = 7
        LabelScore.Text = "Score"
        ' 
        ' LabelTemps
        ' 
        LabelTemps.AutoSize = True
        LabelTemps.Location = New Point(414, 226)
        LabelTemps.Name = "LabelTemps"
        LabelTemps.Size = New Size(80, 32)
        LabelTemps.TabIndex = 8
        LabelTemps.Text = "temps"
        ' 
        ' LabelParties
        ' 
        LabelParties.AutoSize = True
        LabelParties.Location = New Point(614, 226)
        LabelParties.Name = "LabelParties"
        LabelParties.Size = New Size(122, 32)
        LabelParties.TabIndex = 9
        LabelParties.Text = "Nb Parties"
        ' 
        ' LabelTotal
        ' 
        LabelTotal.AutoSize = True
        LabelTotal.Location = New Point(812, 226)
        LabelTotal.Name = "LabelTotal"
        LabelTotal.Size = New Size(62, 32)
        LabelTotal.TabIndex = 10
        LabelTotal.Text = "total"
        ' 
        ' BtnFermer
        ' 
        BtnFermer.Location = New Point(735, 465)
        BtnFermer.Name = "BtnFermer"
        BtnFermer.Size = New Size(150, 46)
        BtnFermer.TabIndex = 11
        BtnFermer.Text = "Fermer"
        BtnFermer.UseVisualStyleBackColor = True
        ' 
        ' BtnAfficher
        ' 
        BtnAfficher.Location = New Point(528, 465)
        BtnAfficher.Name = "BtnAfficher"
        BtnAfficher.Size = New Size(150, 46)
        BtnAfficher.TabIndex = 12
        BtnAfficher.Text = "Affichage"
        BtnAfficher.UseVisualStyleBackColor = True
        ' 
        ' ComboBoxRecherche
        ' 
        ComboBoxRecherche.FormattingEnabled = True
        ComboBoxRecherche.Location = New Point(242, 465)
        ComboBoxRecherche.Name = "ComboBoxRecherche"
        ComboBoxRecherche.Size = New Size(242, 40)
        ComboBoxRecherche.TabIndex = 13
        ' 
        ' ListBoxNom
        ' 
        ListBoxNom.FormattingEnabled = True
        ListBoxNom.Location = New Point(23, 270)
        ListBoxNom.Name = "ListBoxNom"
        ListBoxNom.Size = New Size(148, 164)
        ListBoxNom.TabIndex = 15
        ' 
        ' ListBoxScore
        ' 
        ListBoxScore.FormattingEnabled = True
        ListBoxScore.Location = New Point(194, 270)
        ListBoxScore.Name = "ListBoxScore"
        ListBoxScore.Size = New Size(148, 164)
        ListBoxScore.TabIndex = 16
        ' 
        ' ListBoxTempsMin
        ' 
        ListBoxTempsMin.FormattingEnabled = True
        ListBoxTempsMin.Location = New Point(396, 270)
        ListBoxTempsMin.Name = "ListBoxTempsMin"
        ListBoxTempsMin.Size = New Size(148, 164)
        ListBoxTempsMin.TabIndex = 17
        ' 
        ' ListBoxNbParties
        ' 
        ListBoxNbParties.FormattingEnabled = True
        ListBoxNbParties.Location = New Point(592, 270)
        ListBoxNbParties.Name = "ListBoxNbParties"
        ListBoxNbParties.Size = New Size(148, 164)
        ListBoxNbParties.TabIndex = 18
        ' 
        ' ListBoxTempsTotal
        ' 
        ListBoxTempsTotal.FormattingEnabled = True
        ListBoxTempsTotal.Location = New Point(789, 270)
        ListBoxTempsTotal.Name = "ListBoxTempsTotal"
        ListBoxTempsTotal.Size = New Size(148, 164)
        ListBoxTempsTotal.TabIndex = 19
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 582)
        Controls.Add(ListBoxTempsTotal)
        Controls.Add(ListBoxNbParties)
        Controls.Add(ListBoxTempsMin)
        Controls.Add(ListBoxScore)
        Controls.Add(ListBoxNom)
        Controls.Add(ComboBoxRecherche)
        Controls.Add(BtnAfficher)
        Controls.Add(BtnFermer)
        Controls.Add(LabelTotal)
        Controls.Add(LabelParties)
        Controls.Add(LabelTemps)
        Controls.Add(LabelScore)
        Controls.Add(LabelNom)
        Controls.Add(Label1)
        Controls.Add(BtnTri)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnTri As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelNom As Label
    Friend WithEvents LabelScore As Label
    Friend WithEvents LabelTemps As Label
    Friend WithEvents LabelParties As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents BtnFermer As Button
    Friend WithEvents BtnAfficher As Button
    Friend WithEvents ComboBoxRecherche As ComboBox
    Friend WithEvents ListBoxNom As ListBox
    Friend WithEvents ListBoxScore As ListBox
    Friend WithEvents ListBoxTempsMin As ListBox
    Friend WithEvents ListBoxNbParties As ListBox
    Friend WithEvents ListBoxTempsTotal As ListBox
End Class
