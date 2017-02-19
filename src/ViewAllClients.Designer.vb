<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewAllClients
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewAllClients))
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.ListViewClient = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonViewPC = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(865, 371)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(109, 41)
        Me.ButtonUpdate.TabIndex = 20
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(730, 371)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(108, 41)
        Me.ButtonDelete.TabIndex = 19
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonBack
        '
        Me.ButtonBack.Location = New System.Drawing.Point(101, 371)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(114, 41)
        Me.ButtonBack.TabIndex = 21
        Me.ButtonBack.Text = "Back"
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'ListViewClient
        '
        Me.ListViewClient.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListViewClient.GridLines = True
        Me.ListViewClient.Location = New System.Drawing.Point(151, 98)
        Me.ListViewClient.Name = "ListViewClient"
        Me.ListViewClient.Size = New System.Drawing.Size(786, 241)
        Me.ListViewClient.TabIndex = 17
        Me.ListViewClient.UseCompatibleStateImageBehavior = False
        Me.ListViewClient.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Client ID"
        Me.ColumnHeader2.Width = 122
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Client Name"
        Me.ColumnHeader1.Width = 173
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Address"
        Me.ColumnHeader4.Width = 349
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Telephone"
        Me.ColumnHeader5.Width = 135
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1000, 664)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(594, 371)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(108, 41)
        Me.ButtonAdd.TabIndex = 23
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonViewPC
        '
        Me.ButtonViewPC.Location = New System.Drawing.Point(341, 371)
        Me.ButtonViewPC.Name = "ButtonViewPC"
        Me.ButtonViewPC.Size = New System.Drawing.Size(238, 41)
        Me.ButtonViewPC.TabIndex = 24
        Me.ButtonViewPC.Text = "View Profit Centres of this Client"
        Me.ButtonViewPC.UseVisualStyleBackColor = True
        '
        'ViewAllClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 442)
        Me.Controls.Add(Me.ButtonViewPC)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.ListViewClient)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(1016, 487)
        Me.MinimumSize = New System.Drawing.Size(1016, 487)
        Me.Name = "ViewAllClients"
        Me.Text = "ViewAllClients"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonBack As System.Windows.Forms.Button
    Friend WithEvents ListViewClient As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonViewPC As System.Windows.Forms.Button
End Class
