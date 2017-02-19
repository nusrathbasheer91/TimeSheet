Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class FormClient

    Public dbcon1 As New MySqlConnection
    Public clientid As String
    Private Sub ButtonView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonView.Click

        If dbcon1.State = ConnectionState.Closed Then
            dbcon1.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon1.Open()
        End If
        If Not (IsNothing(ComboBoxClientID.SelectedItem)) Then
            Dim S As String() = ComboBoxClientID.SelectedItem.Split(" ")
            txtClientid.Text = S(0)
        End If
        clientid = txtClientid.Text
        Dim sqlQ1 As String = "SELECT * from client where client_id='" & clientid & "'"
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

            MsgBox("Invalid Client ID")


        Else
            '''''pass txtclientid blah
            Dispose()
            Close()
            ViewClient.clientid = clientid
            ViewClient.ShowDialog()
            Dispose()
        End If
        dbcon1.Close()
        clientid = ""

    End Sub


    Private Sub FormClient_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dbcon1.Close()
        Dispose()

    End Sub

    Private Sub FormClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dbcon As New MySqlConnection
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon.Open()
        End If
        Dim strQuery As String = "SELECT client_id,client_name from ts.client;"
        Dim sqlAdapter As New MySqlDataAdapter
        Dim SQLCmd As New MySqlCommand

        Dim table1 As New DataTable
        Dim i As Integer

        'Prepare connection and query
        With SQLCmd
            .CommandText = strQuery
            .Connection = dbcon
        End With
        With sqlAdapter
            .SelectCommand = SQLCmd
            .Fill(table1)
        End With
        For i = 0 To table1.Rows.Count - 1

            ComboBoxClientID.Items.Add(table1.Rows(i)("client_id") & " : " & table1.Rows(i)("client_name"))
        Next
    End Sub
End Class