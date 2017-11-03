namespace DungeonCrawl
{
    partial class EnemyInfo
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
            this.enemyWeaponLabel = new System.Windows.Forms.Label();
            this.enemyWeaponDescLabel = new System.Windows.Forms.Label();
            this.enemyWeaponDamageLabel = new System.Windows.Forms.Label();
            this.enemyWeaponDamageDescLabel = new System.Windows.Forms.Label();
            this.enemyCurrentHPLabel = new System.Windows.Forms.Label();
            this.enemyMaxHPLabel = new System.Windows.Forms.Label();
            this.enemyNameLabel = new System.Windows.Forms.Label();
            this.possibleRoomEnemiesDescLabel = new System.Windows.Forms.Label();
            this.roomDescriptionDescLabel = new System.Windows.Forms.Label();
            this.enemyNameDescLabel = new System.Windows.Forms.Label();
            this.enemyListBox = new System.Windows.Forms.ListBox();
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
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enemy Information:";
            // 
            // roomInfoPanel
            // 
            this.roomInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomInfoPanel.Controls.Add(this.enemyWeaponLabel);
            this.roomInfoPanel.Controls.Add(this.enemyWeaponDescLabel);
            this.roomInfoPanel.Controls.Add(this.enemyWeaponDamageLabel);
            this.roomInfoPanel.Controls.Add(this.enemyWeaponDamageDescLabel);
            this.roomInfoPanel.Controls.Add(this.enemyCurrentHPLabel);
            this.roomInfoPanel.Controls.Add(this.enemyMaxHPLabel);
            this.roomInfoPanel.Controls.Add(this.enemyNameLabel);
            this.roomInfoPanel.Controls.Add(this.possibleRoomEnemiesDescLabel);
            this.roomInfoPanel.Controls.Add(this.roomDescriptionDescLabel);
            this.roomInfoPanel.Controls.Add(this.enemyNameDescLabel);
            this.roomInfoPanel.Location = new System.Drawing.Point(194, 48);
            this.roomInfoPanel.Name = "roomInfoPanel";
            this.roomInfoPanel.Size = new System.Drawing.Size(395, 180);
            this.roomInfoPanel.TabIndex = 4;
            // 
            // enemyWeaponLabel
            // 
            this.enemyWeaponLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemyWeaponLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyWeaponLabel.ForeColor = System.Drawing.Color.Crimson;
            this.enemyWeaponLabel.Location = new System.Drawing.Point(182, 111);
            this.enemyWeaponLabel.Name = "enemyWeaponLabel";
            this.enemyWeaponLabel.Size = new System.Drawing.Size(197, 22);
            this.enemyWeaponLabel.TabIndex = 9;
            this.enemyWeaponLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enemyWeaponDescLabel
            // 
            this.enemyWeaponDescLabel.AutoSize = true;
            this.enemyWeaponDescLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyWeaponDescLabel.ForeColor = System.Drawing.Color.Crimson;
            this.enemyWeaponDescLabel.Location = new System.Drawing.Point(13, 116);
            this.enemyWeaponDescLabel.Name = "enemyWeaponDescLabel";
            this.enemyWeaponDescLabel.Size = new System.Drawing.Size(110, 16);
            this.enemyWeaponDescLabel.TabIndex = 8;
            this.enemyWeaponDescLabel.Text = "Enemy Weapon:";
            // 
            // enemyWeaponDamageLabel
            // 
            this.enemyWeaponDamageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemyWeaponDamageLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyWeaponDamageLabel.ForeColor = System.Drawing.Color.Crimson;
            this.enemyWeaponDamageLabel.Location = new System.Drawing.Point(182, 144);
            this.enemyWeaponDamageLabel.Name = "enemyWeaponDamageLabel";
            this.enemyWeaponDamageLabel.Size = new System.Drawing.Size(197, 22);
            this.enemyWeaponDamageLabel.TabIndex = 7;
            this.enemyWeaponDamageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enemyWeaponDamageDescLabel
            // 
            this.enemyWeaponDamageDescLabel.AutoSize = true;
            this.enemyWeaponDamageDescLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyWeaponDamageDescLabel.ForeColor = System.Drawing.Color.Crimson;
            this.enemyWeaponDamageDescLabel.Location = new System.Drawing.Point(13, 149);
            this.enemyWeaponDamageDescLabel.Name = "enemyWeaponDamageDescLabel";
            this.enemyWeaponDamageDescLabel.Size = new System.Drawing.Size(163, 16);
            this.enemyWeaponDamageDescLabel.TabIndex = 6;
            this.enemyWeaponDamageDescLabel.Text = "Enemy Weapon Damage:";
            // 
            // enemyCurrentHPLabel
            // 
            this.enemyCurrentHPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemyCurrentHPLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyCurrentHPLabel.ForeColor = System.Drawing.Color.Crimson;
            this.enemyCurrentHPLabel.Location = new System.Drawing.Point(182, 79);
            this.enemyCurrentHPLabel.Name = "enemyCurrentHPLabel";
            this.enemyCurrentHPLabel.Size = new System.Drawing.Size(197, 22);
            this.enemyCurrentHPLabel.TabIndex = 5;
            this.enemyCurrentHPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enemyMaxHPLabel
            // 
            this.enemyMaxHPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemyMaxHPLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyMaxHPLabel.ForeColor = System.Drawing.Color.Crimson;
            this.enemyMaxHPLabel.Location = new System.Drawing.Point(182, 44);
            this.enemyMaxHPLabel.Name = "enemyMaxHPLabel";
            this.enemyMaxHPLabel.Size = new System.Drawing.Size(197, 25);
            this.enemyMaxHPLabel.TabIndex = 4;
            this.enemyMaxHPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enemyNameLabel
            // 
            this.enemyNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemyNameLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyNameLabel.ForeColor = System.Drawing.Color.Crimson;
            this.enemyNameLabel.Location = new System.Drawing.Point(182, 11);
            this.enemyNameLabel.Name = "enemyNameLabel";
            this.enemyNameLabel.Size = new System.Drawing.Size(197, 23);
            this.enemyNameLabel.TabIndex = 3;
            this.enemyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // possibleRoomEnemiesDescLabel
            // 
            this.possibleRoomEnemiesDescLabel.AutoSize = true;
            this.possibleRoomEnemiesDescLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.possibleRoomEnemiesDescLabel.ForeColor = System.Drawing.Color.Crimson;
            this.possibleRoomEnemiesDescLabel.Location = new System.Drawing.Point(13, 84);
            this.possibleRoomEnemiesDescLabel.Name = "possibleRoomEnemiesDescLabel";
            this.possibleRoomEnemiesDescLabel.Size = new System.Drawing.Size(139, 16);
            this.possibleRoomEnemiesDescLabel.TabIndex = 2;
            this.possibleRoomEnemiesDescLabel.Text = "Enemy Current HP:";
            // 
            // roomDescriptionDescLabel
            // 
            this.roomDescriptionDescLabel.AutoSize = true;
            this.roomDescriptionDescLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDescriptionDescLabel.ForeColor = System.Drawing.Color.Crimson;
            this.roomDescriptionDescLabel.Location = new System.Drawing.Point(13, 50);
            this.roomDescriptionDescLabel.Name = "roomDescriptionDescLabel";
            this.roomDescriptionDescLabel.Size = new System.Drawing.Size(105, 16);
            this.roomDescriptionDescLabel.TabIndex = 1;
            this.roomDescriptionDescLabel.Text = "Enemy Max HP:";
            // 
            // enemyNameDescLabel
            // 
            this.enemyNameDescLabel.AutoSize = true;
            this.enemyNameDescLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyNameDescLabel.ForeColor = System.Drawing.Color.Crimson;
            this.enemyNameDescLabel.Location = new System.Drawing.Point(13, 16);
            this.enemyNameDescLabel.Name = "enemyNameDescLabel";
            this.enemyNameDescLabel.Size = new System.Drawing.Size(93, 16);
            this.enemyNameDescLabel.TabIndex = 0;
            this.enemyNameDescLabel.Text = "Enemy Name:";
            // 
            // enemyListBox
            // 
            this.enemyListBox.BackColor = System.Drawing.Color.DarkGray;
            this.enemyListBox.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyListBox.ForeColor = System.Drawing.Color.Crimson;
            this.enemyListBox.FormattingEnabled = true;
            this.enemyListBox.ItemHeight = 16;
            this.enemyListBox.Location = new System.Drawing.Point(13, 48);
            this.enemyListBox.Name = "enemyListBox";
            this.enemyListBox.Size = new System.Drawing.Size(175, 180);
            this.enemyListBox.TabIndex = 3;
            this.enemyListBox.SelectedIndexChanged += new System.EventHandler(this.enemyListBox_SelectedIndexChanged);
            // 
            // EnemyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(601, 242);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomInfoPanel);
            this.Controls.Add(this.enemyListBox);
            this.Name = "EnemyInfo";
            this.Text = "EnemyInfo";
            this.Load += new System.EventHandler(this.EnemyInfo_Load);
            this.roomInfoPanel.ResumeLayout(false);
            this.roomInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel roomInfoPanel;
        private System.Windows.Forms.Label enemyCurrentHPLabel;
        private System.Windows.Forms.Label enemyMaxHPLabel;
        private System.Windows.Forms.Label enemyNameLabel;
        private System.Windows.Forms.Label possibleRoomEnemiesDescLabel;
        private System.Windows.Forms.Label roomDescriptionDescLabel;
        private System.Windows.Forms.Label enemyNameDescLabel;
        private System.Windows.Forms.ListBox enemyListBox;
        private System.Windows.Forms.Label enemyWeaponDamageLabel;
        private System.Windows.Forms.Label enemyWeaponDamageDescLabel;
        private System.Windows.Forms.Label enemyWeaponLabel;
        private System.Windows.Forms.Label enemyWeaponDescLabel;
    }
}