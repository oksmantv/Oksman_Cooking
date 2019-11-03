namespace Oksman_Cooking
{
    partial class Form1
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.ListBox();
            this.IngredientsBox = new System.Windows.Forms.RichTextBox();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(366, 51);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(85, 35);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Sök";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(29, 375);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(122, 36);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Lägg till Recept";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(115, 78);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(231, 22);
            this.SearchText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sök Recept:";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(172, 375);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(138, 36);
            this.UpdateButton.TabIndex = 9;
            this.UpdateButton.Text = "Uppdatera Recept";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(329, 375);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(122, 36);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Ta Bort Recept";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.FormattingEnabled = true;
            this.SearchBox.ItemHeight = 16;
            this.SearchBox.Location = new System.Drawing.Point(29, 133);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(281, 228);
            this.SearchBox.TabIndex = 11;
            this.SearchBox.SelectedIndexChanged += new System.EventHandler(this.SearchBox_SelectedIndexChanged);
            // 
            // IngredientsBox
            // 
            this.IngredientsBox.Location = new System.Drawing.Point(316, 245);
            this.IngredientsBox.Name = "IngredientsBox";
            this.IngredientsBox.ReadOnly = true;
            this.IngredientsBox.Size = new System.Drawing.Size(198, 116);
            this.IngredientsBox.TabIndex = 14;
            this.IngredientsBox.Text = "";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(316, 133);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.ReadOnly = true;
            this.DescriptionBox.Size = new System.Drawing.Size(198, 106);
            this.DescriptionBox.TabIndex = 15;
            this.DescriptionBox.Text = "";
            // 
            // CategoryBox
            // 
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Location = new System.Drawing.Point(115, 48);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(231, 24);
            this.CategoryBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kategori:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 421);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.IngredientsBox);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SearchButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ListBox SearchBox;
        private System.Windows.Forms.RichTextBox IngredientsBox;
        private System.Windows.Forms.RichTextBox DescriptionBox;
        private System.Windows.Forms.ComboBox CategoryBox;
        private System.Windows.Forms.Label label2;
    }
}

