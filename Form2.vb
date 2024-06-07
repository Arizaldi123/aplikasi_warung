Public Class Form2

    Public Sub TambahDataKeDataGridView(ByVal data As String())
        DataGridView1.Rows.Add(data)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim nama As String = selectedRow.Cells("nama").Value.ToString()
            Dim makan As String = selectedRow.Cells("menumakan").Value.ToString()
            Dim minum As String = selectedRow.Cells("menuminum").Value.ToString()
            Dim jumlahmakan As String = selectedRow.Cells("jumlahmakan").Value.ToString()
            Dim jumlahminum As String = selectedRow.Cells("jumlahminum").Value.ToString()
            Dim totalharga As String = selectedRow.Cells("totalharga").Value.ToString()
            Dim kembalian As String = selectedRow.Cells("kembalian").Value.ToString()
            txtpem.Text = nama
            cbomakanan.Text = makan
            cbominuman.Text = minum
            txtjumlahbeli.Text = jumlahmakan
            txtjumlahbeliminum.Text = jumlahminum
            txttotalharga.Text = totalharga
            txtkembalian.Text = kembalian
        End If
    End Sub
    Private Sub updatedata()
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            selectedRow.Cells("nama").Value = txtpem.Text
            selectedRow.Cells("menumakan").Value = cbomakanan.Text
            selectedRow.Cells("menuminum").Value = cbominuman.Text
            selectedRow.Cells("jumlahmakan").Value = txtjumlahbeli.Text
            selectedRow.Cells("jumlahminum").Value = txtjumlahbeliminum.Text
            selectedRow.Cells("totalharga").Value = txttotalharga.Text
            selectedRow.Cells("kembalian").Value = txtkembalian.Text
        Else
            MessageBox.Show("Pilih baris yang ingin diperbarui.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub hapusdata()
        If DataGridView1.SelectedRows.Count > 0 Then

            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
        Else
            MessageBox.Show("Pilih baris yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        updatedata()
    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        updatedata()
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Call hapusdata()
    End Sub

    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class
