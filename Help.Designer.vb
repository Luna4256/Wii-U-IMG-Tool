<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Help))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.DimensionsPage = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.WhatsThis = New System.Windows.Forms.TabPage()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Legal = New System.Windows.Forms.TabPage()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.SrcCode = New System.Windows.Forms.TabPage()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.Checkmarks = New System.Windows.Forms.TabPage()
        Me.RichTextBox5 = New System.Windows.Forms.RichTextBox()
        Me.TabControl1.SuspendLayout()
        Me.DimensionsPage.SuspendLayout()
        Me.WhatsThis.SuspendLayout()
        Me.Legal.SuspendLayout()
        Me.SrcCode.SuspendLayout()
        Me.Checkmarks.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.DimensionsPage)
        Me.TabControl1.Controls.Add(Me.WhatsThis)
        Me.TabControl1.Controls.Add(Me.Checkmarks)
        Me.TabControl1.Controls.Add(Me.Legal)
        Me.TabControl1.Controls.Add(Me.SrcCode)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(431, 400)
        Me.TabControl1.TabIndex = 0
        '
        'DimensionsPage
        '
        Me.DimensionsPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.DimensionsPage.Controls.Add(Me.RichTextBox1)
        Me.DimensionsPage.Location = New System.Drawing.Point(4, 22)
        Me.DimensionsPage.Name = "DimensionsPage"
        Me.DimensionsPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DimensionsPage.Size = New System.Drawing.Size(423, 374)
        Me.DimensionsPage.TabIndex = 0
        Me.DimensionsPage.Text = "Dimensions"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.White
        Me.RichTextBox1.Location = New System.Drawing.Point(6, 6)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(411, 362)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = "iconTex = 128x128" & Global.Microsoft.VisualBasic.ChrW(10) & "bootDrcTex = 854x480" & Global.Microsoft.VisualBasic.ChrW(10) & "bootTvTex = 1280x720"
        '
        'WhatsThis
        '
        Me.WhatsThis.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.WhatsThis.Controls.Add(Me.RichTextBox2)
        Me.WhatsThis.Location = New System.Drawing.Point(4, 22)
        Me.WhatsThis.Name = "WhatsThis"
        Me.WhatsThis.Padding = New System.Windows.Forms.Padding(3)
        Me.WhatsThis.Size = New System.Drawing.Size(423, 374)
        Me.WhatsThis.TabIndex = 1
        Me.WhatsThis.Text = "What is this?"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.ForeColor = System.Drawing.Color.White
        Me.RichTextBox2.Location = New System.Drawing.Point(6, 6)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(411, 362)
        Me.RichTextBox2.TabIndex = 1
        Me.RichTextBox2.Text = "Wii U Image Tool is a program to convert images to Wii U compatible TGA files for" &
    " applications."
        '
        'Legal
        '
        Me.Legal.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Legal.Controls.Add(Me.RichTextBox3)
        Me.Legal.Location = New System.Drawing.Point(4, 22)
        Me.Legal.Name = "Legal"
        Me.Legal.Padding = New System.Windows.Forms.Padding(3)
        Me.Legal.Size = New System.Drawing.Size(423, 374)
        Me.Legal.TabIndex = 2
        Me.Legal.Text = "Legal"
        '
        'RichTextBox3
        '
        Me.RichTextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.RichTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox3.ForeColor = System.Drawing.Color.White
        Me.RichTextBox3.Location = New System.Drawing.Point(6, 6)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.ReadOnly = True
        Me.RichTextBox3.Size = New System.Drawing.Size(411, 362)
        Me.RichTextBox3.TabIndex = 2
        Me.RichTextBox3.Text = "This software isn't associated with Nintendo or Hatena in any ways, it is also no" &
    "n-profit, I don't make money from this project." & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "This software was created by Lu" &
    "na4256."
        '
        'SrcCode
        '
        Me.SrcCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.SrcCode.Controls.Add(Me.RichTextBox4)
        Me.SrcCode.Location = New System.Drawing.Point(4, 22)
        Me.SrcCode.Name = "SrcCode"
        Me.SrcCode.Padding = New System.Windows.Forms.Padding(3)
        Me.SrcCode.Size = New System.Drawing.Size(423, 374)
        Me.SrcCode.TabIndex = 3
        Me.SrcCode.Text = "Source code"
        '
        'RichTextBox4
        '
        Me.RichTextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.RichTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox4.ForeColor = System.Drawing.Color.White
        Me.RichTextBox4.Location = New System.Drawing.Point(6, 6)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.ReadOnly = True
        Me.RichTextBox4.Size = New System.Drawing.Size(411, 362)
        Me.RichTextBox4.TabIndex = 3
        Me.RichTextBox4.Text = "The source code can be found here: https://github.com/Luna4256/Wii-U-IMG-Tool" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Checkmarks
        '
        Me.Checkmarks.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Checkmarks.Controls.Add(Me.RichTextBox5)
        Me.Checkmarks.Location = New System.Drawing.Point(4, 22)
        Me.Checkmarks.Name = "Checkmarks"
        Me.Checkmarks.Padding = New System.Windows.Forms.Padding(3)
        Me.Checkmarks.Size = New System.Drawing.Size(423, 374)
        Me.Checkmarks.TabIndex = 4
        Me.Checkmarks.Text = "What are those checkmarks?"
        '
        'RichTextBox5
        '
        Me.RichTextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.RichTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox5.ForeColor = System.Drawing.Color.White
        Me.RichTextBox5.Location = New System.Drawing.Point(6, 6)
        Me.RichTextBox5.Name = "RichTextBox5"
        Me.RichTextBox5.ReadOnly = True
        Me.RichTextBox5.Size = New System.Drawing.Size(411, 362)
        Me.RichTextBox5.TabIndex = 2
        Me.RichTextBox5.Text = "The checkmarks are to choose which files to convert!"
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(455, 424)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(471, 463)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(471, 463)
        Me.Name = "Help"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help"
        Me.TabControl1.ResumeLayout(False)
        Me.DimensionsPage.ResumeLayout(False)
        Me.WhatsThis.ResumeLayout(False)
        Me.Legal.ResumeLayout(False)
        Me.SrcCode.ResumeLayout(False)
        Me.Checkmarks.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents DimensionsPage As TabPage
    Friend WithEvents WhatsThis As TabPage
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Legal As TabPage
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents SrcCode As TabPage
    Friend WithEvents RichTextBox4 As RichTextBox
    Friend WithEvents Checkmarks As TabPage
    Friend WithEvents RichTextBox5 As RichTextBox
End Class
