
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
            this.label4 = new System.Windows.Forms.Label();
            this.tableLegsWidth = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tableLegsLength = new System.Windows.Forms.NumericUpDown();
            this.tableLegsHeight = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.topGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableTopHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTopWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTopLength)).BeginInit();
            this.ledsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLegsWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLegsLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLegsHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // BuildButton
            // 
            this.BuildButton.Location = new System.Drawing.Point(166, 326);
            this.BuildButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(170, 60);
            this.BuildButton.TabIndex = 0;
            this.BuildButton.Text = "Построить";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Длина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ширина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 102);
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
            this.topGroupBox.Size = new System.Drawing.Size(459, 142);
            this.topGroupBox.TabIndex = 12;
            this.topGroupBox.TabStop = false;
            this.topGroupBox.Text = "Параметры столешницы";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(109, 102);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 17);
            this.label13.TabIndex = 19;
            this.label13.Text = "50-80 мм";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(110, 72);
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
            this.label11.Location = new System.Drawing.Point(109, 42);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "550-900 мм";
            // 
            // tableTopHeight
            // 
            this.tableTopHeight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.tableTopHeight.Location = new System.Drawing.Point(17, 97);
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
            this.tableTopWidth.Location = new System.Drawing.Point(17, 67);
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
            this.tableTopLength.Location = new System.Drawing.Point(17, 37);
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
            this.ledsGroupBox.Controls.Add(this.label4);
            this.ledsGroupBox.Controls.Add(this.tableLegsWidth);
            this.ledsGroupBox.Controls.Add(this.label5);
            this.ledsGroupBox.Controls.Add(this.label18);
            this.ledsGroupBox.Controls.Add(this.label14);
            this.ledsGroupBox.Controls.Add(this.tableLegsLength);
            this.ledsGroupBox.Controls.Add(this.tableLegsHeight);
            this.ledsGroupBox.Controls.Add(this.label7);
            this.ledsGroupBox.Controls.Add(this.label6);
            this.ledsGroupBox.Location = new System.Drawing.Point(15, 165);
            this.ledsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ledsGroupBox.Name = "ledsGroupBox";
            this.ledsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ledsGroupBox.Size = new System.Drawing.Size(459, 143);
            this.ledsGroupBox.TabIndex = 13;
            this.ledsGroupBox.TabStop = false;
            this.ledsGroupBox.Text = "Параметры ножки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(110, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "50-225 мм";
            // 
            // tableLegsWidth
            // 
            this.tableLegsWidth.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.tableLegsWidth.Location = new System.Drawing.Point(17, 94);
            this.tableLegsWidth.Margin = new System.Windows.Forms.Padding(4);
            this.tableLegsWidth.Maximum = new decimal(new int[] {
            225,
            0,
            0,
            0});
            this.tableLegsWidth.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.tableLegsWidth.Name = "tableLegsWidth";
            this.tableLegsWidth.Size = new System.Drawing.Size(86, 22);
            this.tableLegsWidth.TabIndex = 24;
            this.tableLegsWidth.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ширина основания ножек";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.DimGray;
            this.label18.Location = new System.Drawing.Point(110, 69);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 17);
            this.label18.TabIndex = 22;
            this.label18.Text = "50-225 мм";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(109, 39);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 17);
            this.label14.TabIndex = 19;
            this.label14.Text = "400-600 мм";
            // 
            // tableLegsLength
            // 
            this.tableLegsLength.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.tableLegsLength.Location = new System.Drawing.Point(17, 64);
            this.tableLegsLength.Margin = new System.Windows.Forms.Padding(4);
            this.tableLegsLength.Maximum = new decimal(new int[] {
            225,
            0,
            0,
            0});
            this.tableLegsLength.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.tableLegsLength.Name = "tableLegsLength";
            this.tableLegsLength.Size = new System.Drawing.Size(86, 22);
            this.tableLegsLength.TabIndex = 16;
            this.tableLegsLength.Value = new decimal(new int[] {
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
            this.tableLegsHeight.Location = new System.Drawing.Point(17, 34);
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
            this.tableLegsHeight.Size = new System.Drawing.Size(84, 22);
            this.tableLegsHeight.TabIndex = 14;
            this.tableLegsHeight.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Длина основания ножек";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Высота ножек";
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 405);
            this.Controls.Add(this.ledsGroupBox);
            this.Controls.Add(this.topGroupBox);
            this.Controls.Add(this.BuildButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TableForm";
            this.Text = "Плагин журнального стола";
            this.topGroupBox.ResumeLayout(false);
            this.topGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableTopHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTopWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTopLength)).EndInit();
            this.ledsGroupBox.ResumeLayout(false);
            this.ledsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLegsWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLegsLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLegsHeight)).EndInit();
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown tableTopHeight;
        private System.Windows.Forms.NumericUpDown tableTopWidth;
        private System.Windows.Forms.NumericUpDown tableTopLength;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown tableLegsLength;
        private System.Windows.Forms.NumericUpDown tableLegsHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown tableLegsWidth;
        private System.Windows.Forms.Label label5;
    }
}

