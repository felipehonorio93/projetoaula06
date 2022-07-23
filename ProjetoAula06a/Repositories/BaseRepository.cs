using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula06a.Repositories
{
    public abstract class BaseRepository<T>
    {
        public abstract void Exportar(T obj);
    }

}
