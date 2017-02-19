<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransferDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransferDetails))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonView = New System.Windows.Forms.Button()
        Me.ButtonTransferEmp = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonTout = New System.Windows.Forms.Button()
        Me.ButtonTin = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1000, 664)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'ButtonView
        '
        Me.ButtonView.Location = New System.Drawing.Point(161, 271)
        Me.ButtonView.Name = "ButtonView"
        Me.ButtonView.Size = New System.Drawing.Size(219, 63)
        Me.ButtonView.TabIndex = 27
        Me.ButtonView.Text = "View Transfer Details"
        Me.ButtonView.UseVisualStyleBackColor = True
        '
        'ButtonTransferEmp
        '
        Me.ButtonTransferEmp.Location = New System.Drawing.Point(184, 140)
        Me.ButtonTransferEmp.Name = "ButtonTransferEmp"
        Me.ButtonTransferEmp.Size = New System.Drawing.Size(175, 63)
        Me.ButtonTransferEmp.TabIndex = 29
        Me.ButtonTransferEmp.Text = "Internal-Transfer"
        Me.ButtonTransferEmp.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(161, 116)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(219, 112)
        Me.Panel4.TabIndex = 38
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ButtonTout)
        Me.Panel1.Location = New System.Drawing.Point(436, 170)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(219, 112)
        Me.Panel1.TabIndex = 39
        '
        'ButtonTout
        '
        Me.ButtonTout.Location = New System.Drawing.Point(23, 24)
        Me.ButtonTout.Name = "ButtonTout"
        Me.ButtonTout.Size = New System.Drawing.Size(175, 63)
        Me.ButtonTout.TabIndex = 30
        Me.ButtonTout.Text = "Transfer OUT"
        Me.ButtonTout.UseVisualStyleBackColor = True
        '
        'ButtonTin
        '
        Me.ButtonTin.Location = New System.Drawing.Point(23, 24)
        Me.ButtonTin.Name = "ButtonTin"
        Me.ButtonTin.Size = New System.Drawing.Size(175, 63)
        Me.ButtonTin.TabIndex = 30
        Me.ButtonTin.Text = "Transfer IN"
        Me.ButtonTin.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel2.Controls.Add(Me.ButtonTin)
        Me.Panel2.Location = New System.Drawing.Point(714, 222)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(219, 112)
        Me.Panel2.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(98, 60)
        Me.Label3.MinimumSize = New System.Drawing.Size(100, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(363, 31)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Transfer Information"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TransferDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 376)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonView)
        Me.Controls.Add(Me.ButtonTransferEmp)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(1012, 421)
        Me.MinimumSize = New System.Drawing.Size(1012, 421)
        Me.Name = "TransferDetails"
        Me.Text = "TransferDetails"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonView As System.Windows.Forms.Button
    Friend WithEvents ButtonTransferEmp As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ButtonTout As System.Windows.Forms.Button
    Friend WithEvents ButtonTin As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
