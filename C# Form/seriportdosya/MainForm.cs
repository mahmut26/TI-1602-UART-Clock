/*
 * Created by SharpDevelop.
 * User: Mahmut T. Kanbollu
 * Date: 8.12.2021
 * Time: 13:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace seriportdosya
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string gelenveri;
		int i=2;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (!serialPort1.IsOpen)
			{
				serialPort1.PortName=textBox4.Text;
				serialPort1.BaudRate=Convert.ToInt32(textBox1.Text);
				serialPort1.Open();
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			if (serialPort1.IsOpen)
			{
				serialPort1.Close();
			}
		}
		void SerialPort1DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			gelenveri=serialPort1.ReadExisting();
			this.Invoke(new EventHandler(goster));
		}
		private void goster(object sender, EventArgs e)
		{
			if (i==0)
			{
				textBox6.Text=textBox6.Text+gelenveri;
				i++;
			}
			else if (i==1)
			{
				textBox6.Text=textBox6.Text+gelenveri;
				i++;
			}
			else
			{
				textBox3.Text=textBox3.Text+gelenveri;
				i++;
			}
		}
		void Button3Click(object sender, EventArgs e)
		{
			serialPort1.Write('*'+textcom.Text);
			textBox3.Text="";
			i=2;
		}
		void Button4Click(object sender, EventArgs e)
		{
			serialPort1.Write('#'+textBox5.Text);
		}
		void Button5Click(object sender, EventArgs e)
		{
			serialPort1.Write("&");
			textBox6.Text="";
			i=0;
		}
	}
}
