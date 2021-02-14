<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddStudent))
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.cmbClass = New System.Windows.Forms.ComboBox()
        Me.ClassesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AASDataSet = New AUTOMATED_ATTENDANCE_SYSTEM.AASDataSet()
        Me.cmbDept = New System.Windows.Forms.ComboBox()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtRollNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DepartmentTableAdapter = New AUTOMATED_ATTENDANCE_SYSTEM.AASDataSetTableAdapters.DepartmentTableAdapter()
        Me.ClassesTableAdapter = New AUTOMATED_ATTENDANCE_SYSTEM.AASDataSetTableAdapters.ClassesTableAdapter()
        Me.TblStudentsTableAdapter1 = New AUTOMATED_ATTENDANCE_SYSTEM.AASDataSetTableAdapters.tblStudentsTableAdapter()
        Me.txtYOA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FillByDeptToolStrip = New System.Windows.Forms.ToolStrip()
        Me.DeptToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.DeptToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByDeptToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByDeptToolStrip.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(365, 97)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 23
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(446, 97)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 25
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(527, 97)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 21
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'cmbClass
        '
        Me.cmbClass.DataSource = Me.ClassesBindingSource
        Me.cmbClass.DisplayMember = "ClassID"
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.Location = New System.Drawing.Point(257, 23)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(121, 21)
        Me.cmbClass.TabIndex = 19
        Me.cmbClass.ValueMember = "Dept_Code"
        '
        'ClassesBindingSource
        '
        Me.ClassesBindingSource.DataMember = "Classes"
        Me.ClassesBindingSource.DataSource = Me.AASDataSet
        '
        'AASDataSet
        '
        Me.AASDataSet.DataSetName = "AASDataSet"
        Me.AASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbDept
        '
        Me.cmbDept.DataSource = Me.DepartmentBindingSource
        Me.cmbDept.DisplayMember = "Dept_Code"
        Me.cmbDept.FormattingEnabled = True
        Me.cmbDept.Location = New System.Drawing.Point(86, 23)
        Me.cmbDept.Name = "cmbDept"
        Me.cmbDept.Size = New System.Drawing.Size(121, 21)
        Me.cmbDept.TabIndex = 17
        Me.cmbDept.ValueMember = "Dept_Name"
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "Department"
        Me.DepartmentBindingSource.DataSource = Me.AASDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(210, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Class"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(8, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Department"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(28, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Last Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(28, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "First Name"
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(106, 121)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(154, 20)
        Me.txtLName.TabIndex = 24
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(365, 164)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 22
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(106, 77)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(154, 20)
        Me.txtFName.TabIndex = 20
        '
        'txtRollNo
        '
        Me.txtRollNo.Location = New System.Drawing.Point(106, 36)
        Me.txtRollNo.Name = "txtRollNo"
        Me.txtRollNo.ReadOnly = True
        Me.txtRollNo.Size = New System.Drawing.Size(154, 20)
        Me.txtRollNo.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(28, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Roll No"
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'ClassesTableAdapter
        '
        Me.ClassesTableAdapter.ClearBeforeFill = True
        '
        'TblStudentsTableAdapter1
        '
        Me.TblStudentsTableAdapter1.ClearBeforeFill = True
        '
        'txtYOA
        '
        Me.txtYOA.Location = New System.Drawing.Point(481, 24)
        Me.txtYOA.Name = "txtYOA"
        Me.txtYOA.Size = New System.Drawing.Size(121, 20)
        Me.txtYOA.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(384, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Year of Admission"
        '
        'FillByDeptToolStrip
        '
        Me.FillByDeptToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeptToolStripLabel, Me.DeptToolStripTextBox, Me.FillByDeptToolStripButton})
        Me.FillByDeptToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByDeptToolStrip.Name = "FillByDeptToolStrip"
        Me.FillByDeptToolStrip.Size = New System.Drawing.Size(642, 25)
        Me.FillByDeptToolStrip.TabIndex = 30
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
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackgroundImage = Global.AUTOMATED_ATTENDANCE_SYSTEM.My.Resources.Resources.bg
        Me.SplitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnClose)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnOk)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnClear)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtYOA)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbDept)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbClass)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackgroundImage = Global.AUTOMATED_ATTENDANCE_SYSTEM.My.Resources.Resources.bg
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnAdd)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtRollNo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtFName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtLName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Size = New System.Drawing.Size(614, 346)
        Me.SplitContainer1.SplitterDistance = 129
        Me.SplitContainer1.TabIndex = 31
        '
        'frmAddStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 346)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.FillByDeptToolStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddStudent"
        Me.Text = "Add Student"
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByDeptToolStrip.ResumeLayout(False)
        Me.FillByDeptToolStrip.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents cmbClass As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDept As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents txtRollNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AASDataSet As AUTOMATED_ATTENDANCE_SYSTEM.AASDataSet
    Friend WithEvents DepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentTableAdapter As AUTOMATED_ATTENDANCE_SYSTEM.AASDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents ClassesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClassesTableAdapter As AUTOMATED_ATTENDANCE_SYSTEM.AASDataSetTableAdapters.ClassesTableAdapter
    Friend WithEvents TblStudentsTableAdapter1 As AUTOMATED_ATTENDANCE_SYSTEM.AASDataSetTableAdapters.tblStudentsTableAdapter
    Friend WithEvents txtYOA As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FillByDeptToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents DeptToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DeptToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByDeptToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
End Class
