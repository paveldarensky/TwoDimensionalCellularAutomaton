namespace TwoDimensionalCellularAutomaton
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.button_Reset = new System.Windows.Forms.Button();
            this.textBox_Rules = new System.Windows.Forms.TextBox();
            this.label_Size = new System.Windows.Forms.Label();
            this.textBox_Size = new System.Windows.Forms.TextBox();
            this.button_StartStop = new System.Windows.Forms.Button();
            this.label_TimeSimulationValue = new System.Windows.Forms.Label();
            this.label_NumberPopulationValue = new System.Windows.Forms.Label();
            this.label_TimeSimulation = new System.Windows.Forms.Label();
            this.label_NumberPopulation = new System.Windows.Forms.Label();
            this.label_Density = new System.Windows.Forms.Label();
            this.trackBar_Density = new System.Windows.Forms.TrackBar();
            this.dataGridView_Space = new System.Windows.Forms.DataGridView();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Density)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Space)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.button_Reset);
            this.splitContainer.Panel1.Controls.Add(this.textBox_Rules);
            this.splitContainer.Panel1.Controls.Add(this.label_Size);
            this.splitContainer.Panel1.Controls.Add(this.textBox_Size);
            this.splitContainer.Panel1.Controls.Add(this.button_StartStop);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.label_TimeSimulationValue);
            this.splitContainer.Panel2.Controls.Add(this.label_NumberPopulationValue);
            this.splitContainer.Panel2.Controls.Add(this.label_TimeSimulation);
            this.splitContainer.Panel2.Controls.Add(this.label_NumberPopulation);
            this.splitContainer.Panel2.Controls.Add(this.label_Density);
            this.splitContainer.Panel2.Controls.Add(this.trackBar_Density);
            this.splitContainer.Panel2.Controls.Add(this.dataGridView_Space);
            this.splitContainer.Size = new System.Drawing.Size(1184, 761);
            this.splitContainer.SplitterDistance = 553;
            this.splitContainer.TabIndex = 0;
            // 
            // button_Reset
            // 
            this.button_Reset.AutoSize = true;
            this.button_Reset.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Reset.Location = new System.Drawing.Point(332, 27);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(42, 41);
            this.button_Reset.TabIndex = 4;
            this.button_Reset.Text = "⟲";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // textBox_Rules
            // 
            this.textBox_Rules.Enabled = false;
            this.textBox_Rules.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Rules.Location = new System.Drawing.Point(14, 174);
            this.textBox_Rules.Multiline = true;
            this.textBox_Rules.Name = "textBox_Rules";
            this.textBox_Rules.ReadOnly = true;
            this.textBox_Rules.Size = new System.Drawing.Size(526, 575);
            this.textBox_Rules.TabIndex = 3;
            this.textBox_Rules.Text = resources.GetString("textBox_Rules.Text");
            // 
            // label_Size
            // 
            this.label_Size.AutoSize = true;
            this.label_Size.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Size.Location = new System.Drawing.Point(177, 106);
            this.label_Size.Name = "label_Size";
            this.label_Size.Size = new System.Drawing.Size(164, 21);
            this.label_Size.TabIndex = 2;
            this.label_Size.Text = "Размер поля (n x n)";
            // 
            // textBox_Size
            // 
            this.textBox_Size.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Size.Location = new System.Drawing.Point(209, 130);
            this.textBox_Size.Name = "textBox_Size";
            this.textBox_Size.Size = new System.Drawing.Size(100, 29);
            this.textBox_Size.TabIndex = 1;
            this.textBox_Size.Text = "10";
            this.textBox_Size.TextChanged += new System.EventHandler(this.textBox_Size_TextChanged);
            // 
            // button_StartStop
            // 
            this.button_StartStop.AutoSize = true;
            this.button_StartStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_StartStop.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_StartStop.Location = new System.Drawing.Point(194, 31);
            this.button_StartStop.Name = "button_StartStop";
            this.button_StartStop.Size = new System.Drawing.Size(132, 33);
            this.button_StartStop.TabIndex = 0;
            this.button_StartStop.Text = "Старт / Стоп";
            this.button_StartStop.UseVisualStyleBackColor = true;
            this.button_StartStop.Click += new System.EventHandler(this.button_StartStop_Click);
            // 
            // label_TimeSimulationValue
            // 
            this.label_TimeSimulationValue.AutoSize = true;
            this.label_TimeSimulationValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TimeSimulationValue.Location = new System.Drawing.Point(214, 707);
            this.label_TimeSimulationValue.Name = "label_TimeSimulationValue";
            this.label_TimeSimulationValue.Size = new System.Drawing.Size(19, 21);
            this.label_TimeSimulationValue.TabIndex = 8;
            this.label_TimeSimulationValue.Text = "0";
            // 
            // label_NumberPopulationValue
            // 
            this.label_NumberPopulationValue.AutoSize = true;
            this.label_NumberPopulationValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_NumberPopulationValue.Location = new System.Drawing.Point(157, 660);
            this.label_NumberPopulationValue.Name = "label_NumberPopulationValue";
            this.label_NumberPopulationValue.Size = new System.Drawing.Size(19, 21);
            this.label_NumberPopulationValue.TabIndex = 7;
            this.label_NumberPopulationValue.Text = "0";
            // 
            // label_TimeSimulation
            // 
            this.label_TimeSimulation.AutoSize = true;
            this.label_TimeSimulation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TimeSimulation.Location = new System.Drawing.Point(51, 707);
            this.label_TimeSimulation.Name = "label_TimeSimulation";
            this.label_TimeSimulation.Size = new System.Drawing.Size(157, 21);
            this.label_TimeSimulation.TabIndex = 6;
            this.label_TimeSimulation.Text = "Время симуляции:";
            // 
            // label_NumberPopulation
            // 
            this.label_NumberPopulation.AutoSize = true;
            this.label_NumberPopulation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_NumberPopulation.Location = new System.Drawing.Point(51, 660);
            this.label_NumberPopulation.Name = "label_NumberPopulation";
            this.label_NumberPopulation.Size = new System.Drawing.Size(100, 21);
            this.label_NumberPopulation.TabIndex = 5;
            this.label_NumberPopulation.Text = "Поколение:";
            // 
            // label_Density
            // 
            this.label_Density.AutoSize = true;
            this.label_Density.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Density.Location = new System.Drawing.Point(195, 599);
            this.label_Density.Name = "label_Density";
            this.label_Density.Size = new System.Drawing.Size(240, 21);
            this.label_Density.TabIndex = 4;
            this.label_Density.Text = "Плотность населения клеток";
            // 
            // trackBar_Density
            // 
            this.trackBar_Density.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar_Density.Location = new System.Drawing.Point(104, 551);
            this.trackBar_Density.Maximum = 100;
            this.trackBar_Density.Name = "trackBar_Density";
            this.trackBar_Density.Size = new System.Drawing.Size(420, 45);
            this.trackBar_Density.TabIndex = 1;
            this.trackBar_Density.Scroll += new System.EventHandler(this.trackBar_Density_Scroll);
            // 
            // dataGridView_Space
            // 
            this.dataGridView_Space.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Space.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Space.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Space.Enabled = false;
            this.dataGridView_Space.GridColor = System.Drawing.Color.Black;
            this.dataGridView_Space.Location = new System.Drawing.Point(55, 12);
            this.dataGridView_Space.Name = "dataGridView_Space";
            this.dataGridView_Space.ReadOnly = true;
            this.dataGridView_Space.RowHeadersVisible = false;
            this.dataGridView_Space.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_Space.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView_Space.Size = new System.Drawing.Size(520, 520);
            this.dataGridView_Space.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_main";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Density)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Space)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TextBox textBox_Rules;
        private System.Windows.Forms.Label label_Size;
        private System.Windows.Forms.TextBox textBox_Size;
        private System.Windows.Forms.Button button_StartStop;
        private System.Windows.Forms.DataGridView dataGridView_Space;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TrackBar trackBar_Density;
        private System.Windows.Forms.Label label_Density;
        private System.Windows.Forms.Label label_TimeSimulationValue;
        private System.Windows.Forms.Label label_NumberPopulationValue;
        private System.Windows.Forms.Label label_TimeSimulation;
        private System.Windows.Forms.Label label_NumberPopulation;
        private System.Windows.Forms.Button button_Reset;
    }
}

