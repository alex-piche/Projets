<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCopie
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
        Me.btnGo = New System.Windows.Forms.Button()
        Me.txtSrc = New System.Windows.Forms.TextBox()
        Me.txtDst = New System.Windows.Forms.TextBox()
        Me.txtExt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(63, 101)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'txtSrc
        '
        Me.txtSrc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSrc.Location = New System.Drawing.Point(13, 13)
        Me.txtSrc.Name = "txtSrc"
        Me.txtSrc.Size = New System.Drawing.Size(170, 20)
        Me.txtSrc.TabIndex = 1
        '
        'txtDst
        '
        Me.txtDst.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDst.Location = New System.Drawing.Point(12, 39)
        Me.txtDst.Name = "txtDst"
        Me.txtDst.Size = New System.Drawing.Size(170, 20)
        Me.txtDst.TabIndex = 2
        '
        'txtExt
        '
        Me.txtExt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExt.Location = New System.Drawing.Point(12, 65)
        Me.txtExt.Name = "txtExt"
        Me.txtExt.Size = New System.Drawing.Size(170, 20)
        Me.txtExt.TabIndex = 3
        '
        'frmCopie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(195, 136)
        Me.Controls.Add(Me.txtExt)
        Me.Controls.Add(Me.txtDst)
        Me.Controls.Add(Me.txtSrc)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "frmCopie"
        Me.Text = "Copie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents txtSrc As System.Windows.Forms.TextBox
    Friend WithEvents txtDst As System.Windows.Forms.TextBox
    Friend WithEvents txtExt As System.Windows.Forms.TextBox

End Class
