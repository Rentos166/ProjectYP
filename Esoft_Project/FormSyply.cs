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
    public partial class FormSyply : Form
    {
        void ShowSupplySet()
        {
            //Предварительно очищаем все listView
            listViewSyplySet.Items.Clear();
            //Проходим по коллекции клиентов, которые находятся в базе с помощью foreach
            foreach (SyppySet syppy in Program.wftDb.SyppySet)
            {
                //Создадим новый элемент в listView с помощью массива строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    //указываем необходимые поля
                    //Id и ФИО агента
                    syppy.IdAgent.ToString(),
                    syppy.AgentSet.LastName +" "+syppy.AgentSet.FirstName.Remove(1) +"."+ syppy.AgentSet.MiddleName.Remove(1)+".",
                    //Id и ФИО клиента
                    syppy.IdClient.ToString(),
                    syppy.ClientsSet.LastName +" "+syppy.ClientsSet.FirstName.Remove(1) +". "+ syppy.ClientsSet.MiddleName.Remove(1)+" .",
                    //Id и адрес 
                    syppy.IdRealEstate.ToString(),
                    "г. " + syppy.RealEstateSet.Address_City+", " + "ул. " + syppy.RealEstateSet.Address_Street+", "+
                    "д. " + syppy.RealEstateSet.Address_House+", " + "кв. "+syppy.RealEstateSet.Address_Number, syppy.RealEstateSet.TotalArea.ToString(),
                    //Цена
                    syppy.Price.ToString()
                });
                //указываем по какому тегу выбраны элементы
                item.Tag = syppy;
                //добавляем элементы в listViewRealEstateSet_Apartament для отображения
                listViewSyplySet.Items.Add(item);
            }
        }
        void ShowAgents()
        {
            //очищаем comboBox
            comboBoxAgents.Items.Clear();
            foreach (AgentSet agentSet in Program.wftDb.AgentSet)
            {
                //добавляем информацию, которую хотим видеть в строке comboBox-a
                string[] item = { agentSet.Id.ToString() + ".", agentSet.LastName, agentSet.FirstName.Remove(1)+".", agentSet.MiddleName.Remove(1)+".", };
                comboBoxAgents.Items.Add(string.Join(" ", item));
            }
        }
        void ShowClients()
        {
            //очищаем comboBox
            comboBoxClients.Items.Clear();
            foreach(ClientsSet clientsSet in Program.wftDb.ClientsSet)
            {
                //добавляем информацию, которую хотим видеть в строке comboBox-a
                string[] item = { clientsSet.Id.ToString() + ".", clientsSet.LastName, clientsSet.FirstName.Remove(1) + ". ", clientsSet.MiddleName.Remove(1) + " ." };
                comboBoxClients.Items.Add(string.Join(" ", item));
            }
        }
        void ShowRealEstate()
        {
            //очищаем comboBox
            comboBoxRealEstate.Items.Clear();
            foreach (RealEstateSet realEstateSet in Program.wftDb.RealEstateSet)
            {
                //добавляем информацию, которую хотим видеть в строке comboBox-a
                string[] item = { realEstateSet.Id.ToString() + ".", "г. " + realEstateSet.Address_City+",", "ул. " + realEstateSet.Address_Street+",",
                    "д. " + realEstateSet.Address_House+",", "кв. "+realEstateSet.Address_Number, "площадь: "+realEstateSet.TotalArea };
                comboBoxRealEstate.Items.Add(string.Join(" ", item));
            }
        }
        public FormSyply()
        {
            InitializeComponent();
            ShowAgents();
            ShowClients();
            ShowRealEstate();
            ShowSupplySet();
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void listViewSyplySet_SelectedIndexChanged(object sender, EventArgs e)
        {
            //если в listView выбран по тегу
            if(listViewSyplySet.SelectedItems.Count == 1)
            {
                SyppySet syppy = listViewSyplySet.SelectedItems[0].Tag as SyppySet;
                //указываем, что может быть изменено
                //находим в comboBoxAgents необходимую строку по Id риэлтора из supply.IdAgent и задаем ее отображение comboBox-y
                comboBoxAgents.SelectedIndex = comboBoxAgents.FindString(syppy.IdAgent.ToString());
                //точно также поступаем с comboBoxClients и comboBoxRealEstate
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(syppy.IdClient.ToString());
                comboBoxRealEstate.SelectedIndex = comboBoxRealEstate.FindString(syppy.IdRealEstate.ToString());
                textBoxPrice.Text = syppy.Price.ToString();
            }
            else
            {
                //если не выбран ни один элемент, задаем пустые элементы
                comboBoxAgents.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxRealEstate.SelectedItem = null;
                textBoxPrice.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Проверяем, что все поля (раскрывающихся списков и текствого поля) были заполнены
            if (comboBoxAgents.SelectedItem!=null && comboBoxClients.SelectedItem!=null &&
                comboBoxRealEstate!=null && textBoxPrice.Text!="")
            {
                //создаем новый экземпляр класса Предложение
                SyppySet supply = new SyppySet();
                //из выбранной строки в comboBoxAgents отделяем Id риэлтора (он отделен точкой) и делаем ссылку supply.IdAgent
                supply.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                //точно также отделяем и заносим Id клиента
                supply.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                //точно также отделяем и заносим Id объекта недвижимости
                supply.IdRealEstate = Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split('.')[0]);
                //цена объекта недвижимости чаще всего превосходит миллион, поэтому используем Int64
                supply.Price = Convert.ToInt64(textBoxPrice.Text);
                //добавляем в таблицу SupplySet новый объект недвижимости supply
                Program.wftDb.SyppySet.Add(supply);
                //сохраняем изменения в модели wftDb
                Program.wftDb.SaveChanges();
                ShowSupplySet();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //если в listView выбран элемент
            if (listViewSyplySet.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                SyppySet syppy = listViewSyplySet.SelectedItems[0].Tag as SyppySet;
                //указываем, что может быть изменено
                syppy.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                syppy.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                syppy.IdRealEstate = Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split('.')[0]);
                syppy.Price = Convert.ToInt64(textBoxPrice.Text);
                //Сохраняем изменения в модели wftDb (экземпляр которой был создан ранее)
                Program.wftDb.SaveChanges();
                ShowSupplySet();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            //пробуем совершить действие
            try
            {
                //если в listView выбран элемент
                if(listViewSyplySet.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    SyppySet syppy = listViewSyplySet.SelectedItems[0].Tag as SyppySet;
                    //удаляем из модели базы данных
                    Program.wftDb.SyppySet.Remove(syppy);
                    //сохраняем изменения
                    Program.wftDb.SaveChanges();
                    //отображаем обновленный список
                    ShowSupplySet();
                }
                //очищаем все поля
                comboBoxAgents.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxRealEstate.SelectedItem = null;
                textBoxPrice.Text = "";
            }
            //если возникает какая-то ошибка
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используются", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormRealEstate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45 && number != 43) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }
    }
}
