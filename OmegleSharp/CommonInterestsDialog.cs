using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OmegleSharp
{
    public partial class CommonInterestsDialog : Form
    {
        public List<string> Interests { get; set; }
        public CommonInterestsDialog()
        {
            InitializeComponent();
        }
        private void btnAddtag_Click(object sender, EventArgs e)
        {
            Interests.Add(tbAddTag.Text);
            tbAddTag.Clear();
            refreshdata();
        }
        //removes selected tag
        private void btnRemovetag_Click(object sender, EventArgs e)
        {
            if (lbTags.SelectedItem != null){
                Interests.RemoveAt(lbTags.SelectedIndex);
                refreshdata();
            }
        }

        private void CommonInterestsDialog_Load(object sender, EventArgs e)
        {
            refreshdata();
        }
        private void refreshdata()
        {
            lbTags.DataSource = null;
            lbTags.Items.Clear();
            lbTags.DataSource = Interests;
        }
    }
}
