<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddClass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddClass))
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.cmbDept = New System.Windows.Forms.ComboBox()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AasDataSet1 = New AUTOMATED_ATTENDANCE_SYSTEM.AASDataSet()
        Me.txtClassID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClassesTableAdapter1 = New AUTOMATED_ATTENDANCE_SYSTEM.AASDataSetTableAdapters.ClassesTableAdapter()
        Me.DepartmentTableAdapter1 = New AUTOMATED_ATTENDANCE_SYSTEM.AASDataSetTableAdapters.DepartmentTableAdapter()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AasDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(73, 248)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(162, 248)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 10
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'cmbDept
        '
        Me.cmbDept.DataSource = Me.DepartmentBindingSource
        Me.cmbDept.DisplayMember = "Dept_Code"
        Me.cmbDept.FormattingEnabled = True
        Me.cmbDept.Location = New System.Drawing.Point(101, 22)
        Me.cmbDept.Name = "cmbDept"
        Me.cmbDept.Size = New System.Drawing.Size(136, 21)
        Me.cmbDept.TabIndex = 9
        Me.cmbDept.ValueMember = "Dept_Name"
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "Department"
        Me.DepartmentBindingSource.DataSource = Me.AasDataSet1
        '
        'AasDataSet1
        '
        Me.AasDataSet1.DataSetName = "AASDataSet"
        Me.AasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtClassID
        '
        Me.txtClassID.Location = New System.Drawing.Point(101, 62)
        Me.txtClassID.Name = "txtClassID"
        Me.txtClassID.Size = New System.Drawing.Size(136, 20)
        Me.txtClassID.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(15, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Dept Code"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(15, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Class ID"
        '
        'ClassesTableAdapter1
        '
        Me.ClassesTableAdapter1.ClearBeforeFill = True
        '
        'DepartmentTableAdapter1
        '
        Me.DepartmentTableAdapter1.ClearBeforeFill = True
        '
        'frmAddClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AUTOMATED_ATTENDANCE_SYSTEM.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(249, 279)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.cmbDept)
        Me.Controls.Add(Me.txtClassID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddClass"
        Me.Text = "Add Class"
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AasDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents cmbDept As System.Windows.Forms.ComboBox
    Friend WithEvents txtClassID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ClassesTableAdapter1 As AUTOMATED_ATTENDANCE_SYSTEM.AASDataSetTableAdapters.ClassesTableAdapter
    Friend WithEvents DepartmentTableAdapter1 As AUTOMATED_ATTENDANCE_SYSTEM.AASDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents AasDataSet1 As AUTOMATED_ATTENDANCE_SYSTEM.AASDataSet
    Friend WithEvents DepartmentBindingSource As System.Windows.Forms.BindingSource
End Class
