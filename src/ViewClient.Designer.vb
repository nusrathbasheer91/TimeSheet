<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewClient))
        Me.Textclientname = New System.Windows.Forms.TextBox()
        Me.Texttel = New System.Windows.Forms.TextBox()
        Me.Textadd = New System.Windows.Forms.TextBox()
        Me.Textclientid = New System.Windows.Forms.TextBox()
        Me.ButtonViewPC = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.LabelClientName = New System.Windows.Forms.Label()
        Me.ClientIDLabel = New System.Windows.Forms.Label()
        Me.LabelTel = New System.Windows.Forms.Label()
        Me.LabelAdd = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Textclientname
        '
        Me.Textclientname.Location = New System.Drawing.Point(479, 195)
        Me.Textclientname.Name = "Textclientname"
        Me.Textclientname.ReadOnly = True
        Me.Textclientname.Size = New System.Drawing.Size(276, 22)
        Me.Textclientname.TabIndex = 3
        '
        'Texttel
        '
        Me.Texttel.Location = New System.Drawing.Point(479, 294)
        Me.Texttel.Name = "Texttel"
        Me.Texttel.ReadOnly = True
        Me.Texttel.Size = New System.Drawing.Size(276, 22)
        Me.Texttel.TabIndex = 5
        '
        'Textadd
        '
        Me.Textadd.Location = New System.Drawing.Point(479, 245)
        Me.Textadd.Name = "Textadd"
        Me.Textadd.ReadOnly = True
        Me.Textadd.Size = New System.Drawing.Size(276, 22)
        Me.Textadd.TabIndex = 4
        '
        'Textclientid
        '
        Me.Textclientid.Location = New System.Drawing.Point(479, 146)
        Me.Textclientid.Name = "Textclientid"
        Me.Textclientid.ReadOnly = True
        Me.Textclientid.Size = New System.Drawing.Size(276, 22)
        Me.Textclientid.TabIndex = 1
        '
        'ButtonViewPC
        '
        Me.ButtonViewPC.Location = New System.Drawing.Point(737, 359)
        Me.ButtonViewPC.Name = "ButtonViewPC"
        Me.ButtonViewPC.Size = New System.Drawing.Size(238, 38)
        Me.ButtonViewPC.TabIndex = 8
        Me.ButtonViewPC.Text = "View Profit Centres of this Client"
        Me.ButtonViewPC.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(138, 359)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(101, 38)
        Me.ButtonEdit.TabIndex = 6
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(254, 359)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(108, 38)
        Me.ButtonDelete.TabIndex = 7
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'LabelClientName
        '
        Me.LabelClientName.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.LabelClientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClientName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelClientName.Location = New System.Drawing.Point(250, 195)
        Me.LabelClientName.Name = "LabelClientName"
        Me.LabelClientName.Size = New System.Drawing.Size(220, 23)
        Me.LabelClientName.TabIndex = 35
        Me.LabelClientName.Text = "&Client Name : "
        Me.LabelClientName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ClientIDLabel
        '
        Me.ClientIDLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.ClientIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientIDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientIDLabel.Location = New System.Drawing.Point(250, 146)
        Me.ClientIDLabel.Name = "ClientIDLabel"
        Me.ClientIDLabel.Size = New System.Drawing.Size(220, 23)
        Me.ClientIDLabel.TabIndex = 33
        Me.ClientIDLabel.Text = "&Client ID : "
        Me.ClientIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelTel
        '
        Me.LabelTel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.LabelTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelTel.Location = New System.Drawing.Point(250, 293)
        Me.LabelTel.Name = "LabelTel"
        Me.LabelTel.Size = New System.Drawing.Size(220, 23)
        Me.LabelTel.TabIndex = 38
        Me.LabelTel.Text = "&Telephone Number : "
        Me.LabelTel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelAdd
        '
        Me.LabelAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.LabelAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelAdd.Location = New System.Drawing.Point(250, 244)
        Me.LabelAdd.Name = "LabelAdd"
        Me.LabelAdd.Size = New System.Drawing.Size(220, 23)
        Me.LabelAdd.TabIndex = 37
        Me.LabelAdd.Text = "&Address : "
        Me.LabelAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1000, 664)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'ViewClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 427)
        Me.Controls.Add(Me.LabelTel)
        Me.Controls.Add(Me.LabelAdd)
        Me.Controls.Add(Me.LabelClientName)
        Me.Controls.Add(Me.ClientIDLabel)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonViewPC)
        Me.Controls.Add(Me.Textclientname)
        Me.Controls.Add(Me.Texttel)
        Me.Controls.Add(Me.Textadd)
        Me.Controls.Add(Me.Textclientid)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(1017, 472)
        Me.MinimumSize = New System.Drawing.Size(1017, 472)
        Me.Name = "ViewClient"
        Me.Text = "ViewClient"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Textclientname As System.Windows.Forms.TextBox
    Friend WithEvents Texttel As System.Windows.Forms.TextBox
    Friend WithEvents Textadd As System.Windows.Forms.TextBox
    Friend WithEvents Textclientid As System.Windows.Forms.TextBox
    Friend WithEvents ButtonViewPC As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents LabelClientName As System.Windows.Forms.Label
    Friend WithEvents ClientIDLabel As System.Windows.Forms.Label
    Friend WithEvents LabelTel As System.Windows.Forms.Label
    Friend WithEvents LabelAdd As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
