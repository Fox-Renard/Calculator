Public Class Form1
    Dim num1 As Integer
    Dim num2 As Integer
    Dim m_calc As String



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strText As String = TextBox1.Text
        MessageBox.Show(strText)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles B0.Click, B1.Click, B2.Click, B3.Click, B4.Click, B5.Click, B6.Click, B7.Click, B8.Click, B9.Click

        TextBox2.Text += sender.Text

    End Sub

    Private Sub Plus_Click(sender As Object, e As EventArgs) Handles Plus.Click

        Try
            num1 = TextBox2.Text
            Label.Text = TextBox2.Text
            Label.ForeColor = Color.Red
            Label.Text += "＋"
            TextBox2.Text = ""
            m_calc = "Plus"
        Catch ex As OverflowException
            MsgBox(ex.Message)
            Console.WriteLine(ex.Message)
        Finally
            Console.WriteLine("オーバーフローしたので世界が終わります")

        End Try
    End Sub

    Private Sub Minus_Click(sender As Object, e As EventArgs) Handles Minus.Click
        num1 = TextBox2.Text
        Label.Text = TextBox2.Text
        Label.ForeColor = Color.Red
        Label.Text += "－"
        TextBox2.Text = ""
        m_calc = "Minus"
    End Sub

    Private Sub Multiply_Click(sender As Object, e As EventArgs) Handles Multiply.Click
        num1 = TextBox2.Text
        Label.Text = TextBox2.Text
        Label.ForeColor = Color.Red
        Label.Text += "×"
        TextBox2.Text = ""
        m_calc = "Multiply"
    End Sub

    Private Sub Divide_Click(sender As Object, e As EventArgs) Handles Divide.Click
        num1 = TextBox2.Text
        Label.Text = TextBox2.Text
        Label.ForeColor = Color.Red
        Label.Text += "÷"
        TextBox2.Text = ""
        m_calc = "Divide"
    End Sub

    Private Sub Equal_Click(sender As Object, e As EventArgs) Handles Equal.Click
        num2 = TextBox2.Text

        If m_calc = "Plus" Then
            Label.Text += TextBox2.Text
            TextBox2.Text = num1 + num2
        End If

        If m_calc = "Minus" Then
            Label.Text += TextBox2.Text
            TextBox2.Text = num1 - num2
        End If

        If m_calc = "Multiply" Then
            Label.Text += TextBox2.Text
            TextBox2.Text = num1 * num2
        End If

        If m_calc = "Divide" Then
            Label.Text += TextBox2.Text
            TextBox2.Text = num1 / num2
        End If

    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        TextBox2.Text = ""
        Label.Text = ""
    End Sub



End Class