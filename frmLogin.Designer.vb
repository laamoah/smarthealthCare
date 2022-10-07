<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbxMax = New System.Windows.Forms.PictureBox()
        Me.pbxMin = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbxLogout = New System.Windows.Forms.PictureBox()
        Me.pnllog = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblcreat = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbUtype = New System.Windows.Forms.ComboBox()
        Me.pbxeye = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txtupass = New System.Windows.Forms.TextBox()
        Me.txtUid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAdm = New System.Windows.Forms.Button()
        Me.btnPat = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pbxMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnllog.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbxeye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pbxMax)
        Me.Panel1.Controls.Add(Me.pbxMin)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.pbxLogout)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(941, 38)
        Me.Panel1.TabIndex = 1
        '
        'pbxMax
        '
        Me.pbxMax.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pbxMax.BackgroundImage = Global.SmartHealthCare.My.Resources.Resources.max
        Me.pbxMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxMax.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxMax.Location = New System.Drawing.Point(848, 1)
        Me.pbxMax.Margin = New System.Windows.Forms.Padding(40)
        Me.pbxMax.Name = "pbxMax"
        Me.pbxMax.Size = New System.Drawing.Size(34, 38)
        Me.pbxMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxMax.TabIndex = 9
        Me.pbxMax.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbxMax, "Maximize")
        '
        'pbxMin
        '
        Me.pbxMin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pbxMin.BackgroundImage = Global.SmartHealthCare.My.Resources.Resources.mini
        Me.pbxMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxMin.Location = New System.Drawing.Point(803, 0)
        Me.pbxMin.Margin = New System.Windows.Forms.Padding(40)
        Me.pbxMin.Name = "pbxMin"
        Me.pbxMin.Size = New System.Drawing.Size(34, 38)
        Me.pbxMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxMin.TabIndex = 9
        Me.pbxMin.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbxMin, "Minimize")
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(296, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to Smart HealthCare"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbxLogout
        '
        Me.pbxLogout.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pbxLogout.BackgroundImage = CType(resources.GetObject("pbxLogout.BackgroundImage"), System.Drawing.Image)
        Me.pbxLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxLogout.Location = New System.Drawing.Point(893, 1)
        Me.pbxLogout.Margin = New System.Windows.Forms.Padding(40)
        Me.pbxLogout.Name = "pbxLogout"
        Me.pbxLogout.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.pbxLogout.Size = New System.Drawing.Size(34, 38)
        Me.pbxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLogout.TabIndex = 10
        Me.pbxLogout.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbxLogout, "Exit App")
        '
        'pnllog
        '
        Me.pnllog.BackColor = System.Drawing.Color.Transparent
        Me.pnllog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnllog.Controls.Add(Me.GroupBox1)
        Me.pnllog.Controls.Add(Me.TextBox1)
        Me.pnllog.Controls.Add(Me.Label2)
        Me.pnllog.Location = New System.Drawing.Point(43, 60)
        Me.pnllog.Name = "pnllog"
        Me.pnllog.Size = New System.Drawing.Size(347, 399)
        Me.pnllog.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblcreat)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbUtype)
        Me.GroupBox1.Controls.Add(Me.pbxeye)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.txtupass)
        Me.GroupBox1.Controls.Add(Me.txtUid)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnlogin)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(10, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 316)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Login"
        '
        'lblcreat
        '
        Me.lblcreat.AutoSize = True
        Me.lblcreat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblcreat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcreat.ForeColor = System.Drawing.Color.Yellow
        Me.lblcreat.Location = New System.Drawing.Point(191, 281)
        Me.lblcreat.Name = "lblcreat"
        Me.lblcreat.Size = New System.Drawing.Size(81, 17)
        Me.lblcreat.TabIndex = 5
        Me.lblcreat.Text = "Create New"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(47, 281)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Don't Have Account?"
        '
        'cmbUtype
        '
        Me.cmbUtype.BackColor = System.Drawing.Color.White
        Me.cmbUtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUtype.FormattingEnabled = True
        Me.cmbUtype.Items.AddRange(New Object() {"---Click to Select---", "Admin", "Patient"})
        Me.cmbUtype.Location = New System.Drawing.Point(103, 44)
        Me.cmbUtype.Name = "cmbUtype"
        Me.cmbUtype.Size = New System.Drawing.Size(213, 28)
        Me.cmbUtype.TabIndex = 4
        '
        'pbxeye
        '
        Me.pbxeye.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.pbxeye.BackgroundImage = Global.SmartHealthCare.My.Resources.Resources.eye
        Me.pbxeye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxeye.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxeye.Location = New System.Drawing.Point(288, 149)
        Me.pbxeye.Name = "pbxeye"
        Me.pbxeye.Size = New System.Drawing.Size(24, 23)
        Me.pbxeye.TabIndex = 3
        Me.pbxeye.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(7, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Password"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.Black
        Me.TextBox3.Location = New System.Drawing.Point(11, 201)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(300, 2)
        Me.TextBox3.TabIndex = 1
        '
        'txtupass
        '
        Me.txtupass.BackColor = System.Drawing.Color.White
        Me.txtupass.Enabled = False
        Me.txtupass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtupass.ForeColor = System.Drawing.Color.Black
        Me.txtupass.Location = New System.Drawing.Point(103, 147)
        Me.txtupass.Name = "txtupass"
        Me.txtupass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtupass.Size = New System.Drawing.Size(210, 26)
        Me.txtupass.TabIndex = 1
        '
        'txtUid
        '
        Me.txtUid.BackColor = System.Drawing.Color.White
        Me.txtUid.Enabled = False
        Me.txtUid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUid.ForeColor = System.Drawing.Color.Black
        Me.txtUid.Location = New System.Drawing.Point(103, 101)
        Me.txtUid.Name = "txtUid"
        Me.txtUid.Size = New System.Drawing.Size(213, 26)
        Me.txtUid.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(10, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "User Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "User ID"
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.Azure
        Me.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin.Enabled = False
        Me.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnlogin.FlatAppearance.BorderSize = 2
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnlogin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnlogin.Location = New System.Drawing.Point(68, 217)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(201, 34)
        Me.btnlogin.TabIndex = 0
        Me.btnlogin.Text = "LogIn"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(2, 50)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(342, 2)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(125, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 47)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "User"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RichTextBox1.Location = New System.Drawing.Point(500, 96)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(3, 3, 50, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(398, 381)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(677, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 33)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "About"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdm
        '
        Me.btnAdm.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnAdm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdm.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdm.ForeColor = System.Drawing.Color.SkyBlue
        Me.btnAdm.Location = New System.Drawing.Point(122, 220)
        Me.btnAdm.Name = "btnAdm"
        Me.btnAdm.Size = New System.Drawing.Size(201, 52)
        Me.btnAdm.TabIndex = 0
        Me.btnAdm.Text = "As Admin"
        Me.btnAdm.UseVisualStyleBackColor = False
        '
        'btnPat
        '
        Me.btnPat.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnPat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPat.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnPat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPat.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPat.ForeColor = System.Drawing.Color.SkyBlue
        Me.btnPat.Location = New System.Drawing.Point(122, 144)
        Me.btnPat.Name = "btnPat"
        Me.btnPat.Size = New System.Drawing.Size(201, 52)
        Me.btnPat.TabIndex = 0
        Me.btnPat.Text = "As  Patient"
        Me.btnPat.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.SmartHealthCare.My.Resources.Resources.digdoc
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(881, 497)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(941, 520)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.pnllog)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAdm)
        Me.Controls.Add(Me.btnPat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(957, 536)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Smart HealthCare--User Entry"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbxMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnllog.ResumeLayout(False)
        Me.pnllog.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbxeye, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnllog As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUid As TextBox
    Friend WithEvents txtupass As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents pbxMin As PictureBox
    Friend WithEvents pbxLogout As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pbxeye As PictureBox
    Friend WithEvents pbxMax As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAdm As Button
    Friend WithEvents btnPat As Button
    Friend WithEvents cmbUtype As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblcreat As Label
End Class
