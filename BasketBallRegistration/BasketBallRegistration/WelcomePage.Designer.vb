<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomePage
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
        Me.usernamelabel = New System.Windows.Forms.Label()
        Me.groupreg = New System.Windows.Forms.Button()
        Me.playerreg = New System.Windows.Forms.Button()
        Me.paymentreg = New System.Windows.Forms.Button()
        Me.attendancereg = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.newUser = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'usernamelabel
        '
        Me.usernamelabel.AutoSize = True
        Me.usernamelabel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usernamelabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.usernamelabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernamelabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.usernamelabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.usernamelabel.Location = New System.Drawing.Point(208, 8)
        Me.usernamelabel.Name = "usernamelabel"
        Me.usernamelabel.Size = New System.Drawing.Size(116, 24)
        Me.usernamelabel.TabIndex = 0
        Me.usernamelabel.Text = "اهلاً اسم المستخدم"
        '
        'groupreg
        '
        Me.groupreg.Location = New System.Drawing.Point(352, 79)
        Me.groupreg.Name = "groupreg"
        Me.groupreg.Size = New System.Drawing.Size(144, 23)
        Me.groupreg.TabIndex = 1
        Me.groupreg.Text = "تسجيل مجموعة"
        Me.groupreg.UseVisualStyleBackColor = True
        '
        'playerreg
        '
        Me.playerreg.Location = New System.Drawing.Point(30, 134)
        Me.playerreg.Name = "playerreg"
        Me.playerreg.Size = New System.Drawing.Size(144, 23)
        Me.playerreg.TabIndex = 2
        Me.playerreg.Text = "تسجيل لاعب"
        Me.playerreg.UseVisualStyleBackColor = True
        '
        'paymentreg
        '
        Me.paymentreg.Location = New System.Drawing.Point(352, 198)
        Me.paymentreg.Name = "paymentreg"
        Me.paymentreg.Size = New System.Drawing.Size(144, 23)
        Me.paymentreg.TabIndex = 3
        Me.paymentreg.Text = "الدفع"
        Me.paymentreg.UseVisualStyleBackColor = True
        '
        'attendancereg
        '
        Me.attendancereg.Location = New System.Drawing.Point(30, 79)
        Me.attendancereg.Name = "attendancereg"
        Me.attendancereg.Size = New System.Drawing.Size(144, 23)
        Me.attendancereg.TabIndex = 4
        Me.attendancereg.Text = "تسجيل الحضور"
        Me.attendancereg.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(212, 291)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(112, 23)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "تسجيل الخروج"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'newUser
        '
        Me.newUser.Location = New System.Drawing.Point(352, 145)
        Me.newUser.Name = "newUser"
        Me.newUser.Size = New System.Drawing.Size(144, 23)
        Me.newUser.TabIndex = 6
        Me.newUser.Text = "تسجيل مستخدم جديد"
        Me.newUser.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "عرض اللاعبين"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(30, 245)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "عرض الحضور"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'WelcomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 326)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.newUser)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.attendancereg)
        Me.Controls.Add(Me.paymentreg)
        Me.Controls.Add(Me.playerreg)
        Me.Controls.Add(Me.groupreg)
        Me.Controls.Add(Me.usernamelabel)
        Me.Name = "WelcomePage"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "البداية"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents usernamelabel As System.Windows.Forms.Label
    Friend WithEvents groupreg As System.Windows.Forms.Button
    Friend WithEvents playerreg As System.Windows.Forms.Button
    Friend WithEvents paymentreg As System.Windows.Forms.Button
    Friend WithEvents attendancereg As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents newUser As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
