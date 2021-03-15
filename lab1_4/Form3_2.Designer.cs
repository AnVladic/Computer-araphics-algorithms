
namespace lab1_4
{
    partial class Form3_2
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
            this.components = new System.ComponentModel.Container();
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.PointInGrap = new System.Windows.Forms.Timer(this.components);
            this.maxXSet = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minXSet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.maxYSet = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.minYSet = new System.Windows.Forms.NumericUpDown();
            this.FunctionsBox = new System.Windows.Forms.ComboBox();
            this.Apply = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorPicker = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.maxXSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minXSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxYSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minYSet)).BeginInit();
            this.SuspendLayout();
            // 
            // AnT
            // 
            this.AnT.AccumBits = ((byte)(0));
            this.AnT.AutoCheckErrors = false;
            this.AnT.AutoFinish = false;
            this.AnT.AutoMakeCurrent = true;
            this.AnT.AutoSwapBuffers = true;
            this.AnT.BackColor = System.Drawing.Color.Black;
            this.AnT.ColorBits = ((byte)(32));
            this.AnT.DepthBits = ((byte)(16));
            this.AnT.Location = new System.Drawing.Point(-5, -2);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(548, 548);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            this.AnT.Load += new System.EventHandler(this.Form3_2_Load);
            this.AnT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseMove);
            // 
            // PointInGrap
            // 
            this.PointInGrap.Interval = 30;
            this.PointInGrap.Tick += new System.EventHandler(this.PointInGrap_Tick);
            // 
            // maxXSet
            // 
            this.maxXSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxXSet.Location = new System.Drawing.Point(549, 31);
            this.maxXSet.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.maxXSet.Name = "maxXSet";
            this.maxXSet.Size = new System.Drawing.Size(179, 23);
            this.maxXSet.TabIndex = 2;
            this.maxXSet.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.maxXSet.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(545, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Max X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(545, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Min X:";
            // 
            // minXSet
            // 
            this.minXSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minXSet.Location = new System.Drawing.Point(549, 84);
            this.minXSet.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.minXSet.Name = "minXSet";
            this.minXSet.Size = new System.Drawing.Size(179, 23);
            this.minXSet.TabIndex = 4;
            this.minXSet.Value = new decimal(new int[] {
            15,
            0,
            0,
            -2147483648});
            this.minXSet.ValueChanged += new System.EventHandler(this.minXSet_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(545, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Max Y:";
            // 
            // maxYSet
            // 
            this.maxYSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxYSet.Location = new System.Drawing.Point(549, 137);
            this.maxYSet.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.maxYSet.Name = "maxYSet";
            this.maxYSet.Size = new System.Drawing.Size(179, 23);
            this.maxYSet.TabIndex = 6;
            this.maxYSet.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.maxYSet.ValueChanged += new System.EventHandler(this.maxYSet_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(547, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Min Y:";
            // 
            // minYSet
            // 
            this.minYSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minYSet.Location = new System.Drawing.Point(551, 190);
            this.minYSet.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.minYSet.Name = "minYSet";
            this.minYSet.Size = new System.Drawing.Size(179, 23);
            this.minYSet.TabIndex = 8;
            this.minYSet.Value = new decimal(new int[] {
            15,
            0,
            0,
            -2147483648});
            this.minYSet.ValueChanged += new System.EventHandler(this.minYSet_ValueChanged_1);
            // 
            // FunctionsBox
            // 
            this.FunctionsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FunctionsBox.FormattingEnabled = true;
            this.FunctionsBox.Items.AddRange(new object[] {
            "sin(x) * 3 + 1",
            "|x| - 2",
            "x^2"});
            this.FunctionsBox.Location = new System.Drawing.Point(551, 262);
            this.FunctionsBox.Name = "FunctionsBox";
            this.FunctionsBox.Size = new System.Drawing.Size(177, 24);
            this.FunctionsBox.TabIndex = 10;
            this.FunctionsBox.Text = "sin(x) * 3 + 1";
            this.FunctionsBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Apply
            // 
            this.Apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Apply.Location = new System.Drawing.Point(570, 480);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(158, 49);
            this.Apply.TabIndex = 11;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // colorPicker
            // 
            this.colorPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorPicker.FormattingEnabled = true;
            this.colorPicker.Location = new System.Drawing.Point(551, 292);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(177, 24);
            this.colorPicker.TabIndex = 12;
            this.colorPicker.Text = "Red";
            // 
            // Form3_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 541);
            this.Controls.Add(this.colorPicker);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.FunctionsBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.minYSet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxYSet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minXSet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxXSet);
            this.Controls.Add(this.AnT);
            this.Name = "Form3_2";
            this.Text = "Form3_2";
            ((System.ComponentModel.ISupportInitialize)(this.maxXSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minXSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxYSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minYSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.Timer PointInGrap;
        private System.Windows.Forms.NumericUpDown maxXSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown minXSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown maxYSet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown minYSet;
        private System.Windows.Forms.ComboBox FunctionsBox;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox colorPicker;
    }
}