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
    public partial class wfBookSet : Form
    {
        public wfBookSet()
        {
            InitializeComponent();
        }
        void vTitle()
        {
            cbTitle.Items.Clear();
            wfLogIn.q = "SELECT distinct title FROM book order by title";
            wfLogIn.vSelect();
            for (int a = 0; a < wfLogIn.t.Rows.Count; a++)
                cbTitle.Items.Add(wfLogIn.t.Rows[a][0]);
        }
        void vRemarks()
        {
            cbRemarks.Items.Clear();
            wfLogIn.q = "SELECT distinct remarks FROM book order by remarks";
            wfLogIn.vSelect();
            for (int a = 0; a < wfLogIn.t.Rows.Count; a++)
                cbRemarks.Items.Add(wfLogIn.t.Rows[a][0]);
        }
        void vYear()
        {
            cbYear.Items.Clear();
            wfLogIn.q = "SELECT distinct year FROM book order by year";
            wfLogIn.vSelect();
            for (int a = 0; a < wfLogIn.t.Rows.Count; a++)
                cbYear.Items.Add(wfLogIn.t.Rows[a][0]);
        }
        void vEdition()
        {
            cbEdition.Items.Clear();
            wfLogIn.q = "SELECT distinct edition FROM book order by edition";
            wfLogIn.vSelect();
            for (int a = 0; a < wfLogIn.t.Rows.Count; a++)
                cbEdition.Items.Add(wfLogIn.t.Rows[a][0]);
        }
        private void wfBookSet_Load(object sender, EventArgs e)
        {
            vTitle();
            vRemarks();
            vYear();
            vEdition();
            if (wfBook.sSave == "Edit")
            {
                cbTitle.Text = wfBook.stitle;
                wfLogIn.q = "SELECT copy FROM book where title = '" + cbTitle.Text + "'";
                wfLogIn.vSelect();
                txtAuthor.Text = wfBook.sauthor;
                txtCopy.Text = "1 - " + wfLogIn.t.Rows.Count.ToString();
                txtCopy.Enabled = false;
                cbEdition.Text = wfBook.sedition;
                txtPublisher.Text = wfBook.spublisher;
                cbRemarks.Text = wfBook.sremarks;
                cbYear.Text = wfBook.syear;  
            }
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        int iBookCounter;
        private void bnSave_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < Convert.ToInt32(txtCopy.Text); a++)
            {
                if (wfBook.sSave == "Add")
                {
                    wfLogIn.q = "SELECT bookid FROM book where concat(title,copy) = '" + cbTitle.Text + (a + 1) + "'";
                    wfLogIn.vSelect();
                    if (wfLogIn.t.Rows.Count == 0)
                    {
                        wfLogIn.q = "insert into book (bookid, date, title, edition, copy, publisher, year, remarks, author) values (null,'" + DateTime.Now.ToString("yyyy-MM-dd")
                            + "','" + cbTitle.Text
                            + "','" + cbEdition.Text
                            + "','" + (a + 1)
                            + "','" + txtPublisher.Text
                            + "','" + cbYear.Text
                            + "','" + cbRemarks.Text
                            + "','" + txtAuthor.Text + "')";
                        wfLogIn.vSelect();
                        iBookCounter++;
                    }
                }
                else
                {
                    wfLogIn.q = "update book set title = '" + cbTitle.Text
                        + "', edition = '" + cbEdition.Text
                        + "', publisher = '" + txtPublisher.Text
                        + "', year = '" + cbYear.Text
                        + "', remarks = '" + cbRemarks.Text
                        + "', author = '" + txtAuthor.Text
                        + "' where title = '" + wfBook.stitle + "'";
                    wfLogIn.vSelect();
                    break;
                }
            }
            if (iBookCounter > 0)
            {
                MessageBox.Show(iBookCounter.ToString() + " copy/copies of " + cbTitle.Text + " has been successfully added.","Adding Successful");
            }
            Close();
        }

        private void cbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (wfBook.sSave == "Add")
            {
                wfLogIn.q = "SELECT edition, copy, publisher, year, remarks, author FROM book where title = '" + cbTitle.Text + "' order by copy desc limit 1";
                wfLogIn.vSelect();
                if (wfLogIn.t.Rows.Count > 0)
                {
                    cbEdition.Text = wfLogIn.t.Rows[0][0].ToString();
                    txtCopy.Text = (Convert.ToInt16(wfLogIn.t.Rows[0][1]) + 1).ToString();
                    txtPublisher.Text = wfLogIn.t.Rows[0][2].ToString();
                    cbYear.Text = wfLogIn.t.Rows[0][3].ToString();
                    cbRemarks.Text = wfLogIn.t.Rows[0][4].ToString();
                    txtAuthor.Text = wfLogIn.t.Rows[0][5].ToString();
                }
                else
                {
                    cbEdition.Text = "";
                    txtCopy.Text = "";
                    txtPublisher.Text = "";
                    cbYear.Text = "";
                    cbRemarks.Text = "";
                    txtAuthor.Text = "";
                }
            }
        }
    }
}
