namespace FlowerCourse
{
    partial class MyOrder
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
            this.MyOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.DeleteOrder = new System.Windows.Forms.Button();
            this.MakePar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MyOrderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MyOrderDataGridView
            // 
            this.MyOrderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MyOrderDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MyOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyOrderDataGridView.Location = new System.Drawing.Point(-1, -2);
            this.MyOrderDataGridView.Name = "MyOrderDataGridView";
            this.MyOrderDataGridView.RowHeadersWidth = 82;
            this.MyOrderDataGridView.RowTemplate.Height = 33;
            this.MyOrderDataGridView.Size = new System.Drawing.Size(1746, 506);
            this.MyOrderDataGridView.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(82, 570);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(243, 56);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Вернуться назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DeleteOrder
            // 
            this.DeleteOrder.Location = new System.Drawing.Point(608, 570);
            this.DeleteOrder.Name = "DeleteOrder";
            this.DeleteOrder.Size = new System.Drawing.Size(180, 56);
            this.DeleteOrder.TabIndex = 2;
            this.DeleteOrder.Text = "Удалить заказ";
            this.DeleteOrder.UseVisualStyleBackColor = true;
            this.DeleteOrder.Click += new System.EventHandler(this.DeleteOrder_Click);
            // 
            // MakePar
            // 
            this.MakePar.Location = new System.Drawing.Point(1152, 570);
            this.MakePar.Name = "MakePar";
            this.MakePar.Size = new System.Drawing.Size(197, 56);
            this.MakePar.TabIndex = 3;
            this.MakePar.Text = "Получить чек";
            this.MakePar.UseVisualStyleBackColor = true;
            this.MakePar.Click += new System.EventHandler(this.MakePar_Click);
            // 
            // MyOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1745, 682);
            this.Controls.Add(this.MakePar);
            this.Controls.Add(this.DeleteOrder);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.MyOrderDataGridView);
            this.Name = "MyOrder";
            this.Text = "MyOrder";
            ((System.ComponentModel.ISupportInitialize)(this.MyOrderDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MyOrderDataGridView;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button DeleteOrder;
        private System.Windows.Forms.Button MakePar;
    }
}