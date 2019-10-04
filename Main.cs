
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Assessment2Q5
{
    public partial class frmMain : Form
    {

        public class ReverseComparer : IComparer
        {
            // Call CaseInsensitiveComparer.Compare with the parameters reversed.
            public int Compare(Object x, Object y)
            {
                return (new CaseInsensitiveComparer()).Compare(y, x);
            }
        }

        String[] words = { "The", "QUICK", "BROWN", "FOX", "jumps",
                         "over", "the", "lazy", "dog" };

        IComparer revComparer = new ReverseComparer();


        public frmMain()
        {
            InitializeComponent();
        }



        private void FrmMain_Load(object sender, EventArgs e)
        {
            foreach (string count in words)
                lstOrginalOrder.Items.Add(Convert.ToString(count));

             Array.Sort(words, 1, 3);
            foreach (string count in words)
                lstComparer.Items.Add(Convert.ToString(count));



            Array.Sort(words, revComparer);
            foreach (string count in words)
                lstReverseComparer.Items.Add(Convert.ToString(count));

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
