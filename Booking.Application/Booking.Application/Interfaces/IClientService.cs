﻿using Booking.Application.DTOs.ResponseDTO;
using Booking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Interfaces
{
    public interface IClientService
    {
        Task<Response<Client>> CreateClient(Client client);
        Task<Response<Client>> GetClient(int id);
        Task<Response<Client>> UpdateClientInfo(Client client);
        Task<Response<Client>> UpdatePassword(Client client);
    }
}
