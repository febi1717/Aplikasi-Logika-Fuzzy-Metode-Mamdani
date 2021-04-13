// Decompiled with JetBrains decompiler
// Type: Logfuz_Mamdani.menu
// Assembly: Logfuz_Mamdani, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C6CE83EF-2608-4ABA-8B76-32A7171B5027
// Assembly location: E:\Semester 8\FuzzyLogic-Mamdani-tugasKuliah-main\Logfuz_Mamdani\bin\Debug\app.publish\Logfuz_Mamdani.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Logfuz_Mamdani
{
  public class menu : Form
  {
    private IContainer components = (IContainer) null;
    private Label label2;
    private Label label3;
    private Label label4;
    private PictureBox pictureBox1;
    private PictureBox pictureBox2;
    private Button button1;

    public menu() => this.InitializeComponent();

    private void label3_Click(object sender, EventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {
      new kasus1().Show();
      this.Hide();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (menu));
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.pictureBox1 = new PictureBox();
      this.pictureBox2 = new PictureBox();
      this.button1 = new Button();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      ((ISupportInitialize) this.pictureBox2).BeginInit();
      this.SuspendLayout();
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(84, 34);
      this.label2.Name = "label2";
      this.label2.Size = new Size(332, 96);
      this.label2.TabIndex = 1;
      this.label2.Text = "APLIKASI LOGIKA FUZZY\r\n METODE MAMDANI DALAM \r\nPENGAMBILAN KEPUTUSAN \r\nPENENTUAN JUMLAH PRODUKSI";
      this.label2.TextAlign = ContentAlignment.MiddleCenter;
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Arial Rounded MT Bold", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(40, 183);
      this.label3.Name = "label3";
      this.label3.Size = new Size(148, 17);
      this.label3.TabIndex = 2;
      this.label3.Text = "NAMA ANGGOTA : ";
      this.label3.Click += new EventHandler(this.label3_Click);
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Arial Rounded MT Bold", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.Location = new Point(243, 183);
      this.label4.Name = "label4";
      this.label4.Size = new Size(202, 136);
      this.label4.TabIndex = 3;
      this.label4.Text = "Febi Syarif Permana\r\n (152017086)\r\n\r\nNi Komang Intan TP \r\n(152017096)";
      this.label4.TextAlign = ContentAlignment.MiddleCenter;
      this.pictureBox1.Location = new Point(-23, -45);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(100, 50);
      this.pictureBox1.TabIndex = 4;
      this.pictureBox1.TabStop = false;
      this.pictureBox2.Image = (Image) componentResourceManager.GetObject("pictureBox2.Image");
      this.pictureBox2.Location = new Point(52, 215);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new Size(106, 104);
      this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
      this.pictureBox2.TabIndex = 5;
      this.pictureBox2.TabStop = false;
      this.button1.Location = new Point(185, 395);
      this.button1.Name = "button1";
      this.button1.Size = new Size(109, 37);
      this.button1.TabIndex = 6;
      this.button1.Text = "Mulai";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(494, 486);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.pictureBox2);
      this.Controls.Add((Control) this.pictureBox1);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.MaximizeBox = false;
      this.Name = nameof (menu);
      this.Text = "UTS Pemsil Logika Fuzzy Mamdani";
      ((ISupportInitialize) this.pictureBox1).EndInit();
      ((ISupportInitialize) this.pictureBox2).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
