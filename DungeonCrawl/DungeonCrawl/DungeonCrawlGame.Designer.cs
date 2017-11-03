namespace DungeonCrawl
{
    partial class DungeonCrawlGame
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
            this.battleLogPanel = new System.Windows.Forms.Panel();
            this.battleLogPanelDescLabel = new System.Windows.Forms.Label();
            this.mapDisplayPanel = new System.Windows.Forms.Panel();
            this.mapPanelDescLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.mapLabel = new System.Windows.Forms.Label();
            this.currentRoomLabel = new System.Windows.Forms.Label();
            this.currentRoomDescLabel = new System.Windows.Forms.Label();
            this.southButton = new System.Windows.Forms.Button();
            this.northButton = new System.Windows.Forms.Button();
            this.room1PictureBox = new System.Windows.Forms.PictureBox();
            this.room2PictureBox = new System.Windows.Forms.PictureBox();
            this.room3PictureBox = new System.Windows.Forms.PictureBox();
            this.room4PictureBox = new System.Windows.Forms.PictureBox();
            this.room5PictureBox = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.itemButton = new System.Windows.Forms.Button();
            this.attackButton = new System.Windows.Forms.Button();
            this.enemyListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.playerInfoPanel = new System.Windows.Forms.Panel();
            this.pHPLabel = new System.Windows.Forms.Label();
            this.pNameLabel = new System.Windows.Forms.Label();
            this.pHPDescLabel = new System.Windows.Forms.Label();
            this.pNameDescLabel = new System.Windows.Forms.Label();
            this.playerInfoPanelDescLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.instructionsButton = new System.Windows.Forms.Button();
            this.displayKeyItemsButton = new System.Windows.Forms.Button();
            this.displayItemsButton = new System.Windows.Forms.Button();
            this.battleLogRichTextBox = new System.Windows.Forms.RichTextBox();
            this.battleLogPanel.SuspendLayout();
            this.mapDisplayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.room1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room4PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room5PictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.playerInfoPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // battleLogPanel
            // 
            this.battleLogPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.battleLogPanel.Controls.Add(this.battleLogPanelDescLabel);
            this.battleLogPanel.Controls.Add(this.battleLogRichTextBox);
            this.battleLogPanel.Location = new System.Drawing.Point(13, 13);
            this.battleLogPanel.Name = "battleLogPanel";
            this.battleLogPanel.Size = new System.Drawing.Size(448, 303);
            this.battleLogPanel.TabIndex = 0;
            // 
            // battleLogPanelDescLabel
            // 
            this.battleLogPanelDescLabel.AutoSize = true;
            this.battleLogPanelDescLabel.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battleLogPanelDescLabel.Location = new System.Drawing.Point(3, 12);
            this.battleLogPanelDescLabel.Name = "battleLogPanelDescLabel";
            this.battleLogPanelDescLabel.Size = new System.Drawing.Size(123, 22);
            this.battleLogPanelDescLabel.TabIndex = 33;
            this.battleLogPanelDescLabel.Text = "Battle Log:";
            // 
            // mapDisplayPanel
            // 
            this.mapDisplayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mapDisplayPanel.Controls.Add(this.mapPanelDescLabel);
            this.mapDisplayPanel.Controls.Add(this.searchButton);
            this.mapDisplayPanel.Controls.Add(this.mapLabel);
            this.mapDisplayPanel.Controls.Add(this.currentRoomLabel);
            this.mapDisplayPanel.Controls.Add(this.currentRoomDescLabel);
            this.mapDisplayPanel.Controls.Add(this.southButton);
            this.mapDisplayPanel.Controls.Add(this.northButton);
            this.mapDisplayPanel.Controls.Add(this.room1PictureBox);
            this.mapDisplayPanel.Controls.Add(this.room2PictureBox);
            this.mapDisplayPanel.Controls.Add(this.room3PictureBox);
            this.mapDisplayPanel.Controls.Add(this.room4PictureBox);
            this.mapDisplayPanel.Controls.Add(this.room5PictureBox);
            this.mapDisplayPanel.Location = new System.Drawing.Point(467, 13);
            this.mapDisplayPanel.Name = "mapDisplayPanel";
            this.mapDisplayPanel.Size = new System.Drawing.Size(270, 303);
            this.mapDisplayPanel.TabIndex = 1;
            // 
            // mapPanelDescLabel
            // 
            this.mapPanelDescLabel.AutoSize = true;
            this.mapPanelDescLabel.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapPanelDescLabel.Location = new System.Drawing.Point(10, 12);
            this.mapPanelDescLabel.Name = "mapPanelDescLabel";
            this.mapPanelDescLabel.Size = new System.Drawing.Size(188, 22);
            this.mapPanelDescLabel.TabIndex = 32;
            this.mapPanelDescLabel.Text = "Map Information:";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(106, 190);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(106, 34);
            this.searchButton.TabIndex = 37;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // mapLabel
            // 
            this.mapLabel.AutoSize = true;
            this.mapLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapLabel.Location = new System.Drawing.Point(11, 43);
            this.mapLabel.Name = "mapLabel";
            this.mapLabel.Size = new System.Drawing.Size(38, 16);
            this.mapLabel.TabIndex = 31;
            this.mapLabel.Text = "Map:";
            // 
            // currentRoomLabel
            // 
            this.currentRoomLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentRoomLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentRoomLabel.Location = new System.Drawing.Point(91, 73);
            this.currentRoomLabel.Name = "currentRoomLabel";
            this.currentRoomLabel.Size = new System.Drawing.Size(139, 21);
            this.currentRoomLabel.TabIndex = 30;
            this.currentRoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentRoomDescLabel
            // 
            this.currentRoomDescLabel.AutoSize = true;
            this.currentRoomDescLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentRoomDescLabel.Location = new System.Drawing.Point(88, 48);
            this.currentRoomDescLabel.Name = "currentRoomDescLabel";
            this.currentRoomDescLabel.Size = new System.Drawing.Size(110, 16);
            this.currentRoomDescLabel.TabIndex = 29;
            this.currentRoomDescLabel.Text = "Current Room:";
            // 
            // southButton
            // 
            this.southButton.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.southButton.Location = new System.Drawing.Point(106, 150);
            this.southButton.Name = "southButton";
            this.southButton.Size = new System.Drawing.Size(110, 34);
            this.southButton.TabIndex = 28;
            this.southButton.Text = "South";
            this.southButton.UseVisualStyleBackColor = true;
            this.southButton.Click += new System.EventHandler(this.southButton_Click);
            // 
            // northButton
            // 
            this.northButton.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.northButton.Location = new System.Drawing.Point(106, 110);
            this.northButton.Name = "northButton";
            this.northButton.Size = new System.Drawing.Size(110, 34);
            this.northButton.TabIndex = 27;
            this.northButton.Text = "North";
            this.northButton.UseVisualStyleBackColor = true;
            this.northButton.Click += new System.EventHandler(this.northButton_Click);
            // 
            // room1PictureBox
            // 
            this.room1PictureBox.BackColor = System.Drawing.Color.Crimson;
            this.room1PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.room1PictureBox.Location = new System.Drawing.Point(14, 248);
            this.room1PictureBox.Name = "room1PictureBox";
            this.room1PictureBox.Size = new System.Drawing.Size(40, 40);
            this.room1PictureBox.TabIndex = 26;
            this.room1PictureBox.TabStop = false;
            // 
            // room2PictureBox
            // 
            this.room2PictureBox.BackColor = System.Drawing.Color.Gray;
            this.room2PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.room2PictureBox.Location = new System.Drawing.Point(14, 202);
            this.room2PictureBox.Name = "room2PictureBox";
            this.room2PictureBox.Size = new System.Drawing.Size(40, 40);
            this.room2PictureBox.TabIndex = 25;
            this.room2PictureBox.TabStop = false;
            // 
            // room3PictureBox
            // 
            this.room3PictureBox.BackColor = System.Drawing.Color.Gray;
            this.room3PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.room3PictureBox.Location = new System.Drawing.Point(14, 156);
            this.room3PictureBox.Name = "room3PictureBox";
            this.room3PictureBox.Size = new System.Drawing.Size(40, 40);
            this.room3PictureBox.TabIndex = 24;
            this.room3PictureBox.TabStop = false;
            // 
            // room4PictureBox
            // 
            this.room4PictureBox.BackColor = System.Drawing.Color.Gray;
            this.room4PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.room4PictureBox.Location = new System.Drawing.Point(14, 110);
            this.room4PictureBox.Name = "room4PictureBox";
            this.room4PictureBox.Size = new System.Drawing.Size(40, 40);
            this.room4PictureBox.TabIndex = 23;
            this.room4PictureBox.TabStop = false;
            // 
            // room5PictureBox
            // 
            this.room5PictureBox.BackColor = System.Drawing.Color.Gray;
            this.room5PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.room5PictureBox.Location = new System.Drawing.Point(14, 64);
            this.room5PictureBox.Name = "room5PictureBox";
            this.room5PictureBox.Size = new System.Drawing.Size(40, 40);
            this.room5PictureBox.TabIndex = 22;
            this.room5PictureBox.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.itemButton);
            this.panel3.Controls.Add(this.attackButton);
            this.panel3.Controls.Add(this.enemyListBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(176, 322);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 111);
            this.panel3.TabIndex = 2;
            // 
            // itemButton
            // 
            this.itemButton.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemButton.Location = new System.Drawing.Point(173, 66);
            this.itemButton.Name = "itemButton";
            this.itemButton.Size = new System.Drawing.Size(106, 34);
            this.itemButton.TabIndex = 38;
            this.itemButton.Text = "use item";
            this.itemButton.UseVisualStyleBackColor = true;
            this.itemButton.Click += new System.EventHandler(this.itemButton_Click);
            // 
            // attackButton
            // 
            this.attackButton.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackButton.Location = new System.Drawing.Point(173, 32);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(106, 34);
            this.attackButton.TabIndex = 36;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // enemyListBox
            // 
            this.enemyListBox.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyListBox.FormattingEnabled = true;
            this.enemyListBox.ItemHeight = 16;
            this.enemyListBox.Location = new System.Drawing.Point(12, 32);
            this.enemyListBox.Name = "enemyListBox";
            this.enemyListBox.Size = new System.Drawing.Size(155, 68);
            this.enemyListBox.TabIndex = 35;
            this.enemyListBox.SelectedIndexChanged += new System.EventHandler(this.enemyListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 22);
            this.label2.TabIndex = 34;
            this.label2.Text = "Battle Target:";
            // 
            // playerInfoPanel
            // 
            this.playerInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerInfoPanel.Controls.Add(this.pHPLabel);
            this.playerInfoPanel.Controls.Add(this.pNameLabel);
            this.playerInfoPanel.Controls.Add(this.pHPDescLabel);
            this.playerInfoPanel.Controls.Add(this.pNameDescLabel);
            this.playerInfoPanel.Controls.Add(this.playerInfoPanelDescLabel);
            this.playerInfoPanel.Location = new System.Drawing.Point(13, 323);
            this.playerInfoPanel.Name = "playerInfoPanel";
            this.playerInfoPanel.Size = new System.Drawing.Size(157, 110);
            this.playerInfoPanel.TabIndex = 3;
            // 
            // pHPLabel
            // 
            this.pHPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pHPLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pHPLabel.Location = new System.Drawing.Point(90, 78);
            this.pHPLabel.Name = "pHPLabel";
            this.pHPLabel.Size = new System.Drawing.Size(62, 21);
            this.pHPLabel.TabIndex = 39;
            this.pHPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pNameLabel
            // 
            this.pNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pNameLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNameLabel.Location = new System.Drawing.Point(8, 52);
            this.pNameLabel.Name = "pNameLabel";
            this.pNameLabel.Size = new System.Drawing.Size(144, 21);
            this.pNameLabel.TabIndex = 38;
            this.pNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pHPDescLabel
            // 
            this.pHPDescLabel.AutoSize = true;
            this.pHPDescLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pHPDescLabel.Location = new System.Drawing.Point(3, 78);
            this.pHPDescLabel.Name = "pHPDescLabel";
            this.pHPDescLabel.Size = new System.Drawing.Size(81, 16);
            this.pHPDescLabel.TabIndex = 37;
            this.pHPDescLabel.Text = "Player HP:";
            // 
            // pNameDescLabel
            // 
            this.pNameDescLabel.AutoSize = true;
            this.pNameDescLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNameDescLabel.Location = new System.Drawing.Point(4, 36);
            this.pNameDescLabel.Name = "pNameDescLabel";
            this.pNameDescLabel.Size = new System.Drawing.Size(98, 16);
            this.pNameDescLabel.TabIndex = 36;
            this.pNameDescLabel.Text = "Player Name:";
            // 
            // playerInfoPanelDescLabel
            // 
            this.playerInfoPanelDescLabel.AutoSize = true;
            this.playerInfoPanelDescLabel.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerInfoPanelDescLabel.Location = new System.Drawing.Point(3, 6);
            this.playerInfoPanelDescLabel.Name = "playerInfoPanelDescLabel";
            this.playerInfoPanelDescLabel.Size = new System.Drawing.Size(134, 22);
            this.playerInfoPanelDescLabel.TabIndex = 35;
            this.playerInfoPanelDescLabel.Text = "Player Info:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.instructionsButton);
            this.panel1.Controls.Add(this.displayKeyItemsButton);
            this.panel1.Controls.Add(this.displayItemsButton);
            this.panel1.Location = new System.Drawing.Point(467, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 110);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 41;
            this.label1.Text = "Other Info:";
            // 
            // instructionsButton
            // 
            this.instructionsButton.Font = new System.Drawing.Font("Stencil", 10F);
            this.instructionsButton.Location = new System.Drawing.Point(140, 12);
            this.instructionsButton.Name = "instructionsButton";
            this.instructionsButton.Size = new System.Drawing.Size(120, 43);
            this.instructionsButton.TabIndex = 40;
            this.instructionsButton.Text = "Instructions";
            this.instructionsButton.UseVisualStyleBackColor = true;
            this.instructionsButton.Click += new System.EventHandler(this.instructionsButton_Click);
            // 
            // displayKeyItemsButton
            // 
            this.displayKeyItemsButton.Font = new System.Drawing.Font("Stencil", 11F);
            this.displayKeyItemsButton.Location = new System.Drawing.Point(140, 61);
            this.displayKeyItemsButton.Name = "displayKeyItemsButton";
            this.displayKeyItemsButton.Size = new System.Drawing.Size(120, 43);
            this.displayKeyItemsButton.TabIndex = 39;
            this.displayKeyItemsButton.Text = "My Key Items";
            this.displayKeyItemsButton.UseVisualStyleBackColor = true;
            this.displayKeyItemsButton.Click += new System.EventHandler(this.displayKeyItemsButton_Click);
            // 
            // displayItemsButton
            // 
            this.displayItemsButton.Font = new System.Drawing.Font("Stencil", 11F);
            this.displayItemsButton.Location = new System.Drawing.Point(14, 61);
            this.displayItemsButton.Name = "displayItemsButton";
            this.displayItemsButton.Size = new System.Drawing.Size(120, 43);
            this.displayItemsButton.TabIndex = 38;
            this.displayItemsButton.Text = " My Items";
            this.displayItemsButton.UseVisualStyleBackColor = true;
            this.displayItemsButton.Click += new System.EventHandler(this.displayItemsButton_Click);
            // 
            // battleLogRichTextBox
            // 
            this.battleLogRichTextBox.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battleLogRichTextBox.Location = new System.Drawing.Point(11, 40);
            this.battleLogRichTextBox.Name = "battleLogRichTextBox";
            this.battleLogRichTextBox.ReadOnly = true;
            this.battleLogRichTextBox.Size = new System.Drawing.Size(426, 248);
            this.battleLogRichTextBox.TabIndex = 35;
            this.battleLogRichTextBox.Text = "";
            // 
            // DungeonCrawlGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 440);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.playerInfoPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.mapDisplayPanel);
            this.Controls.Add(this.battleLogPanel);
            this.Name = "DungeonCrawlGame";
            this.Text = "DungeonCrawlGame";
            this.Load += new System.EventHandler(this.DungeonCrawlGame_Load);
            this.battleLogPanel.ResumeLayout(false);
            this.battleLogPanel.PerformLayout();
            this.mapDisplayPanel.ResumeLayout(false);
            this.mapDisplayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.room1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room4PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room5PictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.playerInfoPanel.ResumeLayout(false);
            this.playerInfoPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel battleLogPanel;
        private System.Windows.Forms.Panel mapDisplayPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label mapPanelDescLabel;
        private System.Windows.Forms.Label mapLabel;
        private System.Windows.Forms.Label currentRoomLabel;
        private System.Windows.Forms.Label currentRoomDescLabel;
        private System.Windows.Forms.Button southButton;
        private System.Windows.Forms.Button northButton;
        private System.Windows.Forms.PictureBox room1PictureBox;
        private System.Windows.Forms.PictureBox room2PictureBox;
        private System.Windows.Forms.PictureBox room3PictureBox;
        private System.Windows.Forms.PictureBox room4PictureBox;
        private System.Windows.Forms.PictureBox room5PictureBox;
        private System.Windows.Forms.Label battleLogPanelDescLabel;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.ListBox enemyListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel playerInfoPanel;
        private System.Windows.Forms.Label pHPDescLabel;
        private System.Windows.Forms.Label pNameDescLabel;
        private System.Windows.Forms.Label playerInfoPanelDescLabel;
        private System.Windows.Forms.Label pHPLabel;
        private System.Windows.Forms.Label pNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button itemButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button displayKeyItemsButton;
        private System.Windows.Forms.Button displayItemsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button instructionsButton;
        private System.Windows.Forms.RichTextBox battleLogRichTextBox;
    }
}