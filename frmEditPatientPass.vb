Imports System.Data.OleDb

Public Class frmEditPatientPass
    Private Sub frmEditPatientPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDisname.Text = "Input New Password for:  " & frmViewPatient.lblid.Text
        lblID.Text = frmViewPatient.lblid.Text
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dispose()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length > 3 Then
            btnUpdate.Enabled = True
        Else
            btnUpdate.Enabled = False
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Try
        conCommand = New OleDbCommand("UPDATE tbllogin SET upass=@upass WHERE Uid='" & lblID.Text & "'", conDB)
        conCommand.Parameters.AddWithValue("@upass", TextBox1.Text)
        conDB.Close()
            conDB.Open()
            If conCommand.ExecuteNonQuery() Then
                MessageBox.Show("Update Successfully Made")
                Dispose()
            Else
                MessageBox.Show("Sorry. Update Could Not be Made")
            End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally
        '    conDB.Close()
        'End Try
    End Sub
End Class