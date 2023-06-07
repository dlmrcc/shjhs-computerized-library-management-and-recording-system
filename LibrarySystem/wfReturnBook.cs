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
    public partial class wfReturnBook : Form
    {
        public wfReturnBook()
        {
            InitializeComponent();
        }
        void vBorrower()
        {
            wfLogIn.q = "select borrowerid,"
                + " concat(fname,' ',Mname,' ',lname) `BORROWER`"
                + " from borrower where borrowerid in (select borrowerid from borrow)"
                + " and (borrowerid = '" + textBox1.Text
                + "' or concat(fname,' ',Mname,' ',lname) like '%" + textBox1.Text + "%')";
            wfLogIn.vSelect();
            dgBorrower.DataSource = wfLogIn.t;
            lbResult.Text = dgBorrower.Rows.Count + " borrower result has found.";
        }
        private void wfReturnBook_Load(object sender, EventArgs e)
        {
            vBorrower();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                vBorrower();
            }
        }
        string sBorrowerID;
        private void dgBorrower_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                sBorrowerID = dgBorrower.Rows[dgBorrower.CurrentCell.RowIndex].Cells[0].Value.ToString();
                wfLogIn.q = "SELECT br.borrowid,"//0
                    + " concat(b.title,' copy ',b.copy,' ',b.edition,' Edition') `BOOK`,"//1
                    + " concat(u.fname,' ',u.lname) `STAFF`,"//2
                    + " br.dateborrow `DATE BORROW`,"//3
                    + " br.expecteddatereturn `EXPECTED DATE RETURN`,"//4
                    + " br.RATE FROM borrow br left join (book b, user u) on"//5
                    + " (br.bookid = b.bookid and u.userid = br.userid)"
                    + " where br.borrowerid = '" + sBorrowerID + "'";
                wfLogIn.vSelect();
                dgBorrowBooks.DataSource = wfLogIn.t;
                dgBorrowBooks.Columns[0].Visible = false;
                dgBorrowBooks.Columns[3].DefaultCellStyle.Format = "MMM. dd, yyyy hh:mm:ss tt";
            }
            catch { }
        }
        TimeSpan ts;
        double dTotalAmount;
        DateTime dExpectedReturn;
        double dRate;
        private void dgBorrowBooks_SelectionChanged(object sender, EventArgs e)
        {
            int dTotalDays = 0;
            try
            {
            int iWeekDays = 0;
                dTotalAmount = 0;
                for (int a = 0; a < dgBorrowBooks.SelectedRows.Count; a++)
                {
                    dExpectedReturn = DateTime.Parse(dgBorrowBooks.SelectedRows[a].Cells[4].Value.ToString());
                    dRate = Convert.ToDouble(dgBorrowBooks.SelectedRows[a].Cells[5].Value);
                    ts = DateTime.Now - dExpectedReturn;
                    int s = 0;
                    iWeekDays = 0;
                    for (s = 1; s <= (int)ts.TotalDays; s++)
                    {
                        if (dExpectedReturn.AddDays(s).ToString() == "Sat" || dExpectedReturn.AddDays(s).ToString() == "Sun")
                        {

                        }
                        else
                        {
                            iWeekDays++;
                            dTotalDays++;
                        }
                    }
                    dTotalAmount += (dRate * iWeekDays);
                }
                lbResult.Text = dTotalAmount.ToString("c") + " " + dTotalDays;
            }
            catch { }
        }
    }
}
