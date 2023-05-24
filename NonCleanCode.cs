// This is a representation of a car piece or part
public class O_P {
    public string m_id { get; set; }
    public string m_dsc { get; set; }
    public string m_cst { get; set; }

    public void f32(int v) {
        this.m_cst = this.m_cst + v;
    }
}

// This is a representation of a car
public class O_C {
    public string m_mdl { get; set; }
    public string m_brd { get; set; }
    public List<O_P> m_prt = new List<O_P>();

    // add a part if it's not present
    public void f33(O_P p) {
        var p2 = this.m_prt.Find( t => t.m_id == p.m_id);
        if (p2 == null) {
            this.m_prt.Add(p2);
        }
    }
}