using System.Collections;

namespace Vezbe3
{
    internal class NasEnumetor : IEnumerator
    {
        private object[] vrednosti;
        int trenutniIndeks = 0;

        public NasEnumetor(object[] vrednosti)
        {
            this.vrednosti = vrednosti;
        }

        // object IEnumerator.Current => throw new System.NotImplementedException();
        public object Current
        {
            get
            { // vracamo konkretnu kvrednost na datom indeksu
                return vrednosti[trenutniIndeks++];
            }
        }
        bool IEnumerator.MoveNext()
        {// prolazenje kroz listu
            if(trenutniIndeks < vrednosti.Length)
            {
                return true; // postoje vrednosti koje treba da se vrate
            }
            return false;
            
        }

        void IEnumerator.Reset()
        {
            throw new System.NotImplementedException();
        }
    }
}