Public Class frmAssignPeriod

  
    Private Sub frmAssignPeriod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmAdmin
        'TODO: This line of code loads data into the 'AASDataSet.Classes' table. You can move, or remove it, as needed.
        'Me.ClassesTableAdapter.Fill(Me.AASDataSet.Classes)
        'TODO: This line of code loads data into the 'AASDataSet.Department' table. You can move, or remove it, as needed.
        'Me.DepartmentTableAdapter.Fill(Me.AASDataSet.Department)
        'TODO: This line of code loads data into the 'AASDataSet.Teachers' table. You can move, or remove it, as needed.
        'Me.TeachersTableAdapter.Fill(Me.AASDataSet.Teachers)
    End Sub

    Private Sub FillByDeptToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByDeptToolStripButton.Click
        Try
            Me.TeachersTableAdapter.FillByDept(Me.AASDataSet.Teachers, DeptToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByDeptToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByDeptToolStripButton1.Click
        Try
            Me.ClassesTableAdapter.FillByDept(Me.AASDataSet.Classes, DeptToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnAssign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssign.Click
        ' Dim dd As DateTime = Convert.ToDateTi(cmbDay.Text)
        Try
            If (IsNothing(cmbTeacher.Text) Or IsNothing(cmbClass.Text) Or IsNothing(cmbDay.Text) Or IsNothing(txtSubject.Text) Or IsNothing(cmbPeriod.Text)) Then
                MsgBox("Please fill up all fields", MsgBoxStyle.Exclamation)
            End If
            Me.PeriodsTableAdapter1.InsertPeriod(cmbTeacher.Text, cmbClass.Text, cmbDept.SelectedIndex, txtSubject.Text, cmbPeriod.Text)
            MsgBox(cmbTeacher.Text & " has been assigned a new subject (" & txtSubject.Text & ") successfully", MsgBoxStyle.Information)
            btnClear.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        cmbClass.ResetText()
        cmbDay.ResetText()
        cmbPeriod.ResetText()
        cmbTeacher.ResetText()
        txtSubject.ResetText()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cmbDept_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDept.Click
        Me.DepartmentTableAdapter.Fill(Me.AASDataSet.Department)
    End Sub

    Private Sub cmbDept_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDept.TextChanged
        Try
            ClassesTableAdapter.FillByDept(AASDataSet.Classes, cmbDept.Text)
            TeachersTableAdapter.FillByDept(AASDataSet.Teachers, cmbDept.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FillDeptCodeToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillDeptCodeToolStripButton.Click
        Try
            DepartmentTableAdapter.FillDeptCode(AASDataSet.Department)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByDeptToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByDeptToolStripButton2.Click
        Try
            Me.TeachersTableAdapter.FillByDept(Me.AASDataSet.Teachers, DeptToolStripTextBox2.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByNameToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByNameToolStripButton.Click
        Try
            Me.ClassesTableAdapter.FillByName(Me.AASDataSet.Classes, UnameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class