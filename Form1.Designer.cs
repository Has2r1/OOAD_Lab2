namespace AdapterPattern
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edSeconds = new System.Windows.Forms.NumericUpDown();
            this.edMinutes = new System.Windows.Forms.NumericUpDown();
            this.edHours = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btShowTime = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edHours)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(294, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Аналоговые часы";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.edSeconds);
            this.panel1.Controls.Add(this.edMinutes);
            this.panel1.Controls.Add(this.edHours);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(21, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 230);
            this.panel1.TabIndex = 1;
            // 
            // edSeconds
            // 
            this.edSeconds.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.edSeconds.Location = new System.Drawing.Point(139, 187);
            this.edSeconds.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.edSeconds.Name = "edSeconds";
            this.edSeconds.Size = new System.Drawing.Size(87, 20);
            this.edSeconds.TabIndex = 6;
            this.edSeconds.ValueChanged += new System.EventHandler(this.edSeconds_ValueChanged);
            // 
            // edMinutes
            // 
            this.edMinutes.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.edMinutes.Location = new System.Drawing.Point(139, 142);
            this.edMinutes.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.edMinutes.Name = "edMinutes";
            this.edMinutes.Size = new System.Drawing.Size(87, 20);
            this.edMinutes.TabIndex = 5;
            this.edMinutes.ValueChanged += new System.EventHandler(this.edMinutes_ValueChanged);
            // 
            // edHours
            // 
            this.edHours.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.edHours.Location = new System.Drawing.Point(139, 97);
            this.edHours.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.edHours.Name = "edHours";
            this.edHours.Size = new System.Drawing.Size(87, 20);
            this.edHours.TabIndex = 2;
            this.edHours.ValueChanged += new System.EventHandler(this.edHours_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(16, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Секунды:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Минуты:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Часы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Установить время:";
            // 
            // btShowTime
            // 
            this.btShowTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btShowTime.Location = new System.Drawing.Point(61, 322);
            this.btShowTime.Name = "btShowTime";
            this.btShowTime.Size = new System.Drawing.Size(169, 53);
            this.btShowTime.TabIndex = 7;
            this.btShowTime.Text = "Показать время";
            this.btShowTime.UseVisualStyleBackColor = true;
            this.btShowTime.Click += new System.EventHandler(this.btShowTime_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(491, 83);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(95, 29);
            this.timeLabel.TabIndex = 8;
            this.timeLabel.Text = "Время:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(17, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 42);
            this.label6.TabIndex = 9;
            this.label6.Text = "(угол наклона соответствующих стрелок)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.btShowTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown edSeconds;
        private System.Windows.Forms.NumericUpDown edMinutes;
        private System.Windows.Forms.NumericUpDown edHours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btShowTime;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label6;
    }
}

