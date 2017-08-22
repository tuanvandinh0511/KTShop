namespace KTShop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}