namespace Oksman_Cooking
{
    partial class UpdateReceipt
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
            this.NewCategories = new System.Windows.Forms.ListBox();
            this.NewIngredients = new System.Windows.Forms.RichTextBox();
            this.NewDescription = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NewTitle = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewCategories
            // 
            this.NewCategories.FormattingEnabled = true;
            this.NewCategories.ItemHeight = 16;
            this.NewCategories.Location = new System.Drawing.Point(11, 354);
            this.NewCategories.Name = "NewCategories";
            this.NewCategories.Size = new System.Drawing.Size(321, 68);
            this.NewCategories.TabIndex = 13;
            // 
            // NewIngredients
            // 
            this.NewIngredients.Location = new System.Drawing.Point(12, 215);
            this.NewIngredients.Name = "NewIngredients";
            this.NewIngredients.Size = new System.Drawing.Size(321, 101);
            this.NewIngredients.TabIndex = 12;
            this.NewIngredients.Text = "";
            // 
            // NewDescription
            // 
            this.NewDescription.Location = new System.Drawing.Point(11, 72);
            this.NewDescription.Name = "NewDescription";
            this.NewDescription.Size = new System.Drawing.Size(321, 101);
            this.NewDescription.TabIndex = 11;
            this.NewDescription.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "New Category:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "New Ingredients:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "New Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "New Title: ";
            // 
            // NewTitle
            // 
            this.NewTitle.Location = new System.Drawing.Point(88, 10);
            this.NewTitle.Name = "NewTitle";
            this.NewTitle.Size = new System.Drawing.Size(225, 22);
            this.NewTitle.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 44);
            this.button1.TabIndex = 15;
            this.button1.Text = "Update Receipt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 44);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // UpdateReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 435);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NewTitle);
            this.Controls.Add(this.NewCategories);
            this.Controls.Add(this.NewIngredients);
            this.Controls.Add(this.NewDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Name = "UpdateReceipt";
            this.Text = "UpdateReceipt";
            this.Load += new System.EventHandler(this.UpdateReceipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox NewCategories;
        private System.Windows.Forms.RichTextBox NewIngredients;
        private System.Windows.Forms.RichTextBox NewDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NewTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}