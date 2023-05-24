// an author has written many books, each book has an edition
// C_AUT -> means 'class Author'
// C_BOO -> means 'class Book'
// a_id  -> means 'attribute id'
// a_isb -> means 'attribute isbn'
// a_yop -> means 'attribute year of publication'
// a_bos -> means 'attribute books'
// m_abo -> means 'method addBook'
// m_fby -> means 'method filterByYearOfPublication'
public class Book {
    public string Isbn {get; set;}
    public string Title {get; set;}
    public int Edition {get; set;}
    public int YearOfPublication {get; set;}
}

public class Author {
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public int Age {get; set;}
    public List<Book> books = new List<Book>();

    // adds a book if not present
    public void AddBook(Book book) {
        var existingBook = Find(book);
        if (existingBook == null) {
            books.Add(book);
        }
    }

    private Book? Find(Book book) {
        foreach (var current in books) {
            if (Object.Equals(book, current)) {
                return current;
            }
        }
        return null;
    }

    // finds all books in a given year for this author
    public List<Book> FilterByYearOfPublication(int year) {
        var filtered = new List<Book>();
        foreach (var current in books) {
            if (current.YearOfPublication == year) {
                filtered.Add(current);
            }
        }
        return filtered;
    }
}