<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb2Shl = New System.Windows.Forms.RadioButton()
        Me.rbTrans = New System.Windows.Forms.RadioButton()
        Me.rbShl = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.РасчетыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОПрограммеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОПрограммеToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыходToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СогласованиеСПомошьюРеактивногоПараллельногоШлейфаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СогласованиеЧетвертьволновымТрансформаторомToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СогласованиеМетодомДвухРазнесенныхРеактивныхЭлементовToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(637, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ПРОГРАММА РАСЧЕТА КСВ К ЛАБОРАТОРНОЙ РАБОТЕ:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 93)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(637, 46)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "«Исследование методов согласования в полосковых линиях передачи»" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb2Shl)
        Me.GroupBox1.Controls.Add(Me.rbTrans)
        Me.GroupBox1.Controls.Add(Me.rbShl)
        Me.GroupBox1.Location = New System.Drawing.Point(84, 154)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(633, 173)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Выберите тип согласования:"
        '
        'rb2Shl
        '
        Me.rb2Shl.AutoSize = True
        Me.rb2Shl.Location = New System.Drawing.Point(45, 112)
        Me.rb2Shl.Name = "rb2Shl"
        Me.rb2Shl.Size = New System.Drawing.Size(548, 25)
        Me.rb2Shl.TabIndex = 2
        Me.rb2Shl.TabStop = True
        Me.rb2Shl.Text = "Согласование методом двух разнесенных реактивных элементов"
        Me.rb2Shl.UseVisualStyleBackColor = True
        '
        'rbTrans
        '
        Me.rbTrans.AutoSize = True
        Me.rbTrans.Location = New System.Drawing.Point(45, 81)
        Me.rbTrans.Name = "rbTrans"
        Me.rbTrans.Size = New System.Drawing.Size(448, 25)
        Me.rbTrans.TabIndex = 1
        Me.rbTrans.TabStop = True
        Me.rbTrans.Text = "Согласование четвертьволновым трансформатором"
        Me.rbTrans.UseVisualStyleBackColor = True
        '
        'rbShl
        '
        Me.rbShl.AutoSize = True
        Me.rbShl.Location = New System.Drawing.Point(45, 50)
        Me.rbShl.Name = "rbShl"
        Me.rbShl.Size = New System.Drawing.Size(536, 25)
        Me.rbShl.TabIndex = 0
        Me.rbShl.TabStop = True
        Me.rbShl.Text = "Согласование с помощью реактивного параллельного шлейфа "
        Me.rbShl.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(208, 375)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 44)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Далее"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.Location = New System.Drawing.Point(415, 375)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(162, 44)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Выход"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.РасчетыToolStripMenuItem, Me.ОПрограммеToolStripMenuItem, Me.ВыходToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(786, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'РасчетыToolStripMenuItem
        '
        Me.РасчетыToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СогласованиеСПомошьюРеактивногоПараллельногоШлейфаToolStripMenuItem, Me.СогласованиеЧетвертьволновымТрансформаторомToolStripMenuItem, Me.СогласованиеМетодомДвухРазнесенныхРеактивныхЭлементовToolStripMenuItem})
        Me.РасчетыToolStripMenuItem.Name = "РасчетыToolStripMenuItem"
        Me.РасчетыToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.РасчетыToolStripMenuItem.Text = "Расчеты"
        '
        'ОПрограммеToolStripMenuItem
        '
        Me.ОПрограммеToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ОПрограммеToolStripMenuItem1, Me.HelpToolStripMenuItem})
        Me.ОПрограммеToolStripMenuItem.Name = "ОПрограммеToolStripMenuItem"
        Me.ОПрограммеToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ОПрограммеToolStripMenuItem.Text = "Справка"
        '
        'ОПрограммеToolStripMenuItem1
        '
        Me.ОПрограммеToolStripMenuItem1.Name = "ОПрограммеToolStripMenuItem1"
        Me.ОПрограммеToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ОПрограммеToolStripMenuItem1.Text = "О программе"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ВыходToolStripMenuItem
        '
        Me.ВыходToolStripMenuItem.Name = "ВыходToolStripMenuItem"
        Me.ВыходToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ВыходToolStripMenuItem.Text = "Выход"
        '
        'СогласованиеСПомошьюРеактивногоПараллельногоШлейфаToolStripMenuItem
        '
        Me.СогласованиеСПомошьюРеактивногоПараллельногоШлейфаToolStripMenuItem.Name = "СогласованиеСПомошьюРеактивногоПараллельногоШлейфаToolStripMenuItem"
        Me.СогласованиеСПомошьюРеактивногоПараллельногоШлейфаToolStripMenuItem.Size = New System.Drawing.Size(433, 22)
        Me.СогласованиеСПомошьюРеактивногоПараллельногоШлейфаToolStripMenuItem.Text = "Согласование с помошью реактивного параллельного шлейфа"
        '
        'СогласованиеЧетвертьволновымТрансформаторомToolStripMenuItem
        '
        Me.СогласованиеЧетвертьволновымТрансформаторомToolStripMenuItem.Name = "СогласованиеЧетвертьволновымТрансформаторомToolStripMenuItem"
        Me.СогласованиеЧетвертьволновымТрансформаторомToolStripMenuItem.Size = New System.Drawing.Size(433, 22)
        Me.СогласованиеЧетвертьволновымТрансформаторомToolStripMenuItem.Text = "Согласование четвертьволновым трансформатором"
        '
        'СогласованиеМетодомДвухРазнесенныхРеактивныхЭлементовToolStripMenuItem
        '
        Me.СогласованиеМетодомДвухРазнесенныхРеактивныхЭлементовToolStripMenuItem.Name = "СогласованиеМетодомДвухРазнесенныхРеактивныхЭлементовToolStripMenuItem"
        Me.СогласованиеМетодомДвухРазнесенныхРеактивныхЭлементовToolStripMenuItem.Size = New System.Drawing.Size(433, 22)
        Me.СогласованиеМетодомДвухРазнесенныхРеактивныхЭлементовToolStripMenuItem.Text = "Согласование методом двух разнесенных реактивных элементов"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(786, 460)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form1"
        Me.Text = "Главное окно"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb2Shl As System.Windows.Forms.RadioButton
    Friend WithEvents rbTrans As System.Windows.Forms.RadioButton
    Friend WithEvents rbShl As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents РасчетыToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ОПрограммеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ОПрограммеToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ВыходToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СогласованиеСПомошьюРеактивногоПараллельногоШлейфаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СогласованиеЧетвертьволновымТрансформаторомToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СогласованиеМетодомДвухРазнесенныхРеактивныхЭлементовToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
