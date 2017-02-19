<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditEmp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditEmp))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Textbadge = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextID = New System.Windows.Forms.TextBox()
        Me.Labelman = New System.Windows.Forms.Label()
        Me.Labelpname = New System.Windows.Forms.Label()
        Me.LabelClientId = New System.Windows.Forms.Label()
        Me.AccnoLabel = New System.Windows.Forms.Label()
        Me.CodeLabel = New System.Windows.Forms.Label()
        Me.Textdob = New System.Windows.Forms.TextBox()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.Textnat = New System.Windows.Forms.TextBox()
        Me.Textaccno = New System.Windows.Forms.TextBox()
        Me.Textename = New System.Windows.Forms.TextBox()
        Me.Textcode = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Textnextmed = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(94, 304)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 23)
        Me.Label5.TabIndex = 160
        Me.Label5.Text = "Date Format : yyyy-mm-dd"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(141, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 23)
        Me.Label6.TabIndex = 157
        Me.Label6.Text = "*&Badge No : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Textbadge
        '
        Me.Textbadge.Location = New System.Drawing.Point(252, 96)
        Me.Textbadge.Name = "Textbadge"
        Me.Textbadge.ReadOnly = True
        Me.Textbadge.Size = New System.Drawing.Size(276, 22)
        Me.Textbadge.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(187, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 23)
        Me.Label4.TabIndex = 156
        Me.Label4.Text = "&ID : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextID
        '
        Me.TextID.Location = New System.Drawing.Point(252, 222)
        Me.TextID.Name = "TextID"
        Me.TextID.Size = New System.Drawing.Size(276, 22)
        Me.TextID.TabIndex = 7
        '
        'Labelman
        '
        Me.Labelman.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Labelman.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelman.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Labelman.Location = New System.Drawing.Point(554, 179)
        Me.Labelman.Name = "Labelman"
        Me.Labelman.Size = New System.Drawing.Size(165, 23)
        Me.Labelman.TabIndex = 155
        Me.Labelman.Text = "&Nationality : "
        Me.Labelman.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Labelpname
        '
        Me.Labelpname.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Labelpname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelpname.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Labelpname.Location = New System.Drawing.Point(93, 140)
        Me.Labelpname.Name = "Labelpname"
        Me.Labelpname.Size = New System.Drawing.Size(153, 23)
        Me.Labelpname.TabIndex = 154
        Me.Labelpname.Text = "*&Employee Name : "
        Me.Labelpname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelClientId
        '
        Me.LabelClientId.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.LabelClientId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClientId.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelClientId.Location = New System.Drawing.Point(120, 181)
        Me.LabelClientId.Name = "LabelClientId"
        Me.LabelClientId.Size = New System.Drawing.Size(126, 23)
        Me.LabelClientId.TabIndex = 153
        Me.LabelClientId.Text = "&Date Of Birth : "
        Me.LabelClientId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AccnoLabel
        '
        Me.AccnoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.AccnoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccnoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AccnoLabel.Location = New System.Drawing.Point(539, 96)
        Me.AccnoLabel.Name = "AccnoLabel"
        Me.AccnoLabel.Size = New System.Drawing.Size(180, 23)
        Me.AccnoLabel.TabIndex = 152
        Me.AccnoLabel.Text = "*&Accommodation No. : "
        Me.AccnoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CodeLabel
        '
        Me.CodeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.CodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CodeLabel.Location = New System.Drawing.Point(549, 138)
        Me.CodeLabel.Name = "CodeLabel"
        Me.CodeLabel.Size = New System.Drawing.Size(170, 23)
        Me.CodeLabel.TabIndex = 151
        Me.CodeLabel.Text = "*&Profit Centre Code : "
        Me.CodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Textdob
        '
        Me.Textdob.Location = New System.Drawing.Point(252, 181)
        Me.Textdob.Name = "Textdob"
        Me.Textdob.Size = New System.Drawing.Size(276, 22)
        Me.Textdob.TabIndex = 5
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(871, 273)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(115, 38)
        Me.ButtonUpdate.TabIndex = 9
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'Textnat
        '
        Me.Textnat.Location = New System.Drawing.Point(728, 181)
        Me.Textnat.Name = "Textnat"
        Me.Textnat.Size = New System.Drawing.Size(237, 22)
        Me.Textnat.TabIndex = 6
        '
        'Textaccno
        '
        Me.Textaccno.Location = New System.Drawing.Point(728, 97)
        Me.Textaccno.Name = "Textaccno"
        Me.Textaccno.ReadOnly = True
        Me.Textaccno.Size = New System.Drawing.Size(237, 22)
        Me.Textaccno.TabIndex = 2
        '
        'Textename
        '
        Me.Textename.Location = New System.Drawing.Point(252, 139)
        Me.Textename.Name = "Textename"
        Me.Textename.Size = New System.Drawing.Size(276, 22)
        Me.Textename.TabIndex = 3
        '
        'Textcode
        '
        Me.Textcode.Location = New System.Drawing.Point(728, 139)
        Me.Textcode.Name = "Textcode"
        Me.Textcode.ReadOnly = True
        Me.Textcode.Size = New System.Drawing.Size(237, 22)
        Me.Textcode.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1006, 664)
        Me.PictureBox1.TabIndex = 150
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(817, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 23)
        Me.Label3.TabIndex = 161
        Me.Label3.Text = "*Fields are Compulsory"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Textnextmed
        '
        Me.Textnextmed.Location = New System.Drawing.Point(728, 222)
        Me.Textnextmed.Name = "Textnextmed"
        Me.Textnextmed.Size = New System.Drawing.Size(237, 22)
        Me.Textnextmed.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(596, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 23)
        Me.Label1.TabIndex = 190
        Me.Label1.Text = "*&Next Med : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = ""
        Me.DateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker2.Location = New System.Drawing.Point(728, 222)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(237, 22)
        Me.DateTimePicker2.TabIndex = 229
        Me.DateTimePicker2.Value = New Date(2013, 1, 1, 0, 0, 0, 0)
        '
        'EditEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 336)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Textnextmed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Textbadge)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextID)
        Me.Controls.Add(Me.Labelman)
        Me.Controls.Add(Me.Labelpname)
        Me.Controls.Add(Me.LabelClientId)
        Me.Controls.Add(Me.AccnoLabel)
        Me.Controls.Add(Me.CodeLabel)
        Me.Controls.Add(Me.Textdob)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.Textnat)
        Me.Controls.Add(Me.Textaccno)
        Me.Controls.Add(Me.Textename)
        Me.Controls.Add(Me.Textcode)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(1016, 381)
        Me.MinimumSize = New System.Drawing.Size(1016, 381)
        Me.Name = "EditEmp"
        Me.Text = "EditEmp"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Textbadge As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextID As System.Windows.Forms.TextBox
    Friend WithEvents Labelman As System.Windows.Forms.Label
    Friend WithEvents Labelpname As System.Windows.Forms.Label
    Friend WithEvents LabelClientId As System.Windows.Forms.Label
    Friend WithEvents AccnoLabel As System.Windows.Forms.Label
    Friend WithEvents CodeLabel As System.Windows.Forms.Label
    Friend WithEvents Textdob As System.Windows.Forms.TextBox
    Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    Friend WithEvents Textnat As System.Windows.Forms.TextBox
    Friend WithEvents Textaccno As System.Windows.Forms.TextBox
    Friend WithEvents Textename As System.Windows.Forms.TextBox
    Friend WithEvents Textcode As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Textnextmed As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
End Class
