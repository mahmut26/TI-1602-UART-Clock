/*
 * Created by SharpDevelop.
 * User: Mahmut T. Kanbollu
 * Date: 7.12.2021
 * Time: 15:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ODEV
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string gelver=string.Empty;
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
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void ButtonACClick(object sender, EventArgs e)
		{
			if(!serialPort1.IsOpen){
				serialPort1.PortName=textCOM.Text;
				serialPort1.BaudRate=Convert.ToInt32(textBaud.Text);
				serialPort1.DataBits=Convert.ToInt32(textData.Text);
				serialPort1.Open();
				
			}
			
		}
		
		void ButtonKapatClick(object sender, EventArgs e)
		{
			if(serialPort1.IsOpen){
				serialPort1.Close();
			}
		}
		
		void ButtonYazClick(object sender, EventArgs e)
		{
			serialPort1.Write(textGit.Text);
			
		}
		
		void ButtonSilClick(object sender, EventArgs e)
		{
			serialPort1.Write("/");
		}
		
		void ButtonAYAClick(object sender, EventArgs e)
		{
			serialPort1.Write("*"+textSaat.Text);			
		}
		
		void TextDataTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TextGitTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void SerialPort1DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			gelver=serialPort1.ReadLine();
			if(gelver=="+"){
				this.Invoke(new EventHandler(GText));
			}
			else if(gelver=="&"){
				this.Invoke(new EventHandler(AText));
			}
			
		
		}
		void GText(object sender, EventArgs e){
			textGel.Text=gelver[1].ToString()+gelver[2].ToString()+gelver[3].ToString()+gelver[4].ToString()+gelver[5].ToString()+gelver[6].ToString()+gelver[7].ToString();
		}
		void AText(object sender, EventArgs e){
			textAdc.Text=gelver[1].ToString()+gelver[2].ToString()+gelver[3].ToString()+gelver[4].ToString();
		}
		
		void TextGelTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TextAdcTextChanged(object sender, EventArgs e)
		{
			
		}
	}
}

