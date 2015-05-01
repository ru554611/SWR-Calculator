Imports System.Math
Public Class Form8

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ' Диэлектрическая проницаемость
        Dim eps As Double
        If Not Double.TryParse(TextBox1.Text, eps) Then
            MessageBox.Show("Неверное значение параметров!")
            TextBox1.Clear()
            Return
        End If

        ' Толщина диэлеткрика
        Dim h As Double
        If Not Double.TryParse(TextBox2.Text, h) Then
            MessageBox.Show("Неверное значение параметров!")
            TextBox2.Clear()
            Return
        End If

        ' Ширина полоски
        Dim W As Double
        If Not Double.TryParse(TextBox4.Text, W) Then
            MessageBox.Show("Неверное значение параметров!")
            TextBox4.Clear()
            Return
        End If
        RaschetMSP(eps, h, W)
    End Sub

    Function RaschetMSP(eps, h, W)

        'Расчет геометрических параметров
        Dim nu As Double
        nu = 120 * PI
        Dim u As Double
        u = W / h

        Dim a As Double
        a = 1 + 1 / 49 * Log(((u ^ 4 + (u / 52) ^ 2) / (u ^ 4 + 0.432)), E) + (1 / 18.7) * Log((1 + (u / 18.1) ^ 3), E)
        Dim b As Double
        b = 0.564 * ((eps - 0.9) / (eps + 3)) ^ 0.053
        Dim ere As Double
        ere = (eps + 1) / 2 + ((eps - 1) / 2) * (1 + 10 / u) ^ -(a * b)
        Dim F As Double
        F = 6 + (2 * PI - 6) * Exp(-(30.666 / u) ^ 0.7528)
        Dim Zvl As Double
        Zvl = (nu / (2 * PI * Sqrt(ere)) * Log(F / u + (Sqrt(1 + (2 / u) ^ 2)), E))
        
        TextBox5.Text = Round(ere, 3)
        TextBox6.Text = Round(Zvl, 3)
        Form2.TextBox1.Text = Round(ere, 3)
        Form2.TextBox4.Text = Round(ere, 3)
        Form3.TextBox1.Text = Round(ere, 3)
        Form3.TextBox8.Text = Round(ere, 3)
        Form4.TextBox1.Text = Round(ere, 3)
        Form4.TextBox8.Text = Round(ere, 3)
        Form4.TextBox9.Text = Round(ere, 3)
        Return 0
    End Function

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class