<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApptmt
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbxLogout = New System.Windows.Forms.PictureBox()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMsgCount = New System.Windows.Forms.Label()
        Me.rtbMessage = New System.Windows.Forms.RichTextBox()
        Me.dtpBDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblPname = New System.Windows.Forms.Label()
        Me.lblPgend = New System.Windows.Forms.Label()
        Me.lblPbirth = New System.Windows.Forms.Label()
        Me.lblPtel = New System.Windows.Forms.Label()
        Me.lblPLoc = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmbBTH = New System.Windows.Forms.ComboBox()
        Me.cmbBTM = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblProvidername = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblprovidertel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pbxLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.pbxLogout)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(-8, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(462, 38)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(29, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(370, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Smart HealthCare --- Appointment Booking"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbxLogout
        '
        Me.pbxLogout.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pbxLogout.BackgroundImage = Global.SmartHealthCare.My.Resources.Resources.close
        Me.pbxLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxLogout.Location = New System.Drawing.Point(428, 1)
        Me.pbxLogout.Margin = New System.Windows.Forms.Padding(40)
        Me.pbxLogout.Name = "pbxLogout"
        Me.pbxLogout.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.pbxLogout.Size = New System.Drawing.Size(24, 28)
        Me.pbxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLogout.TabIndex = 10
        Me.pbxLogout.TabStop = False
        '
        'btnBook
        '
        Me.btnBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBook.Enabled = False
        Me.btnBook.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBook.FlatAppearance.BorderSize = 2
        Me.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBook.ForeColor = System.Drawing.Color.White
        Me.btnBook.Image = Global.SmartHealthCare.My.Resources.Resources.chk
        Me.btnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBook.Location = New System.Drawing.Point(140, 487)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(154, 44)
        Me.btnBook.TabIndex = 7
        Me.btnBook.Text = "Book"
        Me.btnBook.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(4, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Health Provider"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "2.  Visitation Time"
        '
        'lblMsgCount
        '
        Me.lblMsgCount.AutoSize = True
        Me.lblMsgCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsgCount.ForeColor = System.Drawing.Color.Yellow
        Me.lblMsgCount.Location = New System.Drawing.Point(191, 162)
        Me.lblMsgCount.Name = "lblMsgCount"
        Me.lblMsgCount.Size = New System.Drawing.Size(0, 18)
        Me.lblMsgCount.TabIndex = 8
        '
        'rtbMessage
        '
        Me.rtbMessage.Enabled = False
        Me.rtbMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbMessage.Location = New System.Drawing.Point(5, 182)
        Me.rtbMessage.MaxLength = 200
        Me.rtbMessage.Name = "rtbMessage"
        Me.rtbMessage.Size = New System.Drawing.Size(418, 84)
        Me.rtbMessage.TabIndex = 9
        Me.rtbMessage.Text = ""
        '
        'dtpBDate
        '
        Me.dtpBDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBDate.Location = New System.Drawing.Point(150, 74)
        Me.dtpBDate.Name = "dtpBDate"
        Me.dtpBDate.Size = New System.Drawing.Size(201, 26)
        Me.dtpBDate.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(8, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(8, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Gender"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(6, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Telephone"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(6, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Birth Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(11, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 20)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Visitation Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblPLoc)
        Me.GroupBox1.Controls.Add(Me.lblPtel)
        Me.GroupBox1.Controls.Add(Me.lblPbirth)
        Me.GroupBox1.Controls.Add(Me.lblPgend)
        Me.GroupBox1.Controls.Add(Me.lblPname)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 146)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Your Info"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(6, 118)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 20)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Location"
        '
        'lblPname
        '
        Me.lblPname.AutoSize = True
        Me.lblPname.BackColor = System.Drawing.Color.Transparent
        Me.lblPname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPname.ForeColor = System.Drawing.Color.Black
        Me.lblPname.Location = New System.Drawing.Point(138, 26)
        Me.lblPname.Name = "lblPname"
        Me.lblPname.Size = New System.Drawing.Size(193, 20)
        Me.lblPname.TabIndex = 8
        Me.lblPname.Text = ".............................................."
        '
        'lblPgend
        '
        Me.lblPgend.AutoSize = True
        Me.lblPgend.BackColor = System.Drawing.Color.Transparent
        Me.lblPgend.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPgend.ForeColor = System.Drawing.Color.Black
        Me.lblPgend.Location = New System.Drawing.Point(138, 49)
        Me.lblPgend.Name = "lblPgend"
        Me.lblPgend.Size = New System.Drawing.Size(193, 20)
        Me.lblPgend.TabIndex = 8
        Me.lblPgend.Text = ".............................................."
        '
        'lblPbirth
        '
        Me.lblPbirth.AutoSize = True
        Me.lblPbirth.BackColor = System.Drawing.Color.Transparent
        Me.lblPbirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPbirth.ForeColor = System.Drawing.Color.Black
        Me.lblPbirth.Location = New System.Drawing.Point(138, 72)
        Me.lblPbirth.Name = "lblPbirth"
        Me.lblPbirth.Size = New System.Drawing.Size(193, 20)
        Me.lblPbirth.TabIndex = 8
        Me.lblPbirth.Text = ".............................................."
        '
        'lblPtel
        '
        Me.lblPtel.AutoSize = True
        Me.lblPtel.BackColor = System.Drawing.Color.Transparent
        Me.lblPtel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtel.ForeColor = System.Drawing.Color.Black
        Me.lblPtel.Location = New System.Drawing.Point(138, 95)
        Me.lblPtel.Name = "lblPtel"
        Me.lblPtel.Size = New System.Drawing.Size(193, 20)
        Me.lblPtel.TabIndex = 8
        Me.lblPtel.Text = ".............................................."
        '
        'lblPLoc
        '
        Me.lblPLoc.AutoSize = True
        Me.lblPLoc.BackColor = System.Drawing.Color.Transparent
        Me.lblPLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPLoc.ForeColor = System.Drawing.Color.Black
        Me.lblPLoc.Location = New System.Drawing.Point(138, 118)
        Me.lblPLoc.Name = "lblPLoc"
        Me.lblPLoc.Size = New System.Drawing.Size(193, 20)
        Me.lblPLoc.TabIndex = 8
        Me.lblPLoc.Text = ".............................................."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblMsgCount)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.dtpBDate)
        Me.GroupBox2.Controls.Add(Me.rtbMessage)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.lblprovidertel)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblProvidername)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(7, 207)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(430, 272)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Appointment Details"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Gold
        Me.Label17.Location = New System.Drawing.Point(39, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(23, 17)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Hr"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Gold
        Me.Label18.Location = New System.Drawing.Point(136, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 17)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Min"
        '
        'cmbBTH
        '
        Me.cmbBTH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBTH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBTH.FormattingEnabled = True
        Me.cmbBTH.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.cmbBTH.Location = New System.Drawing.Point(8, 17)
        Me.cmbBTH.Name = "cmbBTH"
        Me.cmbBTH.Size = New System.Drawing.Size(100, 28)
        Me.cmbBTH.TabIndex = 11
        '
        'cmbBTM
        '
        Me.cmbBTM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBTM.Enabled = False
        Me.cmbBTM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBTM.FormattingEnabled = True
        Me.cmbBTM.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.cmbBTM.Location = New System.Drawing.Point(109, 17)
        Me.cmbBTM.Name = "cmbBTM"
        Me.cmbBTM.Size = New System.Drawing.Size(100, 28)
        Me.cmbBTM.TabIndex = 11
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(3, 81)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(138, 20)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "1.   Visitation Date"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmbBTM)
        Me.Panel2.Controls.Add(Me.cmbBTH)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Location = New System.Drawing.Point(142, 106)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(214, 52)
        Me.Panel2.TabIndex = 12
        '
        'lblProvidername
        '
        Me.lblProvidername.AutoSize = True
        Me.lblProvidername.BackColor = System.Drawing.Color.Transparent
        Me.lblProvidername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProvidername.ForeColor = System.Drawing.Color.Black
        Me.lblProvidername.Location = New System.Drawing.Point(153, 22)
        Me.lblProvidername.Name = "lblProvidername"
        Me.lblProvidername.Size = New System.Drawing.Size(239, 20)
        Me.lblProvidername.TabIndex = 8
        Me.lblProvidername.Text = ".............................................."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(4, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Provider Tel."
        '
        'lblprovidertel
        '
        Me.lblprovidertel.AutoSize = True
        Me.lblprovidertel.BackColor = System.Drawing.Color.Transparent
        Me.lblprovidertel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprovidertel.ForeColor = System.Drawing.Color.Black
        Me.lblprovidertel.Location = New System.Drawing.Point(153, 46)
        Me.lblprovidertel.Name = "lblprovidertel"
        Me.lblprovidertel.Size = New System.Drawing.Size(239, 20)
        Me.lblprovidertel.TabIndex = 8
        Me.lblprovidertel.Text = ".............................................."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(7, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "3.  Short Message Here.   "
        '
        'frmApptmt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(446, 541)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmApptmt"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmApptmt"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbxLogout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pbxLogout As PictureBox
    Friend WithEvents btnBook As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMsgCount As Label
    Friend WithEvents rtbMessage As RichTextBox
    Friend WithEvents dtpBDate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lblPLoc As Label
    Friend WithEvents lblPtel As Label
    Friend WithEvents lblPbirth As Label
    Friend WithEvents lblPgend As Label
    Friend WithEvents lblPname As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbBTM As ComboBox
    Friend WithEvents cmbBTH As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents lblProvidername As Label
    Friend WithEvents lblprovidertel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
End Class
