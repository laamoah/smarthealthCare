Public Class frmEditDis
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" Then
            btnUpdate.Enabled = True
        Else
            btnUpdate.Enabled = False
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        frmAdmin.editDis()
        Dispose()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dispose()
    End Sub

    Private Sub frmEditDis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDisname.Text = "Input New Name for:  " & frmAdmin.lbldisName.Text
    End Sub
End Class