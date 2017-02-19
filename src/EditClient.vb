
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class EditClient


    Public dbcon As New MySqlConnection
    Friend form As String
    Friend clientid As String
    Friend cname As String
    Friend addr As String
    Friend tele As String

    Private Sub EditClient_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
        dbcon.Close()
    End Sub

    Private Sub EditClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

        Textclientid.Text = clientid
        Textclientname.Text = cname
        Textadd.Text = addr
        Texttel.Text = tele

    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon.Open()
        End If
        Dim sqlQ As String = "update client set client_name='" & Textclientname.Text & "', addr='" & Textadd.Text & "', tele='" & Texttel.Text & "' where client_id='" & clientid & "';"


        Dim sqlCmd As New MySqlCommand
            Try
                With sqlCmd
                    .CommandText = sqlQ
                    .Connection = dbcon
                    .ExecuteNonQuery()
                End With
                MsgBox("Updated record succesfully", MsgBoxStyle.Information)

            Catch myerror As MySqlException
                MsgBox("Error : invalid entries") 'any error like character return for integer field

            End Try
       
        Dispose()
        Close()

        'GETDBDATA AGAIN
        If (form = "ViewClient") Then
            ViewClient.GetDBData()
        ElseIf (form = "ViewAllClients") Then
            ViewAllClients.GetDBData()
        End If


    End Sub

End Class