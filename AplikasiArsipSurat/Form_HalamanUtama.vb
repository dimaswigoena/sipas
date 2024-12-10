Public Class Form_HalamanUtama

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub

    Private Sub UnitKerjaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnitKerjaToolStripMenuItem.Click
        Form_CRUD_UnitKerja.ShowDialog()
    End Sub

    Private Sub btn_SuratMasuk_Click(sender As Object, e As EventArgs) Handles btn_SuratMasuk.Click
        'Form_DaftarSuratMasuk.ShowDialog()
        Form_CRUD_SuratMasuk.ShowDialog()
    End Sub

    Private Sub btn_SuratKeluar_Click(sender As Object, e As EventArgs) Handles btn_SuratKeluar.Click
        Form_CRUD_SuratKeluar.ShowDialog()
    End Sub
End Class

