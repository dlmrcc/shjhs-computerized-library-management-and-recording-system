using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace LibrarySystem
{
    public partial class wfHome : Form
    {
        public wfHome()
        {
            InitializeComponent();
        }
        void vCloseExistingForm()
        {
            int d;
            for (int a = 0; a < MdiChildren.Length; a++)
            {
                d = 0;
                for (int s = 0; s < MdiChildren.Length; s++)
                {
                    if (MdiChildren[a].Text == MdiChildren[s].Text)
                        d++;
                    if (d > 1)
                        MdiChildren[a].Close();
                }
            }
        }
        private void wfHome_Load(object sender, EventArgs e)
        {
            wfLogIn l = new wfLogIn();
            l.ShowDialog();
            tmDate.Enabled = false;
            if (wfLogIn.bExit == true)
                Close();
            else
            {
                vCallNameDate(sender, e);
            }
            tmDate.Enabled = !false;
        }
        void vCallNameDate(object sender, EventArgs e)
        {
            lbUser.Text = wfLogIn.dbutype + ": " + wfLogIn.dbfname + " " + wfLogIn.dblname
                + " [" + wfLogIn.dbuserid + "]";
            tmDate_Tick(sender, e);
        }
        private void tmDate_Tick(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToString("dddd MMMM dd, yyyy hh:mm:ss tt");
        }

        private void changeUsernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfChangeUser c = new wfChangeUser();
            c.ShowDialog();
            vCallNameDate(sender, e);
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void wfHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (wfLogIn.bExit != true)
            {
                if (MessageBox.Show("Do you want to Log - Out?"
                    , "Confirm Log - Out"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
                else
                {
                    wfLogIn.q = "update loghis set logout = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                        + "' where userid = '" + wfLogIn.dbuserid
                        + "' and login = '" + wfLogIn.dLogIn + "'";
                    wfLogIn.vSelect();
                    foreach (Form c in MdiChildren)
                        c.Close();
                    lbDate.Text = "";
                    lbUser.Text = "";
                    tmDate.Enabled = false;
                    wfHome_Load(sender, e);
                    e.Cancel = true;
                }
            }
        }

        private void userInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wfLogIn.dbutype == "Admin")
            {
                wfUser c = new wfUser();
                c.MdiParent = this;
                c.Show();
                vCloseExistingForm();
            }
            else
            {
                MessageBox.Show("You can't access this form."
                    , "Access Forbidden"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Stop);
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bnBook_Click(object sender, EventArgs e)
        {
            wfBook b = new wfBook();
            b.MdiParent = this;
            b.Show();
            vCloseExistingForm();
        }

        private void bnBorrower_Click(object sender, EventArgs e)
        {
            wfBorrower b = new wfBorrower();
            b.MdiParent = this;
            b.Show();
            vCloseExistingForm();
        }

        private void logInHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wfLogIn.dbutype == "Admin")
            {
                wfLogInHistory l = new wfLogInHistory();
                l.MdiParent = this;
                l.Show();
                vCloseExistingForm();
            }
            else
            {
                MessageBox.Show("You can't access this form."
                    , "Access Forbidden"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Stop);
            }
        }

        private void productConfigureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wfLogIn.dbutype == "Admin")
            {
                wfBorrowerType b = new wfBorrowerType();
                b.MdiParent = this;
                b.Show();
                vCloseExistingForm();
            }
            else
            {
                MessageBox.Show("You can't access this form."
                    , "Access Forbidden"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Stop);
            }
        }

        private void bnBorrowBook_Click(object sender, EventArgs e)
        {
            wfBorrowBook b = new wfBorrowBook();
            b.MdiParent = this;
            b.Show();
            vCloseExistingForm();
        }

        private void bnReturnBook_Click(object sender, EventArgs e)
        {
            wfReturnBook r = new wfReturnBook();
            r.MdiParent = this;
            r.Show();
            vCloseExistingForm();
        }
    }
}