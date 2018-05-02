<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateGroup
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
        Me.grpname = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.weekdays = New System.Windows.Forms.CheckedListBox()
        Me.starttime = New System.Windows.Forms.ComboBox()
        Me.endtime = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "اسم المجموعة:"
        '
        'grpname
        '
        Me.grpname.Location = New System.Drawing.Point(85, 30)
        Me.grpname.Name = "grpname"
        Me.grpname.Size = New System.Drawing.Size(133, 20)
        Me.grpname.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 233)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "تم"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'weekdays
        '
        Me.weekdays.FormattingEnabled = True
        Me.weekdays.Location = New System.Drawing.Point(226, 12)
        Me.weekdays.Name = "weekdays"
        Me.weekdays.Size = New System.Drawing.Size(236, 244)
        Me.weekdays.TabIndex = 7
        '
        'starttime
        '
        Me.starttime.FormattingEnabled = True
        Me.starttime.Location = New System.Drawing.Point(85, 71)
        Me.starttime.Name = "starttime"
        Me.starttime.Size = New System.Drawing.Size(133, 21)
        Me.starttime.TabIndex = 8
        '
        'endtime
        '
        Me.endtime.FormattingEnabled = True
        Me.endtime.Location = New System.Drawing.Point(85, 115)
        Me.endtime.Name = "endtime"
        Me.endtime.Size = New System.Drawing.Size(133, 21)
        Me.endtime.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "وقت البداية"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "وقت النهاية"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(126, 233)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "إلغاء"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CreateGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 272)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.endtime)
        Me.Controls.Add(Me.starttime)
        Me.Controls.Add(Me.weekdays)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.grpname)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CreateGroup"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "CreateGroup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpname As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents weekdays As System.Windows.Forms.CheckedListBox
    Friend WithEvents starttime As System.Windows.Forms.ComboBox
    Friend WithEvents endtime As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
