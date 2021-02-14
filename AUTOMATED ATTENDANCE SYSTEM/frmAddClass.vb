Public Class frmAddClass

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            If (cmbDept.Text = Nothing Or txtClassID.Text = Nothing) Then
                MsgBox("Fill up all fields", MsgBoxStyle.Exclamation)
            Else
                ClassesTableAdapter1.InsertClass(txtClassID.Text, cmbDept.Text)
                MsgBox("New class ( " & txtClassID.Text & " ) has been successfully added.", MsgBoxStyle.Information)
                txtClassID.ResetText()
                cmbDept.ResetText()
            End If
        Catch ex As Exception
            '' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub frmAddClass_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.MdiParent = frmAdmin
        Me.DepartmentTableAdapter1.Fill(Me.AasDataSet1.Department)
    End Sub
End Class