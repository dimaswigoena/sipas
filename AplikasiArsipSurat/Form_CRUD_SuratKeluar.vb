﻿Imports System.ComponentModel
Imports System.Data.OleDb
Public Class Form_CRUD_SuratKeluar

    '
    ' # Header Datagridview
    '
    Sub HeaderData()
        dgv_SuratKeluar.AllowUserToResizeColumns = False
        dgv_SuratKeluar.AllowUserToResizeRows = False

        dgv_SuratKeluar.Columns(0).Visible = False

        dgv_SuratKeluar.Columns(1).Width = 175
        dgv_SuratKeluar.Columns(1).HeaderText = "Nomor Surat"

        dgv_SuratKeluar.Columns(2).Width = 150
        dgv_SuratKeluar.Columns(2).HeaderText = "Tanggal Surat"

        dgv_SuratKeluar.Columns(3).Width = 160
        dgv_SuratKeluar.Columns(3).HeaderText = "Tujuan Surat"

        dgv_SuratKeluar.Columns(4).Width = 100
        dgv_SuratKeluar.Columns(4).HeaderText = "Sifat Surat"

        dgv_SuratKeluar.Columns(5).Width = 173
        dgv_SuratKeluar.Columns(5).HeaderText = "Pengirim Surat"

        dgv_SuratKeluar.Columns(6).Width = 265
        dgv_SuratKeluar.Columns(6).HeaderText = "Perihal"

        dgv_SuratKeluar.Columns(7).Visible = False

        dgv_SuratKeluar.Columns(8).Visible = False
    End Sub
    '
    ' # Isi Datagridview
    '
    Sub IsiData()
        Try
            BUKA()
            DA = New OleDbDataAdapter("SELECT * FROM tbl_SuratKeluar", CONN)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "suratkeluar")
            DT = DS.Tables("suratkeluar")
            dgv_SuratKeluar.DataSource = DT
            dgv_SuratKeluar.ReadOnly = True
            DS = Nothing
            DA = Nothing
            CONN.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try

    End Sub

    '
    ' # Isi ComboBox Sifat Surat 
    '
    Sub SifatSurat()
        cb_SifatSurat.Items.Add("Biasa")
        cb_SifatSurat.Items.Add("Segera")
        cb_SifatSurat.Items.Add("Penting")
        cb_SifatSurat.Items.Add("Rahasia")
    End Sub

    '
    ' # Isi ComboBox Unit Kerja
    '
    Sub UnitKerja()
        Try
            BUKA()
            Dim query As String = "SELECT NamaUnit FROM tbl_UnitKerja"
            CMD = New OleDbCommand(query, CONN)
            DR = CMD.ExecuteReader
            While DR.Read()
                cb_UnitKerja.Items.Add(DR("NamaUnit").ToString())
            End While
        Catch ex As Exception

        End Try
    End Sub

    '
    ' # Form Load
    '
    Sub BersihkanData()
        tb_ID.Clear()
        tb_NomorSurat.Clear()
        dtp_TanggalSurat.Value = Date.Today
        cb_SifatSurat.SelectedIndex = 0
        cb_UnitKerja.SelectedIndex = 0
        tb_Perihal.Clear()
        tb_Tujuan.Clear()
        tb_IsiRingkasanSurat.Clear()
        tb_AlamatFile.Clear()
        tb_NamaFile.Clear()

        btn_Simpan.Enabled = True
        btn_Ubah.Enabled = False
        btn_Hapus.Enabled = False
        btn_TampilkanFile.Visible = False
        tb_NomorSurat.Focus()
    End Sub

    Private Sub Form_CRUD_SuratKeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsiData()
        HeaderData()
        SifatSurat()
        UnitKerja()
        BersihkanData()
    End Sub

    Private Sub Form_CRUD_SuratKeluar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        cb_SifatSurat.Items.Clear()
        cb_UnitKerja.Items.Clear()
    End Sub

    Private Sub Form_CRUD_SuratKeluar_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        tb_NomorSurat.Focus()
    End Sub

    Private Sub btn_Batal_Click(sender As Object, e As EventArgs) Handles btn_Batal.Click
        BersihkanData()
    End Sub

    Private Sub btn_Upload_Click(sender As Object, e As EventArgs) Handles btn_Upload.Click
        Try
            OpenFileDialog1.Filter = "PDF | *.pdf"
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                tb_AlamatFile.Text = OpenFileDialog1.FileName
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Simpan_Click(sender As Object, e As EventArgs) Handles btn_Simpan.Click
        If tb_NomorSurat.Text = "" Then
            MsgBox("Nomor Surat masih kosong", MsgBoxStyle.Information, "Informasi")
            tb_NomorSurat.Focus()
        ElseIf tb_Tujuan.Text = "" Then
            MsgBox("Pengirim Surat masih kosong", MsgBoxStyle.Information, "Informasi")
            tb_Tujuan.Focus()
        ElseIf tb_Perihal.Text = "" Then
            MsgBox("Perihal Surat masih kosong", MsgBoxStyle.Information, "Informasi")
            tb_Perihal.Focus()
        ElseIf tb_IsiRingkasanSurat.Text = "" Then
            MsgBox("Ringkasan Surat masih kosong", MsgBoxStyle.Information, "Informasi")
            tb_IsiRingkasanSurat.Focus()
        Else
            Dim hasil As Integer = MessageBox.Show("Apakah anda yakin ingin menyimpan data ?", "Perhatian !", MessageBoxButtons.YesNo)
            If hasil = DialogResult.Yes Then
                Call BUKA()
                Dim STR As String = "INSERT INTO tbl_SuratKeluar
                                    (NomorSurat, TanggalSurat, TujuanSurat, SifatSurat, Pengirim, Perihal, IsiRingkasan, NamaFile) 
                                 VALUES 
                                    (@nomorsurat, @tanggalsurat, @tujuansurat, @sifatsurat, @pengirim, @perihal, @isiringkasan, @namafile)"

                CMD = New OleDbCommand
                With CMD
                    .Connection = CONN
                    .CommandType = CommandType.Text
                    .CommandText = STR
                    .Parameters.Add(New OleDbParameter("@nomorsurat", tb_NomorSurat.Text))
                    .Parameters.Add(New OleDbParameter("@tanggalsurat", dtp_TanggalSurat.Text))
                    .Parameters.Add(New OleDbParameter("@tujuansurat", tb_Tujuan.Text))
                    .Parameters.Add(New OleDbParameter("@sifatsurat", cb_SifatSurat.SelectedItem))
                    .Parameters.Add(New OleDbParameter("@pengirim", cb_UnitKerja.SelectedItem))
                    .Parameters.Add(New OleDbParameter("@perihal", tb_Perihal.Text))
                    .Parameters.Add(New OleDbParameter("@isiringkasan", tb_IsiRingkasanSurat.Text))
                    .Parameters.Add(New OleDbParameter("@namafile", tb_AlamatFile.Text))

                    CMD.Parameters("@nomorsurat").Value = tb_NomorSurat.Text
                    CMD.Parameters("@tanggalsurat").Value = dtp_TanggalSurat.Text
                    CMD.Parameters("@tujuansurat").Value = tb_Tujuan.Text
                    CMD.Parameters("@sifatsurat").Value = cb_SifatSurat.SelectedItem
                    CMD.Parameters("@pengirim").Value = cb_UnitKerja.SelectedItem
                    CMD.Parameters("@perihal").Value = tb_Perihal.Text
                    CMD.Parameters("@isiringkasan").Value = tb_IsiRingkasanSurat.Text
                    CMD.Parameters("@namafile").Value = System.IO.Path.GetFileName(tb_AlamatFile.Text)
                    CMD.ExecuteNonQuery()

                    If tb_AlamatFile.Text <> "" Then
                        '
                        ' Memindahkan File
                        '
                        System.IO.File.Copy(tb_AlamatFile.Text, Application.StartupPath & "\SURAT KELUAR\" & System.IO.Path.GetFileName(tb_AlamatFile.Text), True)
                    End If

                End With
                MsgBox("Data berhasil disimpan !", MsgBoxStyle.Information, "Informasi")
                BersihkanData()
                IsiData()
            ElseIf hasil = DialogResult.No Then
                tb_NomorSurat.Focus()
            End If
        End If
    End Sub

    Private Sub dgv_SuratMasuk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_SuratKeluar.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgv_SuratKeluar.Rows(e.RowIndex)
            tb_ID.Text = row.Cells("ID").Value.ToString
            tb_NomorSurat.Text = row.Cells("NomorSurat").Value.ToString
            dtp_TanggalSurat.Value = row.Cells("TanggalSurat").Value.ToString
            tb_Tujuan.Text = row.Cells("TujuanSurat").Value.ToString
            cb_SifatSurat.SelectedItem = row.Cells("SifatSurat").Value.ToString
            cb_UnitKerja.SelectedItem = row.Cells("Pengirim").Value.ToString
            tb_Perihal.Text = row.Cells("Perihal").Value.ToString
            tb_IsiRingkasanSurat.Text = row.Cells("IsiRingkasan").Value.ToString
            tb_NamaFile.Text = row.Cells("NamaFile").Value.ToString

            btn_Simpan.Enabled = False
            btn_Ubah.Enabled = True
            btn_Hapus.Enabled = True
            btn_TampilkanFile.Visible = True

            tb_NomorSurat.Focus()

        End If
    End Sub

    Private Sub btn_Ubah_Click(sender As Object, e As EventArgs) Handles btn_Ubah.Click
        If tb_NomorSurat.Text = "" Then
            MsgBox("Nama unit masih kosong", MsgBoxStyle.Information, "Informasi")
        Else
            Dim hasil As Integer = MessageBox.Show("Apakah anda yakin ingin mengubah data ?", "Perhatian !", MessageBoxButtons.YesNo)
            If hasil = DialogResult.Yes Then
                If tb_AlamatFile.Text <> "" Then
                    Try
                        Call BUKA()
                        Dim str As String = "UPDATE tbl_SuratKeluar SET
                                NomorSurat = @nomorsurat, 
                                TanggalSurat = @tanggalsurat, 
                                TujuanSurat = @tujuansurat, 
                                SifatSurat = @sifatsurat, 
                                Pengirim = @pengirim, 
                                Perihal = @perihal, 
                                IsiRingkasan = @isiringkasan, 
                                NamaFile = @namafile                       
                            WHERE
                                ID = @id"

                        CMD = New OleDbCommand
                        With CMD
                            .Connection = CONN
                            .CommandType = CommandType.Text
                            .CommandText = str
                            .Parameters.Add(New OleDbParameter("@nomorsurat", tb_NomorSurat.Text))
                            .Parameters.Add(New OleDbParameter("@tanggalsurat", dtp_TanggalSurat.Text))
                            .Parameters.Add(New OleDbParameter("@tujuansurat", tb_Tujuan.Text))
                            .Parameters.Add(New OleDbParameter("@sifatsurat", cb_SifatSurat.SelectedItem))
                            .Parameters.Add(New OleDbParameter("@pengirim", cb_UnitKerja.SelectedItem))
                            .Parameters.Add(New OleDbParameter("@perihal", tb_Perihal.Text))
                            .Parameters.Add(New OleDbParameter("@isiringkasan", tb_IsiRingkasanSurat.Text))
                            .Parameters.Add(New OleDbParameter("@namafile", tb_AlamatFile.Text))
                            .Parameters.Add(New OleDbParameter("@id", tb_ID.Text))

                            CMD.Parameters("@nomorsurat").Value = tb_NomorSurat.Text
                            CMD.Parameters("@tanggalsurat").Value = dtp_TanggalSurat.Text
                            CMD.Parameters("@tujuansurat").Value = tb_Tujuan.Text
                            CMD.Parameters("@sifatsurat").Value = cb_SifatSurat.SelectedItem
                            CMD.Parameters("@pengirim").Value = cb_UnitKerja.SelectedItem
                            CMD.Parameters("@perihal").Value = tb_Perihal.Text
                            CMD.Parameters("@isiringkasan").Value = tb_IsiRingkasanSurat.Text
                            CMD.Parameters("@namafile").Value = System.IO.Path.GetFileName(tb_AlamatFile.Text)
                            CMD.ExecuteNonQuery()

                            '
                            ' Menghapus file lama dan Memindahkan file baru
                            '
                            System.IO.File.Delete(Application.StartupPath & "\SURAT KELUAR\" & System.IO.Path.GetFileName(tb_NamaFile.Text))
                            System.IO.File.Copy(tb_AlamatFile.Text, Application.StartupPath & "\SURAT KELUAR\" & System.IO.Path.GetFileName(tb_AlamatFile.Text), True)
                        End With
                        MsgBox("Data berhasil diubah !", MsgBoxStyle.Information, "Informasi")
                        BersihkanData()
                        IsiData()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                    End Try
                Else
                    Try
                        Call BUKA()
                        Dim str As String = "UPDATE tbl_SuratKeluar SET
                                NomorSurat = @nomorsurat, 
                                TanggalSurat = @tanggalsurat, 
                                TujuanSurat = @tujuansurat, 
                                SifatSurat = @sifatsurat, 
                                Pengirim = @pengirim, 
                                Perihal = @perihal, 
                                IsiRingkasan = @isiringkasan, 
                                NamaFile = @namafile                       
                            WHERE
                                ID = @id"

                        CMD = New OleDbCommand
                        With CMD
                            .Connection = CONN
                            .CommandType = CommandType.Text
                            .CommandText = str
                            .Parameters.Add(New OleDbParameter("@nomorsurat", tb_NomorSurat.Text))
                            .Parameters.Add(New OleDbParameter("@tanggalsurat", dtp_TanggalSurat.Text))
                            .Parameters.Add(New OleDbParameter("@tujuansurat", tb_Tujuan.Text))
                            .Parameters.Add(New OleDbParameter("@sifatsurat", cb_SifatSurat.SelectedItem))
                            .Parameters.Add(New OleDbParameter("@pengirim", cb_UnitKerja.SelectedItem))
                            .Parameters.Add(New OleDbParameter("@perihal", tb_Perihal.Text))
                            .Parameters.Add(New OleDbParameter("@isiringkasan", tb_IsiRingkasanSurat.Text))
                            .Parameters.Add(New OleDbParameter("@namafile", tb_NamaFile.Text))
                            .Parameters.Add(New OleDbParameter("@id", tb_ID.Text))

                            CMD.Parameters("@nomorsurat").Value = tb_NomorSurat.Text
                            CMD.Parameters("@tanggalsurat").Value = dtp_TanggalSurat.Text
                            CMD.Parameters("@tujuansurat").Value = tb_Tujuan.Text
                            CMD.Parameters("@sifatsurat").Value = cb_SifatSurat.SelectedItem
                            CMD.Parameters("@pengirim").Value = cb_UnitKerja.SelectedItem
                            CMD.Parameters("@perihal").Value = tb_Perihal.Text
                            CMD.Parameters("@isiringkasan").Value = tb_IsiRingkasanSurat.Text
                            CMD.Parameters("@namafile").Value = tb_NamaFile.Text
                            CMD.ExecuteNonQuery()

                        End With
                        MsgBox("Data berhasil diubah !", MsgBoxStyle.Information, "Informasi")
                        BersihkanData()
                        IsiData()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                    End Try
                End If

            ElseIf hasil = DialogResult.No Then
                tb_NomorSurat.Focus()
            End If
        End If
    End Sub

    Private Sub btn_Hapus_Click(sender As Object, e As EventArgs) Handles btn_Hapus.Click
        Dim hasil As Integer = MessageBox.Show("Apakah anda yakin ingin menghapus data ?", "Perhatian !", MessageBoxButtons.YesNo)
        If hasil = DialogResult.Yes Then
            Try
                Call BUKA()
                Dim str As String = "DELETE * FROM tbl_SuratKeluar WHERE id = @id"

                CMD = New OleDbCommand
                With CMD
                    .Connection = CONN
                    .CommandType = CommandType.Text
                    .CommandText = str
                    .Parameters.Add(New OleDbParameter("@id", tb_ID.Text))
                    CMD.ExecuteNonQuery()

                    '
                    ' Menghapus File
                    '
                    System.IO.File.Delete(Application.StartupPath & "\SURAT KELUAR\" & System.IO.Path.GetFileName(tb_NamaFile.Text))
                End With
                MsgBox("Data berhasil dihapus !", MsgBoxStyle.Information, "Informasi")
                BersihkanData()
                IsiData()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        ElseIf hasil = DialogResult.No Then
            tb_NomorSurat.Focus()
        End If
    End Sub

    Private Sub btn_TampilkanFile_Click(sender As Object, e As EventArgs) Handles btn_TampilkanFile.Click
        Try
            BUKA()
            DA = New OleDbDataAdapter("SELECT * FROM tbl_SuratKeluar WHERE NamaFile ='" & tb_NamaFile.Text & "'", CONN)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "suratkeluar")
            DT = DS.Tables("suratkeluar")

            With Form_TampilanFileSurat
                .Show()
                .Focus()
                .AxAcroPDF1.src = Application.StartupPath & "\SURAT KELUAR\" & DT.Rows(0).Item("NamaFile")
            End With
            DS = Nothing
            DA = Nothing
            CONN.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub tb_NomorSurat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_NomorSurat.KeyPress
        If e.KeyChar = Chr(13) Then
            If tb_NomorSurat.Text = "" Then
                MsgBox("Nomor Surat tidak boleh kosong", MsgBoxStyle.Information, "Informasi")
                tb_NomorSurat.Focus()
            Else
                cb_UnitKerja.Focus()
            End If
        End If
    End Sub

    Private Sub cb_UnitKerja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_UnitKerja.KeyPress
        If e.KeyChar = Chr(13) Then
            cb_SifatSurat.Focus()
        End If
    End Sub

    Private Sub cb_SifatSurat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_SifatSurat.KeyPress
        If e.KeyChar = Chr(13) Then
            tb_Tujuan.Focus()
        End If
    End Sub

    Private Sub tb_Pengirim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Tujuan.KeyPress
        If e.KeyChar = Chr(13) Then
            If tb_Tujuan.Text = "" Then
                MsgBox("Pengirim tidak boleh kosong", MsgBoxStyle.Information, "Informasi")
                tb_Tujuan.Focus()
            Else
                tb_Perihal.Focus()
            End If
        End If
    End Sub

    Private Sub tb_Perihal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Perihal.KeyPress
        If e.KeyChar = Chr(13) Then
            If tb_Perihal.Text = "" Then
                MsgBox("Perihal tidak boleh kosong", MsgBoxStyle.Information, "Informasi")
                tb_Perihal.Focus()
            Else
                tb_IsiRingkasanSurat.Focus()
            End If
        End If
    End Sub

    Private Sub tb_IsiRingkasanSurat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_IsiRingkasanSurat.KeyPress
        If e.KeyChar = Chr(13) Then
            If tb_IsiRingkasanSurat.Text = "" Then
                MsgBox("Ringkasan tidak boleh kosong", MsgBoxStyle.Information, "Informasi")
                tb_IsiRingkasanSurat.Focus()
            Else
                btn_Simpan.Focus()
            End If
        End If
    End Sub
End Class