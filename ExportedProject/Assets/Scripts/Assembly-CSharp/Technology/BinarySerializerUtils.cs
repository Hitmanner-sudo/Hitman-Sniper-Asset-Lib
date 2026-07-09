using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Token(Token = "0x2000A9B")]
	public static class BinarySerializerUtils
	{
		[Serializable]
		[Token(Token = "0x2000A9C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597B70", Offset = "0x597B70")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40036C0")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40036C1")]
			[FieldOffset(Offset = "0x8")]
			public static Func<FieldInfo, bool> _003C_003E9__5_0;

			[Token(Token = "0x40036C2")]
			[FieldOffset(Offset = "0x10")]
			public static Func<FieldInfo, bool> _003C_003E9__6_0;

			[Token(Token = "0x60042AC")]
			[Address(RVA = "0x92613C", Offset = "0x92613C", VA = "0x92613C")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60042AD")]
			[Address(RVA = "0x926144", Offset = "0x926144", VA = "0x926144")]
			internal bool _003CHasSaveableFields_003Eb__5_0(FieldInfo f)
			{
				return default(bool);
			}

			[Token(Token = "0x60042AE")]
			[Address(RVA = "0x926150", Offset = "0x926150", VA = "0x926150")]
			internal bool _003CGetSaveableFields_003Eb__6_0(FieldInfo fi)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60042A4")]
		[Address(RVA = "0xC6561C", Offset = "0xC6561C", VA = "0xC6561C")]
		public static bool IsSimpleType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60042A5")]
		[Address(RVA = "0xC656C8", Offset = "0xC656C8", VA = "0xC656C8")]
		public static bool CanSerializeField(FieldInfo info)
		{
			return default(bool);
		}

		[Token(Token = "0x60042A6")]
		[Address(RVA = "0xC65888", Offset = "0xC65888", VA = "0xC65888")]
		public static bool IsDeprecated(FieldInfo info)
		{
			return default(bool);
		}

		[Token(Token = "0x60042A7")]
		[Address(RVA = "0xC65800", Offset = "0xC65800", VA = "0xC65800")]
		public static bool IsSaveable(this FieldInfo info)
		{
			return default(bool);
		}

		[Token(Token = "0x60042A8")]
		[Address(RVA = "0xC65910", Offset = "0xC65910", VA = "0xC65910")]
		public static bool HasAttribute(this FieldInfo info, Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60042A9")]
		[Address(RVA = "0xC65998", Offset = "0xC65998", VA = "0xC65998")]
		public static bool HasSaveableFields(MonoBehaviour cp)
		{
			return default(bool);
		}

		[Token(Token = "0x60042AA")]
		[Address(RVA = "0xC65AF4", Offset = "0xC65AF4", VA = "0xC65AF4")]
		public static FieldInfo[] GetSaveableFields(Type type, bool includeDeprecated)
		{
			return null;
		}
	}
}
