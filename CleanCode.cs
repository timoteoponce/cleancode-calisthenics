/*
== Clean code calisthenics
1. Don't use single letters as variable names
2. Name variables and methods names in a meaningful way
3. At most 2 levels of indentation per method
4. One dot per line
5. Keep all methods short, maximum of 7 lines
*/
// This is a representation of a car piece or part
public class CarPart {
    public string id { get; set; }
    public string description { get; set; }
    public string cost { get; set; }

    public void increaseCost(int additionaCost) {
        cost = cost + additionaCost;
    }
}

// This is a representation of a car
public class Car {
    public string model { get; set; }
    public string brand { get; set; }
    public List<CarPart> parts = new List<CarPart>();

    // add a part if it's not present
    public void addPart(CarPart part) {
        var existingPart = FindPart(part);
        if (existingPart == null) {
            parts.Add(part);
        }
    }

    private CarPart? FindPart(CarPart part) {
        foreach (var current in parts){
            if (Object.Equals(current, part)) {
                return current;
            }
        }
        return null;
    }
}