using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace X10D.Performant.ArrayExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="Array"/>
    /// </summary>
    public static class ArrayExtensions
    {
        /// <inheritdoc cref="Array.Clear(Array,int,int)"/>
        public static void Clear(this Array value, int index, int length) => Array.Clear(value, index, length);
        
        /// <inheritdoc cref="Array.Copy(Array,int,Array,int,int)"/>
        public static void Copy(this Array value, int valueIndex, Array value2, int value2Index, int length) =>
            Array.Copy(value, valueIndex, value2, value2Index, length);
        
        /// <inheritdoc cref="Array.Copy(Array,long,Array,long,long)"/>
        public static void Copy(this Array value, long valueIndex, Array value2, long value2Index, long length) =>
            Array.Copy(value, valueIndex, value2, value2Index, length);

        /// <inheritdoc cref="Array.Exists{T}(T[],Predicate{T})"/>
        public static bool Exists<T>(this T[] value, Predicate<T> match) => Array.Exists(value, match);

        /// <inheritdoc cref="Array.Fill{T}(T[],T,int,int)"/>
        public static void Fill<T>(this T[] value, T fillValue, int startIndex = 0, int? count = null) => 
            Array.Fill(value, fillValue, startIndex, count ?? value.Length - startIndex);
        
        /// <inheritdoc cref="Array.Find{T}(T[],Predicate{T})"/>
        public static T? Find<T>(this T[] value, Predicate<T> predicate) => Array.Find(value, predicate);

        /// <inheritdoc cref="Array.Reverse(Array,int,int)"/>
        public static void Reverse(this Array value, int startIndex = 0, int? count = null) =>
            Array.Reverse(value, startIndex, count ?? value.Length - startIndex);
        
        /// <inheritdoc cref="Array.Reverse{T}(T[],int,int)"/>
        public static void Reverse<T>(this T[] value, int startIndex = 0, int? count = null) =>
            Array.Reverse(value, startIndex, count ?? value.Length - startIndex);

        /// <inheritdoc cref="Array.Sort(Array,Array,int,int,IComparer)"/>
        public static void Sort(this Array keys, Array? items = null, int index = 0, int? length = null, IComparer? comparer = null) =>
            Array.Sort(keys, items, index, length ?? keys.Length - index, comparer);

        /// <inheritdoc cref="Array.Sort{TKey,TValue}(TKey[],TValue[],int,int,IComparer{TKey})"/>
        public static void Sort<TKey, TValue>(this TKey[] keys, TValue[]? items = null, int index = 0, int? length = null, IComparer<TKey>? comparer = null) =>
            Array.Sort(keys, items, index, length ?? keys.Length - index, comparer);

        /// <inheritdoc cref="Array.Sort{T}(T[],int,int,IComparer{T})"/>
        public static void Sort<T>(this T[] array, int index = 0, int? length = null, IComparer<T>? comparer = null) =>
            Array.Sort(array, index, length ?? array.Length - index, comparer);

        /// <inheritdoc cref="Array.Sort{T}(T[],Comparison{T})"/>
        public static void Sort<T>(this T[] array, Comparison<T> comparison) => Array.Sort(array, comparison);

        /// <inheritdoc cref="Array.BinarySearch(Array,int,int,object,IComparer)"/>
        public static int BinarySearch(this Array array, object? value, int index = 0, int? length = null, IComparer? comparer = null) =>
            Array.BinarySearch(array, index, length ?? array.Length - index, value, comparer);

        /// <inheritdoc cref="Array.BinarySearch{T}(T[],int,int,T,IComparer{T})"/>
        public static int BinarySearch<T>(this T[] array, T? value, int index = 0, int? length = null, IComparer<T?>? comparer = null) =>
            Array.BinarySearch(array, index, length ?? array.Length - index, value, comparer);

        /// <inheritdoc cref="Array.ConstrainedCopy(Array,int,Array,int,int)"/>
        public static void ConstrainedCopy(this Array value, int sourceIndex, Array destinationArray, int destinationIndex, int length) =>
            Array.ConstrainedCopy(value, sourceIndex, destinationArray, destinationIndex, length);

        /// <inheritdoc cref="Array.ConvertAll{TFrom,TTo}(TFrom[],Converter{TFrom,TTo})"/>
        public static TTo[] ConvertAll<TFrom, TTo>(this TFrom[] array, Converter<TFrom, TTo> converter) => Array.ConvertAll(array, converter);

        /// <inheritdoc cref="Array.FindAll{T}(T[],Predicate{T})"/>
        public static T[] FindAll<T>(this T[] array, Predicate<T> match) => Array.FindAll(array, match);

        /// <inheritdoc cref="Array.FindIndex{T}(T[],int,int,Predicate{T})"/>
        public static int FindIndex<T>(this T[] array, Predicate<T> match, int index = 0, int? count = null) =>
            Array.FindIndex(array, index, count ?? array.Length - index, match);

        /// <inheritdoc cref="Array.FindLast{T}(T[],Predicate{T})"/>
        public static T? FindLast<T>(this T[] array, Predicate<T> match) => Array.FindLast(array, match);

        /// <inheritdoc cref="Array.ForEach{T}(T[],Action{T})"/>
        public static void ForEach<T>(this T[] array, Action<T> action) => Array.ForEach(array, action);

        /// <inheritdoc cref="Array.IndexOf(Array,object,int,int)"/>
        public static int IndexOf(this Array array, object? value, int index = 0, int? count = null) =>
            Array.IndexOf(array, value, index, count ?? array.Length - index);

        /// <inheritdoc cref="Array.IndexOf{T}(T[],T,int,int)"/>
        public static int IndexOf<T>(this T[] array, T value, int index = 0, int? count = null) =>
            Array.IndexOf(array, value, index, count ?? array.Length - index);

        /// <inheritdoc cref="Array.AsReadOnly{T}(T[])"/>
        public static ReadOnlyCollection<T> AsReadOnly<T>(this T[] array) => Array.AsReadOnly(array);
        
        /// <inheritdoc cref="Array.FindLastIndex{T}(T[],int,int,Predicate{T})"/>
        public static int FindLastIndex<T>(this T[] array, Predicate<T> match, int index = 0, int? count = null) =>
            Array.FindLastIndex(array, index, count ?? array.Length - index, match);

        /// <inheritdoc cref="Array.TrueForAll{T}(T[],Predicate{T})"/>
        public static bool TrueForAll<T>(this T[] array, Predicate<T> match) => Array.TrueForAll(array, match);
    }
}