/*
 * Created by SharpDevelop.
 * User: Mahmut T. Kanbollu
 * Date: 5.12.2021
 * Time: 23:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace sp1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.textcom = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textbrat = new System.Windows.Forms.TextBox();
			this.textdatb = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textsaay = new System.Windows.Forms.TextBox();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.textGELEN = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textcom
			// 
			this.textcom.Location = new System.Drawing.Point(149, 21);
			this.textcom.Name = "textcom";
			this.textcom.Size = new System.Drawing.Size(100, 22);
			this.textcom.TabIndex = 3;
			this.textcom.Text = "COM3";
			this.textcom.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(21, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "COM PORT";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(21, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "B-RATE";
			// 
			// textbrat
			// 
			this.textbrat.Location = new System.Drawing.Point(149, 68);
			this.textbrat.Name = "textbrat";
			this.textbrat.Size = new System.Drawing.Size(100, 22);
			this.textbrat.TabIndex = 6;
			this.textbrat.Text = "115200";
			// 
			// textdatb
			// 
			this.textdatb.Location = new System.Drawing.Point(149, 114);
			this.textdatb.Name = "textdatb";
			this.textdatb.Size = new System.Drawing.Size(100, 22);
			this.textdatb.TabIndex = 7;
			this.textdatb.Text = "8";
			this.textdatb.TextChanged += new System.EventHandler(this.TextBox3TextChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(21, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "DATABIT";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(21, 173);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "VERİ";
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// textsaay
			// 
			this.textsaay.Location = new System.Drawing.Point(149, 173);
			this.textsaay.Multiline = true;
			this.textsaay.Name = "textsaay";
			this.textsaay.Size = new System.Drawing.Size(198, 170);
			this.textsaay.TabIndex = 10;
			// 
			// serialPort1
			// 
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1DataReceived);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(21, 387);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "VERİ GELEN";
			// 
			// textGELEN
			// 
			this.textGELEN.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.textGELEN.Location = new System.Drawing.Point(149, 370);
			this.textGELEN.Multiline = true;
			this.textGELEN.Name = "textGELEN";
			this.textGELEN.Size = new System.Drawing.Size(258, 170);
			this.textGELEN.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(13, 568);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 23);
			this.label6.TabIndex = 14;
			this.label6.Text = "ADC";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(12, 603);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(61, 20);
			this.label7.TabIndex = 15;
			this.label7.Text = "SAAT";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(175, 565);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(118, 22);
			this.textBox1.TabIndex = 18;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(149, 601);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(173, 22);
			this.textBox2.TabIndex = 19;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(378, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(73, 30);
			this.button1.TabIndex = 20;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(378, 62);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(69, 28);
			this.button2.TabIndex = 21;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(378, 108);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(68, 27);
			this.button3.TabIndex = 22;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(378, 188);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(67, 37);
			this.button4.TabIndex = 23;
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(378, 265);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(66, 33);
			this.button5.TabIndex = 24;
			this.button5.Text = "button5";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(466, 667);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textGELEN);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textsaay);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textdatb);
			this.Controls.Add(this.textbrat);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textcom);
			this.Name = "MainForm";
			this.Text = "sp1";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textGELEN;
		private System.Windows.Forms.Label label5;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.TextBox textsaay;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textdatb;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textcom;
		private System.Windows.Forms.TextBox textbrat;
	}
}
