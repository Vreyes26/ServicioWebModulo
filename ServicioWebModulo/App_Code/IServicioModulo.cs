using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract]
public interface IServicioModulo
{
    [OperationContract]
    int ObtenerModulo(int divisor, int dividendo);
}

[DataContract]
public class Modulo
{
    private int _divisor, _dividendo;
    [DataMember]
    public int Divisor
    {
        get
        {
            return _divisor;
        }

        set
        {
            _divisor = value;
        }
    }

    [DataMember]
    public int Dividendo
    {
        get
        {
            return _dividendo;
        }

        set
        {
            _dividendo = value;
        }
    }
    
}