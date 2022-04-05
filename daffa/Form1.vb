Public Class Form1
    Dim hasil As Integer
    Sub celciusConverter()
        Dim selected = ComboBox2.SelectedItem.ToString
        If selected = "USD" Then
            hasil = Val(TextBox1.Text) * 0.00007
        End If
        If selected = "Poundsterling" Then
            hasil = Val(TextBox1.Text) * 0.000053
        End If
        If selected = "Euro" Then
            hasil = Val(TextBox1.Text) * 0.000064
        End If
    End Sub
    Sub KelvinConverter()
        Dim selected = ComboBox2.SelectedItem.ToString
        If selected = "USD" Then
            hasil = Val(TextBox1.Text) * 1.31
        End If
        If selected = "IDR" Then
            hasil = Val(TextBox1.Text) * 18806
        End If
        If selected = "Euro" Then
            hasil = Val(TextBox1.Text) * 1.2
        End If
    End Sub
    Sub ReamurConverter()
        Dim selected = ComboBox2.SelectedItem.ToString
        If selected = "Poundsterling" Then
            hasil = Val(TextBox1.Text) * 0.83
        End If
        If selected = "IDR" Then
            hasil = Val(TextBox1.Text) * 15677
        End If
        If selected = "USD" Then
            hasil = Val(TextBox1.Text) * 1.09
        End If
    End Sub

    Sub FahrenheitConverter()
        Dim selected = ComboBox2.SelectedItem.ToString
        If selected = "Poundsterling" Then
            hasil = Val(TextBox1.Text) * 0.76
        End If
        If selected = "IDR" Then
            hasil = Val(TextBox1.Text) * 14353
        End If
        If selected = "Euro" Then
            hasil = Val(TextBox1.Text) * 0.92
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selected = ComboBox1.SelectedItem.ToString
        If selected = "IDR" Then
            celciusConverter()
        End If
        If selected = "USD" Then
            FahrenheitConverter()
        End If
        If selected = "Poundsterling" Then
            KelvinConverter()
        End If
        If selected = "Euro" Then
            ReamurConverter()
        End If
        TextBox2.Text = hasil
    End Sub
End Class
