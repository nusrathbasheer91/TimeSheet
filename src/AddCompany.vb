Imports MySql.Data
Imports MySql.Data.MySqlClient


Public Class AddCompany


    Public dbcon As New MySqlConnection
    Public dbcon1 As New MySqlConnection
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon.Open()
        End If

        Dim sqlQ As String = "insert into camp (accno,campname,capacity) values ('" & Textaccno.Text & "','" & Textcamp.Text & "','" & Textcap.Text & "'); "

        Dim sqlCmd As New MySqlCommand
        ''''''''''''''''
        Dim sqlQ1 As String = "SELECT * from camp where accno='" & Textaccno.Text & "'"
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
            Dispose()
            Close()
           

            'GETDBDATA AGAIN

            FormCompany.GetDBData()



        Else

            '   If dbcon.State = ConnectionState.Closed Then
            'dbcon.ConnectionString = "Server=LOCALHOST;Port=3307;Database=pc;Userid=root;Password=init2013"
            '  dbcon.Open()


            MsgBox("Duplicate ID")
            dbcon.Close()
            dbcon1.Close()


        End If
    End Sub

    Private Sub AddCompany_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
        dbcon.Close()
        dbcon1.Close()

    End Sub
End Class