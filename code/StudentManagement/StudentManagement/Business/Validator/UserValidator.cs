using System;
using StudentManagement.Business.Entity;

namespace StudentManagement.Business.Validator
{
    public class UserValidator : IGenericValidator<User>
    {
        public void Validate(User entity)
        {
            if (entity.Name.Length < 3 || entity.Name.Length > 40)
            {
                throw new ArgumentException("user name too small or too long");
            }

            if (entity.Address.Length < 3 || entity.Address.Length > 40)
            {
                throw new ArgumentException("user addres too small or too long");
            }

            if (entity.CardNumber.Length < 3 || entity.CardNumber.Length > 40)
            {
                throw new ArgumentException("user cardnumber too small or too long");
            }

            if (entity.PersonalNumericalCode.Length < 3 || entity.PersonalNumericalCode.Length > 40)
            {
                throw new ArgumentException("user personal numerical code too small or too long");
            }
        }
    }
}