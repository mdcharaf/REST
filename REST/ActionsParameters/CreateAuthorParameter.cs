using System;

namespace REST.ActionsParameters
{
    public class CreateAuthorParameter
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string MainCategory { get; set; }
    }
}