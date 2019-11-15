﻿using Application.AeroportoViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contract
{
    public interface IAeroportoService
    {
        Task<IEnumerable<AeroportosViewModel>> BuscarAeroportos();
    }
}
