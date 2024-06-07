<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label3 = New Label()
        DataGridView1 = New DataGridView()
        nama = New DataGridViewTextBoxColumn()
        menumakan = New DataGridViewTextBoxColumn()
        menuminum = New DataGridViewTextBoxColumn()
        jumlahmakan = New DataGridViewTextBoxColumn()
        jumlahminum = New DataGridViewTextBoxColumn()
        totalharga = New DataGridViewTextBoxColumn()
        kembalian = New DataGridViewTextBoxColumn()
        Label8 = New Label()
        txtjumlahbeliminum = New TextBox()
        Label12 = New Label()
        btnsimpan = New Button()
        txtkembalian = New TextBox()
        txttotalharga = New TextBox()
        txtjumlahbeli = New TextBox()
        cbominuman = New ComboBox()
        cbomakanan = New ComboBox()
        txtpem = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        btnhapus = New Button()
        btnupdate = New Button()
        btnkembali = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(322, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(137, 25)
        Label3.TabIndex = 32
        Label3.Text = "Form Laporan "
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {nama, menumakan, menuminum, jumlahmakan, jumlahminum, totalharga, kembalian})
        DataGridView1.Location = New Point(12, 288)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(790, 150)
        DataGridView1.TabIndex = 33
        ' 
        ' nama
        ' 
        nama.HeaderText = "nama"
        nama.Name = "nama"
        ' 
        ' menumakan
        ' 
        menumakan.HeaderText = "makanan"
        menumakan.Name = "menumakan"
        ' 
        ' menuminum
        ' 
        menuminum.HeaderText = "minuman"
        menuminum.Name = "menuminum"
        ' 
        ' jumlahmakan
        ' 
        jumlahmakan.HeaderText = "beli makan"
        jumlahmakan.Name = "jumlahmakan"
        ' 
        ' jumlahminum
        ' 
        jumlahminum.HeaderText = "beli minum"
        jumlahminum.Name = "jumlahminum"
        ' 
        ' totalharga
        ' 
        totalharga.HeaderText = "total harga"
        totalharga.Name = "totalharga"
        ' 
        ' kembalian
        ' 
        kembalian.HeaderText = "Kembalian"
        kembalian.Name = "kembalian"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(1, 202)
        Label8.Name = "Label8"
        Label8.Size = New Size(180, 15)
        Label8.TabIndex = 57
        Label8.Text = "Jumlah Pembelian Makanan"
        ' 
        ' txtjumlahbeliminum
        ' 
        txtjumlahbeliminum.Location = New Point(190, 237)
        txtjumlahbeliminum.Name = "txtjumlahbeliminum"
        txtjumlahbeliminum.Size = New Size(241, 23)
        txtjumlahbeliminum.TabIndex = 56
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(1, 241)
        Label12.Name = "Label12"
        Label12.Size = New Size(183, 15)
        Label12.TabIndex = 55
        Label12.Text = "Jumlah Pembelian Minuman"
        ' 
        ' btnsimpan
        ' 
        btnsimpan.Location = New Point(554, 149)
        btnsimpan.Name = "btnsimpan"
        btnsimpan.Size = New Size(155, 23)
        btnsimpan.TabIndex = 54
        btnsimpan.Text = "Simpan Data"
        btnsimpan.UseVisualStyleBackColor = True
        ' 
        ' txtkembalian
        ' 
        txtkembalian.Location = New Point(538, 100)
        txtkembalian.Name = "txtkembalian"
        txtkembalian.Size = New Size(241, 23)
        txtkembalian.TabIndex = 44
        ' 
        ' txttotalharga
        ' 
        txttotalharga.Location = New Point(538, 54)
        txttotalharga.Name = "txttotalharga"
        txttotalharga.Size = New Size(241, 23)
        txttotalharga.TabIndex = 43
        ' 
        ' txtjumlahbeli
        ' 
        txtjumlahbeli.Location = New Point(190, 199)
        txtjumlahbeli.Name = "txtjumlahbeli"
        txtjumlahbeli.Size = New Size(241, 23)
        txtjumlahbeli.TabIndex = 42
        ' 
        ' cbominuman
        ' 
        cbominuman.FormattingEnabled = True
        cbominuman.Items.AddRange(New Object() {"Es Teh", "Teh Anget", "Es Jeruk", "Jeruk Anget", "Air Mineral "})
        cbominuman.Location = New Point(178, 158)
        cbominuman.Name = "cbominuman"
        cbominuman.Size = New Size(241, 23)
        cbominuman.TabIndex = 41
        ' 
        ' cbomakanan
        ' 
        cbomakanan.FormattingEnabled = True
        cbomakanan.Items.AddRange(New Object() {"Soto Ayam", "Soto Daging", "Rawon", "Pecel", "Nasi Goreng"})
        cbomakanan.Location = New Point(178, 104)
        cbomakanan.Name = "cbomakanan"
        cbomakanan.Size = New Size(241, 23)
        cbomakanan.TabIndex = 40
        ' 
        ' txtpem
        ' 
        txtpem.Location = New Point(178, 53)
        txtpem.Name = "txtpem"
        txtpem.Size = New Size(241, 23)
        txtpem.TabIndex = 39
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(433, 100)
        Label7.Name = "Label7"
        Label7.Size = New Size(89, 20)
        Label7.TabIndex = 38
        Label7.Text = "Kembalian"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(433, 52)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 20)
        Label6.TabIndex = 37
        Label6.Text = "Total Harga"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(26, 157)
        Label5.Name = "Label5"
        Label5.Size = New Size(124, 20)
        Label5.TabIndex = 36
        Label5.Text = "Menu Minuman"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(28, 103)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 20)
        Label4.TabIndex = 35
        Label4.Text = "Menu Makanan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(29, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 20)
        Label2.TabIndex = 34
        Label2.Text = "Nama Pembeli"
        ' 
        ' btnhapus
        ' 
        btnhapus.Location = New Point(554, 178)
        btnhapus.Name = "btnhapus"
        btnhapus.Size = New Size(155, 23)
        btnhapus.TabIndex = 58
        btnhapus.Text = "Hapus Data"
        btnhapus.UseVisualStyleBackColor = True
        ' 
        ' btnupdate
        ' 
        btnupdate.Location = New Point(554, 207)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(153, 23)
        btnupdate.TabIndex = 59
        btnupdate.Text = "Update Data"
        btnupdate.UseVisualStyleBackColor = True
        ' 
        ' btnkembali
        ' 
        btnkembali.Location = New Point(551, 245)
        btnkembali.Name = "btnkembali"
        btnkembali.Size = New Size(158, 23)
        btnkembali.TabIndex = 60
        btnkembali.Text = "Kembali "
        btnkembali.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnkembali)
        Controls.Add(btnupdate)
        Controls.Add(btnhapus)
        Controls.Add(Label8)
        Controls.Add(txtjumlahbeliminum)
        Controls.Add(Label12)
        Controls.Add(btnsimpan)
        Controls.Add(txtkembalian)
        Controls.Add(txttotalharga)
        Controls.Add(txtjumlahbeli)
        Controls.Add(cbominuman)
        Controls.Add(cbomakanan)
        Controls.Add(txtpem)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(DataGridView1)
        Controls.Add(Label3)
        Name = "Form2"
        Text = "Form2"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents menumakan As DataGridViewTextBoxColumn
    Friend WithEvents menuminum As DataGridViewTextBoxColumn
    Friend WithEvents jumlahmakan As DataGridViewTextBoxColumn
    Friend WithEvents jumlahminum As DataGridViewTextBoxColumn
    Friend WithEvents totalharga As DataGridViewTextBoxColumn
    Friend WithEvents kembalian As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents txtjumlahbeliminum As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnsimpan As Button
    Friend WithEvents txtkembalian As TextBox
    Friend WithEvents txttotalharga As TextBox
    Friend WithEvents txtjumlahbeli As TextBox
    Friend WithEvents cbominuman As ComboBox
    Friend WithEvents cbomakanan As ComboBox
    Friend WithEvents txtpem As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnkembali As Button
End Class
