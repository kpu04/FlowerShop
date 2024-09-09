namespace FlowerCourse
{
    partial class CustomerForm
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
            this.components = new System.ComponentModel.Container();
            this.CustomerDataGridView = new System.Windows.Forms.DataGridView();
            this.idcustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flower_databaseDataSet = new FlowerCourse.Flower_databaseDataSet();
            this.customerTableAdapter = new FlowerCourse.Flower_databaseDataSetTableAdapters.CustomerTableAdapter();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.AddStatusComboBox = new System.Windows.Forms.ComboBox();
            this.AddNumTextBox = new System.Windows.Forms.TextBox();
            this.AddAdressTextBox = new System.Windows.Forms.TextBox();
            this.AddNameTextBox = new System.Windows.Forms.TextBox();
            this.AddSurnameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.ChangePanel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.ChangeIDCustTextBox = new System.Windows.Forms.TextBox();
            this.ChangeStatusComboBox = new System.Windows.Forms.ComboBox();
            this.ChangeNumberTextBox = new System.Windows.Forms.TextBox();
            this.ChangeAdressTextBox = new System.Windows.Forms.TextBox();
            this.ChangeNameTextBox = new System.Windows.Forms.TextBox();
            this.ChangeSurnameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.OpenAddPanel = new System.Windows.Forms.Button();
            this.OpenChangeButton = new System.Windows.Forms.Button();
            this.DeleteCustButton = new System.Windows.Forms.Button();
            this.OpenSearchButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.OpenSearch = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchInfoTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SearchComboBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet)).BeginInit();
            this.AddPanel.SuspendLayout();
            this.ChangePanel.SuspendLayout();
            this.OpenSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerDataGridView
            // 
            this.CustomerDataGridView.AutoGenerateColumns = false;
            this.CustomerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcustomerDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phnumDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.CustomerDataGridView.DataSource = this.customerBindingSource;
            this.CustomerDataGridView.Location = new System.Drawing.Point(2, -1);
            this.CustomerDataGridView.Name = "CustomerDataGridView";
            this.CustomerDataGridView.RowHeadersWidth = 82;
            this.CustomerDataGridView.RowTemplate.Height = 33;
            this.CustomerDataGridView.Size = new System.Drawing.Size(1731, 516);
            this.CustomerDataGridView.TabIndex = 0;
            // 
            // idcustomerDataGridViewTextBoxColumn
            // 
            this.idcustomerDataGridViewTextBoxColumn.DataPropertyName = "id_customer";
            this.idcustomerDataGridViewTextBoxColumn.HeaderText = "id_customer";
            this.idcustomerDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idcustomerDataGridViewTextBoxColumn.Name = "idcustomerDataGridViewTextBoxColumn";
            this.idcustomerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phnumDataGridViewTextBoxColumn
            // 
            this.phnumDataGridViewTextBoxColumn.DataPropertyName = "ph_num";
            this.phnumDataGridViewTextBoxColumn.HeaderText = "ph_num";
            this.phnumDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.phnumDataGridViewTextBoxColumn.Name = "phnumDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.flower_databaseDataSet;
            // 
            // flower_databaseDataSet
            // 
            this.flower_databaseDataSet.DataSetName = "Flower_databaseDataSet";
            this.flower_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // AddPanel
            // 
            this.AddPanel.Controls.Add(this.AddStatusComboBox);
            this.AddPanel.Controls.Add(this.AddNumTextBox);
            this.AddPanel.Controls.Add(this.AddAdressTextBox);
            this.AddPanel.Controls.Add(this.AddNameTextBox);
            this.AddPanel.Controls.Add(this.AddSurnameTextBox);
            this.AddPanel.Controls.Add(this.label5);
            this.AddPanel.Controls.Add(this.label4);
            this.AddPanel.Controls.Add(this.label3);
            this.AddPanel.Controls.Add(this.label2);
            this.AddPanel.Controls.Add(this.label1);
            this.AddPanel.Controls.Add(this.AddButton);
            this.AddPanel.Location = new System.Drawing.Point(321, 514);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(343, 814);
            this.AddPanel.TabIndex = 1;
            // 
            // AddStatusComboBox
            // 
            this.AddStatusComboBox.FormattingEnabled = true;
            this.AddStatusComboBox.Items.AddRange(new object[] {
            "новый",
            "постоянный"});
            this.AddStatusComboBox.Location = new System.Drawing.Point(74, 516);
            this.AddStatusComboBox.Name = "AddStatusComboBox";
            this.AddStatusComboBox.Size = new System.Drawing.Size(217, 33);
            this.AddStatusComboBox.TabIndex = 11;
            this.AddStatusComboBox.Text = "Выберите статус";
            // 
            // AddNumTextBox
            // 
            this.AddNumTextBox.Location = new System.Drawing.Point(74, 429);
            this.AddNumTextBox.Name = "AddNumTextBox";
            this.AddNumTextBox.Size = new System.Drawing.Size(217, 31);
            this.AddNumTextBox.TabIndex = 10;
            // 
            // AddAdressTextBox
            // 
            this.AddAdressTextBox.Location = new System.Drawing.Point(74, 307);
            this.AddAdressTextBox.Name = "AddAdressTextBox";
            this.AddAdressTextBox.Size = new System.Drawing.Size(217, 31);
            this.AddAdressTextBox.TabIndex = 9;
            // 
            // AddNameTextBox
            // 
            this.AddNameTextBox.Location = new System.Drawing.Point(74, 196);
            this.AddNameTextBox.Name = "AddNameTextBox";
            this.AddNameTextBox.Size = new System.Drawing.Size(217, 31);
            this.AddNameTextBox.TabIndex = 8;
            // 
            // AddSurnameTextBox
            // 
            this.AddSurnameTextBox.Location = new System.Drawing.Point(74, 105);
            this.AddSurnameTextBox.Name = "AddSurnameTextBox";
            this.AddSurnameTextBox.Size = new System.Drawing.Size(217, 31);
            this.AddSurnameTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Номер телефона";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавление клиента";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(106, 708);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(149, 56);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ChangePanel
            // 
            this.ChangePanel.Controls.Add(this.label13);
            this.ChangePanel.Controls.Add(this.ChangeIDCustTextBox);
            this.ChangePanel.Controls.Add(this.ChangeStatusComboBox);
            this.ChangePanel.Controls.Add(this.ChangeNumberTextBox);
            this.ChangePanel.Controls.Add(this.ChangeAdressTextBox);
            this.ChangePanel.Controls.Add(this.ChangeNameTextBox);
            this.ChangePanel.Controls.Add(this.ChangeSurnameTextBox);
            this.ChangePanel.Controls.Add(this.label7);
            this.ChangePanel.Controls.Add(this.label8);
            this.ChangePanel.Controls.Add(this.label9);
            this.ChangePanel.Controls.Add(this.label10);
            this.ChangePanel.Controls.Add(this.label11);
            this.ChangePanel.Controls.Add(this.label12);
            this.ChangePanel.Controls.Add(this.ChangeButton);
            this.ChangePanel.Location = new System.Drawing.Point(803, 514);
            this.ChangePanel.Name = "ChangePanel";
            this.ChangePanel.Size = new System.Drawing.Size(343, 814);
            this.ChangePanel.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(92, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 25);
            this.label13.TabIndex = 24;
            this.label13.Text = "Номер клиента";
            // 
            // ChangeIDCustTextBox
            // 
            this.ChangeIDCustTextBox.Location = new System.Drawing.Point(65, 134);
            this.ChangeIDCustTextBox.Name = "ChangeIDCustTextBox";
            this.ChangeIDCustTextBox.ReadOnly = true;
            this.ChangeIDCustTextBox.Size = new System.Drawing.Size(217, 31);
            this.ChangeIDCustTextBox.TabIndex = 23;
            // 
            // ChangeStatusComboBox
            // 
            this.ChangeStatusComboBox.FormattingEnabled = true;
            this.ChangeStatusComboBox.Items.AddRange(new object[] {
            "новый",
            "постоянный"});
            this.ChangeStatusComboBox.Location = new System.Drawing.Point(65, 632);
            this.ChangeStatusComboBox.Name = "ChangeStatusComboBox";
            this.ChangeStatusComboBox.Size = new System.Drawing.Size(217, 33);
            this.ChangeStatusComboBox.TabIndex = 22;
            // 
            // ChangeNumberTextBox
            // 
            this.ChangeNumberTextBox.Location = new System.Drawing.Point(65, 537);
            this.ChangeNumberTextBox.Name = "ChangeNumberTextBox";
            this.ChangeNumberTextBox.Size = new System.Drawing.Size(217, 31);
            this.ChangeNumberTextBox.TabIndex = 21;
            // 
            // ChangeAdressTextBox
            // 
            this.ChangeAdressTextBox.Location = new System.Drawing.Point(65, 415);
            this.ChangeAdressTextBox.Name = "ChangeAdressTextBox";
            this.ChangeAdressTextBox.Size = new System.Drawing.Size(217, 31);
            this.ChangeAdressTextBox.TabIndex = 20;
            // 
            // ChangeNameTextBox
            // 
            this.ChangeNameTextBox.Location = new System.Drawing.Point(65, 304);
            this.ChangeNameTextBox.Name = "ChangeNameTextBox";
            this.ChangeNameTextBox.Size = new System.Drawing.Size(217, 31);
            this.ChangeNameTextBox.TabIndex = 19;
            // 
            // ChangeSurnameTextBox
            // 
            this.ChangeSurnameTextBox.Location = new System.Drawing.Point(65, 213);
            this.ChangeSurnameTextBox.Name = "ChangeSurnameTextBox";
            this.ChangeSurnameTextBox.Size = new System.Drawing.Size(217, 31);
            this.ChangeSurnameTextBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 588);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Статус";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 498);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Номер телефона";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(128, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Адрес";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(139, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Имя";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(120, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "Фамилия";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(77, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(261, 58);
            this.label12.TabIndex = 12;
            this.label12.Text = "Изменение данных (выберите строку)";
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(97, 708);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(149, 56);
            this.ChangeButton.TabIndex = 0;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // OpenAddPanel
            // 
            this.OpenAddPanel.Location = new System.Drawing.Point(63, 587);
            this.OpenAddPanel.Name = "OpenAddPanel";
            this.OpenAddPanel.Size = new System.Drawing.Size(222, 71);
            this.OpenAddPanel.TabIndex = 3;
            this.OpenAddPanel.Text = "Добавить клиента";
            this.OpenAddPanel.UseVisualStyleBackColor = true;
            this.OpenAddPanel.Click += new System.EventHandler(this.OpenAddPanel_Click);
            // 
            // OpenChangeButton
            // 
            this.OpenChangeButton.Location = new System.Drawing.Point(63, 700);
            this.OpenChangeButton.Name = "OpenChangeButton";
            this.OpenChangeButton.Size = new System.Drawing.Size(222, 71);
            this.OpenChangeButton.TabIndex = 4;
            this.OpenChangeButton.Text = "Изменить данные";
            this.OpenChangeButton.UseVisualStyleBackColor = true;
            this.OpenChangeButton.Click += new System.EventHandler(this.OpenChangeButton_Click);
            // 
            // DeleteCustButton
            // 
            this.DeleteCustButton.Location = new System.Drawing.Point(63, 800);
            this.DeleteCustButton.Name = "DeleteCustButton";
            this.DeleteCustButton.Size = new System.Drawing.Size(222, 71);
            this.DeleteCustButton.TabIndex = 5;
            this.DeleteCustButton.Text = "Удалить клиента (выберите строку)";
            this.DeleteCustButton.UseVisualStyleBackColor = true;
            this.DeleteCustButton.Click += new System.EventHandler(this.DeleteCustButton_Click);
            // 
            // OpenSearchButton
            // 
            this.OpenSearchButton.Location = new System.Drawing.Point(63, 915);
            this.OpenSearchButton.Name = "OpenSearchButton";
            this.OpenSearchButton.Size = new System.Drawing.Size(222, 71);
            this.OpenSearchButton.TabIndex = 6;
            this.OpenSearchButton.Text = "Поиск";
            this.OpenSearchButton.UseVisualStyleBackColor = true;
            this.OpenSearchButton.Click += new System.EventHandler(this.OpenSearchButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(89, 1253);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(146, 56);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OpenSearch
            // 
            this.OpenSearch.Controls.Add(this.SearchButton);
            this.OpenSearch.Controls.Add(this.SearchInfoTextBox);
            this.OpenSearch.Controls.Add(this.label15);
            this.OpenSearch.Controls.Add(this.SearchComboBox);
            this.OpenSearch.Controls.Add(this.label14);
            this.OpenSearch.Location = new System.Drawing.Point(1255, 639);
            this.OpenSearch.Name = "OpenSearch";
            this.OpenSearch.Size = new System.Drawing.Size(380, 424);
            this.OpenSearch.TabIndex = 8;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(123, 357);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(149, 56);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Выполнить";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchInfoTextBox
            // 
            this.SearchInfoTextBox.Location = new System.Drawing.Point(52, 289);
            this.SearchInfoTextBox.Name = "SearchInfoTextBox";
            this.SearchInfoTextBox.Size = new System.Drawing.Size(288, 31);
            this.SearchInfoTextBox.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(47, 220);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(293, 25);
            this.label15.TabIndex = 2;
            this.label15.Text = "Введите данные для поиска";
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.FormattingEnabled = true;
            this.SearchComboBox.Location = new System.Drawing.Point(26, 98);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(334, 33);
            this.SearchComboBox.TabIndex = 1;
            this.SearchComboBox.Text = "Выберите столбец данных";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(150, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "Поиск";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1733, 1326);
            this.Controls.Add(this.OpenSearch);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OpenSearchButton);
            this.Controls.Add(this.DeleteCustButton);
            this.Controls.Add(this.OpenChangeButton);
            this.Controls.Add(this.OpenAddPanel);
            this.Controls.Add(this.ChangePanel);
            this.Controls.Add(this.AddPanel);
            this.Controls.Add(this.CustomerDataGridView);
            this.Name = "CustomerForm";
            this.Text = "Управление клиентами";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet)).EndInit();
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            this.ChangePanel.ResumeLayout(false);
            this.ChangePanel.PerformLayout();
            this.OpenSearch.ResumeLayout(false);
            this.OpenSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerDataGridView;
        private Flower_databaseDataSet flower_databaseDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Flower_databaseDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel ChangePanel;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button OpenAddPanel;
        private System.Windows.Forms.Button OpenChangeButton;
        private System.Windows.Forms.Button DeleteCustButton;
        private System.Windows.Forms.Button OpenSearchButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AddStatusComboBox;
        private System.Windows.Forms.TextBox AddNumTextBox;
        private System.Windows.Forms.TextBox AddAdressTextBox;
        private System.Windows.Forms.TextBox AddNameTextBox;
        private System.Windows.Forms.TextBox AddSurnameTextBox;
        private System.Windows.Forms.ComboBox ChangeStatusComboBox;
        private System.Windows.Forms.TextBox ChangeNumberTextBox;
        private System.Windows.Forms.TextBox ChangeAdressTextBox;
        private System.Windows.Forms.TextBox ChangeNameTextBox;
        private System.Windows.Forms.TextBox ChangeSurnameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ChangeIDCustTextBox;
        private System.Windows.Forms.Panel OpenSearch;
        private System.Windows.Forms.ComboBox SearchComboBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchInfoTextBox;
        private System.Windows.Forms.Label label15;
    }
}