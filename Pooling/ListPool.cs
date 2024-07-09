﻿using System.Collections.Generic;

namespace RustRcon.Pooling
{
    /// <summary>
    /// Represents a pool for <see cref="List{T}"/>
    /// </summary>
    /// <typeparam name="T">Type that will be in the list</typeparam>
    public class ListPool<T> : BasePool<List<T>>
    {
        public static readonly IPool<List<T>> Instance;
        
        static ListPool()
        {
            Instance = new ListPool<T>();
        }

        private ListPool() : base(128) { }

        protected override List<T> CreateNew() => new List<T>();

        ///<inheritdoc/>
        protected override bool OnFreeItem(ref List<T> item)
        {
            item.Clear();
            return true;
        }
    }
}