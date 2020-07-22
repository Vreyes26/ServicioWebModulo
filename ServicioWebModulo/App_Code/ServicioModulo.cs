using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

public class ServicioModulo : IServicioModulo
{
    public int ObtenerModulo(int dividendo, int divisor)
    {
        return (dividendo % divisor);
    }
}
