<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReport))
        Me.AttendanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AASDataSet = New AUTOMATED_ATTENDANCE_SYSTEM.AASDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ClassesComboBox = New System.Windows.Forms.ComboBox()
        Me.ClassesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.AttendanceBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttendanceTableAdapter = New AUTOMATED_ATTENDANCE_SYSTEM.AASDataSetTableAdapters.AttendanceTableAdapter()
        Me.ClassesTableAdapter = New AUTOMATED_ATTENDANCE_SYSTEM.AASDataSetTableAdapters.ClassesTableAdapter()
        CType(Me.AttendanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AttendanceBindingSource
        '
        Me.AttendanceBindingSource.DataMember = "Attendance"
        Me.AttendanceBindingSource.DataSource = Me.AASDataSet
        '
        'AASDataSet
        '
        Me.AASDataSet.DataSetName = "AASDataSet"
        Me.AASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.AttendanceBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AUTOMATED_ATTENDANCE_SYSTEM.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowPageNavigationControls = False
        Me.ReportViewer1.ShowStopButton = False
        Me.ReportViewer1.Size = New System.Drawing.Size(832, 379)
        Me.ReportViewer1.TabIndex = 0
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
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.BackgroundImage = Global.AUTOMATED_ATTENDANCE_SYSTEM.My.Resources.Resources.bg
        Me.SplitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel1.Controls.Add(Me.ClassesComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnLoad)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(836, 487)
        Me.SplitContainer1.SplitterDistance = 100
        Me.SplitContainer1.TabIndex = 1
        '
        'ClassesComboBox
        '
        Me.ClassesComboBox.DataSource = Me.ClassesBindingSource
        Me.ClassesComboBox.DisplayMember = "ClassID"
        Me.ClassesComboBox.FormattingEnabled = True
        Me.ClassesComboBox.Location = New System.Drawing.Point(54, 22)
        Me.ClassesComboBox.Name = "ClassesComboBox"
        Me.ClassesComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ClassesComboBox.TabIndex = 2
        Me.ClassesComboBox.ValueMember = "Dept_Code"
        Me.ClassesComboBox.Visible = False
        '
        'ClassesBindingSource
        '
        Me.ClassesBindingSource.DataMember = "Classes"
        Me.ClassesBindingSource.DataSource = Me.AASDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(7, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Class"
        Me.Label1.Visible = False
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(43, 67)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(141, 23)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "Load Attendance Report"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'AttendanceBindingSource1
        '
        Me.AttendanceBindingSource1.DataMember = "Attendance"
        Me.AttendanceBindingSource1.DataSource = Me.AASDataSet
        '
        'AttendanceTableAdapter
        '
        Me.AttendanceTableAdapter.ClearBeforeFill = True
        '
        'ClassesTableAdapter
        '
        Me.ClassesTableAdapter.ClearBeforeFill = True
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 487)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReport"
        Me.Text = "Attendance Report"
        CType(Me.AttendanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AttendanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AASDataSet As AUTOMATED_ATTENDANCE_SYSTEM.AASDataSet
    Friend WithEvents AttendanceTableAdapter As AUTOMATED_ATTENDANCE_SYSTEM.AASDataSetTableAdapters.AttendanceTableAdapter
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents ClassesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AttendanceBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ClassesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClassesTableAdapter As AUTOMATED_ATTENDANCE_SYSTEM.AASDataSetTableAdapters.ClassesTableAdapter
End Class
