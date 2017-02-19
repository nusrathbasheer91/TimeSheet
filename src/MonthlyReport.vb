Imports MySql.Data.MySqlClient
Imports MySql.Data


Public Class MonthlyReport
    Dim SubRows(40) As Integer
    Dim SubRowCount As Integer = 0
    Dim RowCount As Integer
    Dim Code As String
    'Dim RowNumbers As String
    Dim MaxCol As Integer
    Dim oExcel As Object
    Dim oBook As Object
    Dim oSheet As Object
    Dim FileToSave As String
    Public errornum As Integer
    Public sdate As Date
    Public edate As Date
    Public dbcon2 As New MySqlConnection
    Public dbcon As New MySqlConnection



    Private Sub ButtonChPwdAd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonChPwdAd.Click
        TextDateStart.Text = Format(DateTimePicker1.Value.Date, "yyyy-MM-dd")
        TextDateEnd.Text = Format(DateTimePicker2.Value.Date, "yyyy-MM-dd")

        If Not (IsNothing(ComboBoxAccNo.SelectedItem)) Then
            Dim S As String() = ComboBoxAccNo.SelectedItem.Split(" ")
            Textaccno.Text = S(0)
        End If

        If TextDateEnd.Text = "" And TextDateStart.Text = "" And Textaccno.Text = "" Then
            ' CheckAcc()
            'CheckDate()

            MsgBox("Error : Fields are Empty ", MsgBoxStyle.Exclamation)
            errornum = 1
        ElseIf errornum = 0 Then
            edate = TextDateEnd.Text
            sdate = TextDateStart.Text
        End If
        If errornum = 1 Then
            errornum = 0
            'FIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            'ElseIf DateDiff("d", Today, edate) > 0 Then
            '    MsgBox("Error : Invalid End Date : Should not include date beyond Today", MsgBoxStyle.Exclamation)
        ElseIf DateDiff("d", edate, sdate) >= 0 Then
            MsgBox("Error : Start Date and End Date should differ by atleast 1 day", MsgBoxStyle.Exclamation)

        ElseIf DateDiff("d", sdate, edate) > 31 Then
            MsgBox("Error : Start Date and End Date should differ by atmost 31 days", MsgBoxStyle.Exclamation)
        ElseIf errornum = 0 Then

            If errornum = 0 Then
                'Excel MADE
                MakeExcel()
            End If

            errornum = 0
        End If
    End Sub


    Public Sub MakeExcel()

        oBook = oExcel.Workbooks.Add
        oSheet = oBook.Worksheets(1)

        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon.Open()
        End If

        'Try

        'PrintColumnNames() '''''''change so that columns come every profitc
        PrintPCs()



        If (errornum = 0) Then
            PrintSummary()
            WidthAdjust()
        End If

        ' PrintEmpDetails()
        'PrintAttendance()

        'PrintTotal()

        'Catch
        ' MsgBox("ERROR", MsgBoxStyle.Exclamation)
        ' End Try

        If (errornum = 0) Then
            SaveFileDialog1.ShowDialog()
            FileToSave = SaveFileDialog1.FileName
            Try
                oBook.SaveAs(FileToSave)
                MsgBox("File Saved Successfully", MsgBoxStyle.Information)
                SaveFileDialog1.FileName = ""
                oExcel.Quit()
                Me.Close()
            Catch
                MsgBox("File Not Saved", MsgBoxStyle.Exclamation)
                oExcel.DisplayAlerts = False
                oExcel.Quit()
                oExcel.DisplayAlerts = True
            End Try
        End If
    End Sub

    Public Sub PrintPCs()
        Dim dbcon4 As New MySqlConnection
        Dim table As New DataTable
        Dim i As Integer
        Dim sqlQ As String = "Select coname,p.pname,t.out_code,campname,c.client_name,c.client_id from client as c,company,profitc as p,camp,transfers as t where c.client_id=p.client_id and p.accno=camp.accno and p.code=t.out_code and t.out_accno='" & Textaccno.Text & "' group by t.out_code;"
        Dim sqlAdapter As New MySqlDataAdapter
        Dim SQLCmd As New MySqlCommand
        If dbcon4.State = ConnectionState.Closed Then
            dbcon4.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon4.Open()
        End If
        'Try
        With SQLCmd
            .CommandText = sqlQ
            .Connection = dbcon4
        End With
        With sqlAdapter
            .SelectCommand = SQLCmd
            .Fill(table)
        End With
        If table.Rows.Count <> 0 Then


            With oSheet
                .Cells(1, 1).value = "Company NAME"
                .Cells(1, 1).font.bold = True
                .Cells(1, 2).value = table.Rows(i)("coname")
                .Cells(1, 2).font.size = 12
                .Cells(1, 2).font.bold = True
                .Cells(2, 1).value = Textaccno.Text
                .Cells(2, 1).font.bold = True
                .Cells(2, 2).value = table.Rows(i)("campname")
                .Cells(2, 2).font.bold = True
            End With
            RowCount = 3
            For i = 0 To table.Rows.Count - 1

                With oSheet
                    .Cells(RowCount, 1).value = table.Rows(i)("out_code")
                    .Cells(RowCount, 1).font.bold = True
                    .Cells(RowCount, 2).value = table.Rows(i)("pname")
                    .Cells(RowCount, 2).font.bold = True
                    .Cells(RowCount, 3).value = "CLIENT => client_id,client_name"
                    .Cells(RowCount, 3).font.bold = True
                    .Cells(RowCount, 4).value = table.Rows(i)("client_id")
                    .Cells(RowCount, 4).font.bold = True
                    .Cells(RowCount, 5).value = table.Rows(i)("client_name")
                    .Cells(RowCount, 5).font.bold = True
                End With
                Code = table.Rows(i)("out_code")
                PrintColumnNames()


            Next


            'Catch
            'MsgBox("ERROR", MsgBoxStyle.Exclamation)
            'errornum = 1
            'End Try
        Else

            MsgBox("ERROR : No Records For this AccNo", MsgBoxStyle.Exclamation)
            errornum = 1
        End If
        If (errornum = 0) Then

            RowCount -= 1
            PrintGrandTotal()
        End If
    End Sub

    Public Sub PrintColumnNames()
        Dim ColCount As Integer
        Dim date1 As Date = sdate
        Dim date2 As Date = edate
        RowCount += 1
        oSheet.Cells(RowCount, 1).Value = "Sl.No"
        oSheet.Cells(RowCount, 2).Value = "Badge_No"
        oSheet.Cells(RowCount, 3).Value = "Employee Name"
        oSheet.Cells(RowCount, 4).Value = "Profit Centre Code"
        oSheet.Cells(RowCount, 5).Value = "Profit Centre Name"
        oSheet.Cells(RowCount, 6).Value = "Transfer IN Date"
        oSheet.Cells(RowCount, 7).Value = "Transfer Out Date"
        oSheet.Cells(RowCount, 8).Value = "CheckOut Date"

        ColCount = 9

        While (DateDiff("d", date2, date1) <= 0)
            oSheet.Cells(RowCount, ColCount).Value = Format(date1, "yyyy-MM-dd")
            ColCount += 1
            date1 = DateAdd("d", 1, date1)
        End While
        MaxCol = ColCount
        oSheet.Cells(RowCount, ColCount).Value = "Days Stayed"

        While (ColCount <> 0)
            oSheet.cells(RowCount, ColCount).Interior.Color = RGB(250, 250, 137)
            ColCount -= 1
        End While
        RowCount += 1
        PrintEmpDetails()
    End Sub

    Public Sub PrintEmpDetails()
        Dim dbcon3 As New MySqlConnection
        Dim table As New DataTable
        Dim i As Integer
        Dim slno As Integer = 1
        Dim sqlQ As String = "Select e.badge_no,ename,t.in_date as transferindate,t.out_date as transferoutdate,e.out_date,p.pname,t.out_code,t.in_code,t.in_accno,t.out_accno from employee as e,profitc as p,transfers as t where p.code=t.out_code and t.out_code='" & Code & "' and t.out_accno='" & Textaccno.Text & "' and t.in_date<='" & TextDateEnd.Text & "' and e.badge_no=t.badge_no order by e.badge_no asc,t.in_date asc;"

        Dim sqlAdapter As New MySqlDataAdapter
        Dim SQLCmd As New MySqlCommand
        If dbcon3.State = ConnectionState.Closed Then
            dbcon3.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon3.Open()
        End If
        'Prepare connection and query
        ' Try
        With SQLCmd
            .CommandText = sqlQ
            .Connection = dbcon3
        End With
        With sqlAdapter
            .SelectCommand = SQLCmd
            .Fill(table)
        End With
        For i = 0 To table.Rows.Count - 1
            If (i = 0) Then

                With oSheet
                    .Cells(RowCount, 1).Value = slno.ToString
                    .Cells(RowCount, 2).value = table.Rows(i)("badge_no")

                    .Cells(RowCount, 3).value = table.Rows(i)("ename")
                    .Cells(RowCount, 4).value = table.Rows(i)("out_code")
                    .Cells(RowCount, 5).value = table.Rows(i)("pname")
                    .Cells(RowCount, 6).value = Format(Convert.ToDateTime(table.Rows(i)("transferindate")), "yyyy-MM-dd")
                    If (table.Rows(i)("transferoutdate").ToString <> "") Then
                        oSheet.Cells(RowCount, 7).value = Format(Convert.ToDateTime(table.Rows(i)("transferoutdate")), "yyyy-MM-dd")
                        '''''''''''''''''''''''
                    Else
                        oSheet.Cells(RowCount, 7).value = ""
                    End If
                    If (table.Rows(i)("out_date").ToString <> "") Then
                        .Cells(RowCount, 8).value = Format(Convert.ToDateTime(table.Rows(i)("out_date")), "yyyy-MM-dd")
                        '''''''''''''''''''''''
                    End If

                End With
                If (table.Rows(i)("transferoutdate").ToString <> "") Then
                    PrintAttendance(RowCount, table.Rows(i)("transferindate").ToString, table.Rows(i)("transferoutdate").ToString, slno)
                Else
                    PrintAttendance(RowCount, table.Rows(i)("transferindate").ToString, table.Rows(i)("out_date").ToString, slno)
                End If
            ElseIf (table.Rows(i)("badge_no") = table.Rows(i - 1)("badge_no")) Then

                slno -= 1
                RowCount -= 1
                If (table.Rows(i)("transferoutdate").ToString <> "") Then
                    oSheet.Cells(RowCount, 7).value = Format(Convert.ToDateTime(table.Rows(i)("transferoutdate")), "yyyy-MM-dd")
                Else
                    oSheet.Cells(RowCount, 7).value = ""
                    '''''''''''''''''''''''
                End If
                If (table.Rows(i)("transferoutdate").ToString <> "") Then
                    PrintAttendance(RowCount, table.Rows(i)("transferindate").ToString, table.Rows(i)("transferoutdate").ToString, slno)
                Else
                    PrintAttendance(RowCount, table.Rows(i)("transferindate").ToString, table.Rows(i)("out_date").ToString, slno)
                End If
            Else
                With oSheet
                    .Cells(RowCount, 1).Value = slno.ToString
                    .Cells(RowCount, 2).value = table.Rows(i)("badge_no")
                    .Cells(RowCount, 3).value = table.Rows(i)("ename")
                    .Cells(RowCount, 4).value = table.Rows(i)("out_code")
                    .Cells(RowCount, 5).value = table.Rows(i)("pname")
                    .Cells(RowCount, 6).value = Format(Convert.ToDateTime(table.Rows(i)("transferindate")), "yyyy-MM-dd")
                    If (table.Rows(i)("transferoutdate").ToString <> "") Then
                        oSheet.Cells(RowCount, 7).value = Format(Convert.ToDateTime(table.Rows(i)("transferoutdate")), "yyyy-MM-dd")
                    Else
                        oSheet.Cells(RowCount, 7).value = ""
                        '''''''''''''''''''''''
                    End If
                    If (table.Rows(i)("out_date").ToString <> "") Then
                        .Cells(RowCount, 8).value = Format(Convert.ToDateTime(table.Rows(i)("out_date")), "yyyy-MM-dd")
                        '''''''''''''''''''''''
                    End If
                End With
                If (table.Rows(i)("transferoutdate").ToString <> "") Then
                    PrintAttendance(RowCount, table.Rows(i)("transferindate").ToString, table.Rows(i)("transferoutdate").ToString, slno)
                Else
                    PrintAttendance(RowCount, table.Rows(i)("transferindate").ToString, table.Rows(i)("out_date").ToString, slno)
                End If

            End If



            slno += 1
            RowCount += 1
        Next

        PrintTotal(RowCount - slno, RowCount - 1)
        RowCount += 1

        'Catch
        'MsgBox("ERROR", MsgBoxStyle.Exclamation)
        'End Try
        'MaxEmp += table.Rows.Count
        dbcon3.Close()

    End Sub

    Public Sub PrintAttendance(ByVal Row As Integer, ByVal date1 As String, ByVal date2 As String, ByVal slno As Integer)
        Dim Column As Integer = 9
        Dim CurrentDate As Date
        Dim dateS As Date = Format(Convert.ToDateTime(date1), "yyyy-MM-dd")
        Dim dateE As Date
        Dim Total As Integer
        If (date2 = "") Then
            dateE = DateAdd("d", 1, edate)
        Else
            dateE = Format(Convert.ToDateTime(date2), "yyyy-MM-dd")
        End If
        If (DateDiff("d", dateS, sdate) > 0) Then
            dateS = sdate
        End If
        If (DateDiff("d", dateE, edate) < 0) Then
            dateE = DateAdd("d", 1, edate)
        End If
        CurrentDate = dateS


        Try

            While (Column < MaxCol And oSheet.Cells(Row - slno, Column).Value <> dateS)
                Column += 1
            End While
        Catch ex As Exception

        End Try
        While (DateDiff("d", CurrentDate, dateE) > 0)
            oSheet.Cells(Row, Column).Value = "X"
            Total += 1
            Column += 1
            CurrentDate = DateAdd("d", 1, CurrentDate)
        End While
        oSheet.Cells(Row, 9 + DateDiff("d", sdate, edate) + 1).Value += Total.ToString
        PrintAbsence(Row, slno)



    End Sub

    Public Sub PrintAbsence(ByVal Row As Integer, ByVal slno As Integer)
        Dim badge As String = oSheet.Cells(Row, 2).Value
        Dim code As String = oSheet.Cells(Row, 4).Value
        Dim accno As String = Textaccno.Text
        Dim Column As Integer = 9
        Dim dbcon3 As New MySqlConnection
        If dbcon3.State = ConnectionState.Closed Then
            dbcon3.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon3.Open()
        End If

        Dim strQuery As String = "SELECT adate from leaveT where badge_no='" & badge & "'"
        Dim sqlAdapter As New MySqlDataAdapter
        Dim SQLCmd As New MySqlCommand
        Dim table As New DataTable
        Dim i As Integer


        'Prepare connection and query
        With SQLCmd
            .CommandText = strQuery
            .Connection = dbcon3
        End With
        With sqlAdapter
            .SelectCommand = SQLCmd
            .Fill(table)

        End With
        'CLears the table before loading

        Dim mydata As MySqlDataReader
        mydata = SQLCmd.ExecuteReader()
        If (mydata.HasRows <> 0) Then
            i = 0
            While (Column < MaxCol)
                If (oSheet.Cells(Row - slno, Column).Value = table.Rows(i)("adate") And oSheet.Cells(Row, Column).Value <> "") Then
                    oSheet.Cells(Row, Column).Value = ""
                    oSheet.Cells(Row, MaxCol).Value -= 1
                    If (i < table.Rows.Count - 1) Then
                        i += 1
                    End If
                End If

                Column += 1
            End While
        End If
        '***********************************************

        dbcon3.Close()

    End Sub

    Public Sub PrintTotal(ByVal Row1 As Integer, ByVal Row2 As Integer)
        Dim Column As Integer = 9
        Dim Row As Integer = Row1 + 1
        Dim Total As Integer
        While (Column < MaxCol)
            Total = 0
            Row = Row1 + 1
            While (Row <= Row2)
                If (oSheet.cells(Row, Column).Value = "X") Then
                    Total += 1
                End If
                ' oSheet.cells(RowCount, Column).Exterior.Color = RGB(250, 250, 137)

                Row += 1
            End While
            oSheet.cells(Row, Column).value = Total.ToString
            Column += 1

        End While
        Total = 0
        Row = Row1 + 1
        While (Row <= Row2)
            Total += oSheet.cells(Row, MaxCol).value
            Row += 1
        End While

        oSheet.cells(Row, MaxCol).value = Total
        'Print Summary of employees price total day
        oSheet.cells(RowCount, 1).value = Code
        oSheet.cells(RowCount, 2).value = oSheet.cells(Row1 - 1, 2).value
        oSheet.cells(RowCount, 3).value = "SUBTOTAL"
        oSheet.Range(oSheet.Cells(RowCount, 1), oSheet.Cells(RowCount, MaxCol)).Font.Color = RGB(250, 250, 137)
        oSheet.Range(oSheet.Cells(RowCount, 1), oSheet.Cells(RowCount, MaxCol)).Interior.Color = RGB(40, 56, 151)
        oSheet.Range(oSheet.Cells(RowCount, 1), oSheet.Cells(RowCount, MaxCol)).Font.bold = True

        Try
            SubRows(SubRowCount) = RowCount
        Catch myexeption As IndexOutOfRangeException
            ReDim Preserve SubRows(SubRows.Length + 50)
            SubRows(SubRowCount) = RowCount
        End Try
        SubRowCount += 1
        RowCount += 1
    End Sub

    Public Sub PrintGrandTotal()
        Dim Column As Integer = 9
        Dim Row As Integer = 0
        Dim Row2 As Integer = RowCount
        Dim Total As Integer
        While (Column <= MaxCol)
            Total = 0
            Row = 1
            While (Row < Row2)


                If (oSheet.cells(Row, Column).Font.Color = RGB(250, 250, 137)) Then
                    Total += oSheet.cells(Row, Column).value
                End If

                Row += 1
            End While
            oSheet.cells(RowCount, Column).value = Total.ToString
            Column += 1

        End While
        oSheet.cells(RowCount, 1).value = "GRANDTOTAL"
        oSheet.Range(oSheet.Cells(RowCount, 1), oSheet.Cells(RowCount, MaxCol)).Font.Color = RGB(250, 250, 137)
        oSheet.Range(oSheet.Cells(RowCount, 1), oSheet.Cells(RowCount, MaxCol)).Interior.Color = RGB(138, 43, 45)
        oSheet.Range(oSheet.Cells(RowCount, 1), oSheet.Cells(RowCount, MaxCol)).Font.bold = True
        Try
            SubRows(SubRowCount) = RowCount
        Catch myexeption As IndexOutOfRangeException
            ReDim Preserve SubRows(SubRows.Length + 50)
            SubRows(SubRowCount) = RowCount
        End Try
        SubRowCount += 1
    End Sub

    Public Sub PrintSummary()
        RowCount += 5
        Dim RowCountI As Integer = RowCount
        oSheet.cells(RowCount - 1, 1).value = "SUMMARY"

        oSheet.Range(oSheet.Cells(RowCount - 1, 1), oSheet.Cells(RowCount - 1, MaxCol)).Interior.Color = RGB(250, 250, 137)
        oSheet.Range(oSheet.Cells(RowCount - 1, 1), oSheet.Cells(RowCount - 1, MaxCol)).Font.bold = True
        For Each RowCount1 As Integer In SubRows
            If RowCount1 = 0 Then
                Exit For
            End If
            oSheet.Rows(RowCount1).Copy()
            oSheet.Rows(RowCount).PasteSpecial()

            RowCount += 1
        Next

        oSheet.Range(oSheet.Cells(RowCountI, 1), oSheet.Cells(RowCount - 2, MaxCol)).Font.Color = RGB(250, 250, 137)
        oSheet.Range(oSheet.Cells(RowCountI, 1), oSheet.Cells(RowCount - 2, MaxCol)).Interior.Color = RGB(40, 56, 151)
        oSheet.Range(oSheet.Cells(RowCountI, 1), oSheet.Cells(RowCount - 2, MaxCol)).Font.bold = True

        oSheet.Range(oSheet.Cells(RowCount - 1, 1), oSheet.Cells(RowCount - 1, MaxCol)).Font.Color = RGB(250, 250, 137)
        oSheet.Range(oSheet.Cells(RowCount - 1, 1), oSheet.Cells(RowCount - 1, MaxCol)).Interior.Color = RGB(138, 43, 45)
        oSheet.Range(oSheet.Cells(RowCount - 1, 1), oSheet.Cells(RowCount - 1, MaxCol)).Font.bold = True


        SubRowCount = 0
        Array.Clear(SubRows, 0, 40)

    End Sub

    Private Sub MonthlyReport_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dbcon.Close()
        dbcon2.Close()
        Dispose()
    End Sub

    Private Sub MonthlyReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


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


        oExcel = CreateObject("Excel.Application")

    End Sub
    Public Sub WidthAdjust()
        oSheet.Range(oSheet.Columns(1), oSheet.Columns(MaxCol)).AutoFit()
    End Sub

End Class
