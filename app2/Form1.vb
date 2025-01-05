Public Class Form1
    Dim A As String
    Dim B As String
    Dim op = ""


    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If op = "" Then
            A = A + "0"
        Else
            B = B + "0"
        End If
        txt.Text = A + " " + op + " " + B
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If op = "" Then
            A = A + "1"
        Else
            B = B + "1"
        End If
        txt.Text = A + " " + op + " " + B
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If op = "" Then
            A = A + "2"
        Else
            B = B + "2"
        End If
        txt.Text = A + " " + op + " " + B
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If op = "" Then
            A = A + "3"
        Else
            B = B + "3"
        End If
        txt.Text = A + " " + op + " " + B
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If op = "" Then
            A = A + "4"
        Else
            B = B + "4"
        End If
        txt.Text = A + " " + op + " " + B
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If op = "" Then
            A = A + "5"
        Else
            B = B + "5"
        End If
        txt.Text = A + " " + op + " " + B
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If op = "" Then
            A = A + "6"
        Else
            B = B + "6"
        End If
        txt.Text = A + " " + op + " " + B
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If op = "" Then
            A = A + "7"
        Else
            B = B + "7"
        End If
        txt.Text = A + " " + op + " " + B
    End Sub
    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If op = "" Then
            A = A + "8"
        Else
            B = B + "8"
        End If
        txt.Text = A + " " + op + " " + B
    End Sub
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If op = "" Then
            A = A + "9"
        Else
            B = B + "9"
        End If
        txt.Text = A + " " + op + " " + B
    End Sub

    Private Sub btnc_Click(sender As Object, e As EventArgs) Handles btnc.Click
        txt.Text = ""
    End Sub

    Private Sub btnegal_Click(sender As Object, e As EventArgs) Handles btnegal.Click
        Dim test = True
        Dim res As Double
        If IsNumeric(A) And IsNumeric(B) And Not op = "" Then
            Dim va = Integer.Parse(A)
            Dim vb = Integer.Parse(B)

            If op = "+" Then
                res = va + vb
            ElseIf op = "-" Then
                res = va - vb
            ElseIf op = "*" Then
                res = va * vb
            ElseIf op = "/" Then
                res = va / vb
            Else
                MessageBox.Show("division par zero")
                test = False

            End If
        Else
            MessageBox.Show("A et B doivent etre entier")
            test = False
        End If
        If test = True Then
            txt.Text = txt.Text + "=" + res.ToString
        End If
    End Sub

    Private Sub btnplus_Click(sender As Object, e As EventArgs) Handles btnplus.Click
        If Not A = "" Then
            op = "+"
        End If
    End Sub

    Private Sub btnmoin_Click(sender As Object, e As EventArgs) Handles btnmoin.Click
        If Not A = "" Then
            op = "-"
        End If
    End Sub

    Private Sub btnfois_Click(sender As Object, e As EventArgs) Handles btnfois.Click
        If Not A = "" Then
            op = "*"
        End If
    End Sub

    Private Sub btndiv_Click(sender As Object, e As EventArgs) Handles btndiv.Click
        If Not A = "" Then
            op = "/"
        End If
    End Sub


End Class
