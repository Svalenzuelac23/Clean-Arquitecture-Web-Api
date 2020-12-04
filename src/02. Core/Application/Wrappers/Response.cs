using System.Collections.Generic;

namespace Application.Wrappers
{
    public class Response<T>
    {
        public Response()
        {

        }

        public Response(T data, string message = null)
        {
            Succeded = true;
            Message = message;
            Data = data;
        }
        public Response(string message)
        {
            Succeded = false;
            Message = message;
        }

        public bool Succeded { get; set; }
        public string Message { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public T Data { get; set; }
    }
}
