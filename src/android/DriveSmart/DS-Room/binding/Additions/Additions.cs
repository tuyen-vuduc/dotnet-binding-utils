
#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;


namespace Com.Example.Dsroom.Repository
{
    partial class DeviceRepository
    {
        protected override Com.Example.Dsroom.Dao.IBaseDao BaseDao => Dao;
    }
    partial class UserRepository
    {
        protected override Com.Example.Dsroom.Dao.IBaseDao BaseDao => Dao;
    }
}
namespace Com.Example.Dsroom.Dao
{
    partial class AccessDao_Impl
    {
        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Delete(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Delete(obj as Entity.AccessModel, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(global::System.Collections.IList litObj, Kotlin.Coroutines.IContinuation p1)
            => Insert(litObj?.Cast<Entity.AccessModel>().ToList(), p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Insert(obj as Entity.AccessModel, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(Java.Lang.Object[] obj, Kotlin.Coroutines.IContinuation p1)
            => Insert(obj?.Cast<Entity.AccessModel>().ToArray(), p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.RowQuery(AndroidX.Sqlite.Db.ISupportSQLiteQuery query, Kotlin.Coroutines.IContinuation p1)
            => RowQuery(query, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Update(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Update(obj as Entity.AccessModel, p1);
    }
    partial class AchievementDao_Impl
    {
        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Delete(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Delete(obj as Entity.AchievementModel, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(global::System.Collections.IList litObj, Kotlin.Coroutines.IContinuation p1)
            => Insert(litObj?.Cast<Entity.AchievementModel>().ToList(), p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Insert(obj as Entity.AchievementModel, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(Java.Lang.Object[] obj, Kotlin.Coroutines.IContinuation p1)
            => Insert(obj?.Cast<Entity.AchievementModel>().ToArray(), p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.RowQuery(AndroidX.Sqlite.Db.ISupportSQLiteQuery query, Kotlin.Coroutines.IContinuation p1)
            => RowQuery(query, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Update(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Update(obj as Entity.AchievementModel, p1);
    }
    partial class BiscuitActivityDao_Impl
    {
        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Delete(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Delete(obj as Entity.BiscuitActivityModel, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(global::System.Collections.IList litObj, Kotlin.Coroutines.IContinuation p1)
            => Insert(litObj?.Cast<Entity.BiscuitActivityModel>().ToList(), p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Insert(obj as Entity.BiscuitActivityModel, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(Java.Lang.Object[] obj, Kotlin.Coroutines.IContinuation p1)
            => Insert(obj?.Cast<Entity.BiscuitActivityModel>().ToArray(), p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.RowQuery(AndroidX.Sqlite.Db.ISupportSQLiteQuery query, Kotlin.Coroutines.IContinuation p1)
            => RowQuery(query, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Update(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Update(obj as Entity.BiscuitActivityModel, p1);
    }
    partial class BiscuitScoreDao_Impl
    {
        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Delete(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Delete(obj as Entity.BiscuitScoreModel, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(global::System.Collections.IList litObj, Kotlin.Coroutines.IContinuation p1)
            => Insert(litObj?.Cast<Entity.BiscuitScoreModel>().ToList(), p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Insert(obj as Entity.BiscuitScoreModel, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(Java.Lang.Object[] obj, Kotlin.Coroutines.IContinuation p1)
            => Insert(obj?.Cast<Entity.BiscuitScoreModel>().ToArray(), p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.RowQuery(AndroidX.Sqlite.Db.ISupportSQLiteQuery query, Kotlin.Coroutines.IContinuation p1)
            => RowQuery(query, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Update(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Update(obj as Entity.BiscuitScoreModel, p1);
    }
    partial class DeviceDao_Impl
    {
        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Delete(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Delete(obj as Entity.DeviceModel, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(global::System.Collections.IList litObj, Kotlin.Coroutines.IContinuation p1)
            => Insert(litObj?.Cast<Entity.DeviceModel>().ToList(), p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Insert(obj as Entity.DeviceModel, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(Java.Lang.Object[] obj, Kotlin.Coroutines.IContinuation p1)
            => Insert(obj?.Cast<Entity.DeviceModel>().ToArray(), p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.RowQuery(AndroidX.Sqlite.Db.ISupportSQLiteQuery query, Kotlin.Coroutines.IContinuation p1)
            => RowQuery(query, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Update(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Update(obj as Entity.DeviceModel, p1);
    }
    partial class HomeInsightDao_Impl
    {
        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Delete(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Delete(obj as Entity.HomeInsightModel, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(global::System.Collections.IList litObj, Kotlin.Coroutines.IContinuation p1)
            => Insert(litObj?.Cast<Entity.HomeInsightModel>().ToList(), p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Insert(obj as Entity.HomeInsightModel, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(Java.Lang.Object[] obj, Kotlin.Coroutines.IContinuation p1)
            => Insert(obj?.Cast<Entity.HomeInsightModel>().ToArray(), p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.RowQuery(AndroidX.Sqlite.Db.ISupportSQLiteQuery query, Kotlin.Coroutines.IContinuation p1)
            => RowQuery(query, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Update(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Update(obj as Entity.HomeInsightModel, p1);
    }
    partial class SettingDao_Impl
    {
        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Delete(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Delete(obj as Entity.SettingsModel, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(global::System.Collections.IList litObj, Kotlin.Coroutines.IContinuation p1)
            => Insert(litObj?.Cast<Entity.SettingsModel>().ToList(), p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Insert(obj as Entity.SettingsModel, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(Java.Lang.Object[] obj, Kotlin.Coroutines.IContinuation p1)
            => Insert(obj?.Cast<Entity.SettingsModel>().ToArray(), p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.RowQuery(AndroidX.Sqlite.Db.ISupportSQLiteQuery query, Kotlin.Coroutines.IContinuation p1)
            => RowQuery(query, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Update(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Update(obj as Entity.SettingsModel, p1);
    }
    partial class SmartCoinDao_Impl
    {
        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Delete(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Delete(obj as Entity.SmartCoinModel, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(global::System.Collections.IList litObj, Kotlin.Coroutines.IContinuation p1)
            => Insert(litObj?.Cast<Entity.SmartCoinModel>().ToList(), p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Insert(obj as Entity.SmartCoinModel, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(Java.Lang.Object[] obj, Kotlin.Coroutines.IContinuation p1)
            => Insert(obj?.Cast<Entity.SmartCoinModel>().ToArray(), p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.RowQuery(AndroidX.Sqlite.Db.ISupportSQLiteQuery query, Kotlin.Coroutines.IContinuation p1)
            => RowQuery(query, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Update(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Update(obj as Entity.SmartCoinModel, p1);
    }
    partial class SmartMileDao_Impl
    {
        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Delete(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Delete(obj as Entity.SmartMileModel, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(global::System.Collections.IList litObj, Kotlin.Coroutines.IContinuation p1)
            => Insert(litObj?.Cast<Entity.SmartMileModel>().ToList(), p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Insert(obj as Entity.SmartMileModel, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(Java.Lang.Object[] obj, Kotlin.Coroutines.IContinuation p1)
            => Insert(obj?.Cast<Entity.SmartMileModel>().ToArray(), p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.RowQuery(AndroidX.Sqlite.Db.ISupportSQLiteQuery query, Kotlin.Coroutines.IContinuation p1)
            => RowQuery(query, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Update(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Update(obj as Entity.SmartMileModel, p1);
    }
    partial class UserDao_Impl
    {
        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Delete(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Delete(obj as Entity.UserModel, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(global::System.Collections.IList litObj, Kotlin.Coroutines.IContinuation p1)
            => Insert(litObj?.Cast<Entity.UserModel>().ToList(), p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Insert(obj as Entity.UserModel, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(Java.Lang.Object[] obj, Kotlin.Coroutines.IContinuation p1)
            => Insert(obj?.Cast<Entity.UserModel>().ToArray(), p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.RowQuery(AndroidX.Sqlite.Db.ISupportSQLiteQuery query, Kotlin.Coroutines.IContinuation p1)
            => RowQuery(query, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Update(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Update(obj as Entity.UserModel, p1);
    }
    partial class UserProfileDao_Impl
    {
        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Delete(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Delete(obj as Entity.ProfileModel, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(global::System.Collections.IList litObj, Kotlin.Coroutines.IContinuation p1)
            => Insert(litObj?.Cast<Entity.ProfileModel>().ToList(), p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Insert(obj as Entity.ProfileModel, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Insert(Java.Lang.Object[] obj, Kotlin.Coroutines.IContinuation p1)
            => Insert(obj?.Cast<Entity.ProfileModel>().ToArray(), p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.RowQuery(AndroidX.Sqlite.Db.ISupportSQLiteQuery query, Kotlin.Coroutines.IContinuation p1)
            => RowQuery(query, p1);

        Java.Lang.Object? Com.Example.Dsroom.Dao.IBaseDao.Update(Java.Lang.Object? obj, Kotlin.Coroutines.IContinuation p1)
            => Update(obj as Entity.ProfileModel, p1);
    }
}