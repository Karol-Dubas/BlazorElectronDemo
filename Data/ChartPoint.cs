namespace BlazorElectronDemo.Data;

public class ChartPoint
{
    public ChartPoint(int id, double value)
    {
        Id = id;
        Value = value;
    }
        
    public int Id { get; set; }
    public double Value { get; set; }
}