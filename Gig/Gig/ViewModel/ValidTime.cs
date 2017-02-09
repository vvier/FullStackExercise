using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Gig.ViewModel
{
    public class ValidTime : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime result;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "HH:mm",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out result);
            return isValid;
        }
    }
}