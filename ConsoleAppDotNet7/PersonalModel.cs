using System.Diagnostics.CodeAnalysis;

namespace RequiredProperties
{
    internal class PersonalModel
    {
        public required string FirstName { get; set; }

        public required string LastName { get; set; }

        [SetsRequiredMembers]
        public PersonalModel()
        { }

        //[SetsRequiredMembers]
        //public PersonalModel(string firstName, string lastName)
        //{}
    }
}
