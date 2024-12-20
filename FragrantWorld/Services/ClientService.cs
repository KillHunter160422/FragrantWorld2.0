using FragrantWorld.Data;
using FragrantWorld.Interface;
using FragrantWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FragrantWorld.Services
{
    public class ClientService : IClientService
    {
        private readonly FW_ShopDbContext _context;

        public ClientService(FW_ShopDbContext context)
        {
            _context = context;
        }
        public List<Client> GetAllClients()
        {
            return _context.Clients.ToList();
        }
    }
}
