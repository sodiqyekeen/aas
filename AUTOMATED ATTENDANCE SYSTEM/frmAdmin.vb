Public Class frmAdmin

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        frmAddTeacher.Show()
    End Sub

    Private Sub AssignPeriodToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssignPeriodToolStripMenuItem.Click
        frmAssignPeriod.Show()
    End Sub

    Private Sub AddToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem1.Click
        frmAddStudent.Show()
    End Sub

    Private Sub AddToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem2.Click
        frmAddDept.Show()
    End Sub

    Private Sub AddClassToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddClassToolStripMenuItem.Click
        frmAddClass.Show()
    End Sub

    Private Sub AttendanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttendanceToolStripMenuItem.Click
        frmReport.MdiParent = Me
        frmReport.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        LoginForm.Show()
        Me.Close()
    End Sub

    Private Sub TeacherListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeacherListToolStripMenuItem.Click
        frmTeacherList.Show()
    End Sub

    Private Sub StudentListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentListToolStripMenuItem.Click
        frmStudentList.Show()
    End Sub

    Private Sub DepartmentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentsToolStripMenuItem.Click
        frmDeptList.Show()
    End Sub

    Private Sub ClassesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassesToolStripMenuItem.Click
        frmClassList.Show()
    End Sub

    Private Sub frmAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
