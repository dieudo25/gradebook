namespace GradeBook.Tests;

public class BookTests
{
    Book book;

    public BookTests()
    {
        book = new Book("Test");
    }

    [Fact]
    public void BookAddGradeTest()
    {
        // Arrange
        book.AddGrade(14);
        book.AddGrade(12);
        book.AddGrade(17);

        // Act
        var result = book.Grades.Count;

        // Assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void BookGetAverageGradeTest()
    {
        // Arrange
        book.AddGrade(14);
        book.AddGrade(12);
        book.AddGrade(17);

        // Act
        var result = book.GetAverage();

        // Assert
        Assert.Equal(14.3, result, 1);
    }

    [Fact]
    public void BookGetHighestGradeTest()
    {
        // Arrange
        book.AddGrade(14);
        book.AddGrade(12);
        book.AddGrade(17);

        // Act
        var result = book.GetHighestGrade();

        // Assert
        Assert.Equal(17, result, 1);
    }

    [Fact]
    public void BookGetLowestGradeTest()
    {
        // Arrange
        book.AddGrade(14);
        book.AddGrade(12);
        book.AddGrade(17);

        // Act
        var result = book.GetLowestGrade();

        // Assert
        Assert.Equal(12, result, 1);
    }
}