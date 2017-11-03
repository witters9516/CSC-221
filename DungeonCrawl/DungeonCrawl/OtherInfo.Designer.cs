namespace DungeonCrawl
{
    partial class OtherInfo
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
            this.roomInformationButton = new System.Windows.Forms.Button();
            this.enemyInformation = new System.Windows.Forms.Button();
            this.itemInformationButton = new System.Windows.Forms.Button();
            this.treasureInformationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Other Available Information:";
            // 
            // roomInformationButton
            // 
            this.roomInformationButton.BackColor = System.Drawing.Color.Crimson;
            this.roomInformationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomInformationButton.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomInformationButton.Location = new System.Drawing.Point(65, 51);
            this.roomInformationButton.Name = "roomInformationButton";
            this.roomInformationButton.Size = new System.Drawing.Size(222, 37);
            this.roomInformationButton.TabIndex = 1;
            this.roomInformationButton.Text = "Room Information";
            this.roomInformationButton.UseVisualStyleBackColor = false;
            this.roomInformationButton.Click += new System.EventHandler(this.roomInformationButton_Click);
            // 
            // enemyInformation
            // 
            this.enemyInformation.BackColor = System.Drawing.Color.Crimson;
            this.enemyInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enemyInformation.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyInformation.Location = new System.Drawing.Point(65, 105);
            this.enemyInformation.Name = "enemyInformation";
            this.enemyInformation.Size = new System.Drawing.Size(222, 37);
            this.enemyInformation.TabIndex = 2;
            this.enemyInformation.Text = "Enemy Information";
            this.enemyInformation.UseVisualStyleBackColor = false;
            this.enemyInformation.Click += new System.EventHandler(this.enemyInformation_Click);
            // 
            // itemInformationButton
            // 
            this.itemInformationButton.BackColor = System.Drawing.Color.Crimson;
            this.itemInformationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemInformationButton.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemInformationButton.Location = new System.Drawing.Point(65, 160);
            this.itemInformationButton.Name = "itemInformationButton";
            this.itemInformationButton.Size = new System.Drawing.Size(222, 37);
            this.itemInformationButton.TabIndex = 3;
            this.itemInformationButton.Text = "Item Information";
            this.itemInformationButton.UseVisualStyleBackColor = false;
            this.itemInformationButton.Click += new System.EventHandler(this.itemInformationButton_Click);
            // 
            // treasureInformationButton
            // 
            this.treasureInformationButton.BackColor = System.Drawing.Color.Crimson;
            this.treasureInformationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.treasureInformationButton.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treasureInformationButton.Location = new System.Drawing.Point(65, 215);
            this.treasureInformationButton.Name = "treasureInformationButton";
            this.treasureInformationButton.Size = new System.Drawing.Size(222, 61);
            this.treasureInformationButton.TabIndex = 4;
            this.treasureInformationButton.Text = "Treasure Information";
            this.treasureInformationButton.UseVisualStyleBackColor = false;
            this.treasureInformationButton.Click += new System.EventHandler(this.treasureInformationButton_Click);
            // 
            // OtherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(363, 289);
            this.Controls.Add(this.treasureInformationButton);
            this.Controls.Add(this.itemInformationButton);
            this.Controls.Add(this.enemyInformation);
            this.Controls.Add(this.roomInformationButton);
            this.Controls.Add(this.label1);
            this.Name = "OtherInfo";
            this.Text = "OtherInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button roomInformationButton;
        private System.Windows.Forms.Button enemyInformation;
        private System.Windows.Forms.Button itemInformationButton;
        private System.Windows.Forms.Button treasureInformationButton;
    }
}