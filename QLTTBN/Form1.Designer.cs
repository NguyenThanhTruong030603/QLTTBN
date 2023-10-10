
namespace QLTTBN
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbBNLNT = new System.Windows.Forms.ComboBox();
            this.CBTT = new System.Windows.Forms.ComboBox();
            this.ghichu = new System.Windows.Forms.TextBox();
            this.tenBN = new System.Windows.Forms.TextBox();
            this.maBN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvBN = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.them = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBN)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBNLNT);
            this.groupBox1.Controls.Add(this.CBTT);
            this.groupBox1.Controls.Add(this.ghichu);
            this.groupBox1.Controls.Add(this.tenBN);
            this.groupBox1.Controls.Add(this.maBN);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bênh nhân";
            // 
            // cbBNLNT
            // 
            this.cbBNLNT.FormattingEnabled = true;
            this.cbBNLNT.Items.AddRange(new object[] {
            ""});
            this.cbBNLNT.Location = new System.Drawing.Point(86, 280);
            this.cbBNLNT.Name = "cbBNLNT";
            this.cbBNLNT.Size = new System.Drawing.Size(136, 21);
            this.cbBNLNT.TabIndex = 4;
            // 
            // CBTT
            // 
            this.CBTT.FormattingEnabled = true;
            this.CBTT.Location = new System.Drawing.Point(86, 134);
            this.CBTT.Name = "CBTT";
            this.CBTT.Size = new System.Drawing.Size(121, 21);
            this.CBTT.TabIndex = 4;
            // 
            // ghichu
            // 
            this.ghichu.Location = new System.Drawing.Point(86, 181);
            this.ghichu.Multiline = true;
            this.ghichu.Name = "ghichu";
            this.ghichu.Size = new System.Drawing.Size(169, 88);
            this.ghichu.TabIndex = 3;
            // 
            // tenBN
            // 
            this.tenBN.Location = new System.Drawing.Point(86, 86);
            this.tenBN.Name = "tenBN";
            this.tenBN.Size = new System.Drawing.Size(121, 20);
            this.tenBN.TabIndex = 3;
            // 
            // maBN
            // 
            this.maBN.Location = new System.Drawing.Point(86, 38);
            this.maBN.Name = "maBN";
            this.maBN.Size = new System.Drawing.Size(121, 20);
            this.maBN.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lây nhiễm từ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ghi Chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tình Trạng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên BN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma BN";
            // 
            // dgvBN
            // 
            this.dgvBN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvBN.Location = new System.Drawing.Point(375, 110);
            this.dgvBN.Name = "dgvBN";
            this.dgvBN.Size = new System.Drawing.Size(509, 300);
            this.dgvBN.TabIndex = 1;
            this.dgvBN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBN_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã BN";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên BN";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tình Trạng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "F";
            this.Column4.Name = "Column4";
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(48, 417);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(75, 21);
            this.them.TabIndex = 2;
            this.them.Text = "Cập nhật";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(200, 417);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 21);
            this.xoa.TabIndex = 2;
            this.xoa.Text = "Thoát";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(193, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(602, 46);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thông tin ca bệnh Covid19 tại Việt Nam";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýKhoaToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // quảnLýKhoaToolStripMenuItem
            // 
            this.quảnLýKhoaToolStripMenuItem.Name = "quảnLýKhoaToolStripMenuItem";
            this.quảnLýKhoaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.quảnLýKhoaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.quảnLýKhoaToolStripMenuItem.Text = "Truy Vết";
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.tìmKiếmToolStripMenuItem.Text = "Thoát";
            this.tìmKiếmToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvBN);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBN)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox ghichu;
        private System.Windows.Forms.TextBox tenBN;
        private System.Windows.Forms.TextBox maBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBN;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBTT;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBNLNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

