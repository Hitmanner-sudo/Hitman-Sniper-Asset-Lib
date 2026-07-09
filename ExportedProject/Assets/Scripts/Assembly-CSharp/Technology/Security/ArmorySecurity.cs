using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C25")]
	internal static class ArmorySecurity
	{
		[Token(Token = "0x2000C26")]
		private class FilterTypeEqualityComparer : IEqualityComparer<FilterType>
		{
			[Token(Token = "0x6004CBD")]
			[Address(RVA = "0x9233E4", Offset = "0x9233E4", VA = "0x9233E4", Slot = "4")]
			public bool Equals(FilterType x, FilterType y)
			{
				return default(bool);
			}

			[Token(Token = "0x6004CBE")]
			[Address(RVA = "0x9233F0", Offset = "0x9233F0", VA = "0x9233F0", Slot = "5")]
			public int GetHashCode(FilterType obj)
			{
				return default(int);
			}

			[Token(Token = "0x6004CBF")]
			[Address(RVA = "0x9233F8", Offset = "0x9233F8", VA = "0x9233F8")]
			public FilterTypeEqualityComparer()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000C27")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5985C4", Offset = "0x5985C4")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4003C79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4003C7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<InstallValidationEventArgs> _003C_003E9__17_0;

			[Token(Token = "0x6004CC1")]
			[Address(RVA = "0x92323C", Offset = "0x92323C", VA = "0x92323C")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6004CC2")]
			[Address(RVA = "0x923244", Offset = "0x923244", VA = "0x923244")]
			internal void _003CValidateInstall_003Eb__17_0(InstallValidationEventArgs e)
			{
			}
		}

		[Token(Token = "0x4003C78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<FilterType, Dictionary<Type, List<SecurityFilter>>> _filters;

		[Token(Token = "0x1400013E")]
		public static event Action<InstallValidationEventArgs> OnValidateInstall
		{
			[Token(Token = "0x6004CAD")]
			[Address(RVA = "0xD506D8", Offset = "0xD506D8", VA = "0xD506D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6286F0", Offset = "0x6286F0")]
			add
			{
			}
			[Token(Token = "0x6004CAE")]
			[Address(RVA = "0xD507CC", Offset = "0xD507CC", VA = "0xD507CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628700", Offset = "0x628700")]
			remove
			{
			}
		}

		[Token(Token = "0x1400013F")]
		public static event Action<string> OnAssemblyHashComputed
		{
			[Token(Token = "0x6004CAF")]
			[Address(RVA = "0xD508C0", Offset = "0xD508C0", VA = "0xD508C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628710", Offset = "0x628710")]
			add
			{
			}
			[Token(Token = "0x6004CB0")]
			[Address(RVA = "0xD509B8", Offset = "0xD509B8", VA = "0xD509B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628720", Offset = "0x628720")]
			remove
			{
			}
		}

		[Token(Token = "0x6004CB1")]
		[Address(RVA = "0xD50AB0", Offset = "0xD50AB0", VA = "0xD50AB0")]
		internal static void Register(SecurityFilter filter, FilterType filterType, Type inputType)
		{
		}

		[Token(Token = "0x6004CB2")]
		[Address(RVA = "0xD50D90", Offset = "0xD50D90", VA = "0xD50D90")]
		internal static void ResetFilter()
		{
		}

		[Token(Token = "0x6004CB3")]
		[Address(RVA = "0xD50E14", Offset = "0xD50E14", VA = "0xD50E14")]
		internal static object ApplyFilter(FilterType type, object input)
		{
			return null;
		}

		[Token(Token = "0x6004CB4")]
		internal static T2 ApplyFilter<T1, T2>(FilterType type, T1 input, [Optional] T2 defaultOutput)
		{
			return (T2)null;
		}

		[Token(Token = "0x6004CB5")]
		[Address(RVA = "0xD50EA8", Offset = "0xD50EA8", VA = "0xD50EA8")]
		private static object ApplyFilter(FilterType type, Type inputType, object input, [Optional] object defaultOutput)
		{
			return null;
		}

		[Token(Token = "0x6004CB6")]
		[Address(RVA = "0xD51168", Offset = "0xD51168", VA = "0xD51168")]
		internal static object RevertFilter(FilterType type, object output)
		{
			return null;
		}

		[Token(Token = "0x6004CB7")]
		internal static T RevertFilter<T>(FilterType type, T output)
		{
			return (T)null;
		}

		[Token(Token = "0x6004CB8")]
		internal static T2 RevertFilter<T1, T2>(FilterType type, T1 output, [Optional] T2 defaultResponse)
		{
			return (T2)null;
		}

		[Token(Token = "0x6004CB9")]
		[Address(RVA = "0xD511FC", Offset = "0xD511FC", VA = "0xD511FC")]
		private static object RevertFilter(FilterType type, Type inputType, object output, [Optional] object defaultResponse)
		{
			return null;
		}

		[Token(Token = "0x6004CBA")]
		[Address(RVA = "0xD51510", Offset = "0xD51510", VA = "0xD51510")]
		public static void ValidateInstall()
		{
		}

		[Token(Token = "0x6004CBB")]
		[Address(RVA = "0xD51784", Offset = "0xD51784", VA = "0xD51784")]
		public static void ComputeAssemblyHash()
		{
		}
	}
}
