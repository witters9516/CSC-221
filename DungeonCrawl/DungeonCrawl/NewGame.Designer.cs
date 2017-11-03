namespace DungeonCrawl
{
    partial class NewGame
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
            this.saveInfoButton = new System.Windows.Forms.Button();
            this.pPasswordTextBox = new System.Windows.Forms.TextBox();
            this.pNameTextBox = new System.Windows.Forms.TextBox();
            this.chooseWeaponDescLabel = new System.Windows.Forms.Label();
            this.pPasswordLabel = new System.Windows.Forms.Label();
            this.pNameLabel = new System.Windows.Forms.Label();
            this.playerClassPanel = new System.Windows.Forms.Panel();
            this.potRadioButton = new System.Windows.Forms.RadioButton();
            this.axeRadioButton = new System.Windows.Forms.RadioButton();
            this.swordRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gunRadioButton = new System.Windows.Forms.RadioButton();
            this.playerClassPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveInfoButton
            // 
            this.saveInfoButton.BackColor = System.Drawing.Color.Crimson;
            this.saveInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveInfoButton.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveInfoButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveInfoButton.Location = new System.Drawing.Point(111, 330);
            this.saveInfoButton.Name = "saveInfoButton";
            this.saveInfoButton.Size = new System.Drawing.Size(189, 39);
            this.saveInfoButton.TabIndex = 72;
            this.saveInfoButton.Text = "Save Information";
            this.saveInfoButton.UseVisualStyleBackColor = false;
            this.saveInfoButton.Click += new System.EventHandler(this.saveInfoButton_Click);
            // 
            // pPasswordTextBox
            // 
            this.pPasswordTextBox.BackColor = System.Drawing.Color.Crimson;
            this.pPasswordTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.pPasswordTextBox.Location = new System.Drawing.Point(235, 97);
            this.pPasswordTextBox.Name = "pPasswordTextBox";
            this.pPasswordTextBox.Size = new System.Drawing.Size(170, 20);
            this.pPasswordTextBox.TabIndex = 71;
            // 
            // pNameTextBox
            // 
            this.pNameTextBox.BackColor = System.Drawing.Color.Crimson;
            this.pNameTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.pNameTextBox.Location = new System.Drawing.Point(235, 70);
            this.pNameTextBox.Name = "pNameTextBox";
            this.pNameTextBox.Size = new System.Drawing.Size(170, 20);
            this.pNameTextBox.TabIndex = 70;
            // 
            // chooseWeaponDescLabel
            // 
            this.chooseWeaponDescLabel.AutoSize = true;
            this.chooseWeaponDescLabel.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseWeaponDescLabel.ForeColor = System.Drawing.Color.Crimson;
            this.chooseWeaponDescLabel.Location = new System.Drawing.Point(8, 9);
            this.chooseWeaponDescLabel.Name = "chooseWeaponDescLabel";
            this.chooseWeaponDescLabel.Size = new System.Drawing.Size(373, 25);
            this.chooseWeaponDescLabel.TabIndex = 68;
            this.chooseWeaponDescLabel.Text = "Please Choose a Default Weapon:";
            // 
            // pPasswordLabel
            // 
            this.pPasswordLabel.AutoSize = true;
            this.pPasswordLabel.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pPasswordLabel.ForeColor = System.Drawing.Color.Crimson;
            this.pPasswordLabel.Location = new System.Drawing.Point(19, 92);
            this.pPasswordLabel.Name = "pPasswordLabel";
            this.pPasswordLabel.Size = new System.Drawing.Size(210, 25);
            this.pPasswordLabel.TabIndex = 67;
            this.pPasswordLabel.Text = "Player Password:";
            // 
            // pNameLabel
            // 
            this.pNameLabel.AutoSize = true;
            this.pNameLabel.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNameLabel.ForeColor = System.Drawing.Color.Crimson;
            this.pNameLabel.Location = new System.Drawing.Point(19, 65);
            this.pNameLabel.Name = "pNameLabel";
            this.pNameLabel.Size = new System.Drawing.Size(156, 25);
            this.pNameLabel.TabIndex = 66;
            this.pNameLabel.Text = "Player Name:";
            // 
            // playerClassPanel
            // 
            this.playerClassPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerClassPanel.Controls.Add(this.gunRadioButton);
            this.playerClassPanel.Controls.Add(this.potRadioButton);
            this.playerClassPanel.Controls.Add(this.axeRadioButton);
            this.playerClassPanel.Controls.Add(this.swordRadioButton);
            this.playerClassPanel.Controls.Add(this.chooseWeaponDescLabel);
            this.playerClassPanel.Location = new System.Drawing.Point(24, 144);
            this.playerClassPanel.Name = "playerClassPanel";
            this.playerClassPanel.Size = new System.Drawing.Size(381, 180);
            this.playerClassPanel.TabIndex = 73;
            // 
            // potRadioButton
            // 
            this.potRadioButton.AutoSize = true;
            this.potRadioButton.Checked = true;
            this.potRadioButton.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potRadioButton.ForeColor = System.Drawing.Color.Crimson;
            this.potRadioButton.Location = new System.Drawing.Point(35, 37);
            this.potRadioButton.Name = "potRadioButton";
            this.potRadioButton.Size = new System.Drawing.Size(164, 26);
            this.potRadioButton.TabIndex = 40;
            this.potRadioButton.TabStop = true;
            this.potRadioButton.Text = "Pot - Weakest";
            this.potRadioButton.UseVisualStyleBackColor = true;
            // 
            // axeRadioButton
            // 
            this.axeRadioButton.AutoSize = true;
            this.axeRadioButton.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axeRadioButton.ForeColor = System.Drawing.Color.Crimson;
            this.axeRadioButton.Location = new System.Drawing.Point(35, 69);
            this.axeRadioButton.Name = "axeRadioButton";
            this.axeRadioButton.Size = new System.Drawing.Size(131, 26);
            this.axeRadioButton.TabIndex = 41;
            this.axeRadioButton.Text = "Axe - Weak";
            this.axeRadioButton.UseVisualStyleBackColor = true;
            // 
            // swordRadioButton
            // 
            this.swordRadioButton.AutoSize = true;
            this.swordRadioButton.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swordRadioButton.ForeColor = System.Drawing.Color.Crimson;
            this.swordRadioButton.Location = new System.Drawing.Point(35, 101);
            this.swordRadioButton.Name = "swordRadioButton";
            this.swordRadioButton.Size = new System.Drawing.Size(179, 26);
            this.swordRadioButton.TabIndex = 42;
            this.swordRadioButton.Text = "Sword - Strong";
            this.swordRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 29);
            this.label1.TabIndex = 74;
            this.label1.Text = "Please Enter New Player Info:";
            // 
            // gunRadioButton
            // 
            this.gunRadioButton.AutoSize = true;
            this.gunRadioButton.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunRadioButton.ForeColor = System.Drawing.Color.Crimson;
            this.gunRadioButton.Location = new System.Drawing.Point(35, 133);
            this.gunRadioButton.Name = "gunRadioButton";
            this.gunRadioButton.Size = new System.Drawing.Size(186, 26);
            this.gunRadioButton.TabIndex = 69;
            this.gunRadioButton.Text = "Gun - Strongest";
            this.gunRadioButton.UseVisualStyleBackColor = true;
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(427, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveInfoButton);
            this.Controls.Add(this.pPasswordTextBox);
            this.Controls.Add(this.pNameTextBox);
            this.Controls.Add(this.pPasswordLabel);
            this.Controls.Add(this.pNameLabel);
            this.Controls.Add(this.playerClassPanel);
            this.Name = "NewGame";
            this.Text = "NewGame";
            this.playerClassPanel.ResumeLayout(false);
            this.playerClassPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveInfoButton;
        private System.Windows.Forms.TextBox pPasswordTextBox;
        private System.Windows.Forms.TextBox pNameTextBox;
        private System.Windows.Forms.Label chooseWeaponDescLabel;
        private System.Windows.Forms.Label pPasswordLabel;
        private System.Windows.Forms.Label pNameLabel;
        private System.Windows.Forms.Panel playerClassPanel;
        private System.Windows.Forms.RadioButton gunRadioButton;
        private System.Windows.Forms.RadioButton potRadioButton;
        private System.Windows.Forms.RadioButton axeRadioButton;
        private System.Windows.Forms.RadioButton swordRadioButton;
        private System.Windows.Forms.Label label1;
    }
}