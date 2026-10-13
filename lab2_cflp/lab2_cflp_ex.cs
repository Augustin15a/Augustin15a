using System;
using System.Collections;
using System.Collections.Generic;

public enum TipCont{persoana,companie};
class Banca
{
    private String name;
    private String Swift;
    private List<Cont> listaCont = new List<Cont>();

    public Banca(String name,String Swift)
    {
        this.name = name;
        this.Swift = Swift;
    }

    public void DeschidereCont(Cont cont)
    {
        listaCont.Add(cont);
    }

    public Cont GasireCont(String iban)
    {
        foreach(Cont c in listaCont)
        {
            if(iban.Equals(c.getIBAN()))
            {
                return c;
            }
        }
        return null;
    }

    public void DepunereBaniBanca(float bani,String iban)
    {
        Cont c = GasireCont(iban);
        c.DepunereBani(bani);
        Console.WriteLine("Depunere reusita ");
    }
    public void RetragereBaniBanca(float bani,String iban)
    {
        Cont c = GasireCont(iban);
        c.RetragereBani(bani);
        Console.WriteLine("Retragere reusita ");
    }
    public void transfer(float bani,String iban1,String iban2)
    {
        Cont c1 = GasireCont(iban1);
        Cont c2 = GasireCont(iban2);

        c1.RetragereBani(bani);
        c2.DepunereBani(bani);
        Console.WriteLine("Transfer reusit ");
    }
}
class Cont
{
    private String titularCont;
    private TipCont Tip;
    private String IBAN;
    private float suma = 0.0f;

    public Cont(String titularCont,TipCont Tip,String IBAN)
    {
        this.titularCont = titularCont;
        this.Tip = Tip;
        this.IBAN = IBAN;
        this.suma = suma;
    }

    public void DepunereBani(float bani)
    {
        suma += bani;
    }

    public void RetragereBani(float bani)
    {
        suma -= bani;
        if(suma < 0)
        {
            Console.WriteLine("fonduri insuficiente!");
            suma += bani;
        }
    }
    public override String ToString()
    {
        return "Titular Cont: " + titularCont + "\nTip: " + Tip + "\nIBAN: " + IBAN + "\nsuma: " + suma;
    }

    public String getIBAN()
    {
        return IBAN;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Banca bancaMea = new Banca("Banca Transilvania", "BTRLRO22");

        Cont c1 = new Cont("Ion Popescu", TipCont.persoana, "RO11BTRL00001");
        Cont c2 = new Cont("SC Firma SRL", TipCont.companie, "RO22BTRL00002");

        bancaMea.DeschidereCont(c1);
        bancaMea.DeschidereCont(c2);
        bancaMea.DepunereBaniBanca(1000f, "RO11BTRL00001");
        Cont c = bancaMea.GasireCont("RO11BTRL00001");
        Console.WriteLine(c.ToString());
        bancaMea.transfer(300f, "RO11BTRL00001", "RO22BTRL00002");
        c = bancaMea.GasireCont("RO22BTRL00002");
        Console.WriteLine(c.ToString());
    }
}