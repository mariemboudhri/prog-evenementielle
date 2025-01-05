Public Class fmcalculatrice
    Dim op As Char

    Private Sub fmcalculatrice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextB_TextChanged(sender As Object, e As EventArgs) Handles TextB.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnmoin_Click(sender As Object, e As EventArgs) Handles btnmoin.Click
        op = "-"
    End Sub

    Private Sub btnplus_Click(sender As Object, e As EventArgs) Handles btnplus.Click
        op = "+"
    End Sub

    Private Sub btnfois_Click(sender As Object, e As EventArgs) Handles btnfois.Click
        op = "*"
    End Sub

    Private Sub btndiv_Click(sender As Object, e As EventArgs) Handles btndiv.Click
        op = "/"
    End Sub

    Private Sub btnegal_Click(sender As Object, e As EventArgs) Handles btnegal.Click
        If IsNumeric(TextA.Text) And IsNumeric(TextB.Text) Then
            Dim a = Integer.Parse(TextA.Text)
            Dim b = Integer.Parse(TextB.Text)
            Dim test = True
            Dim res = 0

            If Op = "+" Then
                res = a + b
            ElseIf op = "-" Then
                res = a - b
            ElseIf op = "*" Then
                res = a * b
            ElseIf op = "/" And Not b = 0 Then

                res = a / b
            Else
                MessageBox.Show("veuiller choisir une autre opération")
                test = False

            End If
            If test Then
                lblRes.Text = a.ToString + "" + op + "" + b.ToString + "=" + res.ToString
            End If
        Else
            MessageBox.Show("A et B doit erte numérique")


        End If
    End Sub

    Private Sub TextA_TextChanged(sender As Object, e As EventArgs) Handles TextA.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextA.Text = ""
        TextB.Text = ""
        lblRes.Text = ""

    End Sub
End Class
