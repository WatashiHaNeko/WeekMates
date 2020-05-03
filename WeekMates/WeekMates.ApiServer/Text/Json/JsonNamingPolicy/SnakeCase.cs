using System.Text.Json;

using static WeekMates.ApiServer.Utilities.Text;

namespace WeekMates.ApiServer.Text.Json
{
    public class SnakeCase : JsonNamingPolicy
    {
        public override string ConvertName(string name)
        {
            return CamelCaseToSnakeCase(name);
        }
    }
}
