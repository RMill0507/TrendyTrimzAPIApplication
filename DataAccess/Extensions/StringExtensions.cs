

namespace DataAccess.Extensions
{
    public static class StringExtensions
    {
        public static string FormattedPhoneNumber(this string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
            {
                return string.Empty;
            }
            if (phoneNumber.Length == 10)
            {
                return string.Format("{0:(000)-000-0000}", long.Parse(phoneNumber));
            }
            else return phoneNumber;
        }
    }
}
