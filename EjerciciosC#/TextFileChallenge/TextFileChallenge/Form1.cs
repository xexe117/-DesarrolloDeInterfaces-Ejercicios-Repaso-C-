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

        int OrdenNombre = 0;
        int OrdenApellido = 0;
        int Edad = 0;
        int VM= 0;

        public Form1()
        {
            InitializeComponent();

            CargarLista();

            WireUpDropDown();
        }

        private void CargarLista()
        {
            String[] lines = File.ReadAllLines("UserList.csv");

            string[] headers = lines[0].Split(',');

            for (int i = 0; i < headers.Length; i++)
            {
                if (headers[1] == "FirstName")
                {
                    OrdenNombre = i;
                }
                else if (headers[1] == "LastName")
                {
                    OrdenApellido = i;
                }
                if (headers[1] == "Age")
                {
                    Edad = i;
                }
                if (headers[1] == "IsAlive")
                {
                    VM = i;
                }
            }
        
            for (int i = 1; i < lines.Length; i++)
            {
                string[] columns = lines[i].Split(',');
                bool isAlive = false;

                if (columns[VM] == "1")
                {
                    isAlive = true;
                }


                users.Add(new UserModel
                {
                    FirstName = columns[OrdenNombre],
                    LastName = columns[OrdenApellido],
                    Age = int.Parse(columns[Edad]),
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
            List<string> lines = new List<string>;//No entiendo porque aqui me da error

            string line = "";

            //{
            // "FirstName,LastName,Age,IsAlive"
            //};

            for (int i = 0; i < 4; i++)
            {
                if (OrdenNombre == i)
                {
                    line += "FirstName";
                }
                else if (OrdenApellido == i)
                {
                    line = "LastName";
                }
                else if (Edad == i)
                {
                    line = "Age";
                }
                else if (VM == i)
                {
                    line = "IsAlive";
                }

                line += ",";
            }

            line = line.Substring(0, line.Length - 1);

            lines.Add(line);

            foreach (UserModel user in users)
                {
                    int isAliveValor = 0;
                    line = "";

                    if (user.IsAlive == true)
                    {
                        isAliveValor = 1;
                    }
                    
                    for (int i = 0; i < 4; i++)
                        {
                        if (OrdenNombre == i)
                        {
                            line += user.FirstName;
                        }
                        else if (OrdenApellido == i)
                        {
                            line += user.LastName;
                        }
                        else if (Edad == i)
                        {
                            line += user.Age;
                        }
                        else if (VM == i)
                        {
                            line += user.IsAlive;
                        }

                    line += ",";
                }

                line = line.Substring(0, line.Length - 1);

                lines.Add(line);

                //lines.Add($"{ user.FirstName },{ user.LastName },{ user.Age },{ isAliveValor }");
            }

                File.WriteAllLines("UserList.csv", lines);
                MessageBox.Show("Save complete");
        }
    }
}
