using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattagliaNavale_Sacchiero
{
    public abstract class CgiocoBase
    {
        public int[,] Campo { get; protected set; } = new int[10, 10];
        public List<Cnave> Navi { get; protected set; } = new List<Cnave>();
        public int MosseEffettuate { get; protected set; }
        public int NaviNonAffondate { get; protected set; }

        public abstract void GestisciClickCella(int x, int y);
        public abstract void RiproduciSuono(bool colpito);
    }
}
