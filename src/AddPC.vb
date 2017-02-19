Imports MySql.Data
Imports MySql.Data.MySqlClient



Public Class AddPC

    Friend form As String
    Public dbcon As New MySqlConnection
    Public dbcon1 As New MySqlConnection

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click

        If Not (IsNothing(ComboBoxAccNo.SelectedItem)) Then
            Dim S As String() = ComboBoxAccNo.SelectedItem.Split(" ")
            Textaccno.Text = S(0)
        End If
        If Not (IsNothing(ComboBoxClientID.SelectedItem)) Then
            Dim S As String() = ComboBoxClientID.SelectedItem.Split(" ")
            Textclientid.Text = S(0)
        End If
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon.Open()
        End If

        Dim sqlQ As String = "insert into profitc (code,client_id,accno,pname,manday,bf,lunch,dinner,hkeep,laundry) values ('" & Textcode.Text & "','" & Textclientid.Text & "','" & Textaccno.Text & "','" & Textpname.Text & "'," & Textman.Text & "," & TextBf.Text & "," & Textlunch.Text & "," & Textdinner.Text & "," & Texthkeep.Text & "," & Textlaundry.Text & "); "

        Dim sqlCmd As New MySqlCommand
        ''''''''''''''''
        Dim sqlQ1 As String = "SELECT * from profitc where code='" & Textcode.Text & "'"
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
        If mydata.HasRows = 0 Then
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

            Catch myerror As MySqlException
                MsgBox("Error : invalid entry")

            End Try

            'GETDBDATA AGAIN
            If form = "ViewAllPCs" Then
                ViewAllPCs.GetDBData()
            End If
            Dispose()
            Close()

        Else

            '   If dbcon.State = ConnectionState.Closed Then
            'dbcon.ConnectionString = "Server=LOCALHOST;Port=3307;Database=pc;Userid=root;Password=init2013"
            '  dbcon.Open()


            MsgBox("Duplicate ID")
            dbcon.Close()
            dbcon1.Close()
        End If

    End Sub

    Private Sub AddPC_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
        dbcon.Close()
        dbcon1.Close()
    End Sub

    Private Sub AddPC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        strQuery = "SELECT client_id,client_name from ts.client;"



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

            ComboBoxClientID.Items.Add(table1.Rows(i)("client_id") & " : " & table1.Rows(i)("client_name"))
        Next
    End Sub
End Class