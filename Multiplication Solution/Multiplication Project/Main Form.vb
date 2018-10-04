' Name:         Multiplication Project
' Purpose:      Displays a multiplication table that shows the multiplicand, multiplier, and product.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        ' Displays a multiplication table.
        Dim input As String = ""
        txtNumber.Text = input
        Dim val1 As Integer = CInt(Me.txtNumber.Text)
        Do While 1 <= 9
            val1 *= 1
        Loop
        Me.lblTable.Text = input & (* ) & 1 = CType(val1, String)

    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ' Displays a multiplication table.
        Dim input As String = ""
        txtNumber.Text = input
        Dim val1 As Integer = CInt(Me.txtNumber.Text)
        For i As Decimal = 1 To 9
            Me.lblTable.Text = input & (* ) & i = CType(val1, String)
        Next

    End Sub

    Private Function NewMethod() As String
        Return txtNumber.Text
    End Function

    Private Sub txtNumber_Enter(sender As Object, e As EventArgs) Handles txtNumber.Enter
        txtNumber.SelectAll()
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        ' Allow only numbers and the Backspace key.

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        lblTable.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lblTable_Click(sender As Object, e As EventArgs) Handles lblTable.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
