using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using System;

namespace neo3_hello_world
{
    [DisplayName("neo3_hello_world")]
    [ManifestExtra("Author", "tomio")]
    [ManifestExtra("Email", "tobilokki99@gmail.com")]
    [ManifestExtra("Description", "This is a neo3_hello_world")]
    public class neo3_hello_world : SmartContract
    {
        public const string test_str = "hello world";
        public static String Main(string operation, object[] args)
        {
            Storage.put("Hello", "World");
            return test_str;
        }
    }
}
