﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Parqueo.Movil
{
    interface IPuesto
    {
        String ingresarAuto(Auto auto);
        double salirAuto();
        Boolean estaOcupado();
        Auto getAuto();




    }
}