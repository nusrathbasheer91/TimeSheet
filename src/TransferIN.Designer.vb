<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransferIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransferIN))
        Me.PCLabel = New System.Windows.Forms.Label()
        Me.TextDateIn = New System.Windows.Forms.TextBox()
        Me.ButtonTin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PCLabel
        '
        Me.PCLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.PCLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PCLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PCLabel.Location = New System.Drawing.Point(142, 143)
        Me.PCLabel.Name = "PCLabel"
        Me.PCLabel.Size = New System.Drawing.Size(220, 23)
        Me.PCLabel.TabIndex = 40
        Me.PCLabel.Text = "&Enter Date "
        Me.PCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextDateIn
        '
        Me.TextDateIn.Location = New System.Drawing.Point(164, 169)
        Me.TextDateIn.Name = "TextDateIn"
        Me.TextDateIn.Size = New System.Drawing.Size(220, 22)
        Me.TextDateIn.TabIndex = 1
        '
        'ButtonTin
        '
        Me.ButtonTin.Location = New System.Drawing.Point(228, 213)
        Me.ButtonTin.Name = "ButtonTin"
        Me.ButtonTin.Size = New System.Drawing.Size(98, 43)
        Me.ButtonTin.TabIndex = 2
        Me.ButtonTin.Text = "Transfer IN"
        Me.ButtonTin.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(475, 484)
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(181, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(276, 23)
        Me.Label5.TabIndex = 211
        Me.Label5.Text = "Date Format : yyyy-mm-dd"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker1.Location = New System.Drawing.Point(146, 169)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(268, 22)
        Me.DateTimePicker1.TabIndex = 231
        Me.DateTimePicker1.Value = Today
        '
        'TransferIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 343)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PCLabel)
        Me.Controls.Add(Me.TextDateIn)
        Me.Controls.Add(Me.ButtonTin)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(487, 388)
        Me.MinimumSize = New System.Drawing.Size(487, 388)
        Me.Name = "TransferIN"
        Me.Text = "TransferIN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PCLabel As System.Windows.Forms.Label
    Friend WithEvents TextDateIn As System.Windows.Forms.TextBox
    Friend WithEvents ButtonTin As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
