Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class AddUser
    Dim dbcon As New MySqlConnection
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"

            Try
                dbcon.Open()
            Catch myerror As MySqlException
                MsgBox("Error connecting to Database")
            End Try
        End If
        Dim enPwd As String
        Dim sqlAdapter As New MySqlDataAdapter
        Dim SQLCmd As New MySqlCommand
        If txtPwd.Text = txtCPwd.Text And txtUser.Text <> "" Then
            If txtPwd.Text.ToString.Length >= 5 Then
                enPwd = encrypt(txtPwd.Text.ToString(), 25)
                Dim sqlQ As String = "insert into users (user_id,pwd) values ('" & txtUser.Text & "','" & enPwd & "'); "
                'Prepare connection and query
                Try
                    With SQLCmd
                        .CommandText = sqlQ
                        .Connection = dbcon
                        .ExecuteNonQuery()
                    End With
                    MsgBox("User added succesfully", MsgBoxStyle.Information)

                Catch myerror As MySqlException
                    MsgBox("Error : Invalid Entry") 'any error like character return for integer field

                End Try
            Else
                MsgBox("Password length should be ATLEAST 5 characters long", MsgBoxStyle.Exclamation)
            End If
        Else

            MsgBox("Passwords DO NOT MATCH or Empty Entries", MsgBoxStyle.Exclamation)
        End If

            FormUsers.GetDBData()
            Dispose()
            Close()
            Me.Close()
    End Sub


    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()

    End Sub

    Private Sub AddUser_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dbcon.Close()
        Dispose()

    End Sub

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

End Class