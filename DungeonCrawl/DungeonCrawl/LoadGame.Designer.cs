namespace DungeonCrawl
{
    partial class LoadGame
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
            this.loadInfoButton = new System.Windows.Forms.Button();
            this.pPasswordTextBox = new System.Windows.Forms.TextBox();
            this.pNameTextBox = new System.Windows.Forms.TextBox();
            this.pPasswordLabel = new System.Windows.Forms.Label();
            this.pNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadInfoButton
            // 
            this.loadInfoButton.BackColor = System.Drawing.Color.Crimson;
            this.loadInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadInfoButton.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadInfoButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loadInfoButton.Location = new System.Drawing.Point(114, 126);
            this.loadInfoButton.Name = "loadInfoButton";
            this.loadInfoButton.Size = new System.Drawing.Size(189, 39);
            this.loadInfoButton.TabIndex = 86;
            this.loadInfoButton.Text = "Load Information";
            this.loadInfoButton.UseVisualStyleBackColor = false;
            this.loadInfoButton.Click += new System.EventHandler(this.loadInfoButton_Click);
            // 
            // pPasswordTextBox
            // 
            this.pPasswordTextBox.BackColor = System.Drawing.Color.Crimson;
            this.pPasswordTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.pPasswordTextBox.Location = new System.Drawing.Point(241, 88);
            this.pPasswordTextBox.Name = "pPasswordTextBox";
            this.pPasswordTextBox.Size = new System.Drawing.Size(170, 20);
            this.pPasswordTextBox.TabIndex = 85;
            // 
            // pNameTextBox
            // 
            this.pNameTextBox.BackColor = System.Drawing.Color.Crimson;
            this.pNameTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.pNameTextBox.Location = new System.Drawing.Point(241, 61);
            this.pNameTextBox.Name = "pNameTextBox";
            this.pNameTextBox.Size = new System.Drawing.Size(170, 20);
            this.pNameTextBox.TabIndex = 84;
            // 
            // pPasswordLabel
            // 
            this.pPasswordLabel.AutoSize = true;
            this.pPasswordLabel.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pPasswordLabel.ForeColor = System.Drawing.Color.Crimson;
            this.pPasswordLabel.Location = new System.Drawing.Point(25, 83);
            this.pPasswordLabel.Name = "pPasswordLabel";
            this.pPasswordLabel.Size = new System.Drawing.Size(210, 25);
            this.pPasswordLabel.TabIndex = 83;
            this.pPasswordLabel.Text = "Player Password:";
            // 
            // pNameLabel
            // 
            this.pNameLabel.AutoSize = true;
            this.pNameLabel.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNameLabel.ForeColor = System.Drawing.Color.Crimson;
            this.pNameLabel.Location = new System.Drawing.Point(25, 56);
            this.pNameLabel.Name = "pNameLabel";
            this.pNameLabel.Size = new System.Drawing.Size(156, 25);
            this.pNameLabel.TabIndex = 82;
            this.pNameLabel.Text = "Player Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 29);
            this.label1.TabIndex = 81;
            this.label1.Text = "Please Enter Player Login Info:";
            // 
            // LoadGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(429, 179);
            this.Controls.Add(this.loadInfoButton);
            this.Controls.Add(this.pPasswordTextBox);
            this.Controls.Add(this.pNameTextBox);
            this.Controls.Add(this.pPasswordLabel);
            this.Controls.Add(this.pNameLabel);
            this.Controls.Add(this.label1);
            this.Name = "LoadGame";
            this.Text = "LoadGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadInfoButton;
        private System.Windows.Forms.TextBox pPasswordTextBox;
        private System.Windows.Forms.TextBox pNameTextBox;
        private System.Windows.Forms.Label pPasswordLabel;
        private System.Windows.Forms.Label pNameLabel;
        private System.Windows.Forms.Label label1;
    }
}