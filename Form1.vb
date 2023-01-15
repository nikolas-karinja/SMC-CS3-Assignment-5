'Nikolas Karinja
'11/11/2022
'Assignment 5 - Hello User

Public Class frmHelloUser
    Private Sub btnClickMe_Click(sender As Object, e As EventArgs) Handles btnClickMe.Click

        'Display message using input values
        lblMessage.Text = "Hello " & txtFN.Text & " " & txtLN.Text & vbCrLf & "You are " & txtAge.Text & " years old."

    End Sub



    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        'Clear the textboxes
        txtAge.Clear()
        txtFN.Clear()
        txtLN.Clear()

        'Clear the label
        lblMessage.Text = ""

        'Return the focus to the appropriate object
        txtFN.Focus()

    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Close the form and dispose of it
        Me.Close()
        Me.Dispose()

    End Sub
End Class
