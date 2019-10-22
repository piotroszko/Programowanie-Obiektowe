using System;

public class Car
{
    public string marka;
    public int rok;

    private string model;
    private int iloscDrzwi;
    private int pojemnoscSilnika;
    public float srednieSpalanie;
    public Car(string marka, int rok)
    {
        this.marka = marka;
        this.rok = rok;
    }
    private double ObliczSpalanie(double dlugoscTrasy){
        double spalanie = (srednieSpalanie * dlugoscTrasy);
        return spalanie;
    }
    public double ObliczKosztPrzejazdu(double dlugoscTrasy,double cenaPaliwa) {
        double kosztPrzejazdu = ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
        return kosztPrzejazdu;

    }
}
