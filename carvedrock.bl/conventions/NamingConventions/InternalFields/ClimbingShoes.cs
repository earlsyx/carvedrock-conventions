
namespace carvedrock.bl.Conventions.NamingConventions.InternalFields
{
    public class ClimbingShoes
    {
        public int Name;

        private readonly int uniqueIdentifier;

        public ClimbingShoes()
        {
            uniqueIdentifier = 0;

            var variable_Inside_Constructor = "";

            Console.WriteLine(variable_Inside_Constructor);
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} (UniqueId={uniqueIdentifier})";
        }
    }
}
