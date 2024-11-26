namespace A3_Card
{
    partial class Card
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            pictureBox1 = new PictureBox();
            lblAge = new Label();
            lblAlbum = new Label();
            lblGroupName = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = SystemColors.Window;
            lblName.Location = new Point(273, 21);
            lblName.Name = "lblName";
            lblName.Size = new Size(161, 48);
            lblName.TabIndex = 1;
            lblName.Text = "lblName";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(46, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 236);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblAge.ForeColor = SystemColors.Window;
            lblAge.Location = new Point(327, 95);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(66, 25);
            lblAge.TabIndex = 3;
            lblAge.Text = "lblAge";
            // 
            // lblAlbum
            // 
            lblAlbum.AutoSize = true;
            lblAlbum.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblAlbum.ForeColor = SystemColors.Window;
            lblAlbum.Location = new Point(401, 130);
            lblAlbum.Name = "lblAlbum";
            lblAlbum.Size = new Size(88, 25);
            lblAlbum.TabIndex = 4;
            lblAlbum.Text = "lblAlbum";
            // 
            // lblGroupName
            // 
            lblGroupName.BackColor = SystemColors.Window;
            lblGroupName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGroupName.ForeColor = SystemColors.WindowText;
            lblGroupName.Location = new Point(273, 192);
            lblGroupName.Name = "lblGroupName";
            lblGroupName.Size = new Size(223, 65);
            lblGroupName.TabIndex = 5;
            lblGroupName.Text = "lblGroupName";
            lblGroupName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 95);
            label3.Name = "label3";
            label3.Size = new Size(48, 25);
            label3.TabIndex = 8;
            label3.Text = "Age:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(283, 130);
            label4.Name = "label4";
            label4.Size = new Size(123, 25);
            label4.TabIndex = 9;
            label4.Text = "Debut Album:";
            // 
            // Card
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblGroupName);
            Controls.Add(lblAlbum);
            Controls.Add(lblAge);
            Controls.Add(pictureBox1);
            Controls.Add(lblName);
            Name = "Card";
            Size = new Size(543, 274);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblName;
        private PictureBox pictureBox1;
        private Label lblAge;
        private Label lblAlbum;
        private Label lblGroupName;
        private Label label3;
        private Label label4;
    }
}
