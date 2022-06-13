using espaceVertV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace espaceVertV2.Gestion
{
    public abstract class Gestion
    {
        public readonly mydbContext Context;

        public Gestion()
        {
            Context = new mydbContext() ;
        }
    }
}
