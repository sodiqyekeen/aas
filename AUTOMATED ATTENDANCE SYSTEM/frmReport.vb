Public Class frmReport

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.AttendanceTableAdapter.FillAtt1(Me.AASDataSet.Attendance, "BCA III")
    End Sub

    Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AASDataSet.Classes' table. You can move, or remove it, as needed.
        Try
            ClassesComboBox.Visible = True
            If LoginForm.priority > 0 Then
                Me.ClassesTableAdapter.Fill(Me.AASDataSet.Classes)
            Else
                Me.ClassesTableAdapter.FillByName(Me.AASDataSet.Classes, LoginForm.UN)
            End If
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            ''MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Me.AttendanceTableAdapter.FillAtt1(Me.AASDataSet.Attendance, ClassesComboBox.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class