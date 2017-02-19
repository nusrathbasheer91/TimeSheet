
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class EditPC
    Public dbcon As New MySqlConnection
    Friend form As String
    Friend code As String
   

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon.Open()
        End If
        Dim sqlQ As String = "update profitc set pname='" & Textpname.Text & "', manday=" & Textman.Text & ", hkeep=" & Texthkeep.Text & ", laundry=" & Textlaundry.Text & ", bf=" & TextBf.Text & ", lunch=" & Textlunch.Text & ", dinner=" & Textdinner.Text & " where code='" & Textcode.Text & "';"


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
        If (Form = "FormViewPC") Then
            FormViewPC.GetDBData()
        ElseIf (Form = "ViewAllPCs") Then
            ViewAllPCs.GetDBData()
        End If
    End Sub

    Private Sub EditPC_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dbcon.Close()
        Dispose()
    End Sub

    Private Sub EditPC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon.Open()
        End If

        GetDBData()
    End Sub

    Public Sub GetDBData()
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon.Open()
        End If

        Dim strQuery As String = "SELECT * from profitc where code='" & code & "';"
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



        Textcode.Text = code
        Textaccno.Text = table.Rows(i)("accno")
        Textclientid.Text = table.Rows(i)("client_id")
        Textpname.Text = table.Rows(i)("pname")
        Textman.Text = table.Rows(i)("manday")
        TextBf.Text = table.Rows(i)("bf")
        Textlunch.Text = table.Rows(i)("lunch")
        Textdinner.Text = table.Rows(i)("dinner")
        Texthkeep.Text = table.Rows(i)("hkeep")
        Textlaundry.Text = table.Rows(i)("laundry")

        dbcon.Close()

    End Sub

End Class