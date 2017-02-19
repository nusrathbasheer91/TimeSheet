<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdmin))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonChPwdAd = New System.Windows.Forms.Button()
        Me.ButtonCompany = New System.Windows.Forms.Button()
        Me.ButtonViewUser = New System.Windows.Forms.Button()
        Me.ButtonViewEmp = New System.Windows.Forms.Button()
        Me.ButtonEmpAll = New System.Windows.Forms.Button()
        Me.ButtonClAl = New System.Windows.Forms.Button()
        Me.ButtonViewCl = New System.Windows.Forms.Button()
        Me.ButtonPcAll = New System.Windows.Forms.Button()
        Me.ButtonViewPc = New System.Windows.Forms.Button()
        Me.ButtonAddCl = New System.Windows.Forms.Button()
        Me.ButtonAddEmp = New System.Windows.Forms.Button()
        Me.ButtonAddPc = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonAt = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ButtonMonthly = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label = New System.Windows.Forms.Label()
        Me.ButtonEditCo = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.ButtonTransfer = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ButtonLogOut = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-14, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1000, 730)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'ButtonChPwdAd
        '
        Me.ButtonChPwdAd.Location = New System.Drawing.Point(343, 640)
        Me.ButtonChPwdAd.Name = "ButtonChPwdAd"
        Me.ButtonChPwdAd.Size = New System.Drawing.Size(161, 54)
        Me.ButtonChPwdAd.TabIndex = 16
        Me.ButtonChPwdAd.Text = "Change Password"
        Me.ButtonChPwdAd.UseVisualStyleBackColor = True
        '
        'ButtonCompany
        '
        Me.ButtonCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCompany.Location = New System.Drawing.Point(19, 20)
        Me.ButtonCompany.Name = "ButtonCompany"
        Me.ButtonCompany.Size = New System.Drawing.Size(167, 63)
        Me.ButtonCompany.TabIndex = 17
        Me.ButtonCompany.Text = "Camp Details"
        Me.ButtonCompany.UseVisualStyleBackColor = True
        '
        'ButtonViewUser
        '
        Me.ButtonViewUser.Location = New System.Drawing.Point(569, 640)
        Me.ButtonViewUser.Name = "ButtonViewUser"
        Me.ButtonViewUser.Size = New System.Drawing.Size(167, 54)
        Me.ButtonViewUser.TabIndex = 18
        Me.ButtonViewUser.Text = "View Users"
        Me.ButtonViewUser.UseVisualStyleBackColor = True
        '
        'ButtonViewEmp
        '
        Me.ButtonViewEmp.Location = New System.Drawing.Point(20, 66)
        Me.ButtonViewEmp.Name = "ButtonViewEmp"
        Me.ButtonViewEmp.Size = New System.Drawing.Size(175, 63)
        Me.ButtonViewEmp.TabIndex = 20
        Me.ButtonViewEmp.Text = "View Employee"
        Me.ButtonViewEmp.UseVisualStyleBackColor = True
        '
        'ButtonEmpAll
        '
        Me.ButtonEmpAll.Location = New System.Drawing.Point(20, 169)
        Me.ButtonEmpAll.Name = "ButtonEmpAll"
        Me.ButtonEmpAll.Size = New System.Drawing.Size(175, 63)
        Me.ButtonEmpAll.TabIndex = 21
        Me.ButtonEmpAll.Text = "View All Employees"
        Me.ButtonEmpAll.UseVisualStyleBackColor = True
        '
        'ButtonClAl
        '
        Me.ButtonClAl.Location = New System.Drawing.Point(22, 169)
        Me.ButtonClAl.Name = "ButtonClAl"
        Me.ButtonClAl.Size = New System.Drawing.Size(175, 63)
        Me.ButtonClAl.TabIndex = 23
        Me.ButtonClAl.Text = "View All Clients"
        Me.ButtonClAl.UseVisualStyleBackColor = True
        '
        'ButtonViewCl
        '
        Me.ButtonViewCl.Location = New System.Drawing.Point(22, 66)
        Me.ButtonViewCl.Name = "ButtonViewCl"
        Me.ButtonViewCl.Size = New System.Drawing.Size(175, 63)
        Me.ButtonViewCl.TabIndex = 22
        Me.ButtonViewCl.Text = "View Client"
        Me.ButtonViewCl.UseVisualStyleBackColor = True
        '
        'ButtonPcAll
        '
        Me.ButtonPcAll.Location = New System.Drawing.Point(21, 168)
        Me.ButtonPcAll.Name = "ButtonPcAll"
        Me.ButtonPcAll.Size = New System.Drawing.Size(175, 63)
        Me.ButtonPcAll.TabIndex = 25
        Me.ButtonPcAll.Text = "View All Profit Centres"
        Me.ButtonPcAll.UseVisualStyleBackColor = True
        '
        'ButtonViewPc
        '
        Me.ButtonViewPc.Location = New System.Drawing.Point(21, 65)
        Me.ButtonViewPc.Name = "ButtonViewPc"
        Me.ButtonViewPc.Size = New System.Drawing.Size(175, 63)
        Me.ButtonViewPc.TabIndex = 24
        Me.ButtonViewPc.Text = "View Profit Centre"
        Me.ButtonViewPc.UseVisualStyleBackColor = True
        '
        'ButtonAddCl
        '
        Me.ButtonAddCl.Location = New System.Drawing.Point(22, 268)
        Me.ButtonAddCl.Name = "ButtonAddCl"
        Me.ButtonAddCl.Size = New System.Drawing.Size(175, 63)
        Me.ButtonAddCl.TabIndex = 27
        Me.ButtonAddCl.Text = "Add Client"
        Me.ButtonAddCl.UseVisualStyleBackColor = True
        '
        'ButtonAddEmp
        '
        Me.ButtonAddEmp.Location = New System.Drawing.Point(20, 268)
        Me.ButtonAddEmp.Name = "ButtonAddEmp"
        Me.ButtonAddEmp.Size = New System.Drawing.Size(175, 63)
        Me.ButtonAddEmp.TabIndex = 26
        Me.ButtonAddEmp.Text = "Add Employee"
        Me.ButtonAddEmp.UseVisualStyleBackColor = True
        '
        'ButtonAddPc
        '
        Me.ButtonAddPc.Location = New System.Drawing.Point(21, 267)
        Me.ButtonAddPc.Name = "ButtonAddPc"
        Me.ButtonAddPc.Size = New System.Drawing.Size(175, 63)
        Me.ButtonAddPc.TabIndex = 28
        Me.ButtonAddPc.Text = "Add Profit Centre"
        Me.ButtonAddPc.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.ButtonAddEmp)
        Me.Panel2.Controls.Add(Me.ButtonEmpAll)
        Me.Panel2.Controls.Add(Me.ButtonViewEmp)
        Me.Panel2.Location = New System.Drawing.Point(127, 125)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(216, 355)
        Me.Panel2.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 19)
        Me.Label1.MinimumSize = New System.Drawing.Size(100, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 30)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Employees"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.ButtonAddCl)
        Me.Panel4.Controls.Add(Me.ButtonClAl)
        Me.Panel4.Controls.Add(Me.ButtonViewCl)
        Me.Panel4.Location = New System.Drawing.Point(414, 125)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(215, 355)
        Me.Panel4.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(52, 19)
        Me.Label2.MinimumSize = New System.Drawing.Size(100, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 30)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Clients"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.ButtonPcAll)
        Me.Panel3.Controls.Add(Me.ButtonViewPc)
        Me.Panel3.Controls.Add(Me.ButtonAddPc)
        Me.Panel3.Location = New System.Drawing.Point(698, 126)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(215, 355)
        Me.Panel3.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Bold", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 18)
        Me.Label3.MinimumSize = New System.Drawing.Size(100, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 30)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Profit Centres"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ButtonAt)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Location = New System.Drawing.Point(323, 515)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(207, 101)
        Me.Panel1.TabIndex = 39
        '
        'ButtonAt
        '
        Me.ButtonAt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAt.Location = New System.Drawing.Point(20, 20)
        Me.ButtonAt.Name = "ButtonAt"
        Me.ButtonAt.Size = New System.Drawing.Size(166, 63)
        Me.ButtonAt.TabIndex = 35
        Me.ButtonAt.Text = "Absent"
        Me.ButtonAt.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(21, 168)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(175, 63)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "View All Profit Centres"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(21, 267)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(175, 63)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "Add Profit Centre"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ButtonMonthly
        '
        Me.ButtonMonthly.Location = New System.Drawing.Point(19, 20)
        Me.ButtonMonthly.Name = "ButtonMonthly"
        Me.ButtonMonthly.Size = New System.Drawing.Size(161, 63)
        Me.ButtonMonthly.TabIndex = 41
        Me.ButtonMonthly.Text = "Monthly Report"
        Me.ButtonMonthly.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Panel5.Controls.Add(Me.ButtonMonthly)
        Me.Panel5.Location = New System.Drawing.Point(769, 515)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(201, 101)
        Me.Panel5.TabIndex = 40
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel6.Controls.Add(Me.ButtonCompany)
        Me.Panel6.Location = New System.Drawing.Point(550, 515)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(201, 101)
        Me.Panel6.TabIndex = 41
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label.Font = New System.Drawing.Font("Copperplate Gothic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.Color.Yellow
        Me.Label.Location = New System.Drawing.Point(119, 44)
        Me.Label.MinimumSize = New System.Drawing.Size(100, 30)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(121, 44)
        Me.Label.TabIndex = 43
        Me.Label.Text = "Text"
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonEditCo
        '
        Me.ButtonEditCo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditCo.Location = New System.Drawing.Point(108, 640)
        Me.ButtonEditCo.Name = "ButtonEditCo"
        Me.ButtonEditCo.Size = New System.Drawing.Size(166, 54)
        Me.ButtonEditCo.TabIndex = 18
        Me.ButtonEditCo.Text = "Edit Company"
        Me.ButtonEditCo.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Panel7.Controls.Add(Me.ButtonTransfer)
        Me.Panel7.Controls.Add(Me.Button3)
        Me.Panel7.Controls.Add(Me.Button5)
        Me.Panel7.Location = New System.Drawing.Point(88, 515)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(207, 101)
        Me.Panel7.TabIndex = 40
        '
        'ButtonTransfer
        '
        Me.ButtonTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTransfer.Location = New System.Drawing.Point(20, 20)
        Me.ButtonTransfer.Name = "ButtonTransfer"
        Me.ButtonTransfer.Size = New System.Drawing.Size(166, 63)
        Me.ButtonTransfer.TabIndex = 35
        Me.ButtonTransfer.Text = "Transfer "
        Me.ButtonTransfer.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(21, 168)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(175, 63)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "View All Profit Centres"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(21, 267)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(175, 63)
        Me.Button5.TabIndex = 28
        Me.Button5.Text = "Add Profit Centre"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ButtonLogOut
        '
        Me.ButtonLogOut.Location = New System.Drawing.Point(788, 640)
        Me.ButtonLogOut.Name = "ButtonLogOut"
        Me.ButtonLogOut.Size = New System.Drawing.Size(161, 54)
        Me.ButtonLogOut.TabIndex = 44
        Me.ButtonLogOut.Text = "Log Out"
        Me.ButtonLogOut.UseVisualStyleBackColor = True
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 719)
        Me.Controls.Add(Me.ButtonLogOut)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.ButtonEditCo)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ButtonViewUser)
        Me.Controls.Add(Me.ButtonChPwdAd)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(1000, 764)
        Me.MinimumSize = New System.Drawing.Size(1000, 764)
        Me.Name = "FormAdmin"
        Me.Text = "FormAdmin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonChPwdAd As System.Windows.Forms.Button
    Friend WithEvents ButtonCompany As System.Windows.Forms.Button
    Friend WithEvents ButtonViewUser As System.Windows.Forms.Button
    Friend WithEvents ButtonViewEmp As System.Windows.Forms.Button
    Friend WithEvents ButtonEmpAll As System.Windows.Forms.Button
    Friend WithEvents ButtonClAl As System.Windows.Forms.Button
    Friend WithEvents ButtonViewCl As System.Windows.Forms.Button
    Friend WithEvents ButtonPcAll As System.Windows.Forms.Button
    Friend WithEvents ButtonViewPc As System.Windows.Forms.Button
    Friend WithEvents ButtonAddCl As System.Windows.Forms.Button
    Friend WithEvents ButtonAddEmp As System.Windows.Forms.Button
    Friend WithEvents ButtonAddPc As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ButtonAt As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ButtonMonthly As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents ButtonEditCo As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents ButtonTransfer As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ButtonLogOut As System.Windows.Forms.Button
End Class
