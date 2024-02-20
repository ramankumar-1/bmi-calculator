Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)


        MessageBox.Show("Welcome to the form")



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles heightInput.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles weightInput.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim weight As Decimal
        Dim height As Decimal
        Dim bmi As Decimal

        weight = weightInput.Text
        height = heightInput.Text
        bmi = weight / (height * height)

        MessageBox.Show("Your BMI is: " & Math.Round(bmi, 2))

    End Sub
End Class
