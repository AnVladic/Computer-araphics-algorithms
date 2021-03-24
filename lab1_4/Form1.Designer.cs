
namespace lab
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.d_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.m_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.n_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.xlabel = new System.Windows.Forms.Label();
            this.xtrackBar = new System.Windows.Forms.TrackBar();
            this.ytrackBar = new System.Windows.Forms.TrackBar();
            this.ylabel = new System.Windows.Forms.Label();
            this.ztrackBar = new System.Windows.Forms.TrackBar();
            this.zlabel = new System.Windows.Forms.Label();
            this.angletrackBar = new System.Windows.Forms.TrackBar();
            this.anglelabel = new System.Windows.Forms.Label();
            this.zoomtrackBar = new System.Windows.Forms.TrackBar();
            this.zoomlabel = new System.Windows.Forms.Label();
            this.useTextures = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ytrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ztrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angletrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomtrackBar)).BeginInit();
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
            this.AnT.Size = new System.Drawing.Size(771, 586);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            this.AnT.Load += new System.EventHandler(this.Form1_Load);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "По оси X",
            "По оси Y",
            "По оси Z"});
            this.comboBox1.Location = new System.Drawing.Point(790, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(790, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вращение по оси";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(790, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Объект визуализации";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "",
            "Куб",
            "Сфера",
            "",
            "",
            "Кубики"});
            this.comboBox2.Location = new System.Drawing.Point(790, 84);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(793, 123);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Сеточный вид";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.d_numericUpDown);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.m_numericUpDown);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.n_numericUpDown);
            this.groupBox1.Location = new System.Drawing.Point(1010, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 559);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Яблоко";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(45, 268);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Stop";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(84, 192);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Right";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.right_button_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(26, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Left";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.left_button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(45, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Down";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.down_button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.up_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "d";
            // 
            // d_numericUpDown
            // 
            this.d_numericUpDown.Location = new System.Drawing.Point(45, 77);
            this.d_numericUpDown.Name = "d_numericUpDown";
            this.d_numericUpDown.Size = new System.Drawing.Size(102, 20);
            this.d_numericUpDown.TabIndex = 4;
            this.d_numericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "m";
            // 
            // m_numericUpDown
            // 
            this.m_numericUpDown.Location = new System.Drawing.Point(45, 48);
            this.m_numericUpDown.Name = "m_numericUpDown";
            this.m_numericUpDown.Size = new System.Drawing.Size(102, 20);
            this.m_numericUpDown.TabIndex = 2;
            this.m_numericUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "n";
            // 
            // n_numericUpDown
            // 
            this.n_numericUpDown.Location = new System.Drawing.Point(45, 20);
            this.n_numericUpDown.Name = "n_numericUpDown";
            this.n_numericUpDown.Size = new System.Drawing.Size(102, 20);
            this.n_numericUpDown.TabIndex = 0;
            this.n_numericUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // xlabel
            // 
            this.xlabel.AutoSize = true;
            this.xlabel.Location = new System.Drawing.Point(790, 159);
            this.xlabel.Name = "xlabel";
            this.xlabel.Size = new System.Drawing.Size(12, 13);
            this.xlabel.TabIndex = 9;
            this.xlabel.Text = "x";
            // 
            // xtrackBar
            // 
            this.xtrackBar.Location = new System.Drawing.Point(832, 159);
            this.xtrackBar.Maximum = 100;
            this.xtrackBar.Minimum = -100;
            this.xtrackBar.Name = "xtrackBar";
            this.xtrackBar.Size = new System.Drawing.Size(172, 45);
            this.xtrackBar.TabIndex = 10;
            this.xtrackBar.Value = -13;
            this.xtrackBar.Scroll += new System.EventHandler(this.xtrackBar_Scroll);
            // 
            // ytrackBar
            // 
            this.ytrackBar.Location = new System.Drawing.Point(832, 210);
            this.ytrackBar.Maximum = 100;
            this.ytrackBar.Minimum = -100;
            this.ytrackBar.Name = "ytrackBar";
            this.ytrackBar.Size = new System.Drawing.Size(172, 45);
            this.ytrackBar.TabIndex = 12;
            this.ytrackBar.Value = -6;
            this.ytrackBar.Scroll += new System.EventHandler(this.ytrackBar_Scroll);
            // 
            // ylabel
            // 
            this.ylabel.AutoSize = true;
            this.ylabel.Location = new System.Drawing.Point(790, 210);
            this.ylabel.Name = "ylabel";
            this.ylabel.Size = new System.Drawing.Size(12, 13);
            this.ylabel.TabIndex = 11;
            this.ylabel.Text = "y";
            // 
            // ztrackBar
            // 
            this.ztrackBar.Location = new System.Drawing.Point(832, 261);
            this.ztrackBar.Maximum = 100;
            this.ztrackBar.Minimum = -100;
            this.ztrackBar.Name = "ztrackBar";
            this.ztrackBar.Size = new System.Drawing.Size(172, 45);
            this.ztrackBar.TabIndex = 14;
            this.ztrackBar.Value = -26;
            this.ztrackBar.Scroll += new System.EventHandler(this.ztrackBar_Scroll);
            // 
            // zlabel
            // 
            this.zlabel.AutoSize = true;
            this.zlabel.Location = new System.Drawing.Point(790, 261);
            this.zlabel.Name = "zlabel";
            this.zlabel.Size = new System.Drawing.Size(12, 13);
            this.zlabel.TabIndex = 13;
            this.zlabel.Text = "z";
            // 
            // angletrackBar
            // 
            this.angletrackBar.Location = new System.Drawing.Point(832, 326);
            this.angletrackBar.Maximum = 360;
            this.angletrackBar.Minimum = -360;
            this.angletrackBar.Name = "angletrackBar";
            this.angletrackBar.Size = new System.Drawing.Size(172, 45);
            this.angletrackBar.TabIndex = 16;
            this.angletrackBar.Value = 135;
            this.angletrackBar.Scroll += new System.EventHandler(this.angletrackBar_Scroll);
            // 
            // anglelabel
            // 
            this.anglelabel.AutoSize = true;
            this.anglelabel.Location = new System.Drawing.Point(772, 326);
            this.anglelabel.Name = "anglelabel";
            this.anglelabel.Size = new System.Drawing.Size(33, 13);
            this.anglelabel.TabIndex = 15;
            this.anglelabel.Text = "angle";
            // 
            // zoomtrackBar
            // 
            this.zoomtrackBar.Location = new System.Drawing.Point(832, 377);
            this.zoomtrackBar.Name = "zoomtrackBar";
            this.zoomtrackBar.Size = new System.Drawing.Size(172, 45);
            this.zoomtrackBar.TabIndex = 18;
            this.zoomtrackBar.Value = 1;
            this.zoomtrackBar.Scroll += new System.EventHandler(this.zoomtrackBar_Scroll);
            // 
            // zoomlabel
            // 
            this.zoomlabel.AutoSize = true;
            this.zoomlabel.Location = new System.Drawing.Point(790, 377);
            this.zoomlabel.Name = "zoomlabel";
            this.zoomlabel.Size = new System.Drawing.Size(32, 13);
            this.zoomlabel.TabIndex = 17;
            this.zoomlabel.Text = "zoom";
            // 
            // useTextures
            // 
            this.useTextures.AutoSize = true;
            this.useTextures.Location = new System.Drawing.Point(895, 123);
            this.useTextures.Name = "useTextures";
            this.useTextures.Size = new System.Drawing.Size(101, 17);
            this.useTextures.TabIndex = 19;
            this.useTextures.Text = "Исп. Текстуры";
            this.useTextures.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 584);
            this.Controls.Add(this.useTextures);
            this.Controls.Add(this.zoomtrackBar);
            this.Controls.Add(this.zoomlabel);
            this.Controls.Add(this.angletrackBar);
            this.Controls.Add(this.anglelabel);
            this.Controls.Add(this.ztrackBar);
            this.Controls.Add(this.zlabel);
            this.Controls.Add(this.ytrackBar);
            this.Controls.Add(this.ylabel);
            this.Controls.Add(this.xtrackBar);
            this.Controls.Add(this.xlabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AnT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ytrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ztrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angletrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomtrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown n_numericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown d_numericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown m_numericUpDown;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label xlabel;
        private System.Windows.Forms.TrackBar xtrackBar;
        private System.Windows.Forms.TrackBar ytrackBar;
        private System.Windows.Forms.Label ylabel;
        private System.Windows.Forms.TrackBar ztrackBar;
        private System.Windows.Forms.Label zlabel;
        private System.Windows.Forms.TrackBar angletrackBar;
        private System.Windows.Forms.Label anglelabel;
        private System.Windows.Forms.TrackBar zoomtrackBar;
        private System.Windows.Forms.Label zoomlabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox useTextures;
    }
}