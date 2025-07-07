using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        List<Flashcard> termDef = new List<Flashcard>();

        public Form1()
        {
            InitializeComponent();
            termDef.Add(new Flashcard("Constructor", "A method called when an object is created."));
            termDef.Add(new Flashcard("Encapsulation", "Wrapping data and methods in a unit."));
            termDef.Add(new Flashcard("Class", "A blueprint of an object."));
            termDef.Add(new Flashcard("Accessor", "Gets data out/returns data."));
            termDef.Add(new Flashcard("Method", "A function defined inside of a class."));

        }
        private void btnDefine_Click(object sender, EventArgs e)
        {
            string inputTerm = txtInput.Text;
            foreach (Flashcard card in termDef)
            {
                if (card.GetTerm().ToLower() == inputTerm.ToLower())
                {
                    lblResults.Text = card.GetDefinition();
                    return;
                }
            }
            lblResults.Text = "Term not found.";
            txtInput.Text = inputTerm;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newTerm = txtInput.Text.ToLower();
            string newDefinition = txtAdd.Text.ToLower();
            if (termDef.Count >= 20)
            {
                lblResults.Text = "Flashcard limit is 20.";
                return;
            }

            termDef.Add(new Flashcard(newTerm, newDefinition));
            lblResults.Text = $"New term and definition added.\n Term: {newTerm}\n Definition: {newDefinition}";

        }

    }
}
