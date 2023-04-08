﻿using Booking.Domain.Entities;
using Booking.Domain.Ports.RepositoryGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Domain.Ports
{
    public interface IClientRepository : IBaseRepository<Client>
    {
        Task<Client> GetClientByCPF(string CPF);
        Task<bool> ClientExist(int id);
    }
}
