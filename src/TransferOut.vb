Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class TransferOut
    Public badge As String
    Public indate As String
    Public dbcon As New MySqlConnection
    Public form As String
    Public errornum As Integer
    Private Sub ButtonTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTransfer.Click
        TextDateOut.Text = Format(DateTimePicker1.Value.Date, "yyyy-MM-dd")
        If (IsNothing(ComboBox1.SelectedItem)) Then
            errornum = 1
            MsgBox("Select an Option")
        ElseIf (DateDiff("d", TextDateOut.Text, indate) >= 0) Then
            MsgBox("Error : IN Date and Out Date should vary atleast by A Day : INDATE is " & Format(Convert.ToDateTime(indate), "yyyy-MMM-dd"), MsgBoxStyle.Exclamation)
            errornum = 1
        Else
            If (Toutcode.Text <> "") Then
                Toutcode.Text = " : " & Toutcode.Text
            End If
            If dbcon.State = ConnectionState.Closed Then
                dbcon.ConnectionString = "Server=LOCALHOST;Port=3306;Database=ts;Userid=root;Password=init2013"
                dbcon.Open()
            End If
            Dim sqlQ As String = "update employee set tr_out='" & ComboBox1.SelectedItem.ToString & "" & Toutcode.Text & "',out_date='" & TextDateOut.Text & "' where badge_no='" & badge & "';update camp set occupied=occupied-1 where accno= (select accno from employee where badge_no='" & badge & "');"


            Dim sqlCmd As New MySqlCommand
            If errornum = 0 Then
                'Try
                With sqlCmd
                    .CommandText = sqlQ
                    .Connection = dbcon
                    .ExecuteNonQuery()
                End With
                MsgBox("Transfer Records Updated succesfully", MsgBoxStyle.Information)
                'Catch myerror As MySqlException
                'MsgBox("Error : invalid entries") 'any error like character return for integer field

                'End Try
            End If

            dbcon.Close()
            Dispose()
            Close()

        End If
        errornum = 0
        If (form = "FormViewEmp") Then
            FormViewEmp.GetDBData()
        ElseIf (form = "ViewAllEmps") Then
            ViewAllEmps.GetDBData()
        End If
    End Sub

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()

    End Sub

    Private Sub TransferOut_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dbcon.Close()
        Dispose()

    End Sub

End Class