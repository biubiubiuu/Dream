using Dream.Application;
using Dream.HelloWord.Impl;

namespace Dream.HelloWord
{
    public class HelloWorldService : ServiceBase, IHelloWorldService
    {
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
