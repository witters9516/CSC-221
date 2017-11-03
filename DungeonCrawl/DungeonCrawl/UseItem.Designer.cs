namespace DungeonCrawl
{
    partial class UseItem
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
            this.exitButton = new System.Windows.Forms.Button();
            this.useItemButton = new System.Windows.Forms.Button();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.healValueLabel = new System.Windows.Forms.Label();
            this.itemDescriptionLabel = new System.Windows.Forms.Label();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.healValueDescLabel = new System.Windows.Forms.Label();
            this.itemDescriptionDescLabel = new System.Windows.Forms.Label();
            this.itemNameDescLabel = new System.Windows.Forms.Label();
            this.currentItemsListBox = new System.Windows.Forms.ListBox();
            this.displayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Crimson;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(12, 189);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(214, 35);
            this.exitButton.TabIndex = 43;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // useItemButton
            // 
            this.useItemButton.BackColor = System.Drawing.Color.Crimson;
            this.useItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.useItemButton.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useItemButton.Location = new System.Drawing.Point(12, 148);
            this.useItemButton.Name = "useItemButton";
            this.useItemButton.Size = new System.Drawing.Size(214, 35);
            this.useItemButton.TabIndex = 42;
            this.useItemButton.Text = "Use Item";
            this.useItemButton.UseVisualStyleBackColor = false;
            this.useItemButton.Click += new System.EventHandler(this.useItemButton_Click);
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
            this.displayPanel.TabIndex = 41;
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
            // currentItemsListBox
            // 
            this.currentItemsListBox.Font = new System.Drawing.Font("Stencil", 12F);
            this.currentItemsListBox.FormattingEnabled = true;
            this.currentItemsListBox.ItemHeight = 19;
            this.currentItemsListBox.Location = new System.Drawing.Point(12, 12);
            this.currentItemsListBox.Name = "currentItemsListBox";
            this.currentItemsListBox.Size = new System.Drawing.Size(214, 118);
            this.currentItemsListBox.TabIndex = 40;
            this.currentItemsListBox.SelectedIndexChanged += new System.EventHandler(this.currentItemsListBox_SelectedIndexChanged);
            // 
            // UseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(594, 234);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.useItemButton);
            this.Controls.Add(this.displayPanel);
            this.Controls.Add(this.currentItemsListBox);
            this.Name = "UseItem";
            this.Text = "UseItem";
            this.Load += new System.EventHandler(this.UseItem_Load);
            this.displayPanel.ResumeLayout(false);
            this.displayPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button useItemButton;
        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.Label healValueLabel;
        private System.Windows.Forms.Label itemDescriptionLabel;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label healValueDescLabel;
        private System.Windows.Forms.Label itemDescriptionDescLabel;
        private System.Windows.Forms.Label itemNameDescLabel;
        private System.Windows.Forms.ListBox currentItemsListBox;
    }
}