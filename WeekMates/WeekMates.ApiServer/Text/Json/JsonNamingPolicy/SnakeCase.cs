using System.Text.Json;

namespace WeekMates.ApiServer.Text.Json
{
    public class SnakeCase : JsonNamingPolicy
    {
        public override string ConvertName(string name)
        {
              string result = "";

              foreach (char c in name.ToCharArray())
              {
                    if (char.IsUpper(c) && !string.IsNullOrEmpty(result))
                    {
                          result += "_";
                    }
                    
                    result += char.ToLower(c);
              }

              return result;
        }
    }
}
