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
		#region Checks for Empty

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

		#endregion

		#region Conversions

		public static int ToInt32( this string? value, int defaultValue = 0 )
		{
			return Int32.TryParse( value, out int result ) ? result : defaultValue;
		}

		public static int? ToNullableInt32( this string? value, int? defaultValue = null )
		{
			return Int32.TryParse( value, out int result ) ? result : defaultValue;
		}

		public static long ToInt64( this string? value, long defaultValue = 0 )
		{
			return Int64.TryParse( value, out long result ) ? result : defaultValue;
		}

		public static long? ToNullableInt64( this string? value, long? defaultValue = null )
		{
			return Int64.TryParse( value, out long result ) ? result : defaultValue;
		}

		public static double ToDouble( this string? value, double defaultValue = 0 )
		{
			return Double.TryParse( value, out double result ) ? result : defaultValue;
		}

		public static double? ToNullableDouble( this string? value, double? defaultValue = null )
		{
			return Double.TryParse( value, out double result ) ? result : defaultValue;
		}

		public static byte ToByte(this string? value, byte defaultValue = 0)
		{
			return Byte.TryParse( value, out byte result ) ? result : defaultValue;
		}

		public static byte? ToNullableByte( this string? value, byte? defaultValue = null )
		{
			return Byte.TryParse( value, out byte result ) ? result : defaultValue;
		}

		public static Guid ToGuid( this string? value, Guid defaultValue )
		{
			return Guid.TryParse( value, out Guid result ) ? result : defaultValue;
		}

		public static Guid? ToNullableGuid( this string? value )
		{
			return Guid.TryParse( value, out Guid result ) ? result : null;
		}
		public static float ToSingle( this string? value, float defaultValue = 0 )
		{
			return Single.TryParse( value, out float result ) ? result : defaultValue;
		}

		public static float? ToNullableSingle( this string? value, float? defaultValue = null )
		{
			return Single.TryParse( value, out float result ) ? result : defaultValue;
		}

		public static decimal ToDecimal( this string? value, decimal defaultValue = 0 )
		{
			return Decimal.TryParse( value, out decimal result ) ? result : defaultValue;
		}

		public static decimal? ToNullableDecimal( this string? value, decimal? defaultValue = null )
		{
			return Decimal.TryParse( value, out decimal result ) ? result : defaultValue;
		}

		public static short ToInt16( this string? value, short defaultValue = 0 )
		{
			return Int16.TryParse( value, out short result ) ? result : defaultValue;
		}

		public static short? ToNullableInt16( this string? value, short? defaultValue = null )
		{
			return Int16.TryParse( value, out short result ) ? result : defaultValue;
		}

		public static ushort ToUInt16( this string? value, ushort defaultValue = 0 )
		{
			return UInt16.TryParse( value, out ushort result ) ? result : defaultValue;
		}

		public static ushort? ToNullableUInt16( this string? value, ushort? defaultValue = null )
		{
			return UInt16.TryParse( value, out ushort result ) ? result : defaultValue;
		}

		public static uint ToUInt32( this string? value, uint defaultValue = 0 )
		{
			return UInt32.TryParse( value, out uint result ) ? result : defaultValue;
		}

		public static uint? ToNullableUInt32( this string? value, uint? defaultValue = null )
		{
			return UInt32.TryParse( value, out uint result ) ? result : defaultValue;
		}

		public static ulong ToUInt64( this string? value, ulong defaultValue = 0 )
		{
			return UInt64.TryParse( value, out ulong result ) ? result : defaultValue;
		}

		public static ulong? ToNullableUInt64( this string? value, ulong? defaultValue = null )
		{
			return UInt64.TryParse( value, out ulong result ) ? result : defaultValue;
		}

		public static sbyte ToSByte( this string? value, sbyte defaultValue = 0 )
		{
			return SByte.TryParse( value, out sbyte result ) ? result : defaultValue;
		}

		public static sbyte? ToNullableSByte( this string? value, sbyte? defaultValue = null )
		{
			return SByte.TryParse( value, out sbyte result ) ? result : defaultValue;
		}
		#endregion

	}
}