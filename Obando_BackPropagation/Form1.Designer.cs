namespace Obando_BackPropagation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            tabPage2 = new TabPage();
            textBox17 = new TextBox();
            textBox16 = new TextBox();
            textBox14 = new TextBox();
            textBox15 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            textBox1 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 44);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(802, 394);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox7);
            tabPage1.Controls.Add(textBox6);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Location = new Point(4, 35);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(794, 355);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "OR Gate";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(489, 251);
            button3.Name = "button3";
            button3.Size = new Size(177, 29);
            button3.TabIndex = 8;
            button3.Text = "Test";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(263, 251);
            button2.Name = "button2";
            button2.Size = new Size(220, 29);
            button2.TabIndex = 7;
            button2.Text = "Train the Neural Net";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(80, 251);
            button1.Name = "button1";
            button1.Size = new Size(177, 29);
            button1.TabIndex = 6;
            button1.Text = "Create BPNN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(192, 99);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 30);
            textBox7.TabIndex = 5;
            textBox7.Text = "Inputs";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(428, 99);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 30);
            textBox6.TabIndex = 4;
            textBox6.Text = "Result";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(428, 135);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 30);
            textBox5.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(192, 189);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 30);
            textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(192, 153);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 30);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(295, 42);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 30);
            textBox2.TabIndex = 0;
            textBox2.Text = "OR Gate Operation";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox17);
            tabPage2.Controls.Add(textBox16);
            tabPage2.Controls.Add(textBox14);
            tabPage2.Controls.Add(textBox15);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(textBox8);
            tabPage2.Controls.Add(textBox9);
            tabPage2.Controls.Add(textBox10);
            tabPage2.Controls.Add(textBox11);
            tabPage2.Controls.Add(textBox12);
            tabPage2.Controls.Add(textBox13);
            tabPage2.Location = new Point(4, 35);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(794, 355);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "AND Gate";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox17
            // 
            textBox17.Location = new Point(568, 110);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(125, 30);
            textBox17.TabIndex = 21;
            textBox17.Text = "Epoch";
            textBox17.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(516, 146);
            textBox16.Multiline = true;
            textBox16.Name = "textBox16";
            textBox16.ScrollBars = ScrollBars.Vertical;
            textBox16.Size = new Size(221, 131);
            textBox16.TabIndex = 20;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(170, 190);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(125, 30);
            textBox14.TabIndex = 19;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(170, 154);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(125, 30);
            textBox15.TabIndex = 18;
            // 
            // button4
            // 
            button4.Location = new Point(516, 302);
            button4.Name = "button4";
            button4.Size = new Size(177, 29);
            button4.TabIndex = 17;
            button4.Text = "Test";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(290, 302);
            button5.Name = "button5";
            button5.Size = new Size(220, 29);
            button5.TabIndex = 16;
            button5.Text = "Train the Neural Net";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(107, 302);
            button6.Name = "button6";
            button6.Size = new Size(177, 29);
            button6.TabIndex = 15;
            button6.Text = "Create BPNN";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(109, 110);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 30);
            textBox8.TabIndex = 14;
            textBox8.Text = "Inputs";
            textBox8.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(345, 110);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 30);
            textBox9.TabIndex = 13;
            textBox9.Text = "Result";
            textBox9.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(345, 146);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(125, 30);
            textBox10.TabIndex = 12;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(39, 190);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(125, 30);
            textBox11.TabIndex = 11;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(39, 154);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(125, 30);
            textBox12.TabIndex = 10;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(319, 58);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(172, 30);
            textBox13.TabIndex = 9;
            textBox13.Text = "OR Gate Operation";
            textBox13.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Poppins ExtraBold", 10F, FontStyle.Bold);
            textBox1.Location = new Point(255, 9);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 32);
            textBox1.TabIndex = 2;
            textBox1.Text = "BACKPROPAGATION";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox15;
        private TextBox textBox17;
        private TextBox textBox16;
    }
}
