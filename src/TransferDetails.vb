Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class TransferDetails
    'Public inacc As String
    'Public inpc As String

    Public indate As String

    Public badge As String
    Public form As String
    Friend accno As String
    Friend code As String
    Public out As String

    Public errornum As Integer


    Private Sub ButtonTransferEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTransferEmp.Click
        If out = "" Then
            TEmp.code = code
            TEmp.accno = accno
            TEmp.badge = badge
            TEmp.form = form
            TEmp.ShowDialog()
        Else
            MsgBox("Employee Has Been Transfere Out", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub ButtonTout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTout.Click
        If out = "" Then
            TransferOut.form = form
            TransferOut.badge = badge
            TransferOut.indate = indate
            TransferOut.ShowDialog()
            Me.Close()

        Else
            MsgBox("Employee Has Been Transfere Out", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub ButtonTin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTin.Click
        If out = "" Then
            MsgBox("Employee Has Never Been Transfere Out", MsgBoxStyle.Exclamation)
        Else
            TransferIN.badge = badge
            TransferIN.form = form
            TransferIN.ShowDialog()
            Me.Close()

        End If

    End Sub


    Private Sub ButtonView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonView.Click
        ViewTransferDetails.badge = badge
        ViewTransferDetails.form = form
        ViewTransferDetails.ShowDialog()

    End Sub

    Private Sub TransferDetails_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dispose()

    End Sub

   
End Class
