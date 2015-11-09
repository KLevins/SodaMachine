/*
 * Created by SharpDevelop.
 * User: User
 * Date: 09.11.2015
 * Time: 16:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SodaMachine
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
			this.Balance = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.Buy = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Information = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Change = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Balance
			// 
			this.Balance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Balance.Location = new System.Drawing.Point(17, 46);
			this.Balance.Multiline = true;
			this.Balance.Name = "Balance";
			this.Balance.ReadOnly = true;
			this.Balance.Size = new System.Drawing.Size(135, 19);
			this.Balance.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox5);
			this.groupBox1.Controls.Add(this.textBox4);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Location = new System.Drawing.Point(169, 26);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(185, 133);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "User Wallet";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(7, 103);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(72, 20);
			this.textBox5.TabIndex = 7;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(7, 75);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(72, 20);
			this.textBox4.TabIndex = 6;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(7, 47);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(72, 20);
			this.textBox3.TabIndex = 5;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(100, 103);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(79, 22);
			this.button4.TabIndex = 4;
			this.button4.Text = "50 cent";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(100, 75);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(79, 22);
			this.button3.TabIndex = 3;
			this.button3.Text = "25 cent";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(100, 47);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(79, 22);
			this.button2.TabIndex = 2;
			this.button2.Text = "5 cent";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(7, 19);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(72, 20);
			this.textBox2.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(100, 19);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(79, 22);
			this.button1.TabIndex = 0;
			this.button1.Text = "1 cent";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Buy
			// 
			this.Buy.Location = new System.Drawing.Point(17, 85);
			this.Buy.Name = "Buy";
			this.Buy.Size = new System.Drawing.Size(72, 23);
			this.Buy.TabIndex = 2;
			this.Buy.Text = "Buy Soda";
			this.Buy.UseVisualStyleBackColor = true;
			this.Buy.Click += new System.EventHandler(this.BuyClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(17, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Balance";
			// 
			// Information
			// 
			this.Information.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Information.Location = new System.Drawing.Point(17, 179);
			this.Information.Multiline = true;
			this.Information.Name = "Information";
			this.Information.ReadOnly = true;
			this.Information.Size = new System.Drawing.Size(331, 63);
			this.Information.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(17, 159);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Information";
			// 
			// Change
			// 
			this.Change.Location = new System.Drawing.Point(95, 85);
			this.Change.Name = "Change";
			this.Change.Size = new System.Drawing.Size(57, 23);
			this.Change.TabIndex = 6;
			this.Change.Text = "Change";
			this.Change.UseVisualStyleBackColor = true;
			this.Change.Click += new System.EventHandler(this.ChangeClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(366, 263);
			this.Controls.Add(this.Change);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Information);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Buy);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.Balance);
			this.Name = "MainForm";
			this.Text = "Soda Machine";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button Change;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Information;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Buy;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox Balance;
	}
}
