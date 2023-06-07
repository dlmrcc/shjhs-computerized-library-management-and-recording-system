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
    public partial class wfBorrowerTypeSet : Form
    {
        public wfBorrowerTypeSet()
        {
            InitializeComponent();
        }

        private void wfBorrowerTypeSet_Load(object sender, EventArgs e)
        {
            if (wfBorrowerType.sSave == "Edit")
            {
                cbBorrowerType.Text = wfBorrowerType.sborrowertype;
                cbFinesType.Text = wfBorrowerType.sfinestype;
                cbStart.Text = wfBorrowerType.sfinestart;
                txtFine.Text = wfBorrowerType.srate;
                txtMaxBorrowBooks.Text = wfBorrowerType.sbookvalue;
            }
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bnSave_Click(object sender, EventArgs e)
        {
            if (wfBorrowerType.sSave == "Add")
            {
                wfLogIn.q = "insert into borrowertype"
                    + " (borrowertypeid, borrowertype, rate, bookvalue, finestype, finestart)"
                    + " values"
                    + " (null,'" + cbBorrowerType.Text
                    + "','" + txtFine.Text
                    + "','" + txtMaxBorrowBooks.Text
                    + "','" + cbFinesType.Text
                    + "','" + cbStart.Text + "')";
                wfLogIn.vSelect();
            }
            else
            {
                wfLogIn.q = "update borrowertype set borrowertype = '" + cbBorrowerType.Text
                    + "', rate = '" + txtFine.Text
                    + "', bookvalue = '" + txtMaxBorrowBooks.Text
                    + "', finestype = '" + cbFinesType.Text
                    + "', finestart = '" + cbStart.Text
                    + "' where borrowertypeid = '" + wfBorrowerType.sborrowertypeid + "'";
                wfLogIn.vSelect();
            }
            Close();
        }
    }
}