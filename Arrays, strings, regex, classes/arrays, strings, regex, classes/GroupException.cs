using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays__strings__regex__classes
{
    public class InvalidGroupStudents : Exception { public InvalidGroupStudents(string ex) : base(ex) {} }

    public class GroupDuplicateStudents : Exception { public GroupDuplicateStudents(string ex) : base(ex) {} }

    public class InvalidGroupName : Exception { public InvalidGroupName(string ex) : base(ex) {} }

    public class InvalidGroupSpecialization: Exception { public InvalidGroupSpecialization(string ex) : base(ex) {} }

    public class InvalidGroupCourseNumber: Exception { public InvalidGroupCourseNumber(string ex) : base(ex) {} }
}