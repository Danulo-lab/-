class Wire
{
    private string marka;        
    private double area;         
    public double Resistivity;   
    public string Material;      
  
    public void SetMarka(string m) => marka = m;
    public string GetMarka() => marka;

    public void SetArea(double a)
    {
        if (a > 0) area = a;
    }
    public double GetArea() => area;

    
    public override string ToString()
    {
        return $"Марка: {marka}, Площа: {area} мм², Опір: {Resistivity}, Матеріал: {Material}";
    }
}
