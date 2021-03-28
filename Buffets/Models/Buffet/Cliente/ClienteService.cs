using System;
using System.Collections.Generic;

namespace Buffets.Models.Buffet.Cliente
{
    public class ClienteService
    {
        public List<ClienteEntity> obterClientes()
        {
            var listaDeClientes = new List<ClienteEntity>();
            listaDeClientes.Add(item:new ClienteEntity
            {
                Id=1,
                Nome="Thiago",
                DataDeNascimento = new DateTime(year:1983,month:12,day:16)
            });
            listaDeClientes.Add(item:new ClienteEntity
            {
                Id=2,
                Nome="JOSÉ",
                DataDeNascimento = new DateTime(year:1977,month:09,day:25)
            });
            return listaDeClientes;
        }
    }
}