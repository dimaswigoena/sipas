<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_DaftarSuratMasuk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_DaftarSuratMasuk))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_TambahSuratMasuk = New System.Windows.Forms.Button()
        Me.dgv_SuratMasuk = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_SuratMasuk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_TambahSuratMasuk)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(867, 54)
        Me.Panel1.TabIndex = 0
        '
        'btn_TambahSuratMasuk
        '
        Me.btn_TambahSuratMasuk.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_TambahSuratMasuk.Image = CType(resources.GetObject("btn_TambahSuratMasuk.Image"), System.Drawing.Image)
        Me.btn_TambahSuratMasuk.Location = New System.Drawing.Point(719, 3)
        Me.btn_TambahSuratMasuk.Name = "btn_TambahSuratMasuk"
        Me.btn_TambahSuratMasuk.Size = New System.Drawing.Size(138, 45)
        Me.btn_TambahSuratMasuk.TabIndex = 1
        Me.btn_TambahSuratMasuk.Text = "  Tambah Data"
        Me.btn_TambahSuratMasuk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_TambahSuratMasuk.UseVisualStyleBackColor = True
        '
        'dgv_SuratMasuk
        '
        Me.dgv_SuratMasuk.AllowUserToAddRows = False
        Me.dgv_SuratMasuk.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_SuratMasuk.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_SuratMasuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_SuratMasuk.Location = New System.Drawing.Point(12, 72)
        Me.dgv_SuratMasuk.Name = "dgv_SuratMasuk"
        Me.dgv_SuratMasuk.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_SuratMasuk.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_SuratMasuk.RowHeadersVisible = False
        Me.dgv_SuratMasuk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_SuratMasuk.Size = New System.Drawing.Size(867, 420)
        Me.dgv_SuratMasuk.TabIndex = 1
        '
        'Form_DaftarSuratMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(892, 504)
        Me.Controls.Add(Me.dgv_SuratMasuk)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_DaftarSuratMasuk"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIPAS | Surat Masuk"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv_SuratMasuk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_TambahSuratMasuk As Button
    Friend WithEvents dgv_SuratMasuk As DataGridView
End Class
