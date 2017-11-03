namespace DungeonCrawl
{
    partial class RoomInfo
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
            this.roomListBox = new System.Windows.Forms.ListBox();
            this.roomInfoPanel = new System.Windows.Forms.Panel();
            this.possibleEnemiesTextBox = new System.Windows.Forms.ListBox();
            this.roomDescriptionLabel = new System.Windows.Forms.Label();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.possibleRoomEnemiesDescLabel = new System.Windows.Forms.Label();
            this.roomDescriptionDescLabel = new System.Windows.Forms.Label();
            this.roomNameDescLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roomInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomListBox
            // 
            this.roomListBox.BackColor = System.Drawing.Color.DarkGray;
            this.roomListBox.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomListBox.ForeColor = System.Drawing.Color.Crimson;
            this.roomListBox.FormattingEnabled = true;
            this.roomListBox.ItemHeight = 16;
            this.roomListBox.Location = new System.Drawing.Point(13, 48);
            this.roomListBox.Name = "roomListBox";
            this.roomListBox.Size = new System.Drawing.Size(175, 292);
            this.roomListBox.TabIndex = 0;
            this.roomListBox.SelectedIndexChanged += new System.EventHandler(this.roomListBox_SelectedIndexChanged);
            // 
            // roomInfoPanel
            // 
            this.roomInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomInfoPanel.Controls.Add(this.possibleEnemiesTextBox);
            this.roomInfoPanel.Controls.Add(this.roomDescriptionLabel);
            this.roomInfoPanel.Controls.Add(this.roomNameLabel);
            this.roomInfoPanel.Controls.Add(this.possibleRoomEnemiesDescLabel);
            this.roomInfoPanel.Controls.Add(this.roomDescriptionDescLabel);
            this.roomInfoPanel.Controls.Add(this.roomNameDescLabel);
            this.roomInfoPanel.Location = new System.Drawing.Point(194, 48);
            this.roomInfoPanel.Name = "roomInfoPanel";
            this.roomInfoPanel.Size = new System.Drawing.Size(421, 295);
            this.roomInfoPanel.TabIndex = 1;
            // 
            // possibleEnemiesTextBox
            // 
            this.possibleEnemiesTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.possibleEnemiesTextBox.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.possibleEnemiesTextBox.ForeColor = System.Drawing.Color.Crimson;
            this.possibleEnemiesTextBox.FormattingEnabled = true;
            this.possibleEnemiesTextBox.ItemHeight = 16;
            this.possibleEnemiesTextBox.Location = new System.Drawing.Point(186, 185);
            this.possibleEnemiesTextBox.Name = "possibleEnemiesTextBox";
            this.possibleEnemiesTextBox.Size = new System.Drawing.Size(217, 100);
            this.possibleEnemiesTextBox.TabIndex = 2;
            // 
            // roomDescriptionLabel
            // 
            this.roomDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomDescriptionLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDescriptionLabel.ForeColor = System.Drawing.Color.Crimson;
            this.roomDescriptionLabel.Location = new System.Drawing.Point(186, 44);
            this.roomDescriptionLabel.Name = "roomDescriptionLabel";
            this.roomDescriptionLabel.Size = new System.Drawing.Size(217, 130);
            this.roomDescriptionLabel.TabIndex = 4;
            this.roomDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomNameLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNameLabel.ForeColor = System.Drawing.Color.Crimson;
            this.roomNameLabel.Location = new System.Drawing.Point(186, 13);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(217, 23);
            this.roomNameLabel.TabIndex = 3;
            this.roomNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // possibleRoomEnemiesDescLabel
            // 
            this.possibleRoomEnemiesDescLabel.AutoSize = true;
            this.possibleRoomEnemiesDescLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.possibleRoomEnemiesDescLabel.ForeColor = System.Drawing.Color.Crimson;
            this.possibleRoomEnemiesDescLabel.Location = new System.Drawing.Point(13, 229);
            this.possibleRoomEnemiesDescLabel.Name = "possibleRoomEnemiesDescLabel";
            this.possibleRoomEnemiesDescLabel.Size = new System.Drawing.Size(167, 16);
            this.possibleRoomEnemiesDescLabel.TabIndex = 2;
            this.possibleRoomEnemiesDescLabel.Text = "Possible Room Enemies:";
            // 
            // roomDescriptionDescLabel
            // 
            this.roomDescriptionDescLabel.AutoSize = true;
            this.roomDescriptionDescLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDescriptionDescLabel.ForeColor = System.Drawing.Color.Crimson;
            this.roomDescriptionDescLabel.Location = new System.Drawing.Point(13, 101);
            this.roomDescriptionDescLabel.Name = "roomDescriptionDescLabel";
            this.roomDescriptionDescLabel.Size = new System.Drawing.Size(133, 16);
            this.roomDescriptionDescLabel.TabIndex = 1;
            this.roomDescriptionDescLabel.Text = "Room Description:";
            // 
            // roomNameDescLabel
            // 
            this.roomNameDescLabel.AutoSize = true;
            this.roomNameDescLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNameDescLabel.ForeColor = System.Drawing.Color.Crimson;
            this.roomNameDescLabel.Location = new System.Drawing.Point(13, 16);
            this.roomNameDescLabel.Name = "roomNameDescLabel";
            this.roomNameDescLabel.Size = new System.Drawing.Size(85, 16);
            this.roomNameDescLabel.TabIndex = 0;
            this.roomNameDescLabel.Text = "Room Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 18F);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Information:";
            // 
            // RoomInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(627, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomInfoPanel);
            this.Controls.Add(this.roomListBox);
            this.Name = "RoomInfo";
            this.Text = "RoomInfo";
            this.Load += new System.EventHandler(this.RoomInfo_Load);
            this.roomInfoPanel.ResumeLayout(false);
            this.roomInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox roomListBox;
        private System.Windows.Forms.Panel roomInfoPanel;
        private System.Windows.Forms.ListBox possibleEnemiesTextBox;
        private System.Windows.Forms.Label roomDescriptionLabel;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.Label possibleRoomEnemiesDescLabel;
        private System.Windows.Forms.Label roomDescriptionDescLabel;
        private System.Windows.Forms.Label roomNameDescLabel;
        private System.Windows.Forms.Label label1;
    }
}