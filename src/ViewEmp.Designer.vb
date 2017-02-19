<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewEmp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewEmp))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ListViewPC = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1246, 664)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(1105, 471)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(109, 41)
        Me.ButtonClose.TabIndex = 41
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ListViewPC
        '
        Me.ListViewPC.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader7, Me.ColumnHeader10, Me.ColumnHeader13, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader11, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader12})
        Me.ListViewPC.GridLines = True
        Me.ListViewPC.Location = New System.Drawing.Point(106, 108)
        Me.ListViewPC.Name = "ListViewPC"
        Me.ListViewPC.Size = New System.Drawing.Size(1108, 331)
        Me.ListViewPC.TabIndex = 42
        Me.ListViewPC.UseCompatibleStateImageBehavior = False
        Me.ListViewPC.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Badge No."
        Me.ColumnHeader2.Width = 86
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Accommodation No."
        Me.ColumnHeader3.Width = 141
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Profit Centre Code"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Employee Name"
        Me.ColumnHeader4.Width = 165
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Current ID"
        Me.ColumnHeader7.Width = 104
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Check IN Date"
        Me.ColumnHeader10.Width = 106
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Check OUT Date"
        Me.ColumnHeader13.Width = 120
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "TransferIN_Accno"
        Me.ColumnHeader8.Width = 122
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "TransferIN_Code"
        Me.ColumnHeader9.Width = 116
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "TransferOUT"
        Me.ColumnHeader11.Width = 112
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Date Of Birth"
        Me.ColumnHeader5.Width = 107
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Nationality"
        Me.ColumnHeader6.Width = 110
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Next Medical At"
        Me.ColumnHeader12.Width = 120
        '
        'ViewEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1242, 537)
        Me.Controls.Add(Me.ListViewPC)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(1260, 582)
        Me.MinimumSize = New System.Drawing.Size(1260, 582)
        Me.Name = "ViewEmp"
        Me.Text = "ViewEmp"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ListViewPC As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
End Class
