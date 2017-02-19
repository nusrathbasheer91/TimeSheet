<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewTransferDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewTransferDetails))
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonViewINPC = New System.Windows.Forms.Button()
        Me.ButtonViewINCamp = New System.Windows.Forms.Button()
        Me.ListViewTransfer = New System.Windows.Forms.ListView()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonViewOutPC = New System.Windows.Forms.Button()
        Me.ButtonViewOutCamp = New System.Windows.Forms.Button()
        Me.AccnoLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(111, 466)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(101, 38)
        Me.ButtonEdit.TabIndex = 5
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonViewINPC
        '
        Me.ButtonViewINPC.Location = New System.Drawing.Point(1046, 224)
        Me.ButtonViewINPC.Name = "ButtonViewINPC"
        Me.ButtonViewINPC.Size = New System.Drawing.Size(167, 38)
        Me.ButtonViewINPC.TabIndex = 2
        Me.ButtonViewINPC.Text = "View IN Profit Centre"
        Me.ButtonViewINPC.UseVisualStyleBackColor = True
        '
        'ButtonViewINCamp
        '
        Me.ButtonViewINCamp.Location = New System.Drawing.Point(1046, 167)
        Me.ButtonViewINCamp.Name = "ButtonViewINCamp"
        Me.ButtonViewINCamp.Size = New System.Drawing.Size(167, 38)
        Me.ButtonViewINCamp.TabIndex = 1
        Me.ButtonViewINCamp.Text = "View IN Camp"
        Me.ButtonViewINCamp.UseVisualStyleBackColor = True
        '
        'ListViewTransfer
        '
        Me.ListViewTransfer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader2, Me.ColumnHeader10, Me.ColumnHeader3, Me.ColumnHeader1, Me.ColumnHeader13, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.ListViewTransfer.GridLines = True
        Me.ListViewTransfer.Location = New System.Drawing.Point(111, 104)
        Me.ListViewTransfer.Name = "ListViewTransfer"
        Me.ListViewTransfer.Size = New System.Drawing.Size(899, 331)
        Me.ListViewTransfer.TabIndex = 38
        Me.ListViewTransfer.UseCompatibleStateImageBehavior = False
        Me.ListViewTransfer.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Order"
        Me.ColumnHeader12.Width = 64
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Badge No."
        Me.ColumnHeader2.Width = 86
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Check IN Date"
        Me.ColumnHeader10.Width = 99
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "IN AccNo."
        Me.ColumnHeader3.Width = 119
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "IN Profit Centre Code"
        Me.ColumnHeader1.Width = 138
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Check OUT Date"
        Me.ColumnHeader13.Width = 115
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "OUT AccNo."
        Me.ColumnHeader8.Width = 116
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "OUT Profit Centre Code"
        Me.ColumnHeader9.Width = 157
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1246, 664)
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'ButtonViewOutPC
        '
        Me.ButtonViewOutPC.Location = New System.Drawing.Point(1046, 377)
        Me.ButtonViewOutPC.Name = "ButtonViewOutPC"
        Me.ButtonViewOutPC.Size = New System.Drawing.Size(167, 38)
        Me.ButtonViewOutPC.TabIndex = 4
        Me.ButtonViewOutPC.Text = "View OUT Profit Centre"
        Me.ButtonViewOutPC.UseVisualStyleBackColor = True
        '
        'ButtonViewOutCamp
        '
        Me.ButtonViewOutCamp.Location = New System.Drawing.Point(1046, 320)
        Me.ButtonViewOutCamp.Name = "ButtonViewOutCamp"
        Me.ButtonViewOutCamp.Size = New System.Drawing.Size(167, 38)
        Me.ButtonViewOutCamp.TabIndex = 3
        Me.ButtonViewOutCamp.Text = "View OUT Camp"
        Me.ButtonViewOutCamp.UseVisualStyleBackColor = True
        '
        'AccnoLabel
        '
        Me.AccnoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.AccnoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccnoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AccnoLabel.Location = New System.Drawing.Point(1033, 126)
        Me.AccnoLabel.Name = "AccnoLabel"
        Me.AccnoLabel.Size = New System.Drawing.Size(180, 23)
        Me.AccnoLabel.TabIndex = 174
        Me.AccnoLabel.Text = "Transfer In Details"
        Me.AccnoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(1042, 281)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 23)
        Me.Label1.TabIndex = 175
        Me.Label1.Text = "Transfer Out Details"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(1099, 466)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(114, 38)
        Me.ButtonClose.TabIndex = 6
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(227, 466)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(108, 38)
        Me.ButtonDelete.TabIndex = 41
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ViewTransferDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 520)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AccnoLabel)
        Me.Controls.Add(Me.ButtonViewOutPC)
        Me.Controls.Add(Me.ButtonViewOutCamp)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonViewINPC)
        Me.Controls.Add(Me.ButtonViewINCamp)
        Me.Controls.Add(Me.ListViewTransfer)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(1261, 565)
        Me.MinimumSize = New System.Drawing.Size(1261, 565)
        Me.Name = "ViewTransferDetails"
        Me.Text = "ViewTransferDetails"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents ButtonViewINPC As System.Windows.Forms.Button
    Friend WithEvents ButtonViewINCamp As System.Windows.Forms.Button
    Friend WithEvents ListViewTransfer As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonViewOutPC As System.Windows.Forms.Button
    Friend WithEvents ButtonViewOutCamp As System.Windows.Forms.Button
    Friend WithEvents AccnoLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
End Class
