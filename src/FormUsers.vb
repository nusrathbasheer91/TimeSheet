Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class FormUsers
    Public dbcon As New MySqlConnection
    Public userid As String

    Private Sub ListViewUsers_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewUsers.MouseClick
        userid = ListViewUsers.SelectedItems(0).Text()
    End Sub

    Private Sub FormUsers_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dbcon.Close()
        Dispose()

    End Sub

    Private Sub FormUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon.Open()
        End If
        GetDBData()
    End Sub

    Public Sub GetDBData()

        Dim strQuery As String = "SELECT user_id,pwd from users where user_id!='admin' "
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
        ListViewUsers.Items.Clear()

        For i = 0 To table.Rows.Count - 1
            With ListViewUsers
                .Items.Add(table.Rows(i)("user_id"))

                With .Items(.Items.Count - 1).SubItems
                    .Add(decrypt(table.Rows(i)("pwd"), 25))

                End With
            End With

        Next

    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        If (userid = Nothing) Then
            MsgBox("Please select a record to Delete", MsgBoxStyle.Exclamation)

        Else
            Dim sqlQ As String = "delete from users where user_id = '" & userid & "'"
            Dim SQLCmd As New MySqlCommand

            With SQLCmd
                .CommandText = sqlQ
                .Connection = dbcon
                .ExecuteNonQuery()
            End With

            MsgBox("Record Deleted succesfully", MsgBoxStyle.Information)

            GetDBData()
        End If
        userid = ""
    End Sub

    Private Sub ButtonUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUpdate.Click
        If userid = Nothing Then
            MsgBox("Please select a record to EDIT", MsgBoxStyle.Exclamation)

        Else
            Dim sqlQ As String = "SELECT user_id,pwd from users where user_id ='" & userid & "';"
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

            EditUser.userid = userid
            EditUser.pwd = table.Rows(0)("pwd")
            EditUser.ShowDialog()

        End If

        userid = ""
    End Sub

    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        AddUser.ShowDialog()
    End Sub

    Public Function decrypt(ByVal s As String, ByVal v As Long) As String
        Dim total As String = ""
        Dim tmp As String
        For i = 1 To Len(s)
            tmp = Mid(s, i, 1)
            tmp = Asc(tmp) - v
            tmp = Chr(tmp)
            total = total & tmp
        Next i
        decrypt = total
    End Function

End Class