using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays__strings__regex__classes
{
    public class InvalidCountry : Exception { public InvalidCountry(string ex) : base(ex) {} }

    public class InvalidCity : Exception { public InvalidCity(string ex) : base(ex) { } }

    public class InvalidRegion : Exception { public InvalidRegion(string ex) : base(ex) { } }

    public class InvalidPostalCode : Exception { public InvalidPostalCode(string ex) : base(ex) {} }

    public class InvalidStreet : Exception { public InvalidStreet(string ex) : base(ex) { } }

    public class InvalidHouse : Exception { public InvalidHouse(string ex) : base(ex) { } }
}
