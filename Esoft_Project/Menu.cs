using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_Project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonOpenAgents_Click(object sender, EventArgs e)
        {
            //Задаем новую форму из класса Риэлтор и открываем ее
            Form formAgent = new FormAgents();
            formAgent.Show();
        }

        private void buttonOpenClients_Click(object sender, EventArgs e)
        {
            //Задаем новую форму из класса Клиент и открываем ее
            Form formClient = new FormClients();
            formClient.Show();
        }

        private void buttonOpenRealEstates_Click(object sender, EventArgs e)
        {
            //Задаем новую форму из класса Объекты недвижимости и открываем ее
            Form formRealEstate = new FormRealEstate();
            formRealEstate.Show();
        }
    }
}
