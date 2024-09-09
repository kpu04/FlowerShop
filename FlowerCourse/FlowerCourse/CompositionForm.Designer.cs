namespace FlowerCourse
{
    partial class CompositionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompositionForm));
            this.CompositionDataGridView = new System.Windows.Forms.DataGridView();
            this.idbouquetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bouquetschemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bouquetsnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.compositionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.flower_databaseDataSet3 = new FlowerCourse.Flower_databaseDataSet3();
            this.compositionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.flower_databaseDataSet1 = new FlowerCourse.Flower_databaseDataSet1();
            this.compositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compositionTableAdapter = new FlowerCourse.Flower_databaseDataSetTableAdapters.CompositionTableAdapter();
            this.compositionTableAdapter1 = new FlowerCourse.Flower_databaseDataSet1TableAdapters.CompositionTableAdapter();
            this.OpenAddPanel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.OpenChangePanel = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.AddDatePicker = new System.Windows.Forms.DateTimePicker();
            this.imagePathTextBox = new System.Windows.Forms.TextBox();
            this.AddSchemeTextBox = new System.Windows.Forms.TextBox();
            this.idCompositionTextBox = new System.Windows.Forms.TextBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.AddPriceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangePanel = new System.Windows.Forms.Panel();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.ChangeCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ChangePriceTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ChangeNameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ChangeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ChangeSchemeTextBox = new System.Windows.Forms.TextBox();
            this.OpenSearchButton = new System.Windows.Forms.Button();
            this.ChangePhotoPanel = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.OpenPhotoButton = new System.Windows.Forms.Button();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SearchWhatComboBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.compositionTableAdapter2 = new FlowerCourse.Flower_databaseDataSet3TableAdapters.CompositionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CompositionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.AddPanel.SuspendLayout();
            this.ChangePanel.SuspendLayout();
            this.ChangePhotoPanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CompositionDataGridView
            // 
            this.CompositionDataGridView.AutoGenerateColumns = false;
            this.CompositionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CompositionDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CompositionDataGridView.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.CompositionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompositionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbouquetDataGridViewTextBoxColumn,
            this.makingdateDataGridViewTextBoxColumn,
            this.bouquetschemeDataGridViewTextBoxColumn,
            this.bouquetsnameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.photo});
            this.CompositionDataGridView.DataSource = this.compositionBindingSource2;
            this.CompositionDataGridView.Location = new System.Drawing.Point(-2, 0);
            this.CompositionDataGridView.Name = "CompositionDataGridView";
            this.CompositionDataGridView.RowHeadersWidth = 82;
            this.CompositionDataGridView.RowTemplate.Height = 33;
            this.CompositionDataGridView.Size = new System.Drawing.Size(2084, 1147);
            this.CompositionDataGridView.TabIndex = 0;
            // 
            // idbouquetDataGridViewTextBoxColumn
            // 
            this.idbouquetDataGridViewTextBoxColumn.DataPropertyName = "id_bouquet";
            this.idbouquetDataGridViewTextBoxColumn.HeaderText = "id_bouquet";
            this.idbouquetDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idbouquetDataGridViewTextBoxColumn.Name = "idbouquetDataGridViewTextBoxColumn";
            this.idbouquetDataGridViewTextBoxColumn.ReadOnly = true;
            this.idbouquetDataGridViewTextBoxColumn.Width = 164;
            // 
            // makingdateDataGridViewTextBoxColumn
            // 
            this.makingdateDataGridViewTextBoxColumn.DataPropertyName = "making_date";
            this.makingdateDataGridViewTextBoxColumn.HeaderText = "making_date";
            this.makingdateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.makingdateDataGridViewTextBoxColumn.Name = "makingdateDataGridViewTextBoxColumn";
            this.makingdateDataGridViewTextBoxColumn.Width = 180;
            // 
            // bouquetschemeDataGridViewTextBoxColumn
            // 
            this.bouquetschemeDataGridViewTextBoxColumn.DataPropertyName = "bouquet_scheme";
            this.bouquetschemeDataGridViewTextBoxColumn.HeaderText = "bouquet_scheme";
            this.bouquetschemeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.bouquetschemeDataGridViewTextBoxColumn.Name = "bouquetschemeDataGridViewTextBoxColumn";
            this.bouquetschemeDataGridViewTextBoxColumn.Width = 222;
            // 
            // bouquetsnameDataGridViewTextBoxColumn
            // 
            this.bouquetsnameDataGridViewTextBoxColumn.DataPropertyName = "bouquet\'s_name";
            this.bouquetsnameDataGridViewTextBoxColumn.HeaderText = "bouquet\'s_name";
            this.bouquetsnameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.bouquetsnameDataGridViewTextBoxColumn.Name = "bouquetsnameDataGridViewTextBoxColumn";
            this.bouquetsnameDataGridViewTextBoxColumn.Width = 215;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 104;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 140;
            // 
            // photo
            // 
            this.photo.DataPropertyName = "photo";
            this.photo.HeaderText = "photo";
            this.photo.MinimumWidth = 10;
            this.photo.Name = "photo";
            this.photo.Width = 72;
            // 
            // compositionBindingSource2
            // 
            this.compositionBindingSource2.DataMember = "Composition";
            this.compositionBindingSource2.DataSource = this.flower_databaseDataSet3;
            // 
            // flower_databaseDataSet3
            // 
            this.flower_databaseDataSet3.DataSetName = "Flower_databaseDataSet3";
            this.flower_databaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compositionBindingSource1
            // 
            this.compositionBindingSource1.DataMember = "Composition";
            this.compositionBindingSource1.DataSource = this.flower_databaseDataSet1;
            // 
            // flower_databaseDataSet1
            // 
            this.flower_databaseDataSet1.DataSetName = "Flower_databaseDataSet1";
            this.flower_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compositionBindingSource
            // 
            this.compositionBindingSource.DataMember = "Composition";
            this.compositionBindingSource.DataSource = this.flower_databaseDataSet1;
            // 
            // compositionTableAdapter
            // 
            this.compositionTableAdapter.ClearBeforeFill = true;
            // 
            // compositionTableAdapter1
            // 
            this.compositionTableAdapter1.ClearBeforeFill = true;
            // 
            // OpenAddPanel
            // 
            this.OpenAddPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.OpenAddPanel.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenAddPanel.Location = new System.Drawing.Point(2182, 38);
            this.OpenAddPanel.Name = "OpenAddPanel";
            this.OpenAddPanel.Size = new System.Drawing.Size(367, 77);
            this.OpenAddPanel.TabIndex = 1;
            this.OpenAddPanel.Text = "Добавить композицию";
            this.OpenAddPanel.UseVisualStyleBackColor = false;
            this.OpenAddPanel.Click += new System.EventHandler(this.OpenAddPanel_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightBlue;
            this.button2.Location = new System.Drawing.Point(13, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 62);
            this.button2.TabIndex = 2;
            this.button2.Text = "Выбор фото";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OpenChangePanel
            // 
            this.OpenChangePanel.BackColor = System.Drawing.Color.SkyBlue;
            this.OpenChangePanel.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenChangePanel.Location = new System.Drawing.Point(2182, 139);
            this.OpenChangePanel.Name = "OpenChangePanel";
            this.OpenChangePanel.Size = new System.Drawing.Size(367, 73);
            this.OpenChangePanel.TabIndex = 3;
            this.OpenChangePanel.Text = "Изменить информацию";
            this.OpenChangePanel.UseVisualStyleBackColor = false;
            this.OpenChangePanel.Click += new System.EventHandler(this.OpenChangePanel_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.button4.Location = new System.Drawing.Point(163, 349);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 75);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton.BackgroundImage")));
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.BackButton.Location = new System.Drawing.Point(2473, 1535);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(114, 72);
            this.BackButton.TabIndex = 5;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddDatePicker
            // 
            this.AddDatePicker.Location = new System.Drawing.Point(28, 87);
            this.AddDatePicker.Name = "AddDatePicker";
            this.AddDatePicker.Size = new System.Drawing.Size(513, 39);
            this.AddDatePicker.TabIndex = 6;
            // 
            // imagePathTextBox
            // 
            this.imagePathTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imagePathTextBox.Location = new System.Drawing.Point(13, 179);
            this.imagePathTextBox.Name = "imagePathTextBox";
            this.imagePathTextBox.Size = new System.Drawing.Size(486, 35);
            this.imagePathTextBox.TabIndex = 7;
            // 
            // AddSchemeTextBox
            // 
            this.AddSchemeTextBox.Location = new System.Drawing.Point(641, 83);
            this.AddSchemeTextBox.Name = "AddSchemeTextBox";
            this.AddSchemeTextBox.Size = new System.Drawing.Size(228, 39);
            this.AddSchemeTextBox.TabIndex = 8;
            // 
            // idCompositionTextBox
            // 
            this.idCompositionTextBox.Location = new System.Drawing.Point(13, 289);
            this.idCompositionTextBox.Name = "idCompositionTextBox";
            this.idCompositionTextBox.Size = new System.Drawing.Size(486, 31);
            this.idCompositionTextBox.TabIndex = 10;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Location = new System.Drawing.Point(366, 14);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(182, 154);
            this.imagePictureBox.TabIndex = 11;
            this.imagePictureBox.TabStop = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.SkyBlue;
            this.DeleteButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(2182, 440);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(367, 65);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Удалить строку";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddPanel
            // 
            this.AddPanel.Controls.Add(this.AddButton);
            this.AddPanel.Controls.Add(this.AddCategoryComboBox);
            this.AddPanel.Controls.Add(this.AddPriceTextBox);
            this.AddPanel.Controls.Add(this.label5);
            this.AddPanel.Controls.Add(this.AddNameTextBox);
            this.AddPanel.Controls.Add(this.label4);
            this.AddPanel.Controls.Add(this.label3);
            this.AddPanel.Controls.Add(this.label2);
            this.AddPanel.Controls.Add(this.label1);
            this.AddPanel.Controls.Add(this.AddDatePicker);
            this.AddPanel.Controls.Add(this.AddSchemeTextBox);
            this.AddPanel.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPanel.Location = new System.Drawing.Point(12, 1153);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(2038, 228);
            this.AddPanel.TabIndex = 13;
            // 
            // AddButton
            // 
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.AddButton.Location = new System.Drawing.Point(1822, 140);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(91, 78);
            this.AddButton.TabIndex = 17;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddCategoryComboBox
            // 
            this.AddCategoryComboBox.FormattingEnabled = true;
            this.AddCategoryComboBox.Items.AddRange(new object[] {
            "Праздник",
            "Свадьба",
            "Юбилей",
            "Отпуск",
            "Весна",
            "Лето"});
            this.AddCategoryComboBox.Location = new System.Drawing.Point(1664, 79);
            this.AddCategoryComboBox.Name = "AddCategoryComboBox";
            this.AddCategoryComboBox.Size = new System.Drawing.Size(328, 40);
            this.AddCategoryComboBox.TabIndex = 16;
            this.AddCategoryComboBox.Text = "Выберите категорию";
            // 
            // AddPriceTextBox
            // 
            this.AddPriceTextBox.Location = new System.Drawing.Point(1359, 80);
            this.AddPriceTextBox.Name = "AddPriceTextBox";
            this.AddPriceTextBox.Size = new System.Drawing.Size(213, 39);
            this.AddPriceTextBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1354, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Цена";
            // 
            // AddNameTextBox
            // 
            this.AddNameTextBox.Location = new System.Drawing.Point(1026, 85);
            this.AddNameTextBox.Name = "AddNameTextBox";
            this.AddNameTextBox.Size = new System.Drawing.Size(214, 39);
            this.AddNameTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1021, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Название букета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(636, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Схема сборки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата сборки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление";
            // 
            // ChangePanel
            // 
            this.ChangePanel.Controls.Add(this.ChangeButton);
            this.ChangePanel.Controls.Add(this.ChangeCategoryComboBox);
            this.ChangePanel.Controls.Add(this.ChangePriceTextBox);
            this.ChangePanel.Controls.Add(this.label8);
            this.ChangePanel.Controls.Add(this.ChangeNameTextBox);
            this.ChangePanel.Controls.Add(this.label9);
            this.ChangePanel.Controls.Add(this.label10);
            this.ChangePanel.Controls.Add(this.label11);
            this.ChangePanel.Controls.Add(this.label12);
            this.ChangePanel.Controls.Add(this.ChangeDatePicker);
            this.ChangePanel.Controls.Add(this.ChangeSchemeTextBox);
            this.ChangePanel.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePanel.Location = new System.Drawing.Point(12, 1387);
            this.ChangePanel.Name = "ChangePanel";
            this.ChangePanel.Size = new System.Drawing.Size(2038, 220);
            this.ChangePanel.TabIndex = 18;
            // 
            // ChangeButton
            // 
            this.ChangeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChangeButton.BackgroundImage")));
            this.ChangeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.ChangeButton.Location = new System.Drawing.Point(1822, 136);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(91, 78);
            this.ChangeButton.TabIndex = 17;
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // ChangeCategoryComboBox
            // 
            this.ChangeCategoryComboBox.FormattingEnabled = true;
            this.ChangeCategoryComboBox.Items.AddRange(new object[] {
            "Праздник",
            "Свадьба",
            "Юбилей",
            "Отпуск",
            "Весна",
            "Лето"});
            this.ChangeCategoryComboBox.Location = new System.Drawing.Point(1640, 83);
            this.ChangeCategoryComboBox.Name = "ChangeCategoryComboBox";
            this.ChangeCategoryComboBox.Size = new System.Drawing.Size(352, 40);
            this.ChangeCategoryComboBox.TabIndex = 16;
            this.ChangeCategoryComboBox.Text = "Выберите категорию";
            // 
            // ChangePriceTextBox
            // 
            this.ChangePriceTextBox.Location = new System.Drawing.Point(1359, 84);
            this.ChangePriceTextBox.Name = "ChangePriceTextBox";
            this.ChangePriceTextBox.Size = new System.Drawing.Size(213, 39);
            this.ChangePriceTextBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1353, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 32);
            this.label8.TabIndex = 12;
            this.label8.Text = "Цена";
            // 
            // ChangeNameTextBox
            // 
            this.ChangeNameTextBox.Location = new System.Drawing.Point(1026, 85);
            this.ChangeNameTextBox.Name = "ChangeNameTextBox";
            this.ChangeNameTextBox.Size = new System.Drawing.Size(214, 39);
            this.ChangeNameTextBox.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1017, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(223, 32);
            this.label9.TabIndex = 10;
            this.label9.Text = "Название букета";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(642, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 32);
            this.label10.TabIndex = 9;
            this.label10.Text = "Схема сборки";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 32);
            this.label11.TabIndex = 7;
            this.label11.Text = "Дата сборки";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(26, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "Изменение";
            // 
            // ChangeDatePicker
            // 
            this.ChangeDatePicker.Location = new System.Drawing.Point(28, 85);
            this.ChangeDatePicker.Name = "ChangeDatePicker";
            this.ChangeDatePicker.Size = new System.Drawing.Size(513, 39);
            this.ChangeDatePicker.TabIndex = 6;
            // 
            // ChangeSchemeTextBox
            // 
            this.ChangeSchemeTextBox.Location = new System.Drawing.Point(641, 85);
            this.ChangeSchemeTextBox.Name = "ChangeSchemeTextBox";
            this.ChangeSchemeTextBox.Size = new System.Drawing.Size(228, 39);
            this.ChangeSchemeTextBox.TabIndex = 8;
            // 
            // OpenSearchButton
            // 
            this.OpenSearchButton.BackColor = System.Drawing.Color.SkyBlue;
            this.OpenSearchButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenSearchButton.Location = new System.Drawing.Point(2182, 237);
            this.OpenSearchButton.Name = "OpenSearchButton";
            this.OpenSearchButton.Size = new System.Drawing.Size(367, 76);
            this.OpenSearchButton.TabIndex = 19;
            this.OpenSearchButton.Text = "Поиск";
            this.OpenSearchButton.UseVisualStyleBackColor = false;
            this.OpenSearchButton.Click += new System.EventHandler(this.OpenSearchButton_Click);
            // 
            // ChangePhotoPanel
            // 
            this.ChangePhotoPanel.Controls.Add(this.label15);
            this.ChangePhotoPanel.Controls.Add(this.label14);
            this.ChangePhotoPanel.Controls.Add(this.label13);
            this.ChangePhotoPanel.Controls.Add(this.button2);
            this.ChangePhotoPanel.Controls.Add(this.button4);
            this.ChangePhotoPanel.Controls.Add(this.imagePathTextBox);
            this.ChangePhotoPanel.Controls.Add(this.idCompositionTextBox);
            this.ChangePhotoPanel.Controls.Add(this.imagePictureBox);
            this.ChangePhotoPanel.Location = new System.Drawing.Point(2088, 1029);
            this.ChangePhotoPanel.Name = "ChangePhotoPanel";
            this.ChangePhotoPanel.Size = new System.Drawing.Size(555, 427);
            this.ChangePhotoPanel.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(8, 252);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(294, 32);
            this.label15.TabIndex = 14;
            this.label15.Text = "Введите номер букета";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(22, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 32);
            this.label14.TabIndex = 13;
            this.label14.Text = "Путь к фото";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(3, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(357, 32);
            this.label13.TabIndex = 12;
            this.label13.Text = "Добавление фотографии";
            // 
            // OpenPhotoButton
            // 
            this.OpenPhotoButton.BackColor = System.Drawing.Color.SkyBlue;
            this.OpenPhotoButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenPhotoButton.Location = new System.Drawing.Point(2182, 340);
            this.OpenPhotoButton.Name = "OpenPhotoButton";
            this.OpenPhotoButton.Size = new System.Drawing.Size(367, 73);
            this.OpenPhotoButton.TabIndex = 21;
            this.OpenPhotoButton.Text = "Изменить фото";
            this.OpenPhotoButton.UseVisualStyleBackColor = false;
            this.OpenPhotoButton.Click += new System.EventHandler(this.OpenPhotoButton_Click);
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.SearchButton);
            this.SearchPanel.Controls.Add(this.SearchTextBox);
            this.SearchPanel.Controls.Add(this.label17);
            this.SearchPanel.Controls.Add(this.SearchWhatComboBox);
            this.SearchPanel.Controls.Add(this.label16);
            this.SearchPanel.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchPanel.Location = new System.Drawing.Point(2112, 553);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(531, 441);
            this.SearchPanel.TabIndex = 22;
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.BackgroundImage")));
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.SearchButton.Location = new System.Drawing.Point(190, 329);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(121, 78);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(27, 231);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(472, 39);
            this.SearchTextBox.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 190);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(414, 32);
            this.label17.TabIndex = 2;
            this.label17.Text = "Введите необходимое значение";
            // 
            // SearchWhatComboBox
            // 
            this.SearchWhatComboBox.FormattingEnabled = true;
            this.SearchWhatComboBox.Location = new System.Drawing.Point(27, 76);
            this.SearchWhatComboBox.Name = "SearchWhatComboBox";
            this.SearchWhatComboBox.Size = new System.Drawing.Size(472, 40);
            this.SearchWhatComboBox.TabIndex = 1;
            this.SearchWhatComboBox.Text = "Выберите столбец для поиска";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(22, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 32);
            this.label16.TabIndex = 0;
            this.label16.Text = "Поиск";
            // 
            // compositionTableAdapter2
            // 
            this.compositionTableAdapter2.ClearBeforeFill = true;
            // 
            // CompositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(2650, 1613);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.OpenPhotoButton);
            this.Controls.Add(this.ChangePhotoPanel);
            this.Controls.Add(this.OpenSearchButton);
            this.Controls.Add(this.ChangePanel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddPanel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OpenChangePanel);
            this.Controls.Add(this.OpenAddPanel);
            this.Controls.Add(this.CompositionDataGridView);
            this.Name = "CompositionForm";
            this.Text = "Информация о композицях";
            this.Load += new System.EventHandler(this.CompositionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CompositionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            this.ChangePanel.ResumeLayout(false);
            this.ChangePanel.PerformLayout();
            this.ChangePhotoPanel.ResumeLayout(false);
            this.ChangePhotoPanel.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CompositionDataGridView;
        private System.Windows.Forms.BindingSource compositionBindingSource;
        private Flower_databaseDataSetTableAdapters.CompositionTableAdapter compositionTableAdapter;
        private Flower_databaseDataSet1 flower_databaseDataSet1;
        private System.Windows.Forms.BindingSource compositionBindingSource1;
        private Flower_databaseDataSet1TableAdapters.CompositionTableAdapter compositionTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbouquetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makingdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bouquetschemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bouquetsnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photo;
        private System.Windows.Forms.Button OpenAddPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button OpenChangePanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DateTimePicker AddDatePicker;
        private System.Windows.Forms.TextBox imagePathTextBox;
        private System.Windows.Forms.TextBox AddSchemeTextBox;
        private System.Windows.Forms.TextBox idCompositionTextBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddPriceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox AddCategoryComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel ChangePanel;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.ComboBox ChangeCategoryComboBox;
        private System.Windows.Forms.TextBox ChangePriceTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ChangeNameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker ChangeDatePicker;
        private System.Windows.Forms.TextBox ChangeSchemeTextBox;
        private System.Windows.Forms.Button OpenSearchButton;
        private System.Windows.Forms.Panel ChangePhotoPanel;
        private System.Windows.Forms.Button OpenPhotoButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox SearchWhatComboBox;
        private Flower_databaseDataSet3 flower_databaseDataSet3;
        private System.Windows.Forms.BindingSource compositionBindingSource2;
        private Flower_databaseDataSet3TableAdapters.CompositionTableAdapter compositionTableAdapter2;
    }
}