Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class FormViewPC
    Public dbcon As New mysqlconnection
    Friend code As String

    Private Sub FormViewPC_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dbcon.Close()
        Dispose()

    End Sub

    Private Sub FormViewPC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon.Open()
        End If
        GetDBData()
    End Sub

    Public Sub GetDBData()

        Dim strQuery As String = "SELECT * from profitc where code='" & code & "' ; "
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
        Textcode.Text = code
        Textclientid.Text = table.Rows(0)("client_id")
        Textaccno.Text = table.Rows(0)("accno")
        Textpname.Text = table.Rows(0)("pname")
        Textman.Text = table.Rows(0)("manday")
        TextBf.Text = table.Rows(0)("bf")
        Textlunch.Text = table.Rows(0)("lunch")
        Textdinner.Text = table.Rows(0)("dinner")
        Texthkeep.Text = table.Rows(0)("hkeep")
        Textlaundry.Text = table.Rows(0)("laundry")

    End Sub

    Private Sub ButtonViewClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonViewClient.Click
        ViewClient.clientid = Textclientid.Text
        ViewClient.ShowDialog()

    End Sub

    Private Sub ButtonViewCamp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonViewCamp.Click
        ViewCamp.accno = Textaccno.Text
        ViewCamp.ShowDialog()

    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click

        Dim sqlQ As String = "delete from profitc where code='" & code & "'"
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
        ''shorter code implemented
        EditPC.form = Name
        EditPC.code = code
        EditPC.ShowDialog()

    End Sub

    Private Sub ButtonViewEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonViewEmp.Click
        ViewEmp.code = code
        ViewEmp.ShowDialog()
    End Sub
End Class