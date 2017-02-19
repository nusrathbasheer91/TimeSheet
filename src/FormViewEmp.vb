Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class FormViewEmp
    Public dbcon As New MySqlConnection
    Public badge As String
    Public out As String
    Public dob As String
    Public code As String
    Public accno As String

    Private Sub ButtonViewPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonViewPC.Click
        FormViewPC.code = Textcode.Text
        FormViewPC.ShowDialog()

    End Sub

    Private Sub ButtonViewCamp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonViewCamp.Click
        ViewCamp.accno = Textaccno.Text
        ViewCamp.ShowDialog()

    End Sub

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub FormViewEmp_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dbcon.Close()
        Dispose()

    End Sub

    Private Sub FormViewEmp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        Dim strQuery As String = "select e.badge_no,ename,accno,code,id,tr_out,next_med,dob,nationality,e.out_date,t.in_date,t.in_code,t.in_accno from employee as e,transfers as t where e.badge_no=t.badge_no and isnull(t.out_date) and e.badge_no='" & badge & "' order by e.code asc,e.badge_no asc ;"
        Dim sqlAdapter As New MySqlDataAdapter
        Dim SQLCmd As New MySqlCommand
        Dim table As New DataTable

        Try
            'Prepare connection and query
            With SQLCmd
                .CommandText = strQuery
                .Connection = dbcon
            End With
            With sqlAdapter
                .SelectCommand = SQLCmd
                .Fill(table)

            End With
        Catch myerror As MySqlException
            MsgBox("ERROR : Handled Exception : 1-" & Name, MsgBoxStyle.Exclamation)
        End Try

        Textbadge.Text = badge
        Textaccno.Text = table.Rows(0)("accno").ToString
        Textcode.Text = table.Rows(0)("code").ToString
        Textename.Text = table.Rows(0)("ename").ToString
        Textnat.Text = table.Rows(0)("nationality").ToString
        TextID.Text = table.Rows(0)("id").ToString
        Textinaccno.Text = table.Rows(0)("in_accno").ToString
        Textincode.Text = table.Rows(0)("in_code").ToString
        Textoutcode.Text = table.Rows(0)("tr_out").ToString

        If (table.Rows(0)("out_date").ToString <> "") Then
            TextOutDate.Text = Format(table.Rows(0)("out_date"), "yyyy-MM-dd")
        Else
            TextOutDate.Text = ""
        End If
        If (table.Rows(0)("in_date").ToString <> "") Then
            Textindate.Text = Format(table.Rows(0)("in_date"), "yyyy-MM-dd")
        Else
            Textindate.Text = ""
        End If
        If (table.Rows(0)("dob").ToString <> "") Then
            Textdob.Text = Format(table.Rows(0)("dob"), "yyyy-MM-dd") 'dob
        Else
            Textdob.Text = ""
        End If
        If (table.Rows(0)("next_med").ToString <> "") Then
            Textnextmed.Text = Format(table.Rows(0)("next_med"), "yyyy-MM-dd")
            If (DateDiff("d", Today, table.Rows(0)("next_med")) < 0) Then
                Textnextmed.BackColor = Color.Red
            End If
        Else
            Textnextmed.Text = ""
        End If

        dbcon.Close()

        accno = Textaccno.Text
        code = Textcode.Text
        out = table.Rows(0)("tr_out").ToString

    End Sub

    Private Sub ButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click
        EditEmp.form = Name
        EditEmp.badge = badge
        EditEmp.ShowDialog()
    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        If MsgBox("Are you sure you want to delete Employee " & badge & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If dbcon.State = ConnectionState.Closed Then
                dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
                dbcon.Open()
            End If
            Dim sqlQ As String = "delete from transfers where badge_no='" & badge & "'; delete from leavet where badge_no='" & badge & "'; delete from employee where badge_no='" & badge & "';update camp set occupied=occupied-1 where accno='" & accno & "'"
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

                dbcon.Close()

            End Try
        End If
    End Sub

    Private Sub ButtonTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTrans.Click
        If badge = Nothing Then

            MsgBox("Please select a record", MsgBoxStyle.Exclamation)
        Else
            TransferDetails.out = out
            TransferDetails.form = Name
            TransferDetails.badge = badge
            TransferDetails.accno = accno
            TransferDetails.code = code
            'TransferDetails.inacc = Textinaccno.Text
            'TransferDetails.inpc = Textincode.Text
            TransferDetails.indate = Textindate.Text
            TransferDetails.ShowDialog()
        End If

    End Sub
End Class