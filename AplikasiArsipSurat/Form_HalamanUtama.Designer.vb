<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_HalamanUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_HalamanUtama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnitKerjaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btn_SuratKeluar = New System.Windows.Forms.Button()
        Me.btn_SuratMasuk = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(377, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UnitKerjaToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'UnitKerjaToolStripMenuItem
        '
        Me.UnitKerjaToolStripMenuItem.Name = "UnitKerjaToolStripMenuItem"
        Me.UnitKerjaToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.UnitKerjaToolStripMenuItem.Text = "Unit Kerja"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 171)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(377, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(153, 17)
        Me.ToolStripStatusLabel1.Text = "SIPAS | PT Karya Muba Abadi"
        '
        'btn_SuratKeluar
        '
        Me.btn_SuratKeluar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btn_SuratKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SuratKeluar.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SuratKeluar.Image = CType(resources.GetObject("btn_SuratKeluar.Image"), System.Drawing.Image)
        Me.btn_SuratKeluar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_SuratKeluar.Location = New System.Drawing.Point(211, 49)
        Me.btn_SuratKeluar.Name = "btn_SuratKeluar"
        Me.btn_SuratKeluar.Size = New System.Drawing.Size(95, 95)
        Me.btn_SuratKeluar.TabIndex = 5
        Me.btn_SuratKeluar.Text = "Surat Keluar"
        Me.btn_SuratKeluar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_SuratKeluar.UseVisualStyleBackColor = True
        '
        'btn_SuratMasuk
        '
        Me.btn_SuratMasuk.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btn_SuratMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SuratMasuk.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SuratMasuk.Image = CType(resources.GetObject("btn_SuratMasuk.Image"), System.Drawing.Image)
        Me.btn_SuratMasuk.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_SuratMasuk.Location = New System.Drawing.Point(71, 49)
        Me.btn_SuratMasuk.Name = "btn_SuratMasuk"
        Me.btn_SuratMasuk.Size = New System.Drawing.Size(95, 95)
        Me.btn_SuratMasuk.TabIndex = 4
        Me.btn_SuratMasuk.Text = "Surat Masuk"
        Me.btn_SuratMasuk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_SuratMasuk.UseVisualStyleBackColor = True
        '
        'Form_HalamanUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(377, 193)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_SuratKeluar)
        Me.Controls.Add(Me.btn_SuratMasuk)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_HalamanUtama"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIPAS | Sistem Informasi Pengelolaan Arsip Surat Ver 1.0"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnitKerjaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents btn_SuratKeluar As Button
    Friend WithEvents btn_SuratMasuk As Button
End Class
