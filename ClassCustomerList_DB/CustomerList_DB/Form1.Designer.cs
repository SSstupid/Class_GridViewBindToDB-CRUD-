
namespace CustomerList_DB
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SaveIf = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.FirstName1 = new System.Windows.Forms.Label();
            this.LastName1 = new System.Windows.Forms.Label();
            this.Birth1 = new System.Windows.Forms.Label();
            this.Address1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Birth = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteDB = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NoLa = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(781, 567);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // SaveIf
            // 
            this.SaveIf.Location = new System.Drawing.Point(234, 488);
            this.SaveIf.Name = "SaveIf";
            this.SaveIf.Size = new System.Drawing.Size(75, 26);
            this.SaveIf.TabIndex = 5;
            this.SaveIf.Text = "Save";
            this.SaveIf.UseVisualStyleBackColor = true;
            this.SaveIf.Click += new System.EventHandler(this.button1_Click);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(110, 81);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(100, 22);
            this.FirstName.TabIndex = 0;
            // 
            // FirstName1
            // 
            this.FirstName1.AutoSize = true;
            this.FirstName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName1.Location = new System.Drawing.Point(16, 81);
            this.FirstName1.Name = "FirstName1";
            this.FirstName1.Size = new System.Drawing.Size(87, 20);
            this.FirstName1.TabIndex = 4;
            this.FirstName1.Text = "FirstName";
            // 
            // LastName1
            // 
            this.LastName1.AutoSize = true;
            this.LastName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName1.Location = new System.Drawing.Point(216, 81);
            this.LastName1.Name = "LastName1";
            this.LastName1.Size = new System.Drawing.Size(86, 20);
            this.LastName1.TabIndex = 5;
            this.LastName1.Text = "LastName";
            // 
            // Birth1
            // 
            this.Birth1.AutoSize = true;
            this.Birth1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birth1.Location = new System.Drawing.Point(16, 115);
            this.Birth1.Name = "Birth1";
            this.Birth1.Size = new System.Drawing.Size(71, 20);
            this.Birth1.TabIndex = 6;
            this.Birth1.Text = "Birthday";
            // 
            // Address1
            // 
            this.Address1.AutoSize = true;
            this.Address1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address1.Location = new System.Drawing.Point(218, 114);
            this.Address1.Name = "Address1";
            this.Address1.Size = new System.Drawing.Size(71, 20);
            this.Address1.TabIndex = 7;
            this.Address1.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(306, 79);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(115, 22);
            this.LastName.TabIndex = 1;
            // 
            // Birth
            // 
            this.Birth.Location = new System.Drawing.Point(110, 112);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(100, 22);
            this.Birth.TabIndex = 2;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(306, 113);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(115, 22);
            this.Address.TabIndex = 3;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(20, 183);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(392, 291);
            this.Description.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DeleteDB
            // 
            this.DeleteDB.Location = new System.Drawing.Point(234, 530);
            this.DeleteDB.Name = "DeleteDB";
            this.DeleteDB.Size = new System.Drawing.Size(75, 26);
            this.DeleteDB.TabIndex = 12;
            this.DeleteDB.Text = "Delete";
            this.DeleteDB.UseVisualStyleBackColor = true;
            this.DeleteDB.Click += new System.EventHandler(this.DeleteDB_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 530);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 13;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NoLa
            // 
            this.NoLa.AutoSize = true;
            this.NoLa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoLa.Location = new System.Drawing.Point(16, 48);
            this.NoLa.Name = "NoLa";
            this.NoLa.Size = new System.Drawing.Size(40, 20);
            this.NoLa.TabIndex = 14;
            this.NoLa.Text = "No :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(64, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 22);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(16, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 28);
            this.textBox2.TabIndex = 16;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.NoLa);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.DeleteDB);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Description);
            this.panel1.Controls.Add(this.Address);
            this.panel1.Controls.Add(this.Birth);
            this.panel1.Controls.Add(this.LastName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Address1);
            this.panel1.Controls.Add(this.Birth1);
            this.panel1.Controls.Add(this.LastName1);
            this.panel1.Controls.Add(this.FirstName1);
            this.panel1.Controls.Add(this.FirstName);
            this.panel1.Controls.Add(this.SaveIf);
            this.panel1.Location = new System.Drawing.Point(788, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 567);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::CustomerList_DB.Properties.Resources.img;
            this.pictureBox1.Location = new System.Drawing.Point(257, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1223, 31);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contectToolStripMenuItem
            // 
            this.contectToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contectToolStripMenuItem.Name = "contectToolStripMenuItem";
            this.contectToolStripMenuItem.Size = new System.Drawing.Size(84, 27);
            this.contectToolStripMenuItem.Text = "Contact";
            this.contectToolStripMenuItem.Click += new System.EventHandler(this.contectToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CusListDB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SaveIf;
        private System.Windows.Forms.Label FirstName1;
        private System.Windows.Forms.Label LastName1;
        private System.Windows.Forms.Label Birth1;
        private System.Windows.Forms.Label Address1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Birth;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DeleteDB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label NoLa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contectToolStripMenuItem;
    }
}

