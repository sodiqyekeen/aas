<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeacherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssignPeriodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddClassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeacherListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TeacherToolStripMenuItem, Me.StudentToolStripMenuItem, Me.ClassToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'TeacherToolStripMenuItem
        '
        Me.TeacherToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.AssignPeriodToolStripMenuItem})
        Me.TeacherToolStripMenuItem.Name = "TeacherToolStripMenuItem"
        Me.TeacherToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.TeacherToolStripMenuItem.Text = "Teacher"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'AssignPeriodToolStripMenuItem
        '
        Me.AssignPeriodToolStripMenuItem.Image = Global.AUTOMATED_ATTENDANCE_SYSTEM.My.Resources.Resources.assign
        Me.AssignPeriodToolStripMenuItem.Name = "AssignPeriodToolStripMenuItem"
        Me.AssignPeriodToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.AssignPeriodToolStripMenuItem.Text = "Assign Period"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem1})
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.StudentToolStripMenuItem.Text = "Student"
        '
        'AddToolStripMenuItem1
        '
        Me.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1"
        Me.AddToolStripMenuItem1.Size = New System.Drawing.Size(96, 22)
        Me.AddToolStripMenuItem1.Text = "Add"
        '
        'ClassToolStripMenuItem
        '
        Me.ClassToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem2, Me.AddClassToolStripMenuItem})
        Me.ClassToolStripMenuItem.Name = "ClassToolStripMenuItem"
        Me.ClassToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.ClassToolStripMenuItem.Text = "Department"
        '
        'AddToolStripMenuItem2
        '
        Me.AddToolStripMenuItem2.Name = "AddToolStripMenuItem2"
        Me.AddToolStripMenuItem2.Size = New System.Drawing.Size(165, 22)
        Me.AddToolStripMenuItem2.Text = " Add Department"
        '
        'AddClassToolStripMenuItem
        '
        Me.AddClassToolStripMenuItem.Name = "AddClassToolStripMenuItem"
        Me.AddClassToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.AddClassToolStripMenuItem.Text = "Add Class"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TeacherListToolStripMenuItem, Me.StudentListToolStripMenuItem, Me.DepartmentsToolStripMenuItem, Me.ClassesToolStripMenuItem, Me.AttendanceToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'TeacherListToolStripMenuItem
        '
        Me.TeacherListToolStripMenuItem.Image = Global.AUTOMATED_ATTENDANCE_SYSTEM.My.Resources.Resources.teacher_icon
        Me.TeacherListToolStripMenuItem.Name = "TeacherListToolStripMenuItem"
        Me.TeacherListToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.TeacherListToolStripMenuItem.Text = "Teacher List"
        '
        'StudentListToolStripMenuItem
        '
        Me.StudentListToolStripMenuItem.Image = Global.AUTOMATED_ATTENDANCE_SYSTEM.My.Resources.Resources.student_icon
        Me.StudentListToolStripMenuItem.Name = "StudentListToolStripMenuItem"
        Me.StudentListToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.StudentListToolStripMenuItem.Text = "Student List"
        '
        'DepartmentsToolStripMenuItem
        '
        Me.DepartmentsToolStripMenuItem.Name = "DepartmentsToolStripMenuItem"
        Me.DepartmentsToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.DepartmentsToolStripMenuItem.Text = "Departments"
        '
        'ClassesToolStripMenuItem
        '
        Me.ClassesToolStripMenuItem.Name = "ClassesToolStripMenuItem"
        Me.ClassesToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ClassesToolStripMenuItem.Text = "Classes"
        '
        'AttendanceToolStripMenuItem
        '
        Me.AttendanceToolStripMenuItem.Image = Global.AUTOMATED_ATTENDANCE_SYSTEM.My.Resources.Resources.Scholaris_Attendance
        Me.AttendanceToolStripMenuItem.Name = "AttendanceToolStripMenuItem"
        Me.AttendanceToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AttendanceToolStripMenuItem.Text = "Attendance"
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AUTOMATED_ATTENDANCE_SYSTEM.My.Resources.Resources.big_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmAdmin"
        Me.Text = "Admin Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TeacherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AssignPeriodToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddClassToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TeacherListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartmentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
