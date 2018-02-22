namespace WindowsFormsApplication2
{
    partial class TicketPurchasingGUI
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
            this.TotalPriceButton = new System.Windows.Forms.Button();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.CoustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.NumberOfTicketsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TotalPriceButton
            // 
            this.TotalPriceButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TotalPriceButton.Location = new System.Drawing.Point(96, 208);
            this.TotalPriceButton.Margin = new System.Windows.Forms.Padding(5);
            this.TotalPriceButton.Name = "TotalPriceButton";
            this.TotalPriceButton.Size = new System.Drawing.Size(105, 35);
            this.TotalPriceButton.TabIndex = 0;
            this.TotalPriceButton.Text = "Total Price";
            this.TotalPriceButton.UseVisualStyleBackColor = false;
            this.TotalPriceButton.Click += new System.EventHandler(this.TotalPriceButton_Click);
            // 
            // DetailsButton
            // 
            this.DetailsButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.DetailsButton.Location = new System.Drawing.Point(238, 208);
            this.DetailsButton.Margin = new System.Windows.Forms.Padding(5);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(101, 35);
            this.DetailsButton.TabIndex = 1;
            this.DetailsButton.Text = "Details";
            this.DetailsButton.UseVisualStyleBackColor = false;
            this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
            // 
            // CoustomerNameTextBox
            // 
            this.CoustomerNameTextBox.Location = new System.Drawing.Point(200, 34);
            this.CoustomerNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CoustomerNameTextBox.Name = "CoustomerNameTextBox";
            this.CoustomerNameTextBox.Size = new System.Drawing.Size(210, 26);
            this.CoustomerNameTextBox.TabIndex = 2;
            // 
            // NumberOfTicketsTextBox
            // 
            this.NumberOfTicketsTextBox.Location = new System.Drawing.Point(200, 103);
            this.NumberOfTicketsTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.NumberOfTicketsTextBox.Name = "NumberOfTicketsTextBox";
            this.NumberOfTicketsTextBox.Size = new System.Drawing.Size(210, 26);
            this.NumberOfTicketsTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Coustomer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number Of Ticket";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Per Ticket 10 Taka Only";
            // 
            // TicketPurchasingGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(438, 287);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberOfTicketsTextBox);
            this.Controls.Add(this.CoustomerNameTextBox);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.TotalPriceButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TicketPurchasingGUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Ticket Purchasing System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TotalPriceButton;
        private System.Windows.Forms.Button DetailsButton;
        private System.Windows.Forms.TextBox CoustomerNameTextBox;
        private System.Windows.Forms.TextBox NumberOfTicketsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

