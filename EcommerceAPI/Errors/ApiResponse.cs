namespace EcommerceAPI.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message=null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }
        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A Bad request, you have made",
                401 => "Authorized you are Not",
                404 => "Response Found it is not",
                500 => "Server error occured",
                 _ => null
            };
        }
    }
}
