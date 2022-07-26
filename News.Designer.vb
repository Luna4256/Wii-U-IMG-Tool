<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class News
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(News))
        Me.newsRich = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'newsRich
        '
        Me.newsRich.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.newsRich.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.newsRich.Dock = System.Windows.Forms.DockStyle.Fill
        Me.newsRich.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newsRich.ForeColor = System.Drawing.Color.White
        Me.newsRich.Location = New System.Drawing.Point(0, 0)
        Me.newsRich.Name = "newsRich"
        Me.newsRich.ReadOnly = True
        Me.newsRich.Size = New System.Drawing.Size(428, 428)
        Me.newsRich.TabIndex = 4
        Me.newsRich.Text = "There was an error loading the news!"
        '
        'News
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(428, 428)
        Me.Controls.Add(Me.newsRich)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(444, 467)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(444, 467)
        Me.Name = "News"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "News"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents newsRich As RichTextBox
End Class
