using System;
using Xunit;

namespace Program.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void 何も指定されていない場合は既定の挨拶を返す()
        {
            Assert.Equal("Hello from .NET", App.helloWorld());
        }

        [Fact]
        public void 指定された名前で挨拶を返す()
        {
            Assert.Equal("Hello from VSCode", App.helloWorld("VSCode"));
        }
    }
}

class App
{
    public static String helloWorld()
    {
        return "Hello from .NET";
    }
    public static String helloWorld(String name)
    {
        return $"Hello from {name}";
    }
}
