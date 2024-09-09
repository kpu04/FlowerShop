namespace FlowerCourse
{
    partial class SalaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryForm));
            this.SalaryDataGridView = new System.Windows.Forms.DataGridView();
            this.idsalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daytimehoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nighthoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payforhourdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payforhournDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flower_databaseDataSet = new FlowerCourse.Flower_databaseDataSet();
            this.salaryTableAdapter = new FlowerCourse.Flower_databaseDataSetTableAdapters.SalaryTableAdapter();
            this.AddSalaryPanel = new System.Windows.Forms.Panel();
            this.AddSalaryButton = new System.Windows.Forms.Button();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.PayNightTextBox = new System.Windows.Forms.TextBox();
            this.PayForDayTextBox = new System.Windows.Forms.TextBox();
            this.NightHoursTextBox = new System.Windows.Forms.TextBox();
            this.DayHoursTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeSalaryPanel = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.SalaryIDTextBox = new System.Windows.Forms.TextBox();
            this.ChangeSalaryButton = new System.Windows.Forms.Button();
            this.EmplIDChangeTextBox = new System.Windows.Forms.TextBox();
            this.PayForNightChangeTextBox = new System.Windows.Forms.TextBox();
            this.PayForDayChangeTextBox = new System.Windows.Forms.TextBox();
            this.NightHourChangeTextBox = new System.Windows.Forms.TextBox();
            this.DayHourChangeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.OpenAddSalaryButton = new System.Windows.Forms.Button();
            this.OpenChangeSalaryButton = new System.Windows.Forms.Button();
            this.DeleteSalaryButton = new System.Windows.Forms.Button();
            this.OpenSearchSalaryButton = new System.Windows.Forms.Button();
            this.SearchSalaryPanel = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchSalaryComboBox = new System.Windows.Forms.ComboBox();
            this.SearchSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet)).BeginInit();
            this.AddSalaryPanel.SuspendLayout();
            this.ChangeSalaryPanel.SuspendLayout();
            this.SearchSalaryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalaryDataGridView
            // 
            this.SalaryDataGridView.AutoGenerateColumns = false;
            this.SalaryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SalaryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SalaryDataGridView.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.SalaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalaryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsalaryDataGridViewTextBoxColumn,
            this.daytimehoursDataGridViewTextBoxColumn,
            this.nighthoursDataGridViewTextBoxColumn,
            this.payforhourdDataGridViewTextBoxColumn,
            this.payforhournDataGridViewTextBoxColumn,
            this.idemployeeDataGridViewTextBoxColumn});
            this.SalaryDataGridView.DataSource = this.salaryBindingSource;
            this.SalaryDataGridView.Location = new System.Drawing.Point(-1, 0);
            this.SalaryDataGridView.Name = "SalaryDataGridView";
            this.SalaryDataGridView.RowHeadersWidth = 82;
            this.SalaryDataGridView.RowTemplate.Height = 33;
            this.SalaryDataGridView.Size = new System.Drawing.Size(1282, 312);
            this.SalaryDataGridView.TabIndex = 0;
            // 
            // idsalaryDataGridViewTextBoxColumn
            // 
            this.idsalaryDataGridViewTextBoxColumn.DataPropertyName = "id_salary";
            this.idsalaryDataGridViewTextBoxColumn.HeaderText = "id_salary";
            this.idsalaryDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idsalaryDataGridViewTextBoxColumn.Name = "idsalaryDataGridViewTextBoxColumn";
            this.idsalaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // daytimehoursDataGridViewTextBoxColumn
            // 
            this.daytimehoursDataGridViewTextBoxColumn.DataPropertyName = "daytime_hours";
            this.daytimehoursDataGridViewTextBoxColumn.HeaderText = "daytime_hours";
            this.daytimehoursDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.daytimehoursDataGridViewTextBoxColumn.Name = "daytimehoursDataGridViewTextBoxColumn";
            // 
            // nighthoursDataGridViewTextBoxColumn
            // 
            this.nighthoursDataGridViewTextBoxColumn.DataPropertyName = "night_hours";
            this.nighthoursDataGridViewTextBoxColumn.HeaderText = "night_hours";
            this.nighthoursDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nighthoursDataGridViewTextBoxColumn.Name = "nighthoursDataGridViewTextBoxColumn";
            // 
            // payforhourdDataGridViewTextBoxColumn
            // 
            this.payforhourdDataGridViewTextBoxColumn.DataPropertyName = "pay_for_hour_d";
            this.payforhourdDataGridViewTextBoxColumn.HeaderText = "pay_for_hour_d";
            this.payforhourdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.payforhourdDataGridViewTextBoxColumn.Name = "payforhourdDataGridViewTextBoxColumn";
            // 
            // payforhournDataGridViewTextBoxColumn
            // 
            this.payforhournDataGridViewTextBoxColumn.DataPropertyName = "pay_for_hour_n";
            this.payforhournDataGridViewTextBoxColumn.HeaderText = "pay_for_hour_n";
            this.payforhournDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.payforhournDataGridViewTextBoxColumn.Name = "payforhournDataGridViewTextBoxColumn";
            // 
            // idemployeeDataGridViewTextBoxColumn
            // 
            this.idemployeeDataGridViewTextBoxColumn.DataPropertyName = "id_employee";
            this.idemployeeDataGridViewTextBoxColumn.HeaderText = "id_employee";
            this.idemployeeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idemployeeDataGridViewTextBoxColumn.Name = "idemployeeDataGridViewTextBoxColumn";
            // 
            // salaryBindingSource
            // 
            this.salaryBindingSource.DataMember = "Salary";
            this.salaryBindingSource.DataSource = this.flower_databaseDataSet;
            // 
            // flower_databaseDataSet
            // 
            this.flower_databaseDataSet.DataSetName = "Flower_databaseDataSet";
            this.flower_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salaryTableAdapter
            // 
            this.salaryTableAdapter.ClearBeforeFill = true;
            // 
            // AddSalaryPanel
            // 
            this.AddSalaryPanel.Controls.Add(this.AddSalaryButton);
            this.AddSalaryPanel.Controls.Add(this.EmployeeIDTextBox);
            this.AddSalaryPanel.Controls.Add(this.PayNightTextBox);
            this.AddSalaryPanel.Controls.Add(this.PayForDayTextBox);
            this.AddSalaryPanel.Controls.Add(this.NightHoursTextBox);
            this.AddSalaryPanel.Controls.Add(this.DayHoursTextBox);
            this.AddSalaryPanel.Controls.Add(this.label6);
            this.AddSalaryPanel.Controls.Add(this.label7);
            this.AddSalaryPanel.Controls.Add(this.label5);
            this.AddSalaryPanel.Controls.Add(this.label4);
            this.AddSalaryPanel.Controls.Add(this.label3);
            this.AddSalaryPanel.Controls.Add(this.label1);
            this.AddSalaryPanel.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddSalaryPanel.Location = new System.Drawing.Point(-1, 311);
            this.AddSalaryPanel.Name = "AddSalaryPanel";
            this.AddSalaryPanel.Size = new System.Drawing.Size(415, 771);
            this.AddSalaryPanel.TabIndex = 1;
            // 
            // AddSalaryButton
            // 
            this.AddSalaryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddSalaryButton.BackgroundImage")));
            this.AddSalaryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddSalaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddSalaryButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.AddSalaryButton.Location = new System.Drawing.Point(129, 617);
            this.AddSalaryButton.Name = "AddSalaryButton";
            this.AddSalaryButton.Size = new System.Drawing.Size(121, 78);
            this.AddSalaryButton.TabIndex = 12;
            this.AddSalaryButton.UseVisualStyleBackColor = true;
            this.AddSalaryButton.Click += new System.EventHandler(this.AddSalaryButton_Click);
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(98, 541);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(214, 39);
            this.EmployeeIDTextBox.TabIndex = 11;
            // 
            // PayNightTextBox
            // 
            this.PayNightTextBox.Location = new System.Drawing.Point(102, 449);
            this.PayNightTextBox.Name = "PayNightTextBox";
            this.PayNightTextBox.Size = new System.Drawing.Size(214, 39);
            this.PayNightTextBox.TabIndex = 10;
            // 
            // PayForDayTextBox
            // 
            this.PayForDayTextBox.Location = new System.Drawing.Point(98, 372);
            this.PayForDayTextBox.Name = "PayForDayTextBox";
            this.PayForDayTextBox.Size = new System.Drawing.Size(214, 39);
            this.PayForDayTextBox.TabIndex = 9;
            // 
            // NightHoursTextBox
            // 
            this.NightHoursTextBox.Location = new System.Drawing.Point(98, 274);
            this.NightHoursTextBox.Name = "NightHoursTextBox";
            this.NightHoursTextBox.Size = new System.Drawing.Size(214, 39);
            this.NightHoursTextBox.TabIndex = 8;
            // 
            // DayHoursTextBox
            // 
            this.DayHoursTextBox.Location = new System.Drawing.Point(98, 169);
            this.DayHoursTextBox.Name = "DayHoursTextBox";
            this.DayHoursTextBox.Size = new System.Drawing.Size(214, 39);
            this.DayHoursTextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(334, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Идентфикатор работника";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(276, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "Оплата за час (ночь)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Оплата за час (день)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Рабочие часы (ночь)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Рабочие часы (день)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление зарплаты";
            // 
            // ChangeSalaryPanel
            // 
            this.ChangeSalaryPanel.Controls.Add(this.label14);
            this.ChangeSalaryPanel.Controls.Add(this.SalaryIDTextBox);
            this.ChangeSalaryPanel.Controls.Add(this.ChangeSalaryButton);
            this.ChangeSalaryPanel.Controls.Add(this.EmplIDChangeTextBox);
            this.ChangeSalaryPanel.Controls.Add(this.PayForNightChangeTextBox);
            this.ChangeSalaryPanel.Controls.Add(this.PayForDayChangeTextBox);
            this.ChangeSalaryPanel.Controls.Add(this.NightHourChangeTextBox);
            this.ChangeSalaryPanel.Controls.Add(this.DayHourChangeTextBox);
            this.ChangeSalaryPanel.Controls.Add(this.label2);
            this.ChangeSalaryPanel.Controls.Add(this.label8);
            this.ChangeSalaryPanel.Controls.Add(this.label9);
            this.ChangeSalaryPanel.Controls.Add(this.label10);
            this.ChangeSalaryPanel.Controls.Add(this.label11);
            this.ChangeSalaryPanel.Controls.Add(this.label12);
            this.ChangeSalaryPanel.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeSalaryPanel.Location = new System.Drawing.Point(559, 311);
            this.ChangeSalaryPanel.Name = "ChangeSalaryPanel";
            this.ChangeSalaryPanel.Size = new System.Drawing.Size(386, 771);
            this.ChangeSalaryPanel.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(338, 32);
            this.label14.TabIndex = 14;
            this.label14.Text = "Идентификатор зарплаты";
            // 
            // SalaryIDTextBox
            // 
            this.SalaryIDTextBox.Location = new System.Drawing.Point(57, 143);
            this.SalaryIDTextBox.Name = "SalaryIDTextBox";
            this.SalaryIDTextBox.ReadOnly = true;
            this.SalaryIDTextBox.Size = new System.Drawing.Size(293, 39);
            this.SalaryIDTextBox.TabIndex = 13;
            // 
            // ChangeSalaryButton
            // 
            this.ChangeSalaryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChangeSalaryButton.BackgroundImage")));
            this.ChangeSalaryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChangeSalaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeSalaryButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.ChangeSalaryButton.Location = new System.Drawing.Point(122, 676);
            this.ChangeSalaryButton.Name = "ChangeSalaryButton";
            this.ChangeSalaryButton.Size = new System.Drawing.Size(121, 78);
            this.ChangeSalaryButton.TabIndex = 12;
            this.ChangeSalaryButton.UseVisualStyleBackColor = true;
            this.ChangeSalaryButton.Click += new System.EventHandler(this.ChangeSalaryButton_Click);
            // 
            // EmplIDChangeTextBox
            // 
            this.EmplIDChangeTextBox.Location = new System.Drawing.Point(57, 624);
            this.EmplIDChangeTextBox.Name = "EmplIDChangeTextBox";
            this.EmplIDChangeTextBox.Size = new System.Drawing.Size(293, 39);
            this.EmplIDChangeTextBox.TabIndex = 11;
            // 
            // PayForNightChangeTextBox
            // 
            this.PayForNightChangeTextBox.Location = new System.Drawing.Point(57, 528);
            this.PayForNightChangeTextBox.Name = "PayForNightChangeTextBox";
            this.PayForNightChangeTextBox.Size = new System.Drawing.Size(293, 39);
            this.PayForNightChangeTextBox.TabIndex = 10;
            // 
            // PayForDayChangeTextBox
            // 
            this.PayForDayChangeTextBox.Location = new System.Drawing.Point(57, 444);
            this.PayForDayChangeTextBox.Name = "PayForDayChangeTextBox";
            this.PayForDayChangeTextBox.Size = new System.Drawing.Size(293, 39);
            this.PayForDayChangeTextBox.TabIndex = 9;
            // 
            // NightHourChangeTextBox
            // 
            this.NightHourChangeTextBox.Location = new System.Drawing.Point(57, 339);
            this.NightHourChangeTextBox.Name = "NightHourChangeTextBox";
            this.NightHourChangeTextBox.Size = new System.Drawing.Size(293, 39);
            this.NightHourChangeTextBox.TabIndex = 8;
            // 
            // DayHourChangeTextBox
            // 
            this.DayHourChangeTextBox.Location = new System.Drawing.Point(57, 243);
            this.DayHourChangeTextBox.Name = "DayHourChangeTextBox";
            this.DayHourChangeTextBox.Size = new System.Drawing.Size(293, 39);
            this.DayHourChangeTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Идентфикатор работника";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 493);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(276, 32);
            this.label8.TabIndex = 5;
            this.label8.Text = "Оплата за час (ночь)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(279, 32);
            this.label9.TabIndex = 4;
            this.label9.Text = "Оплата за час (день)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(271, 32);
            this.label10.TabIndex = 3;
            this.label10.Text = "Рабочие часы (ночь)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(61, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(274, 32);
            this.label11.TabIndex = 2;
            this.label11.Text = "Рабочие часы (день)";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(51, 21);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(322, 64);
            this.label12.TabIndex = 0;
            this.label12.Text = "Изменение зарплаты (выберите строку)";
            // 
            // OpenAddSalaryButton
            // 
            this.OpenAddSalaryButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenAddSalaryButton.Location = new System.Drawing.Point(1330, 20);
            this.OpenAddSalaryButton.Name = "OpenAddSalaryButton";
            this.OpenAddSalaryButton.Size = new System.Drawing.Size(300, 44);
            this.OpenAddSalaryButton.TabIndex = 3;
            this.OpenAddSalaryButton.Text = "Добавить зарплату";
            this.OpenAddSalaryButton.UseVisualStyleBackColor = true;
            this.OpenAddSalaryButton.Click += new System.EventHandler(this.OpenAddSalaryButton_Click);
            // 
            // OpenChangeSalaryButton
            // 
            this.OpenChangeSalaryButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenChangeSalaryButton.Location = new System.Drawing.Point(1330, 94);
            this.OpenChangeSalaryButton.Name = "OpenChangeSalaryButton";
            this.OpenChangeSalaryButton.Size = new System.Drawing.Size(300, 42);
            this.OpenChangeSalaryButton.TabIndex = 4;
            this.OpenChangeSalaryButton.Text = "Изменить информацию";
            this.OpenChangeSalaryButton.UseVisualStyleBackColor = true;
            this.OpenChangeSalaryButton.Click += new System.EventHandler(this.OpenChangeSalaryButton_Click);
            // 
            // DeleteSalaryButton
            // 
            this.DeleteSalaryButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteSalaryButton.Location = new System.Drawing.Point(1330, 234);
            this.DeleteSalaryButton.Name = "DeleteSalaryButton";
            this.DeleteSalaryButton.Size = new System.Drawing.Size(300, 78);
            this.DeleteSalaryButton.TabIndex = 5;
            this.DeleteSalaryButton.Text = "Удалить данные (выберите строку)";
            this.DeleteSalaryButton.UseVisualStyleBackColor = true;
            this.DeleteSalaryButton.Click += new System.EventHandler(this.DeleteSalaryButton_Click);
            // 
            // OpenSearchSalaryButton
            // 
            this.OpenSearchSalaryButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenSearchSalaryButton.Location = new System.Drawing.Point(1330, 162);
            this.OpenSearchSalaryButton.Name = "OpenSearchSalaryButton";
            this.OpenSearchSalaryButton.Size = new System.Drawing.Size(300, 44);
            this.OpenSearchSalaryButton.TabIndex = 6;
            this.OpenSearchSalaryButton.Text = "Поиск";
            this.OpenSearchSalaryButton.UseVisualStyleBackColor = true;
            this.OpenSearchSalaryButton.Click += new System.EventHandler(this.OpenSearchSalaryButton_Click);
            // 
            // SearchSalaryPanel
            // 
            this.SearchSalaryPanel.Controls.Add(this.SearchButton);
            this.SearchSalaryPanel.Controls.Add(this.SearchSalaryComboBox);
            this.SearchSalaryPanel.Controls.Add(this.SearchSalaryTextBox);
            this.SearchSalaryPanel.Controls.Add(this.label16);
            this.SearchSalaryPanel.Controls.Add(this.label15);
            this.SearchSalaryPanel.Controls.Add(this.label13);
            this.SearchSalaryPanel.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchSalaryPanel.Location = new System.Drawing.Point(1037, 476);
            this.SearchSalaryPanel.Name = "SearchSalaryPanel";
            this.SearchSalaryPanel.Size = new System.Drawing.Size(494, 453);
            this.SearchSalaryPanel.TabIndex = 7;
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.BackgroundImage")));
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.SearchButton.Location = new System.Drawing.Point(199, 356);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(121, 78);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchSalaryComboBox
            // 
            this.SearchSalaryComboBox.FormattingEnabled = true;
            this.SearchSalaryComboBox.Location = new System.Drawing.Point(89, 171);
            this.SearchSalaryComboBox.Name = "SearchSalaryComboBox";
            this.SearchSalaryComboBox.Size = new System.Drawing.Size(319, 40);
            this.SearchSalaryComboBox.TabIndex = 4;
            // 
            // SearchSalaryTextBox
            // 
            this.SearchSalaryTextBox.Location = new System.Drawing.Point(89, 279);
            this.SearchSalaryTextBox.Name = "SearchSalaryTextBox";
            this.SearchSalaryTextBox.Size = new System.Drawing.Size(319, 39);
            this.SearchSalaryTextBox.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(60, 230);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(398, 32);
            this.label16.TabIndex = 2;
            this.label16.Text = "Введите необходимые данные";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(74, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(351, 32);
            this.label15.TabIndex = 1;
            this.label15.Text = "Выберите нужный столбец";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(120, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(254, 32);
            this.label13.TabIndex = 0;
            this.label13.Text = "Поиск по таблице";
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton.BackgroundImage")));
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.BackButton.Location = new System.Drawing.Point(1509, 987);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(121, 78);
            this.BackButton.TabIndex = 8;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1641, 1077);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SearchSalaryPanel);
            this.Controls.Add(this.OpenSearchSalaryButton);
            this.Controls.Add(this.DeleteSalaryButton);
            this.Controls.Add(this.OpenChangeSalaryButton);
            this.Controls.Add(this.OpenAddSalaryButton);
            this.Controls.Add(this.ChangeSalaryPanel);
            this.Controls.Add(this.AddSalaryPanel);
            this.Controls.Add(this.SalaryDataGridView);
            this.Name = "SalaryForm";
            this.Text = "Информация о зарплате";
            this.Load += new System.EventHandler(this.SalaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalaryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet)).EndInit();
            this.AddSalaryPanel.ResumeLayout(false);
            this.AddSalaryPanel.PerformLayout();
            this.ChangeSalaryPanel.ResumeLayout(false);
            this.ChangeSalaryPanel.PerformLayout();
            this.SearchSalaryPanel.ResumeLayout(false);
            this.SearchSalaryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SalaryDataGridView;
        private Flower_databaseDataSet flower_databaseDataSet;
        private System.Windows.Forms.BindingSource salaryBindingSource;
        private Flower_databaseDataSetTableAdapters.SalaryTableAdapter salaryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daytimehoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nighthoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payforhourdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payforhournDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel AddSalaryPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddSalaryButton;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.TextBox PayNightTextBox;
        private System.Windows.Forms.TextBox PayForDayTextBox;
        private System.Windows.Forms.TextBox NightHoursTextBox;
        private System.Windows.Forms.TextBox DayHoursTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel ChangeSalaryPanel;
        private System.Windows.Forms.Button ChangeSalaryButton;
        private System.Windows.Forms.TextBox EmplIDChangeTextBox;
        private System.Windows.Forms.TextBox PayForNightChangeTextBox;
        private System.Windows.Forms.TextBox PayForDayChangeTextBox;
        private System.Windows.Forms.TextBox NightHourChangeTextBox;
        private System.Windows.Forms.TextBox DayHourChangeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button OpenAddSalaryButton;
        private System.Windows.Forms.Button OpenChangeSalaryButton;
        private System.Windows.Forms.Button DeleteSalaryButton;
        private System.Windows.Forms.Button OpenSearchSalaryButton;
        private System.Windows.Forms.Panel SearchSalaryPanel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox SalaryIDTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox SearchSalaryTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox SearchSalaryComboBox;
        private System.Windows.Forms.Button SearchButton;
    }
}