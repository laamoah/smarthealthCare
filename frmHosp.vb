Imports System.Data.OleDb

Public Class frmHosp
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dispose()
    End Sub

    Private Sub frmHosp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conCommand = New OleDbCommand("SELECT * FROM tblhosp", conDB)
            conDB.Close()
            conDB.Open()
            conReader = conCommand.ExecuteReader(CommandBehavior.CloseConnection)
            dgvHosp.Rows.Clear()
            While conReader.Read
                dgvHosp.Rows.Add(conReader("hname"), conReader("hloc"), conReader("hphone"), conReader("hsite"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvHosp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHosp.CellClick
        Try
            Dim row As DataGridViewRow
            If e.RowIndex >= 0 Then
                row = dgvHosp.Rows(e.RowIndex)
                If e.ColumnIndex = 3 Then
                    Dim url = row.Cells(3).Value
                    Process.Start(url)
                ElseIf e.ColumnIndex = 4 Then
                    frmApptmt.lblProvidername.Text = row.Cells(0).Value
                    frmApptmt.lblprovidertel.Text = row.Cells(2).Value
                    frmApptmt.ShowDialog()
                    frmApptmt.lblProvidername.Text = row.Cells(0).Value
                    frmApptmt.lblprovidertel.Text = row.Cells(2).Value
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & "Sorry, Website Address is Invalid, Consult the Administrator")
        End Try
    End Sub
End Class