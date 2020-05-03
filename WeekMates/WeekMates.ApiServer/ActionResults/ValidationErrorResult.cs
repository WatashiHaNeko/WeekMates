using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Linq;
using WeekMates.ApiServer.Models;

using static WeekMates.ApiServer.Utilities.Text;

namespace WeekMates.ApiServer.ActionResults
{
    public class ValidationErrorResult : JsonResult
    {
        public ValidationErrorResult(ModelStateDictionary modelState) : base(modelState)
        {
            StatusCode = 200;

            Value = new {
                Success = false,
                ErrorCode = "0",
                Data = new {
                    ValidationErrors = modelState
                        .Select(x =>
                        {
                            return new ValidationError {
                                Field = CamelCaseToSnakeCase(x.Key),
                                Message = x.Value.Errors.First().ErrorMessage,
                            };
                        })
                        .ToList(),
                },
            };
        }
    }
}