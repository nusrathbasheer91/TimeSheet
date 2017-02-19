Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class AbsentRange
    Public dbcon As New MySqlConnection
    Public dbcon1 As New MySqlConnection
    Public dbcon2 As New MySqlConnection
    Public errornum As Integer
    Public entered As Integer
    Public accno As String
    Public code As String
    Public INDate As Date
    Public sdate As Date
    Public edate As Date



    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()

    End Sub

    Private Sub ButtonAbsent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAbsent.Click
        TextDateStart.Text = Format(DateTimePicker1.Value.Date, "yyyy-MM-dd")
        TextDateEnd.Text = Format(DateTimePicker2.Value.Date, "yyyy-MM-dd")
        If Not (IsNothing(ComboBoxEmpBadge.SelectedItem)) Then
            Dim S As String() = ComboBoxEmpBadge.SelectedItem.Split(" ")
            textBadge.Text = S(0)
        End If

        ''''''''''''''DAtechecks'''''''''''''''''
        If TextDateEnd.Text = "" And TextDateStart.Text = "" And textBadge.Text = "" Then
            MsgBox("Error : Fields are Empty ", MsgBoxStyle.Exclamation)
            errornum = 1
        ElseIf errornum = 0 Then
            edate = TextDateEnd.Text
            sdate = TextDateStart.Text
        End If
        If DateDiff("d", edate, sdate) > 0 Then
            MsgBox("Error : Start Date and End Date should differ by atleast 1 day", MsgBoxStyle.Exclamation)
            errornum = 1
        ElseIf DateDiff("d", Today, edate) > 0 Then
            MsgBox("Error : End Date cannot EXCEED Current Date", MsgBoxStyle.Exclamation)
            errornum = 1
        ElseIf errornum = 0 Then

            checkEmp()
            If errornum = 1 Then
                errornum = 0
            ElseIf DateDiff("d", sdate, INDate) > 0 Then
                MsgBox("Error : Invalid Start Date : Start Date must begin after CheckIN Date", MsgBoxStyle.Exclamation)
                errornum = 1
            ElseIf errornum = 0 Then
                Try
                    MakeEntries()
                    MsgBox("Success!!", MsgBoxStyle.Information)
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Error", MsgBoxStyle.Exclamation)

                End Try

                'checkEntered(date1)

                'If errornum = 0 Then
                'make entries
                ' checkEntered(date1)
                'entered=0

                ' End If

                ' errornum = 0
            End If
            '''''''''''''''''''''''''''''''''''''''

        End If
        errornum = 0
    End Sub

    Public Sub checkEntered(ByVal DATE1 As Date)
        Dim dateString As String
        dateString = Format(DATE1, "yyyy-MM-dd")
        If dbcon2.State = ConnectionState.Closed Then
            dbcon2.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon2.Open()
        End If

        Dim sqlQ1 As String = "SELECT * from ts.leaveT where badge_no='" & textBadge.Text & "' and adate='" & dateString & "';"
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

    Public Sub checkEmp()

        If dbcon1.State = ConnectionState.Closed Then
            dbcon1.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon1.Open()
        End If

        ''''''''''''''''
        Dim sqlQ1 As String = "SELECT t.in_date,t.out_accno,t.out_code from employee as e,transfers as t where e.badge_no='" & textBadge.Text & "' and t.badge_no=e.badge_no and isnull(t.out_date);"
        Dim sqlAdapter1 As New MySqlDataAdapter
        Dim SQLCmd1 As New MySqlCommand
        Dim table As New DataTable

        'Prepare connection and query
        With SQLCmd1
            .CommandText = sqlQ1
            .Connection = dbcon1
        End With
        With sqlAdapter1
            .SelectCommand = SQLCmd1
            .Fill(table)
        End With
        Dim mydata As MySqlDataReader
        mydata = SQLCmd1.ExecuteReader()
        If (mydata.HasRows = 0) Then
            errornum = 1
            MsgBox("Error : Invalid Employee Badge No. ", MsgBoxStyle.Exclamation)
        Else
            INDate = table.Rows(0)("in_date").ToString
            accno = table.Rows(0)("out_accno").ToString
            code = table.Rows(0)("out_code").ToString
        End If
        dbcon1.Close()

    End Sub
    Public Sub MakeEntries()
        Dim currentDate As Date
        Dim sqlCmd As New MySqlCommand
        Dim dateString As String

        currentDate = sdate


        While (DateDiff("d", edate, currentDate) <= 0)
            checkEntered(currentDate)
            If entered = 1 Then
                entered = 0
            Else
                If dbcon.State = ConnectionState.Closed Then
                    dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
                    dbcon.Open()
                End If
                dateString =Format(currentDate, "yyyy-MM-dd")
                Dim sqlQ As String = "insert into ts.leaveT (`badge_no`,`adate`) VALUES ('" & textBadge.Text & "','" & dateString & "');"

                Try

                    With sqlCmd
                        .CommandText = sqlQ
                        .Connection = dbcon
                        .ExecuteNonQuery()
                    End With
                    ' MsgBox(textBadge.Text & " Attended on" & TextDate.Text)...Make Success Dialogue
                    dbcon.Close()

                Catch myerror As MySqlException
                    MsgBox("Error : While Adding Records ")

                End Try
            End If
            currentDate = DateAdd("d", 1, currentDate)
        End While

    End Sub


    Private Sub AbsentRange_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
       Dispose()

        dbcon.Close()
        dbcon1.Close()

    End Sub

    Private Sub AbsentRange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dbcon As New MySqlConnection
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon.Open()
        End If
        Dim strQuery As String = "SELECT badge_no,ename from ts.employee;"
        Dim sqlAdapter As New MySqlDataAdapter
        Dim SQLCmd As New MySqlCommand

        Dim table1 As New DataTable
        Dim i As Integer

        'Prepare connection and query
        With SQLCmd
            .CommandText = strQuery
            .Connection = dbcon
        End With
        With sqlAdapter
            .SelectCommand = SQLCmd
            .Fill(table1)
        End With
        For i = 0 To table1.Rows.Count - 1

            ComboBoxEmpBadge.Items.Add(table1.Rows(i)("badge_no") & " : " & table1.Rows(i)("ename"))
        Next
    End Sub
End Class