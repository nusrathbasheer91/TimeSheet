Imports MySql.Data
Imports MySql.Data.MySqlClient


Public Class EditUser

    Friend userid As String
    Friend pwd As String
    Dim dbcon As New MySqlConnection

    Private Sub EditUser_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dbcon.Close()
        Dispose()
    End Sub
    Private Sub EditUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUser.Text = userid
    End Sub

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
        Dim SQLCmd As New MySqlCommand
        If txtPwd.Text = txtCPwd.Text Then
            If txtPwd.Text.ToString.Length >= 5 Then
                enPwd = encrypt(txtPwd.Text.ToString(), 25)
                Dim sqlQ As String = "UPDATE users SET pwd='" & enPwd & "' where user_id='" & txtUser.Text & "';"
                Dim sqlAdapter As New MySqlDataAdapter
                'Prepare connection and query
                Try
                    With SQLCmd
                        .CommandText = sqlQ
                        .Connection = dbcon
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Changed Password succesfully", MsgBoxStyle.Information)

                Catch myerror As MySqlException
                    MsgBox("Error : Invalid Characters in Password") 'any error like character return for integer field

                End Try
            Else
                MsgBox("Minimum Length is 5", MsgBoxStyle.Exclamation)
            End If
        Else

            MsgBox("Passwords DO NOT MATCH", MsgBoxStyle.Exclamation)
        End If
            Dispose()
            Close()
            Me.Close()
            FormUsers.GetDBData()

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

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

   
End Class