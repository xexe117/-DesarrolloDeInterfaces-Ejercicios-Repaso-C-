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
        BindingList<UserModel> users = new BindingList<UserModel>();

        public Form1()
        {
            InitializeComponent();

            CargarLista();

            WireUpDropDown();
        }

        private void CargarLista()
        {
            String[] lines = File.ReadAllLines("UserList.csv");

            for (int i = 1; i < lines.Length; i++)
            {
                string[] columns = lines[i].Split(',');
                bool isAlive = false;

                if (columns[3] == "1")
                {
                    isAlive = true;
                }


                users.Add(new UserModel
                {
                    FirstName = columns[0],
                    LastName = columns[1],
                    Age = int.Parse(columns[2]),
                    IsAlive = isAlive

                });
            }
        }

        private void WireUpDropDown()
        {
            listNames.DataSource = users;
            listNames.DisplayMember = nameof(UserModel.DisplayText);
        }


        private void addUs_Click(object sender, EventArgs e)
        {
            users.Add(new UserModel
            {
                FirstName = firstName.Text,
                LastName = lastName.Text,
                Age = (int)numAge.Value,
                IsAlive = liveCheck.Checked
            });

            firstName.Text = "";
            lastName.Text = "";
            numAge.Value = 0;
            liveCheck.Checked = false;
        }

        private void saveList_Click_1(object sender, EventArgs e)
        {
                List<String> lines = new List<string>
            {
                "FirstName,LastName,Age,IsAlive"
            };

                foreach (UserModel user in users)
                {
                    int isAliveValor = 0;

                    if (user.IsAlive == true)
                    {
                        isAliveValor = 1;
                    }

                    lines.Add($"{ user.FirstName },{ user.LastName },{ user.Age },{ isAliveValor }");
                }

                File.WriteAllLines("UserList.csv", lines);
                MessageBox.Show("Save complete");
        }
    }
}
