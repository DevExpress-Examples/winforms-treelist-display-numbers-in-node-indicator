using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.Utils.Drawing;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        private DataTable CreateTable()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            tbl.Columns.Add("ParentID", typeof(int));
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 5; j++)
                    tbl.Rows.Add(new object[] { String.Format("Name{0}", 10*i+j), 10*i+j + 1, 3 - 10*i+j, DateTime.Now.AddDays(10*i+j), 10*i+j });
            return tbl;
        }
   

        public Form1()
        {
            InitializeComponent();
            treeList1.DataSource = CreateTable();
        }

        private void treeList1_CustomDrawNodeIndicator(object sender, DevExpress.XtraTreeList.CustomDrawNodeIndicatorEventArgs e)
        {
            TreeList tree = sender as DevExpress.XtraTreeList.TreeList;
            IndicatorObjectInfoArgs args = e.ObjectArgs as IndicatorObjectInfoArgs;
            args.DisplayText = (tree.GetVisibleIndexByNode(e.Node) + 1).ToString();
            e.ImageIndex = -1;
        }
    }
}