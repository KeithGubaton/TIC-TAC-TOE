
namespace TIC_TAC_TOE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.box1 = new System.Windows.Forms.Button();
            this.box2 = new System.Windows.Forms.Button();
            this.box3 = new System.Windows.Forms.Button();
            this.box6 = new System.Windows.Forms.Button();
            this.box5 = new System.Windows.Forms.Button();
            this.box4 = new System.Windows.Forms.Button();
            this.box9 = new System.Windows.Forms.Button();
            this.box8 = new System.Windows.Forms.Button();
            this.box7 = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // box1
            // 
            this.box1.BackColor = System.Drawing.Color.Transparent;
            this.box1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.box1.Location = new System.Drawing.Point(15, 16);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(103, 98);
            this.box1.TabIndex = 0;
            this.box1.UseVisualStyleBackColor = false;
            this.box1.Click += new System.EventHandler(this.box_Click);
            // 
            // box2
            // 
            this.box2.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.box2.Location = new System.Drawing.Point(124, 16);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(103, 98);
            this.box2.TabIndex = 1;
            this.box2.UseVisualStyleBackColor = true;
            this.box2.Click += new System.EventHandler(this.box_Click);
            // 
            // box3
            // 
            this.box3.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.box3.Location = new System.Drawing.Point(233, 16);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(103, 98);
            this.box3.TabIndex = 2;
            this.box3.UseVisualStyleBackColor = true;
            this.box3.Click += new System.EventHandler(this.box_Click);
            // 
            // box6
            // 
            this.box6.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.box6.Location = new System.Drawing.Point(234, 120);
            this.box6.Name = "box6";
            this.box6.Size = new System.Drawing.Size(103, 98);
            this.box6.TabIndex = 5;
            this.box6.UseVisualStyleBackColor = true;
            this.box6.Click += new System.EventHandler(this.box_Click);
            // 
            // box5
            // 
            this.box5.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.box5.Location = new System.Drawing.Point(125, 120);
            this.box5.Name = "box5";
            this.box5.Size = new System.Drawing.Size(103, 98);
            this.box5.TabIndex = 4;
            this.box5.UseVisualStyleBackColor = true;
            this.box5.Click += new System.EventHandler(this.box_Click);
            // 
            // box4
            // 
            this.box4.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.box4.Location = new System.Drawing.Point(16, 120);
            this.box4.Name = "box4";
            this.box4.Size = new System.Drawing.Size(103, 98);
            this.box4.TabIndex = 3;
            this.box4.UseVisualStyleBackColor = true;
            this.box4.Click += new System.EventHandler(this.box_Click);
            // 
            // box9
            // 
            this.box9.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.box9.Location = new System.Drawing.Point(233, 224);
            this.box9.Name = "box9";
            this.box9.Size = new System.Drawing.Size(103, 98);
            this.box9.TabIndex = 8;
            this.box9.UseVisualStyleBackColor = true;
            this.box9.Click += new System.EventHandler(this.box_Click);
            // 
            // box8
            // 
            this.box8.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.box8.Location = new System.Drawing.Point(124, 224);
            this.box8.Name = "box8";
            this.box8.Size = new System.Drawing.Size(103, 98);
            this.box8.TabIndex = 7;
            this.box8.UseVisualStyleBackColor = true;
            this.box8.Click += new System.EventHandler(this.box_Click);
            // 
            // box7
            // 
            this.box7.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.box7.Location = new System.Drawing.Point(15, 224);
            this.box7.Name = "box7";
            this.box7.Size = new System.Drawing.Size(103, 98);
            this.box7.TabIndex = 6;
            this.box7.UseVisualStyleBackColor = true;
            this.box7.Click += new System.EventHandler(this.box_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(16, 367);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 9;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ExitBtn.Location = new System.Drawing.Point(233, 367);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 10;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(349, 415);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.box9);
            this.Controls.Add(this.box8);
            this.Controls.Add(this.box7);
            this.Controls.Add(this.box6);
            this.Controls.Add(this.box5);
            this.Controls.Add(this.box4);
            this.Controls.Add(this.box3);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Name = "Form1";
            this.Text = "TIC TAC TOE";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button box1;
        private System.Windows.Forms.Button box2;
        private System.Windows.Forms.Button box3;
        private System.Windows.Forms.Button box6;
        private System.Windows.Forms.Button box5;
        private System.Windows.Forms.Button box4;
        private System.Windows.Forms.Button box9;
        private System.Windows.Forms.Button box8;
        private System.Windows.Forms.Button box7;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}

