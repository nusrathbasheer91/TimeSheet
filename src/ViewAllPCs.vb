Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class ViewAllPCs
    Public code As String
    Public accno As String
    Public clientid As String
    Public dbcon As New MySqlConnection

    Private Sub ViewAllPCs_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dbcon.Close()
        Dispose()

    End Sub
    Private Sub ViewAllPCs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon.Open()
        End If
        GetDBData()
    End Sub

    Private Sub ListViewPC_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewPC.MouseClick
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon.Open()
        End If
        code = ListViewPC.SelectedItems(0).Text()

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
        clientid = table.Rows(0)("client_id")
        accno = table.Rows(0)("accno")
        dbcon.Close()


    End Sub

    Public Sub GetDBData()
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon.Open()
        End If

        Dim strQuery As String = "SELECT * from profitc"
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
        ListViewPC.Items.Clear()

        For i = 0 To table.Rows.Count - 1
            With ListViewPC
                .Items.Add(table.Rows(i)("code"))

                With .Items(.Items.Count - 1).SubItems
                    .Add(table.Rows(i)("accno"))
                    .Add(table.Rows(i)("client_id"))
                    .Add(table.Rows(i)("pname"))
                    .Add(table.Rows(i)("manday"))
                    .Add(table.Rows(i)("bf"))
                    .Add(table.Rows(i)("lunch"))
                    .Add(table.Rows(i)("dinner"))
                    .Add(table.Rows(i)("hkeep"))
                    .Add(table.Rows(i)("laundry"))
                End With
            End With

        Next
        dbcon.Close()

    End Sub

    Private Sub ButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click
        If (code = Nothing) Then
            MsgBox("Please select a record to Edit", MsgBoxStyle.Exclamation)
        Else
            EditPC.form = Name
            EditPC.code = code
            EditPC.ShowDialog()
        End If

        code = ""
        accno = ""
        clientid = ""
    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon.Open()
        End If
        Dim sqlQ As String = "delete from profitc where code='" & code & "'"
        Dim SQLCmd As New MySqlCommand
        If (code = Nothing) Then
            MsgBox("Please select a record to Delete", MsgBoxStyle.Exclamation)
        Else
            Try

                With SQLCmd
                    .CommandText = sqlQ
                    .Connection = dbcon
                    .ExecuteNonQuery()
                End With

                MsgBox("Record Deleted succesfully", MsgBoxStyle.Information)

                Me.GetDBData()

            Catch myerror As MySqlException

                MsgBox("SubRecords dependent on this Record: CANNOT delete", MsgBoxStyle.Exclamation)


            End Try
        End If
        code = ""
        accno = ""
        clientid = ""

        dbcon.Close()
    End Sub

    Private Sub ButtonViewEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonViewEmp.Click
        If code = Nothing Then

            MsgBox("Please select a record", MsgBoxStyle.Exclamation)
        Else
            ViewEmp.code = code
            ViewEmp.ShowDialog()
        End If
        code = ""
        accno = ""
        clientid = ""


    End Sub

    Private Sub ButtonViewCamp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonViewCamp.Click
        If code = Nothing Then

            MsgBox("Please select a record", MsgBoxStyle.Exclamation)
        Else
            ViewCamp.accno = accno
            ViewCamp.ShowDialog()
        End If
        code = ""
        accno = ""
        clientid = ""

    End Sub

    Private Sub ButtonViewClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonViewClient.Click
        If code = Nothing Then

            MsgBox("Please select a record", MsgBoxStyle.Exclamation)
        Else
            ViewClient.clientid = clientid
            ViewClient.ShowDialog()

        End If
        code = ""
        accno = ""
        clientid = ""

    End Sub

    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        AddPC.form = Name
        AddPC.ShowDialog()

    End Sub
End Class