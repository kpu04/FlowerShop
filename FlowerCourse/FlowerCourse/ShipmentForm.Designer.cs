namespace FlowerCourse
{
    partial class ShipmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipmentForm));
            this.ShipmentDataGridView = new System.Windows.Forms.DataGridView();
            this.idshipmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofshipmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproviderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flower_databaseDataSet = new FlowerCourse.Flower_databaseDataSet();
            this.shipmentTableAdapter = new FlowerCourse.Flower_databaseDataSetTableAdapters.ShipmentTableAdapter();
            this.OpenAddShipment = new System.Windows.Forms.Button();
            this.DeleteShipment = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddIDProvTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet)).BeginInit();
            this.AddPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShipmentDataGridView
            // 
            this.ShipmentDataGridView.AutoGenerateColumns = false;
            this.ShipmentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ShipmentDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ShipmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShipmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idshipmentDataGridViewTextBoxColumn,
            this.dateofshipmentDataGridViewTextBoxColumn,
            this.idproviderDataGridViewTextBoxColumn});
            this.ShipmentDataGridView.DataSource = this.shipmentBindingSource;
            this.ShipmentDataGridView.Location = new System.Drawing.Point(355, -3);
            this.ShipmentDataGridView.Name = "ShipmentDataGridView";
            this.ShipmentDataGridView.RowHeadersWidth = 82;
            this.ShipmentDataGridView.RowTemplate.Height = 33;
            this.ShipmentDataGridView.Size = new System.Drawing.Size(764, 198);
            this.ShipmentDataGridView.TabIndex = 0;
            // 
            // idshipmentDataGridViewTextBoxColumn
            // 
            this.idshipmentDataGridViewTextBoxColumn.DataPropertyName = "id_shipment";
            this.idshipmentDataGridViewTextBoxColumn.HeaderText = "id_shipment";
            this.idshipmentDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idshipmentDataGridViewTextBoxColumn.Name = "idshipmentDataGridViewTextBoxColumn";
            this.idshipmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.idshipmentDataGridViewTextBoxColumn.Width = 173;
            // 
            // dateofshipmentDataGridViewTextBoxColumn
            // 
            this.dateofshipmentDataGridViewTextBoxColumn.DataPropertyName = "date_of_shipment";
            this.dateofshipmentDataGridViewTextBoxColumn.HeaderText = "date_of_shipment";
            this.dateofshipmentDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.dateofshipmentDataGridViewTextBoxColumn.Name = "dateofshipmentDataGridViewTextBoxColumn";
            this.dateofshipmentDataGridViewTextBoxColumn.Width = 228;
            // 
            // idproviderDataGridViewTextBoxColumn
            // 
            this.idproviderDataGridViewTextBoxColumn.DataPropertyName = "id_provider";
            this.idproviderDataGridViewTextBoxColumn.HeaderText = "id_provider";
            this.idproviderDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idproviderDataGridViewTextBoxColumn.Name = "idproviderDataGridViewTextBoxColumn";
            this.idproviderDataGridViewTextBoxColumn.Width = 164;
            // 
            // shipmentBindingSource
            // 
            this.shipmentBindingSource.DataMember = "Shipment";
            this.shipmentBindingSource.DataSource = this.flower_databaseDataSet;
            // 
            // flower_databaseDataSet
            // 
            this.flower_databaseDataSet.DataSetName = "Flower_databaseDataSet";
            this.flower_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shipmentTableAdapter
            // 
            this.shipmentTableAdapter.ClearBeforeFill = true;
            // 
            // OpenAddShipment
            // 
            this.OpenAddShipment.BackColor = System.Drawing.Color.DarkTurquoise;
            this.OpenAddShipment.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenAddShipment.Location = new System.Drawing.Point(32, 217);
            this.OpenAddShipment.Name = "OpenAddShipment";
            this.OpenAddShipment.Size = new System.Drawing.Size(301, 69);
            this.OpenAddShipment.TabIndex = 1;
            this.OpenAddShipment.Text = "Добавить поставку";
            this.OpenAddShipment.UseVisualStyleBackColor = false;
            this.OpenAddShipment.Click += new System.EventHandler(this.OpenAddShipment_Click);
            // 
            // DeleteShipment
            // 
            this.DeleteShipment.BackColor = System.Drawing.Color.DarkTurquoise;
            this.DeleteShipment.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteShipment.Location = new System.Drawing.Point(32, 358);
            this.DeleteShipment.Name = "DeleteShipment";
            this.DeleteShipment.Size = new System.Drawing.Size(301, 71);
            this.DeleteShipment.TabIndex = 2;
            this.DeleteShipment.Text = "Удалить поставку";
            this.DeleteShipment.UseVisualStyleBackColor = false;
            this.DeleteShipment.Click += new System.EventHandler(this.DeleteShipment_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton.BackgroundImage")));
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.BackButton.Location = new System.Drawing.Point(22, 470);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(121, 78);
            this.BackButton.TabIndex = 3;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddPanel
            // 
            this.AddPanel.Controls.Add(this.AddButton);
            this.AddPanel.Controls.Add(this.AddIDProvTextBox);
            this.AddPanel.Controls.Add(this.label3);
            this.AddPanel.Controls.Add(this.label2);
            this.AddPanel.Controls.Add(this.AddDatePicker);
            this.AddPanel.Controls.Add(this.label1);
            this.AddPanel.Location = new System.Drawing.Point(470, 241);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(493, 293);
            this.AddPanel.TabIndex = 4;
            // 
            // AddButton
            // 
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.AddButton.Location = new System.Drawing.Point(361, 202);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(121, 78);
            this.AddButton.TabIndex = 5;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddIDProvTextBox
            // 
            this.AddIDProvTextBox.Location = new System.Drawing.Point(29, 187);
            this.AddIDProvTextBox.Name = "AddIDProvTextBox";
            this.AddIDProvTextBox.Size = new System.Drawing.Size(240, 31);
            this.AddIDProvTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Номер поставщика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите дату поставки";
            // 
            // AddDatePicker
            // 
            this.AddDatePicker.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDatePicker.Location = new System.Drawing.Point(24, 103);
            this.AddDatePicker.Name = "AddDatePicker";
            this.AddDatePicker.Size = new System.Drawing.Size(424, 35);
            this.AddDatePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление поставки";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(61, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 158);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ShipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1118, 560);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddPanel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DeleteShipment);
            this.Controls.Add(this.OpenAddShipment);
            this.Controls.Add(this.ShipmentDataGridView);
            this.Name = "ShipmentForm";
            this.Text = "Поставки";
            this.Load += new System.EventHandler(this.ShipmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet)).EndInit();
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ShipmentDataGridView;
        private Flower_databaseDataSet flower_databaseDataSet;
        private System.Windows.Forms.BindingSource shipmentBindingSource;
        private Flower_databaseDataSetTableAdapters.ShipmentTableAdapter shipmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idshipmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofshipmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproviderDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button OpenAddShipment;
        private System.Windows.Forms.Button DeleteShipment;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AddIDProvTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker AddDatePicker;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}