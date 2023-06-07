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
    public partial class wfBorrowerType : Form
    {
        public wfBorrowerType()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wfLogIn.q = "SELECT borrowertypeid,"
                + " borrowertype `BORROWER TYPE`,"
                + " rate `RATE`,"
                + " bookvalue `MAX BORROW BOOKS`,"
                + " finestype `FINES TYPE`,"
                + " finestart `START FINES ON`"
                + " FROM borrowertype";
            wfLogIn.vSelect();
            dgBorrower.DataSource = wfLogIn.t;
            dgBorrower.Columns[0].Visible = false;
            lbResult.Text = dgBorrower.Rows.Count + " borrowers type has been found!";
        }
        void vCallBorrowType()
        {
            wfBorrowerTypeSet b = new wfBorrowerTypeSet();
            b.ShowDialog();
        }
        private void bnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        public static String sborrowertypeid, sborrowertype, srate, sbookvalue, sfinestype, sfinestart, sSave;
        private void dgUser_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                sborrowertypeid = dgBorrower.Rows[dgBorrower.CurrentCell.RowIndex].Cells[0].Value.ToString();
                sborrowertype = dgBorrower.Rows[dgBorrower.CurrentCell.RowIndex].Cells[1].Value.ToString();
                srate = dgBorrower.Rows[dgBorrower.CurrentCell.RowIndex].Cells[2].Value.ToString();
                sbookvalue= dgBorrower.Rows[dgBorrower.CurrentCell.RowIndex].Cells[3].Value.ToString();
                sfinestype = dgBorrower.Rows[dgBorrower.CurrentCell.RowIndex].Cells[4].Value.ToString();
                sfinestart= dgBorrower.Rows[dgBorrower.CurrentCell.RowIndex].Cells[5].Value.ToString();
            }
            catch { }
        }
        private void bnEdit_Click(object sender, EventArgs e)
        {
            sSave = "Edit";
            vCallBorrowType();
            Form1_Load(sender, e);
        }
    }
}
