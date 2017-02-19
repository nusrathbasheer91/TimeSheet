
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class ViewClient
    Public dbcon As New MySqlConnection
    Friend clientid As String

    Private Sub ViewClient_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dbcon.Close()
        Dispose()

    End Sub

    Private Sub ViewClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon.Open()
        End If
        GetDBData()

    End Sub
    Public Sub GetDBData()

        Dim strQuery As String = "SELECT client_name,addr,tele from client where client_id='" & clientid & "' ; "
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

        Textclientid.Text = clientid
        Textclientname.Text = table.Rows(0)("client_name").ToString
        Textadd.Text = table.Rows(0)("addr").ToString
        Texttel.Text = table.Rows(0)("tele").ToString

    End Sub

   
    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        
        Dim sqlQ As String = "delete from client where client_id='" & clientid & "'"
            Dim SQLCmd As New MySqlCommand
            Try

            With SQLCmd
                .CommandText = sqlQ
                .Connection = dbcon
                .ExecuteNonQuery()
            End With

            MsgBox("Record Deleted succesfully", MsgBoxStyle.Information)
            Me.Close()

        Catch myerror As MySqlException

            MsgBox("SubRecords dependent on this Record: CANNOT delete", MsgBoxStyle.Exclamation)

        End Try
          
    End Sub

    Private Sub ButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click
        EditClient.form = Name
        EditClient.clientid = Textclientid.Text
        EditClient.cname = Textclientname.Text
        EditClient.addr = Textadd.Text
        EditClient.tele = Texttel.Text
        EditClient.ShowDialog()


    End Sub

    Private Sub ButtonViewPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonViewPC.Click
        ViewPC.clientid = clientid
        ViewPC.ShowDialog()
    End Sub

End Class