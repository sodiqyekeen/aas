Public Class frmTeacherList

    Private Sub TeachersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeachersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TeachersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AASDataSet)

    End Sub

    Private Sub frmTeacherList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmAdmin
        'TODO: This line of code loads data into the 'AASDataSet.Teachers' table. You can move, or remove it, as needed.
        Me.TeachersTableAdapter.Fill(Me.AASDataSet.Teachers)

    End Sub

    Private Sub btnMoveFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveFirst.Click
        BindingNavigatorMoveFirstItem.PerformClick()
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        BindingNavigatorMovePreviousItem.PerformClick()
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.Click
        BindingNavigatorMoveNextItem.PerformClick()
    End Sub

    Private Sub btnMoveLast_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMoveLast.Click
        BindingNavigatorMoveLastItem.PerformClick()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Me.TeachersDataGridView.ReadOnly = False
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim wish As String = MsgBox("Are you sure you want to remove?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If wish = Windows.Forms.DialogResult.Yes Then
            BindingNavigatorDeleteItem.PerformClick()
            Me.LoginTableAdapter1.DeleteUser(TeachersDataGridView.CurrentCell.Value.ToString)
            MsgBox("Record has been removed successfully.", MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            TeachersBindingNavigatorSaveItem.PerformClick()
            MsgBox("Record has been successfully updated.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class