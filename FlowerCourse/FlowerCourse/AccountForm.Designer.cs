namespace FlowerCourse
{
    partial class AccountForm
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
            this.UserDataGridView = new System.Windows.Forms.DataGridView();
            this.iduserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flower_databaseDataSet = new FlowerCourse.Flower_databaseDataSet();
            this.userTableAdapter = new FlowerCourse.Flower_databaseDataSetTableAdapters.UserTableAdapter();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.OpenChangeButton = new System.Windows.Forms.Button();
            this.OpenAddButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddRoleComboBox = new System.Windows.Forms.ComboBox();
            this.AddIDCustTextBox = new System.Windows.Forms.TextBox();
            this.AddIDempl = new System.Windows.Forms.TextBox();
            this.PswdTextBox = new System.Windows.Forms.TextBox();
            this.AddNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangePanel = new System.Windows.Forms.Panel();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.ChangeRoleComboBox = new System.Windows.Forms.ComboBox();
            this.ChangeIDCustTextBox = new System.Windows.Forms.TextBox();
            this.ChangeIDEmplTextBox = new System.Windows.Forms.TextBox();
            this.ChangePswdTextBox = new System.Windows.Forms.TextBox();
            this.ChangeLoginTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet)).BeginInit();
            this.ButtonPanel.SuspendLayout();
            this.AddPanel.SuspendLayout();
            this.ChangePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserDataGridView
            // 
            this.UserDataGridView.AutoGenerateColumns = false;
            this.UserDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iduserDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.idemployeeDataGridViewTextBoxColumn,
            this.idcustomerDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.UserDataGridView.DataSource = this.userBindingSource;
            this.UserDataGridView.Location = new System.Drawing.Point(302, -2);
            this.UserDataGridView.Name = "UserDataGridView";
            this.UserDataGridView.RowHeadersWidth = 82;
            this.UserDataGridView.RowTemplate.Height = 33;
            this.UserDataGridView.Size = new System.Drawing.Size(1317, 370);
            this.UserDataGridView.TabIndex = 0;
            // 
            // iduserDataGridViewTextBoxColumn
            // 
            this.iduserDataGridViewTextBoxColumn.DataPropertyName = "id_user";
            this.iduserDataGridViewTextBoxColumn.HeaderText = "id_user";
            this.iduserDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.iduserDataGridViewTextBoxColumn.Name = "iduserDataGridViewTextBoxColumn";
            this.iduserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // idemployeeDataGridViewTextBoxColumn
            // 
            this.idemployeeDataGridViewTextBoxColumn.DataPropertyName = "id_employee";
            this.idemployeeDataGridViewTextBoxColumn.HeaderText = "id_employee";
            this.idemployeeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idemployeeDataGridViewTextBoxColumn.Name = "idemployeeDataGridViewTextBoxColumn";
            // 
            // idcustomerDataGridViewTextBoxColumn
            // 
            this.idcustomerDataGridViewTextBoxColumn.DataPropertyName = "id_customer";
            this.idcustomerDataGridViewTextBoxColumn.HeaderText = "id_customer";
            this.idcustomerDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idcustomerDataGridViewTextBoxColumn.Name = "idcustomerDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.flower_databaseDataSet;
            // 
            // flower_databaseDataSet
            // 
            this.flower_databaseDataSet.DataSetName = "Flower_databaseDataSet";
            this.flower_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.DeleteButton);
            this.ButtonPanel.Controls.Add(this.OpenChangeButton);
            this.ButtonPanel.Controls.Add(this.OpenAddButton);
            this.ButtonPanel.Location = new System.Drawing.Point(12, -2);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(256, 370);
            this.ButtonPanel.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(14, 264);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(215, 86);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Удалить аккаунт (выберите строку)";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // OpenChangeButton
            // 
            this.OpenChangeButton.Location = new System.Drawing.Point(14, 142);
            this.OpenChangeButton.Name = "OpenChangeButton";
            this.OpenChangeButton.Size = new System.Drawing.Size(215, 68);
            this.OpenChangeButton.TabIndex = 1;
            this.OpenChangeButton.Text = "Изменить аккаунт";
            this.OpenChangeButton.UseVisualStyleBackColor = true;
            this.OpenChangeButton.Click += new System.EventHandler(this.OpenChangeButton_Click);
            // 
            // OpenAddButton
            // 
            this.OpenAddButton.Location = new System.Drawing.Point(14, 30);
            this.OpenAddButton.Name = "OpenAddButton";
            this.OpenAddButton.Size = new System.Drawing.Size(215, 69);
            this.OpenAddButton.TabIndex = 0;
            this.OpenAddButton.Text = "Добавить аккаунт";
            this.OpenAddButton.UseVisualStyleBackColor = true;
            this.OpenAddButton.Click += new System.EventHandler(this.OpenAddButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(1465, 885);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(142, 56);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddPanel
            // 
            this.AddPanel.Controls.Add(this.AddButton);
            this.AddPanel.Controls.Add(this.AddRoleComboBox);
            this.AddPanel.Controls.Add(this.AddIDCustTextBox);
            this.AddPanel.Controls.Add(this.AddIDempl);
            this.AddPanel.Controls.Add(this.PswdTextBox);
            this.AddPanel.Controls.Add(this.AddNameTextBox);
            this.AddPanel.Controls.Add(this.label7);
            this.AddPanel.Controls.Add(this.label6);
            this.AddPanel.Controls.Add(this.label5);
            this.AddPanel.Controls.Add(this.label4);
            this.AddPanel.Controls.Add(this.label3);
            this.AddPanel.Controls.Add(this.label1);
            this.AddPanel.Location = new System.Drawing.Point(302, 396);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(1237, 230);
            this.AddPanel.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(971, 163);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(207, 54);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddRoleComboBox
            // 
            this.AddRoleComboBox.FormattingEnabled = true;
            this.AddRoleComboBox.Items.AddRange(new object[] {
            "клиент",
            "администратор"});
            this.AddRoleComboBox.Location = new System.Drawing.Point(971, 105);
            this.AddRoleComboBox.Name = "AddRoleComboBox";
            this.AddRoleComboBox.Size = new System.Drawing.Size(249, 33);
            this.AddRoleComboBox.TabIndex = 10;
            this.AddRoleComboBox.Text = "Выберите доступ";
            // 
            // AddIDCustTextBox
            // 
            this.AddIDCustTextBox.Location = new System.Drawing.Point(714, 107);
            this.AddIDCustTextBox.Name = "AddIDCustTextBox";
            this.AddIDCustTextBox.Size = new System.Drawing.Size(190, 31);
            this.AddIDCustTextBox.TabIndex = 9;
            // 
            // AddIDempl
            // 
            this.AddIDempl.Location = new System.Drawing.Point(465, 104);
            this.AddIDempl.Name = "AddIDempl";
            this.AddIDempl.Size = new System.Drawing.Size(197, 31);
            this.AddIDempl.TabIndex = 8;
            // 
            // PswdTextBox
            // 
            this.PswdTextBox.Location = new System.Drawing.Point(253, 104);
            this.PswdTextBox.Name = "PswdTextBox";
            this.PswdTextBox.Size = new System.Drawing.Size(152, 31);
            this.PswdTextBox.TabIndex = 7;
            // 
            // AddNameTextBox
            // 
            this.AddNameTextBox.Location = new System.Drawing.Point(23, 105);
            this.AddNameTextBox.Name = "AddNameTextBox";
            this.AddNameTextBox.Size = new System.Drawing.Size(149, 31);
            this.AddNameTextBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(966, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Права доступа";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(709, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Клиент (номер)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Сотрудник (номер)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление аккаунта";
            // 
            // ChangePanel
            // 
            this.ChangePanel.Controls.Add(this.ChangeButton);
            this.ChangePanel.Controls.Add(this.ChangeRoleComboBox);
            this.ChangePanel.Controls.Add(this.ChangeIDCustTextBox);
            this.ChangePanel.Controls.Add(this.ChangeIDEmplTextBox);
            this.ChangePanel.Controls.Add(this.ChangePswdTextBox);
            this.ChangePanel.Controls.Add(this.ChangeLoginTextBox);
            this.ChangePanel.Controls.Add(this.label8);
            this.ChangePanel.Controls.Add(this.label9);
            this.ChangePanel.Controls.Add(this.label10);
            this.ChangePanel.Controls.Add(this.label11);
            this.ChangePanel.Controls.Add(this.label12);
            this.ChangePanel.Controls.Add(this.label2);
            this.ChangePanel.Location = new System.Drawing.Point(302, 655);
            this.ChangePanel.Name = "ChangePanel";
            this.ChangePanel.Size = new System.Drawing.Size(1237, 224);
            this.ChangePanel.TabIndex = 4;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(971, 156);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(207, 58);
            this.ChangeButton.TabIndex = 21;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // ChangeRoleComboBox
            // 
            this.ChangeRoleComboBox.FormattingEnabled = true;
            this.ChangeRoleComboBox.Items.AddRange(new object[] {
            "клиент",
            "администратор"});
            this.ChangeRoleComboBox.Location = new System.Drawing.Point(970, 96);
            this.ChangeRoleComboBox.Name = "ChangeRoleComboBox";
            this.ChangeRoleComboBox.Size = new System.Drawing.Size(249, 33);
            this.ChangeRoleComboBox.TabIndex = 20;
            this.ChangeRoleComboBox.Text = "Выберите доступ";
            // 
            // ChangeIDCustTextBox
            // 
            this.ChangeIDCustTextBox.Location = new System.Drawing.Point(713, 98);
            this.ChangeIDCustTextBox.Name = "ChangeIDCustTextBox";
            this.ChangeIDCustTextBox.Size = new System.Drawing.Size(190, 31);
            this.ChangeIDCustTextBox.TabIndex = 19;
            // 
            // ChangeIDEmplTextBox
            // 
            this.ChangeIDEmplTextBox.Location = new System.Drawing.Point(464, 95);
            this.ChangeIDEmplTextBox.Name = "ChangeIDEmplTextBox";
            this.ChangeIDEmplTextBox.Size = new System.Drawing.Size(197, 31);
            this.ChangeIDEmplTextBox.TabIndex = 18;
            // 
            // ChangePswdTextBox
            // 
            this.ChangePswdTextBox.Location = new System.Drawing.Point(252, 95);
            this.ChangePswdTextBox.Name = "ChangePswdTextBox";
            this.ChangePswdTextBox.Size = new System.Drawing.Size(152, 31);
            this.ChangePswdTextBox.TabIndex = 17;
            // 
            // ChangeLoginTextBox
            // 
            this.ChangeLoginTextBox.Location = new System.Drawing.Point(22, 96);
            this.ChangeLoginTextBox.Name = "ChangeLoginTextBox";
            this.ChangeLoginTextBox.Size = new System.Drawing.Size(149, 31);
            this.ChangeLoginTextBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(965, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Права доступа";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(708, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Клиент (номер)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(459, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "Сотрудник (номер)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(247, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "Пароль";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 25);
            this.label12.TabIndex = 11;
            this.label12.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Изменение аккаунта";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1619, 953);
            this.Controls.Add(this.ChangePanel);
            this.Controls.Add(this.AddPanel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.UserDataGridView);
            this.Name = "AccountForm";
            this.Text = "Информация об аккаунтах";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_databaseDataSet)).EndInit();
            this.ButtonPanel.ResumeLayout(false);
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            this.ChangePanel.ResumeLayout(false);
            this.ChangePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UserDataGridView;
        private Flower_databaseDataSet flower_databaseDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private Flower_databaseDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button OpenChangeButton;
        private System.Windows.Forms.Button OpenAddButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Panel ChangePanel;
        private System.Windows.Forms.TextBox AddIDempl;
        private System.Windows.Forms.TextBox PswdTextBox;
        private System.Windows.Forms.TextBox AddNameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AddRoleComboBox;
        private System.Windows.Forms.TextBox AddIDCustTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.ComboBox ChangeRoleComboBox;
        private System.Windows.Forms.TextBox ChangeIDCustTextBox;
        private System.Windows.Forms.TextBox ChangeIDEmplTextBox;
        private System.Windows.Forms.TextBox ChangePswdTextBox;
        private System.Windows.Forms.TextBox ChangeLoginTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}