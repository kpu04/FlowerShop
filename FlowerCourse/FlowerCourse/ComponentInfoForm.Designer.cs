namespace FlowerCourse
{
    partial class ComponentInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentInfoForm));
            this.ComponentDataGridView = new System.Windows.Forms.DataGridView();
            this.idcomponentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelflifeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageconditionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flower_databaseDataSet = new FlowerCourse.Flower_databaseDataSet();
            this.componentTableAdapter = new FlowerCourse.Flower_databaseDataSetTableAdapters.ComponentTableAdapter();
            this.OpenAddPanel = new System.Windows.Forms.Button();
            this.OpenChangeButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.OpenSearchButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.AddSort = new System.Windows.Forms.TextBox();
            this.AddQuantityTextBox = new System.Windows.Forms.TextBox();
            this.AddShelfDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AddStorageTextBox = new System.Windows.Forms.TextBox();
            this.AddNameTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangePanel = new System.Windows.Forms.Panel();
            this.ChangeCompIDTextBox = new System.Windows.Forms.TextBox();
            this.ChangeSortTextBox = new System.Windows.Forms.TextBox();
            this.ChangeQuantityTextBox = new System.Windows.Forms.TextBox();
            this.ChangeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ChangeStorageTextBox = new System.Windows.Forms.TextBox();
            this.ChangeNameTextBox = new System.Windows.Forms.TextBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SearchComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ComponentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet)).BeginInit();
            this.AddPanel.SuspendLayout();
            this.ChangePanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComponentDataGridView
            // 
            this.ComponentDataGridView.AutoGenerateColumns = false;
            this.ComponentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ComponentDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ComponentDataGridView.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.ComponentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComponentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcomponentDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.shelflifeDataGridViewTextBoxColumn,
            this.storageconditionsDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.sortDataGridViewTextBoxColumn});
            this.ComponentDataGridView.DataSource = this.componentBindingSource;
            this.ComponentDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ComponentDataGridView.Name = "ComponentDataGridView";
            this.ComponentDataGridView.RowHeadersWidth = 82;
            this.ComponentDataGridView.RowTemplate.Height = 33;
            this.ComponentDataGridView.Size = new System.Drawing.Size(1761, 402);
            this.ComponentDataGridView.TabIndex = 0;
            // 
            // idcomponentDataGridViewTextBoxColumn
            // 
            this.idcomponentDataGridViewTextBoxColumn.DataPropertyName = "id_component";
            this.idcomponentDataGridViewTextBoxColumn.HeaderText = "id_component";
            this.idcomponentDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idcomponentDataGridViewTextBoxColumn.Name = "idcomponentDataGridViewTextBoxColumn";
            this.idcomponentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // shelflifeDataGridViewTextBoxColumn
            // 
            this.shelflifeDataGridViewTextBoxColumn.DataPropertyName = "shelf_life";
            this.shelflifeDataGridViewTextBoxColumn.HeaderText = "shelf_life";
            this.shelflifeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.shelflifeDataGridViewTextBoxColumn.Name = "shelflifeDataGridViewTextBoxColumn";
            // 
            // storageconditionsDataGridViewTextBoxColumn
            // 
            this.storageconditionsDataGridViewTextBoxColumn.DataPropertyName = "storage_conditions";
            this.storageconditionsDataGridViewTextBoxColumn.HeaderText = "storage_conditions";
            this.storageconditionsDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.storageconditionsDataGridViewTextBoxColumn.Name = "storageconditionsDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // sortDataGridViewTextBoxColumn
            // 
            this.sortDataGridViewTextBoxColumn.DataPropertyName = "sort";
            this.sortDataGridViewTextBoxColumn.HeaderText = "sort";
            this.sortDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.sortDataGridViewTextBoxColumn.Name = "sortDataGridViewTextBoxColumn";
            // 
            // componentBindingSource
            // 
            this.componentBindingSource.DataMember = "Component";
            this.componentBindingSource.DataSource = this.flower_databaseDataSet;
            // 
            // flower_databaseDataSet
            // 
            this.flower_databaseDataSet.DataSetName = "Flower_databaseDataSet";
            this.flower_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // componentTableAdapter
            // 
            this.componentTableAdapter.ClearBeforeFill = true;
            // 
            // OpenAddPanel
            // 
            this.OpenAddPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.OpenAddPanel.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenAddPanel.ForeColor = System.Drawing.Color.White;
            this.OpenAddPanel.Location = new System.Drawing.Point(51, 456);
            this.OpenAddPanel.Name = "OpenAddPanel";
            this.OpenAddPanel.Size = new System.Drawing.Size(278, 81);
            this.OpenAddPanel.TabIndex = 1;
            this.OpenAddPanel.Text = "Добавить компонент";
            this.OpenAddPanel.UseVisualStyleBackColor = false;
            this.OpenAddPanel.Click += new System.EventHandler(this.OpenAddPanel_Click);
            // 
            // OpenChangeButton
            // 
            this.OpenChangeButton.BackColor = System.Drawing.Color.SkyBlue;
            this.OpenChangeButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenChangeButton.ForeColor = System.Drawing.Color.White;
            this.OpenChangeButton.Location = new System.Drawing.Point(51, 573);
            this.OpenChangeButton.Name = "OpenChangeButton";
            this.OpenChangeButton.Size = new System.Drawing.Size(278, 81);
            this.OpenChangeButton.TabIndex = 2;
            this.OpenChangeButton.Text = "Изменить данные";
            this.OpenChangeButton.UseVisualStyleBackColor = false;
            this.OpenChangeButton.Click += new System.EventHandler(this.OpenChangeButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.SkyBlue;
            this.DeleteButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(51, 684);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(278, 81);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить запись";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // OpenSearchButton
            // 
            this.OpenSearchButton.BackColor = System.Drawing.Color.SkyBlue;
            this.OpenSearchButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenSearchButton.ForeColor = System.Drawing.Color.White;
            this.OpenSearchButton.Location = new System.Drawing.Point(51, 798);
            this.OpenSearchButton.Name = "OpenSearchButton";
            this.OpenSearchButton.Size = new System.Drawing.Size(278, 81);
            this.OpenSearchButton.TabIndex = 4;
            this.OpenSearchButton.Text = "Поиск";
            this.OpenSearchButton.UseVisualStyleBackColor = false;
            this.OpenSearchButton.Click += new System.EventHandler(this.OpenSearchButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton.BackgroundImage")));
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.BackButton.Location = new System.Drawing.Point(51, 997);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(121, 78);
            this.BackButton.TabIndex = 5;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddPanel
            // 
            this.AddPanel.Controls.Add(this.AddSort);
            this.AddPanel.Controls.Add(this.AddQuantityTextBox);
            this.AddPanel.Controls.Add(this.AddShelfDatePicker);
            this.AddPanel.Controls.Add(this.AddStorageTextBox);
            this.AddPanel.Controls.Add(this.AddNameTextBox);
            this.AddPanel.Controls.Add(this.AddButton);
            this.AddPanel.Controls.Add(this.label6);
            this.AddPanel.Controls.Add(this.label5);
            this.AddPanel.Controls.Add(this.label4);
            this.AddPanel.Controls.Add(this.label3);
            this.AddPanel.Controls.Add(this.label2);
            this.AddPanel.Controls.Add(this.label1);
            this.AddPanel.Location = new System.Drawing.Point(458, 399);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(403, 689);
            this.AddPanel.TabIndex = 6;
            // 
            // AddSort
            // 
            this.AddSort.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddSort.Location = new System.Drawing.Point(29, 551);
            this.AddSort.Name = "AddSort";
            this.AddSort.Size = new System.Drawing.Size(354, 35);
            this.AddSort.TabIndex = 12;
            // 
            // AddQuantityTextBox
            // 
            this.AddQuantityTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddQuantityTextBox.Location = new System.Drawing.Point(29, 443);
            this.AddQuantityTextBox.Name = "AddQuantityTextBox";
            this.AddQuantityTextBox.Size = new System.Drawing.Size(354, 35);
            this.AddQuantityTextBox.TabIndex = 11;
            // 
            // AddShelfDatePicker
            // 
            this.AddShelfDatePicker.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddShelfDatePicker.Font = new System.Drawing.Font("Arial Narrow", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddShelfDatePicker.Location = new System.Drawing.Point(29, 235);
            this.AddShelfDatePicker.Name = "AddShelfDatePicker";
            this.AddShelfDatePicker.Size = new System.Drawing.Size(354, 32);
            this.AddShelfDatePicker.TabIndex = 10;
            // 
            // AddStorageTextBox
            // 
            this.AddStorageTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddStorageTextBox.Location = new System.Drawing.Point(25, 343);
            this.AddStorageTextBox.Name = "AddStorageTextBox";
            this.AddStorageTextBox.Size = new System.Drawing.Size(354, 35);
            this.AddStorageTextBox.TabIndex = 9;
            // 
            // AddNameTextBox
            // 
            this.AddNameTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNameTextBox.Location = new System.Drawing.Point(29, 133);
            this.AddNameTextBox.Name = "AddNameTextBox";
            this.AddNameTextBox.Size = new System.Drawing.Size(354, 35);
            this.AddNameTextBox.TabIndex = 7;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.AddButton.Location = new System.Drawing.Point(144, 599);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(121, 78);
            this.AddButton.TabIndex = 6;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(166, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Сорт";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(120, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(86, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Условия хранения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(120, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Срок годности";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(138, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(120, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление";
            // 
            // ChangePanel
            // 
            this.ChangePanel.Controls.Add(this.ChangeCompIDTextBox);
            this.ChangePanel.Controls.Add(this.ChangeSortTextBox);
            this.ChangePanel.Controls.Add(this.ChangeQuantityTextBox);
            this.ChangePanel.Controls.Add(this.ChangeDatePicker);
            this.ChangePanel.Controls.Add(this.ChangeStorageTextBox);
            this.ChangePanel.Controls.Add(this.ChangeNameTextBox);
            this.ChangePanel.Controls.Add(this.ChangeButton);
            this.ChangePanel.Controls.Add(this.label7);
            this.ChangePanel.Controls.Add(this.label8);
            this.ChangePanel.Controls.Add(this.label9);
            this.ChangePanel.Controls.Add(this.label10);
            this.ChangePanel.Controls.Add(this.label11);
            this.ChangePanel.Controls.Add(this.label12);
            this.ChangePanel.Location = new System.Drawing.Point(919, 399);
            this.ChangePanel.Name = "ChangePanel";
            this.ChangePanel.Size = new System.Drawing.Size(403, 689);
            this.ChangePanel.TabIndex = 13;
            // 
            // ChangeCompIDTextBox
            // 
            this.ChangeCompIDTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeCompIDTextBox.Location = new System.Drawing.Point(29, 82);
            this.ChangeCompIDTextBox.Name = "ChangeCompIDTextBox";
            this.ChangeCompIDTextBox.ReadOnly = true;
            this.ChangeCompIDTextBox.Size = new System.Drawing.Size(354, 35);
            this.ChangeCompIDTextBox.TabIndex = 13;
            // 
            // ChangeSortTextBox
            // 
            this.ChangeSortTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeSortTextBox.Location = new System.Drawing.Point(29, 555);
            this.ChangeSortTextBox.Name = "ChangeSortTextBox";
            this.ChangeSortTextBox.Size = new System.Drawing.Size(354, 35);
            this.ChangeSortTextBox.TabIndex = 12;
            // 
            // ChangeQuantityTextBox
            // 
            this.ChangeQuantityTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeQuantityTextBox.Location = new System.Drawing.Point(29, 461);
            this.ChangeQuantityTextBox.Name = "ChangeQuantityTextBox";
            this.ChangeQuantityTextBox.Size = new System.Drawing.Size(354, 35);
            this.ChangeQuantityTextBox.TabIndex = 11;
            // 
            // ChangeDatePicker
            // 
            this.ChangeDatePicker.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeDatePicker.Font = new System.Drawing.Font("Arial Narrow", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeDatePicker.Location = new System.Drawing.Point(29, 258);
            this.ChangeDatePicker.Name = "ChangeDatePicker";
            this.ChangeDatePicker.Size = new System.Drawing.Size(354, 32);
            this.ChangeDatePicker.TabIndex = 10;
            // 
            // ChangeStorageTextBox
            // 
            this.ChangeStorageTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeStorageTextBox.Location = new System.Drawing.Point(29, 362);
            this.ChangeStorageTextBox.Name = "ChangeStorageTextBox";
            this.ChangeStorageTextBox.Size = new System.Drawing.Size(354, 35);
            this.ChangeStorageTextBox.TabIndex = 9;
            // 
            // ChangeNameTextBox
            // 
            this.ChangeNameTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeNameTextBox.Location = new System.Drawing.Point(29, 172);
            this.ChangeNameTextBox.Name = "ChangeNameTextBox";
            this.ChangeNameTextBox.Size = new System.Drawing.Size(354, 35);
            this.ChangeNameTextBox.TabIndex = 7;
            // 
            // ChangeButton
            // 
            this.ChangeButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ChangeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChangeButton.BackgroundImage")));
            this.ChangeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.ChangeButton.Location = new System.Drawing.Point(144, 599);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(121, 78);
            this.ChangeButton.TabIndex = 6;
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(156, 520);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "Сорт";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(121, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 32);
            this.label8.TabIndex = 4;
            this.label8.Text = "Количество";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(92, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(243, 32);
            this.label9.TabIndex = 3;
            this.label9.Text = "Условия хранения";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(108, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 32);
            this.label10.TabIndex = 2;
            this.label10.Text = "Срок годности";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(138, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 32);
            this.label11.TabIndex = 1;
            this.label11.Text = "Название";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(120, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "Изменение";
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.SearchButton);
            this.SearchPanel.Controls.Add(this.SearchTextBox);
            this.SearchPanel.Controls.Add(this.label14);
            this.SearchPanel.Controls.Add(this.SearchComboBox);
            this.SearchPanel.Controls.Add(this.label13);
            this.SearchPanel.Location = new System.Drawing.Point(1364, 617);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(366, 359);
            this.SearchPanel.TabIndex = 14;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.SearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.BackgroundImage")));
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.SearchButton.Location = new System.Drawing.Point(119, 256);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(121, 78);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(24, 190);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(320, 35);
            this.SearchTextBox.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(88, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(221, 32);
            this.label14.TabIndex = 2;
            this.label14.Text = "Введите данные";
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchComboBox.FormattingEnabled = true;
            this.SearchComboBox.Location = new System.Drawing.Point(24, 67);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(320, 35);
            this.SearchComboBox.TabIndex = 1;
            this.SearchComboBox.Text = "Выберите данные";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(139, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 32);
            this.label13.TabIndex = 0;
            this.label13.Text = "Поиск";
            // 
            // ComponentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1761, 1087);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.ChangePanel);
            this.Controls.Add(this.AddPanel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OpenSearchButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.OpenChangeButton);
            this.Controls.Add(this.OpenAddPanel);
            this.Controls.Add(this.ComponentDataGridView);
            this.Name = "ComponentInfoForm";
            this.Text = "Информация о компонентах";
            this.Load += new System.EventHandler(this.ComponentInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComponentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet)).EndInit();
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            this.ChangePanel.ResumeLayout(false);
            this.ChangePanel.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ComponentDataGridView;
        private Flower_databaseDataSet flower_databaseDataSet;
        private System.Windows.Forms.BindingSource componentBindingSource;
        private Flower_databaseDataSetTableAdapters.ComponentTableAdapter componentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomponentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelflifeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storageconditionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sortDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button OpenAddPanel;
        private System.Windows.Forms.Button OpenChangeButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button OpenSearchButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddSort;
        private System.Windows.Forms.TextBox AddQuantityTextBox;
        private System.Windows.Forms.DateTimePicker AddShelfDatePicker;
        private System.Windows.Forms.TextBox AddStorageTextBox;
        private System.Windows.Forms.TextBox AddNameTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel ChangePanel;
        private System.Windows.Forms.TextBox ChangeCompIDTextBox;
        private System.Windows.Forms.TextBox ChangeSortTextBox;
        private System.Windows.Forms.TextBox ChangeQuantityTextBox;
        private System.Windows.Forms.DateTimePicker ChangeDatePicker;
        private System.Windows.Forms.TextBox ChangeStorageTextBox;
        private System.Windows.Forms.TextBox ChangeNameTextBox;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox SearchComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button SearchButton;
    }
}