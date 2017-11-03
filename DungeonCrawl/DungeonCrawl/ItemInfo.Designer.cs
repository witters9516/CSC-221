namespace DungeonCrawl
{
    partial class ItemInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.roomInfoPanel = new System.Windows.Forms.Panel();
            this.healValueLabel = new System.Windows.Forms.Label();
            this.itemDescriptionLabel = new System.Windows.Forms.Label();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.healValueDescLabel = new System.Windows.Forms.Label();
            this.itemDescriptionDescLabel = new System.Windows.Forms.Label();
            this.itemNameDescLabel = new System.Windows.Forms.Label();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.roomInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Item Information:";
            // 
            // roomInfoPanel
            // 
            this.roomInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomInfoPanel.Controls.Add(this.healValueLabel);
            this.roomInfoPanel.Controls.Add(this.itemDescriptionLabel);
            this.roomInfoPanel.Controls.Add(this.itemNameLabel);
            this.roomInfoPanel.Controls.Add(this.healValueDescLabel);
            this.roomInfoPanel.Controls.Add(this.itemDescriptionDescLabel);
            this.roomInfoPanel.Controls.Add(this.itemNameDescLabel);
            this.roomInfoPanel.Location = new System.Drawing.Point(194, 48);
            this.roomInfoPanel.Name = "roomInfoPanel";
            this.roomInfoPanel.Size = new System.Drawing.Size(395, 180);
            this.roomInfoPanel.TabIndex = 7;
            // 
            // healValueLabel
            // 
            this.healValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.healValueLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healValueLabel.ForeColor = System.Drawing.Color.Crimson;
            this.healValueLabel.Location = new System.Drawing.Point(182, 146);
            this.healValueLabel.Name = "healValueLabel";
            this.healValueLabel.Size = new System.Drawing.Size(197, 22);
            this.healValueLabel.TabIndex = 5;
            this.healValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemDescriptionLabel
            // 
            this.itemDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemDescriptionLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDescriptionLabel.ForeColor = System.Drawing.Color.Crimson;
            this.itemDescriptionLabel.Location = new System.Drawing.Point(182, 44);
            this.itemDescriptionLabel.Name = "itemDescriptionLabel";
            this.itemDescriptionLabel.Size = new System.Drawing.Size(197, 92);
            this.itemDescriptionLabel.TabIndex = 4;
            this.itemDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemNameLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameLabel.ForeColor = System.Drawing.Color.Crimson;
            this.itemNameLabel.Location = new System.Drawing.Point(182, 11);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(197, 23);
            this.itemNameLabel.TabIndex = 3;
            this.itemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // healValueDescLabel
            // 
            this.healValueDescLabel.AutoSize = true;
            this.healValueDescLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healValueDescLabel.ForeColor = System.Drawing.Color.Crimson;
            this.healValueDescLabel.Location = new System.Drawing.Point(13, 151);
            this.healValueDescLabel.Name = "healValueDescLabel";
            this.healValueDescLabel.Size = new System.Drawing.Size(84, 16);
            this.healValueDescLabel.TabIndex = 2;
            this.healValueDescLabel.Text = "Heal Value";
            // 
            // itemDescriptionDescLabel
            // 
            this.itemDescriptionDescLabel.AutoSize = true;
            this.itemDescriptionDescLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDescriptionDescLabel.ForeColor = System.Drawing.Color.Crimson;
            this.itemDescriptionDescLabel.Location = new System.Drawing.Point(3, 82);
            this.itemDescriptionDescLabel.Name = "itemDescriptionDescLabel";
            this.itemDescriptionDescLabel.Size = new System.Drawing.Size(129, 16);
            this.itemDescriptionDescLabel.TabIndex = 1;
            this.itemDescriptionDescLabel.Text = "Item Description:";
            // 
            // itemNameDescLabel
            // 
            this.itemNameDescLabel.AutoSize = true;
            this.itemNameDescLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameDescLabel.ForeColor = System.Drawing.Color.Crimson;
            this.itemNameDescLabel.Location = new System.Drawing.Point(13, 16);
            this.itemNameDescLabel.Name = "itemNameDescLabel";
            this.itemNameDescLabel.Size = new System.Drawing.Size(81, 16);
            this.itemNameDescLabel.TabIndex = 0;
            this.itemNameDescLabel.Text = "Item Name:";
            // 
            // itemListBox
            // 
            this.itemListBox.BackColor = System.Drawing.Color.DarkGray;
            this.itemListBox.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemListBox.ForeColor = System.Drawing.Color.Crimson;
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.ItemHeight = 16;
            this.itemListBox.Location = new System.Drawing.Point(13, 48);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(175, 180);
            this.itemListBox.TabIndex = 6;
            this.itemListBox.SelectedIndexChanged += new System.EventHandler(this.itemListBox_SelectedIndexChanged);
            // 
            // ItemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(597, 240);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomInfoPanel);
            this.Controls.Add(this.itemListBox);
            this.Name = "ItemInfo";
            this.Text = "ItemInfo";
            this.Load += new System.EventHandler(this.ItemInfo_Load);
            this.roomInfoPanel.ResumeLayout(false);
            this.roomInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel roomInfoPanel;
        private System.Windows.Forms.Label healValueLabel;
        private System.Windows.Forms.Label itemDescriptionLabel;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label healValueDescLabel;
        private System.Windows.Forms.Label itemDescriptionDescLabel;
        private System.Windows.Forms.Label itemNameDescLabel;
        private System.Windows.Forms.ListBox itemListBox;
    }
}