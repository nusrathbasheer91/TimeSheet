<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddClient))
        Me.LabelTel = New System.Windows.Forms.Label()
        Me.LabelAdd = New System.Windows.Forms.Label()
        Me.LabelClientName = New System.Windows.Forms.Label()
        Me.ClientIDLabel = New System.Windows.Forms.Label()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.Textclientname = New System.Windows.Forms.TextBox()
        Me.Texttel = New System.Windows.Forms.TextBox()
        Me.Textadd = New System.Windows.Forms.TextBox()
        Me.Textclientid = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTel
        '
        Me.LabelTel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.LabelTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelTel.Location = New System.Drawing.Point(247, 295)
        Me.LabelTel.Name = "LabelTel"
        Me.LabelTel.Size = New System.Drawing.Size(220, 23)
        Me.LabelTel.TabIndex = 62
        Me.LabelTel.Text = "&Telephone Number : "
        Me.LabelTel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelAdd
        '
        Me.LabelAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.LabelAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelAdd.Location = New System.Drawing.Point(247, 246)
        Me.LabelAdd.Name = "LabelAdd"
        Me.LabelAdd.Size = New System.Drawing.Size(220, 23)
        Me.LabelAdd.TabIndex = 61
        Me.LabelAdd.Text = "&Address : "
        Me.LabelAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelClientName
        '
        Me.LabelClientName.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.LabelClientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClientName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelClientName.Location = New System.Drawing.Point(247, 197)
        Me.LabelClientName.Name = "LabelClientName"
        Me.LabelClientName.Size = New System.Drawing.Size(220, 23)
        Me.LabelClientName.TabIndex = 60
        Me.LabelClientName.Text = "*&Client Name : "
        Me.LabelClientName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ClientIDLabel
        '
        Me.ClientIDLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.ClientIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientIDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientIDLabel.Location = New System.Drawing.Point(247, 145)
        Me.ClientIDLabel.Name = "ClientIDLabel"
        Me.ClientIDLabel.Size = New System.Drawing.Size(220, 23)
        Me.ClientIDLabel.TabIndex = 58
        Me.ClientIDLabel.Text = "*&Client ID : "
        Me.ClientIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(824, 344)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(101, 38)
        Me.ButtonSave.TabIndex = 5
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'Textclientname
        '
        Me.Textclientname.Location = New System.Drawing.Point(476, 197)
        Me.Textclientname.Name = "Textclientname"
        Me.Textclientname.Size = New System.Drawing.Size(276, 22)
        Me.Textclientname.TabIndex = 2
        '
        'Texttel
        '
        Me.Texttel.Location = New System.Drawing.Point(476, 296)
        Me.Texttel.Name = "Texttel"
        Me.Texttel.Size = New System.Drawing.Size(276, 22)
        Me.Texttel.TabIndex = 4
        '
        'Textadd
        '
        Me.Textadd.Location = New System.Drawing.Point(476, 247)
        Me.Textadd.Name = "Textadd"
        Me.Textadd.Size = New System.Drawing.Size(276, 22)
        Me.Textadd.TabIndex = 3
        '
        'Textclientid
        '
        Me.Textclientid.Location = New System.Drawing.Point(476, 145)
        Me.Textclientid.Name = "Textclientid"
        Me.Textclientid.Size = New System.Drawing.Size(276, 22)
        Me.Textclientid.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1000, 664)
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(821, 401)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 23)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "*Fields are Compulsory"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AddClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 431)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelTel)
        Me.Controls.Add(Me.LabelAdd)
        Me.Controls.Add(Me.LabelClientName)
        Me.Controls.Add(Me.ClientIDLabel)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.Textclientname)
        Me.Controls.Add(Me.Texttel)
        Me.Controls.Add(Me.Textadd)
        Me.Controls.Add(Me.Textclientid)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(1018, 476)
        Me.MinimumSize = New System.Drawing.Size(1018, 476)
        Me.Name = "AddClient"
        Me.Text = "AddClient"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelTel As System.Windows.Forms.Label
    Friend WithEvents LabelAdd As System.Windows.Forms.Label
    Friend WithEvents LabelClientName As System.Windows.Forms.Label
    Friend WithEvents ClientIDLabel As System.Windows.Forms.Label
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents Textclientname As System.Windows.Forms.TextBox
    Friend WithEvents Texttel As System.Windows.Forms.TextBox
    Friend WithEvents Textadd As System.Windows.Forms.TextBox
    Friend WithEvents Textclientid As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
