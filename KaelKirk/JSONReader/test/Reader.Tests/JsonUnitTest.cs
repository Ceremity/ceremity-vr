using System;
using Xunit;
using Reader.ClassLib;
using System.IO;
using Newtonsoft.Json;

namespace Reader.Tests
{
    public class JsonUnitTest
    {
        [Fact]
        public void Test1()
        {

            // StreamReader r = new StreamReader("file.json");
            // string json = r.ReadToEnd();
            string json = @"{
                
            }";
            Level items = JsonConvert.DeserializeObject<Level>(json);

        }
    }
}
