using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextFileChallenge
{
    public partial class Form1 : Form
    {
        BindingList<PersonModel> users = new BindingList<PersonModel>();

        public Form1()
        {
            InitializeComponent();
        }

        private void CargarLista()
        {
            String[] lines = File.ReadAllLines("StandartDataSet.csv");
        }

        private void addUs_Click(object sender, EventArgs e)
        {

        }
    }
}
