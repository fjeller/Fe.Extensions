using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fe.Extensions
{
	/// ---------------------------------------------------------------------------------------------------------------------------
	/// <summary>
	/// Provides extension methods for <see cref="string"/> to simplify common string checks.
	/// </summary>
	/// ---------------------------------------------------------------------------------------------------------------------------
	public static class StringExtensions
	{
		/// ---------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Determines whether the specified string is not <c>null</c>, empty, or consists only of white-space characters.
		/// </summary>
		/// <param name="item">The string to check.</param>
		/// <returns>
		/// <c>true</c> if the string has a value (is not <c>null</c>, empty, or whitespace); otherwise, <c>false</c>.
		/// </returns>
		/// ---------------------------------------------------------------------------------------------------------------------------
		public static bool HasValue( [NotNullWhen( true )] this string? item )
		{
			return !String.IsNullOrWhiteSpace( item );
		}

		/// ---------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Determines whether the specified string is <c>null</c>, empty, or consists only of white-space characters.
		/// </summary>
		/// <param name="item">The string to check.</param>
		/// <returns>
		/// <c>true</c> if the string is <c>null</c>, empty, or whitespace; otherwise, <c>false</c>.
		/// </returns>
		/// ---------------------------------------------------------------------------------------------------------------------------
		public static bool IsEmpty( [NotNullWhen( false )] this string? item ) => !item.HasValue();

	}
}