Public Class frmAddStudent
    Public Property EnforceConstraint As Boolean
   
    Private Sub frmAddStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmAdmin
        Me.SplitContainer1.Panel2.Enabled = False
        'TODO: This line of code loads data into the 'AASDataSet.Classes' table. You can move, or remove it, as needed.
        ' Me.ClassesTableAdapter.Fill(Me.AASDataSet.Classes)
        'TODO: This line of code loads data into the 'AASDataSet.Department' table. You can move, or remove it, as needed.
        'Me.DepartmentTableAdapter.Fill(Me.AASDataSet.Department)

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Try
            EnforceConstraint = False
            Me.TblStudentsTableAdapter1.MaxRollNo(cmbClass.Text)
            getRollNo(cmbClass.Text)
            Me.SplitContainer1.Panel2.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub getRollNo(ByVal sc As String)
        Dim sn As Integer
        Dim regNo As String
        Dim maxRollNo As String = TblStudentsTableAdapter1.MaxRollNo(cmbClass.Text)
        Try
            If Not (IsDBNull(maxRollNo)) Then
                Dim rl As Integer = Len(maxRollNo) - 3
                Dim rn As Double = Convert.ToDouble(maxRollNo.Substring(maxRollNo.Length - 3))
                regNo = maxRollNo.Substring(0, rl)
                sn = Integer.Parse(rn + 1)
                txtRollNo.Text = regNo & sn.ToString("D3")
            Else
                Dim yoa As Double = Convert.ToDouble(Trim(txtYOA.Text).Substring(2))
                Dim cc As Char
                Dim n As Integer = 1
                If cmbDept.Text = "BA" Then
                    cc = "A"
                ElseIf cmbDept.Text = "BBM" Then
                    cc = "B"
                ElseIf cmbDept.Text = "BCA" Then
                    cc = "C"
                ElseIf cmbDept.Text = "BCom" Then
                    cc = "D"
                ElseIf cmbDept.Text = "BSC" Then
                    cc = "E"
                Else
                    MsgBox("Unable to add the record, please check the details and try again.", MsgBoxStyle.Exclamation)
                End If
                txtRollNo.Text = yoa & cc & n.ToString("D3")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        EnforceConstraint = True
        Dim name As String = txtFName.Text & " " & txtLName.Text
        Try
            If (cmbClass.Text = Nothing Or cmbDept.Text = Nothing Or txtFName.Text = Nothing Or txtLName.Text = Nothing Or txtRollNo.Text = Nothing Or txtYOA.Text = Nothing) Then
                MsgBox("Fill up every fields!", MsgBoxStyle.Exclamation)
            Else
                TblStudentsTableAdapter1.InsertStudent(txtRollNo.Text, name, cmbClass.Text, txtYOA.Text)
                MsgBox("Record has been successfully added.")
                Me.SplitContainer1.Panel2.Enabled = False
                btnClear.PerformClick()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtFName.ResetText()
        txtLName.ResetText()
        txtRollNo.ResetText()
        txtYOA.ResetText()
        cmbClass.ResetText()
        cmbDept.ResetText()
        Me.SplitContainer1.Panel2.Enabled = False
    End Sub

    Private Sub cmbDept_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDept.Click
        Try
            EnforceConstraint = False
            Me.DepartmentTableAdapter.Fill(Me.AASDataSet.Department)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbDept_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDept.TextChanged
        Try
            EnforceConstraint = False
            Me.ClassesTableAdapter.FillByDept(Me.AASDataSet.Classes, cmbDept.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FillByDeptToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByDeptToolStripButton.Click
        Try
            Me.ClassesTableAdapter.FillByDept(Me.AASDataSet.Classes, DeptToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class