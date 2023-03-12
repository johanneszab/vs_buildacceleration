namespace ClassLibrary2
{
    /// <summary>
    /// Test class with net framework specific code. System.Linq.Enumerable.DistinctBy is already available in .net6.0,
    /// but not in .net framework.
    /// </summary>
    public static class EnumerableExtensions
    {
#if NETFRAMEWORK
        /// <summary>
        /// Gets all items from the source sequence with a distinct key value.
        /// </summary>
        /// <typeparam name="T">The type of source items.</typeparam>
        /// <typeparam name="TKey">The type of the key value.</typeparam>
        /// <param name="source">The source sequence.</param>
        /// <param name="selectKey">The key selector.</param>
        /// <returns>
        /// The distinct values.
        /// </returns>
        public static IEnumerable<T> DistinctBy<T, TKey>(this IEnumerable<T> source, Func<T, TKey> selectKey)
        {
            var hashSet = new HashSet<TKey>();
            return source.Where(item => hashSet.Add(selectKey(item)));
        }
#endif
    }
}
