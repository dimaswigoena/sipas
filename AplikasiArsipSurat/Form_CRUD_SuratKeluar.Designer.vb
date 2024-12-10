<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_CRUD_SuratKeluar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_CRUD_SuratKeluar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Hapus = New System.Windows.Forms.Button()
        Me.btn_Ubah = New System.Windows.Forms.Button()
        Me.btn_Batal = New System.Windows.Forms.Button()
        Me.btn_Simpan = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cb_UnitKerja = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tb_NamaFile = New System.Windows.Forms.TextBox()
        Me.btn_TampilkanFile = New System.Windows.Forms.Button()
        Me.tb_ID = New System.Windows.Forms.TextBox()
        Me.btn_Upload = New System.Windows.Forms.Button()
        Me.tb_AlamatFile = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tb_NomorSurat = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtp_TanggalSurat = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cb_SifatSurat = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tb_Perihal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_Tujuan = New System.Windows.Forms.TextBox()
        Me.tb_IsiRingkasanSurat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.dgv_SuratKeluar = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_SuratKeluar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_Hapus)
        Me.Panel1.Controls.Add(Me.btn_Ubah)
        Me.Panel1.Controls.Add(Me.btn_Batal)
        Me.Panel1.Controls.Add(Me.btn_Simpan)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(538, 52)
        Me.Panel1.TabIndex = 223
        '
        'btn_Hapus
        '
        Me.btn_Hapus.Enabled = False
        Me.btn_Hapus.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Hapus.Image = CType(resources.GetObject("btn_Hapus.Image"), System.Drawing.Image)
        Me.btn_Hapus.Location = New System.Drawing.Point(234, 7)
        Me.btn_Hapus.Name = "btn_Hapus"
        Me.btn_Hapus.Size = New System.Drawing.Size(105, 35)
        Me.btn_Hapus.TabIndex = 12
        Me.btn_Hapus.Text = " Hapus"
        Me.btn_Hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Hapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Hapus.UseVisualStyleBackColor = True
        '
        'btn_Ubah
        '
        Me.btn_Ubah.Enabled = False
        Me.btn_Ubah.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ubah.Image = CType(resources.GetObject("btn_Ubah.Image"), System.Drawing.Image)
        Me.btn_Ubah.Location = New System.Drawing.Point(123, 7)
        Me.btn_Ubah.Name = "btn_Ubah"
        Me.btn_Ubah.Size = New System.Drawing.Size(105, 35)
        Me.btn_Ubah.TabIndex = 11
        Me.btn_Ubah.Text = " Ubah"
        Me.btn_Ubah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Ubah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Ubah.UseVisualStyleBackColor = True
        '
        'btn_Batal
        '
        Me.btn_Batal.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Batal.Image = CType(resources.GetObject("btn_Batal.Image"), System.Drawing.Image)
        Me.btn_Batal.Location = New System.Drawing.Point(419, 7)
        Me.btn_Batal.Name = "btn_Batal"
        Me.btn_Batal.Size = New System.Drawing.Size(105, 35)
        Me.btn_Batal.TabIndex = 10
        Me.btn_Batal.Text = " Batal"
        Me.btn_Batal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Batal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Batal.UseVisualStyleBackColor = True
        '
        'btn_Simpan
        '
        Me.btn_Simpan.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Simpan.Image = CType(resources.GetObject("btn_Simpan.Image"), System.Drawing.Image)
        Me.btn_Simpan.Location = New System.Drawing.Point(12, 7)
        Me.btn_Simpan.Name = "btn_Simpan"
        Me.btn_Simpan.Size = New System.Drawing.Size(105, 35)
        Me.btn_Simpan.TabIndex = 9
        Me.btn_Simpan.Text = " Simpan"
        Me.btn_Simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Simpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Simpan.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.cb_UnitKerja)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.tb_NamaFile)
        Me.Panel2.Controls.Add(Me.btn_TampilkanFile)
        Me.Panel2.Controls.Add(Me.tb_ID)
        Me.Panel2.Controls.Add(Me.btn_Upload)
        Me.Panel2.Controls.Add(Me.tb_AlamatFile)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.tb_NomorSurat)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.dtp_TanggalSurat)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.cb_SifatSurat)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.tb_Perihal)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.tb_Tujuan)
        Me.Panel2.Controls.Add(Me.tb_IsiRingkasanSurat)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(12, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(538, 418)
        Me.Panel2.TabIndex = 224
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(143, 184)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(12, 18)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = ":"
        '
        'cb_UnitKerja
        '
        Me.cb_UnitKerja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_UnitKerja.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_UnitKerja.FormattingEnabled = True
        Me.cb_UnitKerja.Location = New System.Drawing.Point(161, 117)
        Me.cb_UnitKerja.Name = "cb_UnitKerja"
        Me.cb_UnitKerja.Size = New System.Drawing.Size(222, 26)
        Me.cb_UnitKerja.TabIndex = 27
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(46, 184)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 18)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Tujuan Surat"
        '
        'tb_NamaFile
        '
        Me.tb_NamaFile.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_NamaFile.Location = New System.Drawing.Point(257, 374)
        Me.tb_NamaFile.Name = "tb_NamaFile"
        Me.tb_NamaFile.Size = New System.Drawing.Size(139, 26)
        Me.tb_NamaFile.TabIndex = 25
        Me.tb_NamaFile.Visible = False
        '
        'btn_TampilkanFile
        '
        Me.btn_TampilkanFile.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_TampilkanFile.Image = CType(resources.GetObject("btn_TampilkanFile.Image"), System.Drawing.Image)
        Me.btn_TampilkanFile.Location = New System.Drawing.Point(402, 369)
        Me.btn_TampilkanFile.Name = "btn_TampilkanFile"
        Me.btn_TampilkanFile.Size = New System.Drawing.Size(106, 35)
        Me.btn_TampilkanFile.TabIndex = 24
        Me.btn_TampilkanFile.Text = "Tampilkan"
        Me.btn_TampilkanFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_TampilkanFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_TampilkanFile.UseVisualStyleBackColor = True
        Me.btn_TampilkanFile.Visible = False
        '
        'tb_ID
        '
        Me.tb_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_ID.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ID.Location = New System.Drawing.Point(514, 21)
        Me.tb_ID.Name = "tb_ID"
        Me.tb_ID.Size = New System.Drawing.Size(43, 26)
        Me.tb_ID.TabIndex = 23
        Me.tb_ID.Visible = False
        '
        'btn_Upload
        '
        Me.btn_Upload.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Upload.Image = CType(resources.GetObject("btn_Upload.Image"), System.Drawing.Image)
        Me.btn_Upload.Location = New System.Drawing.Point(161, 369)
        Me.btn_Upload.Name = "btn_Upload"
        Me.btn_Upload.Size = New System.Drawing.Size(90, 35)
        Me.btn_Upload.TabIndex = 7
        Me.btn_Upload.Text = " Unggah"
        Me.btn_Upload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Upload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Upload.UseVisualStyleBackColor = True
        '
        'tb_AlamatFile
        '
        Me.tb_AlamatFile.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_AlamatFile.Location = New System.Drawing.Point(161, 337)
        Me.tb_AlamatFile.Name = "tb_AlamatFile"
        Me.tb_AlamatFile.ReadOnly = True
        Me.tb_AlamatFile.Size = New System.Drawing.Size(347, 26)
        Me.tb_AlamatFile.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(143, 340)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(12, 18)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(66, 340)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 18)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "File Surat"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(143, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(12, 18)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = ":"
        '
        'tb_NomorSurat
        '
        Me.tb_NomorSurat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_NomorSurat.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_NomorSurat.Location = New System.Drawing.Point(161, 21)
        Me.tb_NomorSurat.Name = "tb_NomorSurat"
        Me.tb_NomorSurat.Size = New System.Drawing.Size(347, 26)
        Me.tb_NomorSurat.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(143, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(12, 18)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = ":"
        '
        'dtp_TanggalSurat
        '
        Me.dtp_TanggalSurat.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_TanggalSurat.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_TanggalSurat.Location = New System.Drawing.Point(161, 53)
        Me.dtp_TanggalSurat.Name = "dtp_TanggalSurat"
        Me.dtp_TanggalSurat.Size = New System.Drawing.Size(142, 26)
        Me.dtp_TanggalSurat.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(143, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(12, 18)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = ":"
        '
        'cb_SifatSurat
        '
        Me.cb_SifatSurat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_SifatSurat.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_SifatSurat.FormattingEnabled = True
        Me.cb_SifatSurat.Location = New System.Drawing.Point(161, 85)
        Me.cb_SifatSurat.Name = "cb_SifatSurat"
        Me.cb_SifatSurat.Size = New System.Drawing.Size(222, 26)
        Me.cb_SifatSurat.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(143, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(12, 18)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = ":"
        '
        'tb_Perihal
        '
        Me.tb_Perihal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_Perihal.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Perihal.Location = New System.Drawing.Point(161, 149)
        Me.tb_Perihal.Name = "tb_Perihal"
        Me.tb_Perihal.Size = New System.Drawing.Size(347, 26)
        Me.tb_Perihal.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(143, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 18)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = ":"
        '
        'tb_Tujuan
        '
        Me.tb_Tujuan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_Tujuan.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Tujuan.Location = New System.Drawing.Point(161, 181)
        Me.tb_Tujuan.Name = "tb_Tujuan"
        Me.tb_Tujuan.Size = New System.Drawing.Size(347, 26)
        Me.tb_Tujuan.TabIndex = 5
        '
        'tb_IsiRingkasanSurat
        '
        Me.tb_IsiRingkasanSurat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_IsiRingkasanSurat.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_IsiRingkasanSurat.Location = New System.Drawing.Point(161, 213)
        Me.tb_IsiRingkasanSurat.Multiline = True
        Me.tb_IsiRingkasanSurat.Name = "tb_IsiRingkasanSurat"
        Me.tb_IsiRingkasanSurat.Size = New System.Drawing.Size(347, 118)
        Me.tb_IsiRingkasanSurat.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(143, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(12, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Isi Surat Ringkas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(83, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Perihal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(70, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Pengirim"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sifat Surat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal Surat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor Surat"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'dgv_SuratKeluar
        '
        Me.dgv_SuratKeluar.AllowUserToAddRows = False
        Me.dgv_SuratKeluar.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_SuratKeluar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_SuratKeluar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_SuratKeluar.Location = New System.Drawing.Point(556, 12)
        Me.dgv_SuratKeluar.Name = "dgv_SuratKeluar"
        Me.dgv_SuratKeluar.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_SuratKeluar.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_SuratKeluar.RowHeadersVisible = False
        Me.dgv_SuratKeluar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_SuratKeluar.Size = New System.Drawing.Size(696, 476)
        Me.dgv_SuratKeluar.TabIndex = 225
        '
        'Form_CRUD_SuratKeluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1264, 502)
        Me.Controls.Add(Me.dgv_SuratKeluar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_CRUD_SuratKeluar"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIPAS | Tambah Surat Keluar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgv_SuratKeluar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Batal As Button
    Friend WithEvents btn_Simpan As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Upload As Button
    Friend WithEvents tb_AlamatFile As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents tb_NomorSurat As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents dtp_TanggalSurat As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents cb_SifatSurat As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tb_Perihal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tb_Tujuan As TextBox
    Friend WithEvents tb_IsiRingkasanSurat As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_Hapus As Button
    Friend WithEvents btn_Ubah As Button
    Friend WithEvents tb_ID As TextBox
    Friend WithEvents btn_TampilkanFile As Button
    Friend WithEvents tb_NamaFile As TextBox
    Friend WithEvents dgv_SuratKeluar As DataGridView
    Friend WithEvents Label17 As Label
    Friend WithEvents cb_UnitKerja As ComboBox
    Friend WithEvents Label18 As Label
End Class
