Public Class Form1
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim taille = lst.SelectedItem.ToString()
        Dim A As String = ""
        If rd_1.Checked Then
            A = "Croute fine"
        ElseIf rd_2.Checked Then
            A = "Croute classique"
        ElseIf rd_3.Checked Then
            A = "Croute epaisse"
        End If
        Dim B As String = ""
        If chk_1.Checked Then
            B = B + "champignion"
        ElseIf chk_2.Checked Then
            B = B + "olive"
        ElseIf chk_3.Checked Then
            B = B + "poivrons"
        ElseIf chk_4.Checked Then
            B = B + "formage supplémentaire"

        End If
        Dim msg As String = "Taille: " + taille + "Type de croute: " + A + "Ingrédiant supplémentaire:" + B
        MessageBox.Show(msg)
    End Sub
End Class
