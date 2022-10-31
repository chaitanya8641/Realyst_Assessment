using Newtonsoft.Json;

namespace Realyst.Common
{
    public class ResponseUtility
    {
        public const string Success = "Request was Successful";

        public const string UnSuccessful = "Request was unsuccessful";

        public static ResponseModel CreateResponse<T>(T response, bool isSuccessful = true)
        {
            return new ResponseModel
            {
                Success = isSuccessful,
                Message = isSuccessful ? Success : UnSuccessful,
                Data = !EqualityComparer<T>.Default.Equals(response, default(T)) ? JsonConvert.SerializeObject(response) : null
            };
        }
    }
}
