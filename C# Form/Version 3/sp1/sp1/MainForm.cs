/*
 * Created by SharpDevelop.
 * User: Mahmut T. Kanbollu
 * Date: 5.12.2021
 * Time: 23:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace sp1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
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
		string gelen=string.Empty;
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void Label4Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
				if (!serialPort1.IsOpen){
				serialPort1.PortName=textcom.Text;
				serialPort1.BaudRate=Convert.ToInt32(textbrat.Text);
				serialPort1.DataBits=Convert.ToInt32(textdatb.Text);
			
				serialPort1.Open();
				}
			
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TextBox3TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void KapatClick(object sender, EventArgs e)
		{
			if (serialPort1.IsOpen){
				serialPort1.Close();
			}
			
		}
		
		void GONDERClick(object sender, EventArgs e)
		{
			serialPort1.Write(textsaay.Text);
		}
		
		void SerialPort1DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			gelen=serialPort1.ReadExisting();
			if(gelen=="#"){
				this.Invoke(new EventHandler(DisplayText));
			}
			
			else if(gelen=="*"){
				this.Invoke(new EventHandler(DisplayTex));
			}
			
		}
		private void DisplayText(object sender ,EventArgs e){
			textGELEN.Text=gelen+textGELEN.Text;
		}
		private void DisplayTex(object sender ,EventArgs e){
			textGELEN.Text=gelen+textGELEN.Text;
		}
	}
}
