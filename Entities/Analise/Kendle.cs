using System;
using System.Collections.Generic;
using System.Text;

namespace BotDayTrade.Entities
{
    class Kendle
    {
        public double ValorAtual { get; set; }
        public double ValorMaximo { get; set; }
        public double ValorMinimo { get; set; }

        public DateTime TempoDecorrido { get; set; }
    }
}
