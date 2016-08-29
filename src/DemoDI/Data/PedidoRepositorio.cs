using DemoDI.Models;
using System.Collections.Generic;

namespace DemoDI.Data
{
    public class ClienteRepositorio
    {
        public ClienteRepositorio()
        {
        }

        public List<Cliente> ObterTodos() {
            return new List<Cliente>
            {
                new Cliente { Id=1,Nome="victor"},
                new Cliente { Id=2,Nome="Giovanni"}
            };
        }
    }
}