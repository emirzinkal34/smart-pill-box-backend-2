using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface INotificationDal : IEntityRepository<Notification>
    {
        object GetAll(Func<object, bool> value);
    }
}
