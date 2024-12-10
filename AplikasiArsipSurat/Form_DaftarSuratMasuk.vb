Imports System.Data.OleDb

Public Class Form_DaftarSuratMasuk

    '
    ' # Header Datagridview
    '
    Sub HeaderData()
        dgv_SuratMasuk.AllowUserToResizeColumns = False
        dgv_SuratMasuk.AllowUserToResizeRows = False

        dgv_SuratMasuk.Columns(0).Visible = False

        dgv_SuratMasuk.Columns(1).Width = 175
        dgv_SuratMasuk.Columns(1).HeaderText = "Nomor Surat"

        dgv_SuratMasuk.Columns(2).Width = 150
        dgv_SuratMasuk.Columns(2).HeaderText = "Tanggal Surat"

        dgv_SuratMasuk.Columns(3).Width = 160
        dgv_SuratMasuk.Columns(3).HeaderText = "Tanggal Diterima"

        dgv_SuratMasuk.Columns(4).Width = 100
        dgv_SuratMasuk.Columns(4).HeaderText = "Sifat Surat"

        dgv_SuratMasuk.Columns(5).Width = 173
        dgv_SuratMasuk.Columns(5).HeaderText = "Pengirim Surat"

        dgv_SuratMasuk.Columns(6).Width = 265
        dgv_SuratMasuk.Columns(6).HeaderText = "Perihal"

        dgv_SuratMasuk.Columns(7).Visible = False

        dgv_SuratMasuk.Columns(8).Visible = False
    End Sub
    '
    ' # Isi Datagridview
    '
    Sub IsiData()
        Try

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        BUKA()
        DA = New OleDbDataAdapter("SELECT * FROM tbl_SuratMasuk", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "suratmasuk")
        DT = DS.Tables("suratmasuk")
        dgv_SuratMasuk.DataSource = DT
        dgv_SuratMasuk.ReadOnly = True
        DS = Nothing
        DA = Nothing
        CONN.Close()
    End Sub

    Private Sub btn_TambahSuratMasuk_Click(sender As Object, e As EventArgs) Handles btn_TambahSuratMasuk.Click
        Form_CRUD_SuratMasuk.ShowDialog()
    End Sub

    Private Sub Form_DaftarSuratMasuk_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        IsiData()
        HeaderData()
    End Sub

    Private Sub Form_DaftarSuratMasuk_Load(sender As Object, e As EventArgs) Handles Me.Load
        IsiData()
        HeaderData()
    End Sub

    Private Sub dgv_SuratMasuk_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_SuratMasuk.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgv_SuratMasuk.Rows(e.RowIndex)
            Form_CRUD_SuratMasuk.tb_ID.Text = row.Cells("ID").Value.ToString
            Form_CRUD_SuratMasuk.tb_NomorSurat.Text = row.Cells("NomorSurat").Value.ToString
            Form_CRUD_SuratMasuk.dtp_TanggalSurat.Value = row.Cells("TanggalSurat").Value.ToString
            Form_CRUD_SuratMasuk.dtp_TanggalDiterima.Value = row.Cells("TanggalDiterima").Value.ToString
            Form_CRUD_SuratMasuk.cb_SifatSurat.SelectedItem = row.Cells("SifatSurat").Value.ToString
            Form_CRUD_SuratMasuk.tb_Pengirim.Text = row.Cells("Pengirim").Value.ToString
            Form_CRUD_SuratMasuk.tb_Perihal.Text = row.Cells("Perihal").Value.ToString
            Form_CRUD_SuratMasuk.tb_IsiRingkasanSurat.Text = row.Cells("IsiRingkasan").Value.ToString
            Form_CRUD_SuratMasuk.tb_NamaFile.Text = row.Cells("NamaFile").Value.ToString

            Form_CRUD_SuratMasuk.btn_Simpan.Enabled = False
            Form_CRUD_SuratMasuk.btn_Ubah.Enabled = True
            Form_CRUD_SuratMasuk.btn_Hapus.Enabled = True
            Form_CRUD_SuratMasuk.btn_TampilkanFile.Visible = True

            Form_CRUD_SuratMasuk.tb_NomorSurat.Focus()
            Form_CRUD_SuratMasuk.SifatSurat()
            Form_CRUD_SuratMasuk.ShowDialog()

        End If
    End Sub
End Class