namespace FlowerCourse
{
    partial class ProviderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProviderForm));
            this.ProviderDataGridView = new System.Windows.Forms.DataGridView();
            this.idproviderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.townDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idshipmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flower_databaseDataSet = new FlowerCourse.Flower_databaseDataSet();
            this.providerTableAdapter = new FlowerCourse.Flower_databaseDataSetTableAdapters.ProviderTableAdapter();
            this.OpenAddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddShipment = new System.Windows.Forms.TextBox();
            this.AddPhone = new System.Windows.Forms.TextBox();
            this.AddTown = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProviderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet)).BeginInit();
            this.AddPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProviderDataGridView
            // 
            this.ProviderDataGridView.AutoGenerateColumns = false;
            this.ProviderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ProviderDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ProviderDataGridView.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.ProviderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProviderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproviderDataGridViewTextBoxColumn,
            this.townDataGridViewTextBoxColumn,
            this.phnumDataGridViewTextBoxColumn,
            this.idshipmentDataGridViewTextBoxColumn});
            this.ProviderDataGridView.DataSource = this.providerBindingSource;
            this.ProviderDataGridView.Location = new System.Drawing.Point(283, -1);
            this.ProviderDataGridView.Name = "ProviderDataGridView";
            this.ProviderDataGridView.RowHeadersWidth = 82;
            this.ProviderDataGridView.RowTemplate.Height = 33;
            this.ProviderDataGridView.Size = new System.Drawing.Size(913, 251);
            this.ProviderDataGridView.TabIndex = 0;
            // 
            // idproviderDataGridViewTextBoxColumn
            // 
            this.idproviderDataGridViewTextBoxColumn.DataPropertyName = "id_provider";
            this.idproviderDataGridViewTextBoxColumn.HeaderText = "id_provider";
            this.idproviderDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idproviderDataGridViewTextBoxColumn.Name = "idproviderDataGridViewTextBoxColumn";
            this.idproviderDataGridViewTextBoxColumn.ReadOnly = true;
            this.idproviderDataGridViewTextBoxColumn.Width = 164;
            // 
            // townDataGridViewTextBoxColumn
            // 
            this.townDataGridViewTextBoxColumn.DataPropertyName = "town";
            this.townDataGridViewTextBoxColumn.HeaderText = "town";
            this.townDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.townDataGridViewTextBoxColumn.Name = "townDataGridViewTextBoxColumn";
            this.townDataGridViewTextBoxColumn.Width = 102;
            // 
            // phnumDataGridViewTextBoxColumn
            // 
            this.phnumDataGridViewTextBoxColumn.DataPropertyName = "ph_num";
            this.phnumDataGridViewTextBoxColumn.HeaderText = "ph_num";
            this.phnumDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.phnumDataGridViewTextBoxColumn.Name = "phnumDataGridViewTextBoxColumn";
            this.phnumDataGridViewTextBoxColumn.Width = 134;
            // 
            // idshipmentDataGridViewTextBoxColumn
            // 
            this.idshipmentDataGridViewTextBoxColumn.DataPropertyName = "id_shipment";
            this.idshipmentDataGridViewTextBoxColumn.HeaderText = "id_shipment";
            this.idshipmentDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idshipmentDataGridViewTextBoxColumn.Name = "idshipmentDataGridViewTextBoxColumn";
            this.idshipmentDataGridViewTextBoxColumn.Width = 173;
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataMember = "Provider";
            this.providerBindingSource.DataSource = this.flower_databaseDataSet;
            // 
            // flower_databaseDataSet
            // 
            this.flower_databaseDataSet.DataSetName = "Flower_databaseDataSet";
            this.flower_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // providerTableAdapter
            // 
            this.providerTableAdapter.ClearBeforeFill = true;
            // 
            // OpenAddButton
            // 
            this.OpenAddButton.BackColor = System.Drawing.Color.Turquoise;
            this.OpenAddButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenAddButton.Location = new System.Drawing.Point(37, 195);
            this.OpenAddButton.Name = "OpenAddButton";
            this.OpenAddButton.Size = new System.Drawing.Size(210, 85);
            this.OpenAddButton.TabIndex = 1;
            this.OpenAddButton.Text = "Добавить поставщика";
            this.OpenAddButton.UseVisualStyleBackColor = false;
            this.OpenAddButton.Click += new System.EventHandler(this.OpenAddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Turquoise;
            this.DeleteButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(37, 310);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(210, 85);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Удалить поставщика";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton.BackgroundImage")));
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.BackButton.Location = new System.Drawing.Point(73, 424);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(121, 78);
            this.BackButton.TabIndex = 4;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddPanel
            // 
            this.AddPanel.Controls.Add(this.AddButton);
            this.AddPanel.Controls.Add(this.label4);
            this.AddPanel.Controls.Add(this.label3);
            this.AddPanel.Controls.Add(this.label2);
            this.AddPanel.Controls.Add(this.AddShipment);
            this.AddPanel.Controls.Add(this.AddPhone);
            this.AddPanel.Controls.Add(this.AddTown);
            this.AddPanel.Controls.Add(this.label1);
            this.AddPanel.Location = new System.Drawing.Point(283, 256);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(902, 272);
            this.AddPanel.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.AddButton.Location = new System.Drawing.Point(407, 187);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(121, 78);
            this.AddButton.TabIndex = 7;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(672, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Номер поставки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Номер телефона";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Город";
            // 
            // AddShipment
            // 
            this.AddShipment.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddShipment.Location = new System.Drawing.Point(673, 122);
            this.AddShipment.Name = "AddShipment";
            this.AddShipment.Size = new System.Drawing.Size(216, 39);
            this.AddShipment.TabIndex = 3;
            // 
            // AddPhone
            // 
            this.AddPhone.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPhone.Location = new System.Drawing.Point(341, 122);
            this.AddPhone.Name = "AddPhone";
            this.AddPhone.Size = new System.Drawing.Size(228, 39);
            this.AddPhone.TabIndex = 2;
            // 
            // AddTown
            // 
            this.AddTown.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTown.Location = new System.Drawing.Point(30, 122);
            this.AddTown.Name = "AddTown";
            this.AddTown.Size = new System.Drawing.Size(199, 39);
            this.AddTown.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление поставщика";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(37, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 177);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ProviderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1197, 533);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddPanel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.OpenAddButton);
            this.Controls.Add(this.ProviderDataGridView);
            this.Name = "ProviderForm";
            this.Text = "Поставщики";
            this.Load += new System.EventHandler(this.ProviderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProviderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet)).EndInit();
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProviderDataGridView;
        private Flower_databaseDataSet flower_databaseDataSet;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private Flower_databaseDataSetTableAdapters.ProviderTableAdapter providerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproviderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn townDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idshipmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button OpenAddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddShipment;
        private System.Windows.Forms.TextBox AddPhone;
        private System.Windows.Forms.TextBox AddTown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}