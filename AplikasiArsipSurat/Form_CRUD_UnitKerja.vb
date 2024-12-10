Imports System.Data.OleDb

Public Class Form_CRUD_UnitKerja
    '
    ' # Form Load
    '
    Sub BersihkanData()
        tb_id.Clear()
        tb_NamaUnitKerja.Clear()

        btn_Simpan.Enabled = True
        btn_Ubah.Enabled = False
        btn_Hapus.Enabled = False

        tb_NamaUnitKerja.Focus()
    End Sub

    '
    ' # Header Datagridview
    '
    Sub HeaderData()
        dgv_UnitKerja.AllowUserToResizeColumns = False
        dgv_UnitKerja.AllowUserToResizeRows = False

        dgv_UnitKerja.Columns(0).Visible = False

        dgv_UnitKerja.Columns(1).Width = 535
        dgv_UnitKerja.Columns(1).HeaderText = "Nama Unit Kerja"
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
        DA = New OleDbDataAdapter("SELECT * FROM tbl_UnitKerja", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "unitkerja")
        DT = DS.Tables("unitkerja")
        dgv_UnitKerja.DataSource = DT
        dgv_UnitKerja.ReadOnly = True
        DS = Nothing
        DA = Nothing
        CONN.Close()
    End Sub

    Private Sub Form_CRUD_UnitKerja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsiData()
        HeaderData()
        BersihkanData()
    End Sub
    Private Sub Form_CRUD_UnitKerja_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        tb_NamaUnitKerja.Focus()
    End Sub


    Private Sub btn_Batal_Click(sender As Object, e As EventArgs) Handles btn_Batal.Click
        IsiData()
        BersihkanData()
    End Sub

    Private Sub btn_Simpan_Click(sender As Object, e As EventArgs) Handles btn_Simpan.Click
        If tb_NamaUnitKerja.Text = "" Then
            MsgBox("Nama unit masih kosong", MsgBoxStyle.Information, "Informasi")
            tb_NamaUnitKerja.Focus()
        Else
            Dim hasil As Integer = MessageBox.Show("Apakah anda yakin ingin menyimpan data ?", "Perhatian !", MessageBoxButtons.YesNo)
            If hasil = DialogResult.Yes Then
                Try
                    Call BUKA()
                    Dim STR As String = "INSERT INTO tbl_UnitKerja 
                                    (NamaUnit) 
                                 VALUES 
                                    (@nama_unit)"

                    CMD = New OleDbCommand
                    With CMD
                        .Connection = CONN
                        .CommandType = CommandType.Text
                        .CommandText = STR
                        .Parameters.Add(New OleDbParameter("@nama_unit", tb_NamaUnitKerja.Text))

                        CMD.Parameters("@nama_unit").Value = tb_NamaUnitKerja.Text
                        CMD.ExecuteNonQuery()
                    End With
                    MsgBox("Data berhasil disimpan !", MsgBoxStyle.Information, "Informasi")
                    BersihkanData()
                    IsiData()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End Try
            ElseIf hasil = DialogResult.No Then
                tb_NamaUnitKerja.Focus()
            End If
        End If
    End Sub

    Private Sub btn_Ubah_Click(sender As Object, e As EventArgs) Handles btn_Ubah.Click
        If tb_NamaUnitKerja.Text = "" Then
            MsgBox("Nama unit masih kosong", MsgBoxStyle.Information, "Informasi")
        Else
            Dim hasil As Integer = MessageBox.Show("Apakah anda yakin ingin mengubah data ?", "Perhatian !", MessageBoxButtons.YesNo)
            If hasil = DialogResult.Yes Then
                Try
                    Call BUKA()
                    Dim str As String = "UPDATE tbl_UnitKerja SET
                                NamaUnit = @nama_unit                        
                            WHERE
                                id = @id"

                    CMD = New OleDbCommand
                    With CMD
                        .Connection = CONN
                        .CommandType = CommandType.Text
                        .CommandText = str
                        .Parameters.Add(New OleDbParameter("@nama_unit", tb_NamaUnitKerja.Text))
                        .Parameters.Add(New OleDbParameter("@id", tb_id.Text))

                        CMD.Parameters("@nama_unit").Value = tb_NamaUnitKerja.Text
                        CMD.ExecuteNonQuery()
                    End With
                    MsgBox("Data berhasil diubah !", MsgBoxStyle.Information, "Informasi")
                    BersihkanData()
                    IsiData()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End Try
            ElseIf hasil = DialogResult.No Then
                tb_NamaUnitKerja.Focus()
            End If
        End If
    End Sub

    Private Sub btn_Hapus_Click(sender As Object, e As EventArgs) Handles btn_Hapus.Click
        Dim hasil As Integer = MessageBox.Show("Apakah anda yakin ingin menghapus data ?", "Perhatian !", MessageBoxButtons.YesNo)
        If hasil = DialogResult.Yes Then
            Try
                Call BUKA()
                Dim str As String = "DELETE * FROM tbl_UnitKerja WHERE id = @id"

                CMD = New OleDbCommand
                With CMD
                    .Connection = CONN
                    .CommandType = CommandType.Text
                    .CommandText = str
                    .Parameters.Add(New OleDbParameter("@id", tb_id.Text))
                    CMD.ExecuteNonQuery()
                End With
                MsgBox("Data berhasil dihapus !", MsgBoxStyle.Information, "Informasi")
                BersihkanData()
                IsiData()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        ElseIf hasil = DialogResult.No Then
            tb_NamaUnitKerja.Focus()
        End If

    End Sub


    Private Sub dgv_UnitKerja_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_UnitKerja.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgv_UnitKerja.Rows(e.RowIndex)
            tb_id.Text = row.Cells("id").Value.ToString
            tb_NamaUnitKerja.Text = row.Cells("NamaUnit").Value.ToString

            btn_Simpan.Enabled = False
            btn_Ubah.Enabled = True
            btn_Hapus.Enabled = True

            tb_NamaUnitKerja.Focus()
        End If
    End Sub

    Private Sub tb_NamaUnitKerja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_NamaUnitKerja.KeyPress
        If e.KeyChar = Chr(13) Then
            If tb_NamaUnitKerja.Text = "" Then
                MsgBox("Nama unit tidak boleh kosong", MsgBoxStyle.Information, "Informasi")
                tb_NamaUnitKerja.Focus()
            Else
                btn_Simpan.Focus()
            End If
        End If
    End Sub
End Class