Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class AddEmp
    Public dbcon As New MySqlConnection
    Public dbcon1 As New MySqlConnection
    Public dbcon2 As New MySqlConnection
    Friend form As String
    Public inaccno As String
    Public incode As String
    Public errornum As Integer


    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        
        TextInDate.Text = Format(DateTimePicker2.Value.Date, "yyyy-MM-dd")

        If (TextID.Text <> "") Then
            CheckID()
        End If


        If Not (IsNothing(ComboBoxAccNo.SelectedItem)) Then
            Dim S As String() = ComboBoxAccNo.SelectedItem.Split(" ")
            Textaccno.Text = S(0)
        End If
        If Not (IsNothing(ComboBoxTAccno.SelectedItem)) Then
            Dim S As String() = ComboBoxTAccno.SelectedItem.Split(" ")
            Textinaccno.Text = S(0)
        End If
        If Not (IsNothing(ComboBoxCode.SelectedItem)) Then
            Dim S As String() = ComboBoxCode.SelectedItem.Split(" ")
            Textcode.Text = S(0)
        End If
        If Not (IsNothing(ComboBoxTCode.SelectedItem)) Then
            Dim S As String() = ComboBoxTCode.SelectedItem.Split(" ")
            Textincode.Text = S(0)
        End If
        If (Textaccno.Text = "" Or Textbadge.Text = "" Or Textename.Text = "" Or Textcode.Text = "") Then
            MsgBox("Empty Fields", MsgBoxStyle.Exclamation)
            errornum = 1
        Else
            CheckAcc()

        End If


        If (Textinaccno.Text = "") Then
            inaccno = "new"
        Else
            inaccno = Textinaccno.Text
            CheckInAcc()

        End If
        If (Textincode.Text = "") Then
            incode = "new"
        Else
            incode = Textincode.Text
            CheckPC()

        End If
        If (Not IsDate(Textdob.Text)) And errornum = 0 And Textdob.Text <> "" Then
            MsgBox("Error : Invalid DOB Date Format ", MsgBoxStyle.Exclamation)
            errornum = 1
        Else
            If dbcon.State = ConnectionState.Closed Then
                dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
                dbcon.Open()
            End If


            Dim sqlQ As String = "insert into ts.employee (`badge_no`,`accno`,`code`,`ename`,`next_med`,`dob`,`nationality`,`id`) VALUES ('" & Textbadge.Text & "','" & Textaccno.Text & "','" & Textcode.Text & "','" & Textename.Text & "',Date_add('" & TextLastMed.Text & "',interval 365 day),'" & Textdob.Text & "','" & Textnat.Text & "','" & TextID.Text & "'); insert into ts.transfers (`out_accno`,`out_code`,`badge_no`,`in_accno`,`in_code`,`in_date`) VALUES ('" & Textaccno.Text & "','" & Textcode.Text & "','" & Textbadge.Text & "','" & inaccno & "','" & incode & "','" & TextInDate.Text & "'); update ts.camp set occupied=occupied+1 where accno='" & Textaccno.Text & "';"
            If (Textdob.Text <> "" And TextLastMed.Text = "") Then
                sqlQ = "insert into ts.employee (`badge_no`,`accno`,`code`,`ename`,`next_med`,`dob`,`nationality`,`id`) VALUES ('" & Textbadge.Text & "','" & Textaccno.Text & "','" & Textcode.Text & "','" & Textename.Text & "',Date_add(curdate(),interval 365 day),'" & Textdob.Text & "','" & Textnat.Text & "','" & TextID.Text & "');insert into ts.transfers (`out_accno`,`out_code`,`badge_no`,`in_accno`,`in_code`,`in_date`) VALUES ('" & Textaccno.Text & "','" & Textcode.Text & "','" & Textbadge.Text & "','" & inaccno & "','" & incode & "','" & TextInDate.Text & "'); update ts.camp set occupied=occupied+1 where accno='" & Textaccno.Text & "';"
            ElseIf (Textdob.Text = "" And TextLastMed.Text = "") Then
                sqlQ = "insert into ts.employee (`badge_no`,`accno`,`code`,`ename`,`next_med`,`nationality`,`id`) VALUES ('" & Textbadge.Text & "','" & Textaccno.Text & "','" & Textcode.Text & "','" & Textename.Text & "',Date_add(curdate(),interval 365 day),'" & Textnat.Text & "','" & TextID.Text & "'); insert into ts.transfers (`out_accno`,`out_code`,`badge_no`,`in_accno`,`in_code`,`in_date`) VALUES ('" & Textaccno.Text & "','" & Textcode.Text & "','" & Textbadge.Text & "','" & inaccno & "','" & incode & "','" & TextInDate.Text & "');update ts.camp set occupied=occupied+1 where accno='" & Textaccno.Text & "';"
            ElseIf (Textdob.Text = "") Then
                sqlQ = "insert into ts.employee (`badge_no`,`accno`,`code`,`ename`,`next_med`,`nationality`,`id`) VALUES ('" & Textbadge.Text & "','" & Textaccno.Text & "','" & Textcode.Text & "','" & Textename.Text & "',Date_add('" & TextLastMed.Text & "',interval 365 day),'" & Textnat.Text & "','" & TextID.Text & "');insert into ts.transfers (`out_accno`,`out_code`,`badge_no`,`in_accno`,`in_code`,`in_date`) VALUES ('" & Textaccno.Text & "','" & Textcode.Text & "','" & Textbadge.Text & "','" & inaccno & "','" & incode & "','" & TextInDate.Text & "'); update ts.camp set occupied=occupied+1 where accno='" & Textaccno.Text & "';"

            End If

            Dim sqlCmd As New MySqlCommand
            ''''''''''''''''
            Dim sqlQ1 As String = "SELECT * from employee where badge_no='" & Textbadge.Text & "'"
            Dim sqlAdapter1 As New MySqlDataAdapter
            Dim SQLCmd1 As New MySqlCommand

            'Prepare connection and query
            With SQLCmd1
                .CommandText = sqlQ1
                .Connection = dbcon
            End With
            With sqlAdapter1
                .SelectCommand = SQLCmd1
            End With
            Dim mydata As MySqlDataReader
            mydata = SQLCmd1.ExecuteReader()
            If (mydata.HasRows = 0 And errornum = 0) Then
                If dbcon1.State = ConnectionState.Closed Then
                    dbcon1.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
                    dbcon1.Open()


                End If
                Try

                    With sqlCmd
                        .CommandText = sqlQ
                        .Connection = dbcon1
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Added new record")
                    If form = "ViewAllEmps" Then
                        ViewAllEmps.GetDBData()
                    End If

                    Dispose()
                    Close()
                Catch myerror As MySqlException
                    MsgBox("Error : invalid entry")

                End Try

            Else

                If errornum = 0 Then
                    MsgBox("Duplicate Badge No.")
                    dbcon.Close()
                    dbcon1.Close()
                End If
            End If
            dbcon.Close()
            dbcon1.Close()
        End If
        errornum = 0
    End Sub

    Public Sub CheckPC()
        If dbcon2.State = ConnectionState.Closed Then
            dbcon2.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon2.Open()
        End If

        Dim sqlQ1 As String = "SELECT * from profitc where code='" & Textincode.Text & "'"
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
            MsgBox("Error : invalid Transfer In Code", MsgBoxStyle.Exclamation)
            errornum = 1

        End If

        dbcon2.Close()

    End Sub

    Public Sub CheckInAcc()

        If dbcon2.State = ConnectionState.Closed Then
            dbcon2.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon2.Open()
        End If

        Dim sqlQ1 As String = "SELECT * from camp where accno='" & Textinaccno.Text & "'"
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
            MsgBox("Error : invalid Transfer In Accno", MsgBoxStyle.Exclamation)
            errornum = 1

        End If

        dbcon2.Close()

    End Sub


    Public Sub CheckAcc()

        If dbcon2.State = ConnectionState.Closed Then
            dbcon2.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon2.Open()
        End If

        Dim sqlQ1 As String = "SELECT * from camp where accno='" & Textaccno.Text & "'"
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
            MsgBox("Error : invalid Transfer In Accno", MsgBoxStyle.Exclamation)
            errornum = 1
        ElseIf (table.Rows(0)("occupied") >= table.Rows(0)("capacity")) Then
            MsgBox("Error : Accommodation is currently FULL", MsgBoxStyle.Exclamation)
            errornum = 1
        End If

        dbcon2.Close()

    End Sub

    Public Sub CheckID()

        If dbcon2.State = ConnectionState.Closed Then
            dbcon2.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon2.Open()
        End If

        Dim sqlQ1 As String = "SELECT * from employee where id='" & TextID.Text & "' and code='" & Textcode.Text & "'; "
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
            MsgBox("Error : Duplicate ID in Profit Centre", MsgBoxStyle.Exclamation)
            errornum = 1
        End If

        dbcon2.Close()

    End Sub

    Private Sub AddEmp_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
        dbcon.Close()
        dbcon2.Close()
        dbcon1.Close()

    End Sub

 
    Private Sub AddEmp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dbcon As New MySqlConnection
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon.Open()
        End If
        Dim strQuery As String = "SELECT accno,campname from ts.camp"
        Dim sqlAdapter As New MySqlDataAdapter
        Dim SQLCmd As New MySqlCommand
        Dim table As New DataTable
        Dim table1 As New DataTable
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
        For i = 0 To table.Rows.Count - 1

            ComboBoxAccNo.Items.Add(table.Rows(i)("accno") & " : " & table.Rows(i)("campname"))
            ComboBoxTAccno.Items.Add(table.Rows(i)("accno") & " : " & table.Rows(i)("campname"))
        Next
        dbcon.Close()

        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon.Open()
        End If
        strQuery = "SELECT code,pname from ts.profitc;"
      


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

            ComboBoxCode.Items.Add(table1.Rows(i)("code") & " : " & table1.Rows(i)("pname"))
            ComboBoxTCode.Items.Add(table1.Rows(i)("code") & " : " & table1.Rows(i)("pname"))
        Next

    End Sub

    'Public Sub ClearText()
    '    'Dim X As Control
    '    'For Each X In Me.Controls
    '    '    If TypeOf X Is TextBox Then
    '    '        X.Text = ""
    '    '    End If
    '    'Next X
    '    'ComboBoxAccNo.SelectedIndex = -1
    '    'ComboBoxCode.SelectedIndex = -1
    '    'ComboBoxTAccno.SelectedIndex = -1
    '    'ComboBoxTCode.SelectedIndex = -1
    '    'ComboBoxAccNo.Items.Clear()
    '    'ComboBoxCode.Items.Clear()
    '    'ComboBoxTAccno.Items.Clear()
    '    'ComboBoxTCode.Items.Clear()

    'End Sub

End Class