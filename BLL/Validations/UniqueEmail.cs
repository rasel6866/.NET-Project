using DAL.EF;
using System.ComponentModel.DataAnnotations;

namespace BLL.Validations
{
    public class UniqueEmail : ValidationAttribute
    {

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var db = (DbBloodContext)validationContext.GetService(typeof(DbBloodContext));

            if (value != null)
            {
                var u = (from user in db.Users
                         where user.Email.Equals(value.ToString())
                         select user).SingleOrDefault();

                if (u == null)
                {
                    return ValidationResult.Success;
                }

                return new ValidationResult("Email Exists");
            }

            return new ValidationResult("Data Required");
        }

    }
}