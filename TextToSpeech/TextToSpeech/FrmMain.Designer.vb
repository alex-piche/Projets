<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.btnSpeak = New System.Windows.Forms.Button()
        Me.rctText = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btnSpeak
        '
        Me.btnSpeak.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSpeak.Location = New System.Drawing.Point(104, 226)
        Me.btnSpeak.Name = "btnSpeak"
        Me.btnSpeak.Size = New System.Drawing.Size(75, 23)
        Me.btnSpeak.TabIndex = 0
        Me.btnSpeak.Text = "Parler"
        Me.btnSpeak.UseVisualStyleBackColor = True
        '
        'rctText
        '
        Me.rctText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rctText.Location = New System.Drawing.Point(12, 12)
        Me.rctText.Name = "rctText"
        Me.rctText.Size = New System.Drawing.Size(260, 199)
        Me.rctText.TabIndex = 1
        Me.rctText.Text = ""
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.rctText)
        Me.Controls.Add(Me.btnSpeak)
        Me.Name = "FrmMain"
        Me.Text = "Voice Output"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSpeak As System.Windows.Forms.Button
    Friend WithEvents rctText As System.Windows.Forms.RichTextBox

End Class
