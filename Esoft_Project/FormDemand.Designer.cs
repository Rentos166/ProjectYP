namespace Esoft_Project
{
    partial class FormDemand
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
            this.labelAgent = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelMinPrice = new System.Windows.Forms.Label();
            this.labelMaxPrice = new System.Windows.Forms.Label();
            this.comboBoxAgents = new System.Windows.Forms.ComboBox();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxMinPrice = new System.Windows.Forms.TextBox();
            this.textBoxMaxPrice = new System.Windows.Forms.TextBox();
            this.listViewDemandSetRoom = new System.Windows.Forms.ListView();
            this.IdAgent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FIOAgent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FIOClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeON = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Min = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Max = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinSquare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxSquare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinRooms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxRooms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinFloor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxFloor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelMinSquare = new System.Windows.Forms.Label();
            this.labelMaxSquare = new System.Windows.Forms.Label();
            this.labelMinRooms = new System.Windows.Forms.Label();
            this.labelMaxRooms = new System.Windows.Forms.Label();
            this.labelMinFloor = new System.Windows.Forms.Label();
            this.labelMaxFloor = new System.Windows.Forms.Label();
            this.textBoxMinSquare = new System.Windows.Forms.TextBox();
            this.textBoxMaxSquare = new System.Windows.Forms.TextBox();
            this.textBoxMinRooms = new System.Windows.Forms.TextBox();
            this.textBoxMaxRooms = new System.Windows.Forms.TextBox();
            this.textBoxMinFloor = new System.Windows.Forms.TextBox();
            this.textBoxMaxFloor = new System.Windows.Forms.TextBox();
            this.listViewDemandSetHouse = new System.Windows.Forms.ListView();
            this.IdAgent2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FIOAgent2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdClient2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FioClient2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type_On = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Min_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Max_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Min_square = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Max_square = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinFloors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxFloors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDemandSetLand = new System.Windows.Forms.ListView();
            this.IdAgent1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FioAgent1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdClient1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FioClient1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type_ON1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Minprice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Maxprice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinSquare1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxSquare1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxMaxFloors = new System.Windows.Forms.TextBox();
            this.textBoxMinFloors = new System.Windows.Forms.TextBox();
            this.labelMaxFloors = new System.Windows.Forms.Label();
            this.labelMinFloors = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAgent
            // 
            this.labelAgent.AutoSize = true;
            this.labelAgent.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAgent.Location = new System.Drawing.Point(10, 6);
            this.labelAgent.Name = "labelAgent";
            this.labelAgent.Size = new System.Drawing.Size(56, 15);
            this.labelAgent.TabIndex = 0;
            this.labelAgent.Text = "Риелтор";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClient.Location = new System.Drawing.Point(10, 52);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(49, 15);
            this.labelClient.TabIndex = 1;
            this.labelClient.Text = "Клиент";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelType.Location = new System.Drawing.Point(10, 98);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(54, 15);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "Тип О.Н.";
            // 
            // labelMinPrice
            // 
            this.labelMinPrice.AutoSize = true;
            this.labelMinPrice.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinPrice.Location = new System.Drawing.Point(10, 144);
            this.labelMinPrice.Name = "labelMinPrice";
            this.labelMinPrice.Size = new System.Drawing.Size(66, 15);
            this.labelMinPrice.TabIndex = 3;
            this.labelMinPrice.Text = "Мин. цена";
            // 
            // labelMaxPrice
            // 
            this.labelMaxPrice.AutoSize = true;
            this.labelMaxPrice.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxPrice.Location = new System.Drawing.Point(10, 189);
            this.labelMaxPrice.Name = "labelMaxPrice";
            this.labelMaxPrice.Size = new System.Drawing.Size(73, 15);
            this.labelMaxPrice.TabIndex = 4;
            this.labelMaxPrice.Text = "Макс. цена";
            // 
            // comboBoxAgents
            // 
            this.comboBoxAgents.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboBoxAgents.FormattingEnabled = true;
            this.comboBoxAgents.Location = new System.Drawing.Point(14, 24);
            this.comboBoxAgents.Name = "comboBoxAgents";
            this.comboBoxAgents.Size = new System.Drawing.Size(150, 23);
            this.comboBoxAgents.TabIndex = 6;
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(14, 70);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(150, 23);
            this.comboBoxClients.TabIndex = 7;
            // 
            // comboBoxType
            // 
            this.comboBoxType.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Квартира",
            "Дом",
            "Земля"});
            this.comboBoxType.Location = new System.Drawing.Point(14, 117);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(150, 23);
            this.comboBoxType.TabIndex = 8;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // textBoxMinPrice
            // 
            this.textBoxMinPrice.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxMinPrice.Location = new System.Drawing.Point(14, 163);
            this.textBoxMinPrice.Name = "textBoxMinPrice";
            this.textBoxMinPrice.Size = new System.Drawing.Size(150, 23);
            this.textBoxMinPrice.TabIndex = 9;
            this.textBoxMinPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormDemand_KeyPress);
            // 
            // textBoxMaxPrice
            // 
            this.textBoxMaxPrice.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxMaxPrice.Location = new System.Drawing.Point(14, 208);
            this.textBoxMaxPrice.Name = "textBoxMaxPrice";
            this.textBoxMaxPrice.Size = new System.Drawing.Size(150, 23);
            this.textBoxMaxPrice.TabIndex = 10;
            this.textBoxMaxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormDemand_KeyPress);
            // 
            // listViewDemandSetRoom
            // 
            this.listViewDemandSetRoom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdAgent,
            this.FIOAgent,
            this.IdClient,
            this.FIOClient,
            this.TypeON,
            this.Min,
            this.Max,
            this.MinSquare,
            this.MaxSquare,
            this.MinRooms,
            this.MaxRooms,
            this.MinFloor,
            this.MaxFloor});
            this.listViewDemandSetRoom.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewDemandSetRoom.FullRowSelect = true;
            this.listViewDemandSetRoom.GridLines = true;
            this.listViewDemandSetRoom.HideSelection = false;
            this.listViewDemandSetRoom.Location = new System.Drawing.Point(170, 110);
            this.listViewDemandSetRoom.MultiSelect = false;
            this.listViewDemandSetRoom.Name = "listViewDemandSetRoom";
            this.listViewDemandSetRoom.Size = new System.Drawing.Size(1115, 211);
            this.listViewDemandSetRoom.TabIndex = 11;
            this.listViewDemandSetRoom.UseCompatibleStateImageBehavior = false;
            this.listViewDemandSetRoom.View = System.Windows.Forms.View.Details;
            this.listViewDemandSetRoom.SelectedIndexChanged += new System.EventHandler(this.listViewDemandSetRoom_SelectedIndexChanged);
            // 
            // IdAgent
            // 
            this.IdAgent.Text = "ID риелтора";
            this.IdAgent.Width = 76;
            // 
            // FIOAgent
            // 
            this.FIOAgent.Text = "ФИО риелтора";
            this.FIOAgent.Width = 91;
            // 
            // IdClient
            // 
            this.IdClient.Text = "ID клиента";
            this.IdClient.Width = 73;
            // 
            // FIOClient
            // 
            this.FIOClient.Text = "ФИО клиента";
            this.FIOClient.Width = 93;
            // 
            // TypeON
            // 
            this.TypeON.Text = "Тип О.Н.";
            this.TypeON.Width = 59;
            // 
            // Min
            // 
            this.Min.Text = "Мин. цена";
            this.Min.Width = 75;
            // 
            // Max
            // 
            this.Max.Text = "Макс. цена";
            this.Max.Width = 83;
            // 
            // MinSquare
            // 
            this.MinSquare.Text = "Мин. площадь";
            this.MinSquare.Width = 90;
            // 
            // MaxSquare
            // 
            this.MaxSquare.Text = "Макс. площадь";
            this.MaxSquare.Width = 93;
            // 
            // MinRooms
            // 
            this.MinRooms.Text = "Мин. кол-во комнат";
            this.MinRooms.Width = 118;
            // 
            // MaxRooms
            // 
            this.MaxRooms.Text = "Макс кол-во комнат";
            this.MaxRooms.Width = 121;
            // 
            // MinFloor
            // 
            this.MinFloor.Text = "Мин. этаж";
            this.MinFloor.Width = 67;
            // 
            // MaxFloor
            // 
            this.MaxFloor.Text = "Макс. этаж";
            this.MaxFloor.Width = 82;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDel.Location = new System.Drawing.Point(828, 357);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(189, 76);
            this.buttonDel.TabIndex = 14;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonEdit.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEdit.Location = new System.Drawing.Point(633, 357);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(189, 76);
            this.buttonEdit.TabIndex = 13;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Location = new System.Drawing.Point(437, 357);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(189, 76);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelMinSquare
            // 
            this.labelMinSquare.AutoSize = true;
            this.labelMinSquare.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinSquare.Location = new System.Drawing.Point(10, 234);
            this.labelMinSquare.Name = "labelMinSquare";
            this.labelMinSquare.Size = new System.Drawing.Size(90, 15);
            this.labelMinSquare.TabIndex = 15;
            this.labelMinSquare.Text = "Мин. площадь";
            // 
            // labelMaxSquare
            // 
            this.labelMaxSquare.AutoSize = true;
            this.labelMaxSquare.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxSquare.Location = new System.Drawing.Point(10, 279);
            this.labelMaxSquare.Name = "labelMaxSquare";
            this.labelMaxSquare.Size = new System.Drawing.Size(97, 15);
            this.labelMaxSquare.TabIndex = 16;
            this.labelMaxSquare.Text = "Макс. площадь";
            // 
            // labelMinRooms
            // 
            this.labelMinRooms.AutoSize = true;
            this.labelMinRooms.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinRooms.Location = new System.Drawing.Point(10, 324);
            this.labelMinRooms.Name = "labelMinRooms";
            this.labelMinRooms.Size = new System.Drawing.Size(154, 15);
            this.labelMinRooms.TabIndex = 17;
            this.labelMinRooms.Text = "Мин. количество комнат";
            // 
            // labelMaxRooms
            // 
            this.labelMaxRooms.AutoSize = true;
            this.labelMaxRooms.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxRooms.Location = new System.Drawing.Point(10, 369);
            this.labelMaxRooms.Name = "labelMaxRooms";
            this.labelMaxRooms.Size = new System.Drawing.Size(161, 15);
            this.labelMaxRooms.TabIndex = 18;
            this.labelMaxRooms.Text = "Макс. количество комнат";
            // 
            // labelMinFloor
            // 
            this.labelMinFloor.AutoSize = true;
            this.labelMinFloor.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinFloor.Location = new System.Drawing.Point(10, 415);
            this.labelMinFloor.Name = "labelMinFloor";
            this.labelMinFloor.Size = new System.Drawing.Size(67, 15);
            this.labelMinFloor.TabIndex = 19;
            this.labelMinFloor.Text = "Мин. этаж";
            // 
            // labelMaxFloor
            // 
            this.labelMaxFloor.AutoSize = true;
            this.labelMaxFloor.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxFloor.Location = new System.Drawing.Point(10, 467);
            this.labelMaxFloor.Name = "labelMaxFloor";
            this.labelMaxFloor.Size = new System.Drawing.Size(74, 15);
            this.labelMaxFloor.TabIndex = 20;
            this.labelMaxFloor.Text = "Макс. этаж";
            // 
            // textBoxMinSquare
            // 
            this.textBoxMinSquare.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxMinSquare.Location = new System.Drawing.Point(14, 253);
            this.textBoxMinSquare.Name = "textBoxMinSquare";
            this.textBoxMinSquare.Size = new System.Drawing.Size(150, 23);
            this.textBoxMinSquare.TabIndex = 21;
            this.textBoxMinSquare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormDemand_KeyPress);
            // 
            // textBoxMaxSquare
            // 
            this.textBoxMaxSquare.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxMaxSquare.Location = new System.Drawing.Point(14, 298);
            this.textBoxMaxSquare.Name = "textBoxMaxSquare";
            this.textBoxMaxSquare.Size = new System.Drawing.Size(150, 23);
            this.textBoxMaxSquare.TabIndex = 22;
            this.textBoxMaxSquare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormDemand_KeyPress);
            // 
            // textBoxMinRooms
            // 
            this.textBoxMinRooms.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxMinRooms.Location = new System.Drawing.Point(14, 343);
            this.textBoxMinRooms.Name = "textBoxMinRooms";
            this.textBoxMinRooms.Size = new System.Drawing.Size(150, 23);
            this.textBoxMinRooms.TabIndex = 23;
            this.textBoxMinRooms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormDemand_KeyPress);
            // 
            // textBoxMaxRooms
            // 
            this.textBoxMaxRooms.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxMaxRooms.Location = new System.Drawing.Point(14, 388);
            this.textBoxMaxRooms.Name = "textBoxMaxRooms";
            this.textBoxMaxRooms.Size = new System.Drawing.Size(150, 23);
            this.textBoxMaxRooms.TabIndex = 24;
            this.textBoxMaxRooms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormDemand_KeyPress);
            // 
            // textBoxMinFloor
            // 
            this.textBoxMinFloor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxMinFloor.Location = new System.Drawing.Point(14, 433);
            this.textBoxMinFloor.Name = "textBoxMinFloor";
            this.textBoxMinFloor.Size = new System.Drawing.Size(150, 23);
            this.textBoxMinFloor.TabIndex = 25;
            this.textBoxMinFloor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormDemand_KeyPress);
            // 
            // textBoxMaxFloor
            // 
            this.textBoxMaxFloor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxMaxFloor.Location = new System.Drawing.Point(14, 485);
            this.textBoxMaxFloor.Name = "textBoxMaxFloor";
            this.textBoxMaxFloor.Size = new System.Drawing.Size(150, 23);
            this.textBoxMaxFloor.TabIndex = 26;
            this.textBoxMaxFloor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormDemand_KeyPress);
            // 
            // listViewDemandSetHouse
            // 
            this.listViewDemandSetHouse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdAgent2,
            this.FIOAgent2,
            this.IdClient2,
            this.FioClient2,
            this.Type_On,
            this.Min_price,
            this.Max_price,
            this.Min_square,
            this.Max_square,
            this.MinFloors,
            this.MaxFloors});
            this.listViewDemandSetHouse.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewDemandSetHouse.FullRowSelect = true;
            this.listViewDemandSetHouse.GridLines = true;
            this.listViewDemandSetHouse.HideSelection = false;
            this.listViewDemandSetHouse.Location = new System.Drawing.Point(170, 110);
            this.listViewDemandSetHouse.MultiSelect = false;
            this.listViewDemandSetHouse.Name = "listViewDemandSetHouse";
            this.listViewDemandSetHouse.Size = new System.Drawing.Size(1115, 211);
            this.listViewDemandSetHouse.TabIndex = 27;
            this.listViewDemandSetHouse.UseCompatibleStateImageBehavior = false;
            this.listViewDemandSetHouse.View = System.Windows.Forms.View.Details;
            this.listViewDemandSetHouse.SelectedIndexChanged += new System.EventHandler(this.listViewDemandSetHouse_SelectedIndexChanged);
            // 
            // IdAgent2
            // 
            this.IdAgent2.Text = "ID риелтора";
            this.IdAgent2.Width = 79;
            // 
            // FIOAgent2
            // 
            this.FIOAgent2.Text = "ФИО риелтора";
            this.FIOAgent2.Width = 103;
            // 
            // IdClient2
            // 
            this.IdClient2.Text = "ID клиента";
            this.IdClient2.Width = 94;
            // 
            // FioClient2
            // 
            this.FioClient2.Text = "ФИО клиента";
            this.FioClient2.Width = 111;
            // 
            // Type_On
            // 
            this.Type_On.Text = "Тип О.Н.";
            this.Type_On.Width = 75;
            // 
            // Min_price
            // 
            this.Min_price.Text = "Мин. цена";
            this.Min_price.Width = 97;
            // 
            // Max_price
            // 
            this.Max_price.Text = "Макс. цена";
            this.Max_price.Width = 89;
            // 
            // Min_square
            // 
            this.Min_square.Text = "Мин. площадь";
            this.Min_square.Width = 137;
            // 
            // Max_square
            // 
            this.Max_square.Text = "Макс. площадь";
            this.Max_square.Width = 115;
            // 
            // MinFloors
            // 
            this.MinFloors.Text = "Мин. этажность";
            this.MinFloors.Width = 111;
            // 
            // MaxFloors
            // 
            this.MaxFloors.Text = "Макс. этажность";
            this.MaxFloors.Width = 105;
            // 
            // listViewDemandSetLand
            // 
            this.listViewDemandSetLand.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdAgent1,
            this.FioAgent1,
            this.IdClient1,
            this.FioClient1,
            this.Type_ON1,
            this.Minprice,
            this.Maxprice,
            this.MinSquare1,
            this.MaxSquare1});
            this.listViewDemandSetLand.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewDemandSetLand.FullRowSelect = true;
            this.listViewDemandSetLand.GridLines = true;
            this.listViewDemandSetLand.HideSelection = false;
            this.listViewDemandSetLand.Location = new System.Drawing.Point(170, 110);
            this.listViewDemandSetLand.MultiSelect = false;
            this.listViewDemandSetLand.Name = "listViewDemandSetLand";
            this.listViewDemandSetLand.Size = new System.Drawing.Size(1115, 211);
            this.listViewDemandSetLand.TabIndex = 28;
            this.listViewDemandSetLand.UseCompatibleStateImageBehavior = false;
            this.listViewDemandSetLand.View = System.Windows.Forms.View.Details;
            this.listViewDemandSetLand.SelectedIndexChanged += new System.EventHandler(this.listViewDemandSetLand_SelectedIndexChanged);
            // 
            // IdAgent1
            // 
            this.IdAgent1.Text = "ID риелтора";
            this.IdAgent1.Width = 76;
            // 
            // FioAgent1
            // 
            this.FioAgent1.Text = "ФИО риелтора";
            this.FioAgent1.Width = 143;
            // 
            // IdClient1
            // 
            this.IdClient1.Text = "ID клиента";
            this.IdClient1.Width = 111;
            // 
            // FioClient1
            // 
            this.FioClient1.Text = "ФИО клиента";
            this.FioClient1.Width = 140;
            // 
            // Type_ON1
            // 
            this.Type_ON1.Text = "Тип О.Н.";
            this.Type_ON1.Width = 128;
            // 
            // Minprice
            // 
            this.Minprice.Text = "Мин. цена";
            this.Minprice.Width = 119;
            // 
            // Maxprice
            // 
            this.Maxprice.Text = "Макс. цена";
            this.Maxprice.Width = 111;
            // 
            // MinSquare1
            // 
            this.MinSquare1.Text = "Мин. площадь";
            this.MinSquare1.Width = 153;
            // 
            // MaxSquare1
            // 
            this.MaxSquare1.Text = "Макс. площадь";
            this.MaxSquare1.Width = 142;
            // 
            // textBoxMaxFloors
            // 
            this.textBoxMaxFloors.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxMaxFloors.Location = new System.Drawing.Point(14, 387);
            this.textBoxMaxFloors.Name = "textBoxMaxFloors";
            this.textBoxMaxFloors.Size = new System.Drawing.Size(150, 23);
            this.textBoxMaxFloors.TabIndex = 32;
            this.textBoxMaxFloors.TextChanged += new System.EventHandler(this.textBoxMaxFloors_TextChanged);
            this.textBoxMaxFloors.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormDemand_KeyPress);
            // 
            // textBoxMinFloors
            // 
            this.textBoxMinFloors.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxMinFloors.Location = new System.Drawing.Point(14, 343);
            this.textBoxMinFloors.Name = "textBoxMinFloors";
            this.textBoxMinFloors.Size = new System.Drawing.Size(150, 23);
            this.textBoxMinFloors.TabIndex = 31;
            this.textBoxMinFloors.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormDemand_KeyPress);
            // 
            // labelMaxFloors
            // 
            this.labelMaxFloors.AutoSize = true;
            this.labelMaxFloors.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxFloors.Location = new System.Drawing.Point(10, 369);
            this.labelMaxFloors.Name = "labelMaxFloors";
            this.labelMaxFloors.Size = new System.Drawing.Size(142, 15);
            this.labelMaxFloors.TabIndex = 30;
            this.labelMaxFloors.Text = "Макс. этажность дома";
            // 
            // labelMinFloors
            // 
            this.labelMinFloors.AutoSize = true;
            this.labelMinFloors.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinFloors.Location = new System.Drawing.Point(11, 325);
            this.labelMinFloors.Name = "labelMinFloors";
            this.labelMinFloors.Size = new System.Drawing.Size(135, 15);
            this.labelMinFloors.TabIndex = 29;
            this.labelMinFloors.Text = "Мин. этажность дома";
            // 
            // Logo
            // 
            this.Logo.Image = global::Esoft_Project.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(548, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(405, 102);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 33;
            this.Logo.TabStop = false;
            // 
            // FormDemand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1307, 515);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.textBoxMaxFloors);
            this.Controls.Add(this.textBoxMinFloors);
            this.Controls.Add(this.labelMaxFloors);
            this.Controls.Add(this.labelMinFloors);
            this.Controls.Add(this.listViewDemandSetLand);
            this.Controls.Add(this.listViewDemandSetHouse);
            this.Controls.Add(this.textBoxMaxFloor);
            this.Controls.Add(this.textBoxMinFloor);
            this.Controls.Add(this.textBoxMaxRooms);
            this.Controls.Add(this.textBoxMinRooms);
            this.Controls.Add(this.textBoxMaxSquare);
            this.Controls.Add(this.textBoxMinSquare);
            this.Controls.Add(this.labelMaxFloor);
            this.Controls.Add(this.labelMinFloor);
            this.Controls.Add(this.labelMaxRooms);
            this.Controls.Add(this.labelMinRooms);
            this.Controls.Add(this.labelMaxSquare);
            this.Controls.Add(this.labelMinSquare);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewDemandSetRoom);
            this.Controls.Add(this.textBoxMaxPrice);
            this.Controls.Add(this.textBoxMinPrice);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxClients);
            this.Controls.Add(this.comboBoxAgents);
            this.Controls.Add(this.labelMaxPrice);
            this.Controls.Add(this.labelMinPrice);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelAgent);
            this.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormDemand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Потребности";
            this.Load += new System.EventHandler(this.FormDemand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAgent;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelMinPrice;
        private System.Windows.Forms.Label labelMaxPrice;
        private System.Windows.Forms.ComboBox comboBoxAgents;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxMinPrice;
        private System.Windows.Forms.TextBox textBoxMaxPrice;
        private System.Windows.Forms.ListView listViewDemandSetRoom;
        private System.Windows.Forms.ColumnHeader IdAgent;
        private System.Windows.Forms.ColumnHeader FIOAgent;
        private System.Windows.Forms.ColumnHeader IdClient;
        private System.Windows.Forms.ColumnHeader FIOClient;
        private System.Windows.Forms.ColumnHeader TypeON;
        private System.Windows.Forms.ColumnHeader Min;
        private System.Windows.Forms.ColumnHeader Max;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelMinSquare;
        private System.Windows.Forms.Label labelMaxSquare;
        private System.Windows.Forms.Label labelMinRooms;
        private System.Windows.Forms.Label labelMaxRooms;
        private System.Windows.Forms.Label labelMinFloor;
        private System.Windows.Forms.Label labelMaxFloor;
        private System.Windows.Forms.TextBox textBoxMinSquare;
        private System.Windows.Forms.TextBox textBoxMaxSquare;
        private System.Windows.Forms.TextBox textBoxMinRooms;
        private System.Windows.Forms.TextBox textBoxMaxRooms;
        private System.Windows.Forms.TextBox textBoxMinFloor;
        private System.Windows.Forms.TextBox textBoxMaxFloor;
        private System.Windows.Forms.ColumnHeader MinSquare;
        private System.Windows.Forms.ColumnHeader MaxSquare;
        private System.Windows.Forms.ColumnHeader MinRooms;
        private System.Windows.Forms.ColumnHeader MaxRooms;
        private System.Windows.Forms.ColumnHeader MinFloor;
        private System.Windows.Forms.ColumnHeader MaxFloor;
        private System.Windows.Forms.ListView listViewDemandSetHouse;
        private System.Windows.Forms.ColumnHeader IdAgent2;
        private System.Windows.Forms.ColumnHeader FIOAgent2;
        private System.Windows.Forms.ColumnHeader IdClient2;
        private System.Windows.Forms.ColumnHeader FioClient2;
        private System.Windows.Forms.ColumnHeader Type_On;
        private System.Windows.Forms.ColumnHeader Min_price;
        private System.Windows.Forms.ColumnHeader Max_price;
        private System.Windows.Forms.ColumnHeader Min_square;
        private System.Windows.Forms.ColumnHeader Max_square;
        private System.Windows.Forms.ColumnHeader MinFloors;
        private System.Windows.Forms.ColumnHeader MaxFloors;
        private System.Windows.Forms.ListView listViewDemandSetLand;
        private System.Windows.Forms.ColumnHeader IdAgent1;
        private System.Windows.Forms.ColumnHeader FioAgent1;
        private System.Windows.Forms.ColumnHeader IdClient1;
        private System.Windows.Forms.ColumnHeader FioClient1;
        private System.Windows.Forms.ColumnHeader Type_ON1;
        private System.Windows.Forms.ColumnHeader Minprice;
        private System.Windows.Forms.ColumnHeader Maxprice;
        private System.Windows.Forms.ColumnHeader MinSquare1;
        private System.Windows.Forms.ColumnHeader MaxSquare1;
        private System.Windows.Forms.TextBox textBoxMaxFloors;
        private System.Windows.Forms.TextBox textBoxMinFloors;
        private System.Windows.Forms.Label labelMaxFloors;
        private System.Windows.Forms.Label labelMinFloors;
        private System.Windows.Forms.PictureBox Logo;
    }
}