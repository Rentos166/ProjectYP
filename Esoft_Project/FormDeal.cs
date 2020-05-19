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
    public partial class FormDeal : Form
    {
        void ShowSupply()
        {
            //очищаем comboBox
            comboBoxSupply.Items.Clear();
            foreach (SyppySet syppySet in Program.wftDb.SyppySet)
            {
                //добавляем информацию, которую хотим видеть в строке comboBox-a
                string[] item = { syppySet.Id.ToString() + ". ", "Риелтор: "+syppySet.AgentSet.LastName + " " + syppySet.AgentSet.FirstName.Remove(1) + ". " + syppySet.AgentSet.MiddleName.Remove(1) + " .",
                "Клиент: " + syppySet.ClientsSet.LastName+" "+syppySet.ClientsSet.FirstName.Remove(1) +". "+ syppySet.ClientsSet.MiddleName.Remove(1)+" ."};
                comboBoxSupply.Items.Add(string.Join(" ", item));
            }
        }
        void ShowDemand()
        {
            //очищаем comboBox
            comboBoxDemand.Items.Clear();
            foreach (DemandSet demandSet in Program.wftDb.DemandSet)
            {
                //добавляем информацию, которую хотим видеть в строке comboBox-a
                string[] item = { demandSet.Id.ToString() + ". ", "Риелтор: "+demandSet.AgentSet.LastName + " " + demandSet.AgentSet.FirstName.Remove(1) + ". " + demandSet.AgentSet.MiddleName.Remove(1) + " .",
                "Клиент: " + demandSet.ClientsSet.LastName+" "+demandSet.ClientsSet.FirstName.Remove(1) +". "+ demandSet.ClientsSet.MiddleName.Remove(1)+" ."};
                comboBoxDemand.Items.Add(string.Join(" ", item));
            }
        }
        void Deductions()
        {
            if(comboBoxSupply.SelectedItem != null && comboBoxDemand.SelectedItem != null)
            {
                //находим в базе предложение и потребность с выбранными номерами
                SyppySet syppySet = Program.wftDb.SyppySet.Find(Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]));
                DemandSet demandSet = Program.wftDb.DemandSet.Find(Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split('.')[0]));
                //расчитываем отчисления компании для клиента-покупателя (3% от стоимости недвижимости), выводим textCustomerCompanyDeductions
                double customerCompanyDeductions = syppySet.Price * 0.03;
                textBoxCustomerCompanyDeductions.Text = customerCompanyDeductions.ToString("0.00");
                //расчитываем отчисления риелтору для клиента-покупателя (комиссия указана в таблице AgentSet), выводим в textBoxAgentCustomerDeductions
                if(demandSet.AgentSet.DealShare != null)
                {
                    double agentCustomerDeductions = customerCompanyDeductions * Convert.ToDouble(demandSet.AgentSet.DealShare) / 100.00;
                    textBoxAgentCustomerDeductions.Text = agentCustomerDeductions.ToString("0.00");
                }
                else
                {
                    //если комиссия не указана, то автоматическуие берется 45%
                    double agentCustomerDeductions = customerCompanyDeductions * 0.45;
                    textBoxAgentCustomerDeductions.Text = agentCustomerDeductions.ToString("0.00");
                }
            }
            else
            {
                textBoxCustomerCompanyDeductions.Text = "";
                textBoxAgentCustomerDeductions.Text = "";
            }
            if(comboBoxSupply.SelectedItem != null)
            {
                //находим в базе предложение с выбранным номером
                SyppySet syppySet = Program.wftDb.SyppySet.Find(Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]));
                //расчитываем отчисления компании для клиента-продавца
                //если продается квартира
                double sellerCompanyDeductions;
                if(syppySet.RealEstateSet.Type == 0)
                {
                    sellerCompanyDeductions = 36000 + syppySet.Price * 0.01;
                    textBoxSellerCompanyDeductions.Text = sellerCompanyDeductions.ToString("0.00");
                }
                //если продается дом
                else if (syppySet.RealEstateSet.Type == 1)
                {
                    sellerCompanyDeductions = 30000 + syppySet.Price * 0.01;
                    textBoxSellerCompanyDeductions.Text = sellerCompanyDeductions.ToString("0.00");
                }
                //если продается земля
                else
                {
                    sellerCompanyDeductions = 30000 + syppySet.Price * 0.02;
                    textBoxSellerCompanyDeductions.Text = sellerCompanyDeductions.ToString("0.00");
                }
                //расчитываем отчисления риелтору для клиента-покупателя (комиссия указана в таблице AgentSet)
                if(syppySet.AgentSet.DealShare != null)
                {
                    double agentSellerDeductions = sellerCompanyDeductions * Convert.ToDouble(syppySet.AgentSet.DealShare) / 100.00;
                    textBoxAgentSellerDeductions.Text = agentSellerDeductions.ToString("0.00");
                }
                else
                {
                    //если комиссия не указана, то автоматически берется 45%
                    double agentSellerDeductions = sellerCompanyDeductions * 0.45;
                    textBoxAgentSellerDeductions.Text = agentSellerDeductions.ToString("0.00");
                }
            }
            else
            {
                textBoxSellerCompanyDeductions.Text = "";
                textBoxAgentSellerDeductions.Text = "";
                textBoxCustomerCompanyDeductions.Text = "";
                textBoxAgentCustomerDeductions.Text = "";
            }
        }
        void ShowDealSet()
        {
            //Предварительно очищаем все listView
            listViewDeal.Items.Clear();
            //Проходим по коллекции сделок, которые находятся в базе с помощью foreach
            foreach (DealSet deal in Program.wftDb.DealSet)
            {
                //создадим новый элемент в listView с помощью массива строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    //указываем необходимые поля 
                    //Фамилия клиента-продавца
                    deal.SyppySet.ClientsSet.LastName +" "+deal.SyppySet.ClientsSet.FirstName.Remove(1)+". " + deal.SyppySet.ClientsSet.MiddleName.Remove(1)+" .",
                    //Фамилия риелтора клиента-продавца
                    deal.SyppySet.AgentSet.LastName +" "+deal.SyppySet.AgentSet.FirstName.Remove(1)+". " + deal.SyppySet.AgentSet.MiddleName.Remove(1)+" .",
                    //Фамилия клиента-покупателя
                    deal.DemandSet.ClientsSet.LastName +" "+deal.DemandSet.ClientsSet.FirstName.Remove(1)+". " + deal.DemandSet.ClientsSet.MiddleName.Remove(1)+" .",
                    //Фамилия риелтора клиента-покупателя
                    deal.DemandSet.AgentSet.LastName +" "+deal.DemandSet.AgentSet.FirstName.Remove(1)+". " + deal.DemandSet.AgentSet.MiddleName.Remove(1)+" .",
                    //Адрес объекта недвижимости
                    "г. "+deal.SyppySet.RealEstateSet.Address_City+", ул. "+deal.SyppySet.RealEstateSet.Address_Street+", д. "+
                    deal.SyppySet.RealEstateSet.Address_House+", кв. "+deal.SyppySet.RealEstateSet.Address_Number,
                    //стоимость
                    deal.SyppySet.Price.ToString()
                });
                //указываем по какому тегу выбраны элементы
                item.Tag = deal;
                //добавляем элементы в listViewRealEstateSet_Apartament для отображения
                listViewDeal.Items.Add(item);
            }
        }
        public FormDeal()
        {
            InitializeComponent();
            ShowSupply();
            ShowDemand();
            ShowDealSet();
        }

        private void FormDeal_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxSupply_SelectedIndexChanged(object sender, EventArgs e)
        {
            Deductions();
        }

        private void comboBoxDemand_SelectedIndexChanged(object sender, EventArgs e)
        {
            Deductions();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //проверяем, что все поля (раскрывающихся списков и текствого поля) были заполнены
            if (comboBoxDemand.SelectedItem != null && comboBoxSupply.SelectedItem != null)
            {
                //создаем новый экземпляр класса Сделка
                DealSet deal = new DealSet();
                //из выбранной строки отделяем Id предложения (он отделен точной) и делаем ссылку
                deal.IdSupply = Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]);
                //из выбранной строки отделяем Id потребности (он отделен точкой) и делаем ссылку
                deal.IdDemand = Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split('.')[0]);
                //добавляем в таблицу DealSet новую сделку
                Program.wftDb.DealSet.Add(deal);
                //сохраняем изменения в модели wftDb
                Program.wftDb.SaveChanges();
                ShowDealSet();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //если в listView выбран элемент
            if (listViewDeal.SelectedItems.Count==1)
            {
                //ищем элемент из таблицы по тегу
                DealSet deal = listViewDeal.SelectedItems[0].Tag as DealSet;
                //указываем, что может быть изменено
                deal.IdSupply = Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]);
                deal.IdDemand = Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split('.')[0]);
                //Сохраняем изменения в модели wftDb
                Program.wftDb.SaveChanges();
                ShowDealSet();
            }
        }

        private void listViewDeal_SelectedIndexChanged(object sender, EventArgs e)
        {
            //если в listView выбран элемент
            if (listViewDeal.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                DealSet deal = listViewDeal.SelectedItems[0].Tag as DealSet;
                comboBoxSupply.SelectedIndex = comboBoxSupply.FindString(deal.IdSupply.ToString());
                comboBoxDemand.SelectedIndex = comboBoxDemand.FindString(deal.IdDemand.ToString());
            }
            else
            {
                //если не выбран ни один элемент, задаем пустые элементы
                comboBoxSupply.SelectedItem = null;
                comboBoxDemand.SelectedItem = null;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            //пробуем совершить действие
            try
            {
                //если в listView выбран элемент
                if (listViewDeal.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    DealSet deal = listViewDeal.SelectedItems[0].Tag as DealSet;
                    //удаляем из модели базы данных
                    Program.wftDb.DealSet.Remove(deal);
                    //сохраняем изменения
                    Program.wftDb.SaveChanges();
                    //отображаем обновленный список
                    ShowDealSet();
                }
                //очищаем comboBox-ы
                comboBoxSupply.SelectedItem = null;
                comboBoxDemand.SelectedItem = null;
            }
            //если возникает какая-то ошибка
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
