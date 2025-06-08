namespace Manufacture.Interfaces;

public interface IPassenger
{
    public int Id { get; set; }            
    public string Name { get; set; }       
    public bool HasLuggage { get; set; }
}