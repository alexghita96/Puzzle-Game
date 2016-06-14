namespace Puzzle_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.shuffle_image_button = new System.Windows.Forms.Button();
            this.Statistics_Panel = new System.Windows.Forms.Panel();
            this.Moves_Made_TextBox = new System.Windows.Forms.TextBox();
            this.Moves_Made_Label = new System.Windows.Forms.Label();
            this.Games_Won_TextBox = new System.Windows.Forms.TextBox();
            this.Games_Played_TextBox = new System.Windows.Forms.TextBox();
            this.Games_Won_Label = new System.Windows.Forms.Label();
            this.Games_Played_Label = new System.Windows.Forms.Label();
            this.Statistics_Label = new System.Windows.Forms.Label();
            this.Solved_PictureBox = new System.Windows.Forms.PictureBox();
            this.Statistics_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Solved_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // shuffle_image_button
            // 
            this.shuffle_image_button.Location = new System.Drawing.Point(550, 50);
            this.shuffle_image_button.Name = "shuffle_image_button";
            this.shuffle_image_button.Size = new System.Drawing.Size(90, 23);
            this.shuffle_image_button.TabIndex = 0;
            this.shuffle_image_button.Text = "Shuffle Image";
            this.shuffle_image_button.UseVisualStyleBackColor = true;
            this.shuffle_image_button.Click += new System.EventHandler(this.shuffle_image_button_Click);
            // 
            // Statistics_Panel
            // 
            this.Statistics_Panel.BackColor = System.Drawing.SystemColors.Control;
            this.Statistics_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Statistics_Panel.Controls.Add(this.Moves_Made_TextBox);
            this.Statistics_Panel.Controls.Add(this.Moves_Made_Label);
            this.Statistics_Panel.Controls.Add(this.Games_Won_TextBox);
            this.Statistics_Panel.Controls.Add(this.Games_Played_TextBox);
            this.Statistics_Panel.Controls.Add(this.Games_Won_Label);
            this.Statistics_Panel.Controls.Add(this.Games_Played_Label);
            this.Statistics_Panel.Location = new System.Drawing.Point(520, 120);
            this.Statistics_Panel.Name = "Statistics_Panel";
            this.Statistics_Panel.Size = new System.Drawing.Size(150, 100);
            this.Statistics_Panel.TabIndex = 1;
            // 
            // Moves_Made_TextBox
            // 
            this.Moves_Made_TextBox.Location = new System.Drawing.Point(85, 70);
            this.Moves_Made_TextBox.Name = "Moves_Made_TextBox";
            this.Moves_Made_TextBox.Size = new System.Drawing.Size(55, 20);
            this.Moves_Made_TextBox.TabIndex = 5;
            // 
            // Moves_Made_Label
            // 
            this.Moves_Made_Label.AutoSize = true;
            this.Moves_Made_Label.Location = new System.Drawing.Point(5, 70);
            this.Moves_Made_Label.Name = "Moves_Made_Label";
            this.Moves_Made_Label.Size = new System.Drawing.Size(71, 13);
            this.Moves_Made_Label.TabIndex = 4;
            this.Moves_Made_Label.Text = "Moves made:";
            // 
            // Games_Won_TextBox
            // 
            this.Games_Won_TextBox.Location = new System.Drawing.Point(85, 40);
            this.Games_Won_TextBox.Name = "Games_Won_TextBox";
            this.Games_Won_TextBox.Size = new System.Drawing.Size(55, 20);
            this.Games_Won_TextBox.TabIndex = 3;
            // 
            // Games_Played_TextBox
            // 
            this.Games_Played_TextBox.Location = new System.Drawing.Point(85, 7);
            this.Games_Played_TextBox.Name = "Games_Played_TextBox";
            this.Games_Played_TextBox.Size = new System.Drawing.Size(55, 20);
            this.Games_Played_TextBox.TabIndex = 2;
            // 
            // Games_Won_Label
            // 
            this.Games_Won_Label.AutoSize = true;
            this.Games_Won_Label.Location = new System.Drawing.Point(5, 40);
            this.Games_Won_Label.Name = "Games_Won_Label";
            this.Games_Won_Label.Size = new System.Drawing.Size(66, 13);
            this.Games_Won_Label.TabIndex = 1;
            this.Games_Won_Label.Text = "Games won:";
            // 
            // Games_Played_Label
            // 
            this.Games_Played_Label.AutoSize = true;
            this.Games_Played_Label.Location = new System.Drawing.Point(5, 10);
            this.Games_Played_Label.Name = "Games_Played_Label";
            this.Games_Played_Label.Size = new System.Drawing.Size(77, 13);
            this.Games_Played_Label.TabIndex = 0;
            this.Games_Played_Label.Text = "Games played:";
            // 
            // Statistics_Label
            // 
            this.Statistics_Label.Location = new System.Drawing.Point(550, 95);
            this.Statistics_Label.Name = "Statistics_Label";
            this.Statistics_Label.Size = new System.Drawing.Size(90, 13);
            this.Statistics_Label.TabIndex = 2;
            this.Statistics_Label.Text = "Statistics:";
            this.Statistics_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Solved_PictureBox
            // 
            this.Solved_PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Solved_PictureBox.Location = new System.Drawing.Point(530, 340);
            this.Solved_PictureBox.Name = "Solved_PictureBox";
            this.Solved_PictureBox.Size = new System.Drawing.Size(130, 130);
            this.Solved_PictureBox.TabIndex = 4;
            this.Solved_PictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 522);
            this.Controls.Add(this.Solved_PictureBox);
            this.Controls.Add(this.Statistics_Label);
            this.Controls.Add(this.Statistics_Panel);
            this.Controls.Add(this.shuffle_image_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Puzzle Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Statistics_Panel.ResumeLayout(false);
            this.Statistics_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Solved_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button shuffle_image_button;
        private System.Windows.Forms.Panel Statistics_Panel;
        private System.Windows.Forms.Label Statistics_Label;
        private System.Windows.Forms.TextBox Moves_Made_TextBox;
        private System.Windows.Forms.Label Moves_Made_Label;
        private System.Windows.Forms.TextBox Games_Won_TextBox;
        private System.Windows.Forms.TextBox Games_Played_TextBox;
        private System.Windows.Forms.Label Games_Won_Label;
        private System.Windows.Forms.Label Games_Played_Label;
        private System.Windows.Forms.PictureBox Solved_PictureBox;
    }
}

