﻿using SistemaDeVentas.DomainEntities.Entities;
using SistemaDeVentas.DomainEntities.EntityDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Application.ServicesContracts
{
    public interface IVentaService
    {
        Task<ICollection<Venta>> GetAllAsync();

        Task<Venta> GetIdAsync(int id);

        Task AddAsync(VentaDTO ventaDTO);

        Task DeleteAsycn(int id);
    }
}
