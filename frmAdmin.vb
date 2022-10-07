Imports System.Data.OleDb
Imports System.Net
Imports System.Text.RegularExpressions
Public Class frmAdmin
    Dim hiddenID As String
    Private Sub lblManDis_Click(sender As Object, e As EventArgs) Handles lblManDis.Click, PictureBox5.Click
        pnlDis.BringToFront()
        pnlHosp.SendToBack()
        fillDisGgrid()
        BackColor = Color.LightSteelBlue
    End Sub

    Dim timerCount As Integer = 50
    Dim timerchk As Integer = 0
    Public Sub startTimer()
        Timer1.Interval = 500
        Timer1.Enabled = True
        Timer1.Start()
    End Sub
    Public Sub stopTimer()
        timerCount = 50
        Timer1.Enabled = False
        Timer1.Stop()
        timerchk = timerCount.ToString
    End Sub

    Public Sub fillDisGgrid()
        Try
            conCommand = New OleDbCommand("SELECT  DISTINCT disname FROM tbldissym", conDB)
            conDB.Close()
            conDB.Open()
            conReader = conCommand.ExecuteReader(CommandBehavior.CloseConnection)
            dgvDis.Rows.Clear()
            While conReader.Read
                dgvDis.Rows.Add((imgView), (imgDel), (imgEdit), conReader("disname"))
            End While
            dgvDis.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub fillHospGrid()
        Try
            conCommand = New OleDbCommand("SELECT hid,hname FROM tblhosp", conDB)
            conDB.Close()
            conDB.Open()
            conReader = conCommand.ExecuteReader(CommandBehavior.CloseConnection)
            dgvHosp.Rows.Clear()

            While conReader.Read
                dgvHosp.Rows.Add((imgView), (imgEdit), conReader("hid"), conReader("hname"))
            End While
            dgvHosp.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub editDis()
        Try
            conCommand = New OleDbCommand("UPDATE tbldissym SET disname=@disname WHERE disname='" & lbldisName.Text & "'", conDB)
            conDB.Close()
            conDB.Open()
            conCommand.Parameters.AddWithValue("@disname", frmEditDis.TextBox1.Text)
            If conCommand.ExecuteNonQuery() Then
                MessageBox.Show("Update Successfully Made")
                fillDisGgrid()
                dgvSym.Rows.Clear()
            Else
                MessageBox.Show("Sorry. Update Could Not be Made")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conDB.Close()
        End Try
    End Sub
    Private Sub lblManHosp_Click(sender As Object, e As EventArgs) Handles lblManHosp.Click, PictureBox4.Click
        pnlHosp.BringToFront()
        pnlDis.SendToBack()
        fillHospGrid()
        Me.BackColor = Color.Lavender
    End Sub

    Private Sub pbxMin_Click(sender As Object, e As EventArgs) Handles pbxMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pbxLogout_Click(sender As Object, e As EventArgs) Handles pbxLogout.Click
        frmLogin.Show()
        Hide()
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Try
            lblwhich.Text = "0"
            For Each txt As Control In grpaddHosp.Controls.OfType(Of TextBox)
                txt.Text = ""
                txt.Enabled = True
                txt.BackColor = Color.White
            Next
            btnSaveHosp.Enabled = True
            btnUpdateHosp.Enabled = False
            btnDelHosp.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conDB.Close()
        End Try
    End Sub


    Public Sub fillSymsGrid()
        Try
            conCommand = New OleDbCommand("SELECT  DISTINCT syms FROM tbldissym WHERE disname=@disname", conDB)
            conCommand.Parameters.AddWithValue("@disname", lblDis.Text)
            conDB.Close()
            conDB.Open()
            conReader = conCommand.ExecuteReader(CommandBehavior.CloseConnection)
            dgvSym.Rows.Clear()
            While conReader.Read
                dgvSym.Rows.Add((imgCancel), conReader("syms"))
            End While
            dgvSym.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub getHospInfo()
        Dim dbtable As New DataTable
        Dim conAdapter As OleDb.OleDbDataAdapter = New OleDbDataAdapter
        hiddenID = txthidname.Text
        'Try
        conDB.Close()
        conDB.Open()
        conCommand = New OleDbCommand("SELECT * FROM tblhosp WHERE hname=@hname", conDB)

        conCommand.Parameters.AddWithValue("@hname", txthidname.Text)

        conCommand.Connection = conDB
        conAdapter.SelectCommand = conCommand
        conAdapter.Fill(dbtable)
        txthname.Text = dbtable.Rows(0).Item(1).ToString
        txthloc.Text = dbtable.Rows(0).Item(2).ToString
        txthphone.Text = dbtable.Rows(0).Item(3).ToString
        txthsite.Text = dbtable.Rows(0).Item(4).ToString
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub
    Private Sub dgvHosp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHosp.CellClick
        'Try

        Dim row As DataGridViewRow
        row = dgvHosp.Rows(e.RowIndex)
        txthidname.Text = row.Cells(3).Value
        If e.RowIndex >= 0 Then
            row = dgvHosp.Rows(e.RowIndex)
            If e.ColumnIndex = 0 Then
                'txthidname.Text = row.Cells(3).Value
                For Each txt As Control In grpaddHosp.Controls.OfType(Of TextBox)
                    txt.Enabled = False
                    txt.BackColor = Color.White
                Next

                btnSaveHosp.Enabled = False
                btnUpdateHosp.Enabled = False
                btnDelHosp.Enabled = True

                getHospInfo()
                lblwhich.Text = 0
            ElseIf e.ColumnIndex = 1 Then
                For Each txt As Control In grpaddHosp.Controls.OfType(Of TextBox)
                    txt.Enabled = True
                    txt.BackColor = Color.White
                Next
                lblwhich.Text = 1

                btnSaveHosp.Enabled = False
                btnUpdateHosp.Enabled = True
                btnDelHosp.Enabled = True

                'txthidname.Text = row.Cells(3).Value
                getHospInfo()
            End If
        End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally
        '    conDB.Close()
        'End Try
    End Sub

    Private Sub btnUpdateHosp_Click(sender As Object, e As EventArgs) Handles btnUpdateHosp.Click
        Try
            Dim emptyTxt As Boolean = False
            For Each ctl As Control In grpaddHosp.Controls
                If ctl.Text.Length = 0 And TypeOf ctl Is TextBox Then
                    emptyTxt = True
                End If
            Next

            If emptyTxt Then
                MessageBox.Show("One or More REQUIRED Field(s) is Empty" & vbCrLf & "Check and Try Again",
                                "Smart HealthCare __________ Saving Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                For Each ctl As Control In grpaddHosp.Controls
                    If ctl.Text.Length = 0 And TypeOf ctl Is TextBox Then
                        ctl.BackColor = Color.Red
                    End If
                Next
            Else
                conCommand = New OleDbCommand("UPDATE tblhosp SET hname=@hname,hloc=@hloc,hphone=@hphone, hsite=@hsite WHERE hname ='" & txthidname.Text & "'", conDB)
                conDB.Close()
                conDB.Open()
                With conCommand.Parameters
                    .AddWithValue("@hname", txthname.Text)
                    .AddWithValue("@hloc", txthloc.Text)
                    .AddWithValue("@hphone", txthphone.Text)
                    .AddWithValue("@hsite", txthsite.Text)
                End With

                If conCommand.ExecuteNonQuery() Then
                    MessageBox.Show("Hospital Info Successfully Updated", "Record Update", MessageBoxButtons.OK,
                               MessageBoxIcon.Information)
                    fillHospGrid()
                    For Each txt As Control In grpaddHosp.Controls.OfType(Of TextBox)
                        txt.Enabled = False
                    Next
                    btnSaveHosp.Enabled = False
                    btnUpdateHosp.Enabled = False
                    btnDelHosp.Enabled = True
                Else
                    MessageBox.Show("Sorry, Record could Not be Updated", "Record Updating", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        fillHospGrid()
    End Sub

    Private Sub btnSaveHosp_Click(sender As Object, e As EventArgs) Handles btnSaveHosp.Click
        Try
            Dim emptyTxt As Boolean = False
            For Each ctl As Control In grpaddHosp.Controls
                If ctl.Text.Length = 0 And TypeOf ctl Is TextBox Then
                    emptyTxt = True
                End If
            Next

            If emptyTxt = True Then
                MessageBox.Show("One or More REQUIRED Field(s) is Empty" & vbCrLf & "Check and Try Again",
                                "Smart HealthCare __________ Saving Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                For Each ctl As Control In grpaddHosp.Controls
                    If ctl.Text.Length = 0 And TypeOf ctl Is TextBox Then
                        ctl.BackColor = Color.Red
                    End If
                Next
            Else
                conDB.Close()
                conDB.Open()

                conCommand = New OleDbCommand("INSERT INTO tblhosp(hname,hloc,hphone,hsite)
                                       VALUES(@hname,@hloc,@hphone,@hsite)", conDB)

                With conCommand.Parameters
                    .AddWithValue("@hname", txthname.Text)
                    .AddWithValue("@hloc", txthloc.Text)
                    .AddWithValue("@hphone", txthphone.Text)
                    .AddWithValue("@hsite", txthsite.Text)
                End With
                conDB.Close()
                conDB.Open()
                If conCommand.ExecuteNonQuery() Then
                    MessageBox.Show("Hospital Info Successfully Saved", "Record Saved", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information)
                    fillHospGrid()
                    btnSaveHosp.Enabled = False
                    For Each txt As Control In grpaddHosp.Controls.OfType(Of TextBox)
                        txt.Enabled = False
                        txt.Text = ""
                        txt.BackColor = Color.Wheat
                    Next
                Else
                    MessageBox.Show("Sorry, Record could Not be Saved", "Record Saving", MessageBoxButtons.OK,
                                    MessageBoxIcon.Hand)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDelHosp_Click(sender As Object, e As EventArgs) Handles btnDelHosp.Click
        Try
            If MessageBox.Show("Do You Really Wish to Delete This Hospital Info?", "Record Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                conDB.Close()
                conDB.Open()
                conCommand = New OleDbCommand("DELETE FROM tblhosp WHERE hname=@hname ", conDB)

                conCommand.Parameters.AddWithValue("@hname", txthidname.Text)

                If conCommand.ExecuteNonQuery() Then
                    MsgBox("                Hospital Info Successfully deleted")
                    fillHospGrid()
                    btnDelHosp.Enabled = False
                    btnUpdateHosp.Enabled = False
                    For Each txt As Control In grpaddHosp.Controls.OfType(Of TextBox)
                        txt.Enabled = False
                        txt.Text = ""
                    Next
                Else
                    MsgBox("           Hospital Info Could Not be deleted")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conDB.Close()
        End Try
    End Sub

    Private Sub btnAddNewDisSym_Click(sender As Object, e As EventArgs) Handles btnAddNewDisSym.Click
        Try
            cmbsyms.Enabled = True
            cmbdis.Enabled = True
            conDB.Close()
            conDB.Open()
            conCommand = New OleDbCommand("SELECT DISTINCT disname FROM tbldissym", conDB)
            conReader = conCommand.ExecuteReader(CommandBehavior.CloseConnection)
            cmbdis.Items.Clear()
            While conReader.Read
                cmbdis.Items.Add(conReader("disname"))
            End While
            cmbdis.Items.Add("---Add New Disease---")

            conDB.Close()
            conDB.Open()
            conCommand = New OleDbCommand("SELECT DISTINCT syms FROM tbldissym", conDB)
            conReader = conCommand.ExecuteReader(CommandBehavior.CloseConnection)
            cmbsyms.Items.Clear()
            While conReader.Read
                cmbsyms.Items.Add(conReader("syms"))
            End While
            cmbsyms.Items.Add("---Add New Symtom---")
            btnAddNewDisSym.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conDB.Close()
        End Try
    End Sub


    Private Sub cmbdis_DropDownClosed(sender As Object, e As EventArgs) Handles cmbdis.DropDownClosed
        If cmbdis.SelectedItem = "---Add New Disease---" Then
            cmbdis.DropDownStyle = ComboBoxStyle.DropDown
            cmbdis.ResetText()
        Else
            cmbdis.DropDownStyle = ComboBoxStyle.DropDownList
        End If
    End Sub

    Private Sub cmbsyms_DropDownClosed(sender As Object, e As EventArgs) Handles txthphone.TextChanged, cmbsyms.DropDownClosed
        If cmbsyms.SelectedItem = "---Add New Symtom---" Then
            cmbsyms.DropDownStyle = ComboBoxStyle.DropDown
            cmbsyms.ResetText()
        Else
            cmbsyms.DropDownStyle = ComboBoxStyle.DropDownList
        End If
    End Sub

    Private Sub cmbsyms_TextChanged(sender As Object, e As EventArgs) Handles cmbsyms.TextChanged, cmbdis.TextChanged
        If cmbdis.Text <> "" And cmbsyms.Text <> "" Then
            btnAddSel.Enabled = True
        Else
            btnAddSel.Enabled = False
        End If
    End Sub

    Private Sub btnAddSel_Click(sender As Object, e As EventArgs) Handles btnAddSel.Click
        dgvSelDisSyms.Rows.Add((imgCancel), (cmbdis.Text), (cmbsyms.Text))
        dgvSelDisSyms.ClearSelection()
        cmbsyms.ResetText()
        btnAddNewDisSym.Enabled = True
        cmbsyms.SelectedIndex = -1
    End Sub

    Private Sub dgvSelDisSyms_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvSelDisSyms.RowsAdded
        If dgvSelDisSyms.RowCount > 0 Then
            btnsaveDisSym.Enabled = True
        Else
            btnsaveDisSym.Enabled = False
        End If
    End Sub

    Private Sub dgvSelDisSyms_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvSelDisSyms.RowsRemoved
        If dgvSelDisSyms.RowCount > 0 Then
            btnsaveDisSym.Enabled = True
        Else
            btnsaveDisSym.Enabled = False
        End If
        If removeType = 2 Then
            MessageBox.Show("Disease and Symtom Added Successfully")
            dgvSelDisSyms.Rows.Clear()
        End If
    End Sub

    Private Sub dgvSelDisSyms_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSelDisSyms.CellClick
        Try
            Dim row As DataGridViewRow
            If e.RowIndex >= 0 Then
                row = dgvSelDisSyms.Rows(e.RowIndex)
                If e.ColumnIndex = 0 Then
                    removeType = 1
                    dgvSelDisSyms.Rows.Remove(dgvSelDisSyms.CurrentRow)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conDB.Close()
        End Try
    End Sub

    Private Sub btnsaveDisSym_Click(sender As Object, e As EventArgs) Handles btnsaveDisSym.Click
        Cursor = Cursors.AppStarting
        Try
            removeType = 2

            For Each row As DataGridViewRow In dgvSelDisSyms.Rows
                'If Not row.IsNewRow Then
                Dim disname = row.Cells(1).Value
                Dim sym = row.Cells(2).Value

                conCommand = New OleDbCommand("INSERT INTO tbldissym (disname,syms) VALUES(@disname,@syms)", conDB)

                With conCommand.Parameters
                    .AddWithValue("@disname", disname)
                    .AddWithValue("@syms", sym)
                End With
                'End If


                conDB.Close()
                conDB.Open()
                If conCommand.ExecuteNonQuery() Then
                    fillDisGgrid()
                    dgvSym.Rows.Clear()
                Else
                    MessageBox.Show("Sorry,Disease and Symtom Could Not be Added!")
                End If
            Next
            dgvSelDisSyms.Rows.Clear()
            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conDB.Close()
        End Try
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click, Label10.Click
        fillDisGgrid()
    End Sub

    Private Sub dgvDis_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDis.CellClick

        Try
            Dim row As DataGridViewRow
            If e.RowIndex >= 0 Then
                row = dgvDis.Rows(e.RowIndex)
                If e.ColumnIndex = 0 Then
                    lblDis.Text = row.Cells(3).Value
                    fillSymsGrid()

                ElseIf e.ColumnIndex = 1 Then
                    lbldisName.Text = row.Cells(3).Value
                    If MessageBox.Show("Are You Sure to Delete '" & lbldisName.Text & "' From the Diseases List ?" & vbNewLine &
                                       "NOTE: Items Delete Cannot be UNDONE!", "Smart HealthCare --- Confirm 
                                   Disease Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

                        conCommand = New OleDbCommand("DELETE FROM tbldissym WHERE disname=@disname ", conDB)
                        conCommand.Parameters.AddWithValue("@disname", lbldisName.Text)
                        conDB.Close()
                        conDB.Open()
                        If conCommand.ExecuteNonQuery() Then
                            MsgBox("                Disease Successfully deleted")
                            fillDisGgrid()
                            dgvSym.Rows.Clear()
                        Else
                            MsgBox("           Disease Info Could Not be deleted")
                            Me.Close()
                            Me.Dispose()
                        End If
                    End If
                ElseIf e.ColumnIndex = 2 Then
                    lbldisName.Text = row.Cells(3).Value
                    frmEditDis.ShowDialog()
                    frmEditDis.lblDisname.Text = "Input New Name for:  " & lbldisName.Text
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txthsite_TextChanged(sender As Object, e As EventArgs) Handles txthsite.TextChanged, txthloc.TextChanged,
                                                                               txthname.TextChanged, txthphone.TextChanged
        For Each ctl As Control In grpaddHosp.Controls
            If ctl.Text.Length <> 0 And TypeOf ctl Is TextBox And ctl.Focused Then
                ctl.BackColor = Color.White
            End If
        Next
    End Sub



    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    timerchk = timerCount.ToString
    '    timerCount -= 1

    '    If timerCount.ToString > 40 Then
    '        'lblHospList.ForeColor = Color.Black
    '        lbleva.Visible = True
    '    Else
    '        lbleva.Visible = False
    '    End If

    '    If timerCount.ToString = 0 Then

    '        stopTimer()
    '        timerCount = 50
    '        startTimer()
    '    End If
    'End Sub

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub dgvSym_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSym.CellClick
        Try
            Dim row As DataGridViewRow
            If e.RowIndex >= 0 Then
                row = dgvSym.Rows(e.RowIndex)
                If e.ColumnIndex = 0 Then
                    lblsyms.Text = row.Cells(1).Value

                    If MessageBox.Show("Are You Sure to Remove '" & lblsyms.Text & "' From Symtoms List of " & lblDis.Text & "?" & vbNewLine &
                                       "NOTE: Items Delete Cannot be UNDONE!", "Smart HealthCare --- Confirm 
                                   Symtom Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

                        conCommand = New OleDbCommand("DELETE FROM tbldissym WHERE disname=@disname AND syms=@syms", conDB)
                        conCommand.Parameters.AddWithValue("@disname", lblDis.Text)
                        conCommand.Parameters.AddWithValue("@syms", lblsyms.Text)
                        conDB.Close()
                        conDB.Open()
                        If conCommand.ExecuteNonQuery() Then
                            MsgBox("                Symtom Successfully Removed")
                            fillSymsGrid()
                        Else
                            MsgBox("           Symtom Could Not be Removed")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txthphone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txthphone.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            System.Media.SystemSounds.Asterisk.Play()
        End If
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Height = 35
        PictureBox2.Width = 35
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Height = 25
        PictureBox2.Width = 25
    End Sub

    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter, PictureBox6.MouseEnter
        PictureBox4.Size = New Size(40, 40)
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave, PictureBox6.MouseLeave
        PictureBox4.Size = New Size(31, 31)
    End Sub

    Private Sub PictureBox5_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox5.MouseEnter
        PictureBox5.Size = New Size(40, 40)
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.Size = New Size(31, 31)
    End Sub

    Private Sub pbxMax_Click(sender As Object, e As EventArgs) Handles pbxMax.Click
        If WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
            'pnllog.Location = New Point(43, 60)
        Else
            WindowState = FormWindowState.Maximized
            'pnllog.Location = New Point(250, 100)
        End If
    End Sub

    Private Sub frmAdmin_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.Size.Width < 1100 Then
            pnlHosp.Location = New Point(5, 54)
            pnlDis.Location = New Point(5, 54)
        Else
            pnlHosp.Location = New Point((10 / 100) * Me.Size.Width, 54)
            pnlDis.Location = New Point((10 / 100) * Me.Size.Width, 54)
        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click, PictureBox6.Click
        frmViewPatient.showDialog
    End Sub

End Class