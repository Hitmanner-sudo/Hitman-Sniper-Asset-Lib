using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology
{
	[Token(Token = "0x2000A6B")]
	public static class ArrayExtensions
	{
		[Token(Token = "0x2000A6C")]
		public class ComparisonComparer<T> : IComparer<T>
		{
			[Token(Token = "0x4003660")]
			[FieldOffset(Offset = "0x0")]
			private readonly Comparison<T> comparison;

			[Token(Token = "0x60041DD")]
			public ComparisonComparer(Func<T, T, int> compare)
			{
			}

			[Token(Token = "0x60041DE")]
			public int Compare(T x, T y)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000A6D")]
		public class StringNumericComparer : IComparer<string>
		{
			[Token(Token = "0x4003661")]
			private const string _numberExpr = "[\\d]+";

			[Token(Token = "0x4003662")]
			private const string _wordExpr = "[^\\d\\n]+";

			[Token(Token = "0x60041DF")]
			[Address(RVA = "0x923898", Offset = "0x923898", VA = "0x923898", Slot = "4")]
			public int Compare(string x, string y)
			{
				return default(int);
			}

			[Token(Token = "0x60041E0")]
			[Address(RVA = "0x923ABC", Offset = "0x923ABC", VA = "0x923ABC")]
			private int CompareNumeric(string x, string y)
			{
				return default(int);
			}

			[Token(Token = "0x60041E1")]
			[Address(RVA = "0x923B38", Offset = "0x923B38", VA = "0x923B38")]
			public StringNumericComparer()
			{
			}
		}

		[Token(Token = "0x2000A6E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597A44", Offset = "0x597A44")]
		private sealed class _003C_003Ec__DisplayClass3_0<T> where T : class
		{
			[Token(Token = "0x4003663")]
			[FieldOffset(Offset = "0x0")]
			public Func<T, int> compare;

			[Token(Token = "0x60041E2")]
			public _003C_003Ec__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60041E3")]
			internal int _003CBinarySearch_003Eb__0(T a, T b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000A6F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597A54", Offset = "0x597A54")]
		private sealed class _003C_003Ec__DisplayClass6_0<T> where T : class
		{
			[Token(Token = "0x4003664")]
			[FieldOffset(Offset = "0x0")]
			public Func<T, int> compare;

			[Token(Token = "0x60041E4")]
			public _003C_003Ec__DisplayClass6_0()
			{
			}

			[Token(Token = "0x60041E5")]
			internal int _003CBinarySearch_003Eb__0(T a, T b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x60041C8")]
		public static int BinarySearch<T>(this List<T> list, T item, Func<T, T, int> compare)
		{
			return default(int);
		}

		[Token(Token = "0x60041C9")]
		public static int BinarySearch<T>(this List<T> list, Func<T, int> compare) where T : class
		{
			return default(int);
		}

		[Token(Token = "0x60041CA")]
		public static int BinarySearch<T>(this T[] list, T item, Func<T, T, int> compare)
		{
			return default(int);
		}

		[Token(Token = "0x60041CB")]
		public static int BinarySearch<T>(this T[] list, T item, IComparer<T> comparer)
		{
			return default(int);
		}

		[Token(Token = "0x60041CC")]
		public static int BinarySearch<T>(this T[] list, Func<T, int> compare) where T : class
		{
			return default(int);
		}

		[Token(Token = "0x60041CD")]
		public static T FindMax<T>(this IEnumerable<T> source, Func<T, int> selector)
		{
			return (T)null;
		}

		[Token(Token = "0x60041CE")]
		public static T FindBest<T>(this IEnumerable<T> source, Func<T, T, bool> isFirstBetterThanSecond)
		{
			return (T)null;
		}

		[Token(Token = "0x60041CF")]
		public static T FindBest<T>(this IEnumerable<T> source, Func<T, T, bool> isFirstBetterThanSecond, out int index)
		{
			return (T)null;
		}

		[Token(Token = "0x60041D0")]
		public static int InsertSorted<T>(this List<T> list, T item, IComparer<T> comparer)
		{
			return default(int);
		}

		[Token(Token = "0x60041D1")]
		public static bool AddUnique<T>(this List<T> list, T item)
		{
			return default(bool);
		}

		[Token(Token = "0x60041D2")]
		public static bool Contains<T>(this T[] array, T item)
		{
			return default(bool);
		}

		[Token(Token = "0x60041D3")]
		public static int InsertSorted<T>(this List<T> list, T item, Func<T, T, int> compare)
		{
			return default(int);
		}

		[Token(Token = "0x60041D4")]
		public static T RandomElement<T>(this List<T> list)
		{
			return (T)null;
		}

		[Token(Token = "0x60041D5")]
		public static T RandomElement<T>(this List<T> list, Random r)
		{
			return (T)null;
		}

		[Token(Token = "0x60041D6")]
		public static T RandomElement<T>(this T[] array)
		{
			return (T)null;
		}

		[Token(Token = "0x60041D7")]
		public static void RemoveAtSwap<T>(this List<T> list, int index)
		{
		}

		[Token(Token = "0x60041D8")]
		public static int FirstIndexSuchThat<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return default(int);
		}

		[Token(Token = "0x60041D9")]
		public static int LastIndexSuchThat<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return default(int);
		}

		[Token(Token = "0x60041DA")]
		public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
		{
			return null;
		}

		[Token(Token = "0x60041DB")]
		public static void Shuffle<T>(this IList<T> list)
		{
		}

		[Token(Token = "0x60041DC")]
		public static void Shuffle<T>(this T[] array)
		{
		}
	}
}
