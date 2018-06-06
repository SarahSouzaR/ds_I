using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atividade1_7 {

    public partial class frmAtividades : Form
    {
        public frmAtividades()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Exer1 e1 = new Exer1();
            e1.MdiParent = this;
            e1.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Exer2 e2 = new Exer2();
            e2.MdiParent = this;
            e2.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Exer3 e3 = new Exer3();
            e3.MdiParent = this;
            e3.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Exer4 e4 = new Exer4();
            e4.MdiParent = this;
            e4.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Exer5 e5 = new Exer5();
            e5.MdiParent = this;
            e5.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Exer6 e6 = new Exer6();
            e6.MdiParent = this;
            e6.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Exer7 e7 = new Exer7();
            e7.MdiParent = this;
            e7.Show();
        }

    }
}
