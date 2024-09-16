namespace Vezba
{
    public class Posetilac
    {
        public int idPosetioca;
        public string ime;

        public Posetilac(int idPosetioca, string ime)
        {
            this.idPosetioca = idPosetioca;
            this.ime = ime;
        }

        public override string ToString()
        {
            return this.ime;
        }
    }
}