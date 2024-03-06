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
}
