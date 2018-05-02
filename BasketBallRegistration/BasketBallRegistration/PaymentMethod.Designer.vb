<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentMethod
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.playerSelection = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.playersearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panelsmall = New System.Windows.Forms.Panel()
        Me.numberoflessons = New System.Windows.Forms.TextBox()
        Me.number_of = New System.Windows.Forms.Label()
        Me.Panelsmall.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(140, 81)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "تم"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(178, 261)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "إلغاء"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'playerSelection
        '
        Me.playerSelection.FormattingEnabled = True
        Me.playerSelection.Location = New System.Drawing.Point(93, 59)
        Me.playerSelection.Name = "playerSelection"
        Me.playerSelection.Size = New System.Drawing.Size(163, 21)
        Me.playerSelection.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "بحث"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'playersearch
        '
        Me.playersearch.Location = New System.Drawing.Point(93, 10)
        Me.playersearch.Name = "playersearch"
        Me.playersearch.Size = New System.Drawing.Size(163, 20)
        Me.playersearch.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(262, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "اسم اللاعب"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 57)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "تم"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panelsmall
        '
        Me.Panelsmall.Controls.Add(Me.numberoflessons)
        Me.Panelsmall.Controls.Add(Me.number_of)
        Me.Panelsmall.Controls.Add(Me.Button1)
        Me.Panelsmall.Location = New System.Drawing.Point(38, 109)
        Me.Panelsmall.Name = "Panelsmall"
        Me.Panelsmall.Size = New System.Drawing.Size(246, 129)
        Me.Panelsmall.TabIndex = 14
        '
        'numberoflessons
        '
        Me.numberoflessons.Location = New System.Drawing.Point(30, 39)
        Me.numberoflessons.Name = "numberoflessons"
        Me.numberoflessons.Size = New System.Drawing.Size(100, 20)
        Me.numberoflessons.TabIndex = 14
        '
        'number_of
        '
        Me.number_of.AutoSize = True
        Me.number_of.Location = New System.Drawing.Point(155, 42)
        Me.number_of.Name = "number_of"
        Me.number_of.Size = New System.Drawing.Size(60, 13)
        Me.number_of.TabIndex = 12
        Me.number_of.Text = "عدد الحصص"
        '
        'PaymentMethod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 296)
        Me.Controls.Add(Me.Panelsmall)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.playersearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.playerSelection)
        Me.Name = "PaymentMethod"
        Me.Text = "Payment"
        Me.Panelsmall.ResumeLayout(False)
        Me.Panelsmall.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents playerSelection As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents playersearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panelsmall As System.Windows.Forms.Panel
    Friend WithEvents numberoflessons As System.Windows.Forms.TextBox
    Friend WithEvents number_of As System.Windows.Forms.Label
End Class
