namespace FlowerCourse
{
    partial class ComponentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentForm));
            this.ShipmentButton = new System.Windows.Forms.Button();
            this.ProviderButton = new System.Windows.Forms.Button();
            this.ComponentButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ShipmentButton
            // 
            this.ShipmentButton.BackColor = System.Drawing.Color.Plum;
            this.ShipmentButton.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShipmentButton.ForeColor = System.Drawing.Color.White;
            this.ShipmentButton.Location = new System.Drawing.Point(42, 173);
            this.ShipmentButton.Name = "ShipmentButton";
            this.ShipmentButton.Size = new System.Drawing.Size(223, 91);
            this.ShipmentButton.TabIndex = 0;
            this.ShipmentButton.Text = "Поставки";
            this.ShipmentButton.UseVisualStyleBackColor = false;
            this.ShipmentButton.Click += new System.EventHandler(this.ShipmentButton_Click);
            // 
            // ProviderButton
            // 
            this.ProviderButton.BackColor = System.Drawing.Color.Plum;
            this.ProviderButton.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProviderButton.ForeColor = System.Drawing.Color.White;
            this.ProviderButton.Location = new System.Drawing.Point(42, 310);
            this.ProviderButton.Name = "ProviderButton";
            this.ProviderButton.Size = new System.Drawing.Size(223, 91);
            this.ProviderButton.TabIndex = 1;
            this.ProviderButton.Text = "Поставщики";
            this.ProviderButton.UseVisualStyleBackColor = false;
            this.ProviderButton.Click += new System.EventHandler(this.ProviderButton_Click);
            // 
            // ComponentButton
            // 
            this.ComponentButton.BackColor = System.Drawing.Color.Plum;
            this.ComponentButton.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComponentButton.ForeColor = System.Drawing.Color.White;
            this.ComponentButton.Location = new System.Drawing.Point(42, 41);
            this.ComponentButton.Name = "ComponentButton";
            this.ComponentButton.Size = new System.Drawing.Size(223, 91);
            this.ComponentButton.TabIndex = 2;
            this.ComponentButton.Text = "Компоненты";
            this.ComponentButton.UseVisualStyleBackColor = false;
            this.ComponentButton.Click += new System.EventHandler(this.ComponentButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton.BackgroundImage")));
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ForeColor = System.Drawing.Color.Transparent;
            this.BackButton.Location = new System.Drawing.Point(99, 441);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(101, 78);
            this.BackButton.TabIndex = 3;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(303, -16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 565);
            this.panel1.TabIndex = 4;
            // 
            // ComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1103, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ComponentButton);
            this.Controls.Add(this.ProviderButton);
            this.Controls.Add(this.ShipmentButton);
            this.Name = "ComponentForm";
            this.Text = "Меню компонентов";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShipmentButton;
        private System.Windows.Forms.Button ProviderButton;
        private System.Windows.Forms.Button ComponentButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel panel1;
    }
}