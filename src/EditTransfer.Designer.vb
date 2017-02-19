<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditTransfer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditTransfer))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextInDate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Textinaccno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Textincode = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextOutDate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextOutAccno = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextOutCode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(277, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 23)
        Me.Label8.TabIndex = 200
        Me.Label8.Text = "*&CheckIN Date : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextInDate
        '
        Me.TextInDate.Location = New System.Drawing.Point(430, 215)
        Me.TextInDate.Name = "TextInDate"
        Me.TextInDate.Size = New System.Drawing.Size(266, 22)
        Me.TextInDate.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(417, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(276, 23)
        Me.Label5.TabIndex = 199
        Me.Label5.Text = "Date Format : yyyy-mm-dd"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(93, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(318, 23)
        Me.Label2.TabIndex = 198
        Me.Label2.Text = "*&Transfered from (Accommodation No.) : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Textinaccno
        '
        Me.Textinaccno.Location = New System.Drawing.Point(430, 143)
        Me.Textinaccno.Name = "Textinaccno"
        Me.Textinaccno.ReadOnly = True
        Me.Textinaccno.Size = New System.Drawing.Size(266, 22)
        Me.Textinaccno.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(121, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 23)
        Me.Label1.TabIndex = 197
        Me.Label1.Text = "*&Transfered from (Profit Centre) : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Textincode
        '
        Me.Textincode.Location = New System.Drawing.Point(430, 179)
        Me.Textincode.Name = "Textincode"
        Me.Textincode.ReadOnly = True
        Me.Textincode.Size = New System.Drawing.Size(266, 22)
        Me.Textincode.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1006, 664)
        Me.PictureBox1.TabIndex = 196
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(220, 347)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 23)
        Me.Label3.TabIndex = 207
        Me.Label3.Text = "*&CheckOUT Date : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextOutDate
        '
        Me.TextOutDate.Location = New System.Drawing.Point(430, 348)
        Me.TextOutDate.Name = "TextOutDate"
        Me.TextOutDate.Size = New System.Drawing.Size(266, 22)
        Me.TextOutDate.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(417, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(276, 23)
        Me.Label4.TabIndex = 206
        Me.Label4.Text = "Date Format : yyyy-mm-dd"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(101, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(310, 23)
        Me.Label6.TabIndex = 205
        Me.Label6.Text = "*&Transfered To (Accommodation No.) : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextOutAccno
        '
        Me.TextOutAccno.Location = New System.Drawing.Point(430, 276)
        Me.TextOutAccno.Name = "TextOutAccno"
        Me.TextOutAccno.ReadOnly = True
        Me.TextOutAccno.Size = New System.Drawing.Size(266, 22)
        Me.TextOutAccno.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(158, 311)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(253, 23)
        Me.Label7.TabIndex = 204
        Me.Label7.Text = "*&Transfered To (Profit Centre) : "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextOutCode
        '
        Me.TextOutCode.Location = New System.Drawing.Point(430, 312)
        Me.TextOutCode.Name = "TextOutCode"
        Me.TextOutCode.ReadOnly = True
        Me.TextOutCode.Size = New System.Drawing.Size(266, 22)
        Me.TextOutCode.TabIndex = 56
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(704, 410)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(276, 23)
        Me.Label9.TabIndex = 208
        Me.Label9.Text = "*All Fields Compulsory"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(794, 143)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(171, 58)
        Me.ButtonUpdate.TabIndex = 7
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(851, 366)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(114, 41)
        Me.ButtonClose.TabIndex = 8
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = ""
        Me.DateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker2.Location = New System.Drawing.Point(430, 348)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(266, 22)
        Me.DateTimePicker2.TabIndex = 229
        Me.DateTimePicker2.Value = New Date(2013, 1, 1, 0, 0, 0, 0)
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker1.Location = New System.Drawing.Point(430, 215)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(266, 22)
        Me.DateTimePicker1.TabIndex = 228
        Me.DateTimePicker1.Value = New Date(2013, 1, 1, 0, 0, 0, 0)
        '
        'EditTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 442)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextOutDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextOutAccno)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextOutCode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextInDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Textinaccno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Textincode)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(1015, 487)
        Me.MinimumSize = New System.Drawing.Size(1015, 487)
        Me.Name = "EditTransfer"
        Me.Text = "EditTransfer"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextInDate As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Textinaccno As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Textincode As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextOutDate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextOutAccno As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextOutCode As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
