
using Com.Example.Dsroom.Dao;

namespace Com.Example.Dsroom.Repository
{
    partial class DeviceRepository
    {
        protected override IBaseDao BaseDao => Dao;
    }
    partial class UserRepository
    {
        protected override IBaseDao BaseDao => Dao;
    }
}