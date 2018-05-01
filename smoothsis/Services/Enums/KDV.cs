using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smoothsis.Services.Enums
{
    public enum KDV
    {
        [System.ComponentModel.Description("KDV Dahil Değil")]
        DahilDegil = 0,
        [System.ComponentModel.Description("KDV Dahil")]
        Dahil = 1
    }
}