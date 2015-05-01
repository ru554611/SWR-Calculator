Imports System.Math

Public Class Form9

    Function RaschetCoax(eps, D, di, nu)

        'Магнитная постоянная
        Dim nu0 As Double
        nu0 = 4 * PI * 10 ^ -7
        'Электрическая постоянная
        Dim eps0 As Double
        eps0 = 8.854197817 * 10 ^ -12

        Dim Z As Double
        Z = (1 / (2 * PI)) * (Sqrt((nu * nu0) / (eps * eps0))) * Log(D / di, E)
        TextBox5.Text = Round(Z, 3)
        Return 0
    End Function

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim eps As Double
        If Not Double.TryParse(TextBox1.Text, eps) Then
            MessageBox.Show("Неверное значение параметров!")
            TextBox1.Clear()
            Return
        End If

        Dim D As Double
        If Not Double.TryParse(TextBox2.Text, D) Then
            MessageBox.Show("Неверное значение параметров!")
            TextBox2.Clear()
            Return
        End If

        Dim di As Double
        If Not Double.TryParse(TextBox3.Text, di) Then
            MessageBox.Show("Неверное значение параметров!")
            TextBox3.Clear()
            Return
        End If

        Dim nu As Double
        If Not Double.TryParse(TextBox4.Text, nu) Then
            MessageBox.Show("Неверное значение параметров!")
            TextBox4.Clear()
            Return
        End If

        RaschetCoax(eps, D, di, nu)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form9_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        TextBox4.Text = 1
    End Sub
End Class