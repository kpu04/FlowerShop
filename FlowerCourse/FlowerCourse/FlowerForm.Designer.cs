namespace FlowerCourse
{
    partial class FlowerForm
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
            this.FlowersButton = new System.Windows.Forms.Button();
            this.PersonalAcc = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MyOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FlowersButton
            // 
            this.FlowersButton.Location = new System.Drawing.Point(174, 46);
            this.FlowersButton.Name = "FlowersButton";
            this.FlowersButton.Size = new System.Drawing.Size(210, 56);
            this.FlowersButton.TabIndex = 0;
            this.FlowersButton.Text = "Каталог";
            this.FlowersButton.UseVisualStyleBackColor = true;
            this.FlowersButton.Click += new System.EventHandler(this.FlowersButton_Click);
            // 
            // PersonalAcc
            // 
            this.PersonalAcc.Location = new System.Drawing.Point(174, 157);
            this.PersonalAcc.Name = "PersonalAcc";
            this.PersonalAcc.Size = new System.Drawing.Size(210, 52);
            this.PersonalAcc.TabIndex = 1;
            this.PersonalAcc.Text = "Личный кабинет";
            this.PersonalAcc.UseVisualStyleBackColor = true;
            this.PersonalAcc.Click += new System.EventHandler(this.PersonalAcc_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(174, 409);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(210, 47);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MyOrderButton
            // 
            this.MyOrderButton.Location = new System.Drawing.Point(174, 259);
            this.MyOrderButton.Name = "MyOrderButton";
            this.MyOrderButton.Size = new System.Drawing.Size(210, 48);
            this.MyOrderButton.TabIndex = 3;
            this.MyOrderButton.Text = "Мои заказы";
            this.MyOrderButton.UseVisualStyleBackColor = true;
            this.MyOrderButton.Click += new System.EventHandler(this.MyOrderButton_Click);
            // 
            // FlowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 515);
            this.Controls.Add(this.MyOrderButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PersonalAcc);
            this.Controls.Add(this.FlowersButton);
            this.Name = "FlowerForm";
            this.Text = "FlowerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FlowersButton;
        private System.Windows.Forms.Button PersonalAcc;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MyOrderButton;
    }
}