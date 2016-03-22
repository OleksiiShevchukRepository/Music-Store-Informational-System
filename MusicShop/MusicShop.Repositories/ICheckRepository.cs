namespace MusicShop.Repositories
{
    /// <summary>
    /// Operations with check
    /// </summary>
    public interface ICheckRepository
    {
        void CreateCheck(int sellerId, decimal totalSum);

        void AddItemToCheck(int albumId, int amount, decimal price);

        Check GetCheckInfo();

    }
}
