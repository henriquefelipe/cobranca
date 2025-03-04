﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain
{
    public class DevResponse
    {
        public string id { get; set; }
        public string rtrId { get; set; }
        public string valor { get; set; }
        public devHorarioResponse horario { get; set; }
        public string status { get; set; }
        public string json { get; set; }
    }

    public class devHorarioResponse
    {
        public string solicitacao { get; set; }
    }
}
