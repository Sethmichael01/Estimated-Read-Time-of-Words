/*
 * Created by SharpDevelop.
 * User: sethm
 * Date: 8 Nov 2019
 * Time: 2:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace win
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
		
		void Button1Click(object sender, EventArgs e)
		{
			if(richTextBox1.Text.Length >=1){
				textBox1.Text=richTextBox1.Text.Replace(" ","");
				textBox1.Text=richTextBox1.Text.Replace(".","");
				textBox1.Text=richTextBox1.Text.Replace(",","");
				textBox2.Text= Convert.ToString(richTextBox1.Text.Length);
				double TextLength = Convert.ToDouble(richTextBox1.Text.Length)/200;
				int Minute = (int)TextLength;
				double Seconds = Convert.ToDouble(TextLength);
				double multiplication = (Seconds - Minute) * 0.60;
           		double _ans = Convert.ToDouble(String.Format("{0:00.00}", multiplication));
           		double _finalsec = Convert.ToDouble(_ans.ToString().Split('.')[1]);
           		if (_finalsec < 30)
            		{
           			textBox2.Text=""+textBox1.TextLength+" Words. Estimated Read Time "+Minute+" Minute(s).";     
           		}           		
           		else if(_finalsec >=30){
           			Minute += 1;
           			textBox2.Text=""+textBox1.TextLength+" Words. Estimated Read Time "+Minute+" Minute(s).";
           		}
           			
			}
			else if(richTextBox1.Text.Length<1){
				MessageBox.Show("Cannot Count an Empty Word!");
			}
	
		}
		void Button2Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
			textBox2.Clear();
			textBox1.Clear();
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			//richTextBox1.Text = richTextBox1.Text.Replace(" ","");
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button3Click(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
	}
}
