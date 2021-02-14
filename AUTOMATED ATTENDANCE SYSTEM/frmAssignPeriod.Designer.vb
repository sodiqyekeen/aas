<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssignPeriod
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAssignPeriod))
        Me.cmbTeacher = New System.Windows.Forms.ComboBox()
        Me.TeachersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AASDataSet = New AUTOMATED_ATTENDANCE_SYSTEM.AASDataSet()
        Me.cmbClass = New System.Windows.Forms.ComboBox()
        Me.ClassesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbPeriod = New System.Windows.Forms.ComboBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TeachersTableAdapter = New AUTOMATED_ATTENDANCE_SYSTEM.AASDataSetTableAdapters.TeachersTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbDept = New System.Windows.Forms.ComboBox()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentTableAdapter = New AUTOMATED_ATTENDANCE_SYSTEM.AASDataSetTableAdapters.DepartmentTableAdapter()
        Me.FillByDeptToolStrip = New System.Windows.Forms.ToolStrip()
        Me.DeptToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.DeptToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByDeptToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ClassesTableAdapter = New AUTOMATED_ATTENDANCE_SYSTEM.AASDataSetTableAdapters.ClassesTableAdapter()
        Me.FillByDeptToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.DeptToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.DeptToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByDeptToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btnAssign = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PeriodsTableAdapter1 = New AUTOMATED_ATTENDANCE_SYSTEM.AASDataSetTableAdapters.PeriodsTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbDay = New System.Windows.Forms.ComboBox()
        Me.FillDeptCodeToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillDeptCodeToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillByDeptToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.DeptToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.DeptToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByDeptToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.FillByNameToolStrip = New System.Windows.Forms.ToolStrip()
        Me.UnameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.UnameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByNameToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.TeachersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByDeptToolStrip.SuspendLayout()
        Me.FillByDeptToolStrip1.SuspendLayout()
        Me.FillDeptCodeToolStrip.SuspendLayout()
        Me.FillByDeptToolStrip2.SuspendLayout()
        Me.FillByNameToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbTeacher
        '
        Me.cmbTeacher.DataSource = Me.TeachersBindingSource
        Me.cmbTeacher.DisplayMember = "Username"
        Me.cmbTeacher.FormattingEnabled = True
        Me.cmbTeacher.Location = New System.Drawing.Point(191, 66)
        Me.cmbTeacher.Name = "cmbTeacher"
        Me.cmbTeacher.Size = New System.Drawing.Size(121, 21)
        Me.cmbTeacher.TabIndex = 0
        Me.cmbTeacher.ValueMember = "Username"
        '
        'TeachersBindingSource
        '
        Me.TeachersBindingSource.DataMember = "Teachers"
        Me.TeachersBindingSource.DataSource = Me.AASDataSet
        '
        'AASDataSet
        '
        Me.AASDataSet.DataSetName = "AASDataSet"
        Me.AASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbClass
        '
        Me.cmbClass.DataSource = Me.ClassesBindingSource
        Me.cmbClass.DisplayMember = "ClassID"
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.Location = New System.Drawing.Point(191, 110)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(121, 21)
        Me.cmbClass.TabIndex = 1
        Me.cmbClass.ValueMember = "Dept_Code"
        '
        'ClassesBindingSource
        '
        Me.ClassesBindingSource.DataMember = "Classes"
        Me.ClassesBindingSource.DataSource = Me.AASDataSet
        '
        'cmbPeriod
        '
        Me.cmbPeriod.FormattingEnabled = True
        Me.cmbPeriod.Items.AddRange(New Object() {"I", "II", "III", "IV", "V", "VI"})
        Me.cmbPeriod.Location = New System.Drawing.Point(191, 184)
        Me.cmbPeriod.Name = "cmbPeriod"
        Me.cmbPeriod.Size = New System.Drawing.Size(121, 21)
        Me.cmbPeriod.TabIndex = 3
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(191, 224)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(121, 20)
        Me.txtSubject.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(26, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Teacher"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(26, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Class"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(26, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Period"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(26, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Subject"
        '
        'TeachersTableAdapter
        '
        Me.TeachersTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(26, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Department"
        '
        'cmbDept
        '
        Me.cmbDept.DataSource = Me.DepartmentBindingSource
        Me.cmbDept.DisplayMember = "Dept_Code"
        Me.cmbDept.FormattingEnabled = True
        Me.cmbDept.Location = New System.Drawing.Point(191, 23)
        Me.cmbDept.Name = "cmbDept"
        Me.cmbDept.Size = New System.Drawing.Size(121, 21)
        Me.cmbDept.TabIndex = 10
        Me.cmbDept.ValueMember = "Dept_Name"
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "Department"
        Me.DepartmentBindingSource.DataSource = Me.AASDataSet
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'FillByDeptToolStrip
        '
        Me.FillByDeptToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeptToolStripLabel, Me.DeptToolStripTextBox, Me.FillByDeptToolStripButton})
        Me.FillByDeptToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByDeptToolStrip.Name = "FillByDeptToolStrip"
        Me.FillByDeptToolStrip.Size = New System.Drawing.Size(563, 25)
        Me.FillByDeptToolStrip.TabIndex = 11
        Me.FillByDeptToolStrip.Text = "FillByDeptToolStrip"
        Me.FillByDeptToolStrip.Visible = False
        '
        'DeptToolStripLabel
        '
        Me.DeptToolStripLabel.Name = "DeptToolStripLabel"
        Me.DeptToolStripLabel.Size = New System.Drawing.Size(34, 22)
        Me.DeptToolStripLabel.Text = "dept:"
        '
        'DeptToolStripTextBox
        '
        Me.DeptToolStripTextBox.Name = "DeptToolStripTextBox"
        Me.DeptToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByDeptToolStripButton
        '
        Me.FillByDeptToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByDeptToolStripButton.Name = "FillByDeptToolStripButton"
        Me.FillByDeptToolStripButton.Size = New System.Drawing.Size(64, 22)
        Me.FillByDeptToolStripButton.Text = "FillByDept"
        '
        'ClassesTableAdapter
        '
        Me.ClassesTableAdapter.ClearBeforeFill = True
        '
        'FillByDeptToolStrip1
        '
        Me.FillByDeptToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeptToolStripLabel1, Me.DeptToolStripTextBox1, Me.FillByDeptToolStripButton1})
        Me.FillByDeptToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.FillByDeptToolStrip1.Name = "FillByDeptToolStrip1"
        Me.FillByDeptToolStrip1.Size = New System.Drawing.Size(366, 25)
        Me.FillByDeptToolStrip1.TabIndex = 12
        Me.FillByDeptToolStrip1.Text = "FillByDeptToolStrip1"
        Me.FillByDeptToolStrip1.Visible = False
        '
        'DeptToolStripLabel1
        '
        Me.DeptToolStripLabel1.Name = "DeptToolStripLabel1"
        Me.DeptToolStripLabel1.Size = New System.Drawing.Size(34, 22)
        Me.DeptToolStripLabel1.Text = "dept:"
        '
        'DeptToolStripTextBox1
        '
        Me.DeptToolStripTextBox1.Name = "DeptToolStripTextBox1"
        Me.DeptToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'FillByDeptToolStripButton1
        '
        Me.FillByDeptToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByDeptToolStripButton1.Name = "FillByDeptToolStripButton1"
        Me.FillByDeptToolStripButton1.Size = New System.Drawing.Size(64, 22)
        Me.FillByDeptToolStripButton1.Text = "FillByDept"
        '
        'btnAssign
        '
        Me.btnAssign.Location = New System.Drawing.Point(73, 356)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.Size = New System.Drawing.Size(75, 23)
        Me.btnAssign.TabIndex = 13
        Me.btnAssign.Text = "Assign"
        Me.btnAssign.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(156, 356)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(237, 356)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'PeriodsTableAdapter1
        '
        Me.PeriodsTableAdapter1.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(26, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Day"
        '
        'cmbDay
        '
        Me.cmbDay.FormattingEnabled = True
        Me.cmbDay.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        Me.cmbDay.Location = New System.Drawing.Point(191, 148)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(121, 21)
        Me.cmbDay.TabIndex = 17
        '
        'FillDeptCodeToolStrip
        '
        Me.FillDeptCodeToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillDeptCodeToolStripButton})
        Me.FillDeptCodeToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillDeptCodeToolStrip.Name = "FillDeptCodeToolStrip"
        Me.FillDeptCodeToolStrip.Size = New System.Drawing.Size(367, 25)
        Me.FillDeptCodeToolStrip.TabIndex = 18
        Me.FillDeptCodeToolStrip.Text = "FillDeptCodeToolStrip"
        Me.FillDeptCodeToolStrip.Visible = False
        '
        'FillDeptCodeToolStripButton
        '
        Me.FillDeptCodeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillDeptCodeToolStripButton.Name = "FillDeptCodeToolStripButton"
        Me.FillDeptCodeToolStripButton.Size = New System.Drawing.Size(79, 22)
        Me.FillDeptCodeToolStripButton.Text = "FillDeptCode"
        '
        'FillByDeptToolStrip2
        '
        Me.FillByDeptToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeptToolStripLabel2, Me.DeptToolStripTextBox2, Me.FillByDeptToolStripButton2})
        Me.FillByDeptToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.FillByDeptToolStrip2.Name = "FillByDeptToolStrip2"
        Me.FillByDeptToolStrip2.Size = New System.Drawing.Size(367, 25)
        Me.FillByDeptToolStrip2.TabIndex = 19
        Me.FillByDeptToolStrip2.Text = "FillByDeptToolStrip2"
        Me.FillByDeptToolStrip2.Visible = False
        '
        'DeptToolStripLabel2
        '
        Me.DeptToolStripLabel2.Name = "DeptToolStripLabel2"
        Me.DeptToolStripLabel2.Size = New System.Drawing.Size(34, 22)
        Me.DeptToolStripLabel2.Text = "dept:"
        '
        'DeptToolStripTextBox2
        '
        Me.DeptToolStripTextBox2.Name = "DeptToolStripTextBox2"
        Me.DeptToolStripTextBox2.Size = New System.Drawing.Size(100, 25)
        '
        'FillByDeptToolStripButton2
        '
        Me.FillByDeptToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByDeptToolStripButton2.Name = "FillByDeptToolStripButton2"
        Me.FillByDeptToolStripButton2.Size = New System.Drawing.Size(64, 22)
        Me.FillByDeptToolStripButton2.Text = "FillByDept"
        '
        'FillByNameToolStrip
        '
        Me.FillByNameToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UnameToolStripLabel, Me.UnameToolStripTextBox, Me.FillByNameToolStripButton})
        Me.FillByNameToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByNameToolStrip.Name = "FillByNameToolStrip"
        Me.FillByNameToolStrip.Size = New System.Drawing.Size(367, 25)
        Me.FillByNameToolStrip.TabIndex = 20
        Me.FillByNameToolStrip.Text = "FillByNameToolStrip"
        Me.FillByNameToolStrip.Visible = False
        '
        'UnameToolStripLabel
        '
        Me.UnameToolStripLabel.Name = "UnameToolStripLabel"
        Me.UnameToolStripLabel.Size = New System.Drawing.Size(48, 22)
        Me.UnameToolStripLabel.Text = "Uname:"
        '
        'UnameToolStripTextBox
        '
        Me.UnameToolStripTextBox.Name = "UnameToolStripTextBox"
        Me.UnameToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByNameToolStripButton
        '
        Me.FillByNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByNameToolStripButton.Name = "FillByNameToolStripButton"
        Me.FillByNameToolStripButton.Size = New System.Drawing.Size(71, 22)
        Me.FillByNameToolStripButton.Text = "FillByName"
        '
        'frmAssignPeriod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AUTOMATED_ATTENDANCE_SYSTEM.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(330, 391)
        Me.Controls.Add(Me.FillByDeptToolStrip2)
        Me.Controls.Add(Me.FillByNameToolStrip)
        Me.Controls.Add(Me.FillDeptCodeToolStrip)
        Me.Controls.Add(Me.cmbDay)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAssign)
        Me.Controls.Add(Me.FillByDeptToolStrip)
        Me.Controls.Add(Me.FillByDeptToolStrip1)
        Me.Controls.Add(Me.cmbDept)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.cmbPeriod)
        Me.Controls.Add(Me.cmbClass)
        Me.Controls.Add(Me.cmbTeacher)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAssignPeriod"
        Me.Text = "Assign Period"
        CType(Me.TeachersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByDeptToolStrip.ResumeLayout(False)
        Me.FillByDeptToolStrip.PerformLayout()
        Me.FillByDeptToolStrip1.ResumeLayout(False)
        Me.FillByDeptToolStrip1.PerformLayout()
        Me.FillDeptCodeToolStrip.ResumeLayout(False)
        Me.FillDeptCodeToolStrip.PerformLayout()
        Me.FillByDeptToolStrip2.ResumeLayout(False)
        Me.FillByDeptToolStrip2.PerformLayout()
        Me.FillByNameToolStrip.ResumeLayout(False)
        Me.FillByNameToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbTeacher As System.Windows.Forms.ComboBox
    Friend WithEvents cmbClass As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AASDataSet As AUTOMATED_ATTENDANCE_SYSTEM.AASDataSet
    Friend WithEvents TeachersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeachersTableAdapter As AUTOMATED_ATTENDANCE_SYSTEM.AASDataSetTableAdapters.TeachersTableAdapter
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbDept As System.Windows.Forms.ComboBox
    Friend WithEvents DepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentTableAdapter As AUTOMATED_ATTENDANCE_SYSTEM.AASDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents FillByDeptToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents DeptToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DeptToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByDeptToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ClassesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClassesTableAdapter As AUTOMATED_ATTENDANCE_SYSTEM.AASDataSetTableAdapters.ClassesTableAdapter
    Friend WithEvents FillByDeptToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents DeptToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DeptToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByDeptToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAssign As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents PeriodsTableAdapter1 As AUTOMATED_ATTENDANCE_SYSTEM.AASDataSetTableAdapters.PeriodsTableAdapter
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbDay As System.Windows.Forms.ComboBox
    Friend WithEvents FillDeptCodeToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillDeptCodeToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillByDeptToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents DeptToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DeptToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByDeptToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillByNameToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents UnameToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents UnameToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByNameToolStripButton As System.Windows.Forms.ToolStripButton
End Class
