namespace ExercisesBookShopService2017.Common.Extension
{
    using System.Collections.Generic;

    public static class EnumerableExtensions
    {
        public static HashSet<T> ToHashSet<T>(this IEnumerable<T> enumerable)
            => new HashSet<T>(enumerable);
    }
}
