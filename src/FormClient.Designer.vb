<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormClient))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonView = New System.Windows.Forms.Button()
        Me.ClientidLabel = New System.Windows.Forms.Label()
        Me.txtClientid = New System.Windows.Forms.TextBox()
        Me.ComboBoxClientID = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(475, 484)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'ButtonView
        '
        Me.ButtonView.Location = New System.Drawing.Point(218, 237)
        Me.ButtonView.Name = "ButtonView"
        Me.ButtonView.Size = New System.Drawing.Size(98, 43)
        Me.ButtonView.TabIndex = 2
        Me.ButtonView.Text = "View"
        Me.ButtonView.UseVisualStyleBackColor = True
        '
        'ClientidLabel
        '
        Me.ClientidLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.ClientidLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientidLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientidLabel.Location = New System.Drawing.Point(151, 167)
        Me.ClientidLabel.Name = "ClientidLabel"
        Me.ClientidLabel.Size = New System.Drawing.Size(220, 23)
        Me.ClientidLabel.TabIndex = 28
        Me.ClientidLabel.Text = "&Enter Client ID"
        Me.ClientidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtClientid
        '
        Me.txtClientid.Location = New System.Drawing.Point(154, 193)
        Me.txtClientid.Name = "txtClientid"
        Me.txtClientid.Size = New System.Drawing.Size(220, 22)
        Me.txtClientid.TabIndex = 55
        '
        'ComboBoxClientID
        '
        Me.ComboBoxClientID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxClientID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxClientID.FormattingEnabled = True
        Me.ComboBoxClientID.Location = New System.Drawing.Point(155, 191)
        Me.ComboBoxClientID.Name = "ComboBoxClientID"
        Me.ComboBoxClientID.Size = New System.Drawing.Size(220, 24)
        Me.ComboBoxClientID.TabIndex = 1
        '
        'FormClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 387)
        Me.Controls.Add(Me.ComboBoxClientID)
        Me.Controls.Add(Me.ClientidLabel)
        Me.Controls.Add(Me.txtClientid)
        Me.Controls.Add(Me.ButtonView)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(486, 432)
        Me.MinimumSize = New System.Drawing.Size(486, 432)
        Me.Name = "FormClient"
        Me.Text = "FormClient"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonView As System.Windows.Forms.Button
    Friend WithEvents ClientidLabel As System.Windows.Forms.Label
    Friend WithEvents txtClientid As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxClientID As System.Windows.Forms.ComboBox
End Class
