namespace LINQPractice
{
    public static class MyExtentions
    {
        /// <summary>
        /// Finds penultimate element in collection 
        /// </summary>
        /// <typeparam name="T">Genetic type of collection</typeparam>
        /// <param name="source">Collection to find here penultimate element</param>
        /// <returns>Penultimate element from collection</returns>
        /// <exception cref="ArgumentException">Throwns when collection hasn't 
        /// enough elements to return penultimate element</exception>
        public static T GetPenultimateElement<T>(this IEnumerable<T> source)
        {
            if(source.Count() <= 1)
                throw new ArgumentException("The collection has 1 or less elements.");

            return source.ElementAt(source.Count() - 2);
        }
    }
}
