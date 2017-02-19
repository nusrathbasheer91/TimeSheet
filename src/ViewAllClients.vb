Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class ViewAllClients

    Public dbcon As New MySqlConnection
    Public clientid As String

    Private Sub ViewAllClients_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dbcon.Close()
        Dispose()

    End Sub
    Private Sub ViewAllClients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon.Open()
        End If
        GetDBData()
    End Sub

    Public Sub GetDBData()

        Dim strQuery As String = "SELECT * from client"
        Dim sqlAdapter As New MySqlDataAdapter
        Dim SQLCmd As New MySqlCommand
        Dim table As New DataTable
        Dim i As Integer


        'Prepare connection and query
        With SQLCmd
            .CommandText = strQuery
            .Connection = dbcon
        End With
        With sqlAdapter
            .SelectCommand = SQLCmd
            .Fill(table)

        End With
        'CLears the table before loading
        ListViewClient.Items.Clear()

        For i = 0 To table.Rows.Count - 1
            With ListViewClient
                .Items.Add(table.Rows(i)("client_id"))

                With .Items(.Items.Count - 1).SubItems
                    .Add(table.Rows(i)("client_name").ToString)
                    .Add(table.Rows(i)("addr").ToString)
                    .Add(table.Rows(i)("tele").ToString)
                End With
            End With

        Next

    End Sub


    Private Sub ButtonBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBack.Click
        Me.Close()

    End Sub

    Private Sub ListViewClient_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewClient.MouseClick
        clientid = ListViewClient.SelectedItems(0).Text()
    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        If (clientid = Nothing) Then
            MsgBox("Please select a record to Delete", MsgBoxStyle.Exclamation)

        Else
            Dim sqlQ As String = "delete from client where client_id='" & clientid & "'"
            Dim SQLCmd As New MySqlCommand
            Try


                With SQLCmd
                    .CommandText = sqlQ
                    .Connection = dbcon
                    .ExecuteNonQuery()
                End With

                MsgBox("Record Deleted succesfully", MsgBoxStyle.Information)
            Catch myerror As MySqlException

                MsgBox("SubRecords dependent on this Record: CANNOT delete", MsgBoxStyle.Exclamation)

            End Try
            GetDBData()
        End If
        clientid = ""
    End Sub

    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        AddClient.form = Name
        AddClient.ShowDialog()

    End Sub

    Private Sub ButtonUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUpdate.Click
        If clientid = Nothing Then
            MsgBox("Please select a record to EDIT", MsgBoxStyle.Exclamation)

        Else
            Dim sqlQ As String = "SELECT client_name,addr,tele from client where client_id ='" & clientid & "';"
            Dim sqlAdapter As New MySqlDataAdapter
            Dim SQLCmd As New MySqlCommand
            Dim table As New DataTable

            With SQLCmd
                .CommandText = sqlQ
                .Connection = dbcon
            End With
            With sqlAdapter
                .SelectCommand = SQLCmd
                .Fill(table)

            End With

            EditClient.form = Name
            EditClient.clientid = clientid
            EditClient.cname = table.Rows(0)("client_name")
            EditClient.addr = table.Rows(0)("addr").ToString
            EditClient.tele = table.Rows(0)("tele").ToString
            EditClient.ShowDialog()

        End If
        clientid = ""
    End Sub

    Private Sub ButtonViewPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonViewPC.Click
        If clientid = Nothing Then
            MsgBox("Please select a record", MsgBoxStyle.Exclamation)
        Else
            ViewPC.clientid = clientid
            ViewPC.ShowDialog()
        End If
        clientid = ""
    End Sub
End Class