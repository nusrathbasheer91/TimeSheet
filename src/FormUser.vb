Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class FormUser
    Public dbcon As New MySqlConnection

    Private Sub FormUser_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        dbcon.Close()
        LoginForm.Show()
    End Sub

    Private Sub FormUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon.Open()
        End If
        Dim strQuery As String = "use ts; select * from company"
        Dim sqlAdapter As New MySqlDataAdapter
        Dim SQLCmd As New MySqlCommand
        Dim table As New DataTable


        'Prepare connection and query
        With SQLCmd
            .CommandText = strQuery
            .Connection = dbcon
        End With
        With sqlAdapter
            .SelectCommand = SQLCmd
            .Fill(table)
        End With
        Label.Text = table.Rows(0)("coname")
    End Sub

    Private Sub ButtonViewCl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonViewCl.Click
        FormClient.ShowDialog()
    End Sub

    Private Sub ButtonClAl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClAl.Click
        ViewAllClients.ShowDialog()
    End Sub

    Private Sub ButtonAddCl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAddCl.Click
        AddClient.ShowDialog()

    End Sub

    Private Sub ButtonViewPc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonViewPc.Click
        FormPC.ShowDialog()

    End Sub

    Private Sub ButtonPcAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPcAll.Click
        ViewAllPCs.ShowDialog()

    End Sub

    Private Sub ButtonAddPc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAddPc.Click
        AddPC.ShowDialog()

    End Sub

    Private Sub ButtonAddEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAddEmp.Click
        AddEmp.ShowDialog()
    End Sub

    Private Sub ButtonEmpAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEmpAll.Click
        ViewAllEmps.ShowDialog()

    End Sub

    Private Sub ButtonViewEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonViewEmp.Click
        FormEmp.ShowDialog()
    End Sub


    Private Sub ButtonAt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAt.Click
        AbsentRange.ShowDialog()

    End Sub

    Private Sub ButtonMonthly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMonthly.Click
        MonthlyReport.ShowDialog()
    End Sub

    Private Sub ButtonLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLogOut.Click
        Close()
        Dispose()
        LoginForm.Show()
    End Sub

    
    Private Sub ButtonTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTransfer.Click
        TransferEmployee.ShowDialog()

    End Sub
End Class