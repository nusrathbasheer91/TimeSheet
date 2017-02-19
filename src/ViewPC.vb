Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class ViewPC

    Public dbcon As New MySqlConnection
    Public clientid As String

    Private Sub ViewPC_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dbcon.Close()
        Dispose()

    End Sub
    Private Sub ViewPC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon.Open()
        End If
        GetDBData()
    End Sub

    Public Sub GetDBData()

        Dim strQuery As String = "SELECT * from profitc where client_id='" & clientid & "'"
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
        Dim mydata As MySqlDataReader
        mydata = SQLCmd.ExecuteReader()
        If mydata.HasRows = 0 Then

            MsgBox("No Profit Centres Listed for this Client", MsgBoxStyle.Exclamation)
            Me.Close()

        End If

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

    End Sub

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Dispose()
        Close()
        dbcon.Close()

    End Sub


End Class