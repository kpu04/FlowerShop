namespace FlowerCourse
{
    partial class DepartmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentForm));
            this.DepartmentDataGridView = new System.Windows.Forms.DataGridView();
            this.iddepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flower_databaseDataSet = new FlowerCourse.Flower_databaseDataSet();
            this.departmentTableAdapter = new FlowerCourse.Flower_databaseDataSetTableAdapters.DepartmentTableAdapter();
            this.BackButton = new System.Windows.Forms.Button();
            this.OpenAddPanel = new System.Windows.Forms.Button();
            this.OpenChangePanel = new System.Windows.Forms.Button();
            this.DeleteDepButton = new System.Windows.Forms.Button();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.AddNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangePanel = new System.Windows.Forms.Panel();
            this.ChangeDepButton = new System.Windows.Forms.Button();
            this.ChangeNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DepIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet)).BeginInit();
            this.AddPanel.SuspendLayout();
            this.ChangePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DepartmentDataGridView
            // 
            this.DepartmentDataGridView.AutoGenerateColumns = false;
            this.DepartmentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DepartmentDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DepartmentDataGridView.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.DepartmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddepartmentDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.DepartmentDataGridView.DataSource = this.departmentBindingSource;
            this.DepartmentDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DepartmentDataGridView.Name = "DepartmentDataGridView";
            this.DepartmentDataGridView.RowHeadersWidth = 82;
            this.DepartmentDataGridView.RowTemplate.Height = 33;
            this.DepartmentDataGridView.Size = new System.Drawing.Size(1069, 271);
            this.DepartmentDataGridView.TabIndex = 0;
            // 
            // iddepartmentDataGridViewTextBoxColumn
            // 
            this.iddepartmentDataGridViewTextBoxColumn.DataPropertyName = "id_department";
            this.iddepartmentDataGridViewTextBoxColumn.HeaderText = "id_department";
            this.iddepartmentDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.iddepartmentDataGridViewTextBoxColumn.Name = "iddepartmentDataGridViewTextBoxColumn";
            this.iddepartmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.flower_databaseDataSet;
            // 
            // flower_databaseDataSet
            // 
            this.flower_databaseDataSet.DataSetName = "Flower_databaseDataSet";
            this.flower_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton.BackgroundImage")));
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.BackButton.Location = new System.Drawing.Point(34, 595);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(121, 78);
            this.BackButton.TabIndex = 1;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OpenAddPanel
            // 
            this.OpenAddPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.OpenAddPanel.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenAddPanel.Location = new System.Drawing.Point(21, 298);
            this.OpenAddPanel.Name = "OpenAddPanel";
            this.OpenAddPanel.Size = new System.Drawing.Size(281, 66);
            this.OpenAddPanel.TabIndex = 2;
            this.OpenAddPanel.Text = "Добавить отдел";
            this.OpenAddPanel.UseVisualStyleBackColor = false;
            this.OpenAddPanel.Click += new System.EventHandler(this.OpenAddPanel_Click);
            // 
            // OpenChangePanel
            // 
            this.OpenChangePanel.BackColor = System.Drawing.Color.SkyBlue;
            this.OpenChangePanel.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenChangePanel.Location = new System.Drawing.Point(21, 385);
            this.OpenChangePanel.Name = "OpenChangePanel";
            this.OpenChangePanel.Size = new System.Drawing.Size(281, 73);
            this.OpenChangePanel.TabIndex = 3;
            this.OpenChangePanel.Text = "Изменить информацию";
            this.OpenChangePanel.UseVisualStyleBackColor = false;
            this.OpenChangePanel.Click += new System.EventHandler(this.OpenChangePanel_Click);
            // 
            // DeleteDepButton
            // 
            this.DeleteDepButton.BackColor = System.Drawing.Color.SkyBlue;
            this.DeleteDepButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteDepButton.Location = new System.Drawing.Point(21, 478);
            this.DeleteDepButton.Name = "DeleteDepButton";
            this.DeleteDepButton.Size = new System.Drawing.Size(281, 74);
            this.DeleteDepButton.TabIndex = 4;
            this.DeleteDepButton.Text = "Удалить отдел (выберите строку)";
            this.DeleteDepButton.UseVisualStyleBackColor = false;
            this.DeleteDepButton.Click += new System.EventHandler(this.DeleteDepButton_Click);
            // 
            // AddPanel
            // 
            this.AddPanel.Controls.Add(this.button1);
            this.AddPanel.Controls.Add(this.AddNameTextBox);
            this.AddPanel.Controls.Add(this.label4);
            this.AddPanel.Controls.Add(this.label1);
            this.AddPanel.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPanel.Location = new System.Drawing.Point(355, 297);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(289, 390);
            this.AddPanel.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Location = new System.Drawing.Point(79, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 78);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNameTextBox
            // 
            this.AddNameTextBox.Location = new System.Drawing.Point(25, 190);
            this.AddNameTextBox.Name = "AddNameTextBox";
            this.AddNameTextBox.Size = new System.Drawing.Size(240, 39);
            this.AddNameTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Введите название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить отдел";
            // 
            // ChangePanel
            // 
            this.ChangePanel.Controls.Add(this.ChangeDepButton);
            this.ChangePanel.Controls.Add(this.ChangeNameTextBox);
            this.ChangePanel.Controls.Add(this.label5);
            this.ChangePanel.Controls.Add(this.label2);
            this.ChangePanel.Controls.Add(this.DepIDTextBox);
            this.ChangePanel.Controls.Add(this.label3);
            this.ChangePanel.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePanel.Location = new System.Drawing.Point(687, 297);
            this.ChangePanel.Name = "ChangePanel";
            this.ChangePanel.Size = new System.Drawing.Size(369, 390);
            this.ChangePanel.TabIndex = 6;
            // 
            // ChangeDepButton
            // 
            this.ChangeDepButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChangeDepButton.BackgroundImage")));
            this.ChangeDepButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChangeDepButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeDepButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.ChangeDepButton.Location = new System.Drawing.Point(132, 305);
            this.ChangeDepButton.Name = "ChangeDepButton";
            this.ChangeDepButton.Size = new System.Drawing.Size(121, 78);
            this.ChangeDepButton.TabIndex = 7;
            this.ChangeDepButton.UseVisualStyleBackColor = true;
            this.ChangeDepButton.Click += new System.EventHandler(this.ChangeDepButton_Click);
            // 
            // ChangeNameTextBox
            // 
            this.ChangeNameTextBox.Location = new System.Drawing.Point(83, 249);
            this.ChangeNameTextBox.Name = "ChangeNameTextBox";
            this.ChangeNameTextBox.Size = new System.Drawing.Size(226, 39);
            this.ChangeNameTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Введите название";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(65, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 78);
            this.label2.TabIndex = 0;
            this.label2.Text = "Изменить отдел (выберите строку)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DepIDTextBox
            // 
            this.DepIDTextBox.Location = new System.Drawing.Point(83, 157);
            this.DepIDTextBox.Name = "DepIDTextBox";
            this.DepIDTextBox.ReadOnly = true;
            this.DepIDTextBox.Size = new System.Drawing.Size(227, 39);
            this.DepIDTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Номер отдела";
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1068, 692);
            this.Controls.Add(this.ChangePanel);
            this.Controls.Add(this.AddPanel);
            this.Controls.Add(this.DeleteDepButton);
            this.Controls.Add(this.OpenChangePanel);
            this.Controls.Add(this.OpenAddPanel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DepartmentDataGridView);
            this.Name = "DepartmentForm";
            this.Text = "Меню отделов";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet)).EndInit();
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            this.ChangePanel.ResumeLayout(false);
            this.ChangePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DepartmentDataGridView;
        private Flower_databaseDataSet flower_databaseDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private Flower_databaseDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button OpenAddPanel;
        private System.Windows.Forms.Button OpenChangePanel;
        private System.Windows.Forms.Button DeleteDepButton;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ChangePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AddNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ChangeDepButton;
        private System.Windows.Forms.TextBox ChangeNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DepIDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}