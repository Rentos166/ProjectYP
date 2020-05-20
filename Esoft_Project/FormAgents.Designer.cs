namespace Esoft_Project
{
    partial class FormAgents
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
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewAgent = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Имя = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Фамилия = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Отчество = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Процент = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelProcent = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxDealShare = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.labelDemandSet = new System.Windows.Forms.Label();
            this.labelSupplySet = new System.Windows.Forms.Label();
            this.listViewDemandSet = new System.Windows.Forms.ListView();
            this.FioAGent1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FioClient1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeON = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinSquare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxSquare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewSupplySet = new System.Windows.Forms.ListView();
            this.FioAgent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FioClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddressON = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDel.Location = new System.Drawing.Point(483, 253);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(77, 45);
            this.buttonDel.TabIndex = 28;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonEdit.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonEdit.Location = new System.Drawing.Point(402, 253);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(77, 45);
            this.buttonEdit.TabIndex = 27;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAdd.Location = new System.Drawing.Point(321, 253);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(77, 45);
            this.buttonAdd.TabIndex = 26;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listViewAgent
            // 
            this.listViewAgent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Имя,
            this.Фамилия,
            this.Отчество,
            this.Процент});
            this.listViewAgent.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewAgent.FullRowSelect = true;
            this.listViewAgent.GridLines = true;
            this.listViewAgent.HideSelection = false;
            this.listViewAgent.Location = new System.Drawing.Point(164, 60);
            this.listViewAgent.MultiSelect = false;
            this.listViewAgent.Name = "listViewAgent";
            this.listViewAgent.Size = new System.Drawing.Size(396, 187);
            this.listViewAgent.TabIndex = 25;
            this.listViewAgent.UseCompatibleStateImageBehavior = false;
            this.listViewAgent.View = System.Windows.Forms.View.Details;
            this.listViewAgent.SelectedIndexChanged += new System.EventHandler(this.listViewAgent_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 73;
            // 
            // Имя
            // 
            this.Имя.Text = "Имя";
            this.Имя.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Имя.Width = 80;
            // 
            // Фамилия
            // 
            this.Фамилия.Text = "Фамилия";
            this.Фамилия.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Фамилия.Width = 90;
            // 
            // Отчество
            // 
            this.Отчество.Text = "Отчество";
            this.Отчество.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Отчество.Width = 89;
            // 
            // Процент
            // 
            this.Процент.Text = "Процент";
            this.Процент.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Процент.Width = 62;
            // 
            // labelProcent
            // 
            this.labelProcent.AutoSize = true;
            this.labelProcent.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProcent.Location = new System.Drawing.Point(5, 179);
            this.labelProcent.Name = "labelProcent";
            this.labelProcent.Size = new System.Drawing.Size(57, 15);
            this.labelProcent.TabIndex = 23;
            this.labelProcent.Text = "Процент";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.Location = new System.Drawing.Point(5, 135);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(62, 15);
            this.labelLastName.TabIndex = 22;
            this.labelLastName.Text = "Фамилия";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddleName.Location = new System.Drawing.Point(5, 90);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(63, 15);
            this.labelMiddleName.TabIndex = 21;
            this.labelMiddleName.Text = "Отчество";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstName.Location = new System.Drawing.Point(5, 42);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(33, 15);
            this.labelFirstName.TabIndex = 20;
            this.labelFirstName.Text = "Имя";
            // 
            // textBoxDealShare
            // 
            this.textBoxDealShare.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxDealShare.Location = new System.Drawing.Point(8, 195);
            this.textBoxDealShare.Name = "textBoxDealShare";
            this.textBoxDealShare.Size = new System.Drawing.Size(150, 20);
            this.textBoxDealShare.TabIndex = 18;
            this.textBoxDealShare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAgents_KeyPress);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxLastName.Location = new System.Drawing.Point(8, 151);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(150, 20);
            this.textBoxLastName.TabIndex = 17;
            this.textBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAgents_KeyPress);
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxMiddleName.Location = new System.Drawing.Point(8, 106);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(150, 20);
            this.textBoxMiddleName.TabIndex = 16;
            this.textBoxMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAgents_KeyPress);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxFirstName.Location = new System.Drawing.Point(8, 60);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(150, 20);
            this.textBoxFirstName.TabIndex = 15;
            this.textBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAgents_KeyPress);
            // 
            // Logo
            // 
            this.Logo.Image = global::Esoft_Project.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(444, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(251, 55);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 29;
            this.Logo.TabStop = false;
            // 
            // labelDemandSet
            // 
            this.labelDemandSet.AutoSize = true;
            this.labelDemandSet.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDemandSet.Location = new System.Drawing.Point(815, 168);
            this.labelDemandSet.Name = "labelDemandSet";
            this.labelDemandSet.Size = new System.Drawing.Size(84, 15);
            this.labelDemandSet.TabIndex = 33;
            this.labelDemandSet.Text = "Потребности";
            // 
            // labelSupplySet
            // 
            this.labelSupplySet.AutoSize = true;
            this.labelSupplySet.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSupplySet.Location = new System.Drawing.Point(815, 42);
            this.labelSupplySet.Name = "labelSupplySet";
            this.labelSupplySet.Size = new System.Drawing.Size(89, 15);
            this.labelSupplySet.TabIndex = 32;
            this.labelSupplySet.Text = "Предложения";
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
            this.listViewDemandSet.Location = new System.Drawing.Point(566, 186);
            this.listViewDemandSet.MultiSelect = false;
            this.listViewDemandSet.Name = "listViewDemandSet";
            this.listViewDemandSet.Size = new System.Drawing.Size(599, 112);
            this.listViewDemandSet.TabIndex = 31;
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
            // MaxPrice
            // 
            this.MaxPrice.Text = "Макс. цена";
            this.MaxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaxPrice.Width = 78;
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
            this.listViewSupplySet.Location = new System.Drawing.Point(566, 60);
            this.listViewSupplySet.MultiSelect = false;
            this.listViewSupplySet.Name = "listViewSupplySet";
            this.listViewSupplySet.Size = new System.Drawing.Size(599, 105);
            this.listViewSupplySet.TabIndex = 30;
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
            // FormAgents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 304);
            this.Controls.Add(this.labelDemandSet);
            this.Controls.Add(this.labelSupplySet);
            this.Controls.Add(this.listViewDemandSet);
            this.Controls.Add(this.listViewSupplySet);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewAgent);
            this.Controls.Add(this.labelProcent);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxDealShare);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Name = "FormAgents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Риелторы";
            this.Load += new System.EventHandler(this.FormAgents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewAgent;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Имя;
        private System.Windows.Forms.ColumnHeader Фамилия;
        private System.Windows.Forms.ColumnHeader Отчество;
        private System.Windows.Forms.ColumnHeader Процент;
        private System.Windows.Forms.Label labelProcent;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxDealShare;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelDemandSet;
        private System.Windows.Forms.Label labelSupplySet;
        private System.Windows.Forms.ListView listViewDemandSet;
        private System.Windows.Forms.ColumnHeader FioAGent1;
        private System.Windows.Forms.ColumnHeader FioClient1;
        private System.Windows.Forms.ColumnHeader TypeON;
        private System.Windows.Forms.ColumnHeader MinSquare;
        private System.Windows.Forms.ColumnHeader MaxSquare;
        private System.Windows.Forms.ColumnHeader MinPrice;
        private System.Windows.Forms.ColumnHeader MaxPrice;
        private System.Windows.Forms.ListView listViewSupplySet;
        private System.Windows.Forms.ColumnHeader FioAgent;
        private System.Windows.Forms.ColumnHeader FioClient;
        private System.Windows.Forms.ColumnHeader AddressON;
        private System.Windows.Forms.ColumnHeader Price;
    }
}