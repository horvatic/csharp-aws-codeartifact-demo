using helloworldlib;

namespace helloworldlibtest {
    public class HelloWorldTest
    {
        [Fact]
        public void HelloWorldShouldBeSuccessful()
        {
            var helloWorld = new HelloWorld();

            Assert.Equal("Hello world!", helloWorld.GetHelloMessage());
        }
    }
}