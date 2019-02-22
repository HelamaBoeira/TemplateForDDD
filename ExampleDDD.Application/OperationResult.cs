
using System.Collections.Generic;
namespace ExampleDDD.Application
{
    public class OperationResult
    {
        public bool Success { get; set; }

        public IEnumerable<string> ErrorsMessage { get; set; }

        public OperationResult()
        {
            this.Success = true;
            this.ErrorsMessage = new List<string>();
        }
    }
}
