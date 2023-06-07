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
    public partial class wfBorrower : Form
    {
        public wfBorrower()
        {
            InitializeComponent();
        }
        string sWhere;
        private void wfBorrower_Load(object sender, EventArgs e)
        {
            wfLogIn.q = "SELECT borrowerid `ID NO.`,"//0
                + " fname `FIRSTNAME`,"//1
                + " mname `MIDDLENAME`,"//2
                + " lname `LASTNAME`,"//3
                + " borrowertype `BORROWER TYPE`,"//4
                + " connum `CONTACT NUMBER`,"//5
                + " address `ADDRESS`"//6
                + " FROM borrower" + sWhere;
            wfLogIn.vSelect();
            dgBorrower.DataSource = wfLogIn.t;
            lbResult.Text = dgBorrower.Rows.Count + " borrower result has found!";
        }

        public static String sborrowerid, sfname, smname, slname, sborrowertype, sconnum, saddress, sSave;
        private void dgUser_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                sborrowerid = dgBorrower.Rows[dgBorrower.CurrentCell.RowIndex].Cells[0].Value.ToString();
                sfname = dgBorrower.Rows[dgBorrower.CurrentCell.RowIndex].Cells[1].Value.ToString();
                smname = dgBorrower.Rows[dgBorrower.CurrentCell.RowIndex].Cells[2].Value.ToString();
                slname = dgBorrower.Rows[dgBorrower.CurrentCell.RowIndex].Cells[3].Value.ToString();
                sborrowertype = dgBorrower.Rows[dgBorrower.CurrentCell.RowIndex].Cells[4].Value.ToString();
                sconnum = dgBorrower.Rows[dgBorrower.CurrentCell.RowIndex].Cells[5].Value.ToString();
                saddress = dgBorrower.Rows[dgBorrower.CurrentCell.RowIndex].Cells[6].Value.ToString();
            }
            catch { }
        }

        private void bnAdd_Click(object sender, EventArgs e)
        {
            sSave = "Add";
            vCallBorrower();
            wfBorrower_Load(sender, e);
        }
        void vCallBorrower()
        {
            wfBorrowerSet s = new wfBorrowerSet();
            s.ShowDialog();
        }
        private void bnEdit_Click(object sender, EventArgs e)
        {
            sSave = "Edit";
            vCallBorrower();
            wfBorrower_Load(sender, e);
        }

        private void bnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bnPrint_Click(object sender, EventArgs e)
        {
            if (SetupThePrinting())
            {
                PrintPreviewDialog MyPrintPreviewDialog = new PrintPreviewDialog();
                MyPrintPreviewDialog.Document = printDocument1;
                MyPrintPreviewDialog.ShowDialog();
                printDocument1.Print();
            }
        }
        Printing print;
        private bool SetupThePrinting()//==================
        {
            PrintDialog MyPrintDialog = new PrintDialog();
            MyPrintDialog.AllowCurrentPage = false;
            MyPrintDialog.AllowPrintToFile = false;
            MyPrintDialog.AllowSelection = false;
            MyPrintDialog.AllowSomePages = false;
            MyPrintDialog.PrintToFile = false;
            MyPrintDialog.ShowHelp = false;
            MyPrintDialog.ShowNetwork = false;
            if (MyPrintDialog.ShowDialog() != DialogResult.OK)
                return false;
            printDocument1.DocumentName = "Borrower Information";
            printDocument1.PrinterSettings = MyPrintDialog.PrinterSettings;
            printDocument1.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10);
            printDocument1.DefaultPageSettings.Landscape = MyPrintDialog.PrinterSettings.DefaultPageSettings.Landscape;
            print = new Printing(dgBorrower, printDocument1, true, true, "Borrower Information"
                , new Font("Tahoma", 18, FontStyle.Bold,
                GraphicsUnit.Point), Color.Black, true);
            return true;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bool more = print.DrawDataGridView(e.Graphics);
            if (more == true)
                e.HasMorePages = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedIndex == 0)
            {
                sWhere = " where borrowerid like '" + txtSearch.Text + "%'";
            }
            else if (cbCategory.SelectedIndex == 1)
            {
                sWhere = " where fname like '" + txtSearch.Text + "%'";
            }
            else if (cbCategory.SelectedIndex == 2)
            {
                sWhere = " where mname like '" + txtSearch.Text + "%'";
            }
            else if (cbCategory.SelectedIndex == 3)
            {
                sWhere = " where lname like '" + txtSearch.Text + "%'";
            }
            else if (cbCategory.SelectedIndex == 4)
            {
                sWhere = " where address like '" + txtSearch.Text + "%'";
            }
            wfBorrower_Load(sender, e);
        }
    }
}