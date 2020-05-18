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
    public partial class FormDemand : Form
    {
        void ShowAgents()
        {
            //очищаем comboBox
            comboBoxAgents.Items.Clear();
            foreach (AgentSet agentSet in Program.wftDb.AgentSet)
            {
                //добавляем информацию, которую хотим видеть в строке comboBox-a
                string[] item = { agentSet.Id.ToString() + ".", agentSet.LastName, agentSet.FirstName.Remove(1) + ".", agentSet.MiddleName.Remove(1) + ".", };
                comboBoxAgents.Items.Add(string.Join(" ", item));
            }
        }
        void ShowClients()
        {
            //очищаем comboBox
            comboBoxClients.Items.Clear();
            foreach (ClientsSet clientsSet in Program.wftDb.ClientsSet)
            {
                //добавляем информацию, которую хотим видеть в строке comboBox-a
                string[] item = { clientsSet.Id.ToString() + ".", clientsSet.LastName, clientsSet.FirstName.Remove(1) + ". ", clientsSet.MiddleName.Remove(1) + " ." };
                comboBoxClients.Items.Add(string.Join(" ", item));
            }
        }
        void ShowDemandSet()
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                //Предварительно очищаем все listView
                listViewDemandSetRoom.Items.Clear();
                //Проходим по коллекции клиентов, которые находятся в базе с помощью foreach
                foreach (DemandSet demandSet in Program.wftDb.DemandSet)
                {
                    //Создадим новый элемент в listView с помощью массива строк
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    //указываем необходимые поля
                    //Id и ФИО агента
                    demandSet.IdAgent.ToString(),
                    demandSet.AgentSet.LastName +" "+demandSet.AgentSet.FirstName.Remove(1) +"."+ demandSet.AgentSet.MiddleName.Remove(1)+".",
                    //Id и ФИО клиента
                    demandSet.IdClient.ToString(),
                    demandSet.ClientsSet.LastName +" "+demandSet.ClientsSet.FirstName.Remove(1) +". "+ demandSet.ClientsSet.MiddleName.Remove(1)+" .",
                    //Тип объекта недвижимости
                    demandSet.Type.ToString(), 
                    //Min-max price
                    demandSet.MinPrice.ToString(), demandSet.MaxPrice.ToString(),
                    //Min-max square
                    demandSet.MinArea.ToString(), demandSet.MinArea.ToString(),
                    //Min-max Rooms
                    demandSet.MinRooms.ToString(), demandSet.MaxRooms.ToString(),
                    //Min-max Floor
                    demandSet.MinFloor.ToString(), demandSet.MaxFloor.ToString()
                    });
                    //указываем по какому тегу выбраны элементы
                    item.Tag = demandSet;
                    //добавляем элементы в listViewRealEstateSet_Apartament для отображения
                    listViewDemandSetRoom.Items.Add(item);
                }
            }
        }

        public FormDemand()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            ShowAgents();
            ShowClients();
            ShowDemandSet();
        }

        private void FormDemand_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Изменения формы, если выбрана строчка "Квартира" (ее индекс 0)
            if (comboBoxType.SelectedIndex == 0)
            {
                //Делаем видимыми нужные элементы
                listViewDemandSetRoom.Visible = true;
                labelAgent.Visible = true;
                comboBoxAgents.Visible = true;
                labelClient.Visible = true;
                comboBoxClients.Visible = true;
                labelMinPrice.Visible = true;
                labelMaxPrice.Visible = true;
                labelMinSquare.Visible = true;
                labelMaxSquare.Visible = true;
                labelMinRooms.Visible = true;
                labelMaxRooms.Visible = true;
                labelMinFloor.Visible = true;
                labelMaxFloor.Visible = true;
                textBoxMinPrice.Visible = true;
                textBoxMaxPrice.Visible = true;
                textBoxMinRooms.Visible = true;
                textBoxMaxRooms.Visible = true;
                textBoxMinFloor.Visible = true;
                textBoxMaxFloor.Visible = true;
                textBoxMinSquare.Visible = true;
                textBoxMaxSquare.Visible = true;

                //Скрываем ненужные элементы
                listViewDemandSetHouse.Visible = false;
                listViewDemandSetLand.Visible = false;
                labelMinFloors.Visible = false;
                labelMaxFloors.Visible = false;
                textBoxMinFloors.Visible = false;
                textBoxMaxFloors.Visible = false;

                //Очищаем все видимые элементы
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
                textBoxMinSquare.Text = "";
                textBoxMaxSquare.Text = "";
                comboBoxAgents.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
            }
            //Изменения формы, если выбрана строчка "Дом" (ее индекс 1)
            else if (comboBoxType.SelectedIndex == 1)
            {
                //Делаем видимыми нужные элементы
                listViewDemandSetHouse.Visible = true;
                labelAgent.Visible = true;
                comboBoxAgents.Visible = true;
                labelClient.Visible = true;
                comboBoxClients.Visible = true;
                labelMinPrice.Visible = true;
                labelMaxPrice.Visible = true;
                labelMinSquare.Visible = true;
                labelMaxSquare.Visible = true;
                labelMinFloors.Visible = true;
                labelMaxFloors.Visible = true;
                textBoxMinFloors.Visible = true;
                textBoxMaxFloors.Visible = true;
                textBoxMinSquare.Visible = true;
                textBoxMaxSquare.Visible = true;
                textBoxMinPrice.Visible = true;
                textBoxMaxPrice.Visible = true;

                //Скрываем ненужные элементы
                listViewDemandSetRoom.Visible = false;
                listViewDemandSetLand.Visible = false;
                labelMinRooms.Visible = false;
                labelMaxRooms.Visible = false;
                textBoxMaxRooms.Visible = false;
                textBoxMinRooms.Visible = false;
                labelMinFloor.Visible = false;
                labelMaxFloor.Visible = false;
                textBoxMinFloor.Visible = false;
                textBoxMaxFloor.Visible = false;

                //Очищаем все видимые элементы
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
                textBoxMinSquare.Text = "";
                textBoxMaxSquare.Text = "";
                comboBoxAgents.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
            }
            //Изменения формы, если выбрана строчка "Земля" (ее индекс 1)
            else if (comboBoxType.SelectedIndex == 2)
            {
                //Делаем видимыми нужные элементы
                listViewDemandSetLand.Visible = true;
                labelAgent.Visible = true;
                comboBoxAgents.Visible = true;
                labelClient.Visible = true;
                comboBoxClients.Visible = true;
                labelMinPrice.Visible = true;
                labelMaxPrice.Visible = true;
                labelMinSquare.Visible = true;
                labelMaxSquare.Visible = true;
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinSquare.Text = "";
                textBoxMaxSquare.Text = "";

                //Скрываем ненужные элементы
                listViewDemandSetRoom.Visible = false;
                listViewDemandSetHouse.Visible = false;
                labelMinRooms.Visible = false;
                labelMaxRooms.Visible = false;
                textBoxMaxRooms.Visible = false;
                textBoxMinRooms.Visible = false;
                labelMinFloor.Visible = false;
                labelMaxFloor.Visible = false;
                textBoxMinFloor.Visible = false;
                textBoxMaxFloor.Visible = false;
                labelMinFloors.Visible = false;
                labelMaxFloors.Visible = false;
                textBoxMinFloors.Visible = false;
                textBoxMaxFloors.Visible = false;

                //Очищаем все видимые элементы
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinSquare.Text = "";
                textBoxMaxSquare.Text = "";
                comboBoxAgents.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Проверяем, что все поля (раскрывающихся списков и текствого поля) были заполнены
            if (comboBoxAgents.SelectedItem != null && comboBoxClients.SelectedItem != null &&
                comboBoxType != null)
            {
                //создаем новый экземпляр класса Потребности
                DemandSet demand = new DemandSet();
                //из выбранной строки в comboBoxAgents отделяем Id риэлтора (он отделен точкой) и делаем ссылку demand.IdAgent
                demand.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                //точно также отделяем и заносим Id клиента
                demand.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                //цена объекта недвижимости чаще всего превосходит миллион, поэтому используем Int64
                demand.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
                demand.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                //Площадь есть у каждого типа
                demand.MinArea = Convert.ToInt32(textBoxMinSquare.Text);
                demand.MaxArea = Convert.ToInt32(textBoxMaxSquare.Text);
                if (comboBoxType.SelectedIndex == 0)
                {
                    demand.Type = 0;
                    demand.MinFloor = Convert.ToInt32(textBoxMinFloor.Text);
                    demand.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text);
                    demand.MinRooms = Convert.ToInt32(textBoxMinRooms.Text);
                    demand.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text);
                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    demand.Type = 1;
                    demand.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                    demand.MaxFloors = Convert.ToInt32(textBoxMinFloors.Text);
                }
                else if (comboBoxType.SelectedIndex == 2)
                {
                    demand.Type = 2;
                }
                //добавляем в таблицу DemandSet новый объект недвижимости demand
                Program.wftDb.DemandSet.Add(demand);
                //сохраняем изменения в модели wftDb
                Program.wftDb.SaveChanges();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
