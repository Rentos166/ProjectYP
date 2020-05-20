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
    public partial class FormAgents : Form
    {
        void ShowAgents()
        {
            //Предварительно очищаем listView
            listViewAgent.Items.Clear();
            //Проходимся по коллекции риэлторов, которые находятся в базе с помощью foreach
            foreach (AgentSet agentSet in Program.wftDb.AgentSet)
            {
                //создаем новый элемент в listView
                //для этого создаем новый массив строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    //указываем необходимые поля
                    agentSet.Id.ToString(),
                    agentSet.FirstName,
                    agentSet.MiddleName,
                    agentSet.LastName,
                    agentSet.DealShare.ToString()
                });
                //указываем по какому тегу будем брать элементы
                item.Tag = agentSet;
                //добавляем элементы в listView для отображения
                listViewAgent.Items.Add(item);
            }
            //выравниваем колонки в listView
            listViewAgent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public FormAgents()
        {
            InitializeComponent();
            ShowAgents();
        }

        private void FormAgents_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Создаем новый экземпляр класса Риэлтор
                AgentSet agentSet = new AgentSet();
                //Делаем ссылку на объект, который хранится в textBox-ax
                agentSet.FirstName = textBoxFirstName.Text;
                agentSet.MiddleName = textBoxMiddleName.Text;
                agentSet.LastName = textBoxLastName.Text;
                //Проверяем textBox-ы на заполненость
                if (textBoxDealShare.Text != "")
                    agentSet.DealShare = Convert.ToInt32(textBoxDealShare.Text);
                if (agentSet.FirstName == "" || agentSet.MiddleName == "" || agentSet.LastName == "")
                {
                    throw new Exception("Не заполнены поля ФИО");
                }
                if (agentSet.DealShare < 0 || agentSet.DealShare > 100)
                {
                    throw new Exception("Доля от комиссии должна находится в диапозоне от 0 до 100");
                }
                //Добавляем в таблицу AgentSet нового клиента agentSet
                Program.wftDb.AgentSet.Add(agentSet);
                //Сохраняем изменения в модели wftDb (экземпляр которой был создан ранее)
                Program.wftDb.SaveChanges();
                ShowAgents();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


        private void listViewAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            //условие, если выбран 1 элемент
            if (listViewAgent.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                AgentSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentSet;
                //указываем, что может быть изменено
                textBoxFirstName.Text = agentSet.FirstName;
                textBoxMiddleName.Text = agentSet.MiddleName;
                textBoxLastName.Text = agentSet.LastName;
                textBoxDealShare.Text = agentSet.DealShare.ToString();
                ShowSupplySet(agentSet);
                ShowDemandSet(agentSet);
            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задаем пустые поля
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxDealShare.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            try
            {
                //условие, если в listView выбран 1 элемент
                if (listViewAgent.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    AgentSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentSet;
                    //указываем, что может быть изменено
                    agentSet.FirstName = textBoxFirstName.Text;
                    agentSet.MiddleName = textBoxMiddleName.Text;
                    agentSet.LastName = textBoxLastName.Text;
                    //Проверяем textBox-ы на заполненость
                    if (textBoxDealShare.Text != "")
                        agentSet.DealShare = Convert.ToInt32(textBoxDealShare.Text);
                    if (textBoxDealShare.Text == "")
                        agentSet.DealShare = null;
                    if (agentSet.FirstName == "" || agentSet.MiddleName == "" || agentSet.LastName == "")
                    {
                        throw new Exception("Не заполнены поля ФИО");
                    }
                    if (agentSet.DealShare < 0 || agentSet.DealShare > 100)
                    {
                        throw new Exception("Доля от комиссии должна находится в диапозоне от 0 до 100");
                    }
                    //Сохраняем изменения в модели wftDb (экземпляр которой был создан ранее)
                    Program.wftDb.SaveChanges();
                    ShowAgents();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        

        private void buttonDel_Click(object sender, EventArgs e)
        {
            //пробуем совершить действие
            try
            {
                //если выбран 1 элемент из listView
                if (listViewAgent.SelectedItems.Count == 1)
                {
                    //ищем этот элемент
                    AgentSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentSet;
                    //удаляем из модели и базы данных
                    Program.wftDb.AgentSet.Remove(agentSet);
                    //сохраняем изменения
                    Program.wftDb.SaveChanges();
                    //отображаем обновленный список
                    ShowAgents();
                }
                //очищаем textBox-ы
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxDealShare.Text = "";
            }
            //если возникает какая-то ошибка, к примеру, запись используется, выводим всплывающее сообщение
            catch
            {
                //вызываем метод для всплывающего окна, в котором указываем текст, заголовок, кнопку и иконку
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxAgents_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
        void ShowSupplySet(AgentSet agentSet)
        {
            //очищаем listView
            listViewSupplySet.Items.Clear();
            //проходим по коллекции
            foreach (SyppySet syppy in Program.wftDb.SyppySet)
            {
                if (agentSet.Id == syppy.IdClient)
                {
                    //Создаем новый элемент
                    ListViewItem item = new ListViewItem(new string[]
                    {
                         //Риелтор
                         syppy.AgentSet.LastName +" "+syppy.AgentSet.FirstName.Remove(1) +". "+ syppy.AgentSet.MiddleName.Remove(1)+" .",
                         //Клиент
                         syppy.ClientsSet.LastName +" "+syppy.ClientsSet.FirstName.Remove(1) +". "+ syppy.ClientsSet.MiddleName.Remove(1)+" .",
                         //Адрес
                         "г. " + syppy.RealEstateSet.Address_City+", " + "ул. " + syppy.RealEstateSet.Address_Street+", "+
                         "д. " + syppy.RealEstateSet.Address_House+", " + "кв. "+syppy.RealEstateSet.Address_Number, syppy.RealEstateSet.TotalArea.ToString(),
                         //Цена
                         syppy.Price.ToString()
                    });
                    //указываем по какому тегу выбраны элементы
                    item.Tag = syppy;
                    //добавляем элементы в listView
                    listViewSupplySet.Items.Add(item);
                }
            }
        }
        void ShowDemandSet(AgentSet agentSet)
        {
            //очищаем listView
            listViewDemandSet.Items.Clear();
            //проходим по коллекции
            foreach (DemandSet demand in Program.wftDb.DemandSet)
            {
                string typeON;
                if (demand.Type == 0)
                {
                    typeON = "Квартира";
                }
                else if (demand.Type == 1)
                {
                    typeON = "Дом";
                }
                else 
                {
                    typeON = "Земля";
                }
                if (agentSet.Id == demand.IdClient)
                {
                    //Создаем новый элемент
                    ListViewItem item = new ListViewItem(new string[]
                    {
                         //Риелтор
                         demand.AgentSet.LastName +" "+demand.AgentSet.FirstName.Remove(1) +". "+ demand.AgentSet.MiddleName.Remove(1)+" .",
                         //Клиент
                         demand.ClientsSet.LastName +" "+demand.ClientsSet.FirstName.Remove(1) +". "+ demand.ClientsSet.MiddleName.Remove(1)+" .",
                         //тип о.н.
                         typeON,
                         //Площадь и цена
                         demand.MinArea.ToString(), demand.MaxArea.ToString(), demand.MinPrice.ToString(), demand.MaxPrice.ToString(),
                    });
                    //указываем по какому тегу выбраны элементы
                    item.Tag = demand;
                    //добавляем элементы в listView
                    listViewDemandSet.Items.Add(item);
                }
            }
        }
    }
}

