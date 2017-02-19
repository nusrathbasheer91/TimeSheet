Imports MySql.Data
Imports MySql.Data.MySqlClient


Public Class LoginForm
    Public dbcon As New MySqlConnection
    Public Function encrypt(ByVal s As String, ByVal v As Long) As String
        Dim total As String = ""
        Dim tmp As String
        For i = 1 To Len(s)
            tmp = Mid(s, i, 1)
            tmp = Asc(tmp) + v
            tmp = Chr(tmp)
            total = total & tmp
        Next i
        encrypt = total
    End Function
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            Try
                dbcon.Open()
            Catch myerror As MySqlException
                MsgBox("Error connecting to Database")
            End Try
        End If
        Dim enPwd As String = encrypt(txtPwd.Text.ToString, 25)
        Dim sqlQ As String = "use ts;SELECT * from users where user_id='" & txtUser.Text & "' and pwd='" & enPwd & "'"
        Dim sqlAdapter As New MySqlDataAdapter
        Dim SQLCmd As New MySqlCommand

        'Prepare connection and query
        With SQLCmd
            .CommandText = sqlQ
            .Connection = dbcon
        End With
        With sqlAdapter
            .SelectCommand = SQLCmd
        End With
        Dim mydata As MySqlDataReader
        mydata = SQLCmd.ExecuteReader()
        If mydata.HasRows = 0 Then
            MsgBox("Invalid Login")
            dbcon.Close()
        Else
            MsgBox("Login Accepted")

            Me.Hide()
            If txtUser.Text = "admin" Then
                txtPwd.Text = ""
                txtUser.Text = ""
                dbcon.Close()
                FormAdmin.ShowDialog()
            Else
                txtPwd.Text = ""
                txtUser.Text = ""
                dbcon.Close()
                FormUser.ShowDialog()
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        txtPwd.Text = ""
        txtUser.Text = ""
        dbcon.Close()

        Me.Close()

    End Sub

    'Private Sub LoginForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    '    txtPwd.Text = ""
    '    txtUser.Text = ""
    '    dbcon.Close()

    'End Sub

   

    Private Sub LoginForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dbcon.Close()
        Dispose()
    End Sub
End Class
