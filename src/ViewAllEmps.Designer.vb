<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewAllEmps
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewAllEmps))
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonTrans = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonViewPC = New System.Windows.Forms.Button()
        Me.ButtonViewCamp = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.AccnoLabel = New System.Windows.Forms.Label()
        Me.badge_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmaccno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmpcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmename = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmin_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmout_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmin_accno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmin_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmtr_out = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmdob = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmnationality = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmnext_med = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LateMedical = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(351, 467)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(108, 38)
        Me.ButtonAdd.TabIndex = 5
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonTrans
        '
        Me.ButtonTrans.Location = New System.Drawing.Point(586, 467)
        Me.ButtonTrans.Name = "ButtonTrans"
        Me.ButtonTrans.Size = New System.Drawing.Size(215, 38)
        Me.ButtonTrans.TabIndex = 6
        Me.ButtonTrans.Text = "View Transfer Details"
        Me.ButtonTrans.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(228, 467)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(108, 38)
        Me.ButtonDelete.TabIndex = 4
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(112, 467)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(101, 38)
        Me.ButtonEdit.TabIndex = 3
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonViewPC
        '
        Me.ButtonViewPC.Location = New System.Drawing.Point(928, 467)
        Me.ButtonViewPC.Name = "ButtonViewPC"
        Me.ButtonViewPC.Size = New System.Drawing.Size(154, 38)
        Me.ButtonViewPC.TabIndex = 7
        Me.ButtonViewPC.Text = "View Profit Centre"
        Me.ButtonViewPC.UseVisualStyleBackColor = True
        '
        'ButtonViewCamp
        '
        Me.ButtonViewCamp.Location = New System.Drawing.Point(1105, 467)
        Me.ButtonViewCamp.Name = "ButtonViewCamp"
        Me.ButtonViewCamp.Size = New System.Drawing.Size(115, 38)
        Me.ButtonViewCamp.TabIndex = 8
        Me.ButtonViewCamp.Text = "View Camp"
        Me.ButtonViewCamp.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1246, 664)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.badge_no, Me.clmaccno, Me.clmpcode, Me.clmename, Me.clmid, Me.clmin_date, Me.clmout_date, Me.clmin_accno, Me.clmin_code, Me.clmtr_out, Me.clmdob, Me.clmnationality, Me.clmnext_med, Me.LateMedical})
        Me.DataGridView1.Location = New System.Drawing.Point(112, 105)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1108, 331)
        Me.DataGridView1.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(261, 63)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(272, 22)
        Me.TextBox1.TabIndex = 1
        '
        'AccnoLabel
        '
        Me.AccnoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.AccnoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccnoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AccnoLabel.Location = New System.Drawing.Point(108, 62)
        Me.AccnoLabel.Name = "AccnoLabel"
        Me.AccnoLabel.Size = New System.Drawing.Size(147, 23)
        Me.AccnoLabel.TabIndex = 174
        Me.AccnoLabel.Text = "&Enter Filter Text : "
        Me.AccnoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'badge_no
        '
        Me.badge_no.DataPropertyName = "badge_no"
        Me.badge_no.Frozen = True
        Me.badge_no.HeaderText = "Badge No."
        Me.badge_no.Name = "badge_no"
        Me.badge_no.ReadOnly = True
        Me.badge_no.Width = 86
        '
        'clmaccno
        '
        Me.clmaccno.DataPropertyName = "accno"
        Me.clmaccno.HeaderText = "Accommodation No."
        Me.clmaccno.Name = "clmaccno"
        Me.clmaccno.ReadOnly = True
        Me.clmaccno.Width = 141
        '
        'clmpcode
        '
        Me.clmpcode.DataPropertyName = "code"
        Me.clmpcode.HeaderText = "Profit Centre Code"
        Me.clmpcode.Name = "clmpcode"
        Me.clmpcode.ReadOnly = True
        Me.clmpcode.Width = 120
        '
        'clmename
        '
        Me.clmename.DataPropertyName = "ename"
        Me.clmename.HeaderText = "Employee Name"
        Me.clmename.Name = "clmename"
        Me.clmename.ReadOnly = True
        Me.clmename.Width = 165
        '
        'clmid
        '
        Me.clmid.DataPropertyName = "id"
        Me.clmid.HeaderText = "Current ID"
        Me.clmid.Name = "clmid"
        Me.clmid.ReadOnly = True
        Me.clmid.Width = 104
        '
        'clmin_date
        '
        Me.clmin_date.DataPropertyName = "in_date"
        Me.clmin_date.HeaderText = "Check IN Date"
        Me.clmin_date.Name = "clmin_date"
        Me.clmin_date.ReadOnly = True
        Me.clmin_date.Width = 106
        '
        'clmout_date
        '
        Me.clmout_date.DataPropertyName = "out_date"
        Me.clmout_date.HeaderText = "Check OUT Date"
        Me.clmout_date.Name = "clmout_date"
        Me.clmout_date.ReadOnly = True
        Me.clmout_date.Width = 120
        '
        'clmin_accno
        '
        Me.clmin_accno.DataPropertyName = "in_accno"
        Me.clmin_accno.HeaderText = "TransferIN_Accno"
        Me.clmin_accno.Name = "clmin_accno"
        Me.clmin_accno.ReadOnly = True
        Me.clmin_accno.Width = 122
        '
        'clmin_code
        '
        Me.clmin_code.DataPropertyName = "in_code"
        Me.clmin_code.HeaderText = "TransferIN_Code"
        Me.clmin_code.Name = "clmin_code"
        Me.clmin_code.ReadOnly = True
        Me.clmin_code.Width = 116
        '
        'clmtr_out
        '
        Me.clmtr_out.DataPropertyName = "tr_out"
        Me.clmtr_out.HeaderText = "TransferOUT"
        Me.clmtr_out.Name = "clmtr_out"
        Me.clmtr_out.ReadOnly = True
        Me.clmtr_out.Width = 112
        '
        'clmdob
        '
        Me.clmdob.DataPropertyName = "dob"
        Me.clmdob.HeaderText = "Date Of Birth"
        Me.clmdob.Name = "clmdob"
        Me.clmdob.ReadOnly = True
        Me.clmdob.Width = 107
        '
        'clmnationality
        '
        Me.clmnationality.DataPropertyName = "nationality"
        Me.clmnationality.HeaderText = "Nationality"
        Me.clmnationality.Name = "clmnationality"
        Me.clmnationality.ReadOnly = True
        Me.clmnationality.Width = 110
        '
        'clmnext_med
        '
        Me.clmnext_med.DataPropertyName = "next_med"
        Me.clmnext_med.HeaderText = "Next Medical At"
        Me.clmnext_med.Name = "clmnext_med"
        Me.clmnext_med.ReadOnly = True
        Me.clmnext_med.Width = 120
        '
        'LateMedical
        '
        Me.LateMedical.DataPropertyName = "late"
        Me.LateMedical.HeaderText = "LateMedical"
        Me.LateMedical.Name = "LateMedical"
        Me.LateMedical.ReadOnly = True
        Me.LateMedical.Visible = False
        '
        'ViewAllEmps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1242, 532)
        Me.Controls.Add(Me.AccnoLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ButtonTrans)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonViewPC)
        Me.Controls.Add(Me.ButtonViewCamp)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(1260, 577)
        Me.MinimumSize = New System.Drawing.Size(1260, 577)
        Me.Name = "ViewAllEmps"
        Me.Text = "ViewAllEmps"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonTrans As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents ButtonViewPC As System.Windows.Forms.Button
    Friend WithEvents ButtonViewCamp As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AccnoLabel As System.Windows.Forms.Label
    Friend WithEvents badge_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmaccno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmpcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmename As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmin_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmout_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmin_accno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmin_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmtr_out As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmdob As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmnationality As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmnext_med As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LateMedical As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
