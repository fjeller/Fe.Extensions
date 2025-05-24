using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fe.Extensions
{
	/// ---------------------------------------------------------------------------------------------------------------------------
	/// <summary>
	/// Provides extension methods for working with <see cref="IEnumerable{T}"/> sequences.
	/// </summary>
	/// <remarks>
	/// This static class contains utility methods that extend the functionality of enumerable sequences,
	/// such as filtering out null elements from a sequence of reference types.
	/// </remarks>
	/// ---------------------------------------------------------------------------------------------------------------------------
	public static class EnumerableExtensions
	{
		/// ---------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Filters a sequence of reference type elements, returning only the non-null elements.
		/// </summary>
		/// <typeparam name="T">The reference type of the elements in the source sequence.</typeparam>
		/// <param name="source">The sequence to filter.</param>
		/// <returns>An <see cref="IEnumerable{T}"/> that contains only the non-null elements from the input sequence.</returns>
		/// <exception cref="ArgumentNullException">Thrown if <paramref name="source"/> is null.</exception>
		/// ---------------------------------------------------------------------------------------------------------------------------
		public static IEnumerable<T> WhereNotNull<T>( this IEnumerable<T?> source ) where T : class
		{
			var result = source is null
				? throw new ArgumentNullException( nameof( source ) )
				: source.Where( item => item is not null ).Select( item => item! );

			return result;
		}
	}
}

