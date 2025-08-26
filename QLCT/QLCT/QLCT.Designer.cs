namespace QLCT
{
    partial class QLCT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonThoat = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageThongTin = new System.Windows.Forms.TabPage();
            this.textBoxHoVaTen = new System.Windows.Forms.TextBox();
            this.textBoxTuoi = new System.Windows.Forms.TextBox();
            this.textBoxMaNguoiDung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSanPham = new System.Windows.Forms.TabPage();
            this.dataGridViewSanPham = new System.Windows.Forms.DataGridView();
            this.textBoxTenSanPham = new System.Windows.Forms.TextBox();
            this.textBoxMaSanPham = new System.Windows.Forms.TextBox();
            this.labelTenSanPham = new System.Windows.Forms.Label();
            this.labelMaSanPham = new System.Windows.Forms.Label();
            this.tabPageDuDinh = new System.Windows.Forms.TabPage();
            this.textBoxSoDu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxMaNguoiDungDD = new System.Windows.Forms.TextBox();
            this.textBoxTenDuDinh = new System.Windows.Forms.TextBox();
            this.textBoxThoiGianDuDinh = new System.Windows.Forms.TextBox();
            this.textBoxTienDuDinh = new System.Windows.Forms.TextBox();
            this.textBoxMaDuDinh = new System.Windows.Forms.TextBox();
            this.labelMaNguoiDung = new System.Windows.Forms.Label();
            this.labelTenDungDinh = new System.Windows.Forms.Label();
            this.labelTienDuDinh = new System.Windows.Forms.Label();
            this.labelThoiGianDuDinh = new System.Windows.Forms.Label();
            this.dataGridViewDuDinh = new System.Windows.Forms.DataGridView();
            this.labelMaduDinh = new System.Windows.Forms.Label();
            this.tabPageGiaoDichDuDinh = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxMaSanPhamGDDD = new System.Windows.Forms.TextBox();
            this.textBoxGia = new System.Windows.Forms.TextBox();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.textBoxMaDuDinhGDDD = new System.Windows.Forms.TextBox();
            this.textBoxMaGiaoDichDuDinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewGiaoDichDuDinh = new System.Windows.Forms.DataGridView();
            this.buttonThemMoi = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonThayDoi = new System.Windows.Forms.Button();
            this.buttonTim = new System.Windows.Forms.Button();
            this.buttonLamMoi = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageThongTin.SuspendLayout();
            this.tabPageSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).BeginInit();
            this.tabPageDuDinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDuDinh)).BeginInit();
            this.tabPageGiaoDichDuDinh.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiaoDichDuDinh)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.Color.LightCoral;
            this.buttonThoat.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(901, 520);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(142, 56);
            this.buttonThoat.TabIndex = 0;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageThongTin);
            this.tabControlMain.Controls.Add(this.tabPageSanPham);
            this.tabControlMain.Controls.Add(this.tabPageDuDinh);
            this.tabControlMain.Controls.Add(this.tabPageGiaoDichDuDinh);
            this.tabControlMain.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(39, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(820, 595);
            this.tabControlMain.TabIndex = 2;
            this.tabControlMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlMain_Selected);
            // 
            // tabPageThongTin
            // 
            this.tabPageThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPageThongTin.Controls.Add(this.textBoxHoVaTen);
            this.tabPageThongTin.Controls.Add(this.textBoxTuoi);
            this.tabPageThongTin.Controls.Add(this.textBoxMaNguoiDung);
            this.tabPageThongTin.Controls.Add(this.label3);
            this.tabPageThongTin.Controls.Add(this.label2);
            this.tabPageThongTin.Controls.Add(this.label1);
            this.tabPageThongTin.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageThongTin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tabPageThongTin.Location = new System.Drawing.Point(4, 35);
            this.tabPageThongTin.Name = "tabPageThongTin";
            this.tabPageThongTin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThongTin.Size = new System.Drawing.Size(812, 556);
            this.tabPageThongTin.TabIndex = 0;
            this.tabPageThongTin.Text = "Thông tin";
            // 
            // textBoxHoVaTen
            // 
            this.textBoxHoVaTen.Location = new System.Drawing.Point(369, 241);
            this.textBoxHoVaTen.Name = "textBoxHoVaTen";
            this.textBoxHoVaTen.Size = new System.Drawing.Size(265, 39);
            this.textBoxHoVaTen.TabIndex = 5;
            // 
            // textBoxTuoi
            // 
            this.textBoxTuoi.Location = new System.Drawing.Point(369, 366);
            this.textBoxTuoi.Name = "textBoxTuoi";
            this.textBoxTuoi.Size = new System.Drawing.Size(100, 39);
            this.textBoxTuoi.TabIndex = 4;
            // 
            // textBoxMaNguoiDung
            // 
            this.textBoxMaNguoiDung.Location = new System.Drawing.Point(369, 119);
            this.textBoxMaNguoiDung.Name = "textBoxMaNguoiDung";
            this.textBoxMaNguoiDung.ReadOnly = true;
            this.textBoxMaNguoiDung.Size = new System.Drawing.Size(222, 39);
            this.textBoxMaNguoiDung.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tuổi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã người dùng";
            // 
            // tabPageSanPham
            // 
            this.tabPageSanPham.BackColor = System.Drawing.Color.NavajoWhite;
            this.tabPageSanPham.Controls.Add(this.dataGridViewSanPham);
            this.tabPageSanPham.Controls.Add(this.textBoxTenSanPham);
            this.tabPageSanPham.Controls.Add(this.textBoxMaSanPham);
            this.tabPageSanPham.Controls.Add(this.labelTenSanPham);
            this.tabPageSanPham.Controls.Add(this.labelMaSanPham);
            this.tabPageSanPham.Location = new System.Drawing.Point(4, 35);
            this.tabPageSanPham.Name = "tabPageSanPham";
            this.tabPageSanPham.Size = new System.Drawing.Size(812, 556);
            this.tabPageSanPham.TabIndex = 3;
            this.tabPageSanPham.Text = "Sản phẩm";
            // 
            // dataGridViewSanPham
            // 
            this.dataGridViewSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSanPham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSanPham.Location = new System.Drawing.Point(30, 340);
            this.dataGridViewSanPham.Name = "dataGridViewSanPham";
            this.dataGridViewSanPham.RowHeadersWidth = 51;
            this.dataGridViewSanPham.RowTemplate.Height = 24;
            this.dataGridViewSanPham.Size = new System.Drawing.Size(748, 189);
            this.dataGridViewSanPham.TabIndex = 4;
            this.dataGridViewSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSanPham_CellClick);
            // 
            // textBoxTenSanPham
            // 
            this.textBoxTenSanPham.Location = new System.Drawing.Point(295, 122);
            this.textBoxTenSanPham.Name = "textBoxTenSanPham";
            this.textBoxTenSanPham.Size = new System.Drawing.Size(161, 34);
            this.textBoxTenSanPham.TabIndex = 3;
            // 
            // textBoxMaSanPham
            // 
            this.textBoxMaSanPham.Location = new System.Drawing.Point(295, 65);
            this.textBoxMaSanPham.Name = "textBoxMaSanPham";
            this.textBoxMaSanPham.Size = new System.Drawing.Size(161, 34);
            this.textBoxMaSanPham.TabIndex = 2;
            // 
            // labelTenSanPham
            // 
            this.labelTenSanPham.AutoSize = true;
            this.labelTenSanPham.Location = new System.Drawing.Point(59, 122);
            this.labelTenSanPham.Name = "labelTenSanPham";
            this.labelTenSanPham.Size = new System.Drawing.Size(143, 26);
            this.labelTenSanPham.TabIndex = 1;
            this.labelTenSanPham.Text = "Tên sản phẩm";
            // 
            // labelMaSanPham
            // 
            this.labelMaSanPham.AutoSize = true;
            this.labelMaSanPham.Location = new System.Drawing.Point(59, 65);
            this.labelMaSanPham.Name = "labelMaSanPham";
            this.labelMaSanPham.Size = new System.Drawing.Size(136, 26);
            this.labelMaSanPham.TabIndex = 0;
            this.labelMaSanPham.Text = "Mã sản phẩm";
            // 
            // tabPageDuDinh
            // 
            this.tabPageDuDinh.BackColor = System.Drawing.Color.LightYellow;
            this.tabPageDuDinh.Controls.Add(this.textBoxSoDu);
            this.tabPageDuDinh.Controls.Add(this.label9);
            this.tabPageDuDinh.Controls.Add(this.textBoxMaNguoiDungDD);
            this.tabPageDuDinh.Controls.Add(this.textBoxTenDuDinh);
            this.tabPageDuDinh.Controls.Add(this.textBoxThoiGianDuDinh);
            this.tabPageDuDinh.Controls.Add(this.textBoxTienDuDinh);
            this.tabPageDuDinh.Controls.Add(this.textBoxMaDuDinh);
            this.tabPageDuDinh.Controls.Add(this.labelMaNguoiDung);
            this.tabPageDuDinh.Controls.Add(this.labelTenDungDinh);
            this.tabPageDuDinh.Controls.Add(this.labelTienDuDinh);
            this.tabPageDuDinh.Controls.Add(this.labelThoiGianDuDinh);
            this.tabPageDuDinh.Controls.Add(this.dataGridViewDuDinh);
            this.tabPageDuDinh.Controls.Add(this.labelMaduDinh);
            this.tabPageDuDinh.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tabPageDuDinh.Location = new System.Drawing.Point(4, 35);
            this.tabPageDuDinh.Name = "tabPageDuDinh";
            this.tabPageDuDinh.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDuDinh.Size = new System.Drawing.Size(812, 556);
            this.tabPageDuDinh.TabIndex = 1;
            this.tabPageDuDinh.Text = "Dự định";
            // 
            // textBoxSoDu
            // 
            this.textBoxSoDu.Location = new System.Drawing.Point(600, 163);
            this.textBoxSoDu.Name = "textBoxSoDu";
            this.textBoxSoDu.ReadOnly = true;
            this.textBoxSoDu.Size = new System.Drawing.Size(182, 34);
            this.textBoxSoDu.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Orange;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(519, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 33);
            this.label9.TabIndex = 12;
            this.label9.Text = "Số dư";
            // 
            // textBoxMaNguoiDungDD
            // 
            this.textBoxMaNguoiDungDD.Location = new System.Drawing.Point(244, 111);
            this.textBoxMaNguoiDungDD.Name = "textBoxMaNguoiDungDD";
            this.textBoxMaNguoiDungDD.ReadOnly = true;
            this.textBoxMaNguoiDungDD.Size = new System.Drawing.Size(228, 34);
            this.textBoxMaNguoiDungDD.TabIndex = 11;
            // 
            // textBoxTenDuDinh
            // 
            this.textBoxTenDuDinh.Location = new System.Drawing.Point(244, 68);
            this.textBoxTenDuDinh.Name = "textBoxTenDuDinh";
            this.textBoxTenDuDinh.Size = new System.Drawing.Size(228, 34);
            this.textBoxTenDuDinh.TabIndex = 10;
            // 
            // textBoxThoiGianDuDinh
            // 
            this.textBoxThoiGianDuDinh.Location = new System.Drawing.Point(244, 206);
            this.textBoxThoiGianDuDinh.Name = "textBoxThoiGianDuDinh";
            this.textBoxThoiGianDuDinh.Size = new System.Drawing.Size(228, 34);
            this.textBoxThoiGianDuDinh.TabIndex = 9;
            this.textBoxThoiGianDuDinh.Text = "tháng/ngày/năm";
            this.textBoxThoiGianDuDinh.Click += new System.EventHandler(this.textBoxThoiGianDuDinh_Click);
            // 
            // textBoxTienDuDinh
            // 
            this.textBoxTienDuDinh.Location = new System.Drawing.Point(244, 160);
            this.textBoxTienDuDinh.Name = "textBoxTienDuDinh";
            this.textBoxTienDuDinh.Size = new System.Drawing.Size(228, 34);
            this.textBoxTienDuDinh.TabIndex = 8;
            // 
            // textBoxMaDuDinh
            // 
            this.textBoxMaDuDinh.Location = new System.Drawing.Point(244, 25);
            this.textBoxMaDuDinh.Name = "textBoxMaDuDinh";
            this.textBoxMaDuDinh.Size = new System.Drawing.Size(228, 34);
            this.textBoxMaDuDinh.TabIndex = 6;
            // 
            // labelMaNguoiDung
            // 
            this.labelMaNguoiDung.AutoSize = true;
            this.labelMaNguoiDung.Location = new System.Drawing.Point(41, 119);
            this.labelMaNguoiDung.Name = "labelMaNguoiDung";
            this.labelMaNguoiDung.Size = new System.Drawing.Size(153, 26);
            this.labelMaNguoiDung.TabIndex = 5;
            this.labelMaNguoiDung.Text = "Mã người dùng";
            // 
            // labelTenDungDinh
            // 
            this.labelTenDungDinh.AutoSize = true;
            this.labelTenDungDinh.Location = new System.Drawing.Point(41, 76);
            this.labelTenDungDinh.Name = "labelTenDungDinh";
            this.labelTenDungDinh.Size = new System.Drawing.Size(126, 26);
            this.labelTenDungDinh.TabIndex = 4;
            this.labelTenDungDinh.Text = "Tên dự định";
            // 
            // labelTienDuDinh
            // 
            this.labelTienDuDinh.AutoSize = true;
            this.labelTienDuDinh.Location = new System.Drawing.Point(41, 168);
            this.labelTienDuDinh.Name = "labelTienDuDinh";
            this.labelTienDuDinh.Size = new System.Drawing.Size(155, 26);
            this.labelTienDuDinh.TabIndex = 3;
            this.labelTienDuDinh.Text = "Số tiền dự định";
            // 
            // labelThoiGianDuDinh
            // 
            this.labelThoiGianDuDinh.AutoSize = true;
            this.labelThoiGianDuDinh.Location = new System.Drawing.Point(41, 214);
            this.labelThoiGianDuDinh.Name = "labelThoiGianDuDinh";
            this.labelThoiGianDuDinh.Size = new System.Drawing.Size(179, 26);
            this.labelThoiGianDuDinh.TabIndex = 2;
            this.labelThoiGianDuDinh.Text = "Thời gian dự định";
            // 
            // dataGridViewDuDinh
            // 
            this.dataGridViewDuDinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDuDinh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDuDinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDuDinh.Location = new System.Drawing.Point(25, 308);
            this.dataGridViewDuDinh.Name = "dataGridViewDuDinh";
            this.dataGridViewDuDinh.RowHeadersWidth = 51;
            this.dataGridViewDuDinh.RowTemplate.Height = 24;
            this.dataGridViewDuDinh.Size = new System.Drawing.Size(757, 230);
            this.dataGridViewDuDinh.TabIndex = 1;
            this.dataGridViewDuDinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDuDinh_CellClick);
            // 
            // labelMaduDinh
            // 
            this.labelMaduDinh.AutoSize = true;
            this.labelMaduDinh.Location = new System.Drawing.Point(41, 33);
            this.labelMaduDinh.Name = "labelMaduDinh";
            this.labelMaduDinh.Size = new System.Drawing.Size(119, 26);
            this.labelMaduDinh.TabIndex = 0;
            this.labelMaduDinh.Text = "Mã dự định";
            // 
            // tabPageGiaoDichDuDinh
            // 
            this.tabPageGiaoDichDuDinh.BackColor = System.Drawing.Color.PowderBlue;
            this.tabPageGiaoDichDuDinh.Controls.Add(this.groupBox1);
            this.tabPageGiaoDichDuDinh.Controls.Add(this.dataGridViewGiaoDichDuDinh);
            this.tabPageGiaoDichDuDinh.Location = new System.Drawing.Point(4, 35);
            this.tabPageGiaoDichDuDinh.Name = "tabPageGiaoDichDuDinh";
            this.tabPageGiaoDichDuDinh.Size = new System.Drawing.Size(812, 556);
            this.tabPageGiaoDichDuDinh.TabIndex = 2;
            this.tabPageGiaoDichDuDinh.Text = "Giao dịch dự định";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxMaSanPhamGDDD);
            this.groupBox1.Controls.Add(this.textBoxGia);
            this.groupBox1.Controls.Add(this.textBoxSoLuong);
            this.groupBox1.Controls.Add(this.textBoxMaDuDinhGDDD);
            this.groupBox1.Controls.Add(this.textBoxMaGiaoDichDuDinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(26, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 268);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // textBoxMaSanPhamGDDD
            // 
            this.textBoxMaSanPhamGDDD.Location = new System.Drawing.Point(272, 67);
            this.textBoxMaSanPhamGDDD.Name = "textBoxMaSanPhamGDDD";
            this.textBoxMaSanPhamGDDD.Size = new System.Drawing.Size(234, 34);
            this.textBoxMaSanPhamGDDD.TabIndex = 10;
            // 
            // textBoxGia
            // 
            this.textBoxGia.Location = new System.Drawing.Point(272, 210);
            this.textBoxGia.Name = "textBoxGia";
            this.textBoxGia.Size = new System.Drawing.Size(234, 34);
            this.textBoxGia.TabIndex = 9;
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Location = new System.Drawing.Point(272, 161);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(234, 34);
            this.textBoxSoLuong.TabIndex = 8;
            // 
            // textBoxMaDuDinhGDDD
            // 
            this.textBoxMaDuDinhGDDD.Location = new System.Drawing.Point(272, 115);
            this.textBoxMaDuDinhGDDD.Name = "textBoxMaDuDinhGDDD";
            this.textBoxMaDuDinhGDDD.Size = new System.Drawing.Size(234, 34);
            this.textBoxMaDuDinhGDDD.TabIndex = 7;
            // 
            // textBoxMaGiaoDichDuDinh
            // 
            this.textBoxMaGiaoDichDuDinh.Location = new System.Drawing.Point(272, 22);
            this.textBoxMaGiaoDichDuDinh.Name = "textBoxMaGiaoDichDuDinh";
            this.textBoxMaGiaoDichDuDinh.Size = new System.Drawing.Size(234, 34);
            this.textBoxMaGiaoDichDuDinh.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã giao dịch dự định";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "Số lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 26);
            this.label8.TabIndex = 5;
            this.label8.Text = "Mã dự định";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 26);
            this.label7.TabIndex = 4;
            this.label7.Text = "Mã sản phẩm";
            // 
            // dataGridViewGiaoDichDuDinh
            // 
            this.dataGridViewGiaoDichDuDinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewGiaoDichDuDinh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewGiaoDichDuDinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGiaoDichDuDinh.Location = new System.Drawing.Point(26, 304);
            this.dataGridViewGiaoDichDuDinh.Name = "dataGridViewGiaoDichDuDinh";
            this.dataGridViewGiaoDichDuDinh.RowHeadersWidth = 51;
            this.dataGridViewGiaoDichDuDinh.RowTemplate.Height = 24;
            this.dataGridViewGiaoDichDuDinh.Size = new System.Drawing.Size(757, 234);
            this.dataGridViewGiaoDichDuDinh.TabIndex = 0;
            this.dataGridViewGiaoDichDuDinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGiaoDichDuDinh_CellClick);
            // 
            // buttonThemMoi
            // 
            this.buttonThemMoi.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonThemMoi.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemMoi.Location = new System.Drawing.Point(901, 136);
            this.buttonThemMoi.Name = "buttonThemMoi";
            this.buttonThemMoi.Size = new System.Drawing.Size(142, 48);
            this.buttonThemMoi.TabIndex = 2;
            this.buttonThemMoi.Text = "Thêm mới";
            this.buttonThemMoi.UseVisualStyleBackColor = false;
            this.buttonThemMoi.Click += new System.EventHandler(this.buttonThemMoi_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonXoa.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(901, 316);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(142, 50);
            this.buttonXoa.TabIndex = 3;
            this.buttonXoa.Text = "Xoá";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonThayDoi
            // 
            this.buttonThayDoi.BackColor = System.Drawing.Color.Gold;
            this.buttonThayDoi.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThayDoi.Location = new System.Drawing.Point(901, 221);
            this.buttonThayDoi.Name = "buttonThayDoi";
            this.buttonThayDoi.Size = new System.Drawing.Size(142, 50);
            this.buttonThayDoi.TabIndex = 4;
            this.buttonThayDoi.Text = "Thay đổi";
            this.buttonThayDoi.UseVisualStyleBackColor = false;
            this.buttonThayDoi.Click += new System.EventHandler(this.buttonThayDoi_Click);
            // 
            // buttonTim
            // 
            this.buttonTim.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonTim.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTim.Location = new System.Drawing.Point(901, 408);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(142, 52);
            this.buttonTim.TabIndex = 7;
            this.buttonTim.Text = "Tìm kiếm";
            this.buttonTim.UseVisualStyleBackColor = false;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.BackColor = System.Drawing.Color.Cyan;
            this.buttonLamMoi.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLamMoi.Location = new System.Drawing.Point(901, 47);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.Size = new System.Drawing.Size(142, 51);
            this.buttonLamMoi.TabIndex = 8;
            this.buttonLamMoi.Text = "Làm mới";
            this.buttonLamMoi.UseVisualStyleBackColor = false;
            this.buttonLamMoi.Click += new System.EventHandler(this.buttonLamMoi_Click);
            // 
            // QLCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.buttonLamMoi);
            this.Controls.Add(this.buttonTim);
            this.Controls.Add(this.buttonThayDoi);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonThemMoi);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.buttonThoat);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLCT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chi tiêu dự định";
            this.Load += new System.EventHandler(this.QLCT_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageThongTin.ResumeLayout(false);
            this.tabPageThongTin.PerformLayout();
            this.tabPageSanPham.ResumeLayout(false);
            this.tabPageSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).EndInit();
            this.tabPageDuDinh.ResumeLayout(false);
            this.tabPageDuDinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDuDinh)).EndInit();
            this.tabPageGiaoDichDuDinh.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiaoDichDuDinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageThongTin;
        private System.Windows.Forms.TabPage tabPageDuDinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageGiaoDichDuDinh;
        private System.Windows.Forms.DataGridView dataGridViewDuDinh;
        private System.Windows.Forms.Label labelMaduDinh;
        private System.Windows.Forms.DataGridView dataGridViewGiaoDichDuDinh;
        private System.Windows.Forms.Label labelTenDungDinh;
        private System.Windows.Forms.Label labelTienDuDinh;
        private System.Windows.Forms.Label labelThoiGianDuDinh;
        private System.Windows.Forms.Label labelMaNguoiDung;
        private System.Windows.Forms.TextBox textBoxMaNguoiDungDD;
        private System.Windows.Forms.TextBox textBoxTenDuDinh;
        private System.Windows.Forms.TextBox textBoxThoiGianDuDinh;
        private System.Windows.Forms.TextBox textBoxTienDuDinh;
        private System.Windows.Forms.TextBox textBoxMaDuDinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHoVaTen;
        private System.Windows.Forms.TextBox textBoxTuoi;
        private System.Windows.Forms.TextBox textBoxMaNguoiDung;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageSanPham;
        private System.Windows.Forms.DataGridView dataGridViewSanPham;
        private System.Windows.Forms.TextBox textBoxTenSanPham;
        private System.Windows.Forms.TextBox textBoxMaSanPham;
        private System.Windows.Forms.Label labelTenSanPham;
        private System.Windows.Forms.Label labelMaSanPham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxMaSanPhamGDDD;
        private System.Windows.Forms.TextBox textBoxGia;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.TextBox textBoxMaDuDinhGDDD;
        private System.Windows.Forms.TextBox textBoxMaGiaoDichDuDinh;
        private System.Windows.Forms.Button buttonThemMoi;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThayDoi;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.Button buttonLamMoi;
        private System.Windows.Forms.TextBox textBoxSoDu;
        private System.Windows.Forms.Label label9;
    }
}