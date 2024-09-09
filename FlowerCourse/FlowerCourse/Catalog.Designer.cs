namespace FlowerCourse
{
    partial class Catalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalog));
            this.CatalogDataGridView = new System.Windows.Forms.DataGridView();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.bouquetsnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flower_databaseDataSet1 = new FlowerCourse.Flower_databaseDataSet1();
            this.compositionTableAdapter = new FlowerCourse.Flower_databaseDataSet1TableAdapters.CompositionTableAdapter();
            this.BackButton = new System.Windows.Forms.Button();
            this.SortDownButton = new System.Windows.Forms.Button();
            this.SortUpButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.ApplySearchButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MaxSearchButton = new System.Windows.Forms.TextBox();
            this.MinSearchButton = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ApplyOrder = new System.Windows.Forms.Button();
            this.OrderPanel = new System.Windows.Forms.Panel();
            this.OrderButton = new System.Windows.Forms.Button();
            this.ApplyOrderPanel = new System.Windows.Forms.Panel();
            this.DateOrderPicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.TimeOrderTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.flower_databaseDataSet3 = new FlowerCourse.Flower_databaseDataSet3();
            this.compositionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.compositionTableAdapter1 = new FlowerCourse.Flower_databaseDataSet3TableAdapters.CompositionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CatalogDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.OrderPanel.SuspendLayout();
            this.ApplyOrderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // CatalogDataGridView
            // 
            this.CatalogDataGridView.AutoGenerateColumns = false;
            this.CatalogDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CatalogDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CatalogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatalogDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.photoDataGridViewImageColumn,
            this.bouquetsnameDataGridViewTextBoxColumn,
            this.makingdateDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.CatalogDataGridView.DataSource = this.compositionBindingSource1;
            this.CatalogDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.CatalogDataGridView.Location = new System.Drawing.Point(0, 0);
            this.CatalogDataGridView.Name = "CatalogDataGridView";
            this.CatalogDataGridView.RowHeadersWidth = 82;
            this.CatalogDataGridView.RowTemplate.Height = 33;
            this.CatalogDataGridView.Size = new System.Drawing.Size(1349, 980);
            this.CatalogDataGridView.TabIndex = 0;
            // 
            // photoDataGridViewImageColumn
            // 
            this.photoDataGridViewImageColumn.DataPropertyName = "photo";
            this.photoDataGridViewImageColumn.HeaderText = "photo";
            this.photoDataGridViewImageColumn.MinimumWidth = 10;
            this.photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
            // 
            // bouquetsnameDataGridViewTextBoxColumn
            // 
            this.bouquetsnameDataGridViewTextBoxColumn.DataPropertyName = "bouquet\'s_name";
            this.bouquetsnameDataGridViewTextBoxColumn.HeaderText = "bouquet\'s_name";
            this.bouquetsnameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.bouquetsnameDataGridViewTextBoxColumn.Name = "bouquetsnameDataGridViewTextBoxColumn";
            // 
            // makingdateDataGridViewTextBoxColumn
            // 
            this.makingdateDataGridViewTextBoxColumn.DataPropertyName = "making_date";
            this.makingdateDataGridViewTextBoxColumn.HeaderText = "making_date";
            this.makingdateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.makingdateDataGridViewTextBoxColumn.Name = "makingdateDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // compositionBindingSource
            // 
            this.compositionBindingSource.DataMember = "Composition";
            this.compositionBindingSource.DataSource = this.flower_databaseDataSet1;
            // 
            // flower_databaseDataSet1
            // 
            this.flower_databaseDataSet1.DataSetName = "Flower_databaseDataSet1";
            this.flower_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compositionTableAdapter
            // 
            this.compositionTableAdapter.ClearBeforeFill = true;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(1455, 912);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(380, 56);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Вернуться назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SortDownButton
            // 
            this.SortDownButton.AutoSize = true;
            this.SortDownButton.BackColor = System.Drawing.Color.White;
            this.SortDownButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SortDownButton.BackgroundImage")));
            this.SortDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SortDownButton.Location = new System.Drawing.Point(62, 87);
            this.SortDownButton.Name = "SortDownButton";
            this.SortDownButton.Size = new System.Drawing.Size(120, 69);
            this.SortDownButton.TabIndex = 2;
            this.SortDownButton.UseVisualStyleBackColor = false;
            this.SortDownButton.Click += new System.EventHandler(this.SortDownButton_Click);
            // 
            // SortUpButton
            // 
            this.SortUpButton.BackColor = System.Drawing.Color.White;
            this.SortUpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SortUpButton.BackgroundImage")));
            this.SortUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SortUpButton.Location = new System.Drawing.Point(266, 87);
            this.SortUpButton.Name = "SortUpButton";
            this.SortUpButton.Size = new System.Drawing.Size(120, 69);
            this.SortUpButton.TabIndex = 3;
            this.SortUpButton.UseVisualStyleBackColor = false;
            this.SortUpButton.Click += new System.EventHandler(this.SortUpButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SortDownButton);
            this.panel1.Controls.Add(this.SortUpButton);
            this.panel1.Location = new System.Drawing.Point(1407, 720);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 175);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сортировка по цене";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RefreshButton);
            this.panel2.Controls.Add(this.ApplySearchButton);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.MaxSearchButton);
            this.panel2.Controls.Add(this.MinSearchButton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.CategoryComboBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1407, 331);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 373);
            this.panel2.TabIndex = 5;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(103, 310);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(236, 49);
            this.RefreshButton.TabIndex = 8;
            this.RefreshButton.Text = "Сбросить фильтр";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ApplySearchButton
            // 
            this.ApplySearchButton.Location = new System.Drawing.Point(131, 238);
            this.ApplySearchButton.Name = "ApplySearchButton";
            this.ApplySearchButton.Size = new System.Drawing.Size(171, 37);
            this.ApplySearchButton.TabIndex = 7;
            this.ApplySearchButton.Text = "Поиск";
            this.ApplySearchButton.UseVisualStyleBackColor = true;
            this.ApplySearchButton.Click += new System.EventHandler(this.ApplySearchButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "До";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "От";
            // 
            // MaxSearchButton
            // 
            this.MaxSearchButton.Location = new System.Drawing.Point(272, 178);
            this.MaxSearchButton.Name = "MaxSearchButton";
            this.MaxSearchButton.Size = new System.Drawing.Size(131, 31);
            this.MaxSearchButton.TabIndex = 4;
            // 
            // MinSearchButton
            // 
            this.MinSearchButton.Location = new System.Drawing.Point(75, 178);
            this.MinSearchButton.Name = "MinSearchButton";
            this.MinSearchButton.Size = new System.Drawing.Size(131, 31);
            this.MinSearchButton.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Поиск по цене";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "Праздник",
            "Свадьба",
            "Юбилей",
            "День Рождения",
            "Отпуск",
            "Весна",
            "Лето"});
            this.CategoryComboBox.Location = new System.Drawing.Point(77, 71);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(309, 33);
            this.CategoryComboBox.TabIndex = 1;
            this.CategoryComboBox.Text = "Выберите категорию";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Поиск по категории";
            // 
            // ApplyOrder
            // 
            this.ApplyOrder.Location = new System.Drawing.Point(9, 141);
            this.ApplyOrder.Name = "ApplyOrder";
            this.ApplyOrder.Size = new System.Drawing.Size(416, 76);
            this.ApplyOrder.TabIndex = 6;
            this.ApplyOrder.Text = "Подтвердить заказ (выберите позицию)";
            this.ApplyOrder.UseVisualStyleBackColor = true;
            this.ApplyOrder.Click += new System.EventHandler(this.ApplyOrder_Click);
            // 
            // OrderPanel
            // 
            this.OrderPanel.Controls.Add(this.OrderButton);
            this.OrderPanel.Controls.Add(this.ApplyOrderPanel);
            this.OrderPanel.Location = new System.Drawing.Point(1407, 1);
            this.OrderPanel.Name = "OrderPanel";
            this.OrderPanel.Size = new System.Drawing.Size(465, 317);
            this.OrderPanel.TabIndex = 7;
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(19, 11);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(433, 67);
            this.OrderButton.TabIndex = 8;
            this.OrderButton.Text = "Оформить заказ";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // ApplyOrderPanel
            // 
            this.ApplyOrderPanel.Controls.Add(this.DateOrderPicker);
            this.ApplyOrderPanel.Controls.Add(this.label7);
            this.ApplyOrderPanel.Controls.Add(this.ApplyOrder);
            this.ApplyOrderPanel.Controls.Add(this.TimeOrderTextBox);
            this.ApplyOrderPanel.Controls.Add(this.label6);
            this.ApplyOrderPanel.Location = new System.Drawing.Point(19, 94);
            this.ApplyOrderPanel.Name = "ApplyOrderPanel";
            this.ApplyOrderPanel.Size = new System.Drawing.Size(433, 220);
            this.ApplyOrderPanel.TabIndex = 7;
            // 
            // DateOrderPicker
            // 
            this.DateOrderPicker.Location = new System.Drawing.Point(20, 87);
            this.DateOrderPicker.Name = "DateOrderPicker";
            this.DateOrderPicker.Size = new System.Drawing.Size(381, 31);
            this.DateOrderPicker.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Укажите дату";
            // 
            // TimeOrderTextBox
            // 
            this.TimeOrderTextBox.Location = new System.Drawing.Point(202, 11);
            this.TimeOrderTextBox.Name = "TimeOrderTextBox";
            this.TimeOrderTextBox.Size = new System.Drawing.Size(197, 31);
            this.TimeOrderTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Укажите время";
            // 
            // flower_databaseDataSet3
            // 
            this.flower_databaseDataSet3.DataSetName = "Flower_databaseDataSet3";
            this.flower_databaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compositionBindingSource1
            // 
            this.compositionBindingSource1.DataMember = "Composition";
            this.compositionBindingSource1.DataSource = this.flower_databaseDataSet3;
            // 
            // compositionTableAdapter1
            // 
            this.compositionTableAdapter1.ClearBeforeFill = true;
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1896, 980);
            this.Controls.Add(this.OrderPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CatalogDataGridView);
            this.Name = "Catalog";
            this.Text = "Catalog";
            this.Load += new System.EventHandler(this.Catalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CatalogDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.OrderPanel.ResumeLayout(false);
            this.ApplyOrderPanel.ResumeLayout(false);
            this.ApplyOrderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CatalogDataGridView;
        private Flower_databaseDataSet1 flower_databaseDataSet1;
        private System.Windows.Forms.BindingSource compositionBindingSource;
        private Flower_databaseDataSet1TableAdapters.CompositionTableAdapter compositionTableAdapter;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bouquetsnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makingdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SortDownButton;
        private System.Windows.Forms.Button SortUpButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button ApplySearchButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MaxSearchButton;
        private System.Windows.Forms.TextBox MinSearchButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ApplyOrder;
        private System.Windows.Forms.Panel OrderPanel;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Panel ApplyOrderPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TimeOrderTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DateOrderPicker;
        private Flower_databaseDataSet3 flower_databaseDataSet3;
        private System.Windows.Forms.BindingSource compositionBindingSource1;
        private Flower_databaseDataSet3TableAdapters.CompositionTableAdapter compositionTableAdapter1;
    }
}