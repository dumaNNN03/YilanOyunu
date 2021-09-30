
namespace Yılanoyunu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel = new System.Windows.Forms.Panel();
            this.bbaslat = new System.Windows.Forms.Button();
            this.bdur = new System.Windows.Forms.Button();
            this.bnew = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.yukarı = new System.Windows.Forms.PictureBox();
            this.sag = new System.Windows.Forms.PictureBox();
            this.assa = new System.Windows.Forms.PictureBox();
            this.sol = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bultra = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yukarı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sol)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(420, 420);
            this.panel.TabIndex = 0;
            // 
            // bbaslat
            // 
            this.bbaslat.BackColor = System.Drawing.Color.LightGray;
            this.bbaslat.FlatAppearance.BorderSize = 0;
            this.bbaslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bbaslat.Location = new System.Drawing.Point(458, 12);
            this.bbaslat.Name = "bbaslat";
            this.bbaslat.Size = new System.Drawing.Size(70, 30);
            this.bbaslat.TabIndex = 1;
            this.bbaslat.Text = "BAŞLAT";
            this.bbaslat.UseVisualStyleBackColor = false;
            this.bbaslat.Click += new System.EventHandler(this.bbaslat_Click);
            // 
            // bdur
            // 
            this.bdur.BackColor = System.Drawing.Color.LightGray;
            this.bdur.FlatAppearance.BorderSize = 0;
            this.bdur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bdur.Location = new System.Drawing.Point(538, 12);
            this.bdur.Name = "bdur";
            this.bdur.Size = new System.Drawing.Size(70, 30);
            this.bdur.TabIndex = 2;
            this.bdur.Text = "DURDUR";
            this.bdur.UseVisualStyleBackColor = false;
            this.bdur.Click += new System.EventHandler(this.bdur_Click);
            // 
            // bnew
            // 
            this.bnew.BackColor = System.Drawing.Color.LightGray;
            this.bnew.FlatAppearance.BorderSize = 0;
            this.bnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnew.Location = new System.Drawing.Point(458, 56);
            this.bnew.Name = "bnew";
            this.bnew.Size = new System.Drawing.Size(150, 30);
            this.bnew.TabIndex = 3;
            this.bnew.Text = "YENİ OYUN";
            this.bnew.UseVisualStyleBackColor = false;
            this.bnew.Click += new System.EventHandler(this.bnew_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.yukarı, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.sag, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.assa, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.sol, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(458, 92);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 150);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // yukarı
            // 
            this.yukarı.Image = ((System.Drawing.Image)(resources.GetObject("yukarı.Image")));
            this.yukarı.Location = new System.Drawing.Point(53, 3);
            this.yukarı.Name = "yukarı";
            this.yukarı.Size = new System.Drawing.Size(43, 43);
            this.yukarı.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yukarı.TabIndex = 0;
            this.yukarı.TabStop = false;
            this.yukarı.Click += new System.EventHandler(this.yukarı_Click);
            // 
            // sag
            // 
            this.sag.Image = ((System.Drawing.Image)(resources.GetObject("sag.Image")));
            this.sag.Location = new System.Drawing.Point(103, 53);
            this.sag.Name = "sag";
            this.sag.Size = new System.Drawing.Size(44, 43);
            this.sag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sag.TabIndex = 1;
            this.sag.TabStop = false;
            this.sag.Click += new System.EventHandler(this.sag_Click);
            // 
            // assa
            // 
            this.assa.Image = ((System.Drawing.Image)(resources.GetObject("assa.Image")));
            this.assa.Location = new System.Drawing.Point(53, 103);
            this.assa.Name = "assa";
            this.assa.Size = new System.Drawing.Size(43, 44);
            this.assa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.assa.TabIndex = 2;
            this.assa.TabStop = false;
            this.assa.Click += new System.EventHandler(this.assa_Click);
            // 
            // sol
            // 
            this.sol.Image = ((System.Drawing.Image)(resources.GetObject("sol.Image")));
            this.sol.Location = new System.Drawing.Point(3, 53);
            this.sol.Name = "sol";
            this.sol.Size = new System.Drawing.Size(43, 43);
            this.sol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sol.TabIndex = 3;
            this.sol.TabStop = false;
            this.sol.Click += new System.EventHandler(this.sol_Click);
            // 
            // score
            // 
            this.score.BackColor = System.Drawing.Color.Lime;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.score.Location = new System.Drawing.Point(455, 402);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(153, 30);
            this.score.TabIndex = 5;
            this.score.Text = "0";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bultra
            // 
            this.bultra.BackColor = System.Drawing.Color.LightGray;
            this.bultra.FlatAppearance.BorderSize = 0;
            this.bultra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bultra.Location = new System.Drawing.Point(458, 248);
            this.bultra.Name = "bultra";
            this.bultra.Size = new System.Drawing.Size(150, 30);
            this.bultra.TabIndex = 6;
            this.bultra.Text = "Çok Hızlı Mod";
            this.bultra.UseVisualStyleBackColor = false;
            this.bultra.Click += new System.EventHandler(this.bultra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 440);
            this.Controls.Add(this.bultra);
            this.Controls.Add(this.score);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.bnew);
            this.Controls.Add(this.bdur);
            this.Controls.Add(this.bbaslat);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Yılan Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.yukarı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button bbaslat;
        private System.Windows.Forms.Button bdur;
        private System.Windows.Forms.Button bnew;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox yukarı;
        private System.Windows.Forms.PictureBox sag;
        private System.Windows.Forms.PictureBox assa;
        private System.Windows.Forms.PictureBox sol;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bultra;
    }
}

