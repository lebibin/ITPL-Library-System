using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ITPL.Project.LibrarySystem.Forms.Book
{
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }

        private void tabBookAdd_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbAuthor_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void lblGuide_Click(object sender, EventArgs e)
        {

        }

        private void tbGRSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            string isbn = tbGRSearch.Text;
                if (isbn != String.Empty)
                {
                    doc.Load(@"http://www.goodreads.com/search.xml?format=json&q=" + isbn + "&key=wFqkKCHJTcmM8Ic0hHi7Q");
                    // doc.Load(@"http://www.goodreads.com/search.xml?format=json&q=0553212419&key=wFqkKCHJTcmM8Ic0hHi7Q");
                    // XmlNodeList nodes = doc.DocumentElement.SelectNodes("/GoodreadsResponse/search/results/work");
                    XmlNode node = doc.DocumentElement.SelectSingleNode("/GoodreadsResponse/search/results/work");
                    tbTitle.Text = node.SelectSingleNode("best_book/title").InnerText;
                    tbAuthor.Text = node.SelectSingleNode("best_book/author/name").InnerText;
                    picBook.ImageLocation = node.SelectSingleNode("best_book/image_url").InnerText;
                    string m = node.SelectSingleNode("original_publication_month").InnerText,
                            d = node.SelectSingleNode("original_publication_day").InnerText,
                            y = node.SelectSingleNode("original_publication_year").InnerText;

                    string datePublished = (m != "" ? m + "/" : "") + (d != "" ? d + "/" : "") + y;
                    tbDatePublished.Text = datePublished;

                    // locations array for simulating location of book
                    var locations = new List<string> { "FIC PS 3563 A7239 G36 1996", "FIC PZ 7 C6837 H85 2008 ", "FIC PR 4622 H6 1984", "FIC PR 4621 R57 2003 ", "RES TK 5105.888 G73 2009 " };
                    tbLocation.Text = locations[new Random().Next(0, locations.Count)];

                    // multiply by 20 since ratings are in the scale of 1-5
                    string rating = node.SelectSingleNode("average_rating").InnerText;
                    pbRating.Value = (int)(Convert.ToDouble(rating)) * 20;
                    toolTip1.SetToolTip(pbRating, rating + "/5.00");
                    tbGRSearch.Text = "";
                }
                else
                {
                    tbGRSearch.Text = "";
                    MessageBox.Show(
                        "Please enter any search term like ISBN, Author, or Title.",
                        "Empty search",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
        }

        private void lblAddBook_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dtpDatePublished_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void pbRating_Click(object sender, EventArgs e)
        {

        }
    }
}
