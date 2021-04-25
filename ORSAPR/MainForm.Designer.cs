
namespace ORSAPR
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
            this.textBoxLengthTop = new System.Windows.Forms.TextBox();
            this.textBoxWidthTop = new System.Windows.Forms.TextBox();
            this.textBoxHeigthTop = new System.Windows.Forms.TextBox();
            this.textBoxWidthLegs = new System.Windows.Forms.TextBox();
            this.textBoxHeightLegs = new System.Windows.Forms.TextBox();
            this.labelLengthTop = new System.Windows.Forms.Label();
            this.labelWedthTop = new System.Windows.Forms.Label();
            this.labelHeigthTop = new System.Windows.Forms.Label();
            this.labelWidthLegs = new System.Windows.Forms.Label();
            this.labelHeightLegs = new System.Windows.Forms.Label();
            this.textBoxLengthLegs = new System.Windows.Forms.TextBox();
            this.labelLengthLegs = new System.Windows.Forms.Label();
            this.buttonBuild = new System.Windows.Forms.Button();
            this.groupBoxTop = new System.Windows.Forms.GroupBox();
            this.groupBoxLegs = new System.Windows.Forms.GroupBox();
            this.groupBoxTop.SuspendLayout();
            this.groupBoxLegs.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLengthTop
            // 
            this.textBoxLengthTop.Location = new System.Drawing.Point(277, 33);
            this.textBoxLengthTop.Name = "textBoxLengthTop";
            this.textBoxLengthTop.Size = new System.Drawing.Size(100, 22);
            this.textBoxLengthTop.TabIndex = 0;
            // 
            // textBoxWidthTop
            // 
            this.textBoxWidthTop.Location = new System.Drawing.Point(277, 61);
            this.textBoxWidthTop.Name = "textBoxWidthTop";
            this.textBoxWidthTop.Size = new System.Drawing.Size(100, 22);
            this.textBoxWidthTop.TabIndex = 1;
            // 
            // textBoxHeigthTop
            // 
            this.textBoxHeigthTop.Location = new System.Drawing.Point(277, 89);
            this.textBoxHeigthTop.Name = "textBoxHeigthTop";
            this.textBoxHeigthTop.Size = new System.Drawing.Size(100, 22);
            this.textBoxHeigthTop.TabIndex = 2;
            this.textBoxHeigthTop.TextChanged += new System.EventHandler(this.textBoxTopThickness_TextChanged);
            // 
            // textBoxWidthLegs
            // 
            this.textBoxWidthLegs.Location = new System.Drawing.Point(277, 61);
            this.textBoxWidthLegs.Name = "textBoxWidthLegs";
            this.textBoxWidthLegs.Size = new System.Drawing.Size(100, 22);
            this.textBoxWidthLegs.TabIndex = 5;
            this.textBoxWidthLegs.TextChanged += new System.EventHandler(this.textBoxWidthLegs_TextChanged);
            // 
            // textBoxHeightLegs
            // 
            this.textBoxHeightLegs.Location = new System.Drawing.Point(277, 89);
            this.textBoxHeightLegs.Name = "textBoxHeightLegs";
            this.textBoxHeightLegs.Size = new System.Drawing.Size(100, 22);
            this.textBoxHeightLegs.TabIndex = 6;
            this.textBoxHeightLegs.TextChanged += new System.EventHandler(this.textBoxHeightLegs_TextChanged);
            // 
            // labelLengthTop
            // 
            this.labelLengthTop.AutoSize = true;
            this.labelLengthTop.Location = new System.Drawing.Point(13, 33);
            this.labelLengthTop.Name = "labelLengthTop";
            this.labelLengthTop.Size = new System.Drawing.Size(138, 17);
            this.labelLengthTop.TabIndex = 8;
            this.labelLengthTop.Text = "Длина столешницы";
            this.labelLengthTop.Click += new System.EventHandler(this.labelTopLength_Click);
            // 
            // labelWedthTop
            // 
            this.labelWedthTop.AutoSize = true;
            this.labelWedthTop.Location = new System.Drawing.Point(13, 61);
            this.labelWedthTop.Name = "labelWedthTop";
            this.labelWedthTop.Size = new System.Drawing.Size(146, 17);
            this.labelWedthTop.TabIndex = 9;
            this.labelWedthTop.Text = "Ширина столешницы";
            this.labelWedthTop.Click += new System.EventHandler(this.labelTopWedth_Click);
            // 
            // labelHeigthTop
            // 
            this.labelHeigthTop.AutoSize = true;
            this.labelHeigthTop.Location = new System.Drawing.Point(13, 89);
            this.labelHeigthTop.Name = "labelHeigthTop";
            this.labelHeigthTop.Size = new System.Drawing.Size(144, 17);
            this.labelHeigthTop.TabIndex = 10;
            this.labelHeigthTop.Text = "Высота столешницы";
            // 
            // labelWidthLegs
            // 
            this.labelWidthLegs.AutoSize = true;
            this.labelWidthLegs.Location = new System.Drawing.Point(13, 61);
            this.labelWidthLegs.Name = "labelWidthLegs";
            this.labelWidthLegs.Size = new System.Drawing.Size(103, 17);
            this.labelWidthLegs.TabIndex = 12;
            this.labelWidthLegs.Text = "Ширина ножек";
            this.labelWidthLegs.Click += new System.EventHandler(this.labelWidthLegs_Click);
            // 
            // labelHeightLegs
            // 
            this.labelHeightLegs.AutoSize = true;
            this.labelHeightLegs.Location = new System.Drawing.Point(13, 89);
            this.labelHeightLegs.Name = "labelHeightLegs";
            this.labelHeightLegs.Size = new System.Drawing.Size(101, 17);
            this.labelHeightLegs.TabIndex = 13;
            this.labelHeightLegs.Text = "Высота ножек";
            this.labelHeightLegs.Click += new System.EventHandler(this.labelHeightLegs_Click);
            // 
            // textBoxLengthLegs
            // 
            this.textBoxLengthLegs.Location = new System.Drawing.Point(277, 33);
            this.textBoxLengthLegs.Name = "textBoxLengthLegs";
            this.textBoxLengthLegs.Size = new System.Drawing.Size(100, 22);
            this.textBoxLengthLegs.TabIndex = 16;
            this.textBoxLengthLegs.TextChanged += new System.EventHandler(this.textBoxBoxWidth_TextChanged);
            // 
            // labelLengthLegs
            // 
            this.labelLengthLegs.AutoSize = true;
            this.labelLengthLegs.Location = new System.Drawing.Point(13, 33);
            this.labelLengthLegs.Name = "labelLengthLegs";
            this.labelLengthLegs.Size = new System.Drawing.Size(95, 17);
            this.labelLengthLegs.TabIndex = 17;
            this.labelLengthLegs.Text = "Длина ножек";
            this.labelLengthLegs.Click += new System.EventHandler(this.labelLengthLegs_Click);
            // 
            // buttonBuild
            // 
            this.buttonBuild.Location = new System.Drawing.Point(271, 314);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(116, 29);
            this.buttonBuild.TabIndex = 18;
            this.buttonBuild.Text = "Построить";
            this.buttonBuild.UseVisualStyleBackColor = true;
            this.buttonBuild.Click += new System.EventHandler(this.buttonBuild_Click);
            // 
            // groupBoxTop
            // 
            this.groupBoxTop.Controls.Add(this.labelHeigthTop);
            this.groupBoxTop.Controls.Add(this.labelWedthTop);
            this.groupBoxTop.Controls.Add(this.labelLengthTop);
            this.groupBoxTop.Controls.Add(this.textBoxHeigthTop);
            this.groupBoxTop.Controls.Add(this.textBoxWidthTop);
            this.groupBoxTop.Controls.Add(this.textBoxLengthTop);
            this.groupBoxTop.Location = new System.Drawing.Point(10, 12);
            this.groupBoxTop.Name = "groupBoxTop";
            this.groupBoxTop.Size = new System.Drawing.Size(395, 130);
            this.groupBoxTop.TabIndex = 19;
            this.groupBoxTop.TabStop = false;
            this.groupBoxTop.Text = "Параметры столешницы";
            // 
            // groupBoxLegs
            // 
            this.groupBoxLegs.Controls.Add(this.labelLengthLegs);
            this.groupBoxLegs.Controls.Add(this.textBoxLengthLegs);
            this.groupBoxLegs.Controls.Add(this.labelHeightLegs);
            this.groupBoxLegs.Controls.Add(this.labelWidthLegs);
            this.groupBoxLegs.Controls.Add(this.textBoxHeightLegs);
            this.groupBoxLegs.Controls.Add(this.textBoxWidthLegs);
            this.groupBoxLegs.Location = new System.Drawing.Point(10, 161);
            this.groupBoxLegs.Name = "groupBoxLegs";
            this.groupBoxLegs.Size = new System.Drawing.Size(395, 130);
            this.groupBoxLegs.TabIndex = 20;
            this.groupBoxLegs.TabStop = false;
            this.groupBoxLegs.Text = "Пареметры ножек";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(416, 355);
            this.Controls.Add(this.groupBoxLegs);
            this.Controls.Add(this.groupBoxTop);
            this.Controls.Add(this.buttonBuild);
            this.Name = "MainForm";
            this.Text = "Плагин журнального стола";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxTop.ResumeLayout(false);
            this.groupBoxTop.PerformLayout();
            this.groupBoxLegs.ResumeLayout(false);
            this.groupBoxLegs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLengthTop;
        private System.Windows.Forms.TextBox textBoxWidthTop;
        private System.Windows.Forms.TextBox textBoxHeigthTop;
        private System.Windows.Forms.TextBox textBoxWidthLegs;
        private System.Windows.Forms.TextBox textBoxHeightLegs;
        private System.Windows.Forms.Label labelLengthTop;
        private System.Windows.Forms.Label labelWedthTop;
        private System.Windows.Forms.Label labelHeigthTop;
        private System.Windows.Forms.Label labelWidthLegs;
        private System.Windows.Forms.Label labelHeightLegs;
        private System.Windows.Forms.TextBox textBoxLengthLegs;
        private System.Windows.Forms.Label labelLengthLegs;
        private System.Windows.Forms.Button buttonBuild;
        private System.Windows.Forms.GroupBox groupBoxTop;
        private System.Windows.Forms.GroupBox groupBoxLegs;
    }
}

