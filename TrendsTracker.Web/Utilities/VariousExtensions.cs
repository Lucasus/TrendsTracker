using AutoMapper;

namespace TrendsTracker.Web.Utilities
{
    public static class VariousExtensions
    {
        public static bool IsNullOrZero(this int? value)
        {
            return value == null || !value.HasValue || value.Value == 0;
        }
    }
}