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
    public partial class wfBook : Form
    {
        public wfBook()
        {
            InitializeComponent();
        }
        private void dgUser_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                sbookid = dgBook.Rows[dgBook.CurrentCell.RowIndex].Cells[0].Value.ToString();
                stitle = dgBook.Rows[dgBook.CurrentCell.RowIndex].Cells[2].Value.ToString();
                sedition = dgBook.Rows[dgBook.CurrentCell.RowIndex].Cells[3].Value.ToString();
                scopy = dgBook.Rows[dgBook.CurrentCell.RowIndex].Cells[4].Value.ToString();
                spublisher = dgBook.Rows[dgBook.CurrentCell.RowIndex].Cells[5].Value.ToString();
                syear = dgBook.Rows[dgBook.CurrentCell.RowIndex].Cells[6].Value.ToString();
                sremarks = dgBook.Rows[dgBook.CurrentCell.RowIndex].Cells[7].Value.ToString();
                sauthor = dgBook.Rows[dgBook.CurrentCell.RowIndex].Cells[8].Value.ToString();
            }
            catch { }
        }
        void vLoad()
        {
            wfLogIn.q = "SELECT bookid `ACCO. NO`,"//0
                + " `date` `DATE RECEIVED`,"//1
                + " title TITLE,"//2
                + " edition `EDITION`,"//3
                + " copy COPY,"//4
                + " publisher `PUBLISHER`,"//5
                + " `year` `YEAR`,"//6
                + " remarks `REMARKS`,"//7
                + " author `AUTHOR` FROM book" + sWhere;
            wfLogIn.vSelect();
            dgBook.DataSource = wfLogIn.t;
            lbResult.Text = dgBook.Rows.Count + " book result has found!";
            dgBook.Columns[1].DefaultCellStyle.Format = "MMM. dd, yyyy";
        }
        string sWhere;
        private void wfBook_Load(object sender, EventArgs e)
        {
            vLoad();
        }

        public static String sbookid, stitle, sedition, scopy, spublisher, syear, sremarks, sauthor;
        public static String sSave;
        private void bnAdd_Click(object sender, EventArgs e)
        {
            sSave = "Add";
            vCallBook();
            wfBook_Load(sender, e);
        }
        void vCallBook()
        {
            wfBookSet b = new wfBookSet();
            b.ShowDialog();
        }
        private void bnEdit_Click(object sender, EventArgs e)
        {
            sSave = "Edit";
            vCallBook();
            wfBook_Load(sender, e);
        }

        private void bnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                vLoad();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bool more = print.DrawDataGridView(e.Graphics);
            if (more == true)
                e.HasMorePages = true;
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
            printDocument1.DocumentName = "Accession Books";
            printDocument1.PrinterSettings = MyPrintDialog.PrinterSettings;
            printDocument1.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10);
            printDocument1.DefaultPageSettings.Landscape = MyPrintDialog.PrinterSettings.DefaultPageSettings.Landscape;
            print = new Printing(dgBook, printDocument1, true, true, "Accession Books"
                , new Font("Tahoma", 18, FontStyle.Bold,
                GraphicsUnit.Point), Color.Black, true);
            return true;
        }//=================
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

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedIndex == 0)
            {
                sWhere = " where bookid like '" + txtKeyword.Text + "%'";
            }
            else if (cbCategory.SelectedIndex == 1)
            {
                sWhere = " where TITLE like '" + txtKeyword.Text + "%'";
            }
            else if (cbCategory.SelectedIndex == 2)
            {
                sWhere = " where edition like '" + txtKeyword.Text + "%'";
            }
            else if (cbCategory.SelectedIndex == 3)
            {
                sWhere = " where copy like '" + txtKeyword.Text + "%'";
            }
            else if (cbCategory.SelectedIndex == 4)
            {
                sWhere = " where publisher like '" + txtKeyword.Text + "%'";
            }
            else if (cbCategory.SelectedIndex == 5)
            {
                sWhere = " where remarks like '" + txtKeyword.Text + "%'";
            }
            else if (cbCategory.SelectedIndex == 6)
            {
                sWhere = " where author like '" + txtKeyword.Text + "%'";
            }
            wfBook_Load(sender, e);
        }
    }
}