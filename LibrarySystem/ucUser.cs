using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class ucUser : UserControl
    {
        public ucUser()
        {
            InitializeComponent();
        }


        private void bnSearch_Click(object sender, EventArgs e)
        {
            ucUser_Load(sender, e);
        }
        ToolTip tt = new ToolTip();
        int iCurCell;
        private void bnApply_Click(object sender, EventArgs e)
        {
            iCurCell = dgUser.CurrentCell.RowIndex;
            if (dgUser.Rows[iCurCell].Cells[4].Value.ToString() == "Admin")
            {
                MessageBox.Show("You can't change an admin account", "Invalid Operation");
            }
            else
            {
                if (cbUstatus.Text == "User Status")
                {
                    MessageBox.Show("Please Select User Status", "Invalid User Status");
                    cbUstatus.Focus();
                }
                else
                {
                    wfLogIn.q = "update user set ustatus = '" + cbUstatus.Text
                        + "' where userid = '"
                        + dgUser.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    wfLogIn.vSelect();
                    ucUser_Load(sender, e);
                }
            }
        }

        private void bnAdd_Click(object sender, EventArgs e)
        {
            wfCreateUser c = new wfCreateUser();
            c.ShowDialog();
            ucUser_Load(sender, e);
            dgUser.SelectedRows[iCurCell].Selected = true;
        }

        private void ucUser_Load(object sender, EventArgs e)
        {
            wfLogIn.q = "SELECT userid `USER ID`,"
                + "uname `USERNAME`,"
                + "fname `FIRSTNAME`,"
                + "lname `LASTNAME`,"
                + "utype `USER TYPE`,"
                + "ustatus `USER STATUS` FROM user where "
                + "(userid like '" + txtSearch.Text
                + "%' or uname like '%" + txtSearch.Text
                + "%' or fname like '%" + txtSearch.Text
                + "%' or lname like '%" + txtSearch.Text
                + "%' or ustatus like '%" + txtSearch.Text
                + "%' or utype like '" + txtSearch.Text + "')";
            wfLogIn.vSelect();
            dgUser.DataSource = wfLogIn.t;
            lbResult.Text = dgUser.Rows.Count + " user result(s) has found.";
        }
    }
}