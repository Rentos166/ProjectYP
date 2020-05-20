namespace Esoft_Project
{
    partial class FormRealEstate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.abelAddress_City = new System.Windows.Forms.Label();
            this.labelAddress_Street = new System.Windows.Forms.Label();
            this.labelAddress_House = new System.Windows.Forms.Label();
            this.labelAddress_Number = new System.Windows.Forms.Label();
            this.labelCoordinate_latitude = new System.Windows.Forms.Label();
            this.labelCoordinate_longitude = new System.Windows.Forms.Label();
            this.labelTotalArea = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelRooms = new System.Windows.Forms.Label();
            this.labelFloor = new System.Windows.Forms.Label();
            this.labelTotalFloors = new System.Windows.Forms.Label();
            this.listViewRealEstateSet_Apartment = new System.Windows.Forms.ListView();
            this.Город = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Улица = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Номер_дома = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Номер_квартиры = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Широта = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Долгота = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Площадь = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Количество_комнат = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Этаж = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxAddress_City = new System.Windows.Forms.TextBox();
            this.textBoxAddress_Street = new System.Windows.Forms.TextBox();
            this.textBoxAddress_House = new System.Windows.Forms.TextBox();
            this.textBoxAddress_Number = new System.Windows.Forms.TextBox();
            this.textBoxCoordinate_latitude = new System.Windows.Forms.TextBox();
            this.textBoxCoordinate_longitude = new System.Windows.Forms.TextBox();
            this.textBoxTotalArea = new System.Windows.Forms.TextBox();
            this.textBoxRooms = new System.Windows.Forms.TextBox();
            this.textBoxFloor = new System.Windows.Forms.TextBox();
            this.textBoxTotalFloors = new System.Windows.Forms.TextBox();
            this.listViewRealEstateSet_House = new System.Windows.Forms.ListView();
            this.Город2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Улица2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Номер_дома2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Номер_квартиры2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Широта2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Долгота2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Площадь2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Количество_этажей1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewRealEstateSet_Land = new System.Windows.Forms.ListView();
            this.Город1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Улица1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Номер_дома1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Номер_квартиры1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Широта1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Долгота1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Площадь1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Location = new System.Drawing.Point(351, 362);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(102, 32);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonEdit.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEdit.Location = new System.Drawing.Point(459, 362);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(102, 32);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDel.Location = new System.Drawing.Point(567, 362);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(102, 32);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Квартира",
            "Дом",
            "Земля"});
            this.comboBoxType.Location = new System.Drawing.Point(131, 108);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 3;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // abelAddress_City
            // 
            this.abelAddress_City.AutoSize = true;
            this.abelAddress_City.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.abelAddress_City.Location = new System.Drawing.Point(1, 13);
            this.abelAddress_City.Name = "abelAddress_City";
            this.abelAddress_City.Size = new System.Drawing.Size(41, 14);
            this.abelAddress_City.TabIndex = 4;
            this.abelAddress_City.Text = "Город";
            // 
            // labelAddress_Street
            // 
            this.labelAddress_Street.AutoSize = true;
            this.labelAddress_Street.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress_Street.Location = new System.Drawing.Point(1, 52);
            this.labelAddress_Street.Name = "labelAddress_Street";
            this.labelAddress_Street.Size = new System.Drawing.Size(42, 14);
            this.labelAddress_Street.TabIndex = 5;
            this.labelAddress_Street.Text = "Улица";
            // 
            // labelAddress_House
            // 
            this.labelAddress_House.AutoSize = true;
            this.labelAddress_House.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress_House.Location = new System.Drawing.Point(1, 92);
            this.labelAddress_House.Name = "labelAddress_House";
            this.labelAddress_House.Size = new System.Drawing.Size(76, 14);
            this.labelAddress_House.TabIndex = 6;
            this.labelAddress_House.Text = "Номер дома";
            // 
            // labelAddress_Number
            // 
            this.labelAddress_Number.AutoSize = true;
            this.labelAddress_Number.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress_Number.Location = new System.Drawing.Point(1, 131);
            this.labelAddress_Number.Name = "labelAddress_Number";
            this.labelAddress_Number.Size = new System.Drawing.Size(102, 14);
            this.labelAddress_Number.TabIndex = 7;
            this.labelAddress_Number.Text = "Номер квартиры";
            // 
            // labelCoordinate_latitude
            // 
            this.labelCoordinate_latitude.AutoSize = true;
            this.labelCoordinate_latitude.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoordinate_latitude.Location = new System.Drawing.Point(128, 12);
            this.labelCoordinate_latitude.Name = "labelCoordinate_latitude";
            this.labelCoordinate_latitude.Size = new System.Drawing.Size(52, 14);
            this.labelCoordinate_latitude.TabIndex = 8;
            this.labelCoordinate_latitude.Text = "Ширина";
            this.labelCoordinate_latitude.Click += new System.EventHandler(this.labelCoordinate_latitude_Click);
            // 
            // labelCoordinate_longitude
            // 
            this.labelCoordinate_longitude.AutoSize = true;
            this.labelCoordinate_longitude.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoordinate_longitude.Location = new System.Drawing.Point(128, 52);
            this.labelCoordinate_longitude.Name = "labelCoordinate_longitude";
            this.labelCoordinate_longitude.Size = new System.Drawing.Size(54, 14);
            this.labelCoordinate_longitude.TabIndex = 9;
            this.labelCoordinate_longitude.Text = "Долгота";
            // 
            // labelTotalArea
            // 
            this.labelTotalArea.AutoSize = true;
            this.labelTotalArea.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalArea.Location = new System.Drawing.Point(128, 131);
            this.labelTotalArea.Name = "labelTotalArea";
            this.labelTotalArea.Size = new System.Drawing.Size(58, 14);
            this.labelTotalArea.TabIndex = 10;
            this.labelTotalArea.Text = "Площадь";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelType.Location = new System.Drawing.Point(128, 92);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(30, 14);
            this.labelType.TabIndex = 11;
            this.labelType.Text = "Тип ";
            // 
            // labelRooms
            // 
            this.labelRooms.AutoSize = true;
            this.labelRooms.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRooms.Location = new System.Drawing.Point(255, 51);
            this.labelRooms.Name = "labelRooms";
            this.labelRooms.Size = new System.Drawing.Size(118, 14);
            this.labelRooms.TabIndex = 12;
            this.labelRooms.Text = "Количество комнат";
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFloor.Location = new System.Drawing.Point(255, 15);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(36, 14);
            this.labelFloor.TabIndex = 13;
            this.labelFloor.Text = "Этаж";
            // 
            // labelTotalFloors
            // 
            this.labelTotalFloors.AutoSize = true;
            this.labelTotalFloors.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalFloors.Location = new System.Drawing.Point(255, 12);
            this.labelTotalFloors.Name = "labelTotalFloors";
            this.labelTotalFloors.Size = new System.Drawing.Size(117, 14);
            this.labelTotalFloors.TabIndex = 14;
            this.labelTotalFloors.Text = "Количество этажей";
            this.labelTotalFloors.Visible = false;
            // 
            // listViewRealEstateSet_Apartment
            // 
            this.listViewRealEstateSet_Apartment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Город,
            this.Улица,
            this.Номер_дома,
            this.Номер_квартиры,
            this.Широта,
            this.Долгота,
            this.Площадь,
            this.Количество_комнат,
            this.Этаж});
            this.listViewRealEstateSet_Apartment.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewRealEstateSet_Apartment.FullRowSelect = true;
            this.listViewRealEstateSet_Apartment.GridLines = true;
            this.listViewRealEstateSet_Apartment.HideSelection = false;
            this.listViewRealEstateSet_Apartment.Location = new System.Drawing.Point(4, 173);
            this.listViewRealEstateSet_Apartment.MultiSelect = false;
            this.listViewRealEstateSet_Apartment.Name = "listViewRealEstateSet_Apartment";
            this.listViewRealEstateSet_Apartment.Size = new System.Drawing.Size(660, 174);
            this.listViewRealEstateSet_Apartment.TabIndex = 15;
            this.listViewRealEstateSet_Apartment.UseCompatibleStateImageBehavior = false;
            this.listViewRealEstateSet_Apartment.View = System.Windows.Forms.View.Details;
            this.listViewRealEstateSet_Apartment.SelectedIndexChanged += new System.EventHandler(this.listViewRealEstateSet_Apartment_SelectedIndexChanged);
            // 
            // Город
            // 
            this.Город.Text = "Город";
            // 
            // Улица
            // 
            this.Улица.Text = "Улица";
            // 
            // Номер_дома
            // 
            this.Номер_дома.Text = "Номер дома";
            this.Номер_дома.Width = 80;
            // 
            // Номер_квартиры
            // 
            this.Номер_квартиры.Text = "Номер квартиры";
            this.Номер_квартиры.Width = 103;
            // 
            // Широта
            // 
            this.Широта.Text = "Широта";
            // 
            // Долгота
            // 
            this.Долгота.Text = "Долгота";
            // 
            // Площадь
            // 
            this.Площадь.Text = "Площадь";
            // 
            // Количество_комнат
            // 
            this.Количество_комнат.Text = "Количество комнат";
            this.Количество_комнат.Width = 113;
            // 
            // Этаж
            // 
            this.Этаж.Text = "Этаж";
            // 
            // textBoxAddress_City
            // 
            this.textBoxAddress_City.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxAddress_City.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxAddress_City.Location = new System.Drawing.Point(4, 29);
            this.textBoxAddress_City.Name = "textBoxAddress_City";
            this.textBoxAddress_City.Size = new System.Drawing.Size(121, 20);
            this.textBoxAddress_City.TabIndex = 16;
            this.textBoxAddress_City.TextChanged += new System.EventHandler(this.textBoxAddress_City_TextChanged);
            this.textBoxAddress_City.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRealEstate_KeyPress);
            // 
            // textBoxAddress_Street
            // 
            this.textBoxAddress_Street.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxAddress_Street.Location = new System.Drawing.Point(4, 68);
            this.textBoxAddress_Street.Name = "textBoxAddress_Street";
            this.textBoxAddress_Street.Size = new System.Drawing.Size(121, 20);
            this.textBoxAddress_Street.TabIndex = 17;
            this.textBoxAddress_Street.TextChanged += new System.EventHandler(this.textBoxAddress_Street_TextChanged);
            this.textBoxAddress_Street.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRealEstate_KeyPress);
            // 
            // textBoxAddress_House
            // 
            this.textBoxAddress_House.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxAddress_House.Location = new System.Drawing.Point(4, 108);
            this.textBoxAddress_House.Name = "textBoxAddress_House";
            this.textBoxAddress_House.Size = new System.Drawing.Size(121, 20);
            this.textBoxAddress_House.TabIndex = 18;
            this.textBoxAddress_House.TextChanged += new System.EventHandler(this.textBoxAddress_House_TextChanged);
            this.textBoxAddress_House.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRealEstate_KeyPress);
            // 
            // textBoxAddress_Number
            // 
            this.textBoxAddress_Number.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxAddress_Number.Location = new System.Drawing.Point(4, 147);
            this.textBoxAddress_Number.Name = "textBoxAddress_Number";
            this.textBoxAddress_Number.Size = new System.Drawing.Size(121, 20);
            this.textBoxAddress_Number.TabIndex = 19;
            this.textBoxAddress_Number.TextChanged += new System.EventHandler(this.textBoxAddress_Number_TextChanged);
            this.textBoxAddress_Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRealEstate_KeyPress);
            // 
            // textBoxCoordinate_latitude
            // 
            this.textBoxCoordinate_latitude.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxCoordinate_latitude.Location = new System.Drawing.Point(131, 29);
            this.textBoxCoordinate_latitude.Name = "textBoxCoordinate_latitude";
            this.textBoxCoordinate_latitude.Size = new System.Drawing.Size(121, 20);
            this.textBoxCoordinate_latitude.TabIndex = 20;
            this.textBoxCoordinate_latitude.TextChanged += new System.EventHandler(this.textBoxCoordinate_latitude_TextChanged);
            this.textBoxCoordinate_latitude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRealEstate_KeyPress);
            // 
            // textBoxCoordinate_longitude
            // 
            this.textBoxCoordinate_longitude.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxCoordinate_longitude.Location = new System.Drawing.Point(131, 68);
            this.textBoxCoordinate_longitude.Name = "textBoxCoordinate_longitude";
            this.textBoxCoordinate_longitude.Size = new System.Drawing.Size(121, 20);
            this.textBoxCoordinate_longitude.TabIndex = 21;
            this.textBoxCoordinate_longitude.TextChanged += new System.EventHandler(this.textBoxCoordinate_longitude_TextChanged);
            this.textBoxCoordinate_longitude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRealEstate_KeyPress);
            // 
            // textBoxTotalArea
            // 
            this.textBoxTotalArea.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxTotalArea.Location = new System.Drawing.Point(131, 147);
            this.textBoxTotalArea.Name = "textBoxTotalArea";
            this.textBoxTotalArea.Size = new System.Drawing.Size(121, 20);
            this.textBoxTotalArea.TabIndex = 22;
            this.textBoxTotalArea.TextChanged += new System.EventHandler(this.textBoxTotalArea_TextChanged);
            this.textBoxTotalArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRealEstate_KeyPress);
            // 
            // textBoxRooms
            // 
            this.textBoxRooms.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxRooms.Location = new System.Drawing.Point(258, 67);
            this.textBoxRooms.Name = "textBoxRooms";
            this.textBoxRooms.Size = new System.Drawing.Size(121, 20);
            this.textBoxRooms.TabIndex = 23;
            this.textBoxRooms.TextChanged += new System.EventHandler(this.textBoxRooms_TextChanged);
            this.textBoxRooms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRealEstate_KeyPress);
            // 
            // textBoxFloor
            // 
            this.textBoxFloor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxFloor.Location = new System.Drawing.Point(258, 29);
            this.textBoxFloor.Name = "textBoxFloor";
            this.textBoxFloor.Size = new System.Drawing.Size(121, 20);
            this.textBoxFloor.TabIndex = 24;
            this.textBoxFloor.TextChanged += new System.EventHandler(this.textBoxFloor_TextChanged);
            this.textBoxFloor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRealEstate_KeyPress);
            // 
            // textBoxTotalFloors
            // 
            this.textBoxTotalFloors.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxTotalFloors.Location = new System.Drawing.Point(258, 29);
            this.textBoxTotalFloors.Name = "textBoxTotalFloors";
            this.textBoxTotalFloors.Size = new System.Drawing.Size(121, 20);
            this.textBoxTotalFloors.TabIndex = 25;
            this.textBoxTotalFloors.Visible = false;
            this.textBoxTotalFloors.TextChanged += new System.EventHandler(this.textBoxTotalFloors_TextChanged);
            this.textBoxTotalFloors.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRealEstate_KeyPress);
            // 
            // listViewRealEstateSet_House
            // 
            this.listViewRealEstateSet_House.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Город2,
            this.Улица2,
            this.Номер_дома2,
            this.Номер_квартиры2,
            this.Широта2,
            this.Долгота2,
            this.Площадь2,
            this.Количество_этажей1});
            this.listViewRealEstateSet_House.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewRealEstateSet_House.FullRowSelect = true;
            this.listViewRealEstateSet_House.GridLines = true;
            this.listViewRealEstateSet_House.HideSelection = false;
            this.listViewRealEstateSet_House.Location = new System.Drawing.Point(4, 173);
            this.listViewRealEstateSet_House.MultiSelect = false;
            this.listViewRealEstateSet_House.Name = "listViewRealEstateSet_House";
            this.listViewRealEstateSet_House.Size = new System.Drawing.Size(665, 174);
            this.listViewRealEstateSet_House.TabIndex = 26;
            this.listViewRealEstateSet_House.UseCompatibleStateImageBehavior = false;
            this.listViewRealEstateSet_House.View = System.Windows.Forms.View.Details;
            this.listViewRealEstateSet_House.Visible = false;
            this.listViewRealEstateSet_House.SelectedIndexChanged += new System.EventHandler(this.listViewRealEstateSet_House_SelectedIndexChanged);
            // 
            // Город2
            // 
            this.Город2.Text = "Город";
            this.Город2.Width = 73;
            // 
            // Улица2
            // 
            this.Улица2.Text = "Улица";
            // 
            // Номер_дома2
            // 
            this.Номер_дома2.Text = "Номер дома";
            this.Номер_дома2.Width = 80;
            // 
            // Номер_квартиры2
            // 
            this.Номер_квартиры2.Text = "Номер квартиры";
            this.Номер_квартиры2.Width = 106;
            // 
            // Широта2
            // 
            this.Широта2.Text = "Широта";
            this.Широта2.Width = 71;
            // 
            // Долгота2
            // 
            this.Долгота2.Text = "Долгота";
            this.Долгота2.Width = 74;
            // 
            // Площадь2
            // 
            this.Площадь2.Text = "Площадь";
            this.Площадь2.Width = 86;
            // 
            // Количество_этажей1
            // 
            this.Количество_этажей1.Text = "Количество этажей";
            this.Количество_этажей1.Width = 111;
            // 
            // listViewRealEstateSet_Land
            // 
            this.listViewRealEstateSet_Land.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Город1,
            this.Улица1,
            this.Номер_дома1,
            this.Номер_квартиры1,
            this.Широта1,
            this.Долгота1,
            this.Площадь1});
            this.listViewRealEstateSet_Land.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewRealEstateSet_Land.FullRowSelect = true;
            this.listViewRealEstateSet_Land.GridLines = true;
            this.listViewRealEstateSet_Land.HideSelection = false;
            this.listViewRealEstateSet_Land.Location = new System.Drawing.Point(4, 173);
            this.listViewRealEstateSet_Land.MultiSelect = false;
            this.listViewRealEstateSet_Land.Name = "listViewRealEstateSet_Land";
            this.listViewRealEstateSet_Land.Size = new System.Drawing.Size(665, 174);
            this.listViewRealEstateSet_Land.TabIndex = 27;
            this.listViewRealEstateSet_Land.UseCompatibleStateImageBehavior = false;
            this.listViewRealEstateSet_Land.View = System.Windows.Forms.View.Details;
            this.listViewRealEstateSet_Land.Visible = false;
            this.listViewRealEstateSet_Land.SelectedIndexChanged += new System.EventHandler(this.listViewRealEstateSet_Land_SelectedIndexChanged);
            // 
            // Город1
            // 
            this.Город1.Text = "Город";
            this.Город1.Width = 83;
            // 
            // Улица1
            // 
            this.Улица1.Text = "Улица";
            this.Улица1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Улица1.Width = 74;
            // 
            // Номер_дома1
            // 
            this.Номер_дома1.Text = "Номер дома";
            this.Номер_дома1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Номер_дома1.Width = 120;
            // 
            // Номер_квартиры1
            // 
            this.Номер_квартиры1.Text = "Номер квартиры";
            this.Номер_квартиры1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Номер_квартиры1.Width = 128;
            // 
            // Широта1
            // 
            this.Широта1.Text = "Широта";
            this.Широта1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Широта1.Width = 81;
            // 
            // Долгота1
            // 
            this.Долгота1.Text = "Долгота";
            this.Долгота1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Долгота1.Width = 86;
            // 
            // Площадь1
            // 
            this.Площадь1.Text = "Площадь";
            this.Площадь1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Площадь1.Width = 90;
            // 
            // Logo
            // 
            this.Logo.Image = global::Esoft_Project.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(397, 8);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(267, 148);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 28;
            this.Logo.TabStop = false;
            // 
            // FormRealEstate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(673, 398);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.listViewRealEstateSet_Land);
            this.Controls.Add(this.listViewRealEstateSet_House);
            this.Controls.Add(this.textBoxTotalFloors);
            this.Controls.Add(this.textBoxFloor);
            this.Controls.Add(this.textBoxRooms);
            this.Controls.Add(this.textBoxTotalArea);
            this.Controls.Add(this.textBoxCoordinate_longitude);
            this.Controls.Add(this.textBoxCoordinate_latitude);
            this.Controls.Add(this.textBoxAddress_Number);
            this.Controls.Add(this.textBoxAddress_House);
            this.Controls.Add(this.textBoxAddress_Street);
            this.Controls.Add(this.textBoxAddress_City);
            this.Controls.Add(this.listViewRealEstateSet_Apartment);
            this.Controls.Add(this.labelTotalFloors);
            this.Controls.Add(this.labelFloor);
            this.Controls.Add(this.labelRooms);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelTotalArea);
            this.Controls.Add(this.labelCoordinate_longitude);
            this.Controls.Add(this.labelCoordinate_latitude);
            this.Controls.Add(this.labelAddress_Number);
            this.Controls.Add(this.labelAddress_House);
            this.Controls.Add(this.labelAddress_Street);
            this.Controls.Add(this.abelAddress_City);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormRealEstate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Объекты недвижимости";
            this.Load += new System.EventHandler(this.FormRealEstate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label abelAddress_City;
        private System.Windows.Forms.Label labelAddress_Street;
        private System.Windows.Forms.Label labelAddress_House;
        private System.Windows.Forms.Label labelAddress_Number;
        private System.Windows.Forms.Label labelCoordinate_latitude;
        private System.Windows.Forms.Label labelCoordinate_longitude;
        private System.Windows.Forms.Label labelTotalArea;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelRooms;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.Label labelTotalFloors;
        private System.Windows.Forms.ListView listViewRealEstateSet_Apartment;
        private System.Windows.Forms.TextBox textBoxAddress_City;
        private System.Windows.Forms.TextBox textBoxAddress_Street;
        private System.Windows.Forms.TextBox textBoxAddress_House;
        private System.Windows.Forms.TextBox textBoxAddress_Number;
        private System.Windows.Forms.TextBox textBoxCoordinate_latitude;
        private System.Windows.Forms.TextBox textBoxCoordinate_longitude;
        private System.Windows.Forms.TextBox textBoxTotalArea;
        private System.Windows.Forms.TextBox textBoxRooms;
        private System.Windows.Forms.TextBox textBoxFloor;
        private System.Windows.Forms.TextBox textBoxTotalFloors;
        private System.Windows.Forms.ListView listViewRealEstateSet_House;
        private System.Windows.Forms.ListView listViewRealEstateSet_Land;
        private System.Windows.Forms.ColumnHeader Город;
        private System.Windows.Forms.ColumnHeader Улица;
        private System.Windows.Forms.ColumnHeader Номер_дома;
        private System.Windows.Forms.ColumnHeader Номер_квартиры;
        private System.Windows.Forms.ColumnHeader Широта;
        private System.Windows.Forms.ColumnHeader Долгота;
        private System.Windows.Forms.ColumnHeader Площадь;
        private System.Windows.Forms.ColumnHeader Количество_комнат;
        private System.Windows.Forms.ColumnHeader Этаж;
        private System.Windows.Forms.ColumnHeader Город2;
        private System.Windows.Forms.ColumnHeader Улица2;
        private System.Windows.Forms.ColumnHeader Номер_дома2;
        private System.Windows.Forms.ColumnHeader Номер_квартиры2;
        private System.Windows.Forms.ColumnHeader Широта2;
        private System.Windows.Forms.ColumnHeader Долгота2;
        private System.Windows.Forms.ColumnHeader Площадь2;
        private System.Windows.Forms.ColumnHeader Количество_этажей1;
        private System.Windows.Forms.ColumnHeader Город1;
        private System.Windows.Forms.ColumnHeader Улица1;
        private System.Windows.Forms.ColumnHeader Номер_дома1;
        private System.Windows.Forms.ColumnHeader Номер_квартиры1;
        private System.Windows.Forms.ColumnHeader Широта1;
        private System.Windows.Forms.ColumnHeader Долгота1;
        private System.Windows.Forms.ColumnHeader Площадь1;
        private System.Windows.Forms.PictureBox Logo;
    }
}