namespace drawfunctionn
{
    partial class frmMain
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
            this.graphWind = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.squareA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.squareB = new System.Windows.Forms.TextBox();
            this.squareC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this._lineB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._lineK = new System.Windows.Forms.TextBox();
            this.xFuncSelector = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.yFuncSelector = new System.Windows.Forms.ListBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.nudA = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudB = new System.Windows.Forms.NumericUpDown();
            this.nudC = new System.Windows.Forms.NumericUpDown();
            this.nudK = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graphWind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudK)).BeginInit();
            this.SuspendLayout();
            // 
            // graphWind
            // 
            this.graphWind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphWind.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.graphWind.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.graphWind.Location = new System.Drawing.Point(12, 12);
            this.graphWind.Name = "graphWind";
            this.graphWind.Size = new System.Drawing.Size(800, 800);
            this.graphWind.TabIndex = 0;
            this.graphWind.TabStop = false;
            this.graphWind.SizeChanged += new System.EventHandler(this.GraphWind_SizeChanged);
            this.graphWind.Click += new System.EventHandler(this.GraphWind_Click);
            this.graphWind.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphWind_Paint);
            this.graphWind.Resize += new System.EventHandler(this.GraphWind_Resize);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(832, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "draw the graph";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(869, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "y = kx + b";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // squareA
            // 
            this.squareA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.squareA.Location = new System.Drawing.Point(920, 189);
            this.squareA.Name = "squareA";
            this.squareA.Size = new System.Drawing.Size(66, 20);
            this.squareA.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(882, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "a =";
            // 
            // squareB
            // 
            this.squareB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.squareB.Location = new System.Drawing.Point(920, 215);
            this.squareB.Name = "squareB";
            this.squareB.Size = new System.Drawing.Size(66, 20);
            this.squareB.TabIndex = 5;
            // 
            // squareC
            // 
            this.squareC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.squareC.Location = new System.Drawing.Point(920, 241);
            this.squareC.Name = "squareC";
            this.squareC.Size = new System.Drawing.Size(66, 20);
            this.squareC.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(882, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "b =";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(882, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "c =";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(869, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "y = a*x ^ 2 + b*x + c";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(885, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "b =";
            // 
            // _lineB
            // 
            this._lineB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lineB.Location = new System.Drawing.Point(923, 124);
            this._lineB.Name = "_lineB";
            this._lineB.Size = new System.Drawing.Size(66, 20);
            this._lineB.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(885, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "k =";
            // 
            // _lineK
            // 
            this._lineK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lineK.Location = new System.Drawing.Point(923, 98);
            this._lineK.Name = "_lineK";
            this._lineK.Size = new System.Drawing.Size(66, 20);
            this._lineK.TabIndex = 10;
            // 
            // xFuncSelector
            // 
            this.xFuncSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xFuncSelector.FormattingEnabled = true;
            this.xFuncSelector.Location = new System.Drawing.Point(869, 281);
            this.xFuncSelector.Name = "xFuncSelector";
            this.xFuncSelector.Size = new System.Drawing.Size(120, 95);
            this.xFuncSelector.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(866, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "f(x)";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(866, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "f(y)";
            // 
            // yFuncSelector
            // 
            this.yFuncSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yFuncSelector.FormattingEnabled = true;
            this.yFuncSelector.Location = new System.Drawing.Point(869, 398);
            this.yFuncSelector.Name = "yFuncSelector";
            this.yFuncSelector.Size = new System.Drawing.Size(120, 95);
            this.yFuncSelector.TabIndex = 16;
            // 
            // btnDraw
            // 
            this.btnDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDraw.Location = new System.Drawing.Point(869, 518);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(117, 23);
            this.btnDraw.TabIndex = 18;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // nudA
            // 
            this.nudA.DecimalPlaces = 2;
            this.nudA.Location = new System.Drawing.Point(904, 547);
            this.nudA.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudA.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudA.Name = "nudA";
            this.nudA.Size = new System.Drawing.Size(85, 20);
            this.nudA.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(876, 601);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "c =";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(876, 575);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "b =";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(876, 549);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "a =";
            // 
            // nudB
            // 
            this.nudB.DecimalPlaces = 2;
            this.nudB.Location = new System.Drawing.Point(904, 573);
            this.nudB.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudB.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudB.Name = "nudB";
            this.nudB.Size = new System.Drawing.Size(85, 20);
            this.nudB.TabIndex = 23;
            // 
            // nudC
            // 
            this.nudC.DecimalPlaces = 2;
            this.nudC.Location = new System.Drawing.Point(904, 599);
            this.nudC.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudC.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudC.Name = "nudC";
            this.nudC.Size = new System.Drawing.Size(85, 20);
            this.nudC.TabIndex = 24;
            // 
            // nudK
            // 
            this.nudK.DecimalPlaces = 2;
            this.nudK.Location = new System.Drawing.Point(904, 625);
            this.nudK.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudK.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudK.Name = "nudK";
            this.nudK.Size = new System.Drawing.Size(85, 20);
            this.nudK.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(876, 627);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "k =";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 823);
            this.Controls.Add(this.nudK);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nudC);
            this.Controls.Add(this.nudB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nudA);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.yFuncSelector);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.xFuncSelector);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._lineB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._lineK);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.squareC);
            this.Controls.Add(this.squareB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.squareA);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.graphWind);
            this.Name = "frmMain";
            this.Text = "graphic of function";
            ((System.ComponentModel.ISupportInitialize)(this.graphWind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox graphWind;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox squareA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox squareB;
        private System.Windows.Forms.TextBox squareC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _lineB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _lineK;
        private System.Windows.Forms.ListBox xFuncSelector;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox yFuncSelector;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.NumericUpDown nudA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudB;
        private System.Windows.Forms.NumericUpDown nudC;
        private System.Windows.Forms.NumericUpDown nudK;
        private System.Windows.Forms.Label label11;
    }
}

