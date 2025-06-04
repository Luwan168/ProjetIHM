<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAccueil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ComboBoxPrenom = New ComboBox()
        BtnQuitter = New Button()
        BtnJouer = New Button()
        LabelPrenom = New Label()
        BtnOption = New Button()
        BtnScore = New Button()
        SuspendLayout()
        ' 
        ' ComboBoxPrenom
        ' 
        ComboBoxPrenom.FormattingEnabled = True
        ComboBoxPrenom.Location = New Point(268, 55)
        ComboBoxPrenom.Margin = New Padding(6)
        ComboBoxPrenom.Name = "ComboBoxPrenom"
        ComboBoxPrenom.Size = New Size(221, 40)
        ComboBoxPrenom.TabIndex = 0
        ' 
        ' BtnQuitter
        ' 
        BtnQuitter.Location = New Point(307, 411)
        BtnQuitter.Margin = New Padding(6)
        BtnQuitter.Name = "BtnQuitter"
        BtnQuitter.Size = New Size(158, 62)
        BtnQuitter.TabIndex = 2
        BtnQuitter.Text = "Quitter"
        BtnQuitter.UseVisualStyleBackColor = True
        ' 
        ' BtnJouer
        ' 
        BtnJouer.Location = New Point(307, 117)
        BtnJouer.Margin = New Padding(6)
        BtnJouer.Name = "BtnJouer"
        BtnJouer.Size = New Size(158, 62)
        BtnJouer.TabIndex = 3
        BtnJouer.Text = "Jouer"
        BtnJouer.UseVisualStyleBackColor = True
        ' 
        ' LabelPrenom
        ' 
        LabelPrenom.AutoSize = True
        LabelPrenom.Location = New Point(45, 55)
        LabelPrenom.Margin = New Padding(6, 0, 6, 0)
        LabelPrenom.Name = "LabelPrenom"
        LabelPrenom.Size = New Size(233, 32)
        LabelPrenom.TabIndex = 4
        LabelPrenom.Text = "Entrez votre prénom"
        ' 
        ' BtnOption
        ' 
        BtnOption.Location = New Point(307, 215)
        BtnOption.Margin = New Padding(6)
        BtnOption.Name = "BtnOption"
        BtnOption.Size = New Size(158, 62)
        BtnOption.TabIndex = 5
        BtnOption.Text = "Options"
        BtnOption.UseVisualStyleBackColor = True
        ' 
        ' BtnScore
        ' 
        BtnScore.Location = New Point(307, 315)
        BtnScore.Margin = New Padding(6)
        BtnScore.Name = "BtnScore"
        BtnScore.Size = New Size(158, 62)
        BtnScore.TabIndex = 6
        BtnScore.Text = "Scores"
        BtnScore.UseVisualStyleBackColor = True
        ' 
        ' FormAccueil
        ' 
        AutoScaleDimensions = New SizeF(13.0F, 32.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(600, 521)
        Controls.Add(BtnScore)
        Controls.Add(BtnOption)
        Controls.Add(LabelPrenom)
        Controls.Add(BtnJouer)
        Controls.Add(BtnQuitter)
        Controls.Add(ComboBoxPrenom)
        Margin = New Padding(6)
        Name = "FormAccueil"
        Text = "Memory"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBoxPrenom As ComboBox
    Friend WithEvents BtnLancerPartie As Button
    Friend WithEvents BtnQuitter As Button
    Friend WithEvents BtnJouer As Button
    Friend WithEvents LabelPrenom As Label
    Friend WithEvents BtnOption As Button
    Friend WithEvents BtnScore As Button

End Class
