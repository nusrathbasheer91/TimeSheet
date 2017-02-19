<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransferEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransferEmployee))
        Me.ComboBoxCode = New System.Windows.Forms.ComboBox()
        Me.ComboBoxAccNo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextOutDate = New System.Windows.Forms.TextBox()
        Me.Textoutacc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Textoutcode = New System.Windows.Forms.TextBox()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonTransfer = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBoxEmpBadge = New System.Windows.Forms.ComboBox()
        Me.PCLabel = New System.Windows.Forms.Label()
        Me.txtBadge = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxCode
        '
        Me.ComboBoxCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxCode.FormattingEnabled = True
        Me.ComboBoxCode.Location = New System.Drawing.Point(130, 261)
        Me.ComboBoxCode.Name = "ComboBoxCode"
        Me.ComboBoxCode.Size = New System.Drawing.Size(288, 24)
        Me.ComboBoxCode.TabIndex = 3
        '
        'ComboBoxAccNo
        '
        Me.ComboBoxAccNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxAccNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxAccNo.FormattingEnabled = True
        Me.ComboBoxAccNo.Location = New System.Drawing.Point(130, 197)
        Me.ComboBoxAccNo.Name = "ComboBoxAccNo"
        Me.ComboBoxAccNo.Size = New System.Drawing.Size(288, 24)
        Me.ComboBoxAccNo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(250, 441)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 20)
        Me.Label2.TabIndex = 235
        Me.Label2.Text = "*All Fields are Compulsory"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(142, 356)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(276, 23)
        Me.Label5.TabIndex = 234
        Me.Label5.Text = "Date Format : yyyy-mm-dd"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(126, 305)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 23)
        Me.Label1.TabIndex = 233
        Me.Label1.Text = "&Transfer Out Date : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextOutDate
        '
        Me.TextOutDate.Location = New System.Drawing.Point(130, 331)
        Me.TextOutDate.Name = "TextOutDate"
        Me.TextOutDate.Size = New System.Drawing.Size(288, 22)
        Me.TextOutDate.TabIndex = 4
        '
        'Textoutacc
        '
        Me.Textoutacc.Location = New System.Drawing.Point(130, 197)
        Me.Textoutacc.Name = "Textoutacc"
        Me.Textoutacc.Size = New System.Drawing.Size(288, 22)
        Me.Textoutacc.TabIndex = 225
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(126, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(292, 23)
        Me.Label7.TabIndex = 231
        Me.Label7.Text = "&Transfer To (Accommodation No.) :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(126, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(292, 23)
        Me.Label8.TabIndex = 230
        Me.Label8.Text = "&Transfer To (Profit Centre) : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Textoutcode
        '
        Me.Textoutcode.Location = New System.Drawing.Point(130, 263)
        Me.Textoutcode.Name = "Textoutcode"
        Me.Textoutcode.Size = New System.Drawing.Size(288, 22)
        Me.Textoutcode.TabIndex = 226
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(293, 391)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(115, 38)
        Me.ButtonClose.TabIndex = 6
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonTransfer
        '
        Me.ButtonTransfer.Location = New System.Drawing.Point(132, 391)
        Me.ButtonTransfer.Name = "ButtonTransfer"
        Me.ButtonTransfer.Size = New System.Drawing.Size(115, 38)
        Me.ButtonTransfer.TabIndex = 5
        Me.ButtonTransfer.Text = "Transfer"
        Me.ButtonTransfer.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(475, 484)
        Me.PictureBox1.TabIndex = 232
        Me.PictureBox1.TabStop = False
        '
        'ComboBoxEmpBadge
        '
        Me.ComboBoxEmpBadge.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxEmpBadge.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxEmpBadge.FormattingEnabled = True
        Me.ComboBoxEmpBadge.Location = New System.Drawing.Point(133, 135)
        Me.ComboBoxEmpBadge.Name = "ComboBoxEmpBadge"
        Me.ComboBoxEmpBadge.Size = New System.Drawing.Size(288, 24)
        Me.ComboBoxEmpBadge.TabIndex = 1
        '
        'PCLabel
        '
        Me.PCLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.PCLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PCLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PCLabel.Location = New System.Drawing.Point(128, 111)
        Me.PCLabel.Name = "PCLabel"
        Me.PCLabel.Size = New System.Drawing.Size(220, 23)
        Me.PCLabel.TabIndex = 240
        Me.PCLabel.Text = "&Enter Employee Badge No"
        Me.PCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBadge
        '
        Me.txtBadge.Location = New System.Drawing.Point(133, 137)
        Me.txtBadge.Name = "txtBadge"
        Me.txtBadge.Size = New System.Drawing.Size(220, 22)
        Me.txtBadge.TabIndex = 238
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker1.Location = New System.Drawing.Point(130, 331)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(288, 22)
        Me.DateTimePicker1.TabIndex = 241
        Me.DateTimePicker1.Value = New Date(2014, 4, 5, 0, 0, 0, 0)
        '
        'TransferEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 480)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBoxEmpBadge)
        Me.Controls.Add(Me.PCLabel)
        Me.Controls.Add(Me.txtBadge)
        Me.Controls.Add(Me.ComboBoxCode)
        Me.Controls.Add(Me.ComboBoxAccNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextOutDate)
        Me.Controls.Add(Me.Textoutacc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Textoutcode)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonTransfer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "TransferEmployee"
        Me.Text = "TransferEmployee"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxCode As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxAccNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextOutDate As System.Windows.Forms.TextBox
    Friend WithEvents Textoutacc As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Textoutcode As System.Windows.Forms.TextBox
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ButtonTransfer As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBoxEmpBadge As System.Windows.Forms.ComboBox
    Friend WithEvents PCLabel As System.Windows.Forms.Label
    Friend WithEvents txtBadge As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
