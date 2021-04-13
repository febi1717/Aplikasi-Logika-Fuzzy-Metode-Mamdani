// Decompiled with JetBrains decompiler
// Type: Logfuz_Mamdani.kasus1
// Assembly: Logfuz_Mamdani, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C6CE83EF-2608-4ABA-8B76-32A7171B5027
// Assembly location: E:\Semester 8\FuzzyLogic-Mamdani-tugasKuliah-main\Logfuz_Mamdani\bin\Debug\app.publish\Logfuz_Mamdani.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Logfuz_Mamdani
{
  public class kasus1 : Form
  {
    private IContainer components = (IContainer) null;
    private Button exit;
    private GroupBox groupBox8;
    private TextBox ta2;
    private Label label19;
    private Label label20;
    private TextBox ta1;
    private Button tentang;
    private GroupBox groupBox7;
    private TextBox kpsn2;
    private Label label18;
    private TextBox kpsn1;
    private Label label17;
    private GroupBox groupBox6;
    private TextBox rule3;
    private Label label16;
    private TextBox rule2;
    private Label label15;
    private TextBox rule1;
    private Label label14;
    private TextBox rule4;
    private Label label13;
    private GroupBox groupBox5;
    private TextBox uSedikit;
    private TextBox uNaik;
    private TextBox uTurun;
    private TextBox uBanyak;
    private Label label12;
    private Label label11;
    private Label label10;
    private Label label9;
    private GroupBox groupBox4;
    private TextBox la3;
    private Label label24;
    private TextBox la2;
    private Label label25;
    private TextBox la1;
    private Label label26;
    private TextBox tm3;
    private Label hasil;
    private Label label21;
    private TextBox tm2;
    private Label label23;
    private Label label22;
    private TextBox tm1;
    private GroupBox groupBox3;
    private TextBox textBox1;
    private TextBox textBox11;
    private TextBox textBox10;
    private ComboBox pr4;
    private TextBox textBox9;
    private ComboBox pr3;
    private ComboBox ps4;
    private ComboBox pr2;
    private ComboBox pr1;
    private ComboBox plh4;
    private ComboBox ps3;
    private ComboBox pm4;
    private ComboBox ps2;
    private ComboBox ps1;
    private ComboBox plh3;
    private ComboBox plh2;
    private ComboBox plh1;
    private ComboBox pm3;
    private ComboBox pm2;
    private GroupBox groupBox1;
    private Button hitung;
    private TextBox sedia;
    private Label label8;
    private TextBox minta;
    private Label label7;
    private GroupBox groupBox2;
    private TextBox prMax;
    private TextBox psMax;
    private TextBox pmMax;
    private Label label4;
    private Label label5;
    private Label label6;
    private TextBox prMin;
    private TextBox psMin;
    private TextBox pmMin;
    private Label label3;
    private Label label2;
    private Label label1;
    private ComboBox pm1;

    public kasus1() => this.InitializeComponent();

    private void hitung_Click(object sender, EventArgs e)
    {
      double PmMax = double.Parse(this.pmMax.Text);
      double PmMin = double.Parse(this.pmMin.Text);
      double Permintaan = double.Parse(this.minta.Text);
      double num1 = rumus.turun(PmMax, PmMin, Permintaan);
      this.uTurun.Text = num1.ToString();
      double num2 = rumus.naik(PmMax, PmMin, Permintaan);
      this.uNaik.Text = num2.ToString();
      double PsMax = double.Parse(this.psMax.Text);
      double PsMin = double.Parse(this.psMin.Text);
      double Persediaan = double.Parse(this.sedia.Text);
      double num3 = rumus.sedikit(PsMax, PsMin, Persediaan);
      double num4 = rumus.banyak(PsMax, PsMin, Persediaan);
      this.uSedikit.Text = num3.ToString();
      this.uBanyak.Text = num4.ToString();
      double val1 = double.MinValue;
      double num5 = double.MinValue;
      double num6 = double.MinValue;
      double val2 = double.MinValue;
      if (this.pm1.Text == "Permintaan Turun" && this.plh1.Text == "And" && this.ps1.Text == "Persediaan Banyak")
      {
        val1 = Math.Min(Math.Round(num1, 2), Math.Round(num4, 2));
        this.rule1.Text = val1.ToString();
      }
      else if (this.pm1.Text == "Permintaan Turun" && this.plh1.Text == "And" && this.ps1.Text == "Persediaan Sedikit")
      {
        val1 = Math.Min(Math.Round(num1, 2), Math.Round(num3, 2));
        this.rule1.Text = val1.ToString();
      }
      else if (this.pm1.Text == "Permintaan Turun" && this.plh1.Text == "Or" && this.ps1.Text == "Persediaan Banyak")
      {
        val1 = Math.Max(Math.Round(num1, 2), Math.Round(num4, 2));
        this.rule1.Text = val1.ToString();
      }
      else if (this.pm1.Text == "Permintaan Turun" && this.plh1.Text == "Or" && this.ps1.Text == "Persediaan Sedikit")
      {
        val1 = Math.Max(Math.Round(num1, 2), Math.Round(num3, 2));
        this.rule1.Text = val1.ToString();
      }
      else if (this.pm1.Text == "Permintaan Naik" && this.plh1.Text == "And" && this.ps1.Text == "Persediaan Banyak")
      {
        val1 = Math.Min(Math.Round(num2, 2), Math.Round(num4, 2));
        this.rule1.Text = val1.ToString();
      }
      else if (this.pm1.Text == "Permintaan Naik" && this.plh1.Text == "And" && this.ps1.Text == "Persediaan Sedikit")
      {
        val1 = Math.Min(Math.Round(num2, 2), Math.Round(num3, 2));
        this.rule1.Text = val1.ToString();
      }
      else if (this.pm1.Text == "Permintaan Naik" && this.plh1.Text == "Or" && this.ps1.Text == "Persediaan Banyak")
      {
        val1 = Math.Max(Math.Round(num2, 2), Math.Round(num4, 2));
        this.rule1.Text = val1.ToString();
      }
      else if (this.pm1.Text == "Permintaan Naik" && this.plh1.Text == "Or" && this.ps1.Text == "Persediaan Sedikit")
      {
        val1 = Math.Max(Math.Round(num2, 2), Math.Round(num3, 2));
        this.rule1.Text = val1.ToString();
      }
      else
        this.rule1.Text = "Pilih Aturan";
      if (this.pm2.Text == "Permintaan Turun" && this.plh2.Text == "And" && this.ps2.Text == "Persediaan Banyak")
      {
        num5 = Math.Min(Math.Round(num1, 2), Math.Round(num4, 2));
        this.rule2.Text = num5.ToString();
      }
      else if (this.pm2.Text == "Permintaan Turun" && this.plh2.Text == "And" && this.ps2.Text == "Persediaan Sedikit")
      {
        num5 = Math.Min(Math.Round(num1, 2), Math.Round(num3, 2));
        this.rule2.Text = num5.ToString();
      }
      else if (this.pm2.Text == "Permintaan Turun" && this.plh2.Text == "Or" && this.ps2.Text == "Persediaan Banyak")
      {
        num5 = Math.Max(Math.Round(num1, 2), Math.Round(num4, 2));
        this.rule2.Text = num5.ToString();
      }
      else if (this.pm2.Text == "Permintaan Turun" && this.plh2.Text == "Or" && this.ps2.Text == "Persediaan Sedikit")
      {
        num5 = Math.Max(Math.Round(num1, 2), Math.Round(num3, 2));
        this.rule2.Text = num5.ToString();
      }
      else if (this.pm2.Text == "Permintaan Naik" && this.plh2.Text == "And" && this.ps2.Text == "Persediaan Banyak")
      {
        num5 = Math.Min(Math.Round(num2, 2), Math.Round(num4, 2));
        this.rule2.Text = num5.ToString();
      }
      else if (this.pm2.Text == "Permintaan Naik" && this.plh2.Text == "And" && this.ps2.Text == "Persediaan Sedikit")
      {
        num5 = Math.Min(Math.Round(num2, 2), Math.Round(num3, 2));
        this.rule2.Text = num5.ToString();
      }
      else if (this.pm2.Text == "Permintaan Naik" && this.plh2.Text == "Or" && this.ps2.Text == "Persediaan Banyak")
      {
        num5 = Math.Max(Math.Round(num2, 2), Math.Round(num4, 2));
        this.rule2.Text = num5.ToString();
      }
      else if (this.pm2.Text == "Permintaan Naik" && this.plh2.Text == "Or" && this.ps2.Text == "Persediaan Sedikit")
      {
        num5 = Math.Max(Math.Round(num2, 2), Math.Round(num3, 2));
        this.rule2.Text = num5.ToString();
      }
      else
        this.rule2.Text = "Pilih Aturan";
      if (this.pm3.Text == "Permintaan Turun" && this.plh3.Text == "And" && this.ps3.Text == "Persediaan Banyak")
      {
        num6 = Math.Min(Math.Round(num1, 2), Math.Round(num4, 2));
        this.rule3.Text = num6.ToString();
      }
      else if (this.pm3.Text == "Permintaan Turun" && this.plh3.Text == "And" && this.ps3.Text == "Persediaan Sedikit")
      {
        num6 = Math.Min(Math.Round(num1, 2), Math.Round(num3, 2));
        this.rule3.Text = num6.ToString();
      }
      else if (this.pm3.Text == "Permintaan Turun" && this.plh3.Text == "Or" && this.ps3.Text == "Persediaan Banyak")
      {
        num6 = Math.Max(Math.Round(num1, 2), Math.Round(num4, 2));
        this.rule3.Text = num6.ToString();
      }
      else if (this.pm3.Text == "Permintaan Turun" && this.plh3.Text == "Or" && this.ps3.Text == "Persediaan Sedikit")
      {
        num6 = Math.Max(Math.Round(num1, 2), Math.Round(num3, 2));
        this.rule3.Text = num6.ToString();
      }
      else if (this.pm3.Text == "Permintaan Naik" && this.plh3.Text == "And" && this.ps3.Text == "Persediaan Banyak")
      {
        num6 = Math.Min(Math.Round(num2, 2), Math.Round(num4, 2));
        this.rule3.Text = num6.ToString();
      }
      else if (this.pm3.Text == "Permintaan Naik" && this.plh3.Text == "And" && this.ps3.Text == "Persediaan Sedikit")
      {
        num6 = Math.Min(Math.Round(num2, 2), Math.Round(num3, 2));
        this.rule3.Text = num6.ToString();
      }
      else if (this.pm3.Text == "Permintaan Naik" && this.plh3.Text == "Or" && this.ps3.Text == "Persediaan Banyak")
      {
        num6 = Math.Max(Math.Round(num2, 2), Math.Round(num4, 2));
        this.rule3.Text = num6.ToString();
      }
      else if (this.pm3.Text == "Permintaan Naik" && this.plh3.Text == "Or" && this.ps3.Text == "Persediaan Sedikit")
      {
        num6 = Math.Max(Math.Round(num2, 2), Math.Round(num3, 2));
        this.rule3.Text = num6.ToString();
      }
      else
        this.rule3.Text = "Pilih Aturan";
      if (this.pm4.Text == "Permintaan Turun" && this.plh4.Text == "And" && this.ps4.Text == "Persediaan Banyak")
      {
        val2 = Math.Min(Math.Round(num1, 2), Math.Round(num4, 2));
        this.rule4.Text = val2.ToString();
      }
      else if (this.pm4.Text == "Permintaan Turun" && this.plh4.Text == "And" && this.ps4.Text == "Persediaan Sedikit")
      {
        val2 = Math.Min(Math.Round(num1, 2), Math.Round(num3, 2));
        this.rule4.Text = val2.ToString();
      }
      else if (this.pm4.Text == "Permintaan Turun" && this.plh4.Text == "Or" && this.ps4.Text == "Persediaan Banyak")
      {
        val2 = Math.Max(Math.Round(num1, 2), Math.Round(num4, 2));
        this.rule4.Text = val2.ToString();
      }
      else if (this.pm4.Text == "Permintaan Turun" && this.plh4.Text == "Or" && this.ps4.Text == "Persediaan Sedikit")
      {
        val2 = Math.Max(Math.Round(num1, 2), Math.Round(num3, 2));
        this.rule4.Text = val2.ToString();
      }
      else if (this.pm4.Text == "Permintaan Naik" && this.plh4.Text == "And" && this.ps4.Text == "Persediaan Banyak")
      {
        val2 = Math.Min(Math.Round(num2, 2), Math.Round(num4, 2));
        this.rule4.Text = val2.ToString();
      }
      else if (this.pm4.Text == "Permintaan Naik" && this.plh4.Text == "And" && this.ps4.Text == "Persediaan Sedikit")
      {
        val2 = Math.Min(Math.Round(num2, 2), Math.Round(num3, 2));
        this.rule4.Text = val2.ToString();
      }
      else if (this.pm4.Text == "Permintaan Naik" && this.plh4.Text == "Or" && this.ps4.Text == "Persediaan Banyak")
      {
        val2 = Math.Max(Math.Round(num2, 2), Math.Round(num4, 2));
        this.rule4.Text = val2.ToString();
      }
      else if (this.pm4.Text == "Permintaan Naik" && this.plh4.Text == "Or" && this.ps4.Text == "Persediaan Sedikit")
      {
        val2 = Math.Max(Math.Round(num2, 2), Math.Round(num3, 2));
        this.rule4.Text = val2.ToString();
      }
      else
        this.rule4.Text = "Pilih Aturan";
      double num7;
      double num8;
      if (this.pr1.Text == "Pemesanan Berkurang")
      {
        num7 = val1;
        num8 = Math.Max(Math.Max(num5, num6), val2);
      }
      else if (this.pr2.Text == "Pemesanan Berkurang")
      {
        num7 = num5;
        num8 = Math.Max(Math.Max(val1, num6), val2);
      }
      else if (this.pr3.Text == "Pemesanan Berkurang")
      {
        num7 = num6;
        num8 = Math.Max(Math.Max(val1, num5), val2);
      }
      else if (this.pr4.Text == "Pemesanan Berkurang")
      {
        num7 = val2;
        num8 = Math.Max(Math.Max(val1, num5), num6);
      }
      else if (this.pr1.Text == "Pemesanan Berkurang" && this.pr2.Text == "Pemesanan Berkurang")
      {
        num7 = Math.Max(val1, num5);
        num8 = Math.Max(num6, val2);
      }
      else if (this.pr1.Text == "Pemesanan Berkurang" && this.pr3.Text == "Pemesanan Berkurang")
      {
        num7 = Math.Max(val1, num6);
        num8 = Math.Max(num5, val2);
      }
      else if (this.pr1.Text == "Pemesanan Berkurang" && this.pr4.Text == "Pemesanan Berkurang")
      {
        num7 = Math.Max(val1, val2);
        num8 = Math.Max(num5, num6);
      }
      else if (this.pr2.Text == "Pemesanan Berkurang" && this.pr3.Text == "Pemesanan Berkurang")
      {
        num7 = Math.Max(num5, num6);
        num8 = Math.Max(val1, val2);
      }
      else if (this.pr2.Text == "Pemesanan Berkurang" && this.pr4.Text == "Pemesanan Berkurang")
      {
        num7 = Math.Max(num5, val2);
        num8 = Math.Max(val1, num6);
      }
      else if (this.pr3.Text == "Pemesanan Berkurang" && this.pr4.Text == "Pemesanan Berkurang")
      {
        num7 = Math.Max(num6, val2);
        num8 = Math.Max(val1, num5);
      }
      else if (this.pr1.Text == "Pemesanan Berkurang" && this.pr2.Text == "Pemesanan Berkurang" && this.pr3.Text == "Pemesanan Berkurang")
      {
        num7 = Math.Max(Math.Max(val1, num5), num6);
        num8 = val2;
      }
      else if (this.pr1.Text == "Pemesanan Berkurang" && this.pr2.Text == "Pemesanan Berkurang" && this.pr4.Text == "Pemesanan Berkurang")
      {
        num7 = Math.Max(Math.Max(val1, num5), val2);
        num8 = num6;
      }
      else if (this.pr1.Text == "Pemesanan Berkurang" && this.pr3.Text == "Pemesanan Berkurang" && this.pr4.Text == "Pemesanan Berkurang")
      {
        num7 = Math.Max(Math.Max(val1, num6), val2);
        num8 = num5;
      }
      else if (this.pr2.Text == "Pemesanan Berkurang" && this.pr3.Text == "Pemesanan Berkurang" && this.pr4.Text == "Pemesanan Berkurang")
      {
        num7 = Math.Max(Math.Max(num5, num6), val2);
        num8 = val1;
      }
      else if (this.pr1.Text == "Pemesanan Berkurang" && this.pr2.Text == "Pemesanan Berkurang" && this.pr3.Text == "Pemesanan Berkurang" && this.pr4.Text == "Pemesanan Berkurang")
      {
        num7 = Math.Max(Math.Max(Math.Max(val1, num5), num6), val2);
        num8 = 0.0;
      }
      else if (this.pr1.Text == "Pemesanan Bertambah" && this.pr2.Text == "Pemesanan Bertambah" && this.pr3.Text == "Pemesanan Bertambah" && this.pr4.Text == "Pemesanan Bertambah")
      {
        num7 = 0.0;
        num8 = Math.Max(Math.Max(Math.Max(val1, num5), num6), val2);
      }
      else
      {
        num7 = 0.0;
        num8 = 0.0;
      }
      this.kpsn1.Text = num7.ToString();
      this.kpsn2.Text = num8.ToString();
      double num9 = double.Parse(this.prMin.Text);
      double x1 = double.Parse(this.prMax.Text);
      double x2 = num7 * (x1 - num9) + num9;
      double x3 = num8 * (x1 - num9) + num9;
      this.ta1.Text = x2.ToString();
      this.ta2.Text = x3.ToString();
      double num10 = Math.Round(0.5 * num7 * Math.Pow(x2, 2.0), 2);
      double num11 = Math.Round(1.0 / (x1 - num9) * (0.3333 * Math.Pow(x3, 3.0) - num9 / 2.0 * Math.Pow(x3, 2.0) - 0.3333 * Math.Pow(x2, 3.0) + num9 / 2.0 * Math.Pow(x2, 2.0)), 2);
      double num12 = Math.Round(0.5 * num8 * Math.Pow(x1, 2.0) - 0.5 * num8 * Math.Pow(x3, 2.0), 2);
      this.tm1.Text = num10.ToString();
      this.tm2.Text = num11.ToString();
      this.tm3.Text = num12.ToString();
      double num13 = x2 * num7;
      double num14 = (num7 + num8) * (x3 - x2) / 2.0;
      double num15 = (x1 - (x1 - num9)) * num8;
      this.la1.Text = num13.ToString();
      this.la2.Text = num14.ToString();
      this.la3.Text = num15.ToString();
      this.hasil.Text = Math.Round((num10 + num11 + num12) / (num13 + num14 + num15), 2).ToString();
    }

    private void exit_Click(object sender, EventArgs e) => this.Close();

    private void tentang_Click(object sender, EventArgs e)
    {
      new menu().Show();
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
      this.exit = new Button();
      this.groupBox8 = new GroupBox();
      this.ta2 = new TextBox();
      this.label19 = new Label();
      this.label20 = new Label();
      this.ta1 = new TextBox();
      this.tentang = new Button();
      this.groupBox7 = new GroupBox();
      this.kpsn2 = new TextBox();
      this.label18 = new Label();
      this.kpsn1 = new TextBox();
      this.label17 = new Label();
      this.groupBox6 = new GroupBox();
      this.rule3 = new TextBox();
      this.label16 = new Label();
      this.rule2 = new TextBox();
      this.label15 = new Label();
      this.rule1 = new TextBox();
      this.label14 = new Label();
      this.rule4 = new TextBox();
      this.label13 = new Label();
      this.groupBox5 = new GroupBox();
      this.uSedikit = new TextBox();
      this.uNaik = new TextBox();
      this.uTurun = new TextBox();
      this.uBanyak = new TextBox();
      this.label12 = new Label();
      this.label11 = new Label();
      this.label10 = new Label();
      this.label9 = new Label();
      this.groupBox4 = new GroupBox();
      this.la3 = new TextBox();
      this.label24 = new Label();
      this.la2 = new TextBox();
      this.label25 = new Label();
      this.la1 = new TextBox();
      this.label26 = new Label();
      this.tm3 = new TextBox();
      this.hasil = new Label();
      this.label21 = new Label();
      this.tm2 = new TextBox();
      this.label23 = new Label();
      this.label22 = new Label();
      this.tm1 = new TextBox();
      this.groupBox3 = new GroupBox();
      this.textBox1 = new TextBox();
      this.textBox11 = new TextBox();
      this.textBox10 = new TextBox();
      this.pr4 = new ComboBox();
      this.textBox9 = new TextBox();
      this.pr3 = new ComboBox();
      this.ps4 = new ComboBox();
      this.pr2 = new ComboBox();
      this.pr1 = new ComboBox();
      this.plh4 = new ComboBox();
      this.ps3 = new ComboBox();
      this.pm4 = new ComboBox();
      this.ps2 = new ComboBox();
      this.ps1 = new ComboBox();
      this.plh3 = new ComboBox();
      this.plh2 = new ComboBox();
      this.plh1 = new ComboBox();
      this.pm3 = new ComboBox();
      this.pm2 = new ComboBox();
      this.pm1 = new ComboBox();
      this.groupBox1 = new GroupBox();
      this.hitung = new Button();
      this.sedia = new TextBox();
      this.label8 = new Label();
      this.minta = new TextBox();
      this.label7 = new Label();
      this.groupBox2 = new GroupBox();
      this.prMax = new TextBox();
      this.psMax = new TextBox();
      this.pmMax = new TextBox();
      this.label4 = new Label();
      this.label5 = new Label();
      this.label6 = new Label();
      this.prMin = new TextBox();
      this.psMin = new TextBox();
      this.pmMin = new TextBox();
      this.label3 = new Label();
      this.label2 = new Label();
      this.label1 = new Label();
      this.groupBox8.SuspendLayout();
      this.groupBox7.SuspendLayout();
      this.groupBox6.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.exit.Cursor = Cursors.Hand;
      this.exit.Font = new Font("Microsoft Sans Serif", 10f);
      this.exit.Location = new Point(884, 451);
      this.exit.Name = "exit";
      this.exit.Size = new Size(156, 28);
      this.exit.TabIndex = 27;
      this.exit.Text = "Keluar";
      this.exit.UseVisualStyleBackColor = true;
      this.exit.Click += new EventHandler(this.exit_Click);
      this.groupBox8.Controls.Add((Control) this.ta2);
      this.groupBox8.Controls.Add((Control) this.label19);
      this.groupBox8.Controls.Add((Control) this.label20);
      this.groupBox8.Controls.Add((Control) this.ta1);
      this.groupBox8.Location = new Point(709, 344);
      this.groupBox8.Name = "groupBox8";
      this.groupBox8.Size = new Size(331, 95);
      this.groupBox8.TabIndex = 23;
      this.groupBox8.TabStop = false;
      this.groupBox8.Text = "Nilai a1 dan a2";
      this.ta2.Location = new Point(65, 57);
      this.ta2.Name = "ta2";
      this.ta2.ReadOnly = true;
      this.ta2.Size = new Size(260, 20);
      this.ta2.TabIndex = 15;
      this.label19.AutoSize = true;
      this.label19.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label19.Location = new Point(6, 30);
      this.label19.Name = "label19";
      this.label19.Size = new Size(53, 16);
      this.label19.TabIndex = 12;
      this.label19.Text = "Nilai a1";
      this.label20.AutoSize = true;
      this.label20.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label20.Location = new Point(6, 57);
      this.label20.Name = "label20";
      this.label20.Size = new Size(53, 16);
      this.label20.TabIndex = 13;
      this.label20.Text = "Nilai a2";
      this.ta1.Location = new Point(65, 28);
      this.ta1.Name = "ta1";
      this.ta1.ReadOnly = true;
      this.ta1.Size = new Size(260, 20);
      this.ta1.TabIndex = 14;
      this.tentang.Cursor = Cursors.Hand;
      this.tentang.Font = new Font("Microsoft Sans Serif", 10f);
      this.tentang.Location = new Point(709, 451);
      this.tentang.Name = "tentang";
      this.tentang.Size = new Size(156, 28);
      this.tentang.TabIndex = 26;
      this.tentang.Text = "Back to Menu Awal";
      this.tentang.UseVisualStyleBackColor = true;
      this.tentang.Click += new EventHandler(this.tentang_Click);
      this.groupBox7.Controls.Add((Control) this.kpsn2);
      this.groupBox7.Controls.Add((Control) this.label18);
      this.groupBox7.Controls.Add((Control) this.kpsn1);
      this.groupBox7.Controls.Add((Control) this.label17);
      this.groupBox7.Location = new Point(709, 249);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new Size(331, 89);
      this.groupBox7.TabIndex = 24;
      this.groupBox7.TabStop = false;
      this.groupBox7.Text = "Komposisi Aturan";
      this.kpsn2.Location = new Point(158, 50);
      this.kpsn2.Name = "kpsn2";
      this.kpsn2.ReadOnly = true;
      this.kpsn2.Size = new Size(167, 20);
      this.kpsn2.TabIndex = 11;
      this.label18.AutoSize = true;
      this.label18.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label18.Location = new Point(6, 23);
      this.label18.Name = "label18";
      this.label18.Size = new Size(146, 16);
      this.label18.TabIndex = 8;
      this.label18.Text = "Pemesanan Berkurang";
      this.kpsn1.Location = new Point(158, 21);
      this.kpsn1.Name = "kpsn1";
      this.kpsn1.ReadOnly = true;
      this.kpsn1.Size = new Size(167, 20);
      this.kpsn1.TabIndex = 10;
      this.label17.AutoSize = true;
      this.label17.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label17.Location = new Point(6, 50);
      this.label17.Name = "label17";
      this.label17.Size = new Size(150, 16);
      this.label17.TabIndex = 9;
      this.label17.Text = "Pemesanan Bertambah";
      this.groupBox6.Controls.Add((Control) this.rule3);
      this.groupBox6.Controls.Add((Control) this.label16);
      this.groupBox6.Controls.Add((Control) this.rule2);
      this.groupBox6.Controls.Add((Control) this.label15);
      this.groupBox6.Controls.Add((Control) this.rule1);
      this.groupBox6.Controls.Add((Control) this.label14);
      this.groupBox6.Controls.Add((Control) this.rule4);
      this.groupBox6.Controls.Add((Control) this.label13);
      this.groupBox6.Location = new Point(709, 131);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new Size(331, 112);
      this.groupBox6.TabIndex = 25;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Nilai Tiap Aturan";
      this.rule3.Location = new Point(139, 62);
      this.rule3.Name = "rule3";
      this.rule3.ReadOnly = true;
      this.rule3.Size = new Size(186, 20);
      this.rule3.TabIndex = 15;
      this.label16.AutoSize = true;
      this.label16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label16.Location = new Point(6, 19);
      this.label16.Name = "label16";
      this.label16.Size = new Size(86, 16);
      this.label16.TabIndex = 8;
      this.label16.Text = "Nilai Aturan 1";
      this.rule2.Location = new Point(139, 40);
      this.rule2.Name = "rule2";
      this.rule2.ReadOnly = true;
      this.rule2.Size = new Size(186, 20);
      this.rule2.TabIndex = 14;
      this.label15.AutoSize = true;
      this.label15.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label15.Location = new Point(6, 40);
      this.label15.Name = "label15";
      this.label15.Size = new Size(86, 16);
      this.label15.TabIndex = 9;
      this.label15.Text = "Nilai Aturan 2";
      this.rule1.Location = new Point(139, 17);
      this.rule1.Name = "rule1";
      this.rule1.ReadOnly = true;
      this.rule1.Size = new Size(186, 20);
      this.rule1.TabIndex = 13;
      this.label14.AutoSize = true;
      this.label14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label14.Location = new Point(6, 62);
      this.label14.Name = "label14";
      this.label14.Size = new Size(86, 16);
      this.label14.TabIndex = 10;
      this.label14.Text = "Nilai Aturan 3";
      this.rule4.Location = new Point(139, 84);
      this.rule4.Name = "rule4";
      this.rule4.ReadOnly = true;
      this.rule4.Size = new Size(186, 20);
      this.rule4.TabIndex = 12;
      this.label13.AutoSize = true;
      this.label13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label13.Location = new Point(6, 85);
      this.label13.Name = "label13";
      this.label13.Size = new Size(86, 16);
      this.label13.TabIndex = 11;
      this.label13.Text = "Nilai Aturan 3";
      this.groupBox5.Controls.Add((Control) this.uSedikit);
      this.groupBox5.Controls.Add((Control) this.uNaik);
      this.groupBox5.Controls.Add((Control) this.uTurun);
      this.groupBox5.Controls.Add((Control) this.uBanyak);
      this.groupBox5.Controls.Add((Control) this.label12);
      this.groupBox5.Controls.Add((Control) this.label11);
      this.groupBox5.Controls.Add((Control) this.label10);
      this.groupBox5.Controls.Add((Control) this.label9);
      this.groupBox5.Location = new Point(709, 13);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new Size(331, 112);
      this.groupBox5.TabIndex = 22;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Keanggotaan";
      this.uSedikit.Location = new Point(139, 62);
      this.uSedikit.Name = "uSedikit";
      this.uSedikit.ReadOnly = true;
      this.uSedikit.Size = new Size(186, 20);
      this.uSedikit.TabIndex = 7;
      this.uNaik.Location = new Point(139, 40);
      this.uNaik.Name = "uNaik";
      this.uNaik.ReadOnly = true;
      this.uNaik.Size = new Size(186, 20);
      this.uNaik.TabIndex = 6;
      this.uTurun.Location = new Point(139, 17);
      this.uTurun.Name = "uTurun";
      this.uTurun.ReadOnly = true;
      this.uTurun.Size = new Size(186, 20);
      this.uTurun.TabIndex = 5;
      this.uBanyak.Location = new Point(139, 84);
      this.uBanyak.Name = "uBanyak";
      this.uBanyak.ReadOnly = true;
      this.uBanyak.Size = new Size(186, 20);
      this.uBanyak.TabIndex = 4;
      this.label12.AutoSize = true;
      this.label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label12.Location = new Point(6, 85);
      this.label12.Name = "label12";
      this.label12.Size = new Size((int) sbyte.MaxValue, 16);
      this.label12.TabIndex = 3;
      this.label12.Text = "Persediaan Banyak";
      this.label11.AutoSize = true;
      this.label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label11.Location = new Point(6, 62);
      this.label11.Name = "label11";
      this.label11.Size = new Size(122, 16);
      this.label11.TabIndex = 2;
      this.label11.Text = "Persediaan Sedikit";
      this.label10.AutoSize = true;
      this.label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label10.Location = new Point(6, 40);
      this.label10.Name = "label10";
      this.label10.Size = new Size(107, 16);
      this.label10.TabIndex = 1;
      this.label10.Text = "Permintaan Naik";
      this.label9.AutoSize = true;
      this.label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label9.Location = new Point(6, 19);
      this.label9.Name = "label9";
      this.label9.Size = new Size(113, 16);
      this.label9.TabIndex = 0;
      this.label9.Text = "Permintaan Turun";
      this.groupBox4.Controls.Add((Control) this.la3);
      this.groupBox4.Controls.Add((Control) this.label24);
      this.groupBox4.Controls.Add((Control) this.la2);
      this.groupBox4.Controls.Add((Control) this.label25);
      this.groupBox4.Controls.Add((Control) this.la1);
      this.groupBox4.Controls.Add((Control) this.label26);
      this.groupBox4.Controls.Add((Control) this.tm3);
      this.groupBox4.Controls.Add((Control) this.hasil);
      this.groupBox4.Controls.Add((Control) this.label21);
      this.groupBox4.Controls.Add((Control) this.tm2);
      this.groupBox4.Controls.Add((Control) this.label23);
      this.groupBox4.Controls.Add((Control) this.label22);
      this.groupBox4.Controls.Add((Control) this.tm1);
      this.groupBox4.Location = new Point(12, 350);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(689, 129);
      this.groupBox4.TabIndex = 21;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Hasil Akhir";
      this.la3.Location = new Point(454, 102);
      this.la3.Name = "la3";
      this.la3.ReadOnly = true;
      this.la3.Size = new Size(212, 20);
      this.la3.TabIndex = 27;
      this.label24.AutoSize = true;
      this.label24.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label24.Location = new Point(351, 59);
      this.label24.Name = "label24";
      this.label24.Size = new Size(77, 16);
      this.label24.TabIndex = 22;
      this.label24.Text = "Nilai Luas 1";
      this.la2.Location = new Point(454, 80);
      this.la2.Name = "la2";
      this.la2.ReadOnly = true;
      this.la2.Size = new Size(212, 20);
      this.la2.TabIndex = 26;
      this.label25.AutoSize = true;
      this.label25.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label25.Location = new Point(351, 80);
      this.label25.Name = "label25";
      this.label25.Size = new Size(77, 16);
      this.label25.TabIndex = 23;
      this.label25.Text = "Nilai Luas 2";
      this.la1.Location = new Point(454, 57);
      this.la1.Name = "la1";
      this.la1.ReadOnly = true;
      this.la1.Size = new Size(212, 20);
      this.la1.TabIndex = 25;
      this.label26.AutoSize = true;
      this.label26.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label26.Location = new Point(351, 102);
      this.label26.Name = "label26";
      this.label26.Size = new Size(77, 16);
      this.label26.TabIndex = 24;
      this.label26.Text = "Nilai Luas 3";
      this.tm3.Location = new Point(117, 102);
      this.tm3.Name = "tm3";
      this.tm3.ReadOnly = true;
      this.tm3.Size = new Size(213, 20);
      this.tm3.TabIndex = 21;
      this.hasil.AutoSize = true;
      this.hasil.Font = new Font("Microsoft Sans Serif", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.hasil.Location = new Point(320, 10);
      this.hasil.Name = "hasil";
      this.hasil.Size = new Size(66, 33);
      this.hasil.TabIndex = 8;
      this.hasil.Text = "???";
      this.label21.AutoSize = true;
      this.label21.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label21.Location = new Point(11, 59);
      this.label21.Name = "label21";
      this.label21.Size = new Size(93, 16);
      this.label21.TabIndex = 16;
      this.label21.Text = "Nilai Momen 1";
      this.tm2.Location = new Point(117, 80);
      this.tm2.Name = "tm2";
      this.tm2.ReadOnly = true;
      this.tm2.Size = new Size(213, 20);
      this.tm2.TabIndex = 20;
      this.label23.AutoSize = true;
      this.label23.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label23.Location = new Point(11, 102);
      this.label23.Name = "label23";
      this.label23.Size = new Size(93, 16);
      this.label23.TabIndex = 18;
      this.label23.Text = "Nilai Momen 3";
      this.label22.AutoSize = true;
      this.label22.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label22.Location = new Point(11, 80);
      this.label22.Name = "label22";
      this.label22.Size = new Size(93, 16);
      this.label22.TabIndex = 17;
      this.label22.Text = "Nilai Momen 2";
      this.tm1.Location = new Point(117, 57);
      this.tm1.Name = "tm1";
      this.tm1.ReadOnly = true;
      this.tm1.Size = new Size(213, 20);
      this.tm1.TabIndex = 19;
      this.groupBox3.Controls.Add((Control) this.textBox1);
      this.groupBox3.Controls.Add((Control) this.textBox11);
      this.groupBox3.Controls.Add((Control) this.textBox10);
      this.groupBox3.Controls.Add((Control) this.pr4);
      this.groupBox3.Controls.Add((Control) this.textBox9);
      this.groupBox3.Controls.Add((Control) this.pr3);
      this.groupBox3.Controls.Add((Control) this.ps4);
      this.groupBox3.Controls.Add((Control) this.pr2);
      this.groupBox3.Controls.Add((Control) this.pr1);
      this.groupBox3.Controls.Add((Control) this.plh4);
      this.groupBox3.Controls.Add((Control) this.ps3);
      this.groupBox3.Controls.Add((Control) this.pm4);
      this.groupBox3.Controls.Add((Control) this.ps2);
      this.groupBox3.Controls.Add((Control) this.ps1);
      this.groupBox3.Controls.Add((Control) this.plh3);
      this.groupBox3.Controls.Add((Control) this.plh2);
      this.groupBox3.Controls.Add((Control) this.plh1);
      this.groupBox3.Controls.Add((Control) this.pm3);
      this.groupBox3.Controls.Add((Control) this.pm2);
      this.groupBox3.Controls.Add((Control) this.pm1);
      this.groupBox3.Location = new Point(12, 215);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(689, 129);
      this.groupBox3.TabIndex = 20;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Aturan Fuzzy";
      this.textBox1.Location = new Point(458, 101);
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.Size = new Size(58, 20);
      this.textBox1.TabIndex = 18;
      this.textBox1.Text = "Then";
      this.textBox1.TextAlign = HorizontalAlignment.Center;
      this.textBox11.Location = new Point(458, 74);
      this.textBox11.Name = "textBox11";
      this.textBox11.ReadOnly = true;
      this.textBox11.Size = new Size(58, 20);
      this.textBox11.TabIndex = 13;
      this.textBox11.Text = "Then";
      this.textBox11.TextAlign = HorizontalAlignment.Center;
      this.textBox10.Location = new Point(458, 48);
      this.textBox10.Name = "textBox10";
      this.textBox10.ReadOnly = true;
      this.textBox10.Size = new Size(58, 20);
      this.textBox10.TabIndex = 12;
      this.textBox10.Text = "Then";
      this.textBox10.TextAlign = HorizontalAlignment.Center;
      this.pr4.FormattingEnabled = true;
      this.pr4.Items.AddRange(new object[2]
      {
        (object) "Pemesanan Berkurang",
        (object) "Pemesanan Bertambah"
      });
      this.pr4.Location = new Point(522, 102);
      this.pr4.Name = "pr4";
      this.pr4.Size = new Size(159, 21);
      this.pr4.TabIndex = 17;
      this.pr4.Text = "Pemesanan Bertambah";
      this.textBox9.Location = new Point(458, 21);
      this.textBox9.Name = "textBox9";
      this.textBox9.ReadOnly = true;
      this.textBox9.Size = new Size(58, 20);
      this.textBox9.TabIndex = 0;
      this.textBox9.Text = "Then";
      this.textBox9.TextAlign = HorizontalAlignment.Center;
      this.pr3.FormattingEnabled = true;
      this.pr3.Items.AddRange(new object[2]
      {
        (object) "Pemesanan Berkurang",
        (object) "Pemesanan Bertambah"
      });
      this.pr3.Location = new Point(522, 75);
      this.pr3.Name = "pr3";
      this.pr3.Size = new Size(159, 21);
      this.pr3.TabIndex = 11;
      this.pr3.Text = "Pemesanan Bertambah";
      this.ps4.FormattingEnabled = true;
      this.ps4.Items.AddRange(new object[2]
      {
        (object) "Persediaan Banyak",
        (object) "Persediaan Sedikit"
      });
      this.ps4.Location = new Point(268, 102);
      this.ps4.Name = "ps4";
      this.ps4.Size = new Size(184, 21);
      this.ps4.TabIndex = 16;
      this.ps4.Text = "Persediaan Sedikit";
      this.pr2.FormattingEnabled = true;
      this.pr2.Items.AddRange(new object[2]
      {
        (object) "Pemesanan Berkurang ",
        (object) "Pemesanan Bertambah"
      });
      this.pr2.Location = new Point(522, 48);
      this.pr2.Name = "pr2";
      this.pr2.Size = new Size(159, 21);
      this.pr2.TabIndex = 10;
      this.pr2.Text = "Pemesanan Berkurang";
      this.pr1.FormattingEnabled = true;
      this.pr1.Items.AddRange(new object[2]
      {
        (object) "Pemesanan Berkurang",
        (object) "Pemesanan Bertambah"
      });
      this.pr1.Location = new Point(522, 20);
      this.pr1.Name = "pr1";
      this.pr1.Size = new Size(159, 21);
      this.pr1.TabIndex = 9;
      this.pr1.Text = "Pemesanan Berkurang";
      this.plh4.FormattingEnabled = true;
      this.plh4.Items.AddRange(new object[2]
      {
        (object) "And",
        (object) "Or"
      });
      this.plh4.Location = new Point(204, 102);
      this.plh4.Name = "plh4";
      this.plh4.Size = new Size(58, 21);
      this.plh4.TabIndex = 15;
      this.plh4.Text = "And";
      this.ps3.FormattingEnabled = true;
      this.ps3.Items.AddRange(new object[2]
      {
        (object) "Persediaan Banyak",
        (object) "Persediaan Sedikit"
      });
      this.ps3.Location = new Point(268, 75);
      this.ps3.Name = "ps3";
      this.ps3.Size = new Size(184, 21);
      this.ps3.TabIndex = 8;
      this.ps3.Text = "Persediaan Banyak";
      this.pm4.FormattingEnabled = true;
      this.pm4.Items.AddRange(new object[2]
      {
        (object) "Permintaan Turun",
        (object) "Permintaan Naik"
      });
      this.pm4.Location = new Point(14, 102);
      this.pm4.Name = "pm4";
      this.pm4.Size = new Size(184, 21);
      this.pm4.TabIndex = 14;
      this.pm4.Text = "Permintaan Naik";
      this.ps2.FormattingEnabled = true;
      this.ps2.Items.AddRange(new object[2]
      {
        (object) "Persediaan Banyak",
        (object) "Persediaan Sedikit"
      });
      this.ps2.Location = new Point(268, 48);
      this.ps2.Name = "ps2";
      this.ps2.Size = new Size(184, 21);
      this.ps2.TabIndex = 7;
      this.ps2.Text = "Persediaan Sedikit";
      this.ps1.FormattingEnabled = true;
      this.ps1.Items.AddRange(new object[2]
      {
        (object) "Persediaan Banyak",
        (object) "Persediaan Sedikit"
      });
      this.ps1.Location = new Point(268, 20);
      this.ps1.Name = "ps1";
      this.ps1.Size = new Size(184, 21);
      this.ps1.TabIndex = 6;
      this.ps1.Text = "Persediaan Banyak";
      this.plh3.FormattingEnabled = true;
      this.plh3.Items.AddRange(new object[2]
      {
        (object) "And ",
        (object) "Or"
      });
      this.plh3.Location = new Point(204, 75);
      this.plh3.Name = "plh3";
      this.plh3.Size = new Size(58, 21);
      this.plh3.TabIndex = 5;
      this.plh3.Text = "And";
      this.plh2.FormattingEnabled = true;
      this.plh2.Items.AddRange(new object[2]
      {
        (object) "And",
        (object) "Or"
      });
      this.plh2.Location = new Point(204, 48);
      this.plh2.Name = "plh2";
      this.plh2.Size = new Size(58, 21);
      this.plh2.TabIndex = 4;
      this.plh2.Text = "And";
      this.plh1.FormattingEnabled = true;
      this.plh1.Items.AddRange(new object[2]
      {
        (object) "And",
        (object) "Or"
      });
      this.plh1.Location = new Point(204, 20);
      this.plh1.Name = "plh1";
      this.plh1.Size = new Size(58, 21);
      this.plh1.TabIndex = 3;
      this.plh1.Text = "And";
      this.pm3.FormattingEnabled = true;
      this.pm3.Items.AddRange(new object[2]
      {
        (object) "Permintaan Turun",
        (object) "Permintaan Naik"
      });
      this.pm3.Location = new Point(14, 75);
      this.pm3.Name = "pm3";
      this.pm3.Size = new Size(184, 21);
      this.pm3.TabIndex = 2;
      this.pm3.Text = "Permintaan Naik";
      this.pm2.FormattingEnabled = true;
      this.pm2.Items.AddRange(new object[2]
      {
        (object) "Permintaan Turun",
        (object) "Permintaan Naik"
      });
      this.pm2.Location = new Point(14, 48);
      this.pm2.Name = "pm2";
      this.pm2.Size = new Size(184, 21);
      this.pm2.TabIndex = 1;
      this.pm2.Text = "Permintaan Turun";
      this.pm1.Cursor = Cursors.Default;
      this.pm1.FormattingEnabled = true;
      this.pm1.ImeMode = ImeMode.NoControl;
      this.pm1.Items.AddRange(new object[2]
      {
        (object) "Permintaan Turun",
        (object) "Permintaan Naik"
      });
      this.pm1.Location = new Point(14, 20);
      this.pm1.Name = "pm1";
      this.pm1.Size = new Size(184, 21);
      this.pm1.TabIndex = 0;
      this.pm1.Text = "Permintaan Turun";
      this.groupBox1.Controls.Add((Control) this.hitung);
      this.groupBox1.Controls.Add((Control) this.sedia);
      this.groupBox1.Controls.Add((Control) this.label8);
      this.groupBox1.Controls.Add((Control) this.minta);
      this.groupBox1.Controls.Add((Control) this.label7);
      this.groupBox1.Controls.Add((Control) this.groupBox2);
      this.groupBox1.Controls.Add((Control) this.prMax);
      this.groupBox1.Controls.Add((Control) this.psMax);
      this.groupBox1.Controls.Add((Control) this.pmMax);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.label5);
      this.groupBox1.Controls.Add((Control) this.label6);
      this.groupBox1.Controls.Add((Control) this.prMin);
      this.groupBox1.Controls.Add((Control) this.psMin);
      this.groupBox1.Controls.Add((Control) this.pmMin);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Location = new Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(690, 197);
      this.groupBox1.TabIndex = 19;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Variabel";
      this.hitung.Cursor = Cursors.Hand;
      this.hitung.Font = new Font("Microsoft Sans Serif", 12f);
      this.hitung.Location = new Point(495, 124);
      this.hitung.Name = "hitung";
      this.hitung.Size = new Size(172, 59);
      this.hitung.TabIndex = 16;
      this.hitung.Text = "Hitung";
      this.hitung.UseVisualStyleBackColor = true;
      this.hitung.Click += new EventHandler(this.hitung_Click);
      this.sedia.Location = new Point(256, 157);
      this.sedia.Name = "sedia";
      this.sedia.Size = new Size(225, 20);
      this.sedia.TabIndex = 15;
      this.label8.AutoSize = true;
      this.label8.Font = new Font("Microsoft Sans Serif", 10f);
      this.label8.Location = new Point(253, 129);
      this.label8.Name = "label8";
      this.label8.Size = new Size(88, 17);
      this.label8.TabIndex = 14;
      this.label8.Text = "Persediaan :";
      this.minta.Location = new Point(16, 157);
      this.minta.Name = "minta";
      this.minta.Size = new Size(200, 20);
      this.minta.TabIndex = 13;
      this.label7.AutoSize = true;
      this.label7.Font = new Font("Microsoft Sans Serif", 10f);
      this.label7.Location = new Point(13, 129);
      this.label7.Name = "label7";
      this.label7.Size = new Size(88, 17);
      this.label7.TabIndex = 12;
      this.label7.Text = "Permintaan :";
      this.groupBox2.Location = new Point(16, 105);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(653, 8);
      this.groupBox2.TabIndex = 11;
      this.groupBox2.TabStop = false;
      this.prMax.Location = new Point(495, 75);
      this.prMax.Name = "prMax";
      this.prMax.Size = new Size(172, 20);
      this.prMax.TabIndex = 10;
      this.psMax.Location = new Point(495, 48);
      this.psMax.Name = "psMax";
      this.psMax.Size = new Size(172, 20);
      this.psMax.TabIndex = 9;
      this.pmMax.Location = new Point(495, 22);
      this.pmMax.Name = "pmMax";
      this.pmMax.Size = new Size(172, 20);
      this.pmMax.TabIndex = 6;
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Microsoft Sans Serif", 10f);
      this.label4.Location = new Point(347, 49);
      this.label4.Name = "label4";
      this.label4.Size = new Size(142, 17);
      this.label4.TabIndex = 8;
      this.label4.Text = "Persediaan Maksimal";
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Microsoft Sans Serif", 10f);
      this.label5.Location = new Point(347, 74);
      this.label5.Name = "label5";
      this.label5.Size = new Size(145, 17);
      this.label5.TabIndex = 7;
      this.label5.Text = "Pemesanan Maksimal";
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Microsoft Sans Serif", 10f);
      this.label6.Location = new Point(347, 25);
      this.label6.Name = "label6";
      this.label6.Size = new Size(142, 17);
      this.label6.TabIndex = 5;
      this.label6.Text = "Permintaan Maksimal";
      this.prMin.Location = new Point(158, 75);
      this.prMin.Name = "prMin";
      this.prMin.Size = new Size(171, 20);
      this.prMin.TabIndex = 4;
      this.psMin.Location = new Point(158, 48);
      this.psMin.Name = "psMin";
      this.psMin.Size = new Size(171, 20);
      this.psMin.TabIndex = 3;
      this.pmMin.Location = new Point(158, 22);
      this.pmMin.Name = "pmMin";
      this.pmMin.Size = new Size(171, 20);
      this.pmMin.TabIndex = 1;
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 10f);
      this.label3.Location = new Point(13, 50);
      this.label3.Name = "label3";
      this.label3.Size = new Size(131, 17);
      this.label3.TabIndex = 2;
      this.label3.Text = "Persediaan Minimal";
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 10f);
      this.label2.Location = new Point(13, 74);
      this.label2.Name = "label2";
      this.label2.Size = new Size(134, 17);
      this.label2.TabIndex = 1;
      this.label2.Text = "Pemesanan Minimal";
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 10f);
      this.label1.Location = new Point(13, 25);
      this.label1.Name = "label1";
      this.label1.Size = new Size(131, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Permintaan Minimal";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1055, 493);
      this.Controls.Add((Control) this.exit);
      this.Controls.Add((Control) this.groupBox8);
      this.Controls.Add((Control) this.tentang);
      this.Controls.Add((Control) this.groupBox7);
      this.Controls.Add((Control) this.groupBox6);
      this.Controls.Add((Control) this.groupBox5);
      this.Controls.Add((Control) this.groupBox4);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.groupBox1);
      this.MaximizeBox = false;
      this.Name = nameof (kasus1);
      this.Text = "Metode Mamdani dalam Pengambilan Keputusan Penentuan Jumlah Produksi (Kasus I)";
      this.groupBox8.ResumeLayout(false);
      this.groupBox8.PerformLayout();
      this.groupBox7.ResumeLayout(false);
      this.groupBox7.PerformLayout();
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
