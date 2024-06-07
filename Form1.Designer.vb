<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Label6 = New Label()
        Label7 = New Label()
        txtpem = New TextBox()
        cbomakanan = New ComboBox()
        cbominuman = New ComboBox()
        txtjumlahbeli = New TextBox()
        txttotalharga = New TextBox()
        txtkembalian = New TextBox()
        btnhitungharga = New Button()
        btnlaporan = New Button()
        txtharga = New TextBox()
        Label9 = New Label()
        txthargaminuman = New TextBox()
        Label10 = New Label()
        txtuangpembeli = New TextBox()
        Label11 = New Label()
        btnhitungkembali = New Button()
        btnsimpan = New Button()
        txtjumlahbeliminum = New TextBox()
        Label12 = New Label()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(286, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(215, 25)
        Label1.TabIndex = 0
        Label1.Text = "Warung Makan Barokah"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(309, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(165, 25)
        Label3.TabIndex = 2
        Label3.Text = "Selamat Datang di"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(38, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 20)
        Label2.TabIndex = 3
        Label2.Text = "Nama Pembeli"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(37, 189)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 20)
        Label4.TabIndex = 4
        Label4.Text = "Menu Makanan"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(35, 243)
        Label5.Name = "Label5"
        Label5.Size = New Size(124, 20)
        Label5.TabIndex = 5
        Label5.Text = "Menu Minuman"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(442, 138)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 20)
        Label6.TabIndex = 7
        Label6.Text = "Total Harga"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(442, 226)
        Label7.Name = "Label7"
        Label7.Size = New Size(89, 20)
        Label7.TabIndex = 8
        Label7.Text = "Kembalian"
        ' 
        ' txtpem
        ' 
        txtpem.Location = New Point(187, 139)
        txtpem.Name = "txtpem"
        txtpem.Size = New Size(241, 23)
        txtpem.TabIndex = 9
        ' 
        ' cbomakanan
        ' 
        cbomakanan.FormattingEnabled = True
        cbomakanan.Items.AddRange(New Object() {"Soto Ayam", "Soto Daging", "Rawon", "Pecel", "Nasi Goreng"})
        cbomakanan.Location = New Point(187, 190)
        cbomakanan.Name = "cbomakanan"
        cbomakanan.Size = New Size(241, 23)
        cbomakanan.TabIndex = 10
        ' 
        ' cbominuman
        ' 
        cbominuman.FormattingEnabled = True
        cbominuman.Items.AddRange(New Object() {"Es Teh", "Teh Anget", "Es Jeruk", "Jeruk Anget", "Air Mineral "})
        cbominuman.Location = New Point(187, 244)
        cbominuman.Name = "cbominuman"
        cbominuman.Size = New Size(241, 23)
        cbominuman.TabIndex = 11
        ' 
        ' txtjumlahbeli
        ' 
        txtjumlahbeli.Location = New Point(187, 285)
        txtjumlahbeli.Name = "txtjumlahbeli"
        txtjumlahbeli.Size = New Size(241, 23)
        txtjumlahbeli.TabIndex = 13
        ' 
        ' txttotalharga
        ' 
        txttotalharga.Location = New Point(547, 140)
        txttotalharga.Name = "txttotalharga"
        txttotalharga.Size = New Size(241, 23)
        txttotalharga.TabIndex = 14
        ' 
        ' txtkembalian
        ' 
        txtkembalian.Location = New Point(547, 226)
        txtkembalian.Name = "txtkembalian"
        txtkembalian.Size = New Size(241, 23)
        txtkembalian.TabIndex = 15
        ' 
        ' btnhitungharga
        ' 
        btnhitungharga.Location = New Point(547, 386)
        btnhitungharga.Name = "btnhitungharga"
        btnhitungharga.Size = New Size(172, 23)
        btnhitungharga.TabIndex = 16
        btnhitungharga.Text = "Hitung Total Harga"
        btnhitungharga.UseVisualStyleBackColor = True
        ' 
        ' btnlaporan
        ' 
        btnlaporan.Location = New Point(547, 415)
        btnlaporan.Name = "btnlaporan"
        btnlaporan.Size = New Size(172, 23)
        btnlaporan.TabIndex = 17
        btnlaporan.Text = "Lihat Laporan"
        btnlaporan.UseVisualStyleBackColor = True
        ' 
        ' txtharga
        ' 
        txtharga.Location = New Point(187, 368)
        txtharga.Name = "txtharga"
        txtharga.Size = New Size(241, 23)
        txtharga.TabIndex = 19
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(38, 367)
        Label9.Name = "Label9"
        Label9.Size = New Size(127, 20)
        Label9.TabIndex = 18
        Label9.Text = "Harga Makanan"
        ' 
        ' txthargaminuman
        ' 
        txthargaminuman.Location = New Point(187, 412)
        txthargaminuman.Name = "txthargaminuman"
        txthargaminuman.Size = New Size(241, 23)
        txthargaminuman.TabIndex = 21
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(38, 411)
        Label10.Name = "Label10"
        Label10.Size = New Size(129, 20)
        Label10.TabIndex = 20
        Label10.Text = "Harga Minuman"
        ' 
        ' txtuangpembeli
        ' 
        txtuangpembeli.Location = New Point(547, 186)
        txtuangpembeli.Name = "txtuangpembeli"
        txtuangpembeli.Size = New Size(241, 23)
        txtuangpembeli.TabIndex = 23
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Historic", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(442, 186)
        Label11.Name = "Label11"
        Label11.Size = New Size(90, 13)
        Label11.TabIndex = 22
        Label11.Text = "Uang Pembeli"
        ' 
        ' btnhitungkembali
        ' 
        btnhitungkembali.Location = New Point(547, 357)
        btnhitungkembali.Name = "btnhitungkembali"
        btnhitungkembali.Size = New Size(172, 23)
        btnhitungkembali.TabIndex = 24
        btnhitungkembali.Text = "hitung kembalian"
        btnhitungkembali.UseVisualStyleBackColor = True
        ' 
        ' btnsimpan
        ' 
        btnsimpan.Location = New Point(547, 328)
        btnsimpan.Name = "btnsimpan"
        btnsimpan.Size = New Size(162, 23)
        btnsimpan.TabIndex = 25
        btnsimpan.Text = "Simpan Data"
        btnsimpan.UseVisualStyleBackColor = True
        ' 
        ' txtjumlahbeliminum
        ' 
        txtjumlahbeliminum.Location = New Point(187, 328)
        txtjumlahbeliminum.Name = "txtjumlahbeliminum"
        txtjumlahbeliminum.Size = New Size(241, 23)
        txtjumlahbeliminum.TabIndex = 27
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(-2, 332)
        Label12.Name = "Label12"
        Label12.Size = New Size(183, 15)
        Label12.TabIndex = 26
        Label12.Text = "Jumlah Pembelian Minuman"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(-2, 288)
        Label8.Name = "Label8"
        Label8.Size = New Size(180, 15)
        Label8.TabIndex = 28
        Label8.Text = "Jumlah Pembelian Makanan"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label8)
        Controls.Add(txtjumlahbeliminum)
        Controls.Add(Label12)
        Controls.Add(btnsimpan)
        Controls.Add(btnhitungkembali)
        Controls.Add(txtuangpembeli)
        Controls.Add(Label11)
        Controls.Add(txthargaminuman)
        Controls.Add(Label10)
        Controls.Add(txtharga)
        Controls.Add(Label9)
        Controls.Add(btnlaporan)
        Controls.Add(btnhitungharga)
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
        Controls.Add(Label3)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtpem As TextBox
    Friend WithEvents cbomakanan As ComboBox
    Friend WithEvents cbominuman As ComboBox
    Friend WithEvents txtjumlahbeli As TextBox
    Friend WithEvents txttotalharga As TextBox
    Friend WithEvents txtkembalian As TextBox
    Friend WithEvents btnhitungharga As Button
    Friend WithEvents btnlaporan As Button
    Friend WithEvents txtharga As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txthargaminuman As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtuangpembeli As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnhitungkembali As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents txtjumlahbeliminum As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
End Class
