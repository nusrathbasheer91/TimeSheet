Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class EditTransfer

    Public badge As String
    Public dbcon As New MySqlConnection
    Public dbcon2 As New MySqlConnection
    Public form As String
    'Public code As String
    'Public accno As String
    'Public datest As String
    Public in_code As String
    Public in_accno As String
    Public in_date As String
    Public out_code As String
    Public out_date As String
    Public out_accno As String
    Public errornum As Integer


    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()

    End Sub

    Public Sub CheckPC(ByVal code As String)
        If dbcon2.State = ConnectionState.Closed Then
            dbcon2.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon2.Open()
        End If

        Dim sqlQ1 As String = "SELECT * from profitc where code='" & code & "'"
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
        If mydata.HasRows = 0 Then
            MsgBox("Error : invalid Transfer Out Code", MsgBoxStyle.Exclamation)
            errornum = 1

        End If

        dbcon2.Close()

    End Sub

    Public Sub CheckAcc(ByVal accno As String)

        If dbcon2.State = ConnectionState.Closed Then
            dbcon2.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon2.Open()
        End If

        Dim sqlQ1 As String = "SELECT * from camp where accno='" & accno & "'"
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
        If mydata.HasRows = 0 Then
            MsgBox("Error : invalid Transfer Out Accno", MsgBoxStyle.Exclamation)
            errornum = 1
        End If

        dbcon2.Close()

    End Sub

    Private Sub ButtonUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUpdate.Click
        TextInDate.Text = Format(DateTimePicker1.Value.Date, "yyyy-MM-dd")
        TextOutDate.Text = Format(DateTimePicker2.Value.Date, "yyyy-MM-dd")
        If (Textinaccno.Text = "" Or Textincode.Text = "" Or TextInDate.Text = "" Or TextOutAccno.Text = "" Or TextOutCode.Text = "" Or TextOutDate.Text = "") Then
            MsgBox("Error : Fields Are Empty", MsgBoxStyle.Exclamation)
            errornum = 1
        ElseIf (DateDiff("d", TextOutDate.Text, TextInDate.Text) >= 0) Then
            MsgBox("Error : invalid OutDate : InDate and OutDate should differ by atleast ONE Day", MsgBoxStyle.Exclamation)
            errornum = 1
        ElseIf (Textinaccno.Text = TextOutAccno.Text And Textincode.Text = TextOutCode.Text) Then
            MsgBox("ERROR : Current Code and Accno And Transfer out Code and Accno SAME ", MsgBoxStyle.Exclamation)
        Else
            If errornum = 0 Then
                CheckAcc(TextOutAccno.Text)
            End If
            If errornum = 0 Then
                CheckPC(TextOutCode.Text)
            End If
            If errornum = 0 Then
                CheckOutDate()
            End If
            If errornum = 0 Then
                CheckInDate()
            End If

            If dbcon.State = ConnectionState.Closed Then
                dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
                dbcon.Open()
            End If
            Dim sqlQ As String
            Dim indate As String = Format(Convert.ToDateTime(in_date), "yyyy-MM-dd")
            sqlQ = "update transfers set out_date='" & Format(Convert.ToDateTime(TextOutDate.Text), "yyyy-MM-dd") & "',in_date='" & Format(Convert.ToDateTime(TextInDate.Text), "yyyy-MM-dd") & "',out_code='" & TextOutCode.Text & "',out_accno='" & TextOutAccno.Text & "' where badge_no='" & badge & "' and in_date='" & indate & "';"

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

            dbcon.Close()

        End If

        ViewTransferDetails.GetDBData()
        If (form = "FormViewEmp") Then
            FormViewEmp.GetDBData()
        ElseIf (form = "ViewAllEmps") Then
            ViewAllEmps.GetDBData()
        End If
        errornum = 0
    End Sub

    Private Sub EditTransfer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dbcon.Close()
        dbcon2.Close()
        Dispose()

    End Sub

    Private Sub EditTransfer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Textinaccno.Text = in_accno
        Textincode.Text = in_code
        DateTimePicker1.Value = Convert.ToDateTime(in_date)
        TextOutAccno.Text = out_accno
        TextOutCode.Text = out_code
        DateTimePicker2.Value = Convert.ToDateTime(out_date)
    End Sub

    Public Sub CheckOutDate()
        Dim indate As String
        indate = Format(Convert.ToDateTime(in_date), "yyyy-MM-dd")
        If dbcon2.State = ConnectionState.Closed Then
            dbcon2.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon2.Open()
        End If

        Dim sqlQ1 As String = "select in_date from transfers where badge_no='" & badge & "' and in_date>'" & indate & "' order by in_date asc;"
        Dim sqlAdapter1 As New MySqlDataAdapter
        Dim SQLCmd1 As New MySqlCommand
        Dim table As New DataTable

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
            'NO RESTRICTIONS
        ElseIf (DateDiff("d", TextOutDate.Text, table.Rows(0)("in_date")) < 0) Then

            MsgBox("Error : invalid OutDate : OutDate and Next Entry of InDate should differ by atleast ONE Day", MsgBoxStyle.Exclamation)
            errornum = 1
        End If

        dbcon2.Close()
    End Sub

    Public Sub CheckInDate()
        Dim indate As String
        indate = Format(Convert.ToDateTime(in_date), "yyyy-MM-dd")
        If dbcon2.State = ConnectionState.Closed Then
            dbcon2.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon2.Open()
        End If

        Dim sqlQ1 As String = "select out_date from transfers where badge_no='" & badge & "' and in_date<'" & indate & "' order by out_date desc;"
        Dim sqlAdapter1 As New MySqlDataAdapter
        Dim SQLCmd1 As New MySqlCommand
        Dim table As New DataTable

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
            'NO RESTRICTIONS
        ElseIf (DateDiff("d", TextInDate.Text, table.Rows(0)("out_date")) > 0) Then

            MsgBox("Error : invalid OutDate : InDate and Previous Entry of OutDate should differ by atleast ONE Day", MsgBoxStyle.Exclamation)
            errornum = 1
        End If

        dbcon2.Close()
    End Sub

End Class