Imports System.Math
Imports System.Numerics
Imports System.Windows.Forms.DataVisualization.Charting


Public Class Form1
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If (rbShl.Checked() = True) Then
            Form2.Show()
        End If

        If (rbTrans.Checked() = True) Then
            Form3.Show()
        End If

        If (rb2Shl.Checked() = True) Then
            Form4.Show()
        End If

    End Sub

    Private Sub СогласованиеСПомошьюРеактивногоПараллельногоШлейфаToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles СогласованиеСПомошьюРеактивногоПараллельногоШлейфаToolStripMenuItem.Click
        Form2.Show()
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
        Form2.Close()
        Me.Close()
    End Sub

    Private Sub ОПрограммеToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ОПрограммеToolStripMenuItem1.Click
        Form6.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        Form7.Show()
    End Sub
End Class
