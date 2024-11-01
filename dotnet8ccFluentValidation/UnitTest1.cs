using FluentValidation;

namespace dotnet8ccFluentValidation
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var personDetails = new PersonDetails();
            personDetails.Numbers = new List<int>();
            personDetails.Numbers.Add(1);
            personDetails.Numbers.Add(2);
            personDetails.Numbers.Add(3);

            //var validator = new SaleValidator().Validate(personDetails);

        }
    }

    public class PersonDetails
    {
        public IList<int> Numbers { get; set; }
    }

    public class SaleValidator : AbstractValidator<PersonDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaleValidator"/> class.
        /// </summary>
        /// <param name="jurisdiction">The jurisdiction.</param>
        /// <param name="household">The household.</param>
        /// <param name="dcPensions">The dc pensions.</param>
        public SaleValidator()
        {


            RuleFor(input => input.Numbers)
                .Must(AllEvenNumber);
        }

        /// <summary>
        /// All the person IDs are unique.
        /// </summary>
        /// <param name="superContributions">The super contributions.</param>
        /// <returns>true if all descriptions are unique.</returns>
        private static bool AllEvenNumber(
            IList<int> numbers)
        {
            if (numbers is null)
            {
                return true;
            }



            return numbers.Count == 3;
        }
    }
}