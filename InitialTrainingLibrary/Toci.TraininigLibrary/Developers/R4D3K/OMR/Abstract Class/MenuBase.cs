﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.R4D3K.OMR.Menu;
namespace Toci.TraininigLibrary.Developers.R4D3K.OMR.Abstract_Class
{
    public abstract class MenuBase
    {
        protected DateTime CreateDate { get; set; }
        protected List<Dishes> ListOfDishes { get; set; }
    }
}
