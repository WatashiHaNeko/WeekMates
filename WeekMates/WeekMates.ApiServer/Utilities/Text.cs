using System;
using System.Globalization;
using System.Text;

namespace WeekMates.ApiServer.Utilities
{
    public static class Text
    {
        public static string CamelCaseToSnakeCase(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            // Allocates a string builder with the guessed result length,
            // where 5 is the average word length in English, and
            // max(2, length / 5) is the number of underscores.
            StringBuilder builder = new StringBuilder(text.Length + Math.Max(2, text.Length / 5));
            UnicodeCategory? previousCategory = null;

            for (int currentIndex = 0; currentIndex < text.Length; currentIndex++)
            {
                char currentChar = text[currentIndex];
                if (currentChar == '_')
                {
                    builder.Append('_');
                    previousCategory = null;
                    continue;
                }

                UnicodeCategory currentCategory = char.GetUnicodeCategory(currentChar);

                switch (currentCategory)
                {
                    case UnicodeCategory.UppercaseLetter:
                    case UnicodeCategory.TitlecaseLetter:
                        if (previousCategory == UnicodeCategory.SpaceSeparator ||
                            previousCategory == UnicodeCategory.LowercaseLetter ||
                            previousCategory != UnicodeCategory.DecimalDigitNumber &&
                            currentIndex > 0 &&
                            currentIndex + 1 < text.Length &&
                            char.IsLower(text[currentIndex + 1]))
                        {
                            builder.Append('_');
                        }

                        currentChar = char.ToLower(currentChar);
                        break;

                    case UnicodeCategory.LowercaseLetter:
                    case UnicodeCategory.DecimalDigitNumber:
                        if (previousCategory == UnicodeCategory.SpaceSeparator)
                        {
                            builder.Append('_');
                        }
                        break;

                    default:
                        if (previousCategory != null)
                        {
                            previousCategory = UnicodeCategory.SpaceSeparator;
                        }
                        continue;
                }

                builder.Append(currentChar);
                previousCategory = currentCategory;
            }

            return builder.ToString();
        }
    }
}