<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AbsentRange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AbsentRange))
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.PCLabel = New System.Windows.Forms.Label()
        Me.textBadge = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextDateEnd = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextDateStart = New System.Windows.Forms.TextBox()
        Me.ButtonAbsent = New System.Windows.Forms.Button()
        Me.ComboBoxEmpBadge = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(367, 411)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(91, 43)
        Me.ButtonClose.TabIndex = 5
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'PCLabel
        '
        Me.PCLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.PCLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PCLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PCLabel.Location = New System.Drawing.Point(125, 138)
        Me.PCLabel.Name = "PCLabel"
        Me.PCLabel.Size = New System.Drawing.Size(291, 23)
        Me.PCLabel.TabIndex = 45
        Me.PCLabel.Text = "&Enter Employee Badge No"
        Me.PCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'textBadge
        '
        Me.textBadge.Location = New System.Drawing.Point(128, 164)
        Me.textBadge.Name = "textBadge"
        Me.textBadge.Size = New System.Drawing.Size(288, 22)
        Me.textBadge.TabIndex = 225
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(475, 484)
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(140, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(276, 23)
        Me.Label5.TabIndex = 217
        Me.Label5.Text = "Date Format : yyyy-mm-dd"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(124, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 23)
        Me.Label1.TabIndex = 216
        Me.Label1.Text = "&End of Absence Date : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextDateEnd
        '
        Me.TextDateEnd.Location = New System.Drawing.Point(128, 266)
        Me.TextDateEnd.Name = "TextDateEnd"
        Me.TextDateEnd.Size = New System.Drawing.Size(288, 22)
        Me.TextDateEnd.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(124, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(292, 23)
        Me.Label8.TabIndex = 214
        Me.Label8.Text = "&Start of Absense Date : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextDateStart
        '
        Me.TextDateStart.Location = New System.Drawing.Point(128, 215)
        Me.TextDateStart.Name = "TextDateStart"
        Me.TextDateStart.Size = New System.Drawing.Size(288, 22)
        Me.TextDateStart.TabIndex = 2
        '
        'ButtonAbsent
        '
        Me.ButtonAbsent.Location = New System.Drawing.Point(128, 317)
        Me.ButtonAbsent.Name = "ButtonAbsent"
        Me.ButtonAbsent.Size = New System.Drawing.Size(288, 38)
        Me.ButtonAbsent.TabIndex = 4
        Me.ButtonAbsent.Text = "Absent on Given Range of Dates"
        Me.ButtonAbsent.UseVisualStyleBackColor = True
        '
        'ComboBoxEmpBadge
        '
        Me.ComboBoxEmpBadge.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxEmpBadge.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxEmpBadge.FormattingEnabled = True
        Me.ComboBoxEmpBadge.Location = New System.Drawing.Point(128, 164)
        Me.ComboBoxEmpBadge.Name = "ComboBoxEmpBadge"
        Me.ComboBoxEmpBadge.Size = New System.Drawing.Size(288, 24)
        Me.ComboBoxEmpBadge.TabIndex = 1
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = ""
        Me.DateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker2.Location = New System.Drawing.Point(128, 266)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(288, 22)
        Me.DateTimePicker2.TabIndex = 231
        Me.DateTimePicker2.Value = Today
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker1.Location = New System.Drawing.Point(128, 215)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(288, 22)
        Me.DateTimePicker1.TabIndex = 230
        Me.DateTimePicker1.Value = Today
        '
        'AbsentRange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 466)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBoxEmpBadge)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextDateEnd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextDateStart)
        Me.Controls.Add(Me.ButtonAbsent)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.PCLabel)
        Me.Controls.Add(Me.textBadge)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(486, 511)
        Me.MinimumSize = New System.Drawing.Size(486, 511)
        Me.Name = "AbsentRange"
        Me.Text = "AbsentRange"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents PCLabel As System.Windows.Forms.Label
    Friend WithEvents textBadge As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextDateEnd As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextDateStart As System.Windows.Forms.TextBox
    Friend WithEvents ButtonAbsent As System.Windows.Forms.Button
    Friend WithEvents ComboBoxEmpBadge As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
