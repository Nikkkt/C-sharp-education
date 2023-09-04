using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays__strings__regex__classes
{
    public class InvalidSurname : Exception { public InvalidSurname(string ex) : base(ex) {} }

    public class InvalidName : Exception { public InvalidName(string ex) : base(ex) {} }

    public class InvalidPatronymic : Exception { public InvalidPatronymic(string ex) : base(ex) {} }

    public class InvalidBirthDate : Exception { public InvalidBirthDate(string ex) : base(ex) {} }

    public class InvalidAddress : Exception { public InvalidAddress(string ex) : base(ex) {} }

    public class InvalidPhoneNumber : Exception { public InvalidPhoneNumber(string ex) : base(ex) {} }

    public class InvalidGrade : Exception { public InvalidGrade(string ex) : base(ex) {} }
}
