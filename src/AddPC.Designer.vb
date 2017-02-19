<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPC))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Textlunch = New System.Windows.Forms.TextBox()
        Me.Texthkeep = New System.Windows.Forms.TextBox()
        Me.TextBf = New System.Windows.Forms.TextBox()
        Me.Textdinner = New System.Windows.Forms.TextBox()
        Me.Textlaundry = New System.Windows.Forms.TextBox()
        Me.Labelman = New System.Windows.Forms.Label()
        Me.Labelpname = New System.Windows.Forms.Label()
        Me.LabelClientId = New System.Windows.Forms.Label()
        Me.AccnoLabel = New System.Windows.Forms.Label()
        Me.CodeLabel = New System.Windows.Forms.Label()
        Me.Textclientid = New System.Windows.Forms.TextBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.Textman = New System.Windows.Forms.TextBox()
        Me.Textaccno = New System.Windows.Forms.TextBox()
        Me.Textpname = New System.Windows.Forms.TextBox()
        Me.Textcode = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxClientID = New System.Windows.Forms.ComboBox()
        Me.ComboBoxAccNo = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(111, 322)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 23)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "&Laundry Cost : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(575, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 23)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "&Dinner Cost : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(576, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 23)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "&Lunch Cost : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(571, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 23)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "&Breakfast Cost : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(105, 277)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 23)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "&HouseKeeping Cost : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Textlunch
        '
        Me.Textlunch.Location = New System.Drawing.Point(761, 276)
        Me.Textlunch.Name = "Textlunch"
        Me.Textlunch.Size = New System.Drawing.Size(217, 22)
        Me.Textlunch.TabIndex = 8
        '
        'Texthkeep
        '
        Me.Texthkeep.Location = New System.Drawing.Point(289, 276)
        Me.Texthkeep.Name = "Texthkeep"
        Me.Texthkeep.Size = New System.Drawing.Size(276, 22)
        Me.Texthkeep.TabIndex = 7
        '
        'TextBf
        '
        Me.TextBf.Location = New System.Drawing.Point(761, 230)
        Me.TextBf.Name = "TextBf"
        Me.TextBf.Size = New System.Drawing.Size(217, 22)
        Me.TextBf.TabIndex = 6
        '
        'Textdinner
        '
        Me.Textdinner.Location = New System.Drawing.Point(761, 321)
        Me.Textdinner.Name = "Textdinner"
        Me.Textdinner.Size = New System.Drawing.Size(217, 22)
        Me.Textdinner.TabIndex = 10
        '
        'Textlaundry
        '
        Me.Textlaundry.Location = New System.Drawing.Point(289, 322)
        Me.Textlaundry.Name = "Textlaundry"
        Me.Textlaundry.Size = New System.Drawing.Size(276, 22)
        Me.Textlaundry.TabIndex = 9
        '
        'Labelman
        '
        Me.Labelman.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Labelman.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelman.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Labelman.Location = New System.Drawing.Point(115, 229)
        Me.Labelman.Name = "Labelman"
        Me.Labelman.Size = New System.Drawing.Size(165, 23)
        Me.Labelman.TabIndex = 104
        Me.Labelman.Text = "&ManDay Cost : "
        Me.Labelman.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Labelpname
        '
        Me.Labelpname.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Labelpname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelpname.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Labelpname.Location = New System.Drawing.Point(101, 186)
        Me.Labelpname.Name = "Labelpname"
        Me.Labelpname.Size = New System.Drawing.Size(179, 23)
        Me.Labelpname.TabIndex = 103
        Me.Labelpname.Text = "&Profit Centre Name : "
        Me.Labelpname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelClientId
        '
        Me.LabelClientId.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.LabelClientId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClientId.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelClientId.Location = New System.Drawing.Point(576, 186)
        Me.LabelClientId.Name = "LabelClientId"
        Me.LabelClientId.Size = New System.Drawing.Size(176, 23)
        Me.LabelClientId.TabIndex = 102
        Me.LabelClientId.Text = "&Client ID : "
        Me.LabelClientId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AccnoLabel
        '
        Me.AccnoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.AccnoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccnoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AccnoLabel.Location = New System.Drawing.Point(572, 139)
        Me.AccnoLabel.Name = "AccnoLabel"
        Me.AccnoLabel.Size = New System.Drawing.Size(180, 23)
        Me.AccnoLabel.TabIndex = 101
        Me.AccnoLabel.Text = "&Accommodation No. : "
        Me.AccnoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CodeLabel
        '
        Me.CodeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.CodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CodeLabel.Location = New System.Drawing.Point(110, 138)
        Me.CodeLabel.Name = "CodeLabel"
        Me.CodeLabel.Size = New System.Drawing.Size(170, 23)
        Me.CodeLabel.TabIndex = 100
        Me.CodeLabel.Text = "&Profit Centre Code : "
        Me.CodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Textclientid
        '
        Me.Textclientid.Location = New System.Drawing.Point(761, 186)
        Me.Textclientid.Name = "Textclientid"
        Me.Textclientid.Size = New System.Drawing.Size(217, 22)
        Me.Textclientid.TabIndex = 96
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(861, 393)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(115, 38)
        Me.ButtonAdd.TabIndex = 11
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'Textman
        '
        Me.Textman.Location = New System.Drawing.Point(289, 231)
        Me.Textman.Name = "Textman"
        Me.Textman.Size = New System.Drawing.Size(276, 22)
        Me.Textman.TabIndex = 5
        '
        'Textaccno
        '
        Me.Textaccno.Location = New System.Drawing.Point(761, 140)
        Me.Textaccno.Name = "Textaccno"
        Me.Textaccno.Size = New System.Drawing.Size(217, 22)
        Me.Textaccno.TabIndex = 95
        '
        'Textpname
        '
        Me.Textpname.Location = New System.Drawing.Point(289, 186)
        Me.Textpname.Name = "Textpname"
        Me.Textpname.Size = New System.Drawing.Size(276, 22)
        Me.Textpname.TabIndex = 3
        '
        'Textcode
        '
        Me.Textcode.Location = New System.Drawing.Point(289, 139)
        Me.Textcode.Name = "Textcode"
        Me.Textcode.Size = New System.Drawing.Size(276, 22)
        Me.Textcode.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1000, 664)
        Me.PictureBox1.TabIndex = 105
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(608, 496)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(379, 23)
        Me.Label6.TabIndex = 111
        Me.Label6.Text = "All Fields are Compulsory"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBoxClientID
        '
        Me.ComboBoxClientID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxClientID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxClientID.FormattingEnabled = True
        Me.ComboBoxClientID.Location = New System.Drawing.Point(761, 184)
        Me.ComboBoxClientID.Name = "ComboBoxClientID"
        Me.ComboBoxClientID.Size = New System.Drawing.Size(217, 24)
        Me.ComboBoxClientID.TabIndex = 4
        '
        'ComboBoxAccNo
        '
        Me.ComboBoxAccNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxAccNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxAccNo.FormattingEnabled = True
        Me.ComboBoxAccNo.Location = New System.Drawing.Point(761, 140)
        Me.ComboBoxAccNo.Name = "ComboBoxAccNo"
        Me.ComboBoxAccNo.Size = New System.Drawing.Size(217, 24)
        Me.ComboBoxAccNo.TabIndex = 2
        '
        'AddPC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 528)
        Me.Controls.Add(Me.ComboBoxClientID)
        Me.Controls.Add(Me.ComboBoxAccNo)
        Me.Controls.Add(Me.Label6)
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
        Me.Controls.Add(Me.Textclientid)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.Textman)
        Me.Controls.Add(Me.Textaccno)
        Me.Controls.Add(Me.Textpname)
        Me.Controls.Add(Me.Textcode)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(1017, 573)
        Me.MinimumSize = New System.Drawing.Size(1017, 573)
        Me.Name = "AddPC"
        Me.Text = "AddPC"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Textlunch As System.Windows.Forms.TextBox
    Friend WithEvents Texthkeep As System.Windows.Forms.TextBox
    Friend WithEvents TextBf As System.Windows.Forms.TextBox
    Friend WithEvents Textdinner As System.Windows.Forms.TextBox
    Friend WithEvents Textlaundry As System.Windows.Forms.TextBox
    Friend WithEvents Labelman As System.Windows.Forms.Label
    Friend WithEvents Labelpname As System.Windows.Forms.Label
    Friend WithEvents LabelClientId As System.Windows.Forms.Label
    Friend WithEvents AccnoLabel As System.Windows.Forms.Label
    Friend WithEvents CodeLabel As System.Windows.Forms.Label
    Friend WithEvents Textclientid As System.Windows.Forms.TextBox
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents Textman As System.Windows.Forms.TextBox
    Friend WithEvents Textaccno As System.Windows.Forms.TextBox
    Friend WithEvents Textpname As System.Windows.Forms.TextBox
    Friend WithEvents Textcode As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxClientID As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxAccNo As System.Windows.Forms.ComboBox
End Class
