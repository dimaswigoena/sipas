<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_CRUD_UnitKerja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_CRUD_UnitKerja))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Batal = New System.Windows.Forms.Button()
        Me.btn_Hapus = New System.Windows.Forms.Button()
        Me.btn_Ubah = New System.Windows.Forms.Button()
        Me.btn_Simpan = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_NamaUnitKerja = New System.Windows.Forms.TextBox()
        Me.dgv_UnitKerja = New System.Windows.Forms.DataGridView()
        Me.tb_id = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_UnitKerja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_Batal)
        Me.Panel1.Controls.Add(Me.btn_Hapus)
        Me.Panel1.Controls.Add(Me.btn_Ubah)
        Me.Panel1.Controls.Add(Me.btn_Simpan)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(538, 52)
        Me.Panel1.TabIndex = 222
        '
        'btn_Batal
        '
        Me.btn_Batal.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Batal.Image = CType(resources.GetObject("btn_Batal.Image"), System.Drawing.Image)
        Me.btn_Batal.Location = New System.Drawing.Point(419, 7)
        Me.btn_Batal.Name = "btn_Batal"
        Me.btn_Batal.Size = New System.Drawing.Size(105, 35)
        Me.btn_Batal.TabIndex = 5
        Me.btn_Batal.Text = " Batal"
        Me.btn_Batal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Batal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Batal.UseVisualStyleBackColor = True
        '
        'btn_Hapus
        '
        Me.btn_Hapus.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Hapus.Image = CType(resources.GetObject("btn_Hapus.Image"), System.Drawing.Image)
        Me.btn_Hapus.Location = New System.Drawing.Point(234, 7)
        Me.btn_Hapus.Name = "btn_Hapus"
        Me.btn_Hapus.Size = New System.Drawing.Size(105, 35)
        Me.btn_Hapus.TabIndex = 4
        Me.btn_Hapus.Text = " Hapus"
        Me.btn_Hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Hapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Hapus.UseVisualStyleBackColor = True
        '
        'btn_Ubah
        '
        Me.btn_Ubah.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ubah.Image = CType(resources.GetObject("btn_Ubah.Image"), System.Drawing.Image)
        Me.btn_Ubah.Location = New System.Drawing.Point(123, 7)
        Me.btn_Ubah.Name = "btn_Ubah"
        Me.btn_Ubah.Size = New System.Drawing.Size(105, 35)
        Me.btn_Ubah.TabIndex = 3
        Me.btn_Ubah.Text = " Ubah"
        Me.btn_Ubah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Ubah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Ubah.UseVisualStyleBackColor = True
        '
        'btn_Simpan
        '
        Me.btn_Simpan.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Simpan.Image = CType(resources.GetObject("btn_Simpan.Image"), System.Drawing.Image)
        Me.btn_Simpan.Location = New System.Drawing.Point(12, 7)
        Me.btn_Simpan.Name = "btn_Simpan"
        Me.btn_Simpan.Size = New System.Drawing.Size(105, 35)
        Me.btn_Simpan.TabIndex = 2
        Me.btn_Simpan.Text = " Simpan"
        Me.btn_Simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Simpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Simpan.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.tb_NamaUnitKerja)
        Me.Panel2.Location = New System.Drawing.Point(12, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(538, 56)
        Me.Panel2.TabIndex = 111
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(138, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 19)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nama Unit Kerja"
        '
        'tb_NamaUnitKerja
        '
        Me.tb_NamaUnitKerja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_NamaUnitKerja.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_NamaUnitKerja.Location = New System.Drawing.Point(157, 14)
        Me.tb_NamaUnitKerja.MaxLength = 30
        Me.tb_NamaUnitKerja.Name = "tb_NamaUnitKerja"
        Me.tb_NamaUnitKerja.Size = New System.Drawing.Size(362, 27)
        Me.tb_NamaUnitKerja.TabIndex = 1
        '
        'dgv_UnitKerja
        '
        Me.dgv_UnitKerja.AllowUserToAddRows = False
        Me.dgv_UnitKerja.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_UnitKerja.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_UnitKerja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_UnitKerja.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_UnitKerja.Location = New System.Drawing.Point(12, 132)
        Me.dgv_UnitKerja.Name = "dgv_UnitKerja"
        Me.dgv_UnitKerja.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_UnitKerja.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_UnitKerja.RowHeadersVisible = False
        Me.dgv_UnitKerja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_UnitKerja.Size = New System.Drawing.Size(538, 287)
        Me.dgv_UnitKerja.TabIndex = 7
        '
        'tb_id
        '
        Me.tb_id.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_id.Location = New System.Drawing.Point(25, 143)
        Me.tb_id.Name = "tb_id"
        Me.tb_id.Size = New System.Drawing.Size(71, 27)
        Me.tb_id.TabIndex = 6
        Me.tb_id.Visible = False
        '
        'Form_CRUD_UnitKerja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 431)
        Me.Controls.Add(Me.tb_id)
        Me.Controls.Add(Me.dgv_UnitKerja)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_CRUD_UnitKerja"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIPAS | Unit Kerja"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgv_UnitKerja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Batal As Button
    Friend WithEvents btn_Hapus As Button
    Friend WithEvents btn_Ubah As Button
    Friend WithEvents btn_Simpan As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_NamaUnitKerja As TextBox
    Friend WithEvents dgv_UnitKerja As DataGridView
    Friend WithEvents tb_id As TextBox
End Class
