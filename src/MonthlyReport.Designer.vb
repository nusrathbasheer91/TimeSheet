<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonthlyReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MonthlyReport))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Labelman = New System.Windows.Forms.Label()
        Me.LabelClientId = New System.Windows.Forms.Label()
        Me.CodeLabel = New System.Windows.Forms.Label()
        Me.TextDateEnd = New System.Windows.Forms.TextBox()
        Me.TextDateStart = New System.Windows.Forms.TextBox()
        Me.Textaccno = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonChPwdAd = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ComboBoxAccNo = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(114, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(276, 23)
        Me.Label5.TabIndex = 167
        Me.Label5.Text = "Date Format : yyyy-mm-dd"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Labelman
        '
        Me.Labelman.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Labelman.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelman.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Labelman.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Labelman.Location = New System.Drawing.Point(150, 199)
        Me.Labelman.Name = "Labelman"
        Me.Labelman.Size = New System.Drawing.Size(166, 23)
        Me.Labelman.TabIndex = 166
        Me.Labelman.Text = "&Enter Starting Date : "
        Me.Labelman.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelClientId
        '
        Me.LabelClientId.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.LabelClientId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClientId.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelClientId.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabelClientId.Location = New System.Drawing.Point(150, 261)
        Me.LabelClientId.Name = "LabelClientId"
        Me.LabelClientId.Size = New System.Drawing.Size(167, 23)
        Me.LabelClientId.TabIndex = 165
        Me.LabelClientId.Text = "&Enter Ending Date : "
        Me.LabelClientId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CodeLabel
        '
        Me.CodeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.CodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CodeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CodeLabel.Location = New System.Drawing.Point(149, 140)
        Me.CodeLabel.Name = "CodeLabel"
        Me.CodeLabel.Size = New System.Drawing.Size(197, 23)
        Me.CodeLabel.TabIndex = 164
        Me.CodeLabel.Text = "&Accommodation No. : "
        Me.CodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextDateEnd
        '
        Me.TextDateEnd.Location = New System.Drawing.Point(153, 287)
        Me.TextDateEnd.Name = "TextDateEnd"
        Me.TextDateEnd.Size = New System.Drawing.Size(237, 22)
        Me.TextDateEnd.TabIndex = 3
        '
        'TextDateStart
        '
        Me.TextDateStart.Location = New System.Drawing.Point(153, 225)
        Me.TextDateStart.Name = "TextDateStart"
        Me.TextDateStart.Size = New System.Drawing.Size(237, 22)
        Me.TextDateStart.TabIndex = 2
        '
        'Textaccno
        '
        Me.Textaccno.Location = New System.Drawing.Point(153, 166)
        Me.Textaccno.Name = "Textaccno"
        Me.Textaccno.Size = New System.Drawing.Size(237, 22)
        Me.Textaccno.TabIndex = 187
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(468, 478)
        Me.PictureBox1.TabIndex = 168
        Me.PictureBox1.TabStop = False
        '
        'ButtonChPwdAd
        '
        Me.ButtonChPwdAd.Location = New System.Drawing.Point(217, 356)
        Me.ButtonChPwdAd.Name = "ButtonChPwdAd"
        Me.ButtonChPwdAd.Size = New System.Drawing.Size(173, 52)
        Me.ButtonChPwdAd.TabIndex = 4
        Me.ButtonChPwdAd.Text = "Generate Report"
        Me.ButtonChPwdAd.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Excel Files(*.xls)|*.xls|All Files|*.*"
        '
        'ComboBoxAccNo
        '
        Me.ComboBoxAccNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxAccNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxAccNo.FormattingEnabled = True
        Me.ComboBoxAccNo.Location = New System.Drawing.Point(153, 164)
        Me.ComboBoxAccNo.Name = "ComboBoxAccNo"
        Me.ComboBoxAccNo.Size = New System.Drawing.Size(237, 24)
        Me.ComboBoxAccNo.TabIndex = 1
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = ""
        Me.DateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker2.Location = New System.Drawing.Point(153, 287)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(237, 22)
        Me.DateTimePicker2.TabIndex = 229
        Me.DateTimePicker2.Value = Today
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker1.Location = New System.Drawing.Point(153, 225)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(237, 22)
        Me.DateTimePicker1.TabIndex = 228
        Me.DateTimePicker1.Value = Today
        '
        'MonthlyReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 468)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBoxAccNo)
        Me.Controls.Add(Me.ButtonChPwdAd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Labelman)
        Me.Controls.Add(Me.LabelClientId)
        Me.Controls.Add(Me.CodeLabel)
        Me.Controls.Add(Me.TextDateEnd)
        Me.Controls.Add(Me.TextDateStart)
        Me.Controls.Add(Me.Textaccno)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MonthlyReport"
        Me.Text = "MonthlyReport"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Labelman As System.Windows.Forms.Label
    Friend WithEvents LabelClientId As System.Windows.Forms.Label
    Friend WithEvents CodeLabel As System.Windows.Forms.Label
    Friend WithEvents TextDateEnd As System.Windows.Forms.TextBox
    Friend WithEvents TextDateStart As System.Windows.Forms.TextBox
    Friend WithEvents Textaccno As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonChPwdAd As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ComboBoxAccNo As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
