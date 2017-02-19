Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class TransferIN
    Dim dbcon1 As New MySqlConnection
    Dim dbcon2 As New MySqlConnection
    Public errornum As Integer
    Public entered As Integer
    Public badge As String
    Public form As String
    Public accno As String
    Public code As String
    'Public INDate As Date

    Dim sdate As Date
    Dim eDate As Date

    Private Sub ButtonTin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTin.Click
        TextDateIn.Text = Format(DateTimePicker1.Value.Date, "yyyy-MM-dd")
        If TextDateIn.Text = "" And errornum = 0 Then
            MsgBox("Error : Fields are Empty ", MsgBoxStyle.Exclamation)
            errornum = 1
        ElseIf (Not IsDate(TextDateIn.Text)) And errornum = 0 Then
            MsgBox("Error : Invalid Date Format ", MsgBoxStyle.Exclamation)
            errornum = 1
        ElseIf errornum = 0 Then
            eDate = Format(Convert.ToDateTime(TextDateIn.Text), "yyyy-MM-dd")
            CheckOut()
            If (errornum = 1) Then
                MsgBox("Error CheckIN Date LESS than CheckOUT Date", MsgBoxStyle.Exclamation)
            End If
            CheckCap()
        End If
        If errornum = 0 Then
            Dim dbcon As New MySqlConnection
            If dbcon.State = ConnectionState.Closed Then
                dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
                dbcon.Open()
            End If

            If errornum = 0 Then
                Dim sqlQ As String = "update employee set out_date=Null, tr_out=NULL where badge_no='" & badge & "';update camp set occupied=occupied+1 where accno= (select accno from employee where badge_no='" & badge & "');"
                Dim sqlCmd As New MySqlCommand

                Try
                    With sqlCmd
                        .CommandText = sqlQ
                        .Connection = dbcon
                        .ExecuteNonQuery()
                    End With
                    MakeEntries()
                    MsgBox("Transfer Records Updated succesfully", MsgBoxStyle.Information)
                Catch myerror As MySqlException
                    MsgBox("Error : invalid entries") 'any error like character return for integer field

                End Try
            End If

            dbcon.Close()
            Dispose()
            Close()


        End If
        If (form = "FormViewEmp") Then
            FormViewEmp.GetDBData()
        ElseIf (form = "ViewAllEmps") Then
            ViewAllEmps.GetDBData()
        End If
        errornum = 0
    End Sub
    Public Sub CheckOut()

        Dim dbcon2 As New MySqlConnection
        Dim table As New DataTable

        'Dim mydata As MySqlDataReader
        If dbcon2.State = ConnectionState.Closed Then
            dbcon2.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon2.Open()
        End If

        Dim sqlQ1 As String = "SELECT e.tr_out,e.accno,e.code,t.in_date,e.out_date from employee as e,transfers as t where e.badge_no='" & badge & "' ;"
        Dim sqlAdapter1 As New MySqlDataAdapter
        Dim SQLCmd1 As New MySqlCommand

        'Prepare connection and query
        'Try
        With SQLCmd1
            .CommandText = sqlQ1
            .Connection = dbcon2
        End With
        With sqlAdapter1
            .SelectCommand = SQLCmd1
            .Fill(table)
        End With

        If (table.Rows(0)("tr_out").ToString = "") Then
            MsgBox("ERROR : Employee Never Checked Out", MsgBoxStyle.Exclamation)
            errornum = 1
            Me.Close()
        End If
        accno = table.Rows(0)("accno")
        code = table.Rows(0)("code")
        ' INDate=table.Rows(0)("in_date")
        sdate = table.Rows(0)("out_date")
        If (DateDiff("d", sdate, eDate) <= 0) Then
            errornum = 1
        End If

        'Catch
        'MsgBox("ERROR", MsgBoxStyle.Exclamation)
        'errornum = 1
        'End Try


        dbcon2.Close()
    End Sub

    Public Sub checkEntered(ByVal DATE1 As Date)
        Dim dateString As String
        dateString = Format(DATE1, "yyyy-MM-dd")
        If dbcon2.State = ConnectionState.Closed Then
            dbcon2.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon2.Open()
        End If

        Dim sqlQ1 As String = "SELECT * from ts.leaveT where badge_no='" & badge & "' and adate='" & dateString & "';"
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
            'MsgBox("Error : Employee already entered", MsgBoxStyle.Exclamation)
            entered = 1
        End If

        dbcon2.Close()
    End Sub


    Public Sub MakeEntries()
        Dim currentDate As Date
        Dim sqlCmd As New MySqlCommand
        Dim dateString As String
        currentDate = sdate


        While (DateDiff("d", eDate, currentDate) < 0)
            checkEntered(currentDate)
            If entered = 1 Then
                entered = 0
            Else
                If dbcon1.State = ConnectionState.Closed Then
                    dbcon1.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
                    dbcon1.Open()
                End If
                dateString = Format(currentDate, "yyyy-MM-dd")
                Dim sqlQ As String = "insert into ts.leaveT (`badge_no`,`adate`) VALUES ('" & badge & "','" & dateString & "');"

                'Try

                With sqlCmd
                    .CommandText = sqlQ
                    .Connection = dbcon1
                    .ExecuteNonQuery()
                End With
                ' MsgBox(textBadge.Text & " Attended on" & TextDate.Text)...Make Success Dialogue
                dbcon1.Close()

                'Catch myerror As MySqlException
                ' MsgBox("Error : While Adding Records ")

                'End Try
            End If
            currentDate = DateAdd("d", 1, currentDate)
        End While

    End Sub

    Public Sub CheckCap()
        If dbcon2.State = ConnectionState.Closed Then
            dbcon2.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon2.Open()
        End If

        Dim sqlQ1 As String = "SELECT occupied,capacity from camp as c,employee as e where e.badge_no='" & badge & "' and c.accno=e.accno"
        Dim sqlAdapter1 As New MySqlDataAdapter
        Dim SQLCmd1 As New MySqlCommand
        Dim table As New DataTable
        If (errornum = 0) Then

            'Prepare connection and query
            With SQLCmd1
                .CommandText = sqlQ1
                .Connection = dbcon2
            End With
            With sqlAdapter1
                .SelectCommand = SQLCmd1
                .Fill(table)
            End With
            Dim mydata As MySqlDataReader
            mydata = SQLCmd1.ExecuteReader()
            If mydata.HasRows = 0 Then
                MsgBox("Error : invalid Transfer In Accno", MsgBoxStyle.Exclamation)
                errornum = 1
            ElseIf (table.Rows(0)("occupied") >= table.Rows(0)("capacity")) Then
                MsgBox("Error : Accommodation is currently FULL", MsgBoxStyle.Exclamation)
                errornum = 1
            End If

        End If
        dbcon2.Close()
    End Sub

    Private Sub TransferIN_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dbcon1.Close()
        dbcon2.Close()
        Dispose()

    End Sub
End Class