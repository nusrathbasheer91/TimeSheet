
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class EditEmp

    Public dbcon As New MySqlConnection
    Public dbcon2 As New MySqlConnection
    Friend form As String
    Friend badge As String
    Public dob As String
    Public errornum As Integer


    
    Private Sub ButtonUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUpdate.Click
        If TextID.Text <> "" Then
            CheckID()
        End If
        Textnextmed.Text = Format(DateTimePicker2.Value.Date, "yyyy-MM-dd")
        If (Textaccno.Text = "" Or Textbadge.Text = "" Or Textename.Text = "" Or Textcode.Text = "") Then
            MsgBox("Empty Fields", MsgBoxStyle.Exclamation)
            errornum = 1
        ElseIf (Not IsDate(Textdob.Text)) And errornum = 0 And Textdob.Text <> "" Then
            MsgBox("Error : Invalid DOB Date Format ", MsgBoxStyle.Exclamation)
            errornum = 1
        ElseIf DateDiff("d", Today, Textnextmed.Text) <= 0 Then
            MsgBox("Error : Invalid Next Medical Date : Should Differ By atleast One Day of Current Date ", MsgBoxStyle.Exclamation)
            errornum = 1
        Else
            If dbcon.State = ConnectionState.Closed Then
                dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
                dbcon.Open()
            End If
            Dim sqlQ As String
            If (Textdob.Text = "") Then
                sqlQ = "update employee set next_med='" & Textnextmed.Text & "',ename='" & Textename.Text & "', dob=NULL ,nationality='" & Textnat.Text & "', id='" & TextID.Text & "' where badge_no='" & badge & "';"
            Else
                sqlQ = "update employee set next_med='" & Textnextmed.Text & "',ename='" & Textename.Text & "', dob='" & Textdob.Text & "', nationality='" & Textnat.Text & "', id='" & TextID.Text & "' where badge_no='" & badge & "';"
            End If

            Dim sqlCmd As New MySqlCommand
            If errornum = 0 Then
                Try
                    With sqlCmd
                        .CommandText = sqlQ
                        .Connection = dbcon
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Updated record succesfully", MsgBoxStyle.Information)
                    Dispose()
                    Close()
                Catch myerror As MySqlException
                    MsgBox("Error : invalid entries") 'any error like character return for integer field

                End Try
            End If

        End If
        dbcon.Close()
        errornum = 0
        'GETDBDATA AGAIN
        If (form = "FormViewEmp") Then
            FormViewEmp.GetDBData()
        ElseIf (form = "ViewAllEmps") Then
            ViewAllEmps.GetDBData()
        End If
    End Sub

    Private Sub EditEmp_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dbcon.Close()
        dbcon2.Close()
        Dispose()

    End Sub

    Private Sub EditEmp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

        Dim strQuery As String = "SELECT * from employee where badge_no='" & badge & "';"
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
        'CLears the table before loading

        If (table.Rows(0)("dob").ToString = "") Then

            dob = ""
        Else
            dob = Format(Convert.ToDateTime(table.Rows(0)("dob")), "yyyy-MM-dd")

        End If

        Textbadge.Text = badge
        Textaccno.Text = table.Rows(0)("accno")
        Textcode.Text = table.Rows(0)("code")
        Textename.Text = table.Rows(0)("ename")
        Textdob.Text = dob
        Textnat.Text = table.Rows(0)("nationality")
        TextID.Text = table.Rows(0)("id")
        DateTimePicker2.Value = Convert.ToDateTime(table.Rows(0)("next_med"))
        dbcon.Close()

    End Sub

    Public Sub CheckID()

        If dbcon2.State = ConnectionState.Closed Then
            dbcon2.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon2.Open()
        End If

        Dim sqlQ1 As String = "SELECT * from employee where id='" & TextID.Text & "' and code='" & Textcode.Text & "'and badge_no !='" & badge & "'; "
        Dim sqlAdapter1 As New MySqlDataAdapter
        Dim SQLCmd1 As New MySqlCommand

        'Prepare connection and query
        With SQLCmd1
            .CommandText = sqlQ1
            .Connection = dbcon2
        End With
        With sqlAdapter1
            .SelectCommand = SQLCmd1
        End With
        Dim mydata As MySqlDataReader
        mydata = SQLCmd1.ExecuteReader()
        If mydata.HasRows <> 0 Then
            errornum = 1
            MsgBox("Error : Duplicate ID in Profit Centre", MsgBoxStyle.Exclamation)
        End If

        dbcon2.Close()

    End Sub

End Class