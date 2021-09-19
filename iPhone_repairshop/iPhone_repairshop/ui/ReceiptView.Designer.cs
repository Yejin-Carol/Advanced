
namespace iPhone_repairshop.ui
{
    partial class ReceiptView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.viewSearch = new CxFlatUI.CxFlatTextBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.viewModify = new Sunny.UI.UISymbolButton();
            this.viewDelete = new Sunny.UI.UISymbolButton();
            this.viewConfirm = new Sunny.UI.UISymbolButton();
            this.viewSearchAll = new Sunny.UI.UISymbolButton();
            this.viewSearchItem = new Sunny.UI.UISymbolButton();
            this.viewSelect = new Sunny.UI.UIComboBox();
            this.Search_btn = new Sunny.UI.UISymbolLabel();
            this.viewGrid = new Sunny.UI.UIDataGridView();
            this.gCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRepair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewList = new System.Windows.Forms.ListView();
            this.lCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.linDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lTotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lStaffName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lCustName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.viewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // viewSearch
            // 
            this.viewSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.viewSearch.Hint = "검색어를 입력하세요";
            this.viewSearch.Location = new System.Drawing.Point(421, 79);
            this.viewSearch.Margin = new System.Windows.Forms.Padding(4);
            this.viewSearch.MaxLength = 32767;
            this.viewSearch.Multiline = false;
            this.viewSearch.Name = "viewSearch";
            this.viewSearch.PasswordChar = '\0';
            this.viewSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.viewSearch.SelectedText = "";
            this.viewSearch.SelectionLength = 0;
            this.viewSearch.SelectionStart = 0;
            this.viewSearch.Size = new System.Drawing.Size(259, 48);
            this.viewSearch.TabIndex = 24;
            this.viewSearch.TabStop = false;
            this.viewSearch.UseSystemPasswordChar = false;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(35, 455);
            this.uiSymbolLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 2);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(210, 63);
            this.uiSymbolLabel2.Symbol = 61667;
            this.uiSymbolLabel2.TabIndex = 23;
            this.uiSymbolLabel2.Text = "상세 수리내역";
            // 
            // viewModify
            // 
            this.viewModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewModify.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewModify.Location = new System.Drawing.Point(688, 438);
            this.viewModify.Margin = new System.Windows.Forms.Padding(4);
            this.viewModify.MinimumSize = new System.Drawing.Size(1, 2);
            this.viewModify.Name = "viewModify";
            this.viewModify.Size = new System.Drawing.Size(150, 57);
            this.viewModify.TabIndex = 22;
            this.viewModify.Text = "수정";
            // 
            // viewDelete
            // 
            this.viewDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewDelete.FillColor = System.Drawing.Color.OrangeRed;
            this.viewDelete.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewDelete.Location = new System.Drawing.Point(846, 438);
            this.viewDelete.Margin = new System.Windows.Forms.Padding(4);
            this.viewDelete.MinimumSize = new System.Drawing.Size(1, 2);
            this.viewDelete.Name = "viewDelete";
            this.viewDelete.RectColor = System.Drawing.Color.OrangeRed;
            this.viewDelete.Size = new System.Drawing.Size(150, 57);
            this.viewDelete.Style = Sunny.UI.UIStyle.Custom;
            this.viewDelete.TabIndex = 21;
            this.viewDelete.Text = "삭제";
            // 
            // viewConfirm
            // 
            this.viewConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewConfirm.FillColor = System.Drawing.Color.LimeGreen;
            this.viewConfirm.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewConfirm.Location = new System.Drawing.Point(530, 438);
            this.viewConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.viewConfirm.MinimumSize = new System.Drawing.Size(1, 2);
            this.viewConfirm.Name = "viewConfirm";
            this.viewConfirm.RectColor = System.Drawing.Color.LimeGreen;
            this.viewConfirm.Size = new System.Drawing.Size(150, 57);
            this.viewConfirm.Style = Sunny.UI.UIStyle.Custom;
            this.viewConfirm.TabIndex = 20;
            this.viewConfirm.Text = "완료";
            // 
            // viewSearchAll
            // 
            this.viewSearchAll.BackColor = System.Drawing.Color.Transparent;
            this.viewSearchAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewSearchAll.FillColor = System.Drawing.Color.Transparent;
            this.viewSearchAll.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewSearchAll.ForeColor = System.Drawing.Color.DarkBlue;
            this.viewSearchAll.Location = new System.Drawing.Point(847, 85);
            this.viewSearchAll.Margin = new System.Windows.Forms.Padding(4);
            this.viewSearchAll.MinimumSize = new System.Drawing.Size(1, 2);
            this.viewSearchAll.Name = "viewSearchAll";
            this.viewSearchAll.Size = new System.Drawing.Size(150, 57);
            this.viewSearchAll.Style = Sunny.UI.UIStyle.Custom;
            this.viewSearchAll.Symbol = 61454;
            this.viewSearchAll.TabIndex = 19;
            this.viewSearchAll.Text = "전체 검색";
            // 
            // viewSearchItem
            // 
            this.viewSearchItem.BackColor = System.Drawing.Color.Transparent;
            this.viewSearchItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewSearchItem.FillColor = System.Drawing.Color.Transparent;
            this.viewSearchItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewSearchItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.viewSearchItem.ForeHoverColor = System.Drawing.Color.RoyalBlue;
            this.viewSearchItem.ForePressColor = System.Drawing.Color.RoyalBlue;
            this.viewSearchItem.ForeSelectedColor = System.Drawing.Color.RoyalBlue;
            this.viewSearchItem.Location = new System.Drawing.Point(688, 85);
            this.viewSearchItem.Margin = new System.Windows.Forms.Padding(4);
            this.viewSearchItem.MinimumSize = new System.Drawing.Size(1, 2);
            this.viewSearchItem.Name = "viewSearchItem";
            this.viewSearchItem.Size = new System.Drawing.Size(150, 57);
            this.viewSearchItem.Style = Sunny.UI.UIStyle.Custom;
            this.viewSearchItem.Symbol = 61454;
            this.viewSearchItem.TabIndex = 18;
            this.viewSearchItem.Text = "검색";
            // 
            // viewSelect
            // 
            this.viewSelect.DataSource = null;
            this.viewSelect.FillColor = System.Drawing.Color.White;
            this.viewSelect.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewSelect.Items.AddRange(new object[] {
            "고객명",
            "고객차량번호"});
            this.viewSelect.Location = new System.Drawing.Point(225, 85);
            this.viewSelect.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.viewSelect.MinimumSize = new System.Drawing.Size(90, 0);
            this.viewSelect.Name = "viewSelect";
            this.viewSelect.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.viewSelect.Size = new System.Drawing.Size(186, 39);
            this.viewSelect.TabIndex = 17;
            this.viewSelect.Text = "검색항목 선택";
            this.viewSelect.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Search_btn
            // 
            this.Search_btn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.Search_btn.Location = new System.Drawing.Point(35, 85);
            this.Search_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Search_btn.MinimumSize = new System.Drawing.Size(1, 2);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.Search_btn.Size = new System.Drawing.Size(180, 51);
            this.Search_btn.Symbol = 61563;
            this.Search_btn.TabIndex = 16;
            this.Search_btn.Text = "검색항목";
            // 
            // viewGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.viewGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.viewGrid.BackgroundColor = System.Drawing.Color.White;
            this.viewGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.viewGrid.ColumnHeadersHeight = 32;
            this.viewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.viewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gCount,
            this.gRepair,
            this.gPrice});
            this.viewGrid.EnableHeadersVisualStyles = false;
            this.viewGrid.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.viewGrid.Location = new System.Drawing.Point(35, 527);
            this.viewGrid.Margin = new System.Windows.Forms.Padding(4);
            this.viewGrid.Name = "viewGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.viewGrid.RowHeadersWidth = 62;
            this.viewGrid.RowHeight = 29;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.viewGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.viewGrid.RowTemplate.Height = 29;
            this.viewGrid.SelectedIndex = -1;
            this.viewGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewGrid.ShowGridLine = true;
            this.viewGrid.Size = new System.Drawing.Size(961, 270);
            this.viewGrid.TabIndex = 15;
            // 
            // gCount
            // 
            this.gCount.HeaderText = "번호";
            this.gCount.MinimumWidth = 8;
            this.gCount.Name = "gCount";
            this.gCount.Width = 150;
            // 
            // gRepair
            // 
            this.gRepair.HeaderText = "수리항목";
            this.gRepair.MinimumWidth = 8;
            this.gRepair.Name = "gRepair";
            this.gRepair.Width = 150;
            // 
            // gPrice
            // 
            this.gPrice.HeaderText = "수리비용";
            this.gPrice.MinimumWidth = 8;
            this.gPrice.Name = "gPrice";
            this.gPrice.Width = 150;
            // 
            // viewList
            // 
            this.viewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lCount,
            this.linDate,
            this.lTotalPrice,
            this.lStaffName,
            this.lCustName});
            this.viewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.viewList.FullRowSelect = true;
            this.viewList.HideSelection = false;
            this.viewList.Location = new System.Drawing.Point(37, 171);
            this.viewList.Margin = new System.Windows.Forms.Padding(4);
            this.viewList.Name = "viewList";
            this.viewList.Size = new System.Drawing.Size(960, 242);
            this.viewList.TabIndex = 14;
            this.viewList.UseCompatibleStateImageBehavior = false;
            this.viewList.View = System.Windows.Forms.View.Details;
            // 
            // lCount
            // 
            this.lCount.Text = "번호";
            // 
            // linDate
            // 
            this.linDate.Text = "접수날짜";
            this.linDate.Width = 150;
            // 
            // lTotalPrice
            // 
            this.lTotalPrice.Text = "총결제금액";
            this.lTotalPrice.Width = 120;
            // 
            // lStaffName
            // 
            this.lStaffName.Text = "담당자";
            this.lStaffName.Width = 100;
            // 
            // lCustName
            // 
            this.lCustName.Text = "고객명";
            this.lCustName.Width = 100;
            // 
            // ReceiptView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 859);
            this.Controls.Add(this.viewSearch);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.viewModify);
            this.Controls.Add(this.viewDelete);
            this.Controls.Add(this.viewConfirm);
            this.Controls.Add(this.viewSearchAll);
            this.Controls.Add(this.viewSearchItem);
            this.Controls.Add(this.viewSelect);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.viewGrid);
            this.Controls.Add(this.viewList);
            this.Name = "ReceiptView";
            this.Text = "ReceiptView";
            ((System.ComponentModel.ISupportInitialize)(this.viewGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatTextBox viewSearch;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolButton viewModify;
        private Sunny.UI.UISymbolButton viewDelete;
        private Sunny.UI.UISymbolButton viewConfirm;
        private Sunny.UI.UISymbolButton viewSearchAll;
        private Sunny.UI.UISymbolButton viewSearchItem;
        private Sunny.UI.UIComboBox viewSelect;
        private Sunny.UI.UISymbolLabel Search_btn;
        private Sunny.UI.UIDataGridView viewGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn gCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRepair;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPrice;
        private System.Windows.Forms.ListView viewList;
        private System.Windows.Forms.ColumnHeader lCount;
        private System.Windows.Forms.ColumnHeader linDate;
        private System.Windows.Forms.ColumnHeader lTotalPrice;
        private System.Windows.Forms.ColumnHeader lStaffName;
        private System.Windows.Forms.ColumnHeader lCustName;
    }
}