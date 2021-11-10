using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.LeilaoOnline.Core
{
    public interface IModaliadadeAvaliacao
    {
        Lance Avalia(Leilao leilao);
    }
}
