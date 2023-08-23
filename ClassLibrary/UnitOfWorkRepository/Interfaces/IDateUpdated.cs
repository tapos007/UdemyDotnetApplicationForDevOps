namespace Infrastructure.UnitOfWorkRepository.Interfaces;

public interface IDateUpdated
{
    DateTime LastUpdateDate { get; set; }
}