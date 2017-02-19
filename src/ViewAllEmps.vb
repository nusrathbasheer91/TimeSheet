Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class ViewAllEmps
    Public out As String
    Public badge As String
    Public accno As String
    Public code As String
    'Public inacc As String
    'Public inpc As String
    Public indate As String
    Public dbcon As New MySqlConnection
    Dim dataS As New DataSet
    Dim dataV As New DataView
    Dim sqlAdapter As New MySqlDataAdapter
    Dim SQLCmd As New MySqlCommand

    Private Sub ViewAllEmps_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dbcon.Close()
        Dispose()

    End Sub


    Private Sub ViewAllEmps_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        Dim strQuery As String = "select e.badge_no,ename,accno,code,id,tr_out,next_med,dob,nationality,e.out_date,t.in_date,t.in_code,t.in_accno,(if (TIMESTAMPDIFF(DAY, next_med, now())>0,'YES','NO')) as late from employee as e,transfers as t where e.badge_no=t.badge_no and isnull(t.out_date) order by e.code asc,e.badge_no asc ;"
        
        dataS.Clear()

        'Prepare connection and query
        With SQLCmd
            .CommandText = strQuery
            .Connection = dbcon
        End With
        With sqlAdapter
            .SelectCommand = SQLCmd
            '.Fill(table)
            .Fill(dataS)
        End With
        'CLears the table before loading
        'ListViewPC.Items.Clear()
        'DataGridView1.DataSource = Nothing
        'DataGridView1.Refresh()
        dataV.Table = dataS.Tables(0)
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = dataV
        DataGridView1.Refresh()
        DataGridView1.AutoResizeColumns()
        Dim i As Integer
        i = 0
        For Each Row As DataGridViewRow In DataGridView1.Rows

            If Row.Cells(13).Value = "YES" Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.IndianRed
                DataGridView1.Rows(i).DefaultCellStyle.SelectionBackColor = Color.IndianRed

            End If
            i += 1
        Next
        
            'For i = 0 To table.Rows.Count - 1
            '    With ListViewPC
            '        .Items.Add(table.Rows(i)("badge_no"))

            '        With .Items(.Items.Count - 1).SubItems
            '            .Add(table.Rows(i)("accno"))
            '            .Add(table.Rows(i)("code"))
            '            .Add(table.Rows(i)("ename"))
            '            .Add(table.Rows(i)("id").ToString)
            '            .Add(Convert.ToDateTime(table.Rows(i)("in_date")).ToShortDateString())
            '            If (table.Rows(i)("out_date").ToString = "") Then

            '                .Add("")
            '            Else
            '                '.Add(table.Rows(i)("out_date"))
            '                .Add(Convert.ToDateTime(table.Rows(i)("out_date")).ToShortDateString())
            '            End If
            '            .Add(table.Rows(i)("in_accno").ToString)
            '            .Add(table.Rows(i)("in_code").ToString)
            '            .Add(table.Rows(i)("tr_out").ToString)
            '            If (table.Rows(i)("dob").ToString = "") Then

            '                .Add("")
            '            Else
            '                .Add(Convert.ToDateTime(table.Rows(i)("dob")).ToShortDateString())
            '            End If
            '            .Add(table.Rows(i)("nationality").ToString)
            '            If (table.Rows(i)("next_med").ToString = "") Then

            '                .Add("")
            '            Else
            '                .Add(Convert.ToDateTime(table.Rows(i)("next_med")).ToShortDateString())
            '                If (DateDiff("d", Today, table.Rows(i)("next_med")) < 0) Then
            '                    ListViewPC.Items(i).BackColor = Color.Red
            '                End If
            '            End If
            '        End With
            '    End With

            'Next
            dbcon.Close()
    End Sub


    'Private Sub ListViewPC_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewPC.MouseClick
    '    If dbcon.State = ConnectionState.Closed Then
    '        dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
    '        dbcon.Open()
    '    End If
    '    badge = ListViewPC.SelectedItems(0).Text()

    '    Dim strQuery As String = "SELECT e.code,e.accno,e.tr_out,t.in_date from employee as e,transfers as t where t.badge_no=e.badge_no and e.badge_no='" & badge & "' and isnull(t.out_date) ; "
    '    Dim sqlAdapter As New MySqlDataAdapter
    '    Dim SQLCmd As New MySqlCommand
    '    Dim table As New DataTable


    '    'Prepare connection and query
    '    With SQLCmd
    '        .CommandText = strQuery
    '        .Connection = dbcon
    '    End With
    '    With sqlAdapter
    '        .SelectCommand = SQLCmd
    '        .Fill(table)

    '    End With
    '    code = table.Rows(0)("code").ToString
    '    accno = table.Rows(0)("accno").ToString
    '    'inacc = table.Rows(0)("tr_in_acc").ToString............................ SEE
    '    'inpc = table.Rows(0)("tr_in_pc").ToString
    '    indate = table.Rows(0)("in_date").ToString
    '    out = table.Rows(0)("tr_out").ToString
    '    dbcon.Close()


    'End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        If (badge = Nothing) Then
            MsgBox("Please select a record to Delete", MsgBoxStyle.Exclamation)
        Else
            If MsgBox("Are you sure you want to delete Employee " & badge & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If dbcon.State = ConnectionState.Closed Then
                    dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
                    dbcon.Open()
                End If
                Dim sqlQ As String = "update camp set occupied=occupied-1 where accno= (select accno from employee where badge_no='" & badge & "'); delete from transfers where badge_no='" & badge & "'; delete from leavet where badge_no='" & badge & "'; delete from employee where badge_no='" & badge & "';"
                Dim SQLCmd As New MySqlCommand

                Try

                    With SQLCmd
                        .CommandText = sqlQ
                        .Connection = dbcon
                        .ExecuteNonQuery()
                    End With

                    MsgBox("Record Deleted succesfully", MsgBoxStyle.Information)

                    Me.GetDBData()

                Catch myerror As MySqlException

                    MsgBox("SubRecords dependent on this Record: CANNOT delete", MsgBoxStyle.Exclamation)


                End Try
            End If
           sqlAdapter.Update(dataS)

            dbcon.Close()
        End If
        badge = ""
    End Sub

    Private Sub ButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click
        If (badge = Nothing) Then
            MsgBox("Please select a record to Edit", MsgBoxStyle.Exclamation)
        Else
            EditEmp.form = Name
            EditEmp.badge = badge
            EditEmp.ShowDialog()
        End If

        badge = ""
    End Sub

    Private Sub ButtonViewPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonViewPC.Click
        If badge = Nothing Then

            MsgBox("Please select a record", MsgBoxStyle.Exclamation)
        Else
            FormViewPC.code = code
            FormViewPC.ShowDialog()
        End If
        badge = ""
    End Sub

    Private Sub ButtonViewCamp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonViewCamp.Click
        If badge = Nothing Then

            MsgBox("Please select a record", MsgBoxStyle.Exclamation)
        Else
            ViewCamp.accno = accno
            ViewCamp.ShowDialog()
        End If
        badge = ""
    End Sub

    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        AddEmp.form = Name

        AddEmp.ShowDialog()
        sqlAdapter.Update(dataS)

    End Sub

    Private Sub ButtonTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTrans.Click
        If badge = Nothing Then

            MsgBox("Please select a record", MsgBoxStyle.Exclamation)
        Else
            TransferDetails.out = out
            TransferDetails.accno = accno
            TransferDetails.code = code
            TransferDetails.form = Name
            TransferDetails.badge = badge
            'TransferDetails.inacc = inacc
            'TransferDetails.inpc = inpc
            TransferDetails.indate = indate
            TransferDetails.ShowDialog()
        End If
        badge = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

        dataV.RowFilter = "badge_no like '" & TextBox1.Text & "%' or accno like '" & TextBox1.Text & "%' or code like '" & TextBox1.Text & "%' or ename like '" & TextBox1.Text & "%'"
        Dim i As Integer
        i = 0
        For Each Row As DataGridViewRow In DataGridView1.Rows

            If Row.Cells(13).Value = "YES" Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.IndianRed
                DataGridView1.Rows(i).DefaultCellStyle.SelectionBackColor = Color.IndianRed

            End If
            i += 1
        Next
    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        If DataGridView1.CurrentRow Is Nothing Then
            badge = ""
            code = ""
            accno = ""
            indate = ""
            out = ""
        Else
            badge = DataGridView1.CurrentRow.Cells(0).Value.ToString

            code = DataGridView1.CurrentRow.Cells(2).Value.ToString
            accno = DataGridView1.CurrentRow.Cells(1).Value.ToString

            indate = DataGridView1.CurrentRow.Cells(5).Value.ToString

            out = DataGridView1.CurrentRow.Cells(9).Value.ToString
        End If
    End Sub

    

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As System.EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.CurrentRow Is Nothing Then
            badge = ""
            code = ""
            accno = ""
            indate = ""
            out = ""
        Else
            badge = DataGridView1.CurrentRow.Cells(0).Value.ToString

            code = DataGridView1.CurrentRow.Cells(2).Value.ToString
            accno = DataGridView1.CurrentRow.Cells(1).Value.ToString

            indate = DataGridView1.CurrentRow.Cells(5).Value.ToString

            out = DataGridView1.CurrentRow.Cells(9).Value.ToString
        End If
    End Sub

    Private Sub DataGridView1_Sorted(sender As Object, e As System.EventArgs) Handles DataGridView1.Sorted
        Dim i As Integer
        i = 0
        For Each Row As DataGridViewRow In DataGridView1.Rows

            If Row.Cells(13).Value = "YES" Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.IndianRed
                DataGridView1.Rows(i).DefaultCellStyle.SelectionBackColor = Color.IndianRed

            End If
            i += 1
        Next
    End Sub
   
End Class