<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.chkMerge = New System.Windows.Forms.CheckBox()
        Me.txtFile1 = New System.Windows.Forms.TextBox()
        Me.txtFile2 = New System.Windows.Forms.TextBox()
        Me.txtFile3 = New System.Windows.Forms.TextBox()
        Me.txtFile4 = New System.Windows.Forms.TextBox()
        Me.lblFile1 = New System.Windows.Forms.Label()
        Me.lblFile2 = New System.Windows.Forms.Label()
        Me.lblFile3 = New System.Windows.Forms.Label()
        Me.lblFile4 = New System.Windows.Forms.Label()
        Me.btnOuvrir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(15, 226)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(257, 23)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "Comparer/Merger"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'chkMerge
        '
        Me.chkMerge.AutoSize = True
        Me.chkMerge.Location = New System.Drawing.Point(115, 174)
        Me.chkMerge.Name = "chkMerge"
        Me.chkMerge.Size = New System.Drawing.Size(56, 17)
        Me.chkMerge.TabIndex = 1
        Me.chkMerge.Text = "Merge"
        Me.chkMerge.UseVisualStyleBackColor = True
        '
        'txtFile1
        '
        Me.txtFile1.Location = New System.Drawing.Point(12, 25)
        Me.txtFile1.Name = "txtFile1"
        Me.txtFile1.Size = New System.Drawing.Size(260, 20)
        Me.txtFile1.TabIndex = 2
        '
        'txtFile2
        '
        Me.txtFile2.Location = New System.Drawing.Point(12, 64)
        Me.txtFile2.Name = "txtFile2"
        Me.txtFile2.Size = New System.Drawing.Size(260, 20)
        Me.txtFile2.TabIndex = 3
        '
        'txtFile3
        '
        Me.txtFile3.Enabled = False
        Me.txtFile3.Location = New System.Drawing.Point(12, 103)
        Me.txtFile3.Name = "txtFile3"
        Me.txtFile3.Size = New System.Drawing.Size(260, 20)
        Me.txtFile3.TabIndex = 4
        '
        'txtFile4
        '
        Me.txtFile4.Enabled = False
        Me.txtFile4.Location = New System.Drawing.Point(12, 142)
        Me.txtFile4.Name = "txtFile4"
        Me.txtFile4.Size = New System.Drawing.Size(260, 20)
        Me.txtFile4.TabIndex = 5
        '
        'lblFile1
        '
        Me.lblFile1.AutoSize = True
        Me.lblFile1.Location = New System.Drawing.Point(12, 9)
        Me.lblFile1.Name = "lblFile1"
        Me.lblFile1.Size = New System.Drawing.Size(73, 13)
        Me.lblFile1.TabIndex = 6
        Me.lblFile1.Text = "Fichier Locale"
        '
        'lblFile2
        '
        Me.lblFile2.AutoSize = True
        Me.lblFile2.Location = New System.Drawing.Point(12, 48)
        Me.lblFile2.Name = "lblFile2"
        Me.lblFile2.Size = New System.Drawing.Size(74, 13)
        Me.lblFile2.TabIndex = 7
        Me.lblFile2.Text = "Fichier Distant"
        '
        'lblFile3
        '
        Me.lblFile3.AutoSize = True
        Me.lblFile3.Location = New System.Drawing.Point(12, 87)
        Me.lblFile3.Name = "lblFile3"
        Me.lblFile3.Size = New System.Drawing.Size(80, 13)
        Me.lblFile3.TabIndex = 8
        Me.lblFile3.Text = "Fichier de Base"
        '
        'lblFile4
        '
        Me.lblFile4.AutoSize = True
        Me.lblFile4.Location = New System.Drawing.Point(12, 126)
        Me.lblFile4.Name = "lblFile4"
        Me.lblFile4.Size = New System.Drawing.Size(109, 13)
        Me.lblFile4.TabIndex = 9
        Me.lblFile4.Text = "Fichier de Destination"
        '
        'btnOuvrir
        '
        Me.btnOuvrir.Location = New System.Drawing.Point(15, 197)
        Me.btnOuvrir.Name = "btnOuvrir"
        Me.btnOuvrir.Size = New System.Drawing.Size(257, 23)
        Me.btnOuvrir.TabIndex = 10
        Me.btnOuvrir.Text = "Ouvrir"
        Me.btnOuvrir.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnOuvrir)
        Me.Controls.Add(Me.lblFile4)
        Me.Controls.Add(Me.lblFile3)
        Me.Controls.Add(Me.lblFile2)
        Me.Controls.Add(Me.lblFile1)
        Me.Controls.Add(Me.txtFile4)
        Me.Controls.Add(Me.txtFile3)
        Me.Controls.Add(Me.txtFile2)
        Me.Controls.Add(Me.txtFile1)
        Me.Controls.Add(Me.chkMerge)
        Me.Controls.Add(Me.btnGo)
        Me.MaximumSize = New System.Drawing.Size(300, 300)
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "frmMain"
        Me.Text = "DiffMerge"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents chkMerge As System.Windows.Forms.CheckBox
    Friend WithEvents txtFile1 As System.Windows.Forms.TextBox
    Friend WithEvents txtFile2 As System.Windows.Forms.TextBox
    Friend WithEvents txtFile3 As System.Windows.Forms.TextBox
    Friend WithEvents txtFile4 As System.Windows.Forms.TextBox
    Friend WithEvents lblFile1 As System.Windows.Forms.Label
    Friend WithEvents lblFile2 As System.Windows.Forms.Label
    Friend WithEvents lblFile3 As System.Windows.Forms.Label
    Friend WithEvents lblFile4 As System.Windows.Forms.Label
    Friend WithEvents btnOuvrir As System.Windows.Forms.Button

End Class
