namespace FlowerCourse
{
    partial class EmployeeInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeInfoForm));
            this.EmployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.idemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameofemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameofemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobtitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flower_databaseDataSet = new FlowerCourse.Flower_databaseDataSet();
            this.employeeTableAdapter = new FlowerCourse.Flower_databaseDataSetTableAdapters.EmployeeTableAdapter();
            this.AddEmployeePanel = new System.Windows.Forms.Panel();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.TitleComboBox = new System.Windows.Forms.ComboBox();
            this.AddPhNumTextBox = new System.Windows.Forms.TextBox();
            this.AddNameTextBox = new System.Windows.Forms.TextBox();
            this.AddSurnameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenAddButton = new System.Windows.Forms.Button();
            this.OpenChangeButton = new System.Windows.Forms.Button();
            this.OpenSearchButton = new System.Windows.Forms.Button();
            this.DeleteEmployeeButton = new System.Windows.Forms.Button();
            this.ChangeEmployeePanel = new System.Windows.Forms.Panel();
            this.ChangeIDEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.ChangeEmployeeButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.ChangeDepartmentEmployeeComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ChangeTitleComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ChangePhNumTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ChangeNameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ChangeSurnameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchEmployeePanel = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SearchInfoComboBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet)).BeginInit();
            this.AddEmployeePanel.SuspendLayout();
            this.ChangeEmployeePanel.SuspendLayout();
            this.SearchEmployeePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeDataGridView
            // 
            this.EmployeeDataGridView.AutoGenerateColumns = false;
            this.EmployeeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.EmployeeDataGridView.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idemployeeDataGridViewTextBoxColumn,
            this.surnameofemployeeDataGridViewTextBoxColumn,
            this.nameofemployeeDataGridViewTextBoxColumn,
            this.phnumDataGridViewTextBoxColumn,
            this.jobtitleDataGridViewTextBoxColumn,
            this.iddepartmentDataGridViewTextBoxColumn});
            this.EmployeeDataGridView.DataSource = this.employeeBindingSource;
            this.EmployeeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.RowHeadersWidth = 82;
            this.EmployeeDataGridView.RowTemplate.Height = 33;
            this.EmployeeDataGridView.Size = new System.Drawing.Size(1282, 366);
            this.EmployeeDataGridView.TabIndex = 0;
            // 
            // idemployeeDataGridViewTextBoxColumn
            // 
            this.idemployeeDataGridViewTextBoxColumn.DataPropertyName = "id_employee";
            this.idemployeeDataGridViewTextBoxColumn.HeaderText = "id_employee";
            this.idemployeeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idemployeeDataGridViewTextBoxColumn.Name = "idemployeeDataGridViewTextBoxColumn";
            this.idemployeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameofemployeeDataGridViewTextBoxColumn
            // 
            this.surnameofemployeeDataGridViewTextBoxColumn.DataPropertyName = "surname_of_employee";
            this.surnameofemployeeDataGridViewTextBoxColumn.HeaderText = "surname_of_employee";
            this.surnameofemployeeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.surnameofemployeeDataGridViewTextBoxColumn.Name = "surnameofemployeeDataGridViewTextBoxColumn";
            // 
            // nameofemployeeDataGridViewTextBoxColumn
            // 
            this.nameofemployeeDataGridViewTextBoxColumn.DataPropertyName = "name_of_employee";
            this.nameofemployeeDataGridViewTextBoxColumn.HeaderText = "name_of_employee";
            this.nameofemployeeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameofemployeeDataGridViewTextBoxColumn.Name = "nameofemployeeDataGridViewTextBoxColumn";
            // 
            // phnumDataGridViewTextBoxColumn
            // 
            this.phnumDataGridViewTextBoxColumn.DataPropertyName = "ph_num";
            this.phnumDataGridViewTextBoxColumn.HeaderText = "ph_num";
            this.phnumDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.phnumDataGridViewTextBoxColumn.Name = "phnumDataGridViewTextBoxColumn";
            // 
            // jobtitleDataGridViewTextBoxColumn
            // 
            this.jobtitleDataGridViewTextBoxColumn.DataPropertyName = "job_title";
            this.jobtitleDataGridViewTextBoxColumn.HeaderText = "job_title";
            this.jobtitleDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.jobtitleDataGridViewTextBoxColumn.Name = "jobtitleDataGridViewTextBoxColumn";
            // 
            // iddepartmentDataGridViewTextBoxColumn
            // 
            this.iddepartmentDataGridViewTextBoxColumn.DataPropertyName = "id_department";
            this.iddepartmentDataGridViewTextBoxColumn.HeaderText = "id_department";
            this.iddepartmentDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.iddepartmentDataGridViewTextBoxColumn.Name = "iddepartmentDataGridViewTextBoxColumn";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.flower_databaseDataSet;
            // 
            // flower_databaseDataSet
            // 
            this.flower_databaseDataSet.DataSetName = "Flower_databaseDataSet";
            this.flower_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // AddEmployeePanel
            // 
            this.AddEmployeePanel.Controls.Add(this.AddEmployeeButton);
            this.AddEmployeePanel.Controls.Add(this.DepartmentComboBox);
            this.AddEmployeePanel.Controls.Add(this.TitleComboBox);
            this.AddEmployeePanel.Controls.Add(this.AddPhNumTextBox);
            this.AddEmployeePanel.Controls.Add(this.AddNameTextBox);
            this.AddEmployeePanel.Controls.Add(this.AddSurnameTextBox);
            this.AddEmployeePanel.Controls.Add(this.label6);
            this.AddEmployeePanel.Controls.Add(this.label3);
            this.AddEmployeePanel.Controls.Add(this.label2);
            this.AddEmployeePanel.Controls.Add(this.label1);
            this.AddEmployeePanel.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddEmployeePanel.Location = new System.Drawing.Point(0, 364);
            this.AddEmployeePanel.Name = "AddEmployeePanel";
            this.AddEmployeePanel.Size = new System.Drawing.Size(495, 875);
            this.AddEmployeePanel.TabIndex = 1;
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddEmployeeButton.BackgroundImage")));
            this.AddEmployeeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployeeButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.AddEmployeeButton.Location = new System.Drawing.Point(149, 753);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(127, 92);
            this.AddEmployeeButton.TabIndex = 11;
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Location = new System.Drawing.Point(36, 627);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(373, 40);
            this.DepartmentComboBox.TabIndex = 10;
            this.DepartmentComboBox.Text = "Выберите отдел";
            // 
            // TitleComboBox
            // 
            this.TitleComboBox.FormattingEnabled = true;
            this.TitleComboBox.Items.AddRange(new object[] {
            "Управляющий",
            "Курьер",
            "Работник склада",
            "Флорист"});
            this.TitleComboBox.Location = new System.Drawing.Point(36, 525);
            this.TitleComboBox.Name = "TitleComboBox";
            this.TitleComboBox.Size = new System.Drawing.Size(373, 40);
            this.TitleComboBox.TabIndex = 9;
            this.TitleComboBox.Text = "Выберите должность";
            // 
            // AddPhNumTextBox
            // 
            this.AddPhNumTextBox.Location = new System.Drawing.Point(36, 409);
            this.AddPhNumTextBox.Name = "AddPhNumTextBox";
            this.AddPhNumTextBox.Size = new System.Drawing.Size(373, 39);
            this.AddPhNumTextBox.TabIndex = 8;
            // 
            // AddNameTextBox
            // 
            this.AddNameTextBox.Location = new System.Drawing.Point(36, 273);
            this.AddNameTextBox.Name = "AddNameTextBox";
            this.AddNameTextBox.Size = new System.Drawing.Size(373, 39);
            this.AddNameTextBox.TabIndex = 7;
            // 
            // AddSurnameTextBox
            // 
            this.AddSurnameTextBox.Location = new System.Drawing.Point(36, 152);
            this.AddSurnameTextBox.Name = "AddSurnameTextBox";
            this.AddSurnameTextBox.Size = new System.Drawing.Size(373, 39);
            this.AddSurnameTextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(30, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(443, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Добавление нового сотрудника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер телефона";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя сотрудника";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия сотрудника";
            // 
            // OpenAddButton
            // 
            this.OpenAddButton.BackColor = System.Drawing.Color.SkyBlue;
            this.OpenAddButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenAddButton.Location = new System.Drawing.Point(1371, 24);
            this.OpenAddButton.Name = "OpenAddButton";
            this.OpenAddButton.Size = new System.Drawing.Size(271, 82);
            this.OpenAddButton.TabIndex = 2;
            this.OpenAddButton.Text = "Добавить сотрудника";
            this.OpenAddButton.UseVisualStyleBackColor = false;
            this.OpenAddButton.Click += new System.EventHandler(this.OpenAddButton_Click);
            // 
            // OpenChangeButton
            // 
            this.OpenChangeButton.BackColor = System.Drawing.Color.SkyBlue;
            this.OpenChangeButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenChangeButton.Location = new System.Drawing.Point(1371, 124);
            this.OpenChangeButton.Name = "OpenChangeButton";
            this.OpenChangeButton.Size = new System.Drawing.Size(271, 74);
            this.OpenChangeButton.TabIndex = 3;
            this.OpenChangeButton.Text = "Изменить данные";
            this.OpenChangeButton.UseVisualStyleBackColor = false;
            this.OpenChangeButton.Click += new System.EventHandler(this.OpenChangeButton_Click);
            // 
            // OpenSearchButton
            // 
            this.OpenSearchButton.BackColor = System.Drawing.Color.SkyBlue;
            this.OpenSearchButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenSearchButton.Location = new System.Drawing.Point(1371, 211);
            this.OpenSearchButton.Name = "OpenSearchButton";
            this.OpenSearchButton.Size = new System.Drawing.Size(271, 68);
            this.OpenSearchButton.TabIndex = 4;
            this.OpenSearchButton.Text = "Поиск";
            this.OpenSearchButton.UseVisualStyleBackColor = false;
            this.OpenSearchButton.Click += new System.EventHandler(this.OpenSearchButton_Click);
            // 
            // DeleteEmployeeButton
            // 
            this.DeleteEmployeeButton.BackColor = System.Drawing.Color.SkyBlue;
            this.DeleteEmployeeButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteEmployeeButton.Location = new System.Drawing.Point(1371, 295);
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.DeleteEmployeeButton.Size = new System.Drawing.Size(271, 108);
            this.DeleteEmployeeButton.TabIndex = 5;
            this.DeleteEmployeeButton.Text = "Удаление сотрудника (выберите строку)";
            this.DeleteEmployeeButton.UseVisualStyleBackColor = false;
            this.DeleteEmployeeButton.Click += new System.EventHandler(this.DeleteEmployeeButton_Click);
            // 
            // ChangeEmployeePanel
            // 
            this.ChangeEmployeePanel.Controls.Add(this.ChangeIDEmployeeTextBox);
            this.ChangeEmployeePanel.Controls.Add(this.ChangeEmployeeButton);
            this.ChangeEmployeePanel.Controls.Add(this.label13);
            this.ChangeEmployeePanel.Controls.Add(this.ChangeDepartmentEmployeeComboBox);
            this.ChangeEmployeePanel.Controls.Add(this.label12);
            this.ChangeEmployeePanel.Controls.Add(this.ChangeTitleComboBox);
            this.ChangeEmployeePanel.Controls.Add(this.label11);
            this.ChangeEmployeePanel.Controls.Add(this.ChangePhNumTextBox);
            this.ChangeEmployeePanel.Controls.Add(this.label10);
            this.ChangeEmployeePanel.Controls.Add(this.ChangeNameTextBox);
            this.ChangeEmployeePanel.Controls.Add(this.label9);
            this.ChangeEmployeePanel.Controls.Add(this.ChangeSurnameTextBox);
            this.ChangeEmployeePanel.Controls.Add(this.label8);
            this.ChangeEmployeePanel.Controls.Add(this.label7);
            this.ChangeEmployeePanel.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeEmployeePanel.Location = new System.Drawing.Point(575, 364);
            this.ChangeEmployeePanel.Name = "ChangeEmployeePanel";
            this.ChangeEmployeePanel.Size = new System.Drawing.Size(498, 875);
            this.ChangeEmployeePanel.TabIndex = 6;
            // 
            // ChangeIDEmployeeTextBox
            // 
            this.ChangeIDEmployeeTextBox.Location = new System.Drawing.Point(83, 152);
            this.ChangeIDEmployeeTextBox.Name = "ChangeIDEmployeeTextBox";
            this.ChangeIDEmployeeTextBox.ReadOnly = true;
            this.ChangeIDEmployeeTextBox.Size = new System.Drawing.Size(342, 39);
            this.ChangeIDEmployeeTextBox.TabIndex = 13;
            // 
            // ChangeEmployeeButton
            // 
            this.ChangeEmployeeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChangeEmployeeButton.BackgroundImage")));
            this.ChangeEmployeeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChangeEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeEmployeeButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.ChangeEmployeeButton.Location = new System.Drawing.Point(192, 767);
            this.ChangeEmployeeButton.Name = "ChangeEmployeeButton";
            this.ChangeEmployeeButton.Size = new System.Drawing.Size(120, 93);
            this.ChangeEmployeeButton.TabIndex = 12;
            this.ChangeEmployeeButton.UseVisualStyleBackColor = true;
            this.ChangeEmployeeButton.Click += new System.EventHandler(this.ChangeEmployeeButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(77, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(362, 32);
            this.label13.TabIndex = 11;
            this.label13.Text = "Идентификатор сотрудника";
            // 
            // ChangeDepartmentEmployeeComboBox
            // 
            this.ChangeDepartmentEmployeeComboBox.FormattingEnabled = true;
            this.ChangeDepartmentEmployeeComboBox.Location = new System.Drawing.Point(84, 708);
            this.ChangeDepartmentEmployeeComboBox.Name = "ChangeDepartmentEmployeeComboBox";
            this.ChangeDepartmentEmployeeComboBox.Size = new System.Drawing.Size(342, 40);
            this.ChangeDepartmentEmployeeComboBox.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(206, 673);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 32);
            this.label12.TabIndex = 9;
            this.label12.Text = "Отдел";
            // 
            // ChangeTitleComboBox
            // 
            this.ChangeTitleComboBox.FormattingEnabled = true;
            this.ChangeTitleComboBox.Items.AddRange(new object[] {
            "Управляющий",
            "Курьер",
            "Работник склада",
            "Флорист"});
            this.ChangeTitleComboBox.Location = new System.Drawing.Point(84, 599);
            this.ChangeTitleComboBox.Name = "ChangeTitleComboBox";
            this.ChangeTitleComboBox.Size = new System.Drawing.Size(342, 40);
            this.ChangeTitleComboBox.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(186, 564);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 32);
            this.label11.TabIndex = 7;
            this.label11.Text = "Должность";
            // 
            // ChangePhNumTextBox
            // 
            this.ChangePhNumTextBox.Location = new System.Drawing.Point(84, 479);
            this.ChangePhNumTextBox.Name = "ChangePhNumTextBox";
            this.ChangePhNumTextBox.Size = new System.Drawing.Size(342, 39);
            this.ChangePhNumTextBox.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(143, 444);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 32);
            this.label10.TabIndex = 5;
            this.label10.Text = "Номер телефона";
            // 
            // ChangeNameTextBox
            // 
            this.ChangeNameTextBox.Location = new System.Drawing.Point(84, 357);
            this.ChangeNameTextBox.Name = "ChangeNameTextBox";
            this.ChangeNameTextBox.Size = new System.Drawing.Size(342, 39);
            this.ChangeNameTextBox.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(217, 32);
            this.label9.TabIndex = 3;
            this.label9.Text = "Имя сотрудника";
            // 
            // ChangeSurnameTextBox
            // 
            this.ChangeSurnameTextBox.Location = new System.Drawing.Point(84, 246);
            this.ChangeSurnameTextBox.Name = "ChangeSurnameTextBox";
            this.ChangeSurnameTextBox.Size = new System.Drawing.Size(342, 39);
            this.ChangeSurnameTextBox.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(279, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "Фамилия сотрудника";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(41, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(431, 99);
            this.label7.TabIndex = 0;
            this.label7.Text = "Изменить данные о сотруднике (выберите строку)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchEmployeePanel
            // 
            this.SearchEmployeePanel.Controls.Add(this.label4);
            this.SearchEmployeePanel.Controls.Add(this.SearchButton);
            this.SearchEmployeePanel.Controls.Add(this.InfoTextBox);
            this.SearchEmployeePanel.Controls.Add(this.label16);
            this.SearchEmployeePanel.Controls.Add(this.SearchInfoComboBox);
            this.SearchEmployeePanel.Controls.Add(this.label14);
            this.SearchEmployeePanel.Location = new System.Drawing.Point(1203, 536);
            this.SearchEmployeePanel.Name = "SearchEmployeePanel";
            this.SearchEmployeePanel.Size = new System.Drawing.Size(352, 445);
            this.SearchEmployeePanel.TabIndex = 7;
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.BackgroundImage")));
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.SearchButton.Location = new System.Drawing.Point(128, 344);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(121, 78);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoTextBox.Location = new System.Drawing.Point(37, 261);
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(297, 39);
            this.InfoTextBox.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(83, 213);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(221, 32);
            this.label16.TabIndex = 3;
            this.label16.Text = "Введите данные";
            // 
            // SearchInfoComboBox
            // 
            this.SearchInfoComboBox.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchInfoComboBox.FormattingEnabled = true;
            this.SearchInfoComboBox.Location = new System.Drawing.Point(37, 147);
            this.SearchInfoComboBox.Name = "SearchInfoComboBox";
            this.SearchInfoComboBox.Size = new System.Drawing.Size(288, 40);
            this.SearchInfoComboBox.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(132, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 32);
            this.label14.TabIndex = 0;
            this.label14.Text = "Поиск";
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton.BackgroundImage")));
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.BackButton.Location = new System.Drawing.Point(1504, 1140);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(121, 78);
            this.BackButton.TabIndex = 8;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(56, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Выберите столбец";
            // 
            // EmployeeInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1670, 1236);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SearchEmployeePanel);
            this.Controls.Add(this.ChangeEmployeePanel);
            this.Controls.Add(this.DeleteEmployeeButton);
            this.Controls.Add(this.OpenSearchButton);
            this.Controls.Add(this.OpenChangeButton);
            this.Controls.Add(this.OpenAddButton);
            this.Controls.Add(this.AddEmployeePanel);
            this.Controls.Add(this.EmployeeDataGridView);
            this.Name = "EmployeeInfoForm";
            this.Text = "Информация о сотрудниках";
            this.Load += new System.EventHandler(this.EmployeeInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet)).EndInit();
            this.AddEmployeePanel.ResumeLayout(false);
            this.AddEmployeePanel.PerformLayout();
            this.ChangeEmployeePanel.ResumeLayout(false);
            this.ChangeEmployeePanel.PerformLayout();
            this.SearchEmployeePanel.ResumeLayout(false);
            this.SearchEmployeePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeDataGridView;
        private Flower_databaseDataSet flower_databaseDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Flower_databaseDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameofemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameofemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobtitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel AddEmployeePanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenAddButton;
        private System.Windows.Forms.Button OpenChangeButton;
        private System.Windows.Forms.Button OpenSearchButton;
        private System.Windows.Forms.Button DeleteEmployeeButton;
        private System.Windows.Forms.ComboBox TitleComboBox;
        private System.Windows.Forms.TextBox AddPhNumTextBox;
        private System.Windows.Forms.TextBox AddNameTextBox;
        private System.Windows.Forms.TextBox AddSurnameTextBox;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
        private System.Windows.Forms.Panel ChangeEmployeePanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ChangeSurnameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ChangeIDEmployeeTextBox;
        private System.Windows.Forms.Button ChangeEmployeeButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ChangeDepartmentEmployeeComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ChangeTitleComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ChangePhNumTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ChangeNameTextBox;
        private System.Windows.Forms.Panel SearchEmployeePanel;
        private System.Windows.Forms.TextBox InfoTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox SearchInfoComboBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label4;
    }
}