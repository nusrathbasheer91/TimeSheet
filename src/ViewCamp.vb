Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class ViewCamp
    Public dbcon As New MySqlConnection
    Friend accno As String

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()

    End Sub

    Private Sub ViewCamp_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dbcon.Close()
        Dispose()

    End Sub

    Private Sub ViewCamp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon.Open()
        End If

        Dim strQuery As String = "SELECT campname,capacity,occupied,(capacity-occupied) as balance from camp where accno='" & accno & "'"
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
        Textaccno.Text = accno
        Textcamp.Text = table.Rows(0)("campname")
        Textcap.Text = table.Rows(0)("capacity")
        Textocc.Text = table.Rows(0)("occupied")
        TextBal.Text = table.Rows(0)("balance")
    End Sub


End Class