Public Class Form1
    Dim form2 As New Form2()

    Sub tambahdata()
        Dim namapembeli = txtpem.Text
        Dim menumakanan = cbomakanan.Text
        Dim menuminuman = cbominuman.Text
        Dim jumlahmakan = txtjumlahbeli.Text
        Dim jumlahminum = txtjumlahbeliminum.Text
        Dim totalharga = txttotalharga.Text
        Dim uangpembeli = txtuangpembeli.Text
        Dim kembalian = txtkembalian.Text

        Dim data As String() = {namapembeli, menumakanan, menuminuman, jumlahmakan, jumlahminum, totalharga, kembalian}
        form2.TambahDataKeDataGridView(data)

        '  If Not form2.Visible Then
        'form2.Show()
        '  End If
    End Sub



    Sub hitungharga()
        Dim hargamakanan As Double = CDbl(txtharga.Text)
        Dim hargaminuman As Double = CDbl(txthargaminuman.Text)
        Dim jumlahpembelian As Double = CDbl(txtjumlahbeli.Text)
        Dim jumlahpembelianminum As Double = CDbl(txtjumlahbeliminum.Text)
        Dim subtotal As Double = hargamakanan * jumlahpembelian + hargaminuman * jumlahpembelianminum
        txttotalharga.Text = subtotal.ToString()
    End Sub


    Sub hargamakanan()
        If cbomakanan.Text = "Soto Ayam" Then
            txtharga.Text = "15000"
        ElseIf cbomakanan.Text = "Soto Daging" Then
            txtharga.Text = "20000"
        ElseIf cbomakanan.Text = "Rawon" Then
            txtharga.Text = "17000"
        ElseIf cbomakanan.Text = "Pecel" Then
            txtharga.Text = "10000"
        ElseIf cbomakanan.Text = "Nasi Goreng" Then
            txtharga.Text = "12000"
        ElseIf cbominuman.Text = "Es Teh" Then
            txtharga.Text = "4000"
        ElseIf cbominuman.Text = "Teh Anget" Then
            txtharga.Text = "3000"
        ElseIf cbominuman.Text = "Es Jeruk" Then
            txtharga.Text = "5000"
        ElseIf cbominuman.Text = "Jeruk Anget" Then
            txtharga.Text = "4000"
        ElseIf cbominuman.Text = "Air Mineral" Then
            txtharga.Text = "4000"
        End If
    End Sub
    Sub hargaminuman()
        If cbominuman.Text = "Es Teh" Then
            txthargaminuman.Text = "4000"
        ElseIf cbominuman.Text = "Teh Anget" Then
            txthargaminuman.Text = "3000"
        ElseIf cbominuman.Text = "Es Jeruk" Then
            txthargaminuman.Text = "5000"
        ElseIf cbominuman.Text = "Jeruk Anget" Then
            txthargaminuman.Text = "4000"
        ElseIf cbominuman.Text = "Air Mineral" Then
            txthargaminuman.Text = "4000"
        End If
    End Sub
    Private Sub cbomakanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomakanan.SelectedIndexChanged
        hargamakanan()
    End Sub
    Private Sub cbominuman_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbominuman.SelectedIndexChanged
        hargaminuman()
    End Sub

    Sub hitungkembalian()
        Dim uangpembeli As Double = CDbl(txtuangpembeli.Text)
        Dim totalharga As Double = CDbl(txttotalharga.Text)
        Dim kembalian As Double = uangpembeli - totalharga
        txtkembalian.Text = kembalian.ToString()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call hargamakanan()
        Call hargaminuman()
    End Sub


    Private Sub btnhitungkembali_Click(sender As Object, e As EventArgs) Handles btnhitungkembali.Click
        Call hitungkembalian()
    End Sub

    Private Sub btnsimpan_Click_1(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Call tambahdata()
    End Sub

    Private Sub btnhitungharga_Click(sender As Object, e As EventArgs) Handles btnhitungharga.Click
        Call hitungharga()
    End Sub

    Private Sub btnlaporan_Click(sender As Object, e As EventArgs) Handles btnlaporan.Click
        form2.Show()
        Me.Hide()
    End Sub
End Class
