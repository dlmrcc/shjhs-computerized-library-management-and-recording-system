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
    public partial class wfBorrowBook : Form
    {
        public wfBorrowBook()
        {
            InitializeComponent();
        }
        void vBorrower()
        {
            wfLogIn.q = "SELECT borrowerid,"//0
                + " concat('[',borrowerid,'] ', fname,' ', mname,' ', lname) BORROWER,"//1
                + " connum,"//2
                + " borrowertype,"//3
                + " address"//4
                + " FROM borrower"
                + " where (concat('[',borrowerid,'] ', fname,' ', mname,' ', lname) like '%" + txtSearchBorrower.Text
                + "%' or connum like '" + txtSearchBorrower.Text
                + "%' or borrowertype like '" + txtSearchBorrower.Text
                + "%' or address like '" + txtSearchBorrower.Text + "%')";
            wfLogIn.vSelect();
            dgBorrower.DataSource = wfLogIn.t;
            dgBorrower.Columns[0].Visible = false;
            dgBorrower.Columns[2].Visible = false;
            dgBorrower.Columns[3].Visible = false;
            dgBorrower.Columns[4].Visible = false;
            lbResultBorrower.Text = dgBorrower.Rows.Count + " borrower result has found!";
            wfLogIn.q = "SELECT rate,bookvalue FROM borrowertype where borrowertype = '" + lbBorrowerType.Text + "'";
            wfLogIn.vSelect();
            dRate = (double)wfLogIn.t.Rows[0][0];
            dBookValue = (double)wfLogIn.t.Rows[0][1];
        }
        Double dRate, dBookValue;
        void vBook()
        {
            wfLogIn.q = "SELECT bookid, title, edition, copy, publisher, author FROM book where (title like '" + txtSearchAvailable.Text
                + "%' or edition like '" + txtSearchAvailable.Text
                + "%' or publisher like '" + txtSearchAvailable.Text
                + "%' or author like '%" + txtSearchAvailable.Text
                + "%') and bookid not in (select bookid from borrow where billingflag = 'Unpaid') order by title, bookid";
            wfLogIn.q = wfLogIn.q.ToUpper();
            wfLogIn.vSelect();
            dgAvailableBooks.DataSource = wfLogIn.t;
            dgAvailableBooks.Columns[0].Visible = false;
            lbResultAvailable.Text = dgAvailableBooks.Rows.Count + " available books has been found!";
        }
        void vBorrowedBook()
        {
            wfLogIn.q = "SELECT borrowid,"
                + " bk.title,"
                + " bk.edition,"
                + " bk.copy,"
                + " bk.author,"
                + " dateborrow `DATE BORROWED`,"
                + " expecteddatereturn `RETURN DATE`"
                + " FROM borrow b left join"
                + " (book bk, borrower br, `user` u)"
                + " on (b.bookid = bk.bookid and b.borrowerid"
                + " = br.borrowerid and u.userid = b.userid)"
                + " where billingflag = 'Unpaid' and b.borrowerid = '" + sborrowerid + "'";
            wfLogIn.q = wfLogIn.q.ToUpper();
            wfLogIn.vSelect();
            dgBorrowedBook.DataSource = wfLogIn.t;
            dgBorrowedBook.Columns[0].Visible = false;
            dgBorrowedBook.Columns[5].DefaultCellStyle.Format = "MMM. dd, yyyy hh:mm:ss tt";
            dgBorrowedBook.Columns[6].DefaultCellStyle.Format = "MMM. dd, yyyy hh:mm:ss tt";
        }
        private void wfBorrowBook_Load(object sender, EventArgs e)
        {
            vBorrower();
            vBook();
            vBorrowedBook();
        }
        public static String sborrowerid;
        private void dgBorrower_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                sborrowerid = dgBorrower.Rows[dgBorrower.CurrentCell.RowIndex].Cells[0].Value.ToString();
                lbContactNumber.Text = dgBorrower.Rows[dgBorrower.CurrentCell.RowIndex].Cells[2].Value.ToString();
                lbBorrowerType.Text = dgBorrower.Rows[dgBorrower.CurrentCell.RowIndex].Cells[3].Value.ToString();
                rtAddress.Text = dgBorrower.Rows[dgBorrower.CurrentCell.RowIndex].Cells[4].Value.ToString();
                vBook();
                vBorrowedBook();
            }
            catch { }
            if (dgBorrower.Rows.Count == 0)
            {
                sborrowerid = "";
                lbContactNumber.Text = "Null";
                lbBorrowerType.Text = "Null";
                rtAddress.Text = "Null";
            }
        }
        private void bnAddBorrower_Click(object sender, EventArgs e)
        {
            wfBorrower.sSave = "Add";
            wfBorrowerSet s = new wfBorrowerSet();
            s.ShowDialog();
            vBorrower();
        }

        private void bnAddBook_Click(object sender, EventArgs e)
        {
            wfBook.sSave = "Add";
            wfBookSet s = new wfBookSet();
            s.ShowDialog();
            vBook();
        }

        private void txtSearchBorrower_TextChanged(object sender, EventArgs e)
        {
            vBorrower();
        }

        private void txtSearchAvailable_TextChanged(object sender, EventArgs e)
        {
            vBook();
        }

        private void bnBorrowBook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to borrow the book titled " + dgAvailableBooks.Rows[dgAvailableBooks.CurrentCell.RowIndex].Cells[1].Value.ToString() + "?"
                , "Confirm Borrow Book"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if ((double)dgBorrowedBook.Rows.Count == dBookValue)
                {
                    MessageBox.Show("You have reached the maximum number of books to borrow"
                        , "Unable to borrow an additional book"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Warning);
                }
                else
                {
                    int iCOunter = 0;
                    for (int a = 0; a < dgBorrowedBook.Rows.Count; a++)
                    {
                        if (dgAvailableBooks.Rows[dgAvailableBooks.CurrentCell.RowIndex].Cells[1].Value.ToString() == dgBorrowedBook.Rows[a].Cells[1].Value.ToString())
                        {
                            iCOunter++;
                        }
                    }
                    if (iCOunter == 0)
                    {
                        int a = 1;
                        for (a = 1; a < 8; a++)
                        {
                            if (DateTime.Now.AddDays(a).ToString("ddd") == "Mon")
                            {
                                break;
                            }
                        }
                        wfLogIn.q = "insert into borrow"
                            + " (borrowid, userid, bookid, borrowerid, dateborrow, datereturn, billingflag, reserveflag, rate, expecteddatereturn)"
                            + " values (null,'" + wfLogIn.dbuserid
                            + "','" + sBookID
                            + "','" + sborrowerid
                            + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                            + "',null,'" + "Unpaid"
                            + "','" + "No"
                            + "','" + dRate
                            + "','" + DateTime.Now.AddDays(a).ToString("yyyy-MM-dd HH:mm:ss") + "')";
                        wfLogIn.vSelect();
                        vBook();
                        vBorrowedBook();
                    }
                    else
                    {
                        MessageBox.Show("You already borrowed " + dgAvailableBooks.Rows[dgAvailableBooks.CurrentCell.RowIndex].Cells[1].Value.ToString(), "Unable to borrow");
                    }
                }
            }
        }
        String sBookID;
        private void dgAvailableBooks_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                sBookID = dgAvailableBooks.Rows[dgAvailableBooks.CurrentCell.RowIndex].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void bnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to remove "+dgBorrowedBook.Rows[dgBorrowedBook.CurrentCell.RowIndex].Cells[1].Value.ToString()+"?"
                ,"Confirm Delete"
                ,MessageBoxButtons.YesNo
                ,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                wfLogIn.q = "delete from borrow where borrowid = '" + dgBorrowedBook.Rows[dgBorrowedBook.CurrentCell.RowIndex].Cells[0].Value.ToString() + "'";
                wfLogIn.vSelect();
                vBook();
                vBorrowedBook();
            }
        }
    }
}