using iPhone_repairshop.common;
using iPhone_repairshop.handler;
using iPhone_repairshop.ui;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iPhone_repairshop
{
    public partial class MainForm : MaterialForm//상속 받음
    {
        //싱글톤(Singleton)
        OraHandler ora;
        ReceiptAdapter adapter;
        public MainForm()
        {
            InitializeComponent();
            CommUtil.initTheme(this);//this MainForm
            ora = new OraHandler();
            adapter = new ReceiptAdapter(ora);
        }

        private void custAdd_Click(object sender, EventArgs e)
        {
            new ReceiptForm(adapter).ShowDialog();
            adapter.addReceiptDb();
        }

        private void repairView_Click(object sender, EventArgs e)
        {
            new ReceiptView(adapter).ShowDialog();
        }
    }
}
