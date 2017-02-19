Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class EditCamp
    Public dbcon As New MySqlConnection
    Friend accno As String
    Friend campname As String
    Friend cap As String
    'Friend next_med As String
    Friend occ As String
    Private Sub ButtonUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUpdate.Click
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
            dbcon.Open()
        End If
        Dim sqlQ As String = "update camp set campname='" & Textcamp.Text & "', capacity =" & Textcap.Text & " where accno='" & accno & "' and occupied<=" & Textcap.Text & ";"


        Dim sqlCmd As New MySqlCommand


        If IsNumeric(Textcap.Text) Then

            If Convert.ToInt64(Textocc.Text) <= Convert.ToInt64(Textcap.Text) Then
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
            Else
                MsgBox("Error : Capicity is Less than Occupied", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("Error : Invalid Input", MsgBoxStyle.Exclamation)
        End If
        'GETDBDATA AGAIN

        FormCompany.GetDBData()
    End Sub

    Private Sub EditCamp_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dbcon.Close()
        Dispose()
    End Sub

    Private Sub EditCamp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Textaccno.Text = accno
        Textcamp.Text = campname
        Textcap.Text = cap
        Textocc.Text = occ
    End Sub

End Class