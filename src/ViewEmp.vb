Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class ViewEmp
    Public badge As String
    Public accno As String
    Public code As String
    Public dbcon As New MySqlConnection

    Private Sub ViewEmp_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dbcon.Close()
        Dispose()

    End Sub
    Private Sub ViewEmp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        Dim strQuery As String = "select e.badge_no,ename,accno,code,id,tr_out,next_med,dob,nationality,e.out_date,t.in_date,t.in_code,t.in_accno from employee as e,transfers as t where code='" & code & "' and e.badge_no=t.badge_no and isnull(t.out_date) order by e.code asc,e.badge_no asc ;"
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
                .Items.Add(table.Rows(i)("badge_no"))

                With .Items(.Items.Count - 1).SubItems
                    .Add(table.Rows(i)("accno"))
                    .Add(table.Rows(i)("code"))
                    .Add(table.Rows(i)("ename"))
                    .Add(table.Rows(i)("id").ToString)
                    .Add(Convert.ToDateTime(table.Rows(i)("in_date")).ToShortDateString())
                    If (table.Rows(i)("out_date").ToString = "") Then

                        .Add("")
                    Else
                        '.Add(table.Rows(i)("out_date"))
                        .Add(Convert.ToDateTime(table.Rows(i)("out_date")).ToShortDateString())
                    End If
                    .Add(table.Rows(i)("in_accno").ToString)
                    .Add(table.Rows(i)("in_code").ToString)
                    .Add(table.Rows(i)("tr_out").ToString)
                    If (table.Rows(i)("dob").ToString = "") Then

                        .Add("")
                    Else
                        .Add(Convert.ToDateTime(table.Rows(i)("dob")).ToShortDateString())
                    End If
                    .Add(table.Rows(i)("nationality").ToString)
                    If (table.Rows(i)("next_med").ToString = "") Then

                        .Add("")
                    Else
                        .Add(Convert.ToDateTime(table.Rows(i)("next_med")).ToShortDateString())
                    End If
                End With
            End With

        Next
        dbcon.Close()
    End Sub

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()

    End Sub
End Class