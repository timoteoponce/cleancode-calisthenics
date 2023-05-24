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