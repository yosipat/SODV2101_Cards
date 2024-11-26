namespace A3_Card
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
            listView1 = new ListView();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            label5 = new Label();
            btnUpdate = new Button();
            btnAdd = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtGroupId = new TextBox();
            txtImg = new TextBox();
            txtAlbum = new TextBox();
            txtAge = new TextBox();
            txtName = new TextBox();
            card1 = new Card();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.Window;
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(13, 84);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(205, 315);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.ItemSelectionChanged += ListView1_SelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtGroupId);
            groupBox1.Controls.Add(txtImg);
            groupBox1.Controls.Add(txtAlbum);
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(txtName);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.WindowText;
            groupBox1.Location = new Point(804, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 379);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add/Modify";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ButtonHighlight;
            btnDelete.ForeColor = SystemColors.WindowText;
            btnDelete.Location = new Point(244, 327);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 34);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 246);
            label5.Name = "label5";
            label5.Size = new Size(98, 25);
            label5.TabIndex = 11;
            label5.Text = "Image URL";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ButtonHighlight;
            btnUpdate.ForeColor = SystemColors.WindowText;
            btnUpdate.Location = new Point(140, 327);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(98, 34);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ButtonHighlight;
            btnAdd.ForeColor = SystemColors.WindowText;
            btnAdd.Location = new Point(36, 327);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(98, 34);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(192, 110);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 8;
            label4.Text = "Group Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 178);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 7;
            label3.Text = "Album";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 110);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 6;
            label2.Text = "Age";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 42);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // txtGroupId
            // 
            txtGroupId.BackColor = SystemColors.Window;
            txtGroupId.ForeColor = SystemColors.WindowText;
            txtGroupId.Location = new Point(192, 141);
            txtGroupId.Name = "txtGroupId";
            txtGroupId.Size = new Size(150, 31);
            txtGroupId.TabIndex = 4;
            // 
            // txtImg
            // 
            txtImg.BackColor = SystemColors.Window;
            txtImg.ForeColor = SystemColors.WindowText;
            txtImg.Location = new Point(36, 277);
            txtImg.Name = "txtImg";
            txtImg.Size = new Size(306, 31);
            txtImg.TabIndex = 3;
            // 
            // txtAlbum
            // 
            txtAlbum.BackColor = SystemColors.Window;
            txtAlbum.ForeColor = SystemColors.WindowText;
            txtAlbum.Location = new Point(36, 209);
            txtAlbum.Name = "txtAlbum";
            txtAlbum.Size = new Size(306, 31);
            txtAlbum.TabIndex = 2;
            // 
            // txtAge
            // 
            txtAge.BackColor = SystemColors.Window;
            txtAge.ForeColor = SystemColors.WindowText;
            txtAge.Location = new Point(36, 141);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(150, 31);
            txtAge.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Window;
            txtName.ForeColor = SystemColors.WindowText;
            txtName.Location = new Point(36, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(306, 31);
            txtName.TabIndex = 0;
            // 
            // card1
            // 
            card1.Age = "lblAge";
            card1.Album = "lblAlbum";
            card1.GroupName = "lblGroupName";
            card1.Location = new Point(246, 125);
            card1.Name = "card1";
            card1.Size = new Size(543, 274);
            card1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.WindowText;
            label6.Location = new Point(246, 84);
            label6.Name = "label6";
            label6.Size = new Size(163, 25);
            label6.TabIndex = 12;
            label6.Text = "Artist Information";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.WindowText;
            label7.Location = new Point(69, 26);
            label7.Name = "label7";
            label7.Size = new Size(230, 32);
            label7.TabIndex = 13;
            label7.Text = "Artist Trading Cards";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1197, 422);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(card1);
            Controls.Add(groupBox1);
            Controls.Add(listView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Assignment 3 - Artist Trading Cards - 457647 - Yosita Jasamut";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private GroupBox groupBox1;
        private TextBox txtAge;
        private TextBox txtName;
        private TextBox txtImg;
        private TextBox txtAlbum;
        private Label label1;
        private TextBox txtGroupId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label5;
        private Card card1;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private Button btnDelete;
    }
}
