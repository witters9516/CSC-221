namespace DungeonCrawl
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
            this.label1 = new System.Windows.Forms.Label();
            this.newGameButton = new System.Windows.Forms.Button();
            this.loadGameButton = new System.Windows.Forms.Button();
            this.otherInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dungeon Crawl";
            // 
            // newGameButton
            // 
            this.newGameButton.BackColor = System.Drawing.Color.Crimson;
            this.newGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newGameButton.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newGameButton.Location = new System.Drawing.Point(166, 125);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(216, 56);
            this.newGameButton.TabIndex = 1;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = false;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // loadGameButton
            // 
            this.loadGameButton.BackColor = System.Drawing.Color.Crimson;
            this.loadGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadGameButton.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadGameButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loadGameButton.Location = new System.Drawing.Point(166, 216);
            this.loadGameButton.Name = "loadGameButton";
            this.loadGameButton.Size = new System.Drawing.Size(216, 56);
            this.loadGameButton.TabIndex = 2;
            this.loadGameButton.Text = "Load Game";
            this.loadGameButton.UseVisualStyleBackColor = false;
            this.loadGameButton.Click += new System.EventHandler(this.loadGameButton_Click);
            // 
            // otherInfoButton
            // 
            this.otherInfoButton.BackColor = System.Drawing.Color.Crimson;
            this.otherInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otherInfoButton.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherInfoButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.otherInfoButton.Location = new System.Drawing.Point(166, 304);
            this.otherInfoButton.Name = "otherInfoButton";
            this.otherInfoButton.Size = new System.Drawing.Size(216, 56);
            this.otherInfoButton.TabIndex = 3;
            this.otherInfoButton.Text = "Other Info";
            this.otherInfoButton.UseVisualStyleBackColor = false;
            this.otherInfoButton.Click += new System.EventHandler(this.otherInfoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(577, 418);
            this.Controls.Add(this.otherInfoButton);
            this.Controls.Add(this.loadGameButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button loadGameButton;
        private System.Windows.Forms.Button otherInfoButton;
    }
}

