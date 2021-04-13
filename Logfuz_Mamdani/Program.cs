// Decompiled with JetBrains decompiler
// Type: Logfuz_Mamdani.Program
// Assembly: Logfuz_Mamdani, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C6CE83EF-2608-4ABA-8B76-32A7171B5027
// Assembly location: E:\Semester 8\FuzzyLogic-Mamdani-tugasKuliah-main\Logfuz_Mamdani\bin\Debug\app.publish\Logfuz_Mamdani.exe

using System;
using System.Windows.Forms;

namespace Logfuz_Mamdani
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new menu());
    }
  }
}
