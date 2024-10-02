/*
 * Created by SharpDevelop.
 * User: Mahmut T. Kanbollu
 * Date: 7.12.2021
 * Time: 15:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ODEV
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
			this.buttonAC = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textCOM = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBaud = new System.Windows.Forms.TextBox();
			this.buttonKapat = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textData = new System.Windows.Forms.TextBox();
			this.buttonYaz = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textGit = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textGel = new System.Windows.Forms.TextBox();
			this.buttonSil = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.textAdc = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.buttonAYA = new System.Windows.Forms.Button();
			this.textSaat = new System.Windows.Forms.TextBox();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.SuspendLayout();
			// 
			// buttonAC
			// 
			this.buttonAC.Location = new System.Drawing.Point(195, 12);
			this.buttonAC.Name = "buttonAC";
			this.buttonAC.Size = new System.Drawing.Size(75, 23);
			this.buttonAC.TabIndex = 0;
			this.buttonAC.Text = "AÇ";
			this.buttonAC.UseVisualStyleBackColor = true;
			this.buttonAC.Click += new System.EventHandler(this.ButtonACClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "COMPORT";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// textCOM
			// 
			this.textCOM.Location = new System.Drawing.Point(89, 15);
			this.textCOM.Name = "textCOM";
			this.textCOM.Size = new System.Drawing.Size(100, 22);
			this.textCOM.TabIndex = 2;
			this.textCOM.Text = "COM3";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "BAUDRATE";
			// 
			// textBaud
			// 
			this.textBaud.Location = new System.Drawing.Point(89, 43);
			this.textBaud.Name = "textBaud";
			this.textBaud.Size = new System.Drawing.Size(100, 22);
			this.textBaud.TabIndex = 4;
			this.textBaud.Text = "115200";
			// 
			// buttonKapat
			// 
			this.buttonKapat.Location = new System.Drawing.Point(195, 43);
			this.buttonKapat.Name = "buttonKapat";
			this.buttonKapat.Size = new System.Drawing.Size(75, 23);
			this.buttonKapat.TabIndex = 5;
			this.buttonKapat.Text = "KAPAT";
			this.buttonKapat.UseVisualStyleBackColor = true;
			this.buttonKapat.Click += new System.EventHandler(this.ButtonKapatClick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "DATABIT";
			// 
			// textData
			// 
			this.textData.Location = new System.Drawing.Point(89, 73);
			this.textData.Name = "textData";
			this.textData.Size = new System.Drawing.Size(100, 22);
			this.textData.TabIndex = 8;
			this.textData.Text = "8";
			this.textData.TextChanged += new System.EventHandler(this.TextDataTextChanged);
			// 
			// buttonYaz
			// 
			this.buttonYaz.Location = new System.Drawing.Point(195, 101);
			this.buttonYaz.Name = "buttonYaz";
			this.buttonYaz.Size = new System.Drawing.Size(75, 23);
			this.buttonYaz.TabIndex = 9;
			this.buttonYaz.Text = "YAZ";
			this.buttonYaz.UseVisualStyleBackColor = true;
			this.buttonYaz.Click += new System.EventHandler(this.ButtonYazClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "GIDEN VERI";
			// 
			// textGit
			// 
			this.textGit.Location = new System.Drawing.Point(89, 102);
			this.textGit.Name = "textGit";
			this.textGit.Size = new System.Drawing.Size(100, 22);
			this.textGit.TabIndex = 11;
			this.textGit.TextChanged += new System.EventHandler(this.TextGitTextChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 130);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "GELEN VERI";
			// 
			// textGel
			// 
			this.textGel.Location = new System.Drawing.Point(89, 130);
			this.textGel.Name = "textGel";
			this.textGel.Size = new System.Drawing.Size(100, 22);
			this.textGel.TabIndex = 13;
			this.textGel.TextChanged += new System.EventHandler(this.TextGelTextChanged);
			// 
			// buttonSil
			// 
			this.buttonSil.Location = new System.Drawing.Point(195, 130);
			this.buttonSil.Name = "buttonSil";
			this.buttonSil.Size = new System.Drawing.Size(75, 23);
			this.buttonSil.TabIndex = 14;
			this.buttonSil.Text = "SİL";
			this.buttonSil.UseVisualStyleBackColor = true;
			this.buttonSil.Click += new System.EventHandler(this.ButtonSilClick);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 160);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 15;
			this.label6.Text = "ADC VERISI";
			// 
			// textAdc
			// 
			this.textAdc.Location = new System.Drawing.Point(89, 160);
			this.textAdc.Name = "textAdc";
			this.textAdc.Size = new System.Drawing.Size(100, 22);
			this.textAdc.TabIndex = 16;
			this.textAdc.TextChanged += new System.EventHandler(this.TextAdcTextChanged);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(6, 191);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 18;
			this.label7.Text = "SAAT AYAR";
			// 
			// buttonAYA
			// 
			this.buttonAYA.Location = new System.Drawing.Point(195, 188);
			this.buttonAYA.Name = "buttonAYA";
			this.buttonAYA.Size = new System.Drawing.Size(75, 23);
			this.buttonAYA.TabIndex = 19;
			this.buttonAYA.Text = "AYARLA";
			this.buttonAYA.UseVisualStyleBackColor = true;
			this.buttonAYA.Click += new System.EventHandler(this.ButtonAYAClick);
			// 
			// textSaat
			// 
			this.textSaat.Location = new System.Drawing.Point(89, 189);
			this.textSaat.Name = "textSaat";
			this.textSaat.Size = new System.Drawing.Size(100, 22);
			this.textSaat.TabIndex = 20;
			// 
			// serialPort1
			// 
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1DataReceived);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(282, 253);
			this.Controls.Add(this.textSaat);
			this.Controls.Add(this.buttonAYA);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textAdc);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.buttonSil);
			this.Controls.Add(this.textGel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textGit);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.buttonYaz);
			this.Controls.Add(this.textData);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.buttonKapat);
			this.Controls.Add(this.textBaud);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textCOM);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonAC);
			this.Name = "MainForm";
			this.Text = "ODEV";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.TextBox textSaat;
		private System.Windows.Forms.Button buttonAYA;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textAdc;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button buttonSil;
		private System.Windows.Forms.TextBox textGel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textGit;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonYaz;
		private System.Windows.Forms.TextBox textData;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonKapat;
		private System.Windows.Forms.TextBox textBaud;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textCOM;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonAC;
	}
}
