Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class EditCompany
    Public dbcon As New MySqlConnection
    Friend coname As String


    Private Sub ButtonUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUpdate.Click
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon.Open()
        End If
        Dim sqlQ As String = "update company set coname='" & Textco.Text & "' where coname='" & coname & "'"


        Dim sqlCmd As New MySqlCommand
        Try
            With sqlCmd
                .CommandText = sqlQ
                .Connection = dbcon
                .ExecuteNonQuery()
            End With
            MsgBox("Updated record succesfully", MsgBoxStyle.Information)
            FormAdmin.GetDBData()
        Catch myerror As MySqlException
            MsgBox("Error : invalid entries") 'any error like character return for integer field

        End Try
        Dispose()
        Close()
    End Sub

    Private Sub EditCompany_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
        dbcon.Close()

    End Sub

    Private Sub EditCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Textco.text = coname
    End Sub
End Class