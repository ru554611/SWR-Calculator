Imports System.Math
Imports System.Numerics
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form2


    Private Sub RashetKSV(ByVal eps As Double, ByVal eps1 As Double, ByVal Zn As Complex, ByVal L As Double, ByVal Lsh As Double, ByRef X() As Double, ByRef Y() As Double)
        Dim i As Integer = 0
        Dim f As Double = ComboBox1.Text * 10 ^ 6 ' Частоты
        Dim fmax As Double = ComboBox2.Text * 10 ^ 6
        Const c As Integer = 3 * (10 ^ 8) ' Скорость света

        While (f <= fmax)
            ' Заполняем массив X
            X(i) = f

            Dim lam0 As Double = c / f  ' Рассчет длины волны в свободном пространстве на задонной частоте
            Dim lam As Double = lam0 / Sqrt(eps) ' Рассчет длины волны
            Dim lam1 As Double = lam0 / Sqrt(eps1) ' Рассчет длины волны

            Dim b As Double = (2 * PI) / lam  ' Расчет бэты
            Dim b1 As Double = (2 * PI) / lam1  ' Расчет бэты

            Dim Yn As Complex
            Yn = Complex.Divide(1, Zn)

            ' Расчет входной проводимости
            Dim Yvh As Complex 'Здесь будет окончательный результат

            ' Считаем числитель
            Dim tg As New Complex(0, Tan(b * L))
            Dim Yvh_ch As Complex = Complex.Add(Yn, tg)

            ' Считаем знаменатель
            Dim Yvh_zn As Complex = Complex.Add(1, Complex.Multiply(Yn, tg))
            Yvh = Complex.Divide(Yvh_ch, Yvh_zn) 'входная проводимость

            ' Расчет проводимости шлейфа
            Dim Ysh As Complex 'Здесь будет окончательный результат

            ' Считаем числитель
            Dim Ysh_ch As Integer = 1

            ' Считаем знаменатель
            Dim Ysh_zn As New Complex(0, (1 / Tan(b1 * Lsh)))

            Ysh = Complex.Divide(Ysh_ch, -Ysh_zn) ' проводимость шлейфа

            ' Считаем Y входное 1
            Dim Yvh1 As Complex = Complex.Add(Yvh, Ysh)

            ' Считаем коэффициент отражения
            Dim G As Complex

            ' Считаем числитель
            Dim G_ch As Complex = Complex.Subtract(Yvh1, 1)
            ' Считаем знаменатель
            Dim G_zn As Complex = Complex.Add(Yvh1, 1)

            G = Complex.Divide(G_ch, G_zn) ' коэффициент отражения

            ' Расчет коэффициента стоячей волны
            Dim KSV As Double
            KSV = (Complex.Abs(G) + 1) / (1 - Complex.Abs(G))
            Y(i) = KSV

            f = f + (10 ^ 7)
            i = i + 1
        End While

        Dim Min As Double
        Min = 2 ' Значение min должно быть максимально возможным (т.к. в нашем случае все числа положительные, то будет достаточно и нуля)

        For kof = 0 To Y.Length - 1
            If Y(kof) < Min Then Min = Y(kof) ' Сравниваем каждый элемент массива с max. Если он больше, то max равен данному элементу
        Next

        If Min >= 2 Then MsgBox("Ошибка! Минимальное значение КСВ > 2!")

    End Sub

    Private Sub Chart1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Chart1.MouseClick
        MsgBox("Частота (f) = " & Math.Round(Chart1.ChartAreas(0).AxisX.PixelPositionToValue(e.X), 0) & "МГц" & " КСВ = " & Math.Round(Chart1.ChartAreas(0).AxisY.PixelPositionToValue(e.Y), 3), MsgBoxStyle.OkOnly, "Точка")
    End Sub


    Private Sub Form2_Load1(sender As Object, e As System.EventArgs) Handles Me.Load
        
        '-------------
        TextBox1.Text = 1.7
        TextBox2.Text = 2
        TextBox3.Text = -1
        TextBox5.Text = 0.031365
        TextBox6.Text = 0.09639
        'TextBox7.Text = 700
        'TextBox4.Text = 1200

        Dim fmin As Integer = 0

        While (fmin <= 2500)
            ComboBox1.Items.Add(fmin)
            ComboBox2.Items.Add(fmin)
            fmin = fmin + 10
        End While
        

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Chart1.BackColor = Color.Transparent
        Chart1.Titles.Clear()
        Chart1.Legends.Clear()

        Chart1.Series(0).Color = Color.Red
        Chart1.ChartAreas(0).Area3DStyle.Enable3D = True

        Chart1.ChartAreas(0).AxisX.Title = "Частота, Мгц"
        Chart1.ChartAreas(0).AxisY.Title = "КСВ"

        Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
        Chart1.ChartAreas(0).AxisX.Minimum = ComboBox1.SelectedItem
        Chart1.ChartAreas(0).AxisX.Maximum = ComboBox2.SelectedItem
        Chart1.ChartAreas(0).AxisX.Interval() = 50
        Chart1.ChartAreas(0).AxisY.Minimum = 1
        Chart1.ChartAreas(0).AxisY.Maximum = 2
        Chart1.ChartAreas(0).AxisY.Interval() = 0.1

        Chart1.Cursor = Cursors.Arrow

        ' Диэлектрическая проницаемость
        Dim eps As Double
        If Not Double.TryParse(TextBox1.Text, eps) Then
            MessageBox.Show("Неверное значение параметров!")
            TextBox1.Clear()
            Return
        End If

        ' Диэлектрическая проницаемость
        Dim eps1 As Double
        If Not Double.TryParse(TextBox4.Text, eps1) Then
            MessageBox.Show("Неверное значение параметров!")
            TextBox4.Clear()
            Return
        End If

        ' Проводимость нагрузки
        Dim Zn1 As Double
        Dim Zn2 As Double
        If (Not Double.TryParse(TextBox2.Text, Zn1)) Or (Not Double.TryParse(TextBox3.Text, Zn2)) Then
            MessageBox.Show("Неверное значение параметров!")
            TextBox2.Clear()
            TextBox3.Clear()
            Return
        End If
        Dim Zn As New Complex(Zn1, Zn2)

        ' Расстояние до места установки
        Dim L As Double
        If Not Double.TryParse(TextBox5.Text, L) Then
            MessageBox.Show("Неверное значение параметров!")
            TextBox5.Clear()
            Return
        End If

        ' Длина шлейфа
        Dim Lsh As Double
        If Not Double.TryParse(TextBox6.Text, Lsh) Then
            MessageBox.Show("Неверное значение параметров!")
            TextBox6.Clear()
            Return
        End If


        Dim fmin_, fmax_, fi_ As Integer
        fmin_ = ComboBox1.Text
        fmax_ = ComboBox2.Text
        fi_ = ((fmax_ - fmin_) / 10)
        If fi_ < 0 Then
            MsgBox("Неверно указан диапозон f")
            ComboBox1.SelectedIndex = -1
            ComboBox2.SelectedIndex = -1
            Return
        End If
        ' -----------------------------------------------

        ' расчет функции

        Dim X(), Y() As Double
        Dim fmin, fmax As Double
        Dim fi As Integer
        fmin = ComboBox1.Text
        fmax = ComboBox2.Text
        fi = ((fmax - fmin) / 10)
        If fi < 0 Then MsgBox("Неверно указан диапозон f")
        ReDim X(fi)
        ReDim Y(fi)
        Call RashetKSV(eps, eps1, Zn, L, Lsh, X, Y)


        'Chart1.ChartAreas(0).AxisY.Minimum = Math.Round(1, 3)
        'Chart1.ChartAreas(0).AxisY.Maximum = Math.Round(2, 3)
        ' рисуем
        Chart1.Series(0).Points.Clear()
        For i As Integer = 0 To Y.Length - 1
            Chart1.Series(0).Points.AddXY(X(i) / (10 ^ 6), Math.Round(Y(i), 3))
        Next

        'Chart1.Show()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Form5.Show()
    End Sub

    Private Sub СогласованиеСПомошьюРеактивногоПараллельногоШлейфаToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles СогласованиеСПомошьюРеактивногоПараллельногоШлейфаToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub СогласованиеЧетвертьволновымТрансформаторомToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles СогласованиеЧетвертьволновымТрансформаторомToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub СогласованиеМетодомДвухРазнесенныхРеактивныхЭлементовToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles СогласованиеМетодомДвухРазнесенныхРеактивныхЭлементовToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub ВыходToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ВыходToolStripMenuItem.Click
        Form5.Close()
        Form4.Close()
        Form3.Close()
        Form1.Close()
        Me.Close()
    End Sub

    Private Sub ОПрограммеToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ОПрограммеToolStripMenuItem1.Click
        Form6.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        Form7.Show()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Form8.Show()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Form9.Show()
    End Sub
End Class