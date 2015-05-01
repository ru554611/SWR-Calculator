Imports System.Math
Public Class Form5

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ' Диэлектрическая проницаемость
        Dim eps As Double
        If Not Double.TryParse(TextBox1.Text, eps) Then
            MessageBox.Show("Неверное значение параметров!")
            TextBox1.Clear()
            Return
        End If

        ' Толщина диэлеткрика
        Dim h1 As Double
        If Not Double.TryParse(TextBox2.Text, h1) Then
            MessageBox.Show("Неверное значение параметров!")
            TextBox2.Clear()
            Return
        End If

        ' Толщина воздушной прослойки
        Dim h2 As Double
        If Not Double.TryParse(TextBox3.Text, h2) Then
            MessageBox.Show("Неверное значение параметров!")
            TextBox3.Clear()
            Return
        End If

        ' Ширина полоски
        Dim W As Double
        If Not Double.TryParse(TextBox4.Text, W) Then
            MessageBox.Show("Неверное значение параметров!")
            TextBox4.Clear()
            Return
        End If
        RaschetPMS(eps, h1, h2, W)
    End Sub

    Function RaschetPMS(eps, h1, h2, W)
        'Расчет геометрических параметров
        Dim a As Double
        a = (0.8621 - 0.1251 * Log(h1 / h2, E)) ^ 4
        Dim b As Double
        b = (0.4986 - 0.1397 * Log(h1 / h2, E)) ^ 4
        Dim erk As Double
        erk = (1 + h1 / h2 * (a - b * Log(W / h2, E)) * (1 / Sqrt(eps) - 1)) ^ -1
        Dim nu As Double
        nu = 120 * PI
        Dim u As Double
        u = W / (h1 + h2)
        Dim F As Double
        F = 6 + (2 * PI - 6) * Exp(-(30.666 / u) ^ 0.7528)
        Dim Zvl As Double
        Zvl = (nu / (2 * PI * erk)) * Log(F / u + (Sqrt(1 + (2 / u) ^ 2)), E)
        Dim epsef As Double
        epsef = erk ^ 2

        TextBox5.Text = Round(epsef, 3)
        TextBox6.Text = Round(Zvl, 3)
        Form2.TextBox1.Text = Round(epsef, 3)
        Form2.TextBox4.Text = Round(epsef, 3)
        Form3.TextBox1.Text = Round(epsef, 3)
        Form3.TextBox8.Text = Round(epsef, 3)
        Form4.TextBox1.Text = Round(epsef, 3)
        Form4.TextBox8.Text = Round(epsef, 3)
        Form4.TextBox9.Text = Round(epsef, 3)
        Return 0
    End Function

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class