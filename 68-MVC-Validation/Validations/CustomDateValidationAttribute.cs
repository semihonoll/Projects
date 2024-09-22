using System.ComponentModel.DataAnnotations;

namespace _68_MVC_Validation.Validations
{
    public class CustomDateValidationAttribute : ValidationAttribute
    {
        private readonly DateTime _startDate;
        public CustomDateValidationAttribute(int startYear, int startMonth, int startDay)
        {
                _startDate = new DateTime(startYear, startMonth, startDay);
        }
        public override bool IsValid(object? value)
        {
            if (value is DateTime dateValue) 
            { 
                if(dateValue >= _startDate)
                    return true;
            }
            return false;
        }
    }
}
