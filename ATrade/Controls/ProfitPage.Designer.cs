namespace ATrade.Controls
{
    partial class ProfitPage
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
            this.futuresLabel = new System.Windows.Forms.Label();
            this.futuresBox = new System.Windows.Forms.ComboBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.volumeValueNumeric = new System.Windows.Forms.NumericUpDown();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.pointsValueNumeric = new System.Windows.Forms.NumericUpDown();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.volumeValueNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsValueNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // futuresLabel
            // 
            this.futuresLabel.AutoSize = true;
            this.futuresLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.futuresLabel.Location = new System.Drawing.Point(12, 29);
            this.futuresLabel.Name = "futuresLabel";
            this.futuresLabel.Size = new System.Drawing.Size(70, 21);
            this.futuresLabel.TabIndex = 0;
            this.futuresLabel.Text = "Бумага:";
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
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLabel.Location = new System.Drawing.Point(12, 102);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(56, 21);
            this.valueLabel.TabIndex = 2;
            this.valueLabel.Text = "Лоты:";
            // 
            // volumeValueNumeric
            // 
            this.volumeValueNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeValueNumeric.Location = new System.Drawing.Point(74, 102);
            this.volumeValueNumeric.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.volumeValueNumeric.Name = "volumeValueNumeric";
            this.volumeValueNumeric.Size = new System.Drawing.Size(68, 24);
            this.volumeValueNumeric.TabIndex = 3;
            this.volumeValueNumeric.ValueChanged += new System.EventHandler(this.volumeValueNumeric_ValueChanged);
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsLabel.Location = new System.Drawing.Point(163, 29);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(74, 21);
            this.pointsLabel.TabIndex = 4;
            this.pointsLabel.Text = "Пункты:";
            // 
            // pointsValueNumeric
            // 
            this.pointsValueNumeric.DecimalPlaces = 2;
            this.pointsValueNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsValueNumeric.Location = new System.Drawing.Point(243, 29);
            this.pointsValueNumeric.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.pointsValueNumeric.Name = "pointsValueNumeric";
            this.pointsValueNumeric.Size = new System.Drawing.Size(71, 24);
            this.pointsValueNumeric.TabIndex = 5;
            this.pointsValueNumeric.ValueChanged += new System.EventHandler(this.pointsValueNumeric_ValueChanged);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(163, 102);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(88, 21);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "Прибыль:";
            // 
            // resultValueLabel
            // 
            this.resultValueLabel.AutoSize = true;
            this.resultValueLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultValueLabel.Location = new System.Drawing.Point(257, 104);
            this.resultValueLabel.Name = "resultValueLabel";
            this.resultValueLabel.Size = new System.Drawing.Size(12, 18);
            this.resultValueLabel.TabIndex = 7;
            this.resultValueLabel.Text = " ";
            // 
            // ProfitPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.resultValueLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.pointsValueNumeric);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.volumeValueNumeric);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.futuresBox);
            this.Controls.Add(this.futuresLabel);
            this.Name = "ProfitPage";
            this.Size = new System.Drawing.Size(366, 152);
            ((System.ComponentModel.ISupportInitialize)(this.volumeValueNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsValueNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label futuresLabel;
        private System.Windows.Forms.ComboBox futuresBox;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.NumericUpDown volumeValueNumeric;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.NumericUpDown pointsValueNumeric;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label resultValueLabel;
    }
}
