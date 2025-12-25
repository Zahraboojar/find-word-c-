using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person2
{
    internal class NationalCodeValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value != null)
            {
                ErrorMessage = "کد ملی نمیتواند خالی باشد";
                return false;
            }

            var code = value.ToString();
            if (!code.IsValidateNationalCode())
            {
                ErrorMessage = "کد ملی نا معتبر میباشد";
                return false;
            }
            return true;
        }
    }
}
