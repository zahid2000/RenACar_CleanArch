using Core.Persistence.Repositories;
using Domain.Enums;

namespace Domain.Entities;

public class Car : Entity<Guid>
{
    public Guid ModelId{ get; set; }
    public double Kilometer { get; set; }
    public short ModelYear{ get; set; }
    public string Plate { get; set; }
    public short MinFindexScore { get; set; }
    public CarState CarState { get; set; }
    public virtual Model? Model { get; set; }
    public Car()
    {
        
    }

    public Car(Guid id,Guid modelId, double kilometer, short modelYear, string plate, short minFindexScore, CarState carState)
    {
        Id = id;
        ModelId = modelId;
        Kilometer = kilometer;
        ModelYear = modelYear;
        Plate = plate;
        MinFindexScore = minFindexScore;
        CarState = carState;
    }
}