Public Class frmAttendance
    'Dim 'dow As Integer = Now.DayOfWeek
    Private Sub frmAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmTeacher
        hideControls()
        lblName.Text = LoginForm.UN
    End Sub

    Private Sub hideControls()
        Me.DataGridView1.Visible = False
        Me.btnSubmit.Visible = False
        Me.SplitContainer1.Panel1.Enabled = True
    End Sub
    Private Sub showControls()
        Me.DataGridView1.Visible = True
        Me.btnSubmit.Visible = True
        Me.SplitContainer1.Panel1.Enabled = False
    End Sub
    Private Sub rMode()
        cmbClass.Enabled = False
        cmbPeriod.Enabled = False
        cmbSubject.Enabled = False
        btnOk.Enabled = False
    End Sub
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Try
            Dim cnt As Integer = Me.PeriodsTableAdapter1.CheckCount(lblName.Text, cmbClass.Text, "2", cmbSubject.Text, cmbPeriod.Text)
            If cnt = 0 Then
                MsgBox("Sorry! The selected period is not assigned to you, please check the details and try again.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            Me.TblStudentsTableAdapter.FillByClassID(Me.AASDataSet.tblStudents, cmbClass.Text)
            Dim chkStatus As DataGridViewCheckBoxColumn
            chkStatus = New DataGridViewCheckBoxColumn()
            chkStatus.HeaderText = "Attendance Status"
            chkStatus.Width = 150
            chkStatus.FlatStyle = FlatStyle.Standard
            Dim chkLeave As DataGridViewCheckBoxColumn
            chkLeave = New DataGridViewCheckBoxColumn()
            chkLeave.HeaderText = "Leave"
            chkLeave.Width = 100
            chkLeave.FlatStyle = FlatStyle.Standard
            Me.DataGridView1.Columns.Add(chkStatus)
            Me.DataGridView1.Columns.Add(chkLeave)
            showControls()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub cmbSubject_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSubject.Click
        Try
            Me.PeriodsTableAdapter1.FillByUname(Me.AASDataSet.Periods, lblName.Text)
        Catch ex As Exception
            ''MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbClass_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbClass.Click
        Try
            Me.ClassesTableAdapter.FillByName(Me.AASDataSet.Classes, lblName.Text)
        Catch ex As Exception
            ''MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim rCount As Integer = Me.DataGridView1.RowCount
        Dim cCount As Integer = Me.DataGridView1.ColumnCount
        Dim status(rCount) As Char
        Dim i As Integer
        Dim p As Integer = 0
        Dim a As Integer = 0
        Dim l As Integer = 0
        Dim onDate As Date = Date.Today.ToString("dd-MMM-yyyy")
        Try

            Dim wish As String = MsgBox("Are you sure you want to submit?", MsgBoxStyle.YesNo, "Confirm Attendance")
            If wish = vbYes Then
                For i = 0 To rCount - 1
                    If (Me.DataGridView1.Rows(i).Cells(2).Value) = True Then
                        status(i) = "P"
                        p += 1
                    ElseIf (Me.DataGridView1.Rows(i).Cells(3).Value) = True Then
                        status(i) = "L"
                        l += 1
                    Else
                        status(i) = "A"
                        a += 1
                    End If
                    Me.AttendanceTableAdapter1.InsertAtt(Me.DataGridView1.Rows(i).Cells(0).Value.ToString, lblName.Text, cmbClass.Text, onDate, cmbPeriod.Text, status(i), cmbSubject.Text)

                Next
                MsgBox("Attendance has been successfully submitted" & vbCrLf & "Total No of Present = " & p & vbCrLf & "Total No of Absent = " & a & vbCrLf & "Total No of Leave = " & l, MsgBoxStyle.Information)
                showControls()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        cmbClass.Enabled = True
        cmbPeriod.Enabled = True
        cmbSubject.Enabled = True
        btnOk.Enabled = True
        hideControls()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class