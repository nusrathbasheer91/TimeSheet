Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class ViewTransferDetails
    Public badge As String '....SET THIS LATER
    Public in_code As String
    Public in_accno As String
    Public in_date As String
    Public out_code As String
    Public out_date As String
    Public out_accno As String
    Public form As String
    Public dbcon As New MySqlConnection

    Private Sub Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ViewTransferDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        Dim strQuery As String = "SELECT * from transfers where badge_no='" & badge & "'"
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
        ListViewTransfer.Items.Clear()

        For i = 0 To table.Rows.Count - 1
            With ListViewTransfer
                .Items.Add((i + 1).ToString)
                With .Items(.Items.Count - 1).SubItems
                    .Add(table.Rows(i)("badge_no"))
                    .Add(table.Rows(i)("in_date"))
                    .Add(table.Rows(i)("in_accno"))
                    .Add(table.Rows(i)("in_code"))
                    ''.Add(Convert.ToDateTime(table.Rows(i)("in_date")).ToShortDateString())..... WHY
                    If (table.Rows(i)("out_date").ToString = "") Then

                        .Add("")
                    Else
                        '.Add(table.Rows(i)("out_date"))
                        .Add(Convert.ToDateTime(table.Rows(i)("out_date")).ToShortDateString())
                    End If
                    .Add(table.Rows(i)("out_accno").ToString)
                    .Add(table.Rows(i)("out_code").ToString)
                End With
            End With

        Next
        ListViewTransfer.Items(i - 1).BackColor = Color.LemonChiffon
        dbcon.Close()
    End Sub

    Private Sub ButtonViewINCamp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonViewINCamp.Click

        If in_code = Nothing Then

            MsgBox("Please select a record", MsgBoxStyle.Exclamation)

        ElseIf in_accno = "new" Then
            MsgBox("New Employee!", MsgBoxStyle.Exclamation)
        Else
            ViewCamp.accno = in_accno
            ViewCamp.ShowDialog()
        End If
        in_accno = Nothing
        in_code = Nothing
        out_accno = Nothing
        out_code = Nothing
    End Sub


    Private Sub ListViewTransfer_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewTransfer.MouseClick


        in_accno = ListViewTransfer.SelectedItems(0).SubItems(3).Text()
        in_code = ListViewTransfer.SelectedItems(0).SubItems(4).Text()
        out_accno = ListViewTransfer.SelectedItems(0).SubItems(6).Text()
        out_code = ListViewTransfer.SelectedItems(0).SubItems(7).Text()
        out_date = ListViewTransfer.SelectedItems(0).SubItems(5).Text()
        in_date = ListViewTransfer.SelectedItems(0).SubItems(2).Text()

    End Sub


    Private Sub ButtonViewINPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonViewINPC.Click
        If in_code = Nothing Then

            MsgBox("Please select a record", MsgBoxStyle.Exclamation)
        ElseIf in_code = "new" Then

            MsgBox("New Employee!", MsgBoxStyle.Exclamation)
        Else
            FormViewPC.code = in_code
            FormViewPC.ShowDialog()
        End If
        in_accno = Nothing
        in_code = Nothing
        out_accno = Nothing
        out_code = Nothing
        out_date = Nothing
        in_date = Nothing
    End Sub

    Private Sub ButtonViewOutPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonViewOutPC.Click
        If in_code = Nothing Then
            MsgBox("Please select a record", MsgBoxStyle.Exclamation)
        ElseIf out_code = "" Then
            MsgBox("Out Code Empty", MsgBoxStyle.Exclamation)
        Else
            FormViewPC.code = out_code
            FormViewPC.ShowDialog()
        End If
        in_accno = Nothing
        in_code = Nothing
        out_accno = Nothing
        out_code = Nothing
        out_date = Nothing
        in_date = Nothing
    End Sub

    Private Sub ButtonViewOutCamp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonViewOutCamp.Click
        If in_code = Nothing Then
            MsgBox("Please select a record", MsgBoxStyle.Exclamation)
        ElseIf out_code = "" Then
            MsgBox("Out Accommodation No. Empty", MsgBoxStyle.Exclamation)
        Else
            ViewCamp.accno = out_accno
            ViewCamp.ShowDialog()
        End If
        in_accno = Nothing
        in_code = Nothing
        out_accno = Nothing
        out_code = Nothing
        out_date = Nothing
        in_date = Nothing
    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        Dim dbcon1 As New MySqlConnection
        If dbcon1.State = ConnectionState.Closed Then
            dbcon1.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon1.Open()
        End If
        If in_code = Nothing Then
            MsgBox("Please select a record", MsgBoxStyle.Exclamation)
        ElseIf (out_date = Nothing) Then
            MsgBox("Please select a NOT Current record", MsgBoxStyle.Exclamation)
        ElseIf (DateDiff("d", out_date, Today) <= 365) Then
            MsgBox("Please select a record older than 1 Year", MsgBoxStyle.Exclamation)
        Else
            Dim sqlQ As String = "delete from transfers where badge_no='" & badge & "' and not isnull(out_date) and out_date<curdate()-31;"
            Dim SQLCmd As New MySqlCommand
            Try


                With SQLCmd
                    .CommandText = sqlQ
                    .Connection = dbcon1
                    .ExecuteNonQuery()
                End With

                MsgBox("Record Deleted succesfully", MsgBoxStyle.Information)
            Catch myerror As MySqlException

                MsgBox("SubRecords dependent on this Record: CANNOT delete", MsgBoxStyle.Exclamation)

            End Try
            GetDBData()
        End If
        in_accno = Nothing
        in_code = Nothing
        out_accno = Nothing
        out_code = Nothing
        out_date = Nothing
        in_date = Nothing
        dbcon1.Close()

    End Sub

    Private Sub ButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click
        If in_code = Nothing Then
            MsgBox("Please select a record to EDIT", MsgBoxStyle.Exclamation)
        ElseIf (out_date = Nothing) Then
            MsgBox("Please select a NOT Current record", MsgBoxStyle.Exclamation)
        Else

            EditTransfer.form = form
            EditTransfer.badge = badge
            EditTransfer.in_accno = in_accno
            EditTransfer.in_code = in_code
            EditTransfer.in_date = in_date
            EditTransfer.out_accno = out_accno
            EditTransfer.out_code = out_code
            EditTransfer.out_date = out_date
            EditTransfer.ShowDialog()

        End If
        in_code = Nothing
    End Sub
End Class