using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookInventorySearch
{
    public partial class Form1 : Form
    {
        string[] names = { "The Great Gatsby", "War and Peace", "Moby-Dick", "Hamlet", "Pride and Prejudice" };
        string[] keywords = { "The story of eccentric millionaire Jay Gatsby and his pursuit of his lost love.", "A fictional story about the 1812 French invasion of Russia.", "The story of a sailor’s relentless hunt for a white whale.", "A Shakespearean tragedy about a young man coming home from college after the murder of his father.", "A comedic story of love and life in Old England." };
        string[] author = { "F. Scott Fitzgerald", "Leo Tolstoy", "Herman Melville", "William Shakespeare", "Jane Austen" };
        string[] isbn = { "978-1847496140", "978-1400079988", "978-1503280786", "978-1973844402", "978-0141439518" };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = SearchByAuthor(txtAuthor.Text);
            if (index != -1)
            {
                ShowBook(index);
            }
            else 
            {
                lblResults.Text = $"No book has been found by that author, please try again.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = SearchByISBN(txtIsbn.Text);
            if (index != -1) 
            {
                ShowBook(index);
            }
            else
            {
                lblResults.Text = $"No book has been found with that ISBN, please try again.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = SearchByKeyword(txtKeyword.Text);
            if (index != -1)
            {
                ShowBook(index);
            }
            else 
            {
                lblResults.Text = $"No book has been found with that keyword, Please try again.";
            }
        }
        private void ShowBook(int index)
        {
            if (index >= 0 && index < names.Length)
            {
                lblResults.Text = $"Name: {names[index]}\n Author: {author[index]}\n Keywords: {keywords[index]}\n ISBN-13: {isbn[index]}";
            }
            else
            {
                lblResults.Text = $"No book, author, keywords, or ISBN-13 matching your input were found in our system, please try again.";
            }
        }
        private int SearchByAuthor(string authorName)
        {
            authorName = authorName.ToLower();
            for (int i = 0; i < author.Length; i++)
            {
                if (author[i].ToLower().Contains(authorName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int SearchByKeyword(string keyword)
        {
            keyword = keyword.ToLower();
            for (int i = 0; i < keywords.Length; i++)
            {
                if (names[i].ToLower().Contains(keyword) || keywords[i].ToLower().Contains(keyword))
                {
                    return i;
                }
            }
            return -1;
        }

        private int SearchByISBN(string isbnNumber)
        {
            for (int i = 0; i < isbn.Length; i++)
            {
                if (isbn[i] == isbnNumber)
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
