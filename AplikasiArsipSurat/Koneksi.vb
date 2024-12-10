Imports System.Data.OleDb
Module Koneksi
    Public CONN As OleDbConnection
    Public CMD As OleDbCommand
    Public DA As OleDbDataAdapter
    Public DR As OleDbDataReader
    Public DS As DataSet
    Public DT As DataTable
    Dim LokasiDB As String

    Sub BUKA()
        LokasiDB = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db_sipas.accdb"
        CONN = New OleDb.OleDbConnection(LokasiDB)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
            'MsgBox("Koneksi Berhasil")
        Else
            MsgBox("Koneksi Gagal")
        End If
    End Sub
End Module
