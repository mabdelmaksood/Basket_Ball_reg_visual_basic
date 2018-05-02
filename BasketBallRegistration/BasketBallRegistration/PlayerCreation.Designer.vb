<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerCreation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Pcode = New System.Windows.Forms.TextBox()
        Me.pname = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.grpselection = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.perlesson = New System.Windows.Forms.RadioButton()
        Me.permonth = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.sum = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lessonprice = New System.Windows.Forms.TextBox()
        Me.numberoflessons = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(539, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "كود"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(539, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "اسم"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(539, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "تاريخ ميلاد"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(539, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "المجموعة"
        '
        'Pcode
        '
        Me.Pcode.Location = New System.Drawing.Point(260, 19)
        Me.Pcode.Name = "Pcode"
        Me.Pcode.Size = New System.Drawing.Size(246, 20)
        Me.Pcode.TabIndex = 4
        '
        'pname
        '
        Me.pname.Location = New System.Drawing.Point(260, 48)
        Me.pname.Name = "pname"
        Me.pname.Size = New System.Drawing.Size(246, 20)
        Me.pname.TabIndex = 5
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(260, 73)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(246, 20)
        Me.DateTimePicker1.TabIndex = 6
        '
        'grpselection
        '
        Me.grpselection.FormattingEnabled = True
        Me.grpselection.Location = New System.Drawing.Point(260, 106)
        Me.grpselection.Name = "grpselection"
        Me.grpselection.Size = New System.Drawing.Size(246, 21)
        Me.grpselection.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(478, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "طريقة الدفع"
        '
        'perlesson
        '
        Me.perlesson.AutoSize = True
        Me.perlesson.Location = New System.Drawing.Point(415, 203)
        Me.perlesson.Name = "perlesson"
        Me.perlesson.Size = New System.Drawing.Size(57, 17)
        Me.perlesson.TabIndex = 9
        Me.perlesson.TabStop = True
        Me.perlesson.Text = "بالحصة"
        Me.perlesson.UseVisualStyleBackColor = True
        '
        'permonth
        '
        Me.permonth.AutoSize = True
        Me.permonth.Location = New System.Drawing.Point(415, 226)
        Me.permonth.Name = "permonth"
        Me.permonth.Size = New System.Drawing.Size(56, 17)
        Me.permonth.TabIndex = 10
        Me.permonth.TabStop = True
        Me.permonth.Text = "بالشهر"
        Me.permonth.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.sum)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lessonprice)
        Me.Panel1.Controls.Add(Me.numberoflessons)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(105, 178)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(246, 107)
        Me.Panel1.TabIndex = 11
        '
        'sum
        '
        Me.sum.AutoSize = True
        Me.sum.Location = New System.Drawing.Point(114, 83)
        Me.sum.Name = "sum"
        Me.sum.Size = New System.Drawing.Size(0, 13)
        Me.sum.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(89, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = " "
        '
        'lessonprice
        '
        Me.lessonprice.Location = New System.Drawing.Point(46, 47)
        Me.lessonprice.Name = "lessonprice"
        Me.lessonprice.Size = New System.Drawing.Size(100, 20)
        Me.lessonprice.TabIndex = 15
        '
        'numberoflessons
        '
        Me.numberoflessons.Location = New System.Drawing.Point(46, 13)
        Me.numberoflessons.Name = "numberoflessons"
        Me.numberoflessons.Size = New System.Drawing.Size(100, 20)
        Me.numberoflessons.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(174, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "سعر الحصة"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(171, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "عدد الحصص"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 46)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "تم"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(30, 98)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 46)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "إلغاء"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PlayerCreation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 296)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.permonth)
        Me.Controls.Add(Me.perlesson)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.grpselection)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.pname)
        Me.Controls.Add(Me.Pcode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PlayerCreation"
        Me.Text = "PlayerCreation"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Pcode As System.Windows.Forms.TextBox
    Friend WithEvents pname As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents grpselection As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents perlesson As System.Windows.Forms.RadioButton
    Friend WithEvents permonth As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lessonprice As System.Windows.Forms.TextBox
    Friend WithEvents numberoflessons As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents sum As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
