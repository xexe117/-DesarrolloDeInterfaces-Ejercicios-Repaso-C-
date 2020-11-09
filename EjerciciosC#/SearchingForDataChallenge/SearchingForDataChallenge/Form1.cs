using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchingForDataChallenge
{
    public partial class Form1 : Form
    {
        BindingList<string> findLines = new BindingList<string>();
        public Form1()
        {
            InitializeComponent();
            ResultadosBox.DataSource = findLines;
        }

        private void BuscarButt_Click(object sender, EventArgs e)
        {
            List<string> linies = File.ReadAllLines(@"C:\Users\xesc2\Desktop\C#\-DesarrolloDeInterfaces-Ejercicios-Repaso-C-\EjerciciosC#\TextFileChallenge\Searching4Data_primary.txt").ToList();
            findLines.Clear();

            foreach (var lina in linies)
            {
                if (lina.IndexOf(txtBusquedaLabelBox.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    findLines.Add(lina);
                }
            }
        }

        private void TelefonButt_Click(object sender, EventArgs e)
        {
            string fileText = File.ReadAllText(@"C:\Users\xesc2\Desktop\C#\-DesarrolloDeInterfaces-Ejercicios-Repaso-C-\EjerciciosC#\TextFileChallenge\Searching4Data_primary.txt");
            findLines.Clear();
            Regex regex = new Regex(@" \(([0-9]{3})\) ([0-9]{3})-([0-9]{4}) ");
            MatchCollection tinder = regex.Matches(fileText); //Tinder = matches (massa temps fora descansar supos)

            foreach (Match match in tinder)
            {
                if (string.IsNullOrWhiteSpace(match.Groups[0].Value) == false)
                {
                    findLines.Add(match.Groups[0].Value.Trim());
                }       
            }
        }

        private void cambiText(object sender, EventArgs e)
        {
            if (txtBusquedaLabelBox.Text.Length < 2)
            {
                return;
            }

            TelefonButt_Click(sender, e);
        }
    }
}
