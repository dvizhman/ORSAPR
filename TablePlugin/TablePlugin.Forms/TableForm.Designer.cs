
namespace TablePlugin.Forms
{
    partial class TableForm
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BuildButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.topGroupBox = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tableTopHeight = new System.Windows.Forms.NumericUpDown();
            this.tableTopWidth = new System.Windows.Forms.NumericUpDown();
            this.tableTopLength = new System.Windows.Forms.NumericUpDown();
            this.ledsGroupBox = new System.Windows.Forms.GroupBox();
            this.LegsTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tableLegsNumber = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.SizeValue = new System.Windows.Forms.NumericUpDown();
            this.tableLegsHeight = new System.Windows.Forms.NumericUpDown();
            this.NameOfSize = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SetMinButton = new System.Windows.Forms.Button();
            this.SetMaxButton = new System.Windows.Forms.Button();
            this.buttonGroupBox = new System.Windows.Forms.GroupBox();
            this.DefaultButton = new System.Windows.Forms.Button();
            this.topGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableTopHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTopWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTopLength)).BeginInit();
            this.ledsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLegsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLegsHeight)).BeginInit();
            this.buttonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BuildButton
            // 
            this.BuildButton.Location = new System.Drawing.Point(246, 328);
            this.BuildButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(200, 60);
            this.BuildButton.TabIndex = 0;
            this.BuildButton.Text = "Построить 3D модель";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Длина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ширина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Высота";
            // 
            // topGroupBox
            // 
            this.topGroupBox.AutoSize = true;
            this.topGroupBox.Controls.Add(this.label13);
            this.topGroupBox.Controls.Add(this.label12);
            this.topGroupBox.Controls.Add(this.label11);
            this.topGroupBox.Controls.Add(this.tableTopHeight);
            this.topGroupBox.Controls.Add(this.tableTopWidth);
            this.topGroupBox.Controls.Add(this.tableTopLength);
            this.topGroupBox.Controls.Add(this.label3);
            this.topGroupBox.Controls.Add(this.label2);
            this.topGroupBox.Controls.Add(this.label1);
            this.topGroupBox.Location = new System.Drawing.Point(15, 15);
            this.topGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.topGroupBox.Name = "topGroupBox";
            this.topGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.topGroupBox.Size = new System.Drawing.Size(655, 109);
            this.topGroupBox.TabIndex = 12;
            this.topGroupBox.TabStop = false;
            this.topGroupBox.Text = "Столешница";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(537, 49);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 17);
            this.label13.TabIndex = 19;
            this.label13.Text = "50-80 мм";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(329, 49);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "550-900 мм";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(109, 54);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "550-900 мм";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // tableTopHeight
            //
            this.tableTopHeight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.tableTopHeight.Location = new System.Drawing.Point(444, 47);
            this.tableTopHeight.Margin = new System.Windows.Forms.Padding(4);
            this.tableTopHeight.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.tableTopHeight.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.tableTopHeight.Name = "tableTopHeight";
            this.tableTopHeight.Size = new System.Drawing.Size(85, 22);
            this.tableTopHeight.TabIndex = 14;
            this.tableTopHeight.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // tableTopWidth
            // 
            this.tableTopWidth.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.tableTopWidth.Location = new System.Drawing.Point(236, 49);
            this.tableTopWidth.Margin = new System.Windows.Forms.Padding(4);
            this.tableTopWidth.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.tableTopWidth.Minimum = new decimal(new int[] {
            550,
            0,
            0,
            0});
            this.tableTopWidth.Name = "tableTopWidth";
            this.tableTopWidth.Size = new System.Drawing.Size(85, 22);
            this.tableTopWidth.TabIndex = 13;
            this.tableTopWidth.Value = new decimal(new int[] {
            700,
            0,
            0,
            0});
            // 
            // tableTopLength
            // 
            this.tableTopLength.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.tableTopLength.Location = new System.Drawing.Point(17, 49);
            this.tableTopLength.Margin = new System.Windows.Forms.Padding(4);
            this.tableTopLength.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.tableTopLength.Minimum = new decimal(new int[] {
            550,
            0,
            0,
            0});
            this.tableTopLength.Name = "tableTopLength";
            this.tableTopLength.Size = new System.Drawing.Size(84, 22);
            this.tableTopLength.TabIndex = 12;
            this.tableTopLength.Value = new decimal(new int[] {
            700,
            0,
            0,
            0});
            // 
            // ledsGroupBox
            // 
            this.ledsGroupBox.Controls.Add(this.LegsTypeComboBox);
            this.ledsGroupBox.Controls.Add(this.label18);
            this.ledsGroupBox.Controls.Add(this.label17);
            this.ledsGroupBox.Controls.Add(this.tableLegsNumber);
            this.ledsGroupBox.Controls.Add(this.label14);
            this.ledsGroupBox.Controls.Add(this.SizeValue);
            this.ledsGroupBox.Controls.Add(this.tableLegsHeight);
            this.ledsGroupBox.Controls.Add(this.NameOfSize);
            this.ledsGroupBox.Controls.Add(this.label8);
            this.ledsGroupBox.Controls.Add(this.label7);
            this.ledsGroupBox.Controls.Add(this.label6);
            this.ledsGroupBox.Location = new System.Drawing.Point(15, 132);
            this.ledsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ledsGroupBox.Name = "ledsGroupBox";
            this.ledsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ledsGroupBox.Size = new System.Drawing.Size(431, 175);
            this.ledsGroupBox.TabIndex = 13;
            this.ledsGroupBox.TabStop = false;
            this.ledsGroupBox.Text = "Ножки";
            // 
            // LegsTypeComboBox
            // 
            this.LegsTypeComboBox.FormattingEnabled = true;
            this.LegsTypeComboBox.Items.AddRange(new object[] {"Квадратные"});
            this.LegsTypeComboBox.Location = new System.Drawing.Point(16, 127);
            this.LegsTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.LegsTypeComboBox.Name = "LegsTypeComboBox";
            this.LegsTypeComboBox.Size = new System.Drawing.Size(115, 24);
            this.LegsTypeComboBox.TabIndex = 23;
            this.LegsTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.LegsTypeComboBox_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.DimGray;
            this.label18.Location = new System.Drawing.Point(353, 128);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 17);
            this.label18.TabIndex = 22;
            this.label18.Text = "50-225 мм";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Location = new System.Drawing.Point(353, 50);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 17);
            this.label17.TabIndex = 21;
            this.label17.Text = "4 шт.";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // tableLegsNumber
            // 
            this.tableLegsNumber.Location = new System.Drawing.Point(239, 48);
            this.tableLegsNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tableLegsNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.tableLegsNumber.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.tableLegsNumber.Name = "tableLegsNumber";
            this.tableLegsNumber.Size = new System.Drawing.Size(107, 22);
            this.tableLegsNumber.TabIndex = 20;
            this.tableLegsNumber.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(140, 50);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 17);
            this.label14.TabIndex = 19;
            this.label14.Text = "400-600 мм";
            // 
            // SizeValue
            //
            this.SizeValue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.SizeValue.Location = new System.Drawing.Point(239, 126);
            this.SizeValue.Margin = new System.Windows.Forms.Padding(4);
            this.SizeValue.Maximum = new decimal(new int[] {
            225,
            0,
            0,
            0});
            this.SizeValue.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.SizeValue.Name = "SizeValue";
            this.SizeValue.Size = new System.Drawing.Size(107, 22);
            this.SizeValue.TabIndex = 16;
            this.SizeValue.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // tableLegsHeight
            // 
            this.tableLegsHeight.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.tableLegsHeight.Location = new System.Drawing.Point(16, 46);
            this.tableLegsHeight.Margin = new System.Windows.Forms.Padding(4);
            this.tableLegsHeight.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.tableLegsHeight.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.tableLegsHeight.Name = "tableLegsHeight";
            this.tableLegsHeight.Size = new System.Drawing.Size(116, 22);
            this.tableLegsHeight.TabIndex = 14;
            this.tableLegsHeight.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // NameOfSize
            // 
            this.NameOfSize.AutoSize = true;
            this.NameOfSize.Location = new System.Drawing.Point(235, 106);
            this.NameOfSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameOfSize.Name = "NameOfSize";
            this.NameOfSize.Size = new System.Drawing.Size(141, 17);
            this.NameOfSize.TabIndex = 11;
            this.NameOfSize.Text = "Диаметр основания";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Тип ножек";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Количество ножек";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Длина ножек";
            // 
            // SetMinButton
            // 
            this.SetMinButton.Location = new System.Drawing.Point(15, 75);
            this.SetMinButton.Margin = new System.Windows.Forms.Padding(4);
            this.SetMinButton.Name = "SetMinButton";
            this.SetMinButton.Size = new System.Drawing.Size(179, 39);
            this.SetMinButton.TabIndex = 14;
            this.SetMinButton.Text = "Минимумы";
            this.SetMinButton.UseVisualStyleBackColor = true;
            this.SetMinButton.Click += new System.EventHandler(this.SetMinButton_Click);
            // 
            // SetMaxButton
            // 
            this.SetMaxButton.Location = new System.Drawing.Point(15, 126);
            this.SetMaxButton.Margin = new System.Windows.Forms.Padding(4);
            this.SetMaxButton.Name = "SetMaxButton";
            this.SetMaxButton.Size = new System.Drawing.Size(179, 39);
            this.SetMaxButton.TabIndex = 15;
            this.SetMaxButton.Text = "Максимумы";
            this.SetMaxButton.UseVisualStyleBackColor = true;
            this.SetMaxButton.Click += new System.EventHandler(this.SetMaxButton_Click);
            // 
            // buttonGroupBox
            // 
            this.buttonGroupBox.Controls.Add(this.DefaultButton);
            this.buttonGroupBox.Controls.Add(this.SetMinButton);
            this.buttonGroupBox.Controls.Add(this.SetMaxButton);
            this.buttonGroupBox.Location = new System.Drawing.Point(461, 132);
            this.buttonGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGroupBox.Name = "buttonGroupBox";
            this.buttonGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.buttonGroupBox.Size = new System.Drawing.Size(209, 175);
            this.buttonGroupBox.TabIndex = 16;
            this.buttonGroupBox.TabStop = false;
            this.buttonGroupBox.Text = "Параметры по умолчанию";
            // 
            // DefaultButton
            // 
            this.DefaultButton.Location = new System.Drawing.Point(15, 25);
            this.DefaultButton.Margin = new System.Windows.Forms.Padding(4);
            this.DefaultButton.Name = "DefaultButton";
            this.DefaultButton.Size = new System.Drawing.Size(179, 39);
            this.DefaultButton.TabIndex = 16;
            this.DefaultButton.Text = "По умолчанию";
            this.DefaultButton.UseVisualStyleBackColor = true;
            this.DefaultButton.Click += new System.EventHandler(this.DefaultButton_Click);
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 410);
            this.Controls.Add(this.buttonGroupBox);
            this.Controls.Add(this.ledsGroupBox);
            this.Controls.Add(this.topGroupBox);
            this.Controls.Add(this.BuildButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TableForm";
            this.Text = "TablePlugin";
            this.Load += new System.EventHandler(this.TableForm_Load);
            this.topGroupBox.ResumeLayout(false);
            this.topGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableTopHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTopWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTopLength)).EndInit();
            this.ledsGroupBox.ResumeLayout(false);
            this.ledsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLegsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLegsHeight)).EndInit();
            this.buttonGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox topGroupBox;
        private System.Windows.Forms.GroupBox ledsGroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label NameOfSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown tableTopHeight;
        private System.Windows.Forms.NumericUpDown tableTopWidth;
        private System.Windows.Forms.NumericUpDown tableTopLength;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown tableLegsNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown SizeValue;
        private System.Windows.Forms.NumericUpDown tableLegsHeight;
        private System.Windows.Forms.Button SetMinButton;
        private System.Windows.Forms.Button SetMaxButton;
        private System.Windows.Forms.ComboBox LegsTypeComboBox;
        private System.Windows.Forms.GroupBox buttonGroupBox;
        private System.Windows.Forms.Button DefaultButton;
    }
}

