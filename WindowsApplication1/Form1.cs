using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsApplication1;

public class Form1 : Form
{
	private int a;

	private int b;

	private string d;

	private IContainer components = null;

	private TextBox textBox1;

	private Button button14;

	private Button button6;

	private Button button5;

	private Button button7;

	private Button button3;

	private Button button8;

	private Button button2;

	private Button button9;

	private Button button1;

	private Button button11;

	private Button button4;

	private Button button10;

	private Button button12;

	private Button button15;

	private Button button16;

	private Button button17;

	private Label label1;

	public Form1()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (textBox1.Text == "0")
		{
			textBox1.Text = "1";
		}
		else
		{
			textBox1.Text += "1";
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		if (textBox1.Text == "0")
		{
			textBox1.Text = "2";
		}
		else
		{
			textBox1.Text += "2";
		}
	}

	private void button3_Click(object sender, EventArgs e)
	{
		if (textBox1.Text == "0")
		{
			textBox1.Text = "3";
		}
		else
		{
			textBox1.Text += "3";
		}
	}

	private void button4_Click(object sender, EventArgs e)
	{
		if (textBox1.Text == "0")
		{
			textBox1.Text = "4";
		}
		else
		{
			textBox1.Text += "4";
		}
	}

	private void button5_Click(object sender, EventArgs e)
	{
		if (textBox1.Text == "0")
		{
			textBox1.Text = "5";
		}
		else
		{
			textBox1.Text += "5";
		}
	}

	private void button6_Click(object sender, EventArgs e)
	{
		if (textBox1.Text == "0")
		{
			textBox1.Text = "6";
		}
		else
		{
			textBox1.Text += "6";
		}
	}

	private void button7_Click(object sender, EventArgs e)
	{
		if (textBox1.Text == "0")
		{
			textBox1.Text = "7";
		}
		else
		{
			textBox1.Text += "7";
		}
	}

	private void button8_Click(object sender, EventArgs e)
	{
		if (textBox1.Text == "0")
		{
			textBox1.Text = "8";
		}
		else
		{
			textBox1.Text += "8";
		}
	}

	private void button9_Click(object sender, EventArgs e)
	{
		if (textBox1.Text == "0")
		{
			textBox1.Text = "9";
		}
		else
		{
			textBox1.Text += "9";
		}
	}

	private void button11_Click(object sender, EventArgs e)
	{
		if (textBox1.Text == "0")
		{
			textBox1.Text = "0";
		}
		else
		{
			textBox1.Text += "0";
		}
	}

	private void button10_Click(object sender, EventArgs e)
	{
		a = Convert.ToInt16(textBox1.Text);
		d = "+";
		textBox1.Text = "";
	}

	private void button12_Click(object sender, EventArgs e)
	{
		a = Convert.ToInt16(textBox1.Text);
		d = "-";
		textBox1.Text = "";
	}

	private void button14_Click(object sender, EventArgs e)
	{
		a = Convert.ToInt16(textBox1.Text);
		d = "*";
		textBox1.Text = "";
	}

	private void button15_Click(object sender, EventArgs e)
	{
		a = Convert.ToInt16(textBox1.Text);
		d = "/";
		textBox1.Text = "";
	}

	private void button17_Click(object sender, EventArgs e)
	{
		b = Convert.ToInt16(textBox1.Text);
		if (d == "")
		{
			MessageBox.Show("Öncelikle Sayı girişi ve işlem şeçimi yapın", "Uyarı");
		}
		if (d == "+")
		{
			textBox1.Text = Convert.ToString(a + b);
		}
		if (d == "-")
		{
			textBox1.Text = Convert.ToString((sbyte)(a - b));
		}
		if (d == "*")
		{
			textBox1.Text = Convert.ToString(a * b);
		}
		if (d == "/")
		{
			textBox1.Text = Convert.ToString(a / b);
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		d = "";
	}

	private void button16_Click(object sender, EventArgs e)
	{
		a = 0;
		b = 0;
		d = "";
		textBox1.Text = "0";
	}

	private void button18_Click(object sender, EventArgs e)
	{
	}

	private void groupBox2_Enter(object sender, EventArgs e)
	{
	}

	private void button19_Click(object sender, EventArgs e)
	{
		textBox1.Text.Substring(1, 5);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.button14 = new System.Windows.Forms.Button();
		this.button6 = new System.Windows.Forms.Button();
		this.button5 = new System.Windows.Forms.Button();
		this.button7 = new System.Windows.Forms.Button();
		this.button3 = new System.Windows.Forms.Button();
		this.button8 = new System.Windows.Forms.Button();
		this.button2 = new System.Windows.Forms.Button();
		this.button9 = new System.Windows.Forms.Button();
		this.button1 = new System.Windows.Forms.Button();
		this.button11 = new System.Windows.Forms.Button();
		this.button4 = new System.Windows.Forms.Button();
		this.button10 = new System.Windows.Forms.Button();
		this.button12 = new System.Windows.Forms.Button();
		this.button15 = new System.Windows.Forms.Button();
		this.button16 = new System.Windows.Forms.Button();
		this.button17 = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.textBox1.BackColor = System.Drawing.Color.Red;
		this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
		this.textBox1.ForeColor = System.Drawing.Color.Black;
		this.textBox1.Location = new System.Drawing.Point(109, 32);
		this.textBox1.Multiline = true;
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new System.Drawing.Size(355, 88);
		this.textBox1.TabIndex = 0;
		this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.button14.ForeColor = System.Drawing.Color.Red;
		this.button14.Location = new System.Drawing.Point(364, 186);
		this.button14.Name = "button14";
		this.button14.Size = new System.Drawing.Size(36, 46);
		this.button14.TabIndex = 17;
		this.button14.Text = "X";
		this.button14.UseVisualStyleBackColor = true;
		this.button14.Click += new System.EventHandler(this.button14_Click);
		this.button6.ForeColor = System.Drawing.Color.Red;
		this.button6.Location = new System.Drawing.Point(438, 265);
		this.button6.Name = "button6";
		this.button6.Size = new System.Drawing.Size(39, 57);
		this.button6.TabIndex = 6;
		this.button6.Text = "6";
		this.button6.UseVisualStyleBackColor = true;
		this.button6.Click += new System.EventHandler(this.button6_Click);
		this.button5.ForeColor = System.Drawing.Color.Red;
		this.button5.Location = new System.Drawing.Point(363, 265);
		this.button5.Name = "button5";
		this.button5.Size = new System.Drawing.Size(37, 57);
		this.button5.TabIndex = 5;
		this.button5.Text = "5";
		this.button5.UseVisualStyleBackColor = true;
		this.button5.Click += new System.EventHandler(this.button5_Click);
		this.button7.ForeColor = System.Drawing.Color.Red;
		this.button7.Location = new System.Drawing.Point(146, 328);
		this.button7.Name = "button7";
		this.button7.Size = new System.Drawing.Size(39, 57);
		this.button7.TabIndex = 7;
		this.button7.Text = "7";
		this.button7.UseVisualStyleBackColor = true;
		this.button7.Click += new System.EventHandler(this.button7_Click);
		this.button3.ForeColor = System.Drawing.Color.Red;
		this.button3.Location = new System.Drawing.Point(249, 265);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(39, 57);
		this.button3.TabIndex = 3;
		this.button3.Text = "3";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(this.button3_Click);
		this.button8.ForeColor = System.Drawing.Color.Red;
		this.button8.Location = new System.Drawing.Point(197, 328);
		this.button8.Name = "button8";
		this.button8.Size = new System.Drawing.Size(40, 57);
		this.button8.TabIndex = 8;
		this.button8.Text = "8";
		this.button8.UseVisualStyleBackColor = true;
		this.button8.Click += new System.EventHandler(this.button8_Click);
		this.button2.ForeColor = System.Drawing.Color.Red;
		this.button2.Location = new System.Drawing.Point(197, 265);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(39, 57);
		this.button2.TabIndex = 2;
		this.button2.Text = "2";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(this.button2_Click);
		this.button9.ForeColor = System.Drawing.Color.Red;
		this.button9.Location = new System.Drawing.Point(249, 328);
		this.button9.Name = "button9";
		this.button9.Size = new System.Drawing.Size(39, 57);
		this.button9.TabIndex = 9;
		this.button9.Text = "9";
		this.button9.UseVisualStyleBackColor = true;
		this.button9.Click += new System.EventHandler(this.button9_Click);
		this.button1.ForeColor = System.Drawing.Color.Red;
		this.button1.Location = new System.Drawing.Point(146, 265);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(37, 57);
		this.button1.TabIndex = 1;
		this.button1.Text = "1";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(this.button1_Click);
		this.button11.ForeColor = System.Drawing.Color.Red;
		this.button11.Location = new System.Drawing.Point(303, 328);
		this.button11.Name = "button11";
		this.button11.Size = new System.Drawing.Size(39, 57);
		this.button11.TabIndex = 11;
		this.button11.Text = "0";
		this.button11.UseVisualStyleBackColor = true;
		this.button11.Click += new System.EventHandler(this.button11_Click);
		this.button4.ForeColor = System.Drawing.Color.Red;
		this.button4.Location = new System.Drawing.Point(303, 265);
		this.button4.Name = "button4";
		this.button4.Size = new System.Drawing.Size(40, 57);
		this.button4.TabIndex = 4;
		this.button4.Text = "4";
		this.button4.UseVisualStyleBackColor = true;
		this.button4.Click += new System.EventHandler(this.button4_Click);
		this.button10.ForeColor = System.Drawing.Color.Red;
		this.button10.Location = new System.Drawing.Point(146, 191);
		this.button10.Name = "button10";
		this.button10.Size = new System.Drawing.Size(33, 37);
		this.button10.TabIndex = 14;
		this.button10.Text = "+";
		this.button10.UseVisualStyleBackColor = true;
		this.button10.Click += new System.EventHandler(this.button10_Click);
		this.button12.ForeColor = System.Drawing.Color.Red;
		this.button12.Location = new System.Drawing.Point(308, 186);
		this.button12.Name = "button12";
		this.button12.Size = new System.Drawing.Size(35, 46);
		this.button12.TabIndex = 15;
		this.button12.Text = "-";
		this.button12.UseVisualStyleBackColor = true;
		this.button12.Click += new System.EventHandler(this.button12_Click);
		this.button15.ForeColor = System.Drawing.Color.Red;
		this.button15.Location = new System.Drawing.Point(423, 191);
		this.button15.Name = "button15";
		this.button15.Size = new System.Drawing.Size(54, 46);
		this.button15.TabIndex = 18;
		this.button15.Text = "BÖLME";
		this.button15.UseVisualStyleBackColor = true;
		this.button15.Click += new System.EventHandler(this.button15_Click);
		this.button16.ForeColor = System.Drawing.Color.Red;
		this.button16.Location = new System.Drawing.Point(249, 186);
		this.button16.Name = "button16";
		this.button16.Size = new System.Drawing.Size(35, 46);
		this.button16.TabIndex = 19;
		this.button16.Text = "C";
		this.button16.UseVisualStyleBackColor = true;
		this.button16.Click += new System.EventHandler(this.button16_Click);
		this.button17.ForeColor = System.Drawing.Color.Red;
		this.button17.Location = new System.Drawing.Point(197, 186);
		this.button17.Name = "button17";
		this.button17.Size = new System.Drawing.Size(35, 46);
		this.button17.TabIndex = 20;
		this.button17.Text = "=";
		this.button17.UseVisualStyleBackColor = true;
		this.button17.Click += new System.EventHandler(this.button17_Click);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(246, 66);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(93, 13);
		this.label1.TabIndex = 21;
		this.label1.Text = "ÇAĞAN TURGUT";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(529, 528);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.button4);
		base.Controls.Add(this.button11);
		base.Controls.Add(this.button17);
		base.Controls.Add(this.button1);
		base.Controls.Add(this.button16);
		base.Controls.Add(this.button9);
		base.Controls.Add(this.button2);
		base.Controls.Add(this.button15);
		base.Controls.Add(this.button8);
		base.Controls.Add(this.button14);
		base.Controls.Add(this.button3);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.button7);
		base.Controls.Add(this.button12);
		base.Controls.Add(this.button5);
		base.Controls.Add(this.button10);
		base.Controls.Add(this.button6);
		base.Name = "Form1";
		this.Text = "Hesap Makinesi";
		base.Load += new System.EventHandler(this.Form1_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
