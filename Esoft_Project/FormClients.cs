﻿using System;
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

    public partial class FormClients : Form
    {
        void ShowClient()
        {
            //Предварительно очищаем listView
            listViewClient.Items.Clear();
            //Проходимся по коллекции клиентов, которые находятся в базе с помощью foreach
            foreach (ClientsSet clientsSet in Program.wftDb.ClientsSet)
            {
                //создаем новый элемент в listView
                //для этого создаем новый массив строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    //указываем необходимые поля
                    clientsSet.Id.ToString(),
                    clientsSet.FirstName,
                    clientsSet.MiddleName,
                    clientsSet.LastName,
                    clientsSet.Phone,
                    clientsSet.Email

                });
                //указываем по какому тегу будем брать элементы
                item.Tag = clientsSet;
                //добавляем элементы в listView для отображения
                listViewClient.Items.Add(item);
            }
            //выравниваем колонки в listView
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public FormClients()
        {
            InitializeComponent();
            ShowClient();
        }

        private void FormClients_Load(object sender, EventArgs e)
        {

        }

        private void labelLastName_Click(object sender, EventArgs e)
        {

        }

        private void labelMiddleName_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Создаем новый экземпляр класса Клиент
            ClientsSet clientsSet = new ClientsSet();
            //Делаем ссылку на объект, который хранится в textBox-ax
            clientsSet.FirstName = textBoxFirstName.Text;
            clientsSet.MiddleName = textBoxMiddleName.Text;
            clientsSet.LastName = textBoxLastName.Text;
            clientsSet.Phone = textBoxPhone.Text;
            clientsSet.Email = textBoxEmail.Text;
            //Добавляем в таблицу ClientsSet нового клиента clientSet
            Program.wftDb.ClientsSet.Add(clientsSet);
            //Сохраняем изменения в модели wftDb (экземпляр которой был создан ранее)
            Program.wftDb.SaveChanges();
            ShowClient();
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            //условие, если выбран 1 элемент
            if (listViewClient.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                ClientsSet clientsSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                //указываем, что может быть изменено
                textBoxFirstName.Text = clientsSet.FirstName;
                textBoxMiddleName.Text = clientsSet.MiddleName;
                textBoxLastName.Text = clientsSet.LastName;
                textBoxPhone.Text = clientsSet.Phone;
                textBoxEmail.Text = clientsSet.Email;
                ShowSupplySet(clientsSet);
                ShowDemandSet(clientsSet);
            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задаем пустые поля
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //условие, если в listView выбран 1 элемент
            if (listViewClient.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                ClientsSet clientsSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                //указываем, что может быть изменено
                clientsSet.FirstName = textBoxFirstName.Text;
                clientsSet.MiddleName = textBoxMiddleName.Text;
                clientsSet.LastName = textBoxLastName.Text;
                clientsSet.Phone = textBoxPhone.Text;
                clientsSet.Email = textBoxEmail.Text;
                //Сохраняем изменения в модели wftDb (экземпляр которой был создан ранее)
                Program.wftDb.SaveChanges();
                ShowClient();
            }

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            //пробуем совершить действие
            try
            {
                //если выбран 1 элемент из listView
                if (listViewClient.SelectedItems.Count == 1)
                {
                    //ищем этот элемент
                    ClientsSet clientsSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                    //удаляем из модели и базы данных
                    Program.wftDb.ClientsSet.Remove(clientsSet);
                    //сохраняем изменения
                    Program.wftDb.SaveChanges();
                    //отображаем обновленный список
                    ShowClient();
                }
                //очищаем textBox-ы
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            //если возникает какая-то ошибка, к примеру, запись используется, выводим всплывающее сообщение
            catch
            {
                //вызываем метод для всплывающего окна, в котором указываем текст, заголовок, кнопку и иконку
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ShowSupplySet(ClientsSet clientsSet)
        {
            //очищаем listView
            listViewSupplySet.Items.Clear();
            //проходим по коллекции
            foreach (SyppySet syppy in Program.wftDb.SyppySet)
            {
                if (clientsSet.Id == syppy.IdClient)
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
       void ShowDemandSet(ClientsSet clientsSet)
        {
            //очищаем listView
            listViewDemandSet.Items.Clear();
            //проходим по коллекции
            foreach (DemandSet demand in Program.wftDb.DemandSet)
            {
                if (clientsSet.Id == demand.IdClient)
                {
                    //Создаем новый элемент
                    ListViewItem item = new ListViewItem(new string[]
                    {
                         //Риелтор
                         demand.AgentSet.LastName +" "+demand.AgentSet.FirstName.Remove(1) +". "+ demand.AgentSet.MiddleName.Remove(1)+" .",
                         //Клиент
                         demand.ClientsSet.LastName +" "+demand.ClientsSet.FirstName.Remove(1) +". "+ demand.ClientsSet.MiddleName.Remove(1)+" .",
                         //тип о.н.
                         demand.Type.ToString(),
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
        private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

