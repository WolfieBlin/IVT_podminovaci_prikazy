namespace IVT_podminovaci_prikazy
{
    public interface ILinearniRovniceVypocet
    {
        // do interface se dá methoda kterou chceme sdílet s ostatníma
        //nepoužívá se před ní žádné označení např public, platí i pro string int atd
        
        void Vypocet(double a, double b);
    }
}