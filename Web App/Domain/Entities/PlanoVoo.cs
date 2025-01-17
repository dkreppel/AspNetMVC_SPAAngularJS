﻿using Domain.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class PlanoVoo : IEntidadeDominio
    {

        public int IDPLANOVOO { get; set; }

        public string NUMEROVOO { get; set; }

        public DateTime DATA { get; set; }

        public int? IDAERONAVE { get; set; }

        public int? IDAEROPORTOORIGEM { get; set; }

        public int? IDAEROPORTODESTINO { get; set; }

        public string MATRICULA { get; set; }

        public string TIPOAERONAVE { get; set; }

        public string ORIGEM { get; set; }

        public string DESTINO{ get; set; }

    }
}
