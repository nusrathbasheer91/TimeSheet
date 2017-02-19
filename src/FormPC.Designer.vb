<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPC))
        Me.PCLabel = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.ButtonView = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBoxCode = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PCLabel
        '
        Me.PCLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.PCLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PCLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PCLabel.Location = New System.Drawing.Point(151, 166)
        Me.PCLabel.Name = "PCLabel"
        Me.PCLabel.Size = New System.Drawing.Size(220, 23)
        Me.PCLabel.TabIndex = 32
        Me.PCLabel.Text = "&Enter Profit Centre Code"
        Me.PCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(154, 192)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(220, 22)
        Me.txtCode.TabIndex = 543
        '
        'ButtonView
        '
        Me.ButtonView.Location = New System.Drawing.Point(218, 236)
        Me.ButtonView.Name = "ButtonView"
        Me.ButtonView.Size = New System.Drawing.Size(98, 43)
        Me.ButtonView.TabIndex = 2
        Me.ButtonView.Text = "View"
        Me.ButtonView.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(475, 484)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'ComboBoxCode
        '
        Me.ComboBoxCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxCode.FormattingEnabled = True
        Me.ComboBoxCode.Location = New System.Drawing.Point(154, 190)
        Me.ComboBoxCode.Name = "ComboBoxCode"
        Me.ComboBoxCode.Size = New System.Drawing.Size(220, 24)
        Me.ComboBoxCode.TabIndex = 1
        '
        'FormPC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 393)
        Me.Controls.Add(Me.ComboBoxCode)
        Me.Controls.Add(Me.PCLabel)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.ButtonView)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(483, 438)
        Me.MinimumSize = New System.Drawing.Size(483, 438)
        Me.Name = "FormPC"
        Me.Text = "FormPC"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PCLabel As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents ButtonView As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBoxCode As System.Windows.Forms.ComboBox
End Class
