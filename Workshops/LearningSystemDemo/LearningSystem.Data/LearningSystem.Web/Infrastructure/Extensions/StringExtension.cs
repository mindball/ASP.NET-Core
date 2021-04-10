using System.Text.RegularExpressions;

namespace LearningSystem.Web.Infrastructure.Extensions
{
    public static class StringExtension
    {
        public static string ToFriendlyUrl(this string text)
            => Regex.Replace(text, @"[^A-Za-z0-9_\.~]+", "-").ToLower();
    }
}
