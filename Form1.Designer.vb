<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.iconTexOpen = New System.Windows.Forms.Button()
        Me.iconTexSection = New System.Windows.Forms.GroupBox()
        Me.iconTexPreview = New System.Windows.Forms.PictureBox()
        Me.iconTex = New System.Windows.Forms.OpenFileDialog()
        Me.bootDrcTexSection = New System.Windows.Forms.GroupBox()
        Me.bootDrcTexPreview = New System.Windows.Forms.PictureBox()
        Me.bootDrcTexOpen = New System.Windows.Forms.Button()
        Me.bootDrcTex = New System.Windows.Forms.OpenFileDialog()
        Me.bootTvTexSection = New System.Windows.Forms.GroupBox()
        Me.bootTvTexPreview = New System.Windows.Forms.PictureBox()
        Me.bootTvTexOpen = New System.Windows.Forms.Button()
        Me.bootTvTex = New System.Windows.Forms.OpenFileDialog()
        Me.convertBtn = New System.Windows.Forms.Button()
        Me.helpBtn = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.statusTxt = New System.Windows.Forms.Label()
        Me.checkUpdatesBTN = New System.Windows.Forms.Button()
        Me.newsBtn = New System.Windows.Forms.Button()
        Me.iconTexSection.SuspendLayout()
        CType(Me.iconTexPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bootDrcTexSection.SuspendLayout()
        CType(Me.bootDrcTexPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bootTvTexSection.SuspendLayout()
        CType(Me.bootTvTexPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'iconTexOpen
        '
        Me.iconTexOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.iconTexOpen.FlatAppearance.BorderSize = 0
        Me.iconTexOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iconTexOpen.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iconTexOpen.ForeColor = System.Drawing.Color.White
        Me.iconTexOpen.Location = New System.Drawing.Point(11, 17)
        Me.iconTexOpen.Name = "iconTexOpen"
        Me.iconTexOpen.Size = New System.Drawing.Size(66, 30)
        Me.iconTexOpen.TabIndex = 0
        Me.iconTexOpen.Text = "Open"
        Me.iconTexOpen.UseVisualStyleBackColor = False
        '
        'iconTexSection
        '
        Me.iconTexSection.Controls.Add(Me.iconTexPreview)
        Me.iconTexSection.Controls.Add(Me.iconTexOpen)
        Me.iconTexSection.ForeColor = System.Drawing.Color.White
        Me.iconTexSection.Location = New System.Drawing.Point(12, 7)
        Me.iconTexSection.Name = "iconTexSection"
        Me.iconTexSection.Size = New System.Drawing.Size(196, 127)
        Me.iconTexSection.TabIndex = 1
        Me.iconTexSection.TabStop = False
        Me.iconTexSection.Text = "iconTex"
        '
        'iconTexPreview
        '
        Me.iconTexPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.iconTexPreview.Location = New System.Drawing.Point(83, 17)
        Me.iconTexPreview.Name = "iconTexPreview"
        Me.iconTexPreview.Size = New System.Drawing.Size(98, 98)
        Me.iconTexPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iconTexPreview.TabIndex = 1
        Me.iconTexPreview.TabStop = False
        '
        'iconTex
        '
        Me.iconTex.Title = "Open your iconTex file."
        '
        'bootDrcTexSection
        '
        Me.bootDrcTexSection.Controls.Add(Me.bootDrcTexPreview)
        Me.bootDrcTexSection.Controls.Add(Me.bootDrcTexOpen)
        Me.bootDrcTexSection.ForeColor = System.Drawing.Color.White
        Me.bootDrcTexSection.Location = New System.Drawing.Point(214, 7)
        Me.bootDrcTexSection.Name = "bootDrcTexSection"
        Me.bootDrcTexSection.Size = New System.Drawing.Size(322, 156)
        Me.bootDrcTexSection.TabIndex = 2
        Me.bootDrcTexSection.TabStop = False
        Me.bootDrcTexSection.Text = "bootDrcTex"
        '
        'bootDrcTexPreview
        '
        Me.bootDrcTexPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.bootDrcTexPreview.Location = New System.Drawing.Point(83, 17)
        Me.bootDrcTexPreview.Name = "bootDrcTexPreview"
        Me.bootDrcTexPreview.Size = New System.Drawing.Size(224, 126)
        Me.bootDrcTexPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bootDrcTexPreview.TabIndex = 1
        Me.bootDrcTexPreview.TabStop = False
        '
        'bootDrcTexOpen
        '
        Me.bootDrcTexOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.bootDrcTexOpen.FlatAppearance.BorderSize = 0
        Me.bootDrcTexOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bootDrcTexOpen.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bootDrcTexOpen.ForeColor = System.Drawing.Color.White
        Me.bootDrcTexOpen.Location = New System.Drawing.Point(11, 17)
        Me.bootDrcTexOpen.Name = "bootDrcTexOpen"
        Me.bootDrcTexOpen.Size = New System.Drawing.Size(66, 30)
        Me.bootDrcTexOpen.TabIndex = 0
        Me.bootDrcTexOpen.Text = "Open"
        Me.bootDrcTexOpen.UseVisualStyleBackColor = False
        '
        'bootDrcTex
        '
        Me.bootDrcTex.Title = "Open your bootDrcTex file."
        '
        'bootTvTexSection
        '
        Me.bootTvTexSection.Controls.Add(Me.bootTvTexPreview)
        Me.bootTvTexSection.Controls.Add(Me.bootTvTexOpen)
        Me.bootTvTexSection.ForeColor = System.Drawing.Color.White
        Me.bootTvTexSection.Location = New System.Drawing.Point(542, 7)
        Me.bootTvTexSection.Name = "bootTvTexSection"
        Me.bootTvTexSection.Size = New System.Drawing.Size(402, 201)
        Me.bootTvTexSection.TabIndex = 3
        Me.bootTvTexSection.TabStop = False
        Me.bootTvTexSection.Text = "bootTvTex"
        '
        'bootTvTexPreview
        '
        Me.bootTvTexPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.bootTvTexPreview.Location = New System.Drawing.Point(83, 17)
        Me.bootTvTexPreview.Name = "bootTvTexPreview"
        Me.bootTvTexPreview.Size = New System.Drawing.Size(306, 172)
        Me.bootTvTexPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bootTvTexPreview.TabIndex = 1
        Me.bootTvTexPreview.TabStop = False
        '
        'bootTvTexOpen
        '
        Me.bootTvTexOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.bootTvTexOpen.FlatAppearance.BorderSize = 0
        Me.bootTvTexOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bootTvTexOpen.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bootTvTexOpen.ForeColor = System.Drawing.Color.White
        Me.bootTvTexOpen.Location = New System.Drawing.Point(11, 17)
        Me.bootTvTexOpen.Name = "bootTvTexOpen"
        Me.bootTvTexOpen.Size = New System.Drawing.Size(66, 30)
        Me.bootTvTexOpen.TabIndex = 0
        Me.bootTvTexOpen.Text = "Open"
        Me.bootTvTexOpen.UseVisualStyleBackColor = False
        '
        'bootTvTex
        '
        Me.bootTvTex.Title = "Open your bootTvTex file."
        '
        'convertBtn
        '
        Me.convertBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.convertBtn.FlatAppearance.BorderSize = 0
        Me.convertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.convertBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.convertBtn.ForeColor = System.Drawing.Color.White
        Me.convertBtn.Location = New System.Drawing.Point(12, 214)
        Me.convertBtn.Name = "convertBtn"
        Me.convertBtn.Size = New System.Drawing.Size(932, 57)
        Me.convertBtn.TabIndex = 2
        Me.convertBtn.Text = "Convert!"
        Me.convertBtn.UseVisualStyleBackColor = False
        '
        'helpBtn
        '
        Me.helpBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.helpBtn.FlatAppearance.BorderSize = 0
        Me.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.helpBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helpBtn.ForeColor = System.Drawing.Color.White
        Me.helpBtn.Location = New System.Drawing.Point(12, 276)
        Me.helpBtn.Name = "helpBtn"
        Me.helpBtn.Size = New System.Drawing.Size(243, 26)
        Me.helpBtn.TabIndex = 4
        Me.helpBtn.Text = "Help"
        Me.helpBtn.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 309)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(932, 10)
        Me.ProgressBar1.TabIndex = 5
        '
        'statusTxt
        '
        Me.statusTxt.AutoSize = True
        Me.statusTxt.ForeColor = System.Drawing.Color.LightCoral
        Me.statusTxt.Location = New System.Drawing.Point(9, 322)
        Me.statusTxt.Name = "statusTxt"
        Me.statusTxt.Size = New System.Drawing.Size(171, 13)
        Me.statusTxt.TabIndex = 6
        Me.statusTxt.Text = "Files have not been converted yet."
        '
        'checkUpdatesBTN
        '
        Me.checkUpdatesBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.checkUpdatesBTN.FlatAppearance.BorderSize = 0
        Me.checkUpdatesBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkUpdatesBTN.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkUpdatesBTN.ForeColor = System.Drawing.Color.White
        Me.checkUpdatesBTN.Location = New System.Drawing.Point(261, 276)
        Me.checkUpdatesBTN.Name = "checkUpdatesBTN"
        Me.checkUpdatesBTN.Size = New System.Drawing.Size(434, 26)
        Me.checkUpdatesBTN.TabIndex = 7
        Me.checkUpdatesBTN.Text = "Check for updates"
        Me.checkUpdatesBTN.UseVisualStyleBackColor = False
        '
        'newsBtn
        '
        Me.newsBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.newsBtn.FlatAppearance.BorderSize = 0
        Me.newsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newsBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newsBtn.ForeColor = System.Drawing.Color.White
        Me.newsBtn.Location = New System.Drawing.Point(701, 276)
        Me.newsBtn.Name = "newsBtn"
        Me.newsBtn.Size = New System.Drawing.Size(243, 26)
        Me.newsBtn.TabIndex = 8
        Me.newsBtn.Text = "News"
        Me.newsBtn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(956, 342)
        Me.Controls.Add(Me.newsBtn)
        Me.Controls.Add(Me.checkUpdatesBTN)
        Me.Controls.Add(Me.statusTxt)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.helpBtn)
        Me.Controls.Add(Me.convertBtn)
        Me.Controls.Add(Me.bootTvTexSection)
        Me.Controls.Add(Me.bootDrcTexSection)
        Me.Controls.Add(Me.iconTexSection)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(972, 381)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(972, 381)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wii U Image Tool"
        Me.iconTexSection.ResumeLayout(False)
        CType(Me.iconTexPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bootDrcTexSection.ResumeLayout(False)
        CType(Me.bootDrcTexPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bootTvTexSection.ResumeLayout(False)
        CType(Me.bootTvTexPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents iconTexOpen As Button
    Friend WithEvents iconTexSection As GroupBox
    Friend WithEvents iconTexPreview As PictureBox
    Friend WithEvents iconTex As OpenFileDialog
    Friend WithEvents bootDrcTexSection As GroupBox
    Friend WithEvents bootDrcTexPreview As PictureBox
    Friend WithEvents bootDrcTexOpen As Button
    Friend WithEvents bootDrcTex As OpenFileDialog
    Friend WithEvents bootTvTexSection As GroupBox
    Friend WithEvents bootTvTexPreview As PictureBox
    Friend WithEvents bootTvTexOpen As Button
    Friend WithEvents bootTvTex As OpenFileDialog
    Friend WithEvents convertBtn As Button
    Friend WithEvents helpBtn As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents statusTxt As Label
    Friend WithEvents checkUpdatesBTN As Button
    Friend WithEvents newsBtn As Button
End Class
