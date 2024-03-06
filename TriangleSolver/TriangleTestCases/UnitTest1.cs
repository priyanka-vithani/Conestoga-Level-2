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

    // Five (5) tests for a valid scalene triangle

    [Test]
    public void AnalyzeTriangle_In12and16and20_ReturnScalene()
    {
        // Arrange
        int firstSide = 12;
        int secondSide = 16;
        int thirdSide = 20;

        string expected = "A scalene triangle is formed";

        // Act
        string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void AnalyzeTriangle_In14and48and50_ReturnScalene()
    {
        // Arrange
        int firstSide = 14;
        int secondSide = 48;
        int thirdSide = 50;

        string expected = "A scalene triangle is formed";

        // Act
        string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void AnalyzeTriangle_In24and55and51_ReturnScalene()
    {
        // Arrange
        int firstSide = 24;
        int secondSide = 45;
        int thirdSide = 51;

        string expected = "A scalene triangle is formed";

        // Act
        string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void AnalyzeTriangle_In3and4and5_ReturnScalene()
    {
        // Arrange
        int firstSide = 3;
        int secondSide = 4;
        int thirdSide = 5;

        string expected = "A scalene triangle is formed";

        // Act
        string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void AnalyzeTriangle_In5and13and14_ReturnScalene()
    {
        // Arrange
        int firstSide = 5;
        int secondSide = 13;
        int thirdSide = 14;

        string expected = "A scalene triangle is formed";

        // Act
        string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    //-	Three (3) tests for verifying a zero length for one or more sides

    [Test]
    public void AnalyzeTriangle_OneSideIsZero_ReturnInvalid()
    {
        // Arrange
        int firstSide = 0;
        int secondSide = 3;
        int thirdSide = 9;

        string expected = "At least one side entered had a zero - invalid triangle";

        // Act
        string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void AnalyzeTriangle_TwoSidesAreZero_ReturnInvalid()
    {
        // Arrange
        int firstSide = 5;
        int secondSide = 0;
        int thirdSide = 0;

        string expected = "At least one side entered had a zero - invalid triangle";

        // Act
        string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void AnalyzeTriangle_ZeroForAllSides_ReturnInvalid()
    {
        // Arrange
        int firstSide = 0;
        int secondSide = 0;
        int thirdSide = 0;

        string expected = "At least one side entered had a zero - invalid triangle";

        // Act
        string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    //-	Three (3) tests for verifying an invalid response (other than a zero length)

    [Test]
    public void AnalyzeTriangle_OneSideIsGreaterThanTwoSidesAddition_ReturnInvalid()
    {
        // Arrange
        int firstSide = 1;
        int secondSide = 2;
        int thirdSide = 5;

        string expected = "A triangle cannot be formed";

        // Act
        string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void AnalyzeTriangle_OneSideIsEqualTwoSidesAddition_ReturnInvalid()
    {
        // Arrange
        int firstSide = 1;
        int secondSide = 2;
        int thirdSide = 3;

        string expected = "A triangle cannot be formed";

        // Act
        string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void AnalyzeTriangle_AnyOneSideIsNegative_ReturnInvalid()
    {
        // Arrange
        int firstSide = -1;
        int secondSide = 8;
        int thirdSide = 9;

        string expected = "A triangle cannot be formed";

        // Act
        string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
