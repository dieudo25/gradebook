namespace GradeBook.Tests;

public class TypeTests
{
    [Fact]
    public void StringBehaveLikeValueTypes()
    {
        string name = "Dd";
        
        var upper = MakeUppercase(name);

        Assert.Equal("Dd", name);
        Assert.Equal("DD", upper);
    }

    [Fact]
    public void ValueTypeAlsoPassByValue()
    {
        var x = GetInt();

        Assert.Equal(3, x);

        SetInt(ref x);

        Assert.Equal(42, x);
    }

    [Fact]
    public void CSharpCanPassByRef()
    {
        var book1 = GetBook("Book 1");
        
        GetBookSetName(ref book1, "New Name");

        Assert.Equal("New Name", book1.Name);

    }

    [Fact]
    public void CSharpIsPassByValue()
    {
        var book1 = GetBook("Book 1");
        
        GetBookSetName(book1, "New Name");

        Assert.Equal("Book 1", book1.Name);

    }

    [Fact]
    public void CanSetNameFromRefenrece()
    {
        var book1 = GetBook("Book 1");
        
        SetName(book1, "New Name");

        Assert.Equal("New Name", book1.Name);

    }

    [Fact]
    public void GetBookReturnsDifferentObjects()
    {
        var book1 = GetBook("Book 1");
        var book2 = GetBook("Book 2");

        Assert.Equal("Book 1", book1.Name);
        Assert.Equal("Book 2", book2.Name);
        Assert.NotSame(book1, book2);
    }

    [Fact]
    public void TwoVarsCanReferenceSameObject()
    {
        var book1 = GetBook("Book 1");
        var book2 = book1;

        Assert.Equal("Book 1", book1.Name);
        Assert.Equal("Book 1", book2.Name);
        Assert.Same(book1, book2);
        Assert.True(Object.ReferenceEquals(book1, book2));
    }

    internal int GetInt()
    {
        return 3;
    }

    internal void SetInt(ref int x)
    {
        x = 42;
    }

    internal Book GetBook(string name)
    {
        return new Book(name);
    }

    internal void SetName(Book book, string name)
    {
        book.Name = name;
    }

    internal void GetBookSetName(Book book, string name)
    {
        book = new Book(name);
    }

    private string MakeUppercase(string param)
    {
        return param.ToUpper();
    }

    // ref means I will receive not a copy af the value but a reference of where the value is hold
    internal void GetBookSetName(ref Book book, string name) 
    {
        book = new Book(name);
    }
}