Public Class frmStudentList

    Private Sub TblStudentsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblStudentsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblStudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AASDataSet)

    End Sub

    Private Sub frmStudentList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmAdmin
        'TODO: This line of code loads data into the 'AASDataSet.tblStudents' table. You can move, or remove it, as needed.
        Me.TblStudentsTableAdapter.Fill(Me.AASDataSet.tblStudents)

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
        Me.TblStudentsDataGridView.ReadOnly = False
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim wish As String = MsgBox("Are you sure you want to remove?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If wish = Windows.Forms.DialogResult.Yes Then
            BindingNavigatorDeleteItem.PerformClick()
            MsgBox("Record has been removed successfully.", MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            TblStudentsBindingNavigatorSaveItem.PerformClick()
            MsgBox("Record has been updated successfully.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub rdbRollNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbRollNo.Click
        txtFiltRollNo.Text = "Enter RollNo"
        txtFiltClass.Visible = False
        txtFiltRollNo.Visible = True
    End Sub

    Private Sub rdbClass_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbClass.Click
        txtFiltClass.Text = "Enter Class"
        txtFiltRollNo.Visible = False
        txtFiltClass.Visible = True
    End Sub

    Private Sub txtFiltClass_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFiltClass.Click
        txtFiltClass.ResetText()
    End Sub

    Private Sub txtFiltRollNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFiltRollNo.Click
        txtFiltRollNo.ResetText()
    End Sub

    Private Sub txtFiltClass_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFiltClass.TextChanged
        Try
            Me.TblStudentsTableAdapter.FilterByClass(Me.AASDataSet.tblStudents, txtFiltClass.Text)
        Catch ex As Exception
            ''MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFiltRollNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFiltRollNo.TextChanged
        Try
            Me.TblStudentsTableAdapter.FilterByRollNO(Me.AASDataSet.tblStudents, txtFiltRollNo.Text)
        Catch ex As Exception
            '' MsgBox(ex.Message)
        End Try
    End Sub
End Class