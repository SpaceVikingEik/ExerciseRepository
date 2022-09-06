namespace ExerciseRepository.Tests;
using ExerciseRepository;
public class UnitTest1
{
    [Fact]
    public void HelloWorldTestOfTestingFeature()
    {

        //Arrange
        String helloWorldTest = "";
        Program placeHolderProgram = new Program();
        //Act
        helloWorldTest = placeHolderProgram.HelloWorld();
        //Assert
        Assert.Equal("HelloWorld", helloWorldTest);
    }

    [Fact]

       public void LeapYearEveryFourYears()
    {
        //Arrange
        bool LeapYearEveryFourYears = false;
        Program placeHolderProgram = new Program();
        //Act & Assert
        LeapYearEveryFourYears = placeHolderProgram.IsLeapYear(4);
        Assert.True(LeapYearEveryFourYears);

        LeapYearEveryFourYears = placeHolderProgram.IsLeapYear(8);
        Assert.True(LeapYearEveryFourYears);

        LeapYearEveryFourYears = placeHolderProgram.IsLeapYear(12);
        Assert.True(LeapYearEveryFourYears);

        LeapYearEveryFourYears = placeHolderProgram.IsLeapYear(16);
        Assert.True(LeapYearEveryFourYears);

        LeapYearEveryFourYears = placeHolderProgram.IsLeapYear(20);
        Assert.True(LeapYearEveryFourYears);
    }
    [Fact]
           public void LeapYearEveryFourHundredYears()
    {
        //Arrange
        bool LeapYearEveryFourYears = false;
        Program placeHolderProgram = new Program();
        //Act & Assert
        LeapYearEveryFourYears = placeHolderProgram.IsLeapYear(1600);
        Assert.True(LeapYearEveryFourYears);

        LeapYearEveryFourYears = placeHolderProgram.IsLeapYear(1700);
        Assert.False(LeapYearEveryFourYears);

        LeapYearEveryFourYears = placeHolderProgram.IsLeapYear(1800);
        Assert.False(LeapYearEveryFourYears);

        LeapYearEveryFourYears = placeHolderProgram.IsLeapYear(1900);
        Assert.False(LeapYearEveryFourYears);
        
        LeapYearEveryFourYears = placeHolderProgram.IsLeapYear(2000);
        Assert.True(LeapYearEveryFourYears);
    }
}