using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SodaMachine
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private List<int> UserWallet = new List<int>{30, 10, 4, 4};
		private List<int> MachineWallet = new List<int>{2, 2, 2, 2};
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		private void MainForm_Load(object sender, EventArgs e)
		{			
			Information.Text = "Hello! Soda Machine sells a cup of soda for 30 cent.";
			textBox2.Text = UserWallet[0].ToString();
			textBox3.Text = UserWallet[1].ToString();
			textBox4.Text = UserWallet[2].ToString();
			textBox5.Text = UserWallet[3].ToString();
			Balance.Text = "0";
		}
		
		//1 cent
		void Button1Click(object sender, EventArgs e)
		{
			Information.Text = "Hello! Soda Machine sells a cup of soda for 30 cent.";
			if (UserWallet[0] > 0)
			{
				UserWallet[0] = --UserWallet[0];
				textBox2.Text = UserWallet[0].ToString();
				Balance.Text = (Int32.Parse(Balance.Text) + 1).ToString();
				MachineWallet[0] = ++MachineWallet[0];
			}
			else
			{
				Information.Text = "Sorry, you don't have this coins: 1 cent";
			}
		}
		
		//5 cent
		void Button2Click(object sender, EventArgs e)
		{
			Information.Text = "Hello! Soda Machine sells a cup of soda for 30 cent.";
			if (UserWallet[1] > 0)
			{
				UserWallet[1] = --UserWallet[1];
				textBox3.Text = UserWallet[1].ToString();
				Balance.Text = (Int32.Parse(Balance.Text) + 5).ToString();
				MachineWallet[1] = ++MachineWallet[1];
			}
			else
			{
				Information.Text = "Sorry, you don't have this coins: 5 cent";
			}
		}
		
		//25 cent
		void Button3Click(object sender, EventArgs e)
		{
			Information.Text = "Hello! Soda Machine sells a cup of soda for 30 cent.";
			if (UserWallet[2] > 0)
			{
				UserWallet[2] = --UserWallet[2];
				textBox4.Text = UserWallet[2].ToString();
				Balance.Text = (Int32.Parse(Balance.Text) + 25).ToString();
				MachineWallet[2] = ++MachineWallet[2];
			}
			else
			{
				Information.Text = "Sorry, you don't have this coins: 25 cent";
			}
		}
		
		//50 cent
		void Button4Click(object sender, EventArgs e)
		{
			Information.Text = "Hello! Soda Machine sells a cup of soda for 30 cent.";
			if (UserWallet[3] > 0)
			{
				UserWallet[3] = --UserWallet[3];
				textBox5.Text = UserWallet[3].ToString();
				Balance.Text = (Int32.Parse(Balance.Text) + 50).ToString();
				MachineWallet[3] = ++MachineWallet[3];
			}
			else
			{
				Information.Text = "Sorry, you don't have this coins: 50 cent";
			}
		}
		
		//Buy Soda		
		void BuyClick(object sender, EventArgs e)
		{
			if (Int32.Parse(Balance.Text) >= 30)
			{
				Information.Text = "Bon Appetit!";
				Balance.Text = (Int32.Parse(Balance.Text) - 30).ToString();
			}
			else
			{
				Information.Text = "The balance is not enough. It is 30 cent.";
			}
		}
		
		//Change
		void ChangeClick(object sender, EventArgs e)
		{
			if (Int32.Parse(Balance.Text) > 0)
			{
				//Change for 50 cent coins
				for(int i = 0; i < 6; i++)
				{
					if (Int32.Parse(Balance.Text) / 50 >= 1)
					{
						if (Int32.Parse(textBox5.Text) == 6)
							break;
						Balance.Text = (Int32.Parse(Balance.Text) - 50).ToString();
						UserWallet[3] = ++UserWallet[3];
						MachineWallet[3] = --MachineWallet[3];
						textBox5.Text = (Int32.Parse(textBox5.Text) + 1).ToString();
					}
				}
				
				//Change for 25 cent coins
				for(int i = 0; i < 3; i++)
				{
					if (Int32.Parse(Balance.Text) / 25 >= 1)
					{
						if (Int32.Parse(textBox4.Text) == 6)
							break;
						Balance.Text = (Int32.Parse(Balance.Text) - 25).ToString();
						UserWallet[2] = ++UserWallet[2];
						MachineWallet[2] = --MachineWallet[2];
						textBox4.Text = (Int32.Parse(textBox4.Text) + 1).ToString();
					}
				}
				
				//Change for 5 cent coins
				for(int i = 0; i < 4; i++)
				{
					if (Int32.Parse(textBox3.Text) == 12)
							break;
					if (Int32.Parse(Balance.Text) / 5 >= 1)
					{
						Balance.Text = (Int32.Parse(Balance.Text) - 5).ToString();
						UserWallet[1] = ++UserWallet[1];
						MachineWallet[1] = --MachineWallet[1];
						textBox3.Text = (Int32.Parse(textBox3.Text) + 1).ToString();
					}
				}
				
				//Change for 1 cent coins
				for(int i = 0; i < 20; i++)
				{
					if (Int32.Parse(textBox2.Text) == 32)
							break;
					if (Int32.Parse(Balance.Text) / 1 >= 1)
					{
						Balance.Text = (Int32.Parse(Balance.Text) - 1).ToString();
						UserWallet[0] = ++UserWallet[0];
						MachineWallet[0] = --MachineWallet[0];
						textBox2.Text = (Int32.Parse(textBox2.Text) + 1).ToString();
					}
				}
				
				//Machine have not enough change. Pleace add coins and buy other soda 
				if (Int32.Parse(Balance.Text) > 0)
				{
					Information.Text = "Machine have not enough change. Pleace add coins and buy other soda";
				}
			}
			else
			{
				Information.Text = "Current balance is 0";
			}
		}
	}
}
