Imports System.Data.OleDb

Public Class frmApptmt

    Public Sub getPatientInfo()
        Dim dbtable As New DataTable

        conDB.Close()
        conDB.Open()

        conCommand = New OleDbCommand("SELECT * FROM tblpatient WHERE pid=@pid", conDB)
        conCommand.Parameters.AddWithValue("@pid", frmPatient.lblPID.Text)
        conCommand.Connection = conDB
        conAdapter.SelectCommand = conCommand
        conAdapter.Fill(dbtable)
        If dbtable.Rows.Count > 0 Then
            lblPname.Text = dbtable.Rows(0).Item(1)
            lblPgend.Text = dbtable.Rows(0).Item(2)
            lblPbirth.Text = dbtable.Rows(0).Item(3)
            lblPLoc.Text = dbtable.Rows(0).Item(4)
            lblPtel.Text = dbtable.Rows(0).Item(5)
        End If
    End Sub
    Private Sub pbxLogout_Click(sender As Object, e As EventArgs) Handles pbxLogout.Click
        Dispose()
    End Sub

    Private Sub frmApptmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getPatientInfo()
    End Sub

    Private Sub rtbMessage_TextChanged(sender As Object, e As EventArgs) Handles rtbMessage.TextChanged
        lblMsgCount.Text = "(" & 200 - rtbMessage.Text.Length & "  Characters Left )"
        If rtbMessage.Text.Length > 0 Then
            btnBook.Enabled = True
        Else
            btnBook.Enabled = False
        End If
    End Sub

    Private Sub cmbBTH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBTH.SelectedIndexChanged
        If cmbBTH.Text.Length > 0 Then
            cmbBTM.Enabled = True
            cmbBTM.DroppedDown = True
        Else
            cmbBTM.Enabled = False
            cmbBTM.DroppedDown = False
        End If
    End Sub

    Private Sub cmbBTM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBTM.SelectedIndexChanged
        If cmbBTH.Text.Length > 0 Then
            rtbMessage.Enabled = True
        Else
            rtbMessage.Enabled = False
        End If
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        btnBook.Cursor = Cursors.AppStarting
        If My.Computer.Network.IsAvailable Then

            Dim apiKey = "VSvGOOhAsDTj4MTSDXRNBG15H"
            Dim url = "https://apps.mnotify.net/"
            Dim Msg = "Hi " & lblProvidername.Text & "," & vbNewLine &
                "--Aptmt Booking--" & vbNewLine &
                "PATIENT INFO :" & vbNewLine &
                lblPname.Text & vbNewLine &
                lblPgend.Text & vbNewLine &
                lblPbirth.Text & vbNewLine &
                lblPLoc.Text & vbNewLine &
                lblPtel.Text & vbNewLine &
                vbNewLine &
                "BOOKING INFO: " & vbNewLine &
                "Date: " & dtpBDate.Text & vbNewLine &
                "Time: " & cmbBTH.Text & ":" & cmbBTM.Text & vbNewLine &
            vbNewLine &
                 "MESSAGE:" & vbNewLine &
                 rtbMessage.Text
            Dim recivNo = lblprovidertel.Text

            Dim senderID = "SmartHealth"
            Dim fullUrl As String = url & "smsapi?key=" & apiKey & "&to=" & recivNo & "&msg=" & Msg & "&sender_id=" & senderID

            Dim webClient As New System.Net.WebClient
            Dim results As String = webClient.DownloadString(fullUrl)
            If results.ToString.Contains("successful") Then

                btnBook.Cursor = Cursors.Default
                MsgBox("Congratulation. Your Appointment is Successfully Sent to the Health Provider" & vbNewLine &
                       "You Will Recieve A Confirmation or Otherwise from the Provider" & vbNewLine &
                       "Thank You")
                Dispose()
            Else
                MsgBox(results)
            End If
        Else
            btnBook.Cursor = Cursors.Default
            MessageBox.Show("Opps....!, Sorry You are Not Connected to Internet. Check and Retry", "SmartHealthCare", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        btnBook.Cursor = Cursors.Default
    End Sub
End Class