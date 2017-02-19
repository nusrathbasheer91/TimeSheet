<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormViewPC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormViewPC))
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonViewClient = New System.Windows.Forms.Button()
        Me.ButtonViewCamp = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Textcode = New System.Windows.Forms.TextBox()
        Me.Textpname = New System.Windows.Forms.TextBox()
        Me.Textaccno = New System.Windows.Forms.TextBox()
        Me.Textman = New System.Windows.Forms.TextBox()
        Me.Textclientid = New System.Windows.Forms.TextBox()
        Me.CodeLabel = New System.Windows.Forms.Label()
        Me.AccnoLabel = New System.Windows.Forms.Label()
        Me.LabelClientId = New System.Windows.Forms.Label()
        Me.Labelpname = New System.Windows.Forms.Label()
        Me.Labelman = New System.Windows.Forms.Label()
        Me.Textlaundry = New System.Windows.Forms.TextBox()
        Me.Textdinner = New System.Windows.Forms.TextBox()
        Me.TextBf = New System.Windows.Forms.TextBox()
        Me.Texthkeep = New System.Windows.Forms.TextBox()
        Me.Textlunch = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonViewEmp = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(256, 393)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(108, 38)
        Me.ButtonDelete.TabIndex = 12
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(140, 393)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(101, 38)
        Me.ButtonEdit.TabIndex = 11
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonViewClient
        '
        Me.ButtonViewClient.Location = New System.Drawing.Point(708, 393)
        Me.ButtonViewClient.Name = "ButtonViewClient"
        Me.ButtonViewClient.Size = New System.Drawing.Size(122, 38)
        Me.ButtonViewClient.TabIndex = 14
        Me.ButtonViewClient.Text = "View Client"
        Me.ButtonViewClient.UseVisualStyleBackColor = True
        '
        'ButtonViewCamp
        '
        Me.ButtonViewCamp.Location = New System.Drawing.Point(861, 393)
        Me.ButtonViewCamp.Name = "ButtonViewCamp"
        Me.ButtonViewCamp.Size = New System.Drawing.Size(115, 38)
        Me.ButtonViewCamp.TabIndex = 15
        Me.ButtonViewCamp.Text = "View Camp"
        Me.ButtonViewCamp.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1000, 664)
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'Textcode
        '
        Me.Textcode.Location = New System.Drawing.Point(289, 139)
        Me.Textcode.Name = "Textcode"
        Me.Textcode.ReadOnly = True
        Me.Textcode.Size = New System.Drawing.Size(276, 22)
        Me.Textcode.TabIndex = 1
        '
        'Textpname
        '
        Me.Textpname.Location = New System.Drawing.Point(289, 186)
        Me.Textpname.Name = "Textpname"
        Me.Textpname.ReadOnly = True
        Me.Textpname.Size = New System.Drawing.Size(276, 22)
        Me.Textpname.TabIndex = 3
        '
        'Textaccno
        '
        Me.Textaccno.Location = New System.Drawing.Point(761, 140)
        Me.Textaccno.Name = "Textaccno"
        Me.Textaccno.ReadOnly = True
        Me.Textaccno.Size = New System.Drawing.Size(217, 22)
        Me.Textaccno.TabIndex = 2
        '
        'Textman
        '
        Me.Textman.Location = New System.Drawing.Point(289, 231)
        Me.Textman.Name = "Textman"
        Me.Textman.ReadOnly = True
        Me.Textman.Size = New System.Drawing.Size(276, 22)
        Me.Textman.TabIndex = 5
        '
        'Textclientid
        '
        Me.Textclientid.Location = New System.Drawing.Point(761, 186)
        Me.Textclientid.Name = "Textclientid"
        Me.Textclientid.ReadOnly = True
        Me.Textclientid.Size = New System.Drawing.Size(217, 22)
        Me.Textclientid.TabIndex = 4
        '
        'CodeLabel
        '
        Me.CodeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.CodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CodeLabel.Location = New System.Drawing.Point(110, 138)
        Me.CodeLabel.Name = "CodeLabel"
        Me.CodeLabel.Size = New System.Drawing.Size(170, 23)
        Me.CodeLabel.TabIndex = 48
        Me.CodeLabel.Text = "&Profit Centre Code : "
        Me.CodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AccnoLabel
        '
        Me.AccnoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.AccnoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccnoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AccnoLabel.Location = New System.Drawing.Point(572, 139)
        Me.AccnoLabel.Name = "AccnoLabel"
        Me.AccnoLabel.Size = New System.Drawing.Size(180, 23)
        Me.AccnoLabel.TabIndex = 49
        Me.AccnoLabel.Text = "&Accommodation No. : "
        Me.AccnoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelClientId
        '
        Me.LabelClientId.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.LabelClientId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClientId.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelClientId.Location = New System.Drawing.Point(576, 186)
        Me.LabelClientId.Name = "LabelClientId"
        Me.LabelClientId.Size = New System.Drawing.Size(176, 23)
        Me.LabelClientId.TabIndex = 50
        Me.LabelClientId.Text = "&Client ID : "
        Me.LabelClientId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Labelpname
        '
        Me.Labelpname.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Labelpname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelpname.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Labelpname.Location = New System.Drawing.Point(101, 186)
        Me.Labelpname.Name = "Labelpname"
        Me.Labelpname.Size = New System.Drawing.Size(179, 23)
        Me.Labelpname.TabIndex = 51
        Me.Labelpname.Text = "&Profit Centre Name : "
        Me.Labelpname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Labelman
        '
        Me.Labelman.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Labelman.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelman.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Labelman.Location = New System.Drawing.Point(115, 229)
        Me.Labelman.Name = "Labelman"
        Me.Labelman.Size = New System.Drawing.Size(165, 23)
        Me.Labelman.TabIndex = 52
        Me.Labelman.Text = "&ManDay Cost : "
        Me.Labelman.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Textlaundry
        '
        Me.Textlaundry.Location = New System.Drawing.Point(289, 322)
        Me.Textlaundry.Name = "Textlaundry"
        Me.Textlaundry.ReadOnly = True
        Me.Textlaundry.Size = New System.Drawing.Size(276, 22)
        Me.Textlaundry.TabIndex = 9
        '
        'Textdinner
        '
        Me.Textdinner.Location = New System.Drawing.Point(761, 321)
        Me.Textdinner.Name = "Textdinner"
        Me.Textdinner.ReadOnly = True
        Me.Textdinner.Size = New System.Drawing.Size(217, 22)
        Me.Textdinner.TabIndex = 10
        '
        'TextBf
        '
        Me.TextBf.Location = New System.Drawing.Point(761, 230)
        Me.TextBf.Name = "TextBf"
        Me.TextBf.ReadOnly = True
        Me.TextBf.Size = New System.Drawing.Size(217, 22)
        Me.TextBf.TabIndex = 6
        '
        'Texthkeep
        '
        Me.Texthkeep.Location = New System.Drawing.Point(289, 276)
        Me.Texthkeep.Name = "Texthkeep"
        Me.Texthkeep.ReadOnly = True
        Me.Texthkeep.Size = New System.Drawing.Size(276, 22)
        Me.Texthkeep.TabIndex = 7
        '
        'Textlunch
        '
        Me.Textlunch.Location = New System.Drawing.Point(761, 276)
        Me.Textlunch.Name = "Textlunch"
        Me.Textlunch.ReadOnly = True
        Me.Textlunch.Size = New System.Drawing.Size(217, 22)
        Me.Textlunch.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(105, 277)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 23)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "&HouseKeeping Cost : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(571, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 23)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "&Breakfast Cost : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(576, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 23)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "&Lunch Cost : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(575, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 23)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "&Dinner Cost : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(111, 322)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 23)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "&Laundry Cost : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonViewEmp
        '
        Me.ButtonViewEmp.Location = New System.Drawing.Point(472, 393)
        Me.ButtonViewEmp.Name = "ButtonViewEmp"
        Me.ButtonViewEmp.Size = New System.Drawing.Size(215, 38)
        Me.ButtonViewEmp.TabIndex = 13
        Me.ButtonViewEmp.Text = "View Employees in this Centre"
        Me.ButtonViewEmp.UseVisualStyleBackColor = True
        '
        'FormViewPC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 466)
        Me.Controls.Add(Me.ButtonViewEmp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Textlunch)
        Me.Controls.Add(Me.Texthkeep)
        Me.Controls.Add(Me.TextBf)
        Me.Controls.Add(Me.Textdinner)
        Me.Controls.Add(Me.Textlaundry)
        Me.Controls.Add(Me.Labelman)
        Me.Controls.Add(Me.Labelpname)
        Me.Controls.Add(Me.LabelClientId)
        Me.Controls.Add(Me.AccnoLabel)
        Me.Controls.Add(Me.CodeLabel)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonViewClient)
        Me.Controls.Add(Me.Textclientid)
        Me.Controls.Add(Me.ButtonViewCamp)
        Me.Controls.Add(Me.Textman)
        Me.Controls.Add(Me.Textaccno)
        Me.Controls.Add(Me.Textpname)
        Me.Controls.Add(Me.Textcode)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(1017, 511)
        Me.MinimumSize = New System.Drawing.Size(1017, 511)
        Me.Name = "FormViewPC"
        Me.Text = "FormViewPC"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents ButtonViewClient As System.Windows.Forms.Button
    Friend WithEvents ButtonViewCamp As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Textcode As System.Windows.Forms.TextBox
    Friend WithEvents Textpname As System.Windows.Forms.TextBox
    Friend WithEvents Textaccno As System.Windows.Forms.TextBox
    Friend WithEvents Textman As System.Windows.Forms.TextBox
    Friend WithEvents Textclientid As System.Windows.Forms.TextBox
    Friend WithEvents CodeLabel As System.Windows.Forms.Label
    Friend WithEvents AccnoLabel As System.Windows.Forms.Label
    Friend WithEvents LabelClientId As System.Windows.Forms.Label
    Friend WithEvents Labelpname As System.Windows.Forms.Label
    Friend WithEvents Labelman As System.Windows.Forms.Label
    Friend WithEvents Textlaundry As System.Windows.Forms.TextBox
    Friend WithEvents Textdinner As System.Windows.Forms.TextBox
    Friend WithEvents TextBf As System.Windows.Forms.TextBox
    Friend WithEvents Texthkeep As System.Windows.Forms.TextBox
    Friend WithEvents Textlunch As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonViewEmp As System.Windows.Forms.Button
End Class
