namespace Vezba
{
    public class PoseteFestivalima
    {
        public string naziv;
        public string godina;
        public string cena;
        public string dan;

        public PoseteFestivalima(string naziv, string godina, string cena, string dan)
        {
            this.naziv = naziv;
            this.godina = godina;
            this.cena = cena;
            this.dan = dan;
        }
    }
}