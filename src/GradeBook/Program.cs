using GradeBook;

var book = new Book("Dieudonné's Grade Book");

book.AddGrade(18);
book.AddGrade(14);
book.AddGrade(12);
book.AddGrade(17);

book.GetAverage();

book.GetInfo();