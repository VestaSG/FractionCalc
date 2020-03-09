namespace FractionCalc
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.calcButton = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.replaseButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(40, 16);
			this.textBox1.MaxLength = 6;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(88, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(40, 64);
			this.textBox2.MaxLength = 6;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(88, 20);
			this.textBox2.TabIndex = 1;
			this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Location = new System.Drawing.Point(24, 48);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(120, 1);
			this.panel1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Location = new System.Drawing.Point(288, 48);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(120, 1);
			this.panel2.TabIndex = 6;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(304, 64);
			this.textBox3.MaxLength = 6;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(88, 20);
			this.textBox3.TabIndex = 5;
			this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(304, 16);
			this.textBox4.MaxLength = 6;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(88, 20);
			this.textBox4.TabIndex = 4;
			this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
			// 
			// calcButton
			// 
			this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.calcButton.Location = new System.Drawing.Point(424, 16);
			this.calcButton.Name = "calcButton";
			this.calcButton.Size = new System.Drawing.Size(80, 72);
			this.calcButton.TabIndex = 7;
			this.calcButton.Text = "Calc";
			this.calcButton.UseVisualStyleBackColor = true;
			this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Location = new System.Drawing.Point(528, 48);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(120, 1);
			this.panel3.TabIndex = 10;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(544, 64);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(88, 20);
			this.textBox5.TabIndex = 9;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(544, 16);
			this.textBox6.Name = "textBox6";
			this.textBox6.ReadOnly = true;
			this.textBox6.Size = new System.Drawing.Size(88, 20);
			this.textBox6.TabIndex = 8;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "*",
            "/",
            "+",
            "-"});
			this.comboBox1.Location = new System.Drawing.Point(176, 40);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(72, 21);
			this.comboBox1.TabIndex = 11;
			// 
			// replaseButton
			// 
			this.replaseButton.Location = new System.Drawing.Point(176, 72);
			this.replaseButton.Name = "replaseButton";
			this.replaseButton.Size = new System.Drawing.Size(72, 24);
			this.replaseButton.TabIndex = 12;
			this.replaseButton.Text = "<->";
			this.replaseButton.UseVisualStyleBackColor = true;
			this.replaseButton.Click += new System.EventHandler(this.replaseButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(685, 124);
			this.Controls.Add(this.replaseButton);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.calcButton);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Frm1";
			this.Activated += new System.EventHandler(this.Form1_Activated);
			this.Shown += new System.EventHandler(this.Form1_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button calcButton;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button replaseButton;
	}
}

