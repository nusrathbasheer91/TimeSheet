Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class FormCompany

    Public dbcon As New MySqlConnection
    Public accno As String


    Private Sub ListViewCompany_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewCompany.MouseClick
        accno = ListViewCompany.SelectedItems(0).Text()
    End Sub

    Private Sub ButtonBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBack.Click
        Me.Close()

    End Sub

    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        AddCompany.ShowDialog()
    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        If (accno = Nothing) Then
            MsgBox("Please select a record to Delete", MsgBoxStyle.Exclamation)

        Else
            Dim sqlQ As String = "delete from camp where accno='" & accno & "'"
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
        accno = ""
    End Sub

    Private Sub ButtonUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUpdate.Click
        If accno = Nothing Then
            MsgBox("Please select a record to EDIT", MsgBoxStyle.Exclamation)

        Else
            Dim sqlQ As String = "SELECT accno,campname,capacity,occupied from camp where accno ='" & accno & "';"
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

            EditCamp.accno = accno
            EditCamp.campname = table.Rows(0)("campname")
            EditCamp.cap = table.Rows(0)("capacity")
            EditCamp.occ = table.Rows(0)("occupied")
            EditCamp.ShowDialog()

        End If
        accno = "" ''''''''''''''''''''''''''''''''''''''''''''''''''important add in every update/delete
    End Sub

    Private Sub FormCompany_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dbcon.Close()
        Dispose()

    End Sub


    Private Sub FormCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon.Open()
        End If
        GetDBData()
    End Sub

    Public Sub GetDBData()

        Dim strQuery As String = "SELECT accno,campname,capacity,occupied,(capacity-occupied) as balance from camp"
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
        ListViewCompany.Items.Clear()

        For i = 0 To table.Rows.Count - 1
            With ListViewCompany
                .Items.Add(table.Rows(i)("accno"))

                With .Items(.Items.Count - 1).SubItems
                    .Add(table.Rows(i)("campname"))
                    .Add(table.Rows(i)("capacity"))
                    .Add(table.Rows(i)("occupied"))
                    .Add(table.Rows(i)("balance"))
                End With
            End With

        Next

    End Sub


End Class