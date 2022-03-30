Public Class Form1
    Dim hasil As Integer
    Sub celciusConverter()
        Dim selected = ComboBox2.SelectedItem.ToString
        If selected = "Kelvin" Then
            hasil = Val(TextBox1.Text) + 273
        End If
        If selected = "Fahrenheit" Then
            hasil = (9 / 5 * Val(TextBox1.Text)) + 32
        End If
        If selected = "Reamur" Then
            hasil = 4 / 5 * Val(TextBox1.Text)
        End If
    End Sub
    Sub KelvinConverter()
        Dim selected = ComboBox2.SelectedItem.ToString
        If selected = "Celcius" Then
            hasil = Val(TextBox1.Text) - 273
        End If
        If selected = "Fahrenheit" Then
            hasil = (Val(TextBox1.Text) * 5 / 9) - 459.67
        End If
        If selected = "Reamur" Then
            hasil = (Val(TextBox1.Text) - 273.15) * 5 / 4
        End If
    End Sub
    Sub ReamurConverter()
        Dim selected = ComboBox2.SelectedItem.ToString
        If selected = "Celcius" Then
            hasil = Val(TextBox1.Text) * 5 / 4
        End If
        If selected = "Fahrenheit" Then
            hasil = Val(TextBox1.Text) * 9 / 4 + 32
        End If
        If selected = "Kelvin" Then
            hasil = Val(TextBox1.Text) * 5 / 4 + 273.15
        End If
    End Sub

    Sub FahrenheitConverter()
        Dim selected = ComboBox2.SelectedItem.ToString
        If selected = "Celcius" Then
            hasil = (Val(TextBox1.Text) - 32) * 5 / 9
        End If
        If selected = "Reamur" Then
            hasil = (Val(TextBox1.Text) - 32) * 4 / 9
        End If
        If selected = "Kelvin" Then
            hasil = (Val(TextBox1.Text) + 459.67) * 5 / 9
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selected = ComboBox1.SelectedItem.ToString
        If selected = "Celcius" Then
            celciusConverter()
        End If
        If selected = "Fahrenheit" Then
            FahrenheitConverter()
        End If
        If selected = "Kelvin" Then
            KelvinConverter()
        End If
        If selected = "Reamur" Then
            ReamurConverter()
        End If
        TextBox2.Text = hasil
    End Sub
End Class
