using System.ComponentModel.DataAnnotations;

namespace BasicShopAPI.API.Validations
{
    public class AllowedValuesAttribute: ValidationAttribute
    {
        private readonly string[] _allowed;

        public AllowedValuesAttribute(params string[] allowed)
        {
            _allowed = allowed;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is null) return ValidationResult.Success;

            if (value is string str && _allowed.Contains(str.ToLower()))
                return ValidationResult.Success;

            return new ValidationResult($"Gender must be one of: {string.Join(", ", _allowed)}");
        }
    }
}
