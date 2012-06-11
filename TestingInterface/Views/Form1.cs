using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestingInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            treeView1.Nodes[1].Tag = new DimBox();
            treeView1.Nodes[0].Tag = new MemberBox();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Control cont = (Control)treeView1.SelectedNode.Tag;
            tableLayoutPanel1.Controls.Add(cont,1,0);
            cont.Dock = DockStyle.Fill;
        }

        private void memberBox1_Load(object sender, EventArgs e)
        {

        }
    }
}
