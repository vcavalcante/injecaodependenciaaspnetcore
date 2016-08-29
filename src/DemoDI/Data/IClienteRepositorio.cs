using System.Collections.Generic;
using DemoDI.Models;

namespace DemoDI.Data
{
    public interface IClienteRepositorio
    {
        List<Cliente> ObterTodos();
    }
}