Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles surnameLabel.Click

    End Sub

    Private Sub aboutmeBtn_Click(sender As Object, e As EventArgs) Handles aboutmeBtn.Click
        Dim name As String
        Dim surname As String
        Dim age As Integer
        Dim tribe As String
        Dim gender As String

        name = txtname.Text
        surname = txtsurname.Text
        age = txtage.Text
        tribe = txttribe.Text
        gender = genderlistbox.Text


        MsgBox("Hi" & name & surname & "you are" & "a" & age & "years old" & tribe & gender
             )








    End Sub

    Private Sub genderlistbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles genderlistbox.SelectedIndexChanged

    End Sub
End Class
