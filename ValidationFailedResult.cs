using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Localization
{
    public class ValidationFailedResult : ObjectResult
    {
        public ValidationFailedResult(ModelStateDictionary modelState)
            : base(new ValidationResultModel(modelState))
        {
            StatusCode = StatusCodes.Status400BadRequest;
        }
    }

    public class ValidationResultModel
    {
        public List<ValidationError> Errors { get; }

        public ValidationResultModel(ModelStateDictionary modelState)
        {
            Errors = modelState.Keys
                    .SelectMany(key => modelState[key]!.Errors.Select(x => new ValidationError(x.ErrorMessage)))
                    .ToList();
        }
    }

    public class ValidationError
    {
        public string Message { get; }

        public ValidationError(string message)
        {
            Message = message;
        }
    }
}
