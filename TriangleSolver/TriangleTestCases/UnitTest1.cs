namespace TriangleTestCases;

public class Tests
{
    //-	Only one (1) test for a valid equilateral triangle

    [Test]
    public void AnalyzeTriangle_In10and10and10_ReturnEquilateral()
    {
        //Arrange
        int firstSide = 10;
        int secondSide = 10;
        int thirdSide = 10;

        string expected = "An equilateral triangle is formed";

        //Act
        string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    //-	Three (3) tests for a valid isosceles triangle

    [Test]
    public void AnalyzeTriangle_In15and40and40_ReturnIsosceles()
    {
        //Arrange
        int firstSide = 15;
        int secondSide = 40;
        int thirdSide = 40;

        string expected = "An isosceles triangle is formed";

        //Act
        string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void AnalyzeTriangle_In40and15and40_ReturnIsosceles()
    {
        //Arrange
        int firstSide = 40;
        int secondSide = 15;
        int thirdSide = 40;

        string expected = "An isosceles triangle is formed";

        //Act
        string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void AnalyzeTriangle_In40and40and15_ReturnIsosceles()
    {
        //Arrange
        int firstSide = 40;
        int secondSide = 40;
        int thirdSide = 15;

        string expected = "An isosceles triangle is formed";

        //Act
        string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
