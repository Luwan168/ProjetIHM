<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOption
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
        BtnValider = New Button()
        BtnAnnuler = New Button()
        LabelTemps = New Label()
        GroupBoxTheme = New GroupBox()
        RadioClair = New RadioButton()
        RadioSombre = New RadioButton()
        GroupBoxDos = New GroupBox()
        RadioDos1 = New RadioButton()
        RadioDos2 = New RadioButton()
        RadioDos3 = New RadioButton()
        ComboTemps = New ComboBox()
        PicturePreview = New PictureBox()
        GroupBoxTheme.SuspendLayout()
        GroupBoxDos.SuspendLayout()
        CType(PicturePreview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnValider
        ' 
        BtnValider.Location = New Point(262, 646)
        BtnValider.Name = "BtnValider"
        BtnValider.Size = New Size(150, 46)
        BtnValider.TabIndex = 0
        BtnValider.Text = "Valider"
        BtnValider.UseVisualStyleBackColor = True
        ' 
        ' BtnAnnuler
        ' 
        BtnAnnuler.Location = New Point(524, 646)
        BtnAnnuler.Name = "BtnAnnuler"
        BtnAnnuler.Size = New Size(150, 46)
        BtnAnnuler.TabIndex = 1
        BtnAnnuler.Text = "Fermer"
        BtnAnnuler.UseVisualStyleBackColor = True
        ' 
        ' LabelTemps
        ' 
        LabelTemps.AutoSize = True
        LabelTemps.Location = New Point(52, 302)
        LabelTemps.Name = "LabelTemps"
        LabelTemps.Size = New Size(329, 32)
        LabelTemps.TabIndex = 2
        LabelTemps.Text = "Temps impartie ( en seconde)"
        ' 
        ' GroupBoxTheme
        ' 
        GroupBoxTheme.Controls.Add(RadioClair)
        GroupBoxTheme.Controls.Add(RadioSombre)
        GroupBoxTheme.Location = New Point(42, 38)
        GroupBoxTheme.Name = "GroupBoxTheme"
        GroupBoxTheme.Size = New Size(400, 200)
        GroupBoxTheme.TabIndex = 4
        GroupBoxTheme.TabStop = False
        GroupBoxTheme.Text = "Theme de l application"
        ' 
        ' RadioClair
        ' 
        RadioClair.AutoSize = True
        RadioClair.Location = New Point(42, 61)
        RadioClair.Name = "RadioClair"
        RadioClair.Size = New Size(92, 36)
        RadioClair.TabIndex = 6
        RadioClair.TabStop = True
        RadioClair.Text = "Clair"
        RadioClair.UseVisualStyleBackColor = True
        ' 
        ' RadioSombre
        ' 
        RadioSombre.AutoSize = True
        RadioSombre.Location = New Point(42, 129)
        RadioSombre.Name = "RadioSombre"
        RadioSombre.Size = New Size(120, 36)
        RadioSombre.TabIndex = 7
        RadioSombre.TabStop = True
        RadioSombre.Text = "Obscur"
        RadioSombre.UseVisualStyleBackColor = True
        ' 
        ' GroupBoxDos
        ' 
        GroupBoxDos.Controls.Add(RadioDos1)
        GroupBoxDos.Controls.Add(RadioDos2)
        GroupBoxDos.Controls.Add(RadioDos3)
        GroupBoxDos.Location = New Point(42, 381)
        GroupBoxDos.Name = "GroupBoxDos"
        GroupBoxDos.Size = New Size(400, 200)
        GroupBoxDos.TabIndex = 4
        GroupBoxDos.TabStop = False
        GroupBoxDos.Text = "Cartes"
        ' 
        ' RadioDos1
        ' 
        RadioDos1.AutoSize = True
        RadioDos1.Location = New Point(32, 48)
        RadioDos1.Name = "RadioDos1"
        RadioDos1.Size = New Size(125, 36)
        RadioDos1.TabIndex = 7
        RadioDos1.TabStop = True
        RadioDos1.Text = "Choix 1"
        RadioDos1.UseVisualStyleBackColor = True
        ' 
        ' RadioDos2
        ' 
        RadioDos2.AutoSize = True
        RadioDos2.Location = New Point(32, 101)
        RadioDos2.Name = "RadioDos2"
        RadioDos2.Size = New Size(125, 36)
        RadioDos2.TabIndex = 8
        RadioDos2.TabStop = True
        RadioDos2.Text = "Choix 2"
        RadioDos2.UseVisualStyleBackColor = True
        ' 
        ' RadioDos3
        ' 
        RadioDos3.AutoSize = True
        RadioDos3.Location = New Point(32, 158)
        RadioDos3.Name = "RadioDos3"
        RadioDos3.Size = New Size(125, 36)
        RadioDos3.TabIndex = 9
        RadioDos3.TabStop = True
        RadioDos3.Text = "Choix 3"
        RadioDos3.UseVisualStyleBackColor = True
        ' 
        ' ComboTemps
        ' 
        ComboTemps.FormattingEnabled = True
        ComboTemps.Location = New Point(448, 302)
        ComboTemps.Name = "ComboTemps"
        ComboTemps.Size = New Size(242, 40)
        ComboTemps.TabIndex = 5
        ' 
        ' PicturePreview
        ' 
        PicturePreview.Location = New Point(503, 394)
        PicturePreview.Name = "PicturePreview"
        PicturePreview.Size = New Size(187, 234)
        PicturePreview.TabIndex = 6
        PicturePreview.TabStop = False
        ' 
        ' FormOption
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(785, 804)
        Controls.Add(PicturePreview)
        Controls.Add(ComboTemps)
        Controls.Add(GroupBoxDos)
        Controls.Add(GroupBoxTheme)
        Controls.Add(LabelTemps)
        Controls.Add(BtnAnnuler)
        Controls.Add(BtnValider)
        Name = "FormOption"
        Text = "Form1"
        GroupBoxTheme.ResumeLayout(False)
        GroupBoxTheme.PerformLayout()
        GroupBoxDos.ResumeLayout(False)
        GroupBoxDos.PerformLayout()
        CType(PicturePreview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnValider As Button
    Friend WithEvents BtnAnnuler As Button
    Friend WithEvents LabelTemps As Label
    Friend WithEvents GroupBoxTheme As GroupBox
    Friend WithEvents RadioClair As RadioButton
    Friend WithEvents RadioSombre As RadioButton
    Friend WithEvents GroupBoxDos As GroupBox
    Friend WithEvents RadioDos1 As RadioButton
    Friend WithEvents RadioDos2 As RadioButton
    Friend WithEvents RadioDos3 As RadioButton
    Friend WithEvents ComboTemps As ComboBox
    Friend WithEvents PicturePreview As PictureBox
End Class
