namespace Esoft_Project
{
    partial class FormClients
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
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.listViewClient = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Имя = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Фамилия = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Отчество = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Телефон = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.listViewSupplySet = new System.Windows.Forms.ListView();
            this.FioAgent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FioClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddressON = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDemandSet = new System.Windows.Forms.ListView();
            this.FioAGent1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FioClient1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeON = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinSquare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxSquare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelSupplySet = new System.Windows.Forms.Label();
            this.labelDemandSet = new System.Windows.Forms.Label();
            this.MaxPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxFirstName.Location = new System.Drawing.Point(6, 57);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(140, 20);
            this.textBoxFirstName.TabIndex = 0;
            this.textBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFirstName_KeyPress);
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxMiddleName.Location = new System.Drawing.Point(6, 136);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(140, 20);
            this.textBoxMiddleName.TabIndex = 1;
            this.textBoxMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFirstName_KeyPress);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxLastName.Location = new System.Drawing.Point(6, 96);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(140, 20);
            this.textBoxLastName.TabIndex = 2;
            this.textBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFirstName_KeyPress);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxPhone.Location = new System.Drawing.Point(6, 175);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(140, 20);
            this.textBoxPhone.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxEmail.Location = new System.Drawing.Point(6, 214);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(140, 20);
            this.textBoxEmail.TabIndex = 4;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstName.Location = new System.Drawing.Point(3, 39);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(33, 15);
            this.labelFirstName.TabIndex = 5;
            this.labelFirstName.Text = "Имя";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddleName.Location = new System.Drawing.Point(3, 120);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(63, 15);
            this.labelMiddleName.TabIndex = 6;
            this.labelMiddleName.Text = "Отчество";
            this.labelMiddleName.Click += new System.EventHandler(this.labelMiddleName_Click);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.Location = new System.Drawing.Point(3, 80);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(62, 15);
            this.labelLastName.TabIndex = 7;
            this.labelLastName.Text = "Фамилия";
            this.labelLastName.Click += new System.EventHandler(this.labelLastName_Click);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(3, 159);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(58, 15);
            this.labelPhone.TabIndex = 8;
            this.labelPhone.Text = "Телефон";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(3, 198);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(43, 15);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "Почта";
            // 
            // listViewClient
            // 
            this.listViewClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Имя,
            this.Фамилия,
            this.Отчество,
            this.Телефон,
            this.Email});
            this.listViewClient.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewClient.FullRowSelect = true;
            this.listViewClient.GridLines = true;
            this.listViewClient.HideSelection = false;
            this.listViewClient.Location = new System.Drawing.Point(152, 57);
            this.listViewClient.MultiSelect = false;
            this.listViewClient.Name = "listViewClient";
            this.listViewClient.Size = new System.Drawing.Size(404, 204);
            this.listViewClient.TabIndex = 10;
            this.listViewClient.UseCompatibleStateImageBehavior = false;
            this.listViewClient.View = System.Windows.Forms.View.Details;
            this.listViewClient.SelectedIndexChanged += new System.EventHandler(this.listViewClient_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 25;
            // 
            // Имя
            // 
            this.Имя.Text = "Имя";
            this.Имя.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Имя.Width = 67;
            // 
            // Фамилия
            // 
            this.Фамилия.Text = "Фамилия";
            this.Фамилия.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Фамилия.Width = 71;
            // 
            // Отчество
            // 
            this.Отчество.Text = "Отчество";
            this.Отчество.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Отчество.Width = 74;
            // 
            // Телефон
            // 
            this.Телефон.Text = "Телефон";
            this.Телефон.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Телефон.Width = 86;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Width = 78;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAdd.Location = new System.Drawing.Point(265, 267);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(93, 28);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonEdit.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonEdit.Location = new System.Drawing.Point(364, 267);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(93, 28);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDel.Location = new System.Drawing.Point(463, 267);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(93, 28);
            this.buttonDel.TabIndex = 13;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::Esoft_Project.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(481, -1);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(251, 55);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 14;
            this.Logo.TabStop = false;
            // 
            // listViewSupplySet
            // 
            this.listViewSupplySet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FioAgent,
            this.FioClient,
            this.AddressON,
            this.Price});
            this.listViewSupplySet.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewSupplySet.FullRowSelect = true;
            this.listViewSupplySet.GridLines = true;
            this.listViewSupplySet.HideSelection = false;
            this.listViewSupplySet.Location = new System.Drawing.Point(562, 57);
            this.listViewSupplySet.MultiSelect = false;
            this.listViewSupplySet.Name = "listViewSupplySet";
            this.listViewSupplySet.Size = new System.Drawing.Size(599, 105);
            this.listViewSupplySet.TabIndex = 15;
            this.listViewSupplySet.UseCompatibleStateImageBehavior = false;
            this.listViewSupplySet.View = System.Windows.Forms.View.Details;
            // 
            // FioAgent
            // 
            this.FioAgent.Text = "ФИО риелтора";
            this.FioAgent.Width = 133;
            // 
            // FioClient
            // 
            this.FioClient.Text = "ФИО клиента";
            this.FioClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FioClient.Width = 152;
            // 
            // AddressON
            // 
            this.AddressON.Text = "Адрес О.Н.";
            this.AddressON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddressON.Width = 223;
            // 
            // Price
            // 
            this.Price.Text = "Цена";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Width = 87;
            // 
            // listViewDemandSet
            // 
            this.listViewDemandSet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FioAGent1,
            this.FioClient1,
            this.TypeON,
            this.MinSquare,
            this.MaxSquare,
            this.MinPrice,
            this.MaxPrice});
            this.listViewDemandSet.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewDemandSet.FullRowSelect = true;
            this.listViewDemandSet.GridLines = true;
            this.listViewDemandSet.HideSelection = false;
            this.listViewDemandSet.Location = new System.Drawing.Point(562, 183);
            this.listViewDemandSet.MultiSelect = false;
            this.listViewDemandSet.Name = "listViewDemandSet";
            this.listViewDemandSet.Size = new System.Drawing.Size(599, 112);
            this.listViewDemandSet.TabIndex = 16;
            this.listViewDemandSet.UseCompatibleStateImageBehavior = false;
            this.listViewDemandSet.View = System.Windows.Forms.View.Details;
            // 
            // FioAGent1
            // 
            this.FioAGent1.Text = "ФИО риелтора";
            this.FioAGent1.Width = 89;
            // 
            // FioClient1
            // 
            this.FioClient1.Text = "ФИО клиента";
            this.FioClient1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FioClient1.Width = 90;
            // 
            // TypeON
            // 
            this.TypeON.Text = "Тип О.Н.";
            this.TypeON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TypeON.Width = 71;
            // 
            // MinSquare
            // 
            this.MinSquare.Text = "Мин. площадь";
            this.MinSquare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MinSquare.Width = 91;
            // 
            // MaxSquare
            // 
            this.MaxSquare.Text = "Макс. площадь";
            this.MaxSquare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaxSquare.Width = 98;
            // 
            // MinPrice
            // 
            this.MinPrice.Text = "Мин. цена";
            this.MinPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MinPrice.Width = 78;
            // 
            // labelSupplySet
            // 
            this.labelSupplySet.AutoSize = true;
            this.labelSupplySet.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSupplySet.Location = new System.Drawing.Point(811, 39);
            this.labelSupplySet.Name = "labelSupplySet";
            this.labelSupplySet.Size = new System.Drawing.Size(89, 15);
            this.labelSupplySet.TabIndex = 17;
            this.labelSupplySet.Text = "Предложения";
            // 
            // labelDemandSet
            // 
            this.labelDemandSet.AutoSize = true;
            this.labelDemandSet.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDemandSet.Location = new System.Drawing.Point(811, 165);
            this.labelDemandSet.Name = "labelDemandSet";
            this.labelDemandSet.Size = new System.Drawing.Size(84, 15);
            this.labelDemandSet.TabIndex = 18;
            this.labelDemandSet.Text = "Потребности";
            // 
            // MaxPrice
            // 
            this.MaxPrice.Text = "Макс. цена";
            this.MaxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaxPrice.Width = 78;
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1165, 300);
            this.Controls.Add(this.labelDemandSet);
            this.Controls.Add(this.labelSupplySet);
            this.Controls.Add(this.listViewDemandSet);
            this.Controls.Add(this.listViewSupplySet);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewClient);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Name = "FormClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.FormClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.ListView listViewClient;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Имя;
        private System.Windows.Forms.ColumnHeader Фамилия;
        private System.Windows.Forms.ColumnHeader Отчество;
        private System.Windows.Forms.ColumnHeader Телефон;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.ListView listViewSupplySet;
        private System.Windows.Forms.ColumnHeader FioAgent;
        private System.Windows.Forms.ColumnHeader FioClient;
        private System.Windows.Forms.ColumnHeader AddressON;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ListView listViewDemandSet;
        private System.Windows.Forms.ColumnHeader FioAGent1;
        private System.Windows.Forms.ColumnHeader FioClient1;
        private System.Windows.Forms.ColumnHeader TypeON;
        private System.Windows.Forms.ColumnHeader MinSquare;
        private System.Windows.Forms.ColumnHeader MaxSquare;
        private System.Windows.Forms.ColumnHeader MinPrice;
        private System.Windows.Forms.Label labelSupplySet;
        private System.Windows.Forms.Label labelDemandSet;
        private System.Windows.Forms.ColumnHeader MaxPrice;
    }
}