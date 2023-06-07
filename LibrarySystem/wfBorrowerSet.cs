using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class wfBorrowerSet : Form
    {
        public wfBorrowerSet()
        {
            InitializeComponent();
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void wfBorrowerSet_Load(object sender, EventArgs e)
        {
            wfLogIn.q = "SELECT borrowertype FROM borrowertype order by borrowertype";
            wfLogIn.vSelect();
            for (int a = 0; a < wfLogIn.t.Rows.Count; a++)
                cbBorrowerType.Items.Add(wfLogIn.t.Rows[a][0]);
            if (wfBorrower.sSave == "Edit")
            {
                txtAddress.Text = wfBorrower.saddress;
                txtBorrowerID.Text = wfBorrower.sborrowerid;
                txtContactNum.Text = wfBorrower.sconnum;
                txtFname.Text = wfBorrower.sfname;
                txtLname.Text = wfBorrower.slname;
                txtMname.Text = wfBorrower.smname;
                cbBorrowerType.Text = wfBorrower.sborrowertype;
            }
        }

        private void bnSave_Click(object sender, EventArgs e)
        {
            if (wfBorrower.sSave == "Add")
            {
                wfLogIn.q = "insert into borrower (borrowerid, fname, mname, lname, connum, address, borrowertype) values ('" + txtBorrowerID.Text + "','" + txtFname.Text
                    + "','" + txtMname.Text
                    + "','" + txtLname.Text
                    + "','" + txtContactNum.Text
                    + "','" + txtAddress.Text
                    + "','" + cbBorrowerType.Text
                    + "')";
            }
            else
            {
                wfLogIn.q = "update borrower set fname = '" + txtFname.Text
                    + "', mname = '" + txtMname.Text
                    + "', lname = '" + txtLname.Text
                    + "', connum = '" + txtContactNum.Text
                    + "', address = '" + txtAddress.Text
                    + "', borrowerid = '" + txtBorrowerID.Text
                    + "', borrowertype = '" + cbBorrowerType.Text
                    + "' where borrowerid = '" + wfBorrower.sborrowerid + "'";
            }
            try
            {
                wfLogIn.vSelect();
                Close();
            }
            catch
            {
                MessageBox.Show("Please put a back slash (\\) before a single quote (').\n\nEx. Brooke\'s to Brooke\\\'s");
            }
        }
    }
}
