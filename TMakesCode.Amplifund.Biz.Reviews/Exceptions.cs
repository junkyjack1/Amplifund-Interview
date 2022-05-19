using System;

namespace TMakesCode.Amplifund.Biz.Reviews
{
    public class InvalidCarIdException: Exception
    {
        public InvalidCarIdException() : base("Invalid Car Id") { }
    }

    public class InvalidPersonaIdException: Exception
    {
        public InvalidPersonaIdException() : base("Invalid Persona Id") { }
    }
}
