Public Class frmAddDept

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            If (IsNothing(txtDeptCode.Text) Or (IsNothing(txtDeptName.Text))) Then
                MsgBox("Fill up all fields", MsgBoxStyle.Exclamation)
            End If
            Me.DepartmentTableAdapter1.InsertDept(txtDeptCode.Text, txtDeptName.Text)
            MsgBox("Record has been successfully added.", MsgBoxStyle.Information)
            txtDeptCode.ResetText()
            txtDeptName.ResetText()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmAddDept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmAdmin
    End Sub
End Class
