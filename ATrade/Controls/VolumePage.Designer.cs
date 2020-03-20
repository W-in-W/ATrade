namespace ATrade.Controls
{
    partial class VolumePage
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.futuresBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pointsValueNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.stopLossValueNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.volumeValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pointsValueNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopLossValueNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Бумага:";
            // 
            // futuresBox
            // 
            this.futuresBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.futuresBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.futuresBox.FormattingEnabled = true;
            this.futuresBox.Location = new System.Drawing.Point(88, 26);
            this.futuresBox.Name = "futuresBox";
            this.futuresBox.Size = new System.Drawing.Size(54, 29);
            this.futuresBox.TabIndex = 1;
            this.futuresBox.SelectedIndexChanged += new System.EventHandler(this.futuresBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(163, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пункты:";
            // 
            // pointsValueNumeric
            // 
            this.pointsValueNumeric.DecimalPlaces = 2;
            this.pointsValueNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsValueNumeric.Location = new System.Drawing.Point(243, 29);
            this.pointsValueNumeric.Name = "pointsValueNumeric";
            this.pointsValueNumeric.Size = new System.Drawing.Size(71, 24);
            this.pointsValueNumeric.TabIndex = 3;
            this.pointsValueNumeric.ValueChanged += new System.EventHandler(this.pointsValueNumeric_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "S/L (в руб):";
            // 
            // stopLossValueNumeric
            // 
            this.stopLossValueNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopLossValueNumeric.Location = new System.Drawing.Point(114, 102);
            this.stopLossValueNumeric.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.stopLossValueNumeric.Name = "stopLossValueNumeric";
            this.stopLossValueNumeric.Size = new System.Drawing.Size(80, 24);
            this.stopLossValueNumeric.TabIndex = 5;
            this.stopLossValueNumeric.ValueChanged += new System.EventHandler(this.stopLossValueNumeric_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(212, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Лоты:";
            // 
            // volumeValueLabel
            // 
            this.volumeValueLabel.AutoSize = true;
            this.volumeValueLabel.BackColor = System.Drawing.Color.White;
            this.volumeValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeValueLabel.Location = new System.Drawing.Point(274, 103);
            this.volumeValueLabel.Name = "volumeValueLabel";
            this.volumeValueLabel.Size = new System.Drawing.Size(13, 20);
            this.volumeValueLabel.TabIndex = 7;
            this.volumeValueLabel.Text = " ";
            // 
            // VolumePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.volumeValueLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stopLossValueNumeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pointsValueNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.futuresBox);
            this.Controls.Add(this.label1);
            this.Name = "VolumePage";
            this.Size = new System.Drawing.Size(366, 152);
            ((System.ComponentModel.ISupportInitialize)(this.pointsValueNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopLossValueNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox futuresBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown pointsValueNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown stopLossValueNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label volumeValueLabel;
    }
}
