Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class FormEmp
    Public dbcon1 As New MySqlConnection
    Public badge As String
    Private Sub ButtonView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonView.Click
        If dbcon1.State = ConnectionState.Closed Then
            dbcon1.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon1.Open()
        End If

        If Not (IsNothing(ComboBoxEmpBadge.SelectedItem)) Then
            txtBadge.Text = ComboBoxEmpBadge.SelectedValue
        End If
        badge = txtBadge.Text
        Dim sqlQ1 As String = "SELECT * from employee where badge_no='" & badge & "'"
        Dim sqlAdapter1 As New MySqlDataAdapter
        Dim SQLCmd1 As New MySqlCommand

        'Prepare connection and query
        With SQLCmd1
            .CommandText = sqlQ1
            .Connection = dbcon1
        End With
        With sqlAdapter1
            .SelectCommand = SQLCmd1
        End With
        Dim mydata As MySqlDataReader
        mydata = SQLCmd1.ExecuteReader()
        If mydata.HasRows = 0 Then

            MsgBox("Invalid Employee Code")


        Else
            '''''pass txtclientid blah
            Dispose()
            Close()
            FormViewEmp.badge = badge
            FormViewEmp.ShowDialog()
            Dispose()
        End If
        dbcon1.Close()
        badge = ""
    End Sub

    Private Sub FormEmp_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dbcon1.Close()
        Dispose()

    End Sub

    Private Sub FormEmp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dbcon As New MySqlConnection
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon.Open()
        End If
        Dim strQuery As String = "SELECT concat(badge_no,' : ',ename)as ename,badge_no from ts.employee;"
        Dim sqlAdapter As New MySqlDataAdapter
        Dim SQLCmd As New MySqlCommand

        Dim dataS As New DataSet

        'Prepare connection and query
        With SQLCmd
            .CommandText = strQuery
            .Connection = dbcon
        End With
        With sqlAdapter
            .SelectCommand = SQLCmd
            .Fill(dataS)
        End With
        'For i = 0 To table1.Rows.Count - 1

        '    ComboBoxEmpBadge.Items.Add(table1.Rows(i)("badge_no") & " : " & table1.Rows(i)("ename"))
        'Next
        ComboBoxEmpBadge.DataSource = dataS.Tables(0)
        ComboBoxEmpBadge.ValueMember = "badge_no"
        ComboBoxEmpBadge.DisplayMember = "ename"
        ComboBoxEmpBadge.SelectedIndex = -1

    End Sub
End Class