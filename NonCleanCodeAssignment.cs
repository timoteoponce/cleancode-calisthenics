/**
== Clean code calisthenics
1. Don't use single letters as variable names
2. Name variables and methods names in a meaningful way
3. At most 2 levels of indentation per method
4. One dot per line
5. Keep all methods short, maximum of 7 lines
*/
// an author has written many books, each book has an edition

// C_AUT -> means 'class Author'
// C_BOO -> means 'class Book'
// a_id  -> means 'attribute id'
// a_isb -> means 'attribute isbn' (interationalStandardBookNumber)
// a_yop -> means 'attribute year of publication'
// a_bos -> means 'attribute books'
// m_abo -> means 'method addBook'
// m_fby -> means 'method filterByYearOfPublication'

public class C_BOO {
    public string a_isb {get; set;}
    public string a_tlt {get; set;}
    public int a_edt {get; set;}
    public int a_yop {get; set;}
}

public class C_AUT {
    public string a_fnm {get; set;}
    public string a_lnm {get; set;}

    public int a_age {get; set;}

    public List<C_BOO> a_bos = new List<C_BOO>();

    // adds a book if not present
    public void m_abo(C_BOO b) {
        var ob = a_bos.Find(x => x.a_isb == b.a_isb);
        if (ob == null) {
            a_bos.Add(b);
        }
    }

    // finds all books in a given year for this author
    public List<C_BOO> m_fby(int y) {
        var x = a_bos.Where(yy => yy.a_yop == y);
        return x.ToList();
    }
}