using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfNotificationDal 
        : EfEntityRepositoryBase<Notification, IlacTakipContext>, INotificationDal
    {
        public EfNotificationDal(IlacTakipContext context) : base(context)
        {
        }
    }
}
