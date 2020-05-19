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
            if (FormAuthorization.users.type == "agent") buttonOpenAgents.Enabled = false;
            labelHello.Text = "Приветствую тебя, " + FormAuthorization.users.login;
            
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

        private void buttonOpenDemands_Click(object sender, EventArgs e)
        {
            //Задаем новую форму из класса Предложения и открываем ее
            Form formSyply = new FormSyply();
            formSyply.Show();
        }

        private void buttonOpenSupplies_Click(object sender, EventArgs e)
        {
            //Задаем новую форму из класса Потребности и открываем ее
            Form formDemand = new FormDemand();
            formDemand.Show();
        }

        private void buttonOpenDeals_Click(object sender, EventArgs e)
        {
            //Задаем новую форму из класса Потребности и открываем ее
            Form formDeal = new FormDeal();
            formDeal.Show();
        }
    }
}
