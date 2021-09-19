
namespace iPhone_repairshop.ui
{
    partial class ReceiptForm
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
            this.staffName = new Sunny.UI.UIComboBox();
            this.uiLine2 = new Sunny.UI.UILine();
            this.uiLine1 = new Sunny.UI.UILine();
            this.receiptClose = new Sunny.UI.UISymbolButton();
            this.receiptSave = new Sunny.UI.UISymbolButton();
            this.check6 = new Sunny.UI.UICheckBox();
            this.check5 = new Sunny.UI.UICheckBox();
            this.check4 = new Sunny.UI.UICheckBox();
            this.check3 = new Sunny.UI.UICheckBox();
            this.check2 = new Sunny.UI.UICheckBox();
            this.check1 = new Sunny.UI.UICheckBox();
            this.repairDetail = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel8 = new Sunny.UI.UISymbolLabel();
            this.iphoneYear = new Sunny.UI.UIComboBox();
            this.iphoneYearLabel = new Sunny.UI.UISymbolLabel();
            this.iphoneCapacity = new Sunny.UI.UIComboBox();
            this.iphoneCCLabel = new Sunny.UI.UISymbolLabel();
            this.iphoneNum = new Sunny.UI.UITextBox();
            this.serialNumLabel = new Sunny.UI.UISymbolLabel();
            this.iphoneModel = new Sunny.UI.UIComboBox();
            this.iphoneModelLabel = new Sunny.UI.UISymbolLabel();
            this.custDay = new Sunny.UI.UIComboBox();
            this.custMonth = new Sunny.UI.UIComboBox();
            this.custYear = new Sunny.UI.UIComboBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.custTelB = new Sunny.UI.UITextBox();
            this.custTelH = new Sunny.UI.UIComboBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.custName = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // staffName
            // 
            this.staffName.DataSource = null;
            this.staffName.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.staffName.FillColor = System.Drawing.Color.White;
            this.staffName.Font = new System.Drawing.Font("HCR Dotum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffName.Items.AddRange(new object[] {
            "원빈",
            "장동건",
            "이보영",
            "전지현",
            "송혜교",
            "송중기"});
            this.staffName.Location = new System.Drawing.Point(269, 569);
            this.staffName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.staffName.MinimumSize = new System.Drawing.Size(90, 0);
            this.staffName.Name = "staffName";
            this.staffName.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.staffName.RectColor = System.Drawing.Color.DarkSeaGreen;
            this.staffName.Size = new System.Drawing.Size(214, 39);
            this.staffName.Style = Sunny.UI.UIStyle.Custom;
            this.staffName.TabIndex = 71;
            this.staffName.Text = "선택";
            this.staffName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLine2
            // 
            this.uiLine2.FillColor = System.Drawing.Color.White;
            this.uiLine2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine2.LineColor = System.Drawing.Color.LightBlue;
            this.uiLine2.Location = new System.Drawing.Point(75, 545);
            this.uiLine2.Margin = new System.Windows.Forms.Padding(4);
            this.uiLine2.MinimumSize = new System.Drawing.Size(3, 3);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(841, 12);
            this.uiLine2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine2.TabIndex = 70;
            // 
            // uiLine1
            // 
            this.uiLine1.FillColor = System.Drawing.Color.White;
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine1.LineColor = System.Drawing.Color.LightBlue;
            this.uiLine1.Location = new System.Drawing.Point(74, 281);
            this.uiLine1.Margin = new System.Windows.Forms.Padding(4);
            this.uiLine1.MinimumSize = new System.Drawing.Size(3, 3);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(843, 16);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 69;
            // 
            // receiptClose
            // 
            this.receiptClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.receiptClose.FillColor = System.Drawing.Color.DarkGoldenrod;
            this.receiptClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.receiptClose.Location = new System.Drawing.Point(496, 745);
            this.receiptClose.Margin = new System.Windows.Forms.Padding(4);
            this.receiptClose.MinimumSize = new System.Drawing.Size(1, 2);
            this.receiptClose.Name = "receiptClose";
            this.receiptClose.RectColor = System.Drawing.Color.Silver;
            this.receiptClose.Size = new System.Drawing.Size(141, 52);
            this.receiptClose.Style = Sunny.UI.UIStyle.Custom;
            this.receiptClose.Symbol = 61457;
            this.receiptClose.TabIndex = 65;
            this.receiptClose.Text = "닫 기";
            // 
            // receiptSave
            // 
            this.receiptSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.receiptSave.FillColor = System.Drawing.Color.DarkGreen;
            this.receiptSave.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.receiptSave.Location = new System.Drawing.Point(256, 745);
            this.receiptSave.Margin = new System.Windows.Forms.Padding(4);
            this.receiptSave.MinimumSize = new System.Drawing.Size(1, 2);
            this.receiptSave.Name = "receiptSave";
            this.receiptSave.RectColor = System.Drawing.Color.Silver;
            this.receiptSave.Size = new System.Drawing.Size(150, 52);
            this.receiptSave.Style = Sunny.UI.UIStyle.Custom;
            this.receiptSave.Symbol = 61639;
            this.receiptSave.TabIndex = 64;
            this.receiptSave.Text = "저 장";
            this.receiptSave.Click += new System.EventHandler(this.receiptSave_Click);
            // 
            // check6
            // 
            this.check6.BackColor = System.Drawing.Color.Transparent;
            this.check6.CheckBoxColor = System.Drawing.Color.DarkSeaGreen;
            this.check6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check6.Font = new System.Drawing.Font("HCR Dotum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check6.Location = new System.Drawing.Point(715, 676);
            this.check6.Margin = new System.Windows.Forms.Padding(4);
            this.check6.MinimumSize = new System.Drawing.Size(1, 2);
            this.check6.Name = "check6";
            this.check6.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.check6.Size = new System.Drawing.Size(213, 44);
            this.check6.Style = Sunny.UI.UIStyle.Custom;
            this.check6.TabIndex = 62;
            this.check6.Text = "카메라";
            // 
            // check5
            // 
            this.check5.BackColor = System.Drawing.Color.Transparent;
            this.check5.CheckBoxColor = System.Drawing.Color.DarkSeaGreen;
            this.check5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check5.Font = new System.Drawing.Font("HCR Dotum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check5.Location = new System.Drawing.Point(496, 677);
            this.check5.Margin = new System.Windows.Forms.Padding(4);
            this.check5.MinimumSize = new System.Drawing.Size(1, 2);
            this.check5.Name = "check5";
            this.check5.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.check5.Size = new System.Drawing.Size(213, 44);
            this.check5.Style = Sunny.UI.UIStyle.Custom;
            this.check5.TabIndex = 61;
            this.check5.Text = "보드";
            // 
            // check4
            // 
            this.check4.BackColor = System.Drawing.Color.Transparent;
            this.check4.CheckBoxColor = System.Drawing.Color.DarkSeaGreen;
            this.check4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check4.Font = new System.Drawing.Font("HCR Dotum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check4.Location = new System.Drawing.Point(269, 676);
            this.check4.Margin = new System.Windows.Forms.Padding(4);
            this.check4.MinimumSize = new System.Drawing.Size(1, 2);
            this.check4.Name = "check4";
            this.check4.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.check4.Size = new System.Drawing.Size(213, 44);
            this.check4.Style = Sunny.UI.UIStyle.Custom;
            this.check4.TabIndex = 60;
            this.check4.Text = "에어팟";
            // 
            // check3
            // 
            this.check3.BackColor = System.Drawing.Color.Transparent;
            this.check3.CheckBoxColor = System.Drawing.Color.DarkSeaGreen;
            this.check3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check3.Font = new System.Drawing.Font("HCR Dotum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check3.Location = new System.Drawing.Point(715, 623);
            this.check3.Margin = new System.Windows.Forms.Padding(4);
            this.check3.MinimumSize = new System.Drawing.Size(1, 2);
            this.check3.Name = "check3";
            this.check3.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.check3.Size = new System.Drawing.Size(213, 44);
            this.check3.Style = Sunny.UI.UIStyle.Custom;
            this.check3.TabIndex = 59;
            this.check3.Text = "사운드";
            // 
            // check2
            // 
            this.check2.BackColor = System.Drawing.Color.Transparent;
            this.check2.CheckBoxColor = System.Drawing.Color.DarkSeaGreen;
            this.check2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check2.Font = new System.Drawing.Font("HCR Dotum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check2.Location = new System.Drawing.Point(496, 625);
            this.check2.Margin = new System.Windows.Forms.Padding(4);
            this.check2.MinimumSize = new System.Drawing.Size(1, 2);
            this.check2.Name = "check2";
            this.check2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.check2.Size = new System.Drawing.Size(213, 44);
            this.check2.Style = Sunny.UI.UIStyle.Custom;
            this.check2.TabIndex = 58;
            this.check2.Text = "배터리교체";
            // 
            // check1
            // 
            this.check1.BackColor = System.Drawing.Color.Transparent;
            this.check1.CheckBoxColor = System.Drawing.Color.DarkSeaGreen;
            this.check1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check1.Font = new System.Drawing.Font("HCR Dotum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check1.Location = new System.Drawing.Point(271, 625);
            this.check1.Margin = new System.Windows.Forms.Padding(4);
            this.check1.MinimumSize = new System.Drawing.Size(1, 2);
            this.check1.Name = "check1";
            this.check1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.check1.Size = new System.Drawing.Size(213, 44);
            this.check1.Style = Sunny.UI.UIStyle.Custom;
            this.check1.TabIndex = 57;
            this.check1.Text = "액정";
            // 
            // repairDetail
            // 
            this.repairDetail.BackColor = System.Drawing.Color.Transparent;
            this.repairDetail.Font = new System.Drawing.Font("HCR Dotum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairDetail.Location = new System.Drawing.Point(69, 623);
            this.repairDetail.Margin = new System.Windows.Forms.Padding(4);
            this.repairDetail.MinimumSize = new System.Drawing.Size(1, 2);
            this.repairDetail.Name = "repairDetail";
            this.repairDetail.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.repairDetail.Size = new System.Drawing.Size(149, 44);
            this.repairDetail.Symbol = 61613;
            this.repairDetail.SymbolColor = System.Drawing.Color.DarkSeaGreen;
            this.repairDetail.TabIndex = 56;
            this.repairDetail.Text = "수리항목";
            this.repairDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel8
            // 
            this.uiSymbolLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel8.Font = new System.Drawing.Font("HCR Dotum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel8.Location = new System.Drawing.Point(68, 569);
            this.uiSymbolLabel8.Margin = new System.Windows.Forms.Padding(4);
            this.uiSymbolLabel8.MinimumSize = new System.Drawing.Size(1, 2);
            this.uiSymbolLabel8.Name = "uiSymbolLabel8";
            this.uiSymbolLabel8.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel8.Size = new System.Drawing.Size(149, 44);
            this.uiSymbolLabel8.Symbol = 62142;
            this.uiSymbolLabel8.SymbolColor = System.Drawing.Color.DarkSeaGreen;
            this.uiSymbolLabel8.TabIndex = 55;
            this.uiSymbolLabel8.Text = "담당자";
            this.uiSymbolLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iphoneYear
            // 
            this.iphoneYear.DataSource = null;
            this.iphoneYear.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.iphoneYear.FillColor = System.Drawing.Color.White;
            this.iphoneYear.Font = new System.Drawing.Font("HCR Dotum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iphoneYear.Items.AddRange(new object[] {
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010"});
            this.iphoneYear.Location = new System.Drawing.Point(269, 484);
            this.iphoneYear.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.iphoneYear.MinimumSize = new System.Drawing.Size(90, 0);
            this.iphoneYear.Name = "iphoneYear";
            this.iphoneYear.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.iphoneYear.Size = new System.Drawing.Size(214, 39);
            this.iphoneYear.TabIndex = 54;
            this.iphoneYear.Text = "선택";
            this.iphoneYear.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iphoneYearLabel
            // 
            this.iphoneYearLabel.BackColor = System.Drawing.Color.Transparent;
            this.iphoneYearLabel.Font = new System.Drawing.Font("HCR Dotum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iphoneYearLabel.Location = new System.Drawing.Point(68, 484);
            this.iphoneYearLabel.Margin = new System.Windows.Forms.Padding(4);
            this.iphoneYearLabel.MinimumSize = new System.Drawing.Size(1, 2);
            this.iphoneYearLabel.Name = "iphoneYearLabel";
            this.iphoneYearLabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.iphoneYearLabel.Size = new System.Drawing.Size(149, 44);
            this.iphoneYearLabel.Symbol = 61555;
            this.iphoneYearLabel.SymbolColor = System.Drawing.Color.SteelBlue;
            this.iphoneYearLabel.TabIndex = 53;
            this.iphoneYearLabel.Text = "제조년도";
            this.iphoneYearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iphoneCapacity
            // 
            this.iphoneCapacity.DataSource = null;
            this.iphoneCapacity.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.iphoneCapacity.FillColor = System.Drawing.Color.White;
            this.iphoneCapacity.Font = new System.Drawing.Font("HCR Dotum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iphoneCapacity.Items.AddRange(new object[] {
            "16G",
            "32G",
            "64GB",
            "128GB",
            "256GB",
            "512GB",
            "1TB"});
            this.iphoneCapacity.Location = new System.Drawing.Point(269, 425);
            this.iphoneCapacity.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.iphoneCapacity.MinimumSize = new System.Drawing.Size(90, 0);
            this.iphoneCapacity.Name = "iphoneCapacity";
            this.iphoneCapacity.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.iphoneCapacity.Size = new System.Drawing.Size(214, 39);
            this.iphoneCapacity.TabIndex = 52;
            this.iphoneCapacity.Text = "선택";
            this.iphoneCapacity.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iphoneCCLabel
            // 
            this.iphoneCCLabel.BackColor = System.Drawing.Color.Transparent;
            this.iphoneCCLabel.Font = new System.Drawing.Font("HCR Dotum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iphoneCCLabel.Location = new System.Drawing.Point(68, 425);
            this.iphoneCCLabel.Margin = new System.Windows.Forms.Padding(4);
            this.iphoneCCLabel.MinimumSize = new System.Drawing.Size(1, 2);
            this.iphoneCCLabel.Name = "iphoneCCLabel";
            this.iphoneCCLabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.iphoneCCLabel.Size = new System.Drawing.Size(149, 44);
            this.iphoneCCLabel.Symbol = 62017;
            this.iphoneCCLabel.SymbolColor = System.Drawing.Color.SteelBlue;
            this.iphoneCCLabel.TabIndex = 51;
            this.iphoneCCLabel.Text = "Capacity";
            this.iphoneCCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iphoneNum
            // 
            this.iphoneNum.ButtonSymbol = 61761;
            this.iphoneNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iphoneNum.FillColor = System.Drawing.Color.White;
            this.iphoneNum.Font = new System.Drawing.Font("HCR Dotum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iphoneNum.Location = new System.Drawing.Point(269, 367);
            this.iphoneNum.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.iphoneNum.Maximum = 2147483647D;
            this.iphoneNum.Minimum = -2147483648D;
            this.iphoneNum.MinimumSize = new System.Drawing.Size(1, 2);
            this.iphoneNum.Name = "iphoneNum";
            this.iphoneNum.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.iphoneNum.Size = new System.Drawing.Size(214, 44);
            this.iphoneNum.TabIndex = 50;
            this.iphoneNum.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // serialNumLabel
            // 
            this.serialNumLabel.BackColor = System.Drawing.Color.Transparent;
            this.serialNumLabel.Font = new System.Drawing.Font("HCR Dotum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialNumLabel.Location = new System.Drawing.Point(66, 367);
            this.serialNumLabel.Margin = new System.Windows.Forms.Padding(4);
            this.serialNumLabel.MinimumSize = new System.Drawing.Size(1, 2);
            this.serialNumLabel.Name = "serialNumLabel";
            this.serialNumLabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.serialNumLabel.Size = new System.Drawing.Size(149, 44);
            this.serialNumLabel.Symbol = 62098;
            this.serialNumLabel.SymbolColor = System.Drawing.Color.SteelBlue;
            this.serialNumLabel.TabIndex = 49;
            this.serialNumLabel.Text = "시리얼 No.";
            this.serialNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iphoneModel
            // 
            this.iphoneModel.DataSource = null;
            this.iphoneModel.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.iphoneModel.FillColor = System.Drawing.Color.White;
            this.iphoneModel.Font = new System.Drawing.Font("HCR Dotum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iphoneModel.Items.AddRange(new object[] {
            "iPhone 6",
            "iPhone 6 Plus",
            "iPhone 7",
            "iPhone 7 Plus",
            "iPhone 8",
            "iPhone 8 Plus",
            "iPhone X",
            "iPhone XR",
            "iPhone XS",
            "iPhone XS Max",
            "iPhone 11",
            "iPhone 11 Pro",
            "iPhone 11 Pro Max",
            "iPhone SE (2nd)",
            "iPhone 12 mini",
            "iPhone 12",
            "iPhone 12 Pro",
            "iPhone 12 Pro Max",
            "iPhone 13 mini",
            "iPhone 13",
            "iPhone 13 Pro",
            "iPhone 13 Pro Max"});
            this.iphoneModel.Location = new System.Drawing.Point(272, 309);
            this.iphoneModel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.iphoneModel.MinimumSize = new System.Drawing.Size(90, 0);
            this.iphoneModel.Name = "iphoneModel";
            this.iphoneModel.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.iphoneModel.Size = new System.Drawing.Size(267, 39);
            this.iphoneModel.TabIndex = 48;
            this.iphoneModel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iphoneModelLabel
            // 
            this.iphoneModelLabel.BackColor = System.Drawing.Color.Transparent;
            this.iphoneModelLabel.Font = new System.Drawing.Font("HCR Dotum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iphoneModelLabel.Location = new System.Drawing.Point(68, 309);
            this.iphoneModelLabel.Margin = new System.Windows.Forms.Padding(4);
            this.iphoneModelLabel.MinimumSize = new System.Drawing.Size(1, 2);
            this.iphoneModelLabel.Name = "iphoneModelLabel";
            this.iphoneModelLabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.iphoneModelLabel.Size = new System.Drawing.Size(149, 44);
            this.iphoneModelLabel.Symbol = 61817;
            this.iphoneModelLabel.SymbolColor = System.Drawing.Color.SteelBlue;
            this.iphoneModelLabel.TabIndex = 47;
            this.iphoneModelLabel.Text = "아이폰모델";
            this.iphoneModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custDay
            // 
            this.custDay.DataSource = null;
            this.custDay.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.custDay.FillColor = System.Drawing.Color.White;
            this.custDay.Font = new System.Drawing.Font("HCR Dotum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custDay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.custDay.Location = new System.Drawing.Point(496, 220);
            this.custDay.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.custDay.MinimumSize = new System.Drawing.Size(90, 0);
            this.custDay.Name = "custDay";
            this.custDay.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.custDay.RectColor = System.Drawing.Color.IndianRed;
            this.custDay.Size = new System.Drawing.Size(97, 39);
            this.custDay.Style = Sunny.UI.UIStyle.Custom;
            this.custDay.TabIndex = 46;
            this.custDay.Text = "선택";
            this.custDay.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custMonth
            // 
            this.custMonth.DataSource = null;
            this.custMonth.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.custMonth.FillColor = System.Drawing.Color.White;
            this.custMonth.Font = new System.Drawing.Font("HCR Dotum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custMonth.Items.AddRange(new object[] {
            "12",
            "11",
            "10",
            "09",
            "08",
            "07",
            "06",
            "05",
            "04",
            "03",
            "02",
            "01"});
            this.custMonth.Location = new System.Drawing.Point(386, 220);
            this.custMonth.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.custMonth.MinimumSize = new System.Drawing.Size(90, 0);
            this.custMonth.Name = "custMonth";
            this.custMonth.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.custMonth.RectColor = System.Drawing.Color.IndianRed;
            this.custMonth.Size = new System.Drawing.Size(97, 39);
            this.custMonth.Style = Sunny.UI.UIStyle.Custom;
            this.custMonth.TabIndex = 45;
            this.custMonth.Text = "선택";
            this.custMonth.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custYear
            // 
            this.custYear.DataSource = null;
            this.custYear.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.custYear.FillColor = System.Drawing.Color.White;
            this.custYear.Font = new System.Drawing.Font("HCR Dotum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custYear.Items.AddRange(new object[] {
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990"});
            this.custYear.Location = new System.Drawing.Point(271, 220);
            this.custYear.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.custYear.MinimumSize = new System.Drawing.Size(90, 0);
            this.custYear.Name = "custYear";
            this.custYear.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.custYear.RectColor = System.Drawing.Color.IndianRed;
            this.custYear.Size = new System.Drawing.Size(97, 39);
            this.custYear.Style = Sunny.UI.UIStyle.Custom;
            this.custYear.TabIndex = 44;
            this.custYear.Text = "선택";
            this.custYear.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("HCR Dotum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel3.Location = new System.Drawing.Point(66, 219);
            this.uiSymbolLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 2);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(149, 44);
            this.uiSymbolLabel3.Symbol = 61949;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.IndianRed;
            this.uiSymbolLabel3.TabIndex = 43;
            this.uiSymbolLabel3.Text = "생년월일";
            this.uiSymbolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custTelB
            // 
            this.custTelB.ButtonSymbol = 61761;
            this.custTelB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.custTelB.FillColor = System.Drawing.Color.White;
            this.custTelB.Font = new System.Drawing.Font("HCR Dotum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custTelB.Location = new System.Drawing.Point(381, 166);
            this.custTelB.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.custTelB.Maximum = 2147483647D;
            this.custTelB.Minimum = -2147483648D;
            this.custTelB.MinimumSize = new System.Drawing.Size(1, 2);
            this.custTelB.Name = "custTelB";
            this.custTelB.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.custTelB.RectColor = System.Drawing.Color.IndianRed;
            this.custTelB.Size = new System.Drawing.Size(214, 39);
            this.custTelB.Style = Sunny.UI.UIStyle.Custom;
            this.custTelB.TabIndex = 42;
            this.custTelB.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custTelH
            // 
            this.custTelH.DataSource = null;
            this.custTelH.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.custTelH.FillColor = System.Drawing.Color.White;
            this.custTelH.Font = new System.Drawing.Font("HCR Dotum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custTelH.Items.AddRange(new object[] {
            "010",
            "011",
            "016"});
            this.custTelH.Location = new System.Drawing.Point(272, 166);
            this.custTelH.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.custTelH.MinimumSize = new System.Drawing.Size(90, 0);
            this.custTelH.Name = "custTelH";
            this.custTelH.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.custTelH.RectColor = System.Drawing.Color.IndianRed;
            this.custTelH.Size = new System.Drawing.Size(97, 39);
            this.custTelH.Style = Sunny.UI.UIStyle.Custom;
            this.custTelH.TabIndex = 41;
            this.custTelH.Text = "선택";
            this.custTelH.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("HCR Dotum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel2.Location = new System.Drawing.Point(68, 160);
            this.uiSymbolLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 2);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(149, 44);
            this.uiSymbolLabel2.Symbol = 57488;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.IndianRed;
            this.uiSymbolLabel2.TabIndex = 40;
            this.uiSymbolLabel2.Text = "전화번호";
            this.uiSymbolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("HCR Dotum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(69, 103);
            this.uiSymbolLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 2);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(149, 44);
            this.uiSymbolLabel1.Symbol = 62141;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.IndianRed;
            this.uiSymbolLabel1.TabIndex = 39;
            this.uiSymbolLabel1.Text = "이 름";
            this.uiSymbolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custName
            // 
            this.custName.ButtonSymbol = 61761;
            this.custName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.custName.FillColor = System.Drawing.Color.White;
            this.custName.Font = new System.Drawing.Font("HCR Dotum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custName.Location = new System.Drawing.Point(271, 103);
            this.custName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.custName.Maximum = 2147483647D;
            this.custName.Minimum = -2147483648D;
            this.custName.MinimumSize = new System.Drawing.Size(1, 2);
            this.custName.Name = "custName";
            this.custName.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.custName.RectColor = System.Drawing.Color.IndianRed;
            this.custName.Size = new System.Drawing.Size(214, 58);
            this.custName.Style = Sunny.UI.UIStyle.Custom;
            this.custName.TabIndex = 38;
            this.custName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 873);
            this.Controls.Add(this.staffName);
            this.Controls.Add(this.uiLine2);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.receiptClose);
            this.Controls.Add(this.receiptSave);
            this.Controls.Add(this.check6);
            this.Controls.Add(this.check5);
            this.Controls.Add(this.check4);
            this.Controls.Add(this.check3);
            this.Controls.Add(this.check2);
            this.Controls.Add(this.check1);
            this.Controls.Add(this.repairDetail);
            this.Controls.Add(this.uiSymbolLabel8);
            this.Controls.Add(this.iphoneYear);
            this.Controls.Add(this.iphoneYearLabel);
            this.Controls.Add(this.iphoneCapacity);
            this.Controls.Add(this.iphoneCCLabel);
            this.Controls.Add(this.iphoneNum);
            this.Controls.Add(this.serialNumLabel);
            this.Controls.Add(this.iphoneModel);
            this.Controls.Add(this.iphoneModelLabel);
            this.Controls.Add(this.custDay);
            this.Controls.Add(this.custMonth);
            this.Controls.Add(this.custYear);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.custTelB);
            this.Controls.Add(this.custTelH);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.custName);
            this.Name = "ReceiptForm";
            this.Text = "Add Customer";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIComboBox staffName;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UISymbolButton receiptClose;
        private Sunny.UI.UISymbolButton receiptSave;
        private Sunny.UI.UICheckBox check6;
        private Sunny.UI.UICheckBox check5;
        private Sunny.UI.UICheckBox check4;
        private Sunny.UI.UICheckBox check3;
        private Sunny.UI.UICheckBox check2;
        private Sunny.UI.UICheckBox check1;
        private Sunny.UI.UISymbolLabel repairDetail;
        private Sunny.UI.UISymbolLabel uiSymbolLabel8;
        private Sunny.UI.UIComboBox iphoneYear;
        private Sunny.UI.UISymbolLabel iphoneYearLabel;
        private Sunny.UI.UIComboBox iphoneCapacity;
        private Sunny.UI.UISymbolLabel iphoneCCLabel;
        private Sunny.UI.UITextBox iphoneNum;
        private Sunny.UI.UISymbolLabel serialNumLabel;
        private Sunny.UI.UIComboBox iphoneModel;
        private Sunny.UI.UISymbolLabel iphoneModelLabel;
        private Sunny.UI.UIComboBox custDay;
        private Sunny.UI.UIComboBox custMonth;
        private Sunny.UI.UIComboBox custYear;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UITextBox custTelB;
        private Sunny.UI.UIComboBox custTelH;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UITextBox custName;
    }
}