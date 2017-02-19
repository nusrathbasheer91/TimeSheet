Imports MySql.Data.MySqlClient
Imports MySql.Data


Public Class TransferEmployee

    Public badge As String
    Public accno As String
    Public code As String
    Public errornum As Integer
    Public dbcon As New MySqlConnection
    Public dbcon2 As New MySqlConnection

    Private Sub TransferEmployee_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dbcon.Close()
        dbcon2.Close()
        Dispose()
    End Sub

    Private Sub TransferEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Next
        dbcon.Close()

        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon.Open()
        End If
        strQuery = "SELECT concat(badge_no,' : ',ename)as ename,badge_no from ts.employee;"
        Dim dataS As New DataSet

        'Prepare connection and query
        With SQLCmd
            .CommandText = strQuery
            .Connection = dbcon
        End With
        With sqlAdapter
            .SelectCommand = SQLCmd
            .Fill(dataS)
        End With
        'For i = 0 To table2.Rows.Count - 1

        '    ComboBoxEmpBadge.Items.Add(table2.Rows(i)("badge_no") & " : " & table2.Rows(i)("ename"))
        'Next
        ComboBoxEmpBadge.DataSource = dataS.Tables(0)
        ComboBoxEmpBadge.ValueMember = "badge_no"
        ComboBoxEmpBadge.DisplayMember = "ename"
        ComboBoxEmpBadge.SelectedIndex = -1
    End Sub

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()

    End Sub

    Private Sub ButtonTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTransfer.Click
        TextOutDate.Text = Format(DateTimePicker1.Value.Date, "yyyy-MM-dd")
        If Not (IsNothing(ComboBoxEmpBadge.SelectedItem)) Then

            txtBadge.Text = ComboBoxEmpBadge.SelectedValue

            badge = ComboBoxEmpBadge.SelectedValue

        End If
        If Not (IsNothing(ComboBoxAccNo.SelectedItem)) Then
            Dim S As String() = ComboBoxAccNo.SelectedItem.Split(" ")
            Textoutacc.Text = S(0)
        End If
        If Not (IsNothing(ComboBoxCode.SelectedItem)) Then
            Dim S As String() = ComboBoxCode.SelectedItem.Split(" ")
            Textoutcode.Text = S(0)
        End If
        If (Textoutacc.Text = "" Or Textoutcode.Text = "" Or TextOutDate.Text = "" Or txtBadge.Text = "") Then
            errornum = 1
            MsgBox("Fields are Empty")
            Dispose()
            Me.Close()
        Else
            GetAccCode()
            CheckID()
            If (Textoutcode.Text <> "") And errornum = 0 Then
                CheckPC()
                ''inpc = code
                'code = Textoutcode.Text
            End If

            If (TextOutDate.Text <> "") And errornum = 0 Then
                CheckDate()
            End If

            If (Textoutacc.Text <> "") And errornum = 0 Then
                CheckAcc()
                ''inacc = accno
                'accno = Textoutacc.Text

            End If
            If (accno = Textoutacc.Text And code = Textoutcode.Text) Then
                MsgBox("ERROR : Current Code and Accno And Transfer out Code and Accno SAME ", MsgBoxStyle.Exclamation)

            Else
                If errornum = 0 Then
                    CheckCap()
                End If
                If errornum = 0 Then
                    If dbcon.State = ConnectionState.Closed Then
                        dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
                        dbcon.Open()
                    End If
                    TextOutDate.Text = Format(Convert.ToDateTime(TextOutDate.Text), "yyyy-MM-dd")
                    Dim sqlQ As String = "update ts.camp set occupied=occupied-1 where accno='" & accno & "'; insert into transfers(in_date,in_code,in_accno,out_accno,out_code,badge_no) values ('" & TextOutDate.Text & "','" & code & "','" & accno & "','" & Textoutacc.Text & "','" & Textoutcode.Text & "','" & badge & "');update transfers set out_date='" & TextOutDate.Text & "' where badge_no='" & badge & "' and isnull(out_date) and out_code='" & code & "' and out_accno='" & accno & "';update employee set accno='" & Textoutacc.Text & "',code='" & Textoutcode.Text & "' where badge_no='" & badge & "';update ts.camp set occupied=occupied+1 where accno='" & Textoutacc.Text & "';"


                    Dim sqlCmd As New MySqlCommand
                    If errornum = 0 Then
                        'Try
                        With sqlCmd
                            .CommandText = sqlQ
                            .Connection = dbcon
                            .ExecuteNonQuery()
                        End With
                        MsgBox("Transfer Records Updated succesfully", MsgBoxStyle.Information)
                        'TransferDetails.inpc = inpc
                        TransferDetails.code = Textoutcode.Text
                        'TransferDetails.inacc = inacc
                        TransferDetails.accno = Textoutacc.Text
                        'GETDBDATA AGAIN
                        'If (Form = "FormViewEmp") Then
                        '    FormViewEmp.GetDBData()
                        'ElseIf (Form = "ViewAllEmps") Then
                        '    ViewAllEmps.GetDBData()
                        'End If
                        Dispose()
                        Me.Close()
                        'Catch myerror As MySqlException
                        'MsgBox("Error : invalid entries") 'any error like character return for integer field

                        'End Try
                    End If

                    dbcon.Close()


                End If
            End If
        End If

        errornum = 0

    End Sub



    Public Sub CheckPC()
        If dbcon2.State = ConnectionState.Closed Then
            dbcon2.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon2.Open()
        End If

        Dim sqlQ1 As String = "SELECT * from profitc where code='" & Textoutcode.Text & "'"
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

    Public Sub CheckAcc()

        If dbcon2.State = ConnectionState.Closed Then
            dbcon2.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon2.Open()
        End If

        Dim sqlQ1 As String = "SELECT * from camp where accno='" & Textoutacc.Text & "'"
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

    Public Sub CheckDate()

        If dbcon2.State = ConnectionState.Closed Then
            dbcon2.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon2.Open()
        End If

        Dim sqlQ1 As String = "select in_date from transfers where badge_no='" & badge & "' and isnull(out_date) ;"
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
            MsgBox("Error!! - 1-TEmp", MsgBoxStyle.Exclamation)
            errornum = 1
        ElseIf (DateDiff("d", TextOutDate.Text, table.Rows(0)("in_date")) >= 0) Then

            MsgBox("Error : invalid OutDate : InDate and OutDate should differ by atleast ONE Day :InDate is " & table.Rows(0)("in_date"), MsgBoxStyle.Exclamation)
            errornum = 1
        End If

        dbcon2.Close()
    End Sub
    Public Sub CheckCap()
        If dbcon2.State = ConnectionState.Closed Then
            dbcon2.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon2.Open()
        End If

        Dim sqlQ1 As String = "SELECT occupied,capacity from camp as c,employee as e where e.badge_no='" & badge & "' and c.accno='" & Textoutacc.Text & "'"
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
    Public Sub GetAccCode()
        If dbcon2.State = ConnectionState.Closed Then
            dbcon2.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon2.Open()
        End If

        Dim sqlQ1 As String = "SELECT accno,code from employee where badge_no='" & badge & "'"
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
                MsgBox("Error : invalid Badge Number", MsgBoxStyle.Exclamation)
                errornum = 1
            Else
                accno = table.Rows(0)("accno")
                code = table.Rows(0)("code")
            End If

        End If
        dbcon2.Close()
    End Sub

    Public Sub CheckID()

        If dbcon2.State = ConnectionState.Closed Then
            dbcon2.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon2.Open()
        End If

        Dim sqlQ1 As String = "SELECT id from employee where id= all(select id from employee where badge_no='" & badge & "') and code='" & Textoutcode.Text & "';"
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
        If mydata.HasRows <> 0 Then
            If table.Rows(0)("id").ToString <> "" Then
                MsgBox("Error : Duplicate ID in Profit Centre : Assign New ID To Employee First", MsgBoxStyle.Exclamation)
                errornum = 1
            End If
        End If

        dbcon2.Close()

    End Sub

    Private Sub ComboBoxAccNo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxAccNo.SelectedIndexChanged
        If ComboBoxAccNo.Items(ComboBoxAccNo.SelectedIndex).ToString() = "20 : VACATION" Then
            ComboBoxCode.SelectedIndex = ComboBoxCode.FindStringExact("VAC : VACATION")
        ElseIf ComboBoxAccNo.Items(ComboBoxAccNo.SelectedIndex).ToString() = "21 : EXIT" Then
            ComboBoxCode.SelectedIndex = ComboBoxCode.FindStringExact("EXIT : EXIT")
        Else
            ComboBoxCode.SelectedIndex = -1
        End If
    End Sub
End Class