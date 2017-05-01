namespace Graficcc
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКруговуюДиаграммуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьГистограммуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьЗеркальнуюГистограммуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьДиаграммуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelDiagramm = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelRefHis = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxDashH = new System.Windows.Forms.CheckBox();
            this.checkBoxHistogram = new System.Windows.Forms.CheckBox();
            this.dataGridViewHistogramm = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHistogramm = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPD = new System.Windows.Forms.Panel();
            this.textBoxP5 = new System.Windows.Forms.TextBox();
            this.textBoxP4 = new System.Windows.Forms.TextBox();
            this.textBoxP3 = new System.Windows.Forms.TextBox();
            this.textBoxP2 = new System.Windows.Forms.TextBox();
            this.textBoxP1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistogramm)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1292, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьКруговуюДиаграммуToolStripMenuItem,
            this.сохранитьГистограммуToolStripMenuItem,
            this.сохранитьЗеркальнуюГистограммуToolStripMenuItem,
            this.сохранитьДиаграммуToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьКруговуюДиаграммуToolStripMenuItem
            // 
            this.сохранитьКруговуюДиаграммуToolStripMenuItem.Name = "сохранитьКруговуюДиаграммуToolStripMenuItem";
            this.сохранитьКруговуюДиаграммуToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.сохранитьКруговуюДиаграммуToolStripMenuItem.Text = "... круговую диаграмму";
            this.сохранитьКруговуюДиаграммуToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКруговуюДиаграммуToolStripMenuItem_Click);
            // 
            // сохранитьГистограммуToolStripMenuItem
            // 
            this.сохранитьГистограммуToolStripMenuItem.Name = "сохранитьГистограммуToolStripMenuItem";
            this.сохранитьГистограммуToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.сохранитьГистограммуToolStripMenuItem.Text = "...гистограмму";
            this.сохранитьГистограммуToolStripMenuItem.Click += new System.EventHandler(this.сохранитьГистограммуToolStripMenuItem_Click);
            // 
            // сохранитьЗеркальнуюГистограммуToolStripMenuItem
            // 
            this.сохранитьЗеркальнуюГистограммуToolStripMenuItem.Name = "сохранитьЗеркальнуюГистограммуToolStripMenuItem";
            this.сохранитьЗеркальнуюГистограммуToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.сохранитьЗеркальнуюГистограммуToolStripMenuItem.Text = "...зеркальную гистограмму";
            this.сохранитьЗеркальнуюГистограммуToolStripMenuItem.Click += new System.EventHandler(this.сохранитьЗеркальнуюГистограммуToolStripMenuItem_Click);
            // 
            // сохранитьДиаграммуToolStripMenuItem
            // 
            this.сохранитьДиаграммуToolStripMenuItem.Name = "сохранитьДиаграммуToolStripMenuItem";
            this.сохранитьДиаграммуToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.сохранитьДиаграммуToolStripMenuItem.Text = "... диаграмму";
            this.сохранитьДиаграммуToolStripMenuItem.Click += new System.EventHandler(this.сохранитьДиаграммуToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1292, 942);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.panelDiagramm);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.panelRefHis);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.checkBoxDashH);
            this.tabPage1.Controls.Add(this.checkBoxHistogram);
            this.tabPage1.Controls.Add(this.dataGridViewHistogramm);
            this.tabPage1.Controls.Add(this.panelHistogramm);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.panelPD);
            this.tabPage1.Controls.Add(this.textBoxP5);
            this.tabPage1.Controls.Add(this.textBoxP4);
            this.tabPage1.Controls.Add(this.textBoxP3);
            this.tabPage1.Controls.Add(this.textBoxP2);
            this.tabPage1.Controls.Add(this.textBoxP1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1284, 916);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Диаграммы";
            // 
            // panelDiagramm
            // 
            this.panelDiagramm.Location = new System.Drawing.Point(27, 347);
            this.panelDiagramm.Name = "panelDiagramm";
            this.panelDiagramm.Size = new System.Drawing.Size(889, 474);
            this.panelDiagramm.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(588, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "Данные гистограмм";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(23, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Данные";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(990, 846);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 28);
            this.label8.TabIndex = 17;
            this.label8.Text = "Зеркальная Гистограмма";
            // 
            // panelRefHis
            // 
            this.panelRefHis.Location = new System.Drawing.Point(988, 495);
            this.panelRefHis.Name = "panelRefHis";
            this.panelRefHis.Size = new System.Drawing.Size(889, 327);
            this.panelRefHis.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(990, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 28);
            this.label7.TabIndex = 15;
            this.label7.Text = "Гистограмма";
            // 
            // checkBoxDashH
            // 
            this.checkBoxDashH.AutoSize = true;
            this.checkBoxDashH.Location = new System.Drawing.Point(592, 283);
            this.checkBoxDashH.Name = "checkBoxDashH";
            this.checkBoxDashH.Size = new System.Drawing.Size(56, 17);
            this.checkBoxDashH.TabIndex = 14;
            this.checkBoxDashH.Text = "Сетка";
            this.checkBoxDashH.UseVisualStyleBackColor = true;
            this.checkBoxDashH.CheckedChanged += new System.EventHandler(this.checkBoxDashH_CheckedChanged);
            // 
            // checkBoxHistogram
            // 
            this.checkBoxHistogram.AutoSize = true;
            this.checkBoxHistogram.Location = new System.Drawing.Point(592, 247);
            this.checkBoxHistogram.Name = "checkBoxHistogram";
            this.checkBoxHistogram.Size = new System.Drawing.Size(110, 17);
            this.checkBoxHistogram.TabIndex = 2;
            this.checkBoxHistogram.Text = "Подпись данных";
            this.checkBoxHistogram.UseVisualStyleBackColor = true;
            this.checkBoxHistogram.CheckedChanged += new System.EventHandler(this.checkBoxHistogram_CheckedChanged);
            // 
            // dataGridViewHistogramm
            // 
            this.dataGridViewHistogramm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHistogramm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistogramm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewHistogramm.Location = new System.Drawing.Point(592, 64);
            this.dataGridViewHistogramm.Name = "dataGridViewHistogramm";
            this.dataGridViewHistogramm.Size = new System.Drawing.Size(243, 150);
            this.dataGridViewHistogramm.TabIndex = 0;
            this.dataGridViewHistogramm.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHistogramm_CellValidated);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Значение";
            this.Column2.Name = "Column2";
            // 
            // panelHistogramm
            // 
            this.panelHistogramm.BackColor = System.Drawing.Color.LightGray;
            this.panelHistogramm.Location = new System.Drawing.Point(988, 163);
            this.panelHistogramm.Name = "panelHistogramm";
            this.panelHistogramm.Size = new System.Drawing.Size(889, 327);
            this.panelHistogramm.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(109, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(109, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(109, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(109, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(109, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(153, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Круговая диаграмма";
            // 
            // panelPD
            // 
            this.panelPD.BackColor = System.Drawing.Color.LightGray;
            this.panelPD.Location = new System.Drawing.Point(155, 62);
            this.panelPD.Name = "panelPD";
            this.panelPD.Size = new System.Drawing.Size(200, 200);
            this.panelPD.TabIndex = 7;
            // 
            // textBoxP5
            // 
            this.textBoxP5.Location = new System.Drawing.Point(27, 262);
            this.textBoxP5.Name = "textBoxP5";
            this.textBoxP5.Size = new System.Drawing.Size(67, 20);
            this.textBoxP5.TabIndex = 6;
            this.textBoxP5.TextChanged += new System.EventHandler(this.GetNumber);
            // 
            // textBoxP4
            // 
            this.textBoxP4.Location = new System.Drawing.Point(27, 210);
            this.textBoxP4.Name = "textBoxP4";
            this.textBoxP4.Size = new System.Drawing.Size(67, 20);
            this.textBoxP4.TabIndex = 5;
            this.textBoxP4.TextChanged += new System.EventHandler(this.GetNumber);
            // 
            // textBoxP3
            // 
            this.textBoxP3.Location = new System.Drawing.Point(27, 160);
            this.textBoxP3.Name = "textBoxP3";
            this.textBoxP3.Size = new System.Drawing.Size(67, 20);
            this.textBoxP3.TabIndex = 4;
            this.textBoxP3.TextChanged += new System.EventHandler(this.GetNumber);
            // 
            // textBoxP2
            // 
            this.textBoxP2.Location = new System.Drawing.Point(27, 109);
            this.textBoxP2.Name = "textBoxP2";
            this.textBoxP2.Size = new System.Drawing.Size(67, 20);
            this.textBoxP2.TabIndex = 3;
            this.textBoxP2.TextChanged += new System.EventHandler(this.GetNumber);
            // 
            // textBoxP1
            // 
            this.textBoxP1.Location = new System.Drawing.Point(27, 64);
            this.textBoxP1.Name = "textBoxP1";
            this.textBoxP1.Size = new System.Drawing.Size(67, 20);
            this.textBoxP1.TabIndex = 2;
            this.textBoxP1.TextChanged += new System.EventHandler(this.GetNumber);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1284, 916);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1284, 916);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1284, 916);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(22, 846);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 28);
            this.label11.TabIndex = 21;
            this.label11.Text = "Диаграмма";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1292, 966);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "!?";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistogramm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxP5;
        private System.Windows.Forms.TextBox textBoxP4;
        private System.Windows.Forms.TextBox textBoxP3;
        private System.Windows.Forms.TextBox textBoxP2;
        private System.Windows.Forms.TextBox textBoxP1;
        private System.Windows.Forms.Panel panelPD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКруговуюДиаграммуToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelHistogramm;
        private System.Windows.Forms.DataGridView dataGridViewHistogramm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.CheckBox checkBoxHistogram;
        private System.Windows.Forms.ToolStripMenuItem сохранитьГистограммуToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxDashH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelRefHis;
        private System.Windows.Forms.ToolStripMenuItem сохранитьЗеркальнуюГистограммуToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelDiagramm;
        private System.Windows.Forms.ToolStripMenuItem сохранитьДиаграммуToolStripMenuItem;
        private System.Windows.Forms.Label label11;
    }
}

