#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Androidx.Media3.Datasource
{
    partial interface IHttpDataSource {
        partial class BaseFactory : IHttpDataSource.IFactory {            
            unsafe global::Androidx.Media3.Datasource.IDataSource? global::Androidx.Media3.Datasource.IDataSource.IFactory.CreateDataSource()
                => CreateDataSource();
        }
    }
    partial class PriorityDataSource
    {
        partial class Factory
        {
            unsafe global::Androidx.Media3.Datasource.IDataSource? global::Androidx.Media3.Datasource.IDataSource.IFactory.CreateDataSource()
                => CreateDataSource();
        }
    }
    partial class DefaultHttpDataSource
    {
        partial class Factory
        {
            unsafe global::Androidx.Media3.Datasource.IDataSource? global::Androidx.Media3.Datasource.IDataSource.IFactory.CreateDataSource()
                => CreateDataSource();
            unsafe global::Androidx.Media3.Datasource.IHttpDataSource.IFactory? global::Androidx.Media3.Datasource.IHttpDataSource.IFactory.SetDefaultRequestProperties(IDictionary<string, string>? p0)
                => SetDefaultRequestProperties(p0);
        }
    }
    partial class HttpEngineDataSource
    {
        partial class Factory
        {
            unsafe global::Androidx.Media3.Datasource.IDataSource? global::Androidx.Media3.Datasource.IDataSource.IFactory.CreateDataSource()
                => CreateDataSource();
            unsafe global::Androidx.Media3.Datasource.IHttpDataSource.IFactory? global::Androidx.Media3.Datasource.IHttpDataSource.IFactory.SetDefaultRequestProperties(IDictionary<string, string>? p0)
                => SetDefaultRequestProperties(p0);
        }
    }
    partial class DefaultDataSource
    {
        partial class Factory
        {
            unsafe global::Androidx.Media3.Datasource.IDataSource? global::Androidx.Media3.Datasource.IDataSource.IFactory.CreateDataSource()
                => CreateDataSource();
        }
    }
    partial class ResolvingDataSource
    {
        partial class Factory
        {
            unsafe global::Androidx.Media3.Datasource.IDataSource? global::Androidx.Media3.Datasource.IDataSource.IFactory.CreateDataSource()
                => CreateDataSource();
        }
    }
    partial class FileDataSource
    {
        partial class Factory
        {
            unsafe global::Androidx.Media3.Datasource.IDataSource? global::Androidx.Media3.Datasource.IDataSource.IFactory.CreateDataSource()
                => CreateDataSource();
        }
    }
    partial class DefaultDataSourceFactory
    {
        unsafe global::Androidx.Media3.Datasource.IDataSource? global::Androidx.Media3.Datasource.IDataSource.IFactory.CreateDataSource()
            => CreateDataSource();
    }
    partial class PriorityDataSourceFactory
    {
        unsafe global::Androidx.Media3.Datasource.IDataSource? global::Androidx.Media3.Datasource.IDataSource.IFactory.CreateDataSource()
            => CreateDataSource();
    }
}
namespace Androidx.Media3.Datasource.Cache {
    partial class CacheSpan {
        int global::Java.Lang.IComparable.CompareTo(global::Java.Lang.Object o)
        {
            return o is global::Androidx.Media3.Datasource.Cache.CacheSpan s ? CompareTo(s) : -1;
        }
    }
    partial class CacheDataSource
    {
        partial class Factory
        {
            unsafe global::Androidx.Media3.Datasource.IDataSource? global::Androidx.Media3.Datasource.IDataSource.IFactory.CreateDataSource()
                => CreateDataSource();
        }
    }
}