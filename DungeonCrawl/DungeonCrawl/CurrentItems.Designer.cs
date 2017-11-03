namespace DungeonCrawl
{
    partial class CurrentItems
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
            this.currentItemsListBox = new System.Windows.Forms.ListBox();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.healValueLabel = new System.Windows.Forms.Label();
            this.itemDescriptionLabel = new System.Windows.Forms.Label();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.healValueDescLabel = new System.Windows.Forms.Label();
            this.itemDescriptionDescLabel = new System.Windows.Forms.Label();
            this.itemNameDescLabel = new System.Windows.Forms.Label();
            this.displayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentItemsListBox
            // 
            this.currentItemsListBox.Font = new System.Drawing.Font("Stencil", 12F);
            this.currentItemsListBox.FormattingEnabled = true;
            this.currentItemsListBox.ItemHeight = 19;
            this.currentItemsListBox.Location = new System.Drawing.Point(12, 12);
            this.currentItemsListBox.Name = "currentItemsListBox";
            this.currentItemsListBox.Size = new System.Drawing.Size(214, 213);
            this.currentItemsListBox.TabIndex = 36;
            this.currentItemsListBox.SelectedIndexChanged += new System.EventHandler(this.currentItemsListBox_SelectedIndexChanged);
            // 
            // displayPanel
            // 
            this.displayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayPanel.Controls.Add(this.healValueLabel);
            this.displayPanel.Controls.Add(this.itemDescriptionLabel);
            this.displayPanel.Controls.Add(this.itemNameLabel);
            this.displayPanel.Controls.Add(this.healValueDescLabel);
            this.displayPanel.Controls.Add(this.itemDescriptionDescLabel);
            this.displayPanel.Controls.Add(this.itemNameDescLabel);
            this.displayPanel.Location = new System.Drawing.Point(232, 12);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(353, 212);
            this.displayPanel.TabIndex = 37;
            // 
            // healValueLabel
            // 
            this.healValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.healValueLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healValueLabel.ForeColor = System.Drawing.Color.Crimson;
            this.healValueLabel.Location = new System.Drawing.Point(143, 151);
            this.healValueLabel.Name = "healValueLabel";
            this.healValueLabel.Size = new System.Drawing.Size(197, 22);
            this.healValueLabel.TabIndex = 11;
            this.healValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemDescriptionLabel
            // 
            this.itemDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemDescriptionLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDescriptionLabel.ForeColor = System.Drawing.Color.Crimson;
            this.itemDescriptionLabel.Location = new System.Drawing.Point(143, 49);
            this.itemDescriptionLabel.Name = "itemDescriptionLabel";
            this.itemDescriptionLabel.Size = new System.Drawing.Size(197, 92);
            this.itemDescriptionLabel.TabIndex = 10;
            this.itemDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemNameLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameLabel.ForeColor = System.Drawing.Color.Crimson;
            this.itemNameLabel.Location = new System.Drawing.Point(143, 16);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(197, 23);
            this.itemNameLabel.TabIndex = 9;
            this.itemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // healValueDescLabel
            // 
            this.healValueDescLabel.AutoSize = true;
            this.healValueDescLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healValueDescLabel.ForeColor = System.Drawing.Color.Crimson;
            this.healValueDescLabel.Location = new System.Drawing.Point(8, 154);
            this.healValueDescLabel.Name = "healValueDescLabel";
            this.healValueDescLabel.Size = new System.Drawing.Size(88, 16);
            this.healValueDescLabel.TabIndex = 8;
            this.healValueDescLabel.Text = "Heal Value:";
            // 
            // itemDescriptionDescLabel
            // 
            this.itemDescriptionDescLabel.AutoSize = true;
            this.itemDescriptionDescLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDescriptionDescLabel.ForeColor = System.Drawing.Color.Crimson;
            this.itemDescriptionDescLabel.Location = new System.Drawing.Point(8, 87);
            this.itemDescriptionDescLabel.Name = "itemDescriptionDescLabel";
            this.itemDescriptionDescLabel.Size = new System.Drawing.Size(129, 16);
            this.itemDescriptionDescLabel.TabIndex = 7;
            this.itemDescriptionDescLabel.Text = "Item Description:";
            // 
            // itemNameDescLabel
            // 
            this.itemNameDescLabel.AutoSize = true;
            this.itemNameDescLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameDescLabel.ForeColor = System.Drawing.Color.Crimson;
            this.itemNameDescLabel.Location = new System.Drawing.Point(8, 19);
            this.itemNameDescLabel.Name = "itemNameDescLabel";
            this.itemNameDescLabel.Size = new System.Drawing.Size(81, 16);
            this.itemNameDescLabel.TabIndex = 6;
            this.itemNameDescLabel.Text = "Item Name:";
            // 
            // CurrentItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(597, 243);
            this.Controls.Add(this.displayPanel);
            this.Controls.Add(this.currentItemsListBox);
            this.Name = "CurrentItems";
            this.Text = "CurrentItems";
            this.Load += new System.EventHandler(this.CurrentItems_Load);
            this.displayPanel.ResumeLayout(false);
            this.displayPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox currentItemsListBox;
        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.Label healValueLabel;
        private System.Windows.Forms.Label itemDescriptionLabel;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label healValueDescLabel;
        private System.Windows.Forms.Label itemDescriptionDescLabel;
        private System.Windows.Forms.Label itemNameDescLabel;
    }
}