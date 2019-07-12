namespace CalculatorOOP
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
        /// 
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
            this.AdditionCalculate = new System.Windows.Forms.Button();
            this.SubstractionCalculate = new System.Windows.Forms.Button();
            this.MultiplyCalculate = new System.Windows.Forms.Button();
            this.DivisionCalculate = new System.Windows.Forms.Button();
            this.Value1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Value2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PowCalculate = new System.Windows.Forms.Button();
            this.SqrtCalculate = new System.Windows.Forms.Button();
            this.MinCalculate = new System.Windows.Forms.Button();
            this.MaxCalculate = new System.Windows.Forms.Button();
            this.MiddleArithmeticCalculate = new System.Windows.Forms.Button();
            this.MidGeometricCalculate = new System.Windows.Forms.Button();
            this.SinCalculate = new System.Windows.Forms.Button();
            this.CosCalculate = new System.Windows.Forms.Button();
            this.TanCalculate = new System.Windows.Forms.Button();
            this.ArcsinCalculate = new System.Windows.Forms.Button();
            this.ArccosCalculate = new System.Windows.Forms.Button();
            this.CtanCalculate = new System.Windows.Forms.Button();
            this.ArctanCalculate = new System.Windows.Forms.Button();
            this.OneDivArgCalculate = new System.Windows.Forms.Button();
            this.ExponentialCalculate = new System.Windows.Forms.Button();
            this.LogarithmCalculate = new System.Windows.Forms.Button();
            this.LogarithmToTheBaseTenCalculate = new System.Windows.Forms.Button();
            this.NaturaleLogarithmCalculate = new System.Windows.Forms.Button();
            this.ModuleNumberCalculate = new System.Windows.Forms.Button();
            this.NegativeNumberCalculate = new System.Windows.Forms.Button();
            this.TwoPowerNumberCalculate = new System.Windows.Forms.Button();
            this.TenPowerNumberCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdditionCalculate
            // 
            this.AdditionCalculate.Location = new System.Drawing.Point(93, 111);
            this.AdditionCalculate.Name = "AdditionCalculate";
            this.AdditionCalculate.Size = new System.Drawing.Size(75, 23);
            this.AdditionCalculate.TabIndex = 0;
            this.AdditionCalculate.Text = "+";
            this.AdditionCalculate.UseVisualStyleBackColor = true;
            this.AdditionCalculate.Click += new System.EventHandler(this.ButtonClickForTwoArgumentsFunctions);
            // 
            // SubstractionCalculate
            // 
            this.SubstractionCalculate.Location = new System.Drawing.Point(93, 140);
            this.SubstractionCalculate.Name = "SubstractionCalculate";
            this.SubstractionCalculate.Size = new System.Drawing.Size(75, 23);
            this.SubstractionCalculate.TabIndex = 1;
            this.SubstractionCalculate.Text = "-";
            this.SubstractionCalculate.UseVisualStyleBackColor = true;
            this.SubstractionCalculate.Click += new System.EventHandler(this.ButtonClickForTwoArgumentsFunctions);
            // 
            // MultiplyCalculate
            // 
            this.MultiplyCalculate.Location = new System.Drawing.Point(174, 111);
            this.MultiplyCalculate.Name = "MultiplyCalculate";
            this.MultiplyCalculate.Size = new System.Drawing.Size(75, 23);
            this.MultiplyCalculate.TabIndex = 2;
            this.MultiplyCalculate.Text = "*";
            this.MultiplyCalculate.UseVisualStyleBackColor = true;
            this.MultiplyCalculate.Click += new System.EventHandler(this.ButtonClickForTwoArgumentsFunctions);
            // 
            // DivisionCalculate
            // 
            this.DivisionCalculate.Location = new System.Drawing.Point(174, 140);
            this.DivisionCalculate.Name = "DivisionCalculate";
            this.DivisionCalculate.Size = new System.Drawing.Size(75, 23);
            this.DivisionCalculate.TabIndex = 3;
            this.DivisionCalculate.Text = "/";
            this.DivisionCalculate.UseVisualStyleBackColor = true;
            this.DivisionCalculate.Click += new System.EventHandler(this.ButtonClickForTwoArgumentsFunctions);
            // 
            // Value1
            // 
            this.Value1.Location = new System.Drawing.Point(93, 76);
            this.Value1.Name = "Value1";
            this.Value1.Size = new System.Drawing.Size(100, 20);
            this.Value1.TabIndex = 4;
            this.Value1.TextChanged += new System.EventHandler(this.Value1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(450, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(101, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Value2
            // 
            this.Value2.Location = new System.Drawing.Point(269, 76);
            this.Value2.Name = "Value2";
            this.Value2.Size = new System.Drawing.Size(100, 20);
            this.Value2.TabIndex = 6;
            this.Value2.TextChanged += new System.EventHandler(this.Value2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(413, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(64, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Первое значение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(238, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Второе значение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(470, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ответ";
            // 
            // PowCalculate
            // 
            this.PowCalculate.Location = new System.Drawing.Point(255, 111);
            this.PowCalculate.Name = "PowCalculate";
            this.PowCalculate.Size = new System.Drawing.Size(75, 23);
            this.PowCalculate.TabIndex = 11;
            this.PowCalculate.Text = "x^2";
            this.PowCalculate.UseVisualStyleBackColor = true;
            this.PowCalculate.Click += new System.EventHandler(this.ButtonClickForOneArgumentFunctions);
            // 
            // SqrtCalculate
            // 
            this.SqrtCalculate.Location = new System.Drawing.Point(255, 140);
            this.SqrtCalculate.Name = "SqrtCalculate";
            this.SqrtCalculate.Size = new System.Drawing.Size(75, 23);
            this.SqrtCalculate.TabIndex = 12;
            this.SqrtCalculate.Text = "Sqrt";
            this.SqrtCalculate.UseVisualStyleBackColor = true;
            this.SqrtCalculate.Click += new System.EventHandler(this.ButtonClickForOneArgumentFunctions);
            // 
            // MinCalculate
            // 
            this.MinCalculate.Location = new System.Drawing.Point(336, 111);
            this.MinCalculate.Name = "MinCalculate";
            this.MinCalculate.Size = new System.Drawing.Size(75, 23);
            this.MinCalculate.TabIndex = 13;
            this.MinCalculate.Text = "Min";
            this.MinCalculate.UseVisualStyleBackColor = true;
            this.MinCalculate.Click += new System.EventHandler(this.ButtonClickForTwoArgumentsFunctions);
            // 
            // MaxCalculate
            // 
            this.MaxCalculate.Location = new System.Drawing.Point(336, 140);
            this.MaxCalculate.Name = "MaxCalculate";
            this.MaxCalculate.Size = new System.Drawing.Size(75, 23);
            this.MaxCalculate.TabIndex = 14;
            this.MaxCalculate.Text = "Max";
            this.MaxCalculate.UseVisualStyleBackColor = true;
            this.MaxCalculate.Click += new System.EventHandler(this.ButtonClickForTwoArgumentsFunctions);
            // 
            // MiddleArithmeticCalculate
            // 
            this.MiddleArithmeticCalculate.Location = new System.Drawing.Point(255, 169);
            this.MiddleArithmeticCalculate.Name = "MiddleArithmeticCalculate";
            this.MiddleArithmeticCalculate.Size = new System.Drawing.Size(75, 23);
            this.MiddleArithmeticCalculate.TabIndex = 15;
            this.MiddleArithmeticCalculate.Text = "MidAr";
            this.MiddleArithmeticCalculate.UseVisualStyleBackColor = true;
            this.MiddleArithmeticCalculate.Click += new System.EventHandler(this.ButtonClickForTwoArgumentsFunctions);
            // 
            // MidGeometricCalculate
            // 
            this.MidGeometricCalculate.Location = new System.Drawing.Point(336, 169);
            this.MidGeometricCalculate.Name = "MidGeometricCalculate";
            this.MidGeometricCalculate.Size = new System.Drawing.Size(75, 23);
            this.MidGeometricCalculate.TabIndex = 16;
            this.MidGeometricCalculate.Text = "MidGeo";
            this.MidGeometricCalculate.UseVisualStyleBackColor = true;
            this.MidGeometricCalculate.Click += new System.EventHandler(this.ButtonClickForTwoArgumentsFunctions);
            // 
            // SinCalculate
            // 
            this.SinCalculate.Location = new System.Drawing.Point(417, 111);
            this.SinCalculate.Name = "SinCalculate";
            this.SinCalculate.Size = new System.Drawing.Size(75, 23);
            this.SinCalculate.TabIndex = 17;
            this.SinCalculate.Text = "Sin";
            this.SinCalculate.UseVisualStyleBackColor = true;
            this.SinCalculate.Click += new System.EventHandler(this.ButtonClickForOneArgumentFunctions);
            // 
            // CosCalculate
            // 
            this.CosCalculate.Location = new System.Drawing.Point(417, 140);
            this.CosCalculate.Name = "CosCalculate";
            this.CosCalculate.Size = new System.Drawing.Size(75, 23);
            this.CosCalculate.TabIndex = 18;
            this.CosCalculate.Text = "Cos";
            this.CosCalculate.UseVisualStyleBackColor = true;
            this.CosCalculate.Click += new System.EventHandler(this.ButtonClickForOneArgumentFunctions);
            // 
            // TanCalculate
            // 
            this.TanCalculate.Location = new System.Drawing.Point(255, 198);
            this.TanCalculate.Name = "TanCalculate";
            this.TanCalculate.Size = new System.Drawing.Size(75, 23);
            this.TanCalculate.TabIndex = 19;
            this.TanCalculate.Text = "Tan";
            this.TanCalculate.UseVisualStyleBackColor = true;
            this.TanCalculate.Click += new System.EventHandler(this.ButtonClickForOneArgumentFunctions);
            // 
            // ArcsinCalculate
            // 
            this.ArcsinCalculate.Location = new System.Drawing.Point(255, 227);
            this.ArcsinCalculate.Name = "ArcsinCalculate";
            this.ArcsinCalculate.Size = new System.Drawing.Size(75, 23);
            this.ArcsinCalculate.TabIndex = 20;
            this.ArcsinCalculate.Text = "Arcsin";
            this.ArcsinCalculate.UseVisualStyleBackColor = true;
            this.ArcsinCalculate.Click += new System.EventHandler(this.ButtonClickForOneArgumentFunctions);
            // 
            // ArccosCalculate
            // 
            this.ArccosCalculate.Location = new System.Drawing.Point(255, 256);
            this.ArccosCalculate.Name = "ArccosCalculate";
            this.ArccosCalculate.Size = new System.Drawing.Size(75, 23);
            this.ArccosCalculate.TabIndex = 21;
            this.ArccosCalculate.Text = "Arccos";
            this.ArccosCalculate.UseVisualStyleBackColor = true;
            this.ArccosCalculate.Click += new System.EventHandler(this.ButtonClickForOneArgumentFunctions);
            // 
            // CtanCalculate
            // 
            this.CtanCalculate.Location = new System.Drawing.Point(255, 285);
            this.CtanCalculate.Name = "CtanCalculate";
            this.CtanCalculate.Size = new System.Drawing.Size(75, 23);
            this.CtanCalculate.TabIndex = 22;
            this.CtanCalculate.Text = "Ctan";
            this.CtanCalculate.UseVisualStyleBackColor = true;
            this.CtanCalculate.Click += new System.EventHandler(this.ButtonClickForOneArgumentFunctions);
            // 
            // ArctanCalculate
            // 
            this.ArctanCalculate.Location = new System.Drawing.Point(336, 198);
            this.ArctanCalculate.Name = "ArctanCalculate";
            this.ArctanCalculate.Size = new System.Drawing.Size(75, 23);
            this.ArctanCalculate.TabIndex = 23;
            this.ArctanCalculate.Text = "Arctan";
            this.ArctanCalculate.UseVisualStyleBackColor = true;
            this.ArctanCalculate.Click += new System.EventHandler(this.ButtonClickForOneArgumentFunctions);
            // 
            // OneDivArgCalculate
            // 
            this.OneDivArgCalculate.Location = new System.Drawing.Point(336, 227);
            this.OneDivArgCalculate.Name = "OneDivArgCalculate";
            this.OneDivArgCalculate.Size = new System.Drawing.Size(75, 23);
            this.OneDivArgCalculate.TabIndex = 24;
            this.OneDivArgCalculate.Text = "1/x";
            this.OneDivArgCalculate.UseVisualStyleBackColor = true;
            this.OneDivArgCalculate.Click += new System.EventHandler(this.ButtonClickForOneArgumentFunctions);
            // 
            // ExponentialCalculate
            // 
            this.ExponentialCalculate.Location = new System.Drawing.Point(336, 256);
            this.ExponentialCalculate.Name = "ExponentialCalculate";
            this.ExponentialCalculate.Size = new System.Drawing.Size(75, 23);
            this.ExponentialCalculate.TabIndex = 25;
            this.ExponentialCalculate.Text = "Exp";
            this.ExponentialCalculate.UseVisualStyleBackColor = true;
            this.ExponentialCalculate.Click += new System.EventHandler(this.ButtonClickForOneArgumentFunctions);
            // 
            // LogarithmCalculate
            // 
            this.LogarithmCalculate.Location = new System.Drawing.Point(336, 285);
            this.LogarithmCalculate.Name = "LogarithmCalculate";
            this.LogarithmCalculate.Size = new System.Drawing.Size(75, 23);
            this.LogarithmCalculate.TabIndex = 26;
            this.LogarithmCalculate.Text = "Log2";
            this.LogarithmCalculate.UseVisualStyleBackColor = true;
            this.LogarithmCalculate.Click += new System.EventHandler(this.ButtonClickForOneArgumentFunctions);
            // 
            // LogarithmToTheBaseTenCalculate
            // 
            this.LogarithmToTheBaseTenCalculate.Location = new System.Drawing.Point(417, 169);
            this.LogarithmToTheBaseTenCalculate.Name = "LogarithmToTheBaseTenCalculate";
            this.LogarithmToTheBaseTenCalculate.Size = new System.Drawing.Size(75, 23);
            this.LogarithmToTheBaseTenCalculate.TabIndex = 27;
            this.LogarithmToTheBaseTenCalculate.Text = "Log10";
            this.LogarithmToTheBaseTenCalculate.UseVisualStyleBackColor = true;
            this.LogarithmToTheBaseTenCalculate.Click += new System.EventHandler(this.ButtonClickForOneArgumentFunctions);
            // 
            // NaturaleLogarithmCalculate
            // 
            this.NaturaleLogarithmCalculate.Location = new System.Drawing.Point(417, 198);
            this.NaturaleLogarithmCalculate.Name = "NaturaleLogarithmCalculate";
            this.NaturaleLogarithmCalculate.Size = new System.Drawing.Size(75, 23);
            this.NaturaleLogarithmCalculate.TabIndex = 28;
            this.NaturaleLogarithmCalculate.Text = "Ln";
            this.NaturaleLogarithmCalculate.UseVisualStyleBackColor = true;
            this.NaturaleLogarithmCalculate.Click += new System.EventHandler(this.ButtonClickForOneArgumentFunctions);
            // 
            // ModuleNumberCalculate
            // 
            this.ModuleNumberCalculate.Location = new System.Drawing.Point(417, 227);
            this.ModuleNumberCalculate.Name = "ModuleNumberCalculate";
            this.ModuleNumberCalculate.Size = new System.Drawing.Size(75, 23);
            this.ModuleNumberCalculate.TabIndex = 29;
            this.ModuleNumberCalculate.Text = "|x|";
            this.ModuleNumberCalculate.UseVisualStyleBackColor = true;
            this.ModuleNumberCalculate.Click += new System.EventHandler(this.ButtonClickForOneArgumentFunctions);
            // 
            // NegativeNumberCalculate
            // 
            this.NegativeNumberCalculate.Location = new System.Drawing.Point(417, 256);
            this.NegativeNumberCalculate.Name = "NegativeNumberCalculate";
            this.NegativeNumberCalculate.Size = new System.Drawing.Size(75, 23);
            this.NegativeNumberCalculate.TabIndex = 30;
            this.NegativeNumberCalculate.Text = "-x";
            this.NegativeNumberCalculate.UseVisualStyleBackColor = true;
            this.NegativeNumberCalculate.Click += new System.EventHandler(this.ButtonClickForOneArgumentFunctions);
            // 
            // TwoPowerNumberCalculate
            // 
            this.TwoPowerNumberCalculate.Location = new System.Drawing.Point(417, 285);
            this.TwoPowerNumberCalculate.Name = "TwoPowerNumberCalculate";
            this.TwoPowerNumberCalculate.Size = new System.Drawing.Size(75, 23);
            this.TwoPowerNumberCalculate.TabIndex = 31;
            this.TwoPowerNumberCalculate.Text = "2^x";
            this.TwoPowerNumberCalculate.UseVisualStyleBackColor = true;
            this.TwoPowerNumberCalculate.Click += new System.EventHandler(this.ButtonClickForOneArgumentFunctions);
            // 
            // TenPowerNumberCalculate
            // 
            this.TenPowerNumberCalculate.Location = new System.Drawing.Point(498, 111);
            this.TenPowerNumberCalculate.Name = "TenPowerNumberCalculate";
            this.TenPowerNumberCalculate.Size = new System.Drawing.Size(75, 23);
            this.TenPowerNumberCalculate.TabIndex = 32;
            this.TenPowerNumberCalculate.Text = "10^x";
            this.TenPowerNumberCalculate.UseVisualStyleBackColor = true;
            this.TenPowerNumberCalculate.Click += new System.EventHandler(this.ButtonClickForOneArgumentFunctions);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 324);
            this.Controls.Add(this.TenPowerNumberCalculate);
            this.Controls.Add(this.TwoPowerNumberCalculate);
            this.Controls.Add(this.NegativeNumberCalculate);
            this.Controls.Add(this.ModuleNumberCalculate);
            this.Controls.Add(this.NaturaleLogarithmCalculate);
            this.Controls.Add(this.LogarithmToTheBaseTenCalculate);
            this.Controls.Add(this.LogarithmCalculate);
            this.Controls.Add(this.ExponentialCalculate);
            this.Controls.Add(this.OneDivArgCalculate);
            this.Controls.Add(this.ArctanCalculate);
            this.Controls.Add(this.CtanCalculate);
            this.Controls.Add(this.ArccosCalculate);
            this.Controls.Add(this.ArcsinCalculate);
            this.Controls.Add(this.TanCalculate);
            this.Controls.Add(this.CosCalculate);
            this.Controls.Add(this.SinCalculate);
            this.Controls.Add(this.MidGeometricCalculate);
            this.Controls.Add(this.MiddleArithmeticCalculate);
            this.Controls.Add(this.MaxCalculate);
            this.Controls.Add(this.MinCalculate);
            this.Controls.Add(this.SqrtCalculate);
            this.Controls.Add(this.PowCalculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Value2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Value1);
            this.Controls.Add(this.DivisionCalculate);
            this.Controls.Add(this.MultiplyCalculate);
            this.Controls.Add(this.SubstractionCalculate);
            this.Controls.Add(this.AdditionCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdditionCalculate;
        private System.Windows.Forms.Button SubstractionCalculate;
        private System.Windows.Forms.Button MultiplyCalculate;
        private System.Windows.Forms.Button DivisionCalculate;
        private System.Windows.Forms.TextBox Value1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Value2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button PowCalculate;
        private System.Windows.Forms.Button SqrtCalculate;
        private System.Windows.Forms.Button MinCalculate;
        private System.Windows.Forms.Button MaxCalculate;
        private System.Windows.Forms.Button MiddleArithmeticCalculate;
        private System.Windows.Forms.Button MidGeometricCalculate;
        private System.Windows.Forms.Button SinCalculate;
        private System.Windows.Forms.Button CosCalculate;
        private System.Windows.Forms.Button TanCalculate;
        private System.Windows.Forms.Button ArcsinCalculate;
        private System.Windows.Forms.Button ArccosCalculate;
        private System.Windows.Forms.Button CtanCalculate;
        private System.Windows.Forms.Button ArctanCalculate;
        private System.Windows.Forms.Button OneDivArgCalculate;
        private System.Windows.Forms.Button ExponentialCalculate;
        private System.Windows.Forms.Button LogarithmCalculate;
        private System.Windows.Forms.Button LogarithmToTheBaseTenCalculate;
        private System.Windows.Forms.Button NaturaleLogarithmCalculate;
        private System.Windows.Forms.Button ModuleNumberCalculate;
        private System.Windows.Forms.Button NegativeNumberCalculate;
        private System.Windows.Forms.Button TwoPowerNumberCalculate;
        private System.Windows.Forms.Button TenPowerNumberCalculate;
    }
}

