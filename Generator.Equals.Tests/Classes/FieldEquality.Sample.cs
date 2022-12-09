namespace Generator.Equals.Tests.Classes
{
    public partial class FieldEquality
    {
        [Equatable]
        public partial class Sample
        {
            public Sample(string[] addresses)
            {
                _addresses = addresses;
            }

            [OrderedEquality] private readonly string[] _addresses;
        }
    }
}