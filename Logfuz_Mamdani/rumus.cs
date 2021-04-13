// Decompiled with JetBrains decompiler
// Type: Logfuz_Mamdani.rumus
// Assembly: Logfuz_Mamdani, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C6CE83EF-2608-4ABA-8B76-32A7171B5027
// Assembly location: E:\Semester 8\FuzzyLogic-Mamdani-tugasKuliah-main\Logfuz_Mamdani\bin\Debug\app.publish\Logfuz_Mamdani.exe

namespace Logfuz_Mamdani
{
  public class rumus
  {
    public static double turun(double PmMax, double PmMin, double Permintaan) => Permintaan > PmMin ? (PmMin > Permintaan || Permintaan > PmMax ? 0.0 : (PmMax - Permintaan) / (PmMax - PmMin)) : 1.0;

    public static double naik(double PmMax, double PmMin, double Permintaan) => Permintaan > PmMin ? (PmMin > Permintaan || Permintaan > PmMax ? 0.0 : (Permintaan - PmMin) / (PmMax - PmMin)) : 1.0;

    public static double sedikit(double PsMax, double PsMin, double Persediaan) => Persediaan > PsMin ? (PsMin > Persediaan || Persediaan > PsMax ? 0.0 : (PsMax - Persediaan) / (PsMax - PsMin)) : 1.0;

    public static double banyak(double PsMax, double PsMin, double Persediaan) => Persediaan > PsMin ? (PsMin > Persediaan || Persediaan > PsMax ? 0.0 : (Persediaan - PsMin) / (PsMax - PsMin)) : 1.0;
  }
}
