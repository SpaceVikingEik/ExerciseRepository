namespace ExerciseRepository.Tests;
using ExerciseRepository;
public class UnitTest1
{
    [Fact]
    public void Test1()
    {

        //Arrange
        String helloTest = "";
        Program TestObject = new Program();
        //Act
        helloTest = TestObject.HelloWorld();
        //Assert
        Assert.Equal("HelloWorld", helloTest);
    }

    [Fact]

       public void Test2()
    {

        //Arrange
        String helloTest = "";
        Program TestObject = new Program();
        //Act
        helloTest = TestObject.HelloWorld();
        //Assert
        Assert.Equal("HelloWorld", helloTest);
    }
}