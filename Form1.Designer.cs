// Decompiled with JetBrains decompiler
// Type: EstrogenExecutor2._0.EstrogenExecutor
// Assembly: EstrogenExecutor2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6E8A97EC-0E47-43F1-ABB1-09CC8D424B21
// Assembly location: C:\Users\Manoli\Downloads\EstrogenExecutor2.0\EstrogenExecutor2.0\EstrogenExecutor2.0.exe

using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstrogenExecutor2._0
{
  public class EstrogenExecutor : Form
  {
    private IContainer components = (IContainer) null;
    private Guna2BorderlessForm guna2BorderlessForm1;
    private Guna2CircleButton guna2CircleButton1;
    private Guna2CircleButton guna2CircleButton2;
    private TextBox textBox1;
    private Guna2CirclePictureBox guna2CirclePictureBox1;
    private Guna2Button guna2Button2;
    private Guna2Button guna2Button1;
    private TextBox textBox2;

    public EstrogenExecutor() => this.InitializeComponent();

    private async void guna2CircleButton1_Click(object sender, EventArgs e)
    {
      await Task.Delay(100);
      Application.Exit();
    }

    private async void guna2CircleButton2_Click(object sender, EventArgs e)
    {
      await Task.Delay(100);
      this.WindowState = FormWindowState.Minimized;
    }

    private void guna2Button2_Click(object sender, EventArgs e)
    {
      if (Process.GetProcessesByName("RobloxPlayerBeta").Length != 0)
      {
        int num1 = (int) MessageBox.Show("Succesfully mapped driver");
        int num2 = (int) MessageBox.Show("Injected Succefully");
      }
      else
      {
        int num = (int) MessageBox.Show("Unable to find roblox session please use the browser version of roblox if it still doesnt find it reinstall it");
      }
    }

    private void guna2Button1_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("Executed Successfully");
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (EstrogenExecutor));
      this.guna2BorderlessForm1 = new Guna2BorderlessForm(this.components);
      this.guna2CircleButton1 = new Guna2CircleButton();
      this.guna2CircleButton2 = new Guna2CircleButton();
      this.guna2CirclePictureBox1 = new Guna2CirclePictureBox();
      this.textBox1 = new TextBox();
      this.textBox2 = new TextBox();
      this.guna2Button1 = new Guna2Button();
      this.guna2Button2 = new Guna2Button();
      ((ISupportInitialize) this.guna2CirclePictureBox1).BeginInit();
      this.SuspendLayout();
      this.guna2BorderlessForm1.ContainerControl = (ContainerControl) this;
      this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
      this.guna2BorderlessForm1.TransparentWhileDrag = true;
      this.guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
      this.guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
      this.guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
      this.guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
      this.guna2CircleButton1.FillColor = Color.Red;
      this.guna2CircleButton1.Font = new Font("Segoe UI", 9f);
      this.guna2CircleButton1.ForeColor = Color.White;
      this.guna2CircleButton1.Location = new Point(771, 12);
      this.guna2CircleButton1.Name = "guna2CircleButton1";
      this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
      this.guna2CircleButton1.Size = new Size(17, 17);
      this.guna2CircleButton1.TabIndex = 0;
      this.guna2CircleButton1.Text = "guna2CircleButton1";
      this.guna2CircleButton1.Click += new EventHandler(this.guna2CircleButton1_Click);
      this.guna2CircleButton2.DisabledState.BorderColor = Color.DarkGray;
      this.guna2CircleButton2.DisabledState.CustomBorderColor = Color.DarkGray;
      this.guna2CircleButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
      this.guna2CircleButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
      this.guna2CircleButton2.FillColor = Color.Yellow;
      this.guna2CircleButton2.Font = new Font("Segoe UI", 9f);
      this.guna2CircleButton2.ForeColor = Color.White;
      this.guna2CircleButton2.Location = new Point(748, 12);
      this.guna2CircleButton2.Name = "guna2CircleButton2";
      this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
      this.guna2CircleButton2.Size = new Size(17, 17);
      this.guna2CircleButton2.TabIndex = 1;
      this.guna2CircleButton2.Text = "guna2CircleButton2";
      this.guna2CircleButton2.Click += new EventHandler(this.guna2CircleButton2_Click);
      this.guna2CirclePictureBox1.Image = (Image) componentResourceManager.GetObject("guna2CirclePictureBox1.Image");
      this.guna2CirclePictureBox1.ImageRotate = 0.0f;
      this.guna2CirclePictureBox1.Location = new Point(12, -5);
      this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
      this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
      this.guna2CirclePictureBox1.Size = new Size(116, 113);
      this.guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      this.guna2CirclePictureBox1.TabIndex = 2;
      this.guna2CirclePictureBox1.TabStop = false;
      this.textBox1.AcceptsReturn = true;
      this.textBox1.BackColor = SystemColors.InfoText;
      this.textBox1.Cursor = Cursors.Arrow;
      this.textBox1.Enabled = false;
      this.textBox1.Font = new Font("Impact", 26.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textBox1.ForeColor = Color.Fuchsia;
      this.textBox1.ImeMode = ImeMode.Off;
      this.textBox1.Location = new Point(134, 30);
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.Size = new Size(426, 50);
      this.textBox1.TabIndex = 3;
      this.textBox1.Text = "Estrogen Executor";
      this.textBox2.BackColor = Color.Gray;
      this.textBox2.Font = new Font("Lucida Console", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textBox2.Location = new Point(12, 114);
      this.textBox2.Multiline = true;
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(776, 298);
      this.textBox2.TabIndex = 4;
      this.textBox2.Text = "type script here the longer the script is the harder and longet it will take to execute";
      this.textBox2.TextChanged += new EventHandler(this.textBox2_TextChanged);
      this.guna2Button1.Animated = true;
      this.guna2Button1.AutoRoundedCorners = true;
      this.guna2Button1.BorderRadius = 21;
      this.guna2Button1.DisabledState.BorderColor = Color.DarkGray;
      this.guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
      this.guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
      this.guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
      this.guna2Button1.FillColor = Color.FromArgb(64, 64, 64);
      this.guna2Button1.Font = new Font("Segoe UI", 9f);
      this.guna2Button1.ForeColor = Color.White;
      this.guna2Button1.Location = new Point(12, 418);
      this.guna2Button1.Name = "guna2Button1";
      this.guna2Button1.Size = new Size(180, 45);
      this.guna2Button1.TabIndex = 5;
      this.guna2Button1.Text = "Execute";
      this.guna2Button1.Click += new EventHandler(this.guna2Button1_Click);
      this.guna2Button2.Animated = true;
      this.guna2Button2.AutoRoundedCorners = true;
      this.guna2Button2.BorderRadius = 21;
      this.guna2Button2.DisabledState.BorderColor = Color.DarkGray;
      this.guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
      this.guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
      this.guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
      this.guna2Button2.FillColor = Color.FromArgb(64, 64, 64);
      this.guna2Button2.Font = new Font("Segoe UI", 9f);
      this.guna2Button2.ForeColor = Color.White;
      this.guna2Button2.Location = new Point(608, 418);
      this.guna2Button2.Name = "guna2Button2";
      this.guna2Button2.Size = new Size(180, 45);
      this.guna2Button2.TabIndex = 6;
      this.guna2Button2.Text = "Inject";
      this.guna2Button2.Click += new EventHandler(this.guna2Button2_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ActiveCaptionText;
      this.ClientSize = new Size(800, 474);
      this.Controls.Add((Control) this.guna2Button2);
      this.Controls.Add((Control) this.guna2Button1);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.guna2CirclePictureBox1);
      this.Controls.Add((Control) this.guna2CircleButton2);
      this.Controls.Add((Control) this.guna2CircleButton1);
      this.ForeColor = SystemColors.ControlText;
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (EstrogenExecutor);
      this.Text = "Form1";
      ((ISupportInitialize) this.guna2CirclePictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
