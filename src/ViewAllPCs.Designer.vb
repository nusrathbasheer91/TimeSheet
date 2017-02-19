<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewAllPCs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewAllPCs))
        Me.ListViewPC = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonViewEmp = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonViewClient = New System.Windows.Forms.Button()
        Me.ButtonViewCamp = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListViewPC
        '
        Me.ListViewPC.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListViewPC.GridLines = True
        Me.ListViewPC.Location = New System.Drawing.Point(107, 111)
        Me.ListViewPC.Name = "ListViewPC"
        Me.ListViewPC.Size = New System.Drawing.Size(1108, 281)
        Me.ListViewPC.TabIndex = 23
        Me.ListViewPC.UseCompatibleStateImageBehavior = False
        Me.ListViewPC.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Code"
        Me.ColumnHeader2.Width = 78
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Accommodation No."
        Me.ColumnHeader3.Width = 143
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Client ID"
        Me.ColumnHeader1.Width = 93
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Name"
        Me.ColumnHeader4.Width = 176
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ManDay Cost"
        Me.ColumnHeader5.Width = 102
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Breakfast Cost"
        Me.ColumnHeader6.Width = 110
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Lunch Cost"
        Me.ColumnHeader7.Width = 86
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Dinner Cost"
        Me.ColumnHeader8.Width = 87
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "HouseKeeping Cost"
        Me.ColumnHeader9.Width = 135
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Laundry Cost"
        Me.ColumnHeader10.Width = 92
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1246, 664)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'ButtonViewEmp
        '
        Me.ButtonViewEmp.Location = New System.Drawing.Point(711, 459)
        Me.ButtonViewEmp.Name = "ButtonViewEmp"
        Me.ButtonViewEmp.Size = New System.Drawing.Size(215, 38)
        Me.ButtonViewEmp.TabIndex = 27
        Me.ButtonViewEmp.Text = "View Employees in this Centre"
        Me.ButtonViewEmp.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(223, 459)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(108, 38)
        Me.ButtonDelete.TabIndex = 26
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(107, 459)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(101, 38)
        Me.ButtonEdit.TabIndex = 25
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonViewClient
        '
        Me.ButtonViewClient.Location = New System.Drawing.Point(955, 459)
        Me.ButtonViewClient.Name = "ButtonViewClient"
        Me.ButtonViewClient.Size = New System.Drawing.Size(122, 38)
        Me.ButtonViewClient.TabIndex = 28
        Me.ButtonViewClient.Text = "View Client"
        Me.ButtonViewClient.UseVisualStyleBackColor = True
        '
        'ButtonViewCamp
        '
        Me.ButtonViewCamp.Location = New System.Drawing.Point(1100, 459)
        Me.ButtonViewCamp.Name = "ButtonViewCamp"
        Me.ButtonViewCamp.Size = New System.Drawing.Size(115, 38)
        Me.ButtonViewCamp.TabIndex = 29
        Me.ButtonViewCamp.Text = "View Camp"
        Me.ButtonViewCamp.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(346, 459)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(108, 38)
        Me.ButtonAdd.TabIndex = 30
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ViewAllPCs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1247, 523)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ButtonViewEmp)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonViewClient)
        Me.Controls.Add(Me.ButtonViewCamp)
        Me.Controls.Add(Me.ListViewPC)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(1265, 568)
        Me.MinimumSize = New System.Drawing.Size(1265, 568)
        Me.Name = "ViewAllPCs"
        Me.Text = "ViewAllPCs"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListViewPC As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonViewEmp As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents ButtonViewClient As System.Windows.Forms.Button
    Friend WithEvents ButtonViewCamp As System.Windows.Forms.Button
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
End Class
