using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchange
{
    public class CurrencyModel
    {
        public required ConversionRate conversion_rates { get; set; }
    }
}
