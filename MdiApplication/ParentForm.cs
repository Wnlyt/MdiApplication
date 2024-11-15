﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MdiApplication
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            switch (e.ClickedItem.Tag.ToString()) { case "NewDoc": ChildForm newChild = new ChildForm(); newChild.MdiParent = this; newChild.Show(); newChild.Text = newChild.Text + " " + ++openDocuments; break; case "Cascade": this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade); break; case "Title": this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal); break; }
        }
    }
}
