using Idiomas.CRUD.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idiomas.CRUD.Domain.CursoIdiomas
{
    public class Turma : Entity<Guid>
    {
        public Turma(string numero, int anoLetivo)
        {
            Numero = numero;
            AnoLetivo = anoLetivo;
        }

        protected Turma() { 
        
        }
        public string Numero {  get; set; }
        public int AnoLetivo {  get; set; }
    }
}
