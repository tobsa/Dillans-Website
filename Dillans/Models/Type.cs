using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Dillans.Models
{
    public enum Type
    {
        Standard,
        Inbakad,
        Stark,
        [Description("halvt inbakad")]
        HalvtInbakad,
        Dubbelinbakad
    }
}