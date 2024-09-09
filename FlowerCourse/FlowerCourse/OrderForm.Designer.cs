namespace FlowerCourse
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.OrderDataGridView = new System.Windows.Forms.DataGridView();
            this.idorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataoforderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeofdeliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_composition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.flower_databaseDataSet2 = new FlowerCourse.Flower_databaseDataSet2();
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.flowerdatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flower_databaseDataSet = new FlowerCourse.Flower_databaseDataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowerdatabaseDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new FlowerCourse.Flower_databaseDataSetTableAdapters.OrderTableAdapter();
            this.AddOrderPanel = new System.Windows.Forms.Panel();
            this.AddOrderDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.PositionIDTextBox = new System.Windows.Forms.TextBox();
            this.TimeOfDeliveryTextBox = new System.Windows.Forms.TextBox();
            this.CustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataOfDeliveryCheckBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddOrderLabel = new System.Windows.Forms.Label();
            this.ChangeOrderInfoPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.OrderIDTextBox = new System.Windows.Forms.TextBox();
            this.ChangeOrderDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ChangeOrderInfoButton = new System.Windows.Forms.Button();
            this.PositionIDChange = new System.Windows.Forms.TextBox();
            this.TimeOfDeliveryChange = new System.Windows.Forms.TextBox();
            this.CustomerIDChange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OpenAddOrderButton = new System.Windows.Forms.Button();
            this.OpenChangeOrderButton = new System.Windows.Forms.Button();
            this.DeleteOrderButton = new System.Windows.Forms.Button();
            this.BackToAdminMenuButton = new System.Windows.Forms.Button();
            this.OpenOrderSearchButton = new System.Windows.Forms.Button();
            this.OrderSearchPanel = new System.Windows.Forms.Panel();
            this.OrderSearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SearchComboBox = new System.Windows.Forms.ComboBox();
            this.OrderSearchLabel = new System.Windows.Forms.Label();
            this.orderBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fKCompositionOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compositionTableAdapter = new FlowerCourse.Flower_databaseDataSetTableAdapters.CompositionTableAdapter();
            this.orderTableAdapter1 = new FlowerCourse.Flower_databaseDataSet2TableAdapters.OrderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerdatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerdatabaseDataSetBindingSource1)).BeginInit();
            this.AddOrderPanel.SuspendLayout();
            this.ChangeOrderInfoPanel.SuspendLayout();
            this.OrderSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCompositionOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderDataGridView
            // 
            this.OrderDataGridView.AutoGenerateColumns = false;
            this.OrderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.OrderDataGridView.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idorderDataGridViewTextBoxColumn,
            this.dataoforderDataGridViewTextBoxColumn,
            this.idcustomerDataGridViewTextBoxColumn,
            this.timeofdeliveryDataGridViewTextBoxColumn,
            this.id_composition});
            this.OrderDataGridView.DataSource = this.orderBindingSource3;
            this.OrderDataGridView.Location = new System.Drawing.Point(-1, 0);
            this.OrderDataGridView.Name = "OrderDataGridView";
            this.OrderDataGridView.RowHeadersWidth = 82;
            this.OrderDataGridView.RowTemplate.Height = 33;
            this.OrderDataGridView.Size = new System.Drawing.Size(1092, 333);
            this.OrderDataGridView.TabIndex = 0;
            // 
            // idorderDataGridViewTextBoxColumn
            // 
            this.idorderDataGridViewTextBoxColumn.DataPropertyName = "id_order";
            this.idorderDataGridViewTextBoxColumn.HeaderText = "id_order";
            this.idorderDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idorderDataGridViewTextBoxColumn.Name = "idorderDataGridViewTextBoxColumn";
            this.idorderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataoforderDataGridViewTextBoxColumn
            // 
            this.dataoforderDataGridViewTextBoxColumn.DataPropertyName = "data_of_order";
            this.dataoforderDataGridViewTextBoxColumn.HeaderText = "data_of_order";
            this.dataoforderDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.dataoforderDataGridViewTextBoxColumn.Name = "dataoforderDataGridViewTextBoxColumn";
            // 
            // idcustomerDataGridViewTextBoxColumn
            // 
            this.idcustomerDataGridViewTextBoxColumn.DataPropertyName = "id_customer";
            this.idcustomerDataGridViewTextBoxColumn.HeaderText = "id_customer";
            this.idcustomerDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idcustomerDataGridViewTextBoxColumn.Name = "idcustomerDataGridViewTextBoxColumn";
            // 
            // timeofdeliveryDataGridViewTextBoxColumn
            // 
            this.timeofdeliveryDataGridViewTextBoxColumn.DataPropertyName = "time_of_delivery";
            this.timeofdeliveryDataGridViewTextBoxColumn.HeaderText = "time_of_delivery";
            this.timeofdeliveryDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.timeofdeliveryDataGridViewTextBoxColumn.Name = "timeofdeliveryDataGridViewTextBoxColumn";
            // 
            // id_composition
            // 
            this.id_composition.DataPropertyName = "id_composition";
            this.id_composition.HeaderText = "id_composition";
            this.id_composition.MinimumWidth = 10;
            this.id_composition.Name = "id_composition";
            // 
            // orderBindingSource3
            // 
            this.orderBindingSource3.DataMember = "Order";
            this.orderBindingSource3.DataSource = this.flower_databaseDataSet2;
            // 
            // flower_databaseDataSet2
            // 
            this.flower_databaseDataSet2.DataSetName = "Flower_databaseDataSet2";
            this.flower_databaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource1
            // 
            this.orderBindingSource1.DataMember = "Order";
            this.orderBindingSource1.DataSource = this.flowerdatabaseDataSetBindingSource;
            // 
            // flowerdatabaseDataSetBindingSource
            // 
            this.flowerdatabaseDataSetBindingSource.DataSource = this.flower_databaseDataSet;
            this.flowerdatabaseDataSetBindingSource.Position = 0;
            // 
            // flower_databaseDataSet
            // 
            this.flower_databaseDataSet.DataSetName = "Flower_databaseDataSet";
            this.flower_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.flowerdatabaseDataSetBindingSource;
            // 
            // flowerdatabaseDataSetBindingSource1
            // 
            this.flowerdatabaseDataSetBindingSource1.DataSource = this.flower_databaseDataSet;
            this.flowerdatabaseDataSetBindingSource1.Position = 0;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // AddOrderPanel
            // 
            this.AddOrderPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.AddOrderPanel.Controls.Add(this.AddOrderDatePicker);
            this.AddOrderPanel.Controls.Add(this.AddOrderButton);
            this.AddOrderPanel.Controls.Add(this.PositionIDTextBox);
            this.AddOrderPanel.Controls.Add(this.TimeOfDeliveryTextBox);
            this.AddOrderPanel.Controls.Add(this.CustomerIDTextBox);
            this.AddOrderPanel.Controls.Add(this.label4);
            this.AddOrderPanel.Controls.Add(this.label3);
            this.AddOrderPanel.Controls.Add(this.DataOfDeliveryCheckBox);
            this.AddOrderPanel.Controls.Add(this.label1);
            this.AddOrderPanel.Controls.Add(this.AddOrderLabel);
            this.AddOrderPanel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrderPanel.Location = new System.Drawing.Point(12, 333);
            this.AddOrderPanel.Name = "AddOrderPanel";
            this.AddOrderPanel.Size = new System.Drawing.Size(479, 671);
            this.AddOrderPanel.TabIndex = 2;
            // 
            // AddOrderDatePicker
            // 
            this.AddOrderDatePicker.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrderDatePicker.Location = new System.Drawing.Point(13, 162);
            this.AddOrderDatePicker.Name = "AddOrderDatePicker";
            this.AddOrderDatePicker.Size = new System.Drawing.Size(446, 35);
            this.AddOrderDatePicker.TabIndex = 10;
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.AddOrderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddOrderButton.BackgroundImage")));
            this.AddOrderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddOrderButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.AddOrderButton.Location = new System.Drawing.Point(161, 578);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(121, 78);
            this.AddOrderButton.TabIndex = 9;
            this.AddOrderButton.UseVisualStyleBackColor = false;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // PositionIDTextBox
            // 
            this.PositionIDTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionIDTextBox.Location = new System.Drawing.Point(90, 492);
            this.PositionIDTextBox.Name = "PositionIDTextBox";
            this.PositionIDTextBox.Size = new System.Drawing.Size(297, 35);
            this.PositionIDTextBox.TabIndex = 8;
            // 
            // TimeOfDeliveryTextBox
            // 
            this.TimeOfDeliveryTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeOfDeliveryTextBox.Location = new System.Drawing.Point(90, 386);
            this.TimeOfDeliveryTextBox.Name = "TimeOfDeliveryTextBox";
            this.TimeOfDeliveryTextBox.Size = new System.Drawing.Size(297, 35);
            this.TimeOfDeliveryTextBox.TabIndex = 7;
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerIDTextBox.Location = new System.Drawing.Point(90, 268);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.Size = new System.Drawing.Size(297, 35);
            this.CustomerIDTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(136, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Номер позиции";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(130, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Время доставки";
            // 
            // DataOfDeliveryCheckBox
            // 
            this.DataOfDeliveryCheckBox.AutoSize = true;
            this.DataOfDeliveryCheckBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataOfDeliveryCheckBox.Location = new System.Drawing.Point(136, 124);
            this.DataOfDeliveryCheckBox.Name = "DataOfDeliveryCheckBox";
            this.DataOfDeliveryCheckBox.Size = new System.Drawing.Size(183, 29);
            this.DataOfDeliveryCheckBox.TabIndex = 2;
            this.DataOfDeliveryCheckBox.Text = "Дата доставки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(85, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Идентификатор клиента";
            // 
            // AddOrderLabel
            // 
            this.AddOrderLabel.AutoSize = true;
            this.AddOrderLabel.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrderLabel.Location = new System.Drawing.Point(68, 21);
            this.AddOrderLabel.Name = "AddOrderLabel";
            this.AddOrderLabel.Size = new System.Drawing.Size(354, 32);
            this.AddOrderLabel.TabIndex = 0;
            this.AddOrderLabel.Text = "Меню добавления заказа";
            // 
            // ChangeOrderInfoPanel
            // 
            this.ChangeOrderInfoPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ChangeOrderInfoPanel.Controls.Add(this.label9);
            this.ChangeOrderInfoPanel.Controls.Add(this.OrderIDTextBox);
            this.ChangeOrderInfoPanel.Controls.Add(this.ChangeOrderDatePicker);
            this.ChangeOrderInfoPanel.Controls.Add(this.ChangeOrderInfoButton);
            this.ChangeOrderInfoPanel.Controls.Add(this.PositionIDChange);
            this.ChangeOrderInfoPanel.Controls.Add(this.TimeOfDeliveryChange);
            this.ChangeOrderInfoPanel.Controls.Add(this.CustomerIDChange);
            this.ChangeOrderInfoPanel.Controls.Add(this.label2);
            this.ChangeOrderInfoPanel.Controls.Add(this.label5);
            this.ChangeOrderInfoPanel.Controls.Add(this.label6);
            this.ChangeOrderInfoPanel.Controls.Add(this.label7);
            this.ChangeOrderInfoPanel.Controls.Add(this.label8);
            this.ChangeOrderInfoPanel.Location = new System.Drawing.Point(505, 333);
            this.ChangeOrderInfoPanel.Name = "ChangeOrderInfoPanel";
            this.ChangeOrderInfoPanel.Size = new System.Drawing.Size(497, 671);
            this.ChangeOrderInfoPanel.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(151, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 29);
            this.label9.TabIndex = 13;
            this.label9.Text = "Номер заказа";
            // 
            // OrderIDTextBox
            // 
            this.OrderIDTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderIDTextBox.Location = new System.Drawing.Point(111, 147);
            this.OrderIDTextBox.Name = "OrderIDTextBox";
            this.OrderIDTextBox.ReadOnly = true;
            this.OrderIDTextBox.Size = new System.Drawing.Size(297, 35);
            this.OrderIDTextBox.TabIndex = 12;
            // 
            // ChangeOrderDatePicker
            // 
            this.ChangeOrderDatePicker.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeOrderDatePicker.Location = new System.Drawing.Point(22, 235);
            this.ChangeOrderDatePicker.Name = "ChangeOrderDatePicker";
            this.ChangeOrderDatePicker.Size = new System.Drawing.Size(450, 35);
            this.ChangeOrderDatePicker.TabIndex = 11;
            // 
            // ChangeOrderInfoButton
            // 
            this.ChangeOrderInfoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChangeOrderInfoButton.BackgroundImage")));
            this.ChangeOrderInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChangeOrderInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeOrderInfoButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeOrderInfoButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.ChangeOrderInfoButton.Location = new System.Drawing.Point(204, 578);
            this.ChangeOrderInfoButton.Name = "ChangeOrderInfoButton";
            this.ChangeOrderInfoButton.Size = new System.Drawing.Size(121, 78);
            this.ChangeOrderInfoButton.TabIndex = 9;
            this.ChangeOrderInfoButton.UseVisualStyleBackColor = true;
            this.ChangeOrderInfoButton.Click += new System.EventHandler(this.ChangeOrderInfoButton_Click);
            // 
            // PositionIDChange
            // 
            this.PositionIDChange.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionIDChange.Location = new System.Drawing.Point(111, 516);
            this.PositionIDChange.Name = "PositionIDChange";
            this.PositionIDChange.Size = new System.Drawing.Size(297, 35);
            this.PositionIDChange.TabIndex = 8;
            // 
            // TimeOfDeliveryChange
            // 
            this.TimeOfDeliveryChange.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeOfDeliveryChange.Location = new System.Drawing.Point(111, 428);
            this.TimeOfDeliveryChange.Name = "TimeOfDeliveryChange";
            this.TimeOfDeliveryChange.Size = new System.Drawing.Size(297, 35);
            this.TimeOfDeliveryChange.TabIndex = 7;
            // 
            // CustomerIDChange
            // 
            this.CustomerIDChange.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerIDChange.Location = new System.Drawing.Point(111, 344);
            this.CustomerIDChange.Name = "CustomerIDChange";
            this.CustomerIDChange.Size = new System.Drawing.Size(297, 35);
            this.CustomerIDChange.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(157, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер позиции";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(151, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Время доставки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(157, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Дата доставки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(106, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(302, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Идентификатор клиента";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(439, 83);
            this.label8.TabIndex = 0;
            this.label8.Text = "Меню изменения информации (выберите строку)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OpenAddOrderButton
            // 
            this.OpenAddOrderButton.BackColor = System.Drawing.Color.SkyBlue;
            this.OpenAddOrderButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenAddOrderButton.Location = new System.Drawing.Point(1110, 12);
            this.OpenAddOrderButton.Name = "OpenAddOrderButton";
            this.OpenAddOrderButton.Size = new System.Drawing.Size(288, 46);
            this.OpenAddOrderButton.TabIndex = 6;
            this.OpenAddOrderButton.Text = "Добавить заказ";
            this.OpenAddOrderButton.UseVisualStyleBackColor = false;
            this.OpenAddOrderButton.Click += new System.EventHandler(this.OpenAddOrderButton_Click);
            // 
            // OpenChangeOrderButton
            // 
            this.OpenChangeOrderButton.BackColor = System.Drawing.Color.SkyBlue;
            this.OpenChangeOrderButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenChangeOrderButton.Location = new System.Drawing.Point(1110, 99);
            this.OpenChangeOrderButton.Name = "OpenChangeOrderButton";
            this.OpenChangeOrderButton.Size = new System.Drawing.Size(288, 46);
            this.OpenChangeOrderButton.TabIndex = 8;
            this.OpenChangeOrderButton.Text = "Изменить информацию";
            this.OpenChangeOrderButton.UseVisualStyleBackColor = false;
            this.OpenChangeOrderButton.Click += new System.EventHandler(this.OpenChangeOrderButton_Click);
            // 
            // DeleteOrderButton
            // 
            this.DeleteOrderButton.BackColor = System.Drawing.Color.SkyBlue;
            this.DeleteOrderButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteOrderButton.Location = new System.Drawing.Point(1110, 254);
            this.DeleteOrderButton.Name = "DeleteOrderButton";
            this.DeleteOrderButton.Size = new System.Drawing.Size(288, 73);
            this.DeleteOrderButton.TabIndex = 7;
            this.DeleteOrderButton.Text = "Удалить запись (выберите запись)";
            this.DeleteOrderButton.UseVisualStyleBackColor = false;
            this.DeleteOrderButton.Click += new System.EventHandler(this.DeleteOrderButton_Click);
            // 
            // BackToAdminMenuButton
            // 
            this.BackToAdminMenuButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackToAdminMenuButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackToAdminMenuButton.BackgroundImage")));
            this.BackToAdminMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackToAdminMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToAdminMenuButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.BackToAdminMenuButton.Location = new System.Drawing.Point(1323, 914);
            this.BackToAdminMenuButton.Name = "BackToAdminMenuButton";
            this.BackToAdminMenuButton.Size = new System.Drawing.Size(106, 79);
            this.BackToAdminMenuButton.TabIndex = 9;
            this.BackToAdminMenuButton.UseVisualStyleBackColor = false;
            this.BackToAdminMenuButton.Click += new System.EventHandler(this.BackToAdminMenuButton_Click);
            // 
            // OpenOrderSearchButton
            // 
            this.OpenOrderSearchButton.BackColor = System.Drawing.Color.SkyBlue;
            this.OpenOrderSearchButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenOrderSearchButton.Location = new System.Drawing.Point(1110, 177);
            this.OpenOrderSearchButton.Name = "OpenOrderSearchButton";
            this.OpenOrderSearchButton.Size = new System.Drawing.Size(288, 49);
            this.OpenOrderSearchButton.TabIndex = 10;
            this.OpenOrderSearchButton.Text = "Поиск";
            this.OpenOrderSearchButton.UseVisualStyleBackColor = false;
            this.OpenOrderSearchButton.Click += new System.EventHandler(this.OpenOrderSearchButton_Click);
            // 
            // OrderSearchPanel
            // 
            this.OrderSearchPanel.Controls.Add(this.OrderSearchButton);
            this.OrderSearchPanel.Controls.Add(this.SearchTextBox);
            this.OrderSearchPanel.Controls.Add(this.label11);
            this.OrderSearchPanel.Controls.Add(this.label10);
            this.OrderSearchPanel.Controls.Add(this.SearchComboBox);
            this.OrderSearchPanel.Controls.Add(this.OrderSearchLabel);
            this.OrderSearchPanel.Location = new System.Drawing.Point(1020, 333);
            this.OrderSearchPanel.Name = "OrderSearchPanel";
            this.OrderSearchPanel.Size = new System.Drawing.Size(409, 414);
            this.OrderSearchPanel.TabIndex = 11;
            // 
            // OrderSearchButton
            // 
            this.OrderSearchButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.OrderSearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OrderSearchButton.BackgroundImage")));
            this.OrderSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OrderSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderSearchButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderSearchButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.OrderSearchButton.Location = new System.Drawing.Point(137, 315);
            this.OrderSearchButton.Name = "OrderSearchButton";
            this.OrderSearchButton.Size = new System.Drawing.Size(121, 78);
            this.OrderSearchButton.TabIndex = 5;
            this.OrderSearchButton.UseVisualStyleBackColor = false;
            this.OrderSearchButton.Click += new System.EventHandler(this.OrderSearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(38, 251);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(310, 35);
            this.SearchTextBox.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(33, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(323, 29);
            this.label11.TabIndex = 3;
            this.label11.Text = "Введите нужное значение";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(16, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(377, 29);
            this.label10.TabIndex = 2;
            this.label10.Text = "Выберите столбец для поиска";
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchComboBox.FormattingEnabled = true;
            this.SearchComboBox.Location = new System.Drawing.Point(38, 138);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(310, 35);
            this.SearchComboBox.TabIndex = 1;
            // 
            // OrderSearchLabel
            // 
            this.OrderSearchLabel.AutoSize = true;
            this.OrderSearchLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderSearchLabel.Location = new System.Drawing.Point(102, 23);
            this.OrderSearchLabel.Name = "OrderSearchLabel";
            this.OrderSearchLabel.Size = new System.Drawing.Size(225, 29);
            this.OrderSearchLabel.TabIndex = 0;
            this.OrderSearchLabel.Text = "Поиск по таблице";
            // 
            // orderBindingSource2
            // 
            this.orderBindingSource2.DataMember = "Order";
            this.orderBindingSource2.DataSource = this.flowerdatabaseDataSetBindingSource;
            // 
            // fKCompositionOrderBindingSource
            // 
            this.fKCompositionOrderBindingSource.DataMember = "FK_Composition_Order";
            this.fKCompositionOrderBindingSource.DataSource = this.orderBindingSource1;
            // 
            // compositionTableAdapter
            // 
            this.compositionTableAdapter.ClearBeforeFill = true;
            // 
            // orderTableAdapter1
            // 
            this.orderTableAdapter1.ClearBeforeFill = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1438, 1005);
            this.Controls.Add(this.OrderSearchPanel);
            this.Controls.Add(this.OpenOrderSearchButton);
            this.Controls.Add(this.BackToAdminMenuButton);
            this.Controls.Add(this.OpenChangeOrderButton);
            this.Controls.Add(this.DeleteOrderButton);
            this.Controls.Add(this.OpenAddOrderButton);
            this.Controls.Add(this.ChangeOrderInfoPanel);
            this.Controls.Add(this.AddOrderPanel);
            this.Controls.Add(this.OrderDataGridView);
            this.Name = "OrderForm";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerdatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerdatabaseDataSetBindingSource1)).EndInit();
            this.AddOrderPanel.ResumeLayout(false);
            this.AddOrderPanel.PerformLayout();
            this.ChangeOrderInfoPanel.ResumeLayout(false);
            this.ChangeOrderInfoPanel.PerformLayout();
            this.OrderSearchPanel.ResumeLayout(false);
            this.OrderSearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCompositionOrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OrderDataGridView;
        private System.Windows.Forms.BindingSource flowerdatabaseDataSetBindingSource;
        private Flower_databaseDataSet flower_databaseDataSet;
        private System.Windows.Forms.BindingSource flowerdatabaseDataSetBindingSource1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private Flower_databaseDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.Panel AddOrderPanel;
        private System.Windows.Forms.DateTimePicker AddOrderDatePicker;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.TextBox PositionIDTextBox;
        private System.Windows.Forms.TextBox TimeOfDeliveryTextBox;
        private System.Windows.Forms.TextBox CustomerIDTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DataOfDeliveryCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AddOrderLabel;
        private System.Windows.Forms.Panel ChangeOrderInfoPanel;
        private System.Windows.Forms.TextBox OrderIDTextBox;
        private System.Windows.Forms.DateTimePicker ChangeOrderDatePicker;
        private System.Windows.Forms.Button ChangeOrderInfoButton;
        private System.Windows.Forms.TextBox PositionIDChange;
        private System.Windows.Forms.TextBox TimeOfDeliveryChange;
        private System.Windows.Forms.TextBox CustomerIDChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button OpenAddOrderButton;
        private System.Windows.Forms.Button OpenChangeOrderButton;
        private System.Windows.Forms.Button DeleteOrderButton;
        private System.Windows.Forms.Button BackToAdminMenuButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource orderBindingSource1;
        private System.Windows.Forms.Button OpenOrderSearchButton;
        private System.Windows.Forms.Panel OrderSearchPanel;
        private System.Windows.Forms.Label OrderSearchLabel;
        private System.Windows.Forms.ComboBox SearchComboBox;
        private System.Windows.Forms.BindingSource orderBindingSource2;
        private System.Windows.Forms.Button OrderSearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource fKCompositionOrderBindingSource;
        private Flower_databaseDataSetTableAdapters.CompositionTableAdapter compositionTableAdapter;
        private Flower_databaseDataSet2 flower_databaseDataSet2;
        private System.Windows.Forms.BindingSource orderBindingSource3;
        private Flower_databaseDataSet2TableAdapters.OrderTableAdapter orderTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataoforderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeofdeliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_composition;
    }
}