namespace handman_2
{
    partial class Hangman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hangman));
            this.Validate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.Debug_Label = new System.Windows.Forms.Label();
            this.Show_Word = new System.Windows.Forms.Label();
            this.HintBox = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Validate
            // 
            this.Validate.BackColor = System.Drawing.Color.Transparent;
            this.Validate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Validate.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Validate.ForeColor = System.Drawing.SystemColors.Window;
            this.Validate.Location = new System.Drawing.Point(894, 661);
            this.Validate.Name = "Validate";
            this.Validate.Size = new System.Drawing.Size(112, 40);
            this.Validate.TabIndex = 2;
            this.Validate.Text = "Validate";
            this.Validate.UseVisualStyleBackColor = false;
            this.Validate.Click += new System.EventHandler(this.Validate_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(12, 554);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "New Game";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserInput
            // 
            this.UserInput.BackColor = System.Drawing.SystemColors.Menu;
            this.UserInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInput.Location = new System.Drawing.Point(907, 539);
            this.UserInput.MaxLength = 1;
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(80, 116);
            this.UserInput.TabIndex = 4;
            this.UserInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Debug_Label
            // 
            this.Debug_Label.AutoSize = true;
            this.Debug_Label.Location = new System.Drawing.Point(677, 536);
            this.Debug_Label.Name = "Debug_Label";
            this.Debug_Label.Size = new System.Drawing.Size(71, 13);
            this.Debug_Label.TabIndex = 5;
            this.Debug_Label.Text = "Debug_Label";
            this.Debug_Label.Visible = false;
            // 
            // Show_Word
            // 
            this.Show_Word.AutoSize = true;
            this.Show_Word.BackColor = System.Drawing.Color.Transparent;
            this.Show_Word.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Word.ForeColor = System.Drawing.SystemColors.Window;
            this.Show_Word.Location = new System.Drawing.Point(385, 567);
            this.Show_Word.Name = "Show_Word";
            this.Show_Word.Size = new System.Drawing.Size(0, 58);
            this.Show_Word.TabIndex = 6;
            this.Show_Word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HintBox
            // 
            this.HintBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HintBox.AutoSize = true;
            this.HintBox.BackColor = System.Drawing.Color.Transparent;
            this.HintBox.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HintBox.ForeColor = System.Drawing.SystemColors.Window;
            this.HintBox.Location = new System.Drawing.Point(12, 682);
            this.HintBox.Name = "HintBox";
            this.HintBox.Size = new System.Drawing.Size(115, 32);
            this.HintBox.TabIndex = 7;
            this.HintBox.Text = "This is a hint";
            this.HintBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BackgroundImage = global::handman_2.Properties.Resources.frame1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 521);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Hangman
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 723);
            this.Controls.Add(this.HintBox);
            this.Controls.Add(this.Show_Word);
            this.Controls.Add(this.Debug_Label);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Validate);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hangman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Validate;
        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.Label Debug_Label;
        private System.Windows.Forms.Label Show_Word;
        private System.Windows.Forms.Label HintBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button button1;
    }
}

