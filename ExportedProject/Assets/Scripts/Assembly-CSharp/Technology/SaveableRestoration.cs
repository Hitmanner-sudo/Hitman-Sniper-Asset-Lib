using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using SimpleJSON;

namespace Technology
{
	[Token(Token = "0x2000A9E")]
	public static class SaveableRestoration
	{
		[Token(Token = "0x2000A9F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597B90", Offset = "0x597B90")]
		private sealed class _003C_003Ec__DisplayClass2_0<T> where T : class, ISaveable
		{
			[Token(Token = "0x40036C4")]
			[FieldOffset(Offset = "0x0")]
			public IEnumerable<string> excludedFields;

			[Token(Token = "0x40036C5")]
			[FieldOffset(Offset = "0x0")]
			public T instance;

			[Token(Token = "0x60042C1")]
			public _003C_003Ec__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60042C2")]
			internal bool _003CRestore_003Eb__0(FieldInfo f)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000AA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597BA0", Offset = "0x597BA0")]
		private sealed class _003C_003Ec__DisplayClass2_1<T> where T : class, ISaveable
		{
			[Token(Token = "0x40036C6")]
			[FieldOffset(Offset = "0x0")]
			public KeyValuePair<string, object> d;

			[Token(Token = "0x40036C7")]
			[FieldOffset(Offset = "0x0")]
			public _003C_003Ec__DisplayClass2_0<T> CS_0024_003C_003E8__locals1;

			[Token(Token = "0x60042C3")]
			public _003C_003Ec__DisplayClass2_1()
			{
			}

			[Token(Token = "0x60042C4")]
			internal bool _003CRestore_003Eb__2(FieldInfo fi)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000AA1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597BB0", Offset = "0x597BB0")]
		private sealed class _003C_003Ec__DisplayClass2_2<T> where T : class, ISaveable
		{
			[Token(Token = "0x40036C8")]
			[FieldOffset(Offset = "0x0")]
			public FieldInfo f;

			[Token(Token = "0x40036C9")]
			[FieldOffset(Offset = "0x0")]
			public _003C_003Ec__DisplayClass2_1<T> CS_0024_003C_003E8__locals2;

			[Token(Token = "0x60042C5")]
			public _003C_003Ec__DisplayClass2_2()
			{
			}

			[Token(Token = "0x60042C6")]
			internal void _003CRestore_003Eb__3(IList lst)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000AA2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597BC0", Offset = "0x597BC0")]
		private sealed class _003C_003Ec__2<T> where T : class, ISaveable
		{
			[Token(Token = "0x40036CA")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec__2<T> _003C_003E9;

			[Token(Token = "0x40036CB")]
			[FieldOffset(Offset = "0x0")]
			public static Func<FieldInfo, bool> _003C_003E9__2_1;

			[Token(Token = "0x60042C8")]
			public _003C_003Ec__2()
			{
			}

			[Token(Token = "0x60042C9")]
			internal bool _003CRestore_003Eb__2_1(FieldInfo f)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000AA3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597BD0", Offset = "0x597BD0")]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			[Token(Token = "0x40036CC")]
			[FieldOffset(Offset = "0x10")]
			public IList list;

			[Token(Token = "0x40036CD")]
			[FieldOffset(Offset = "0x18")]
			public int i;

			[Token(Token = "0x40036CE")]
			[FieldOffset(Offset = "0x20")]
			public Action<IList> _003C_003E9__0;

			[Token(Token = "0x60042CA")]
			[Address(RVA = "0x8B667C", Offset = "0x8B667C", VA = "0x8B667C")]
			public _003C_003Ec__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60042CB")]
			[Address(RVA = "0x8B6684", Offset = "0x8B6684", VA = "0x8B6684")]
			internal void _003CRestoreList_003Eb__0(IList lst)
			{
			}
		}

		[Token(Token = "0x2000AA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597BE0", Offset = "0x597BE0")]
		private sealed class _003C_003Ec__DisplayClass10_0<T> where T : ISaveable
		{
			[Token(Token = "0x40036CF")]
			[FieldOffset(Offset = "0x0")]
			public IEnumerable<string> excludedFields;

			[Token(Token = "0x60042CC")]
			public _003C_003Ec__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60042CD")]
			internal bool _003CSerialize_003Eb__0(FieldInfo f)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000AA5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597BF0", Offset = "0x597BF0")]
		private sealed class _003C_003Ec__10<T> where T : ISaveable
		{
			[Token(Token = "0x40036D0")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec__10<T> _003C_003E9;

			[Token(Token = "0x40036D1")]
			[FieldOffset(Offset = "0x0")]
			public static Func<FieldInfo, bool> _003C_003E9__10_1;

			[Token(Token = "0x60042CF")]
			public _003C_003Ec__10()
			{
			}

			[Token(Token = "0x60042D0")]
			internal bool _003CSerialize_003Eb__10_1(FieldInfo f)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40036C3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Type, FieldInfo[]> _fieldsPerType;

		[Token(Token = "0x60042B1")]
		public static void Restore<T>(this T instance, JSONNode data) where T : class, ISaveable
		{
		}

		[Token(Token = "0x60042B2")]
		public static void Restore<T>(this T instance, JSONNode data, IEnumerable<string> excludedFields) where T : class, ISaveable
		{
		}

		[Token(Token = "0x60042B3")]
		[Address(RVA = "0xBAFF0C", Offset = "0xBAFF0C", VA = "0xBAFF0C")]
		private static IList FixArraySize(IList lst, int count, Type type, Action<IList> set)
		{
			return null;
		}

		[Token(Token = "0x60042B4")]
		[Address(RVA = "0xBB0374", Offset = "0xBB0374", VA = "0xBB0374")]
		private static void ReAssignList(IList listSource, IList listTarget)
		{
		}

		[Token(Token = "0x60042B5")]
		[Address(RVA = "0xBB05A0", Offset = "0xBB05A0", VA = "0xBB05A0")]
		private static void RestoreList(IList list, Type elemType, JSONNode data)
		{
		}

		[Token(Token = "0x60042B6")]
		[Address(RVA = "0xBB0F20", Offset = "0xBB0F20", VA = "0xBB0F20")]
		private static object RestoreObject(ISaveable elem, Type elemType, JSONNode c)
		{
			return null;
		}

		[Token(Token = "0x60042B7")]
		public static JSONNode Serialize<T>(this T instance) where T : ISaveable
		{
			return null;
		}

		[Token(Token = "0x60042B8")]
		public static JSONNode Serialize<T>(this T instance, IEnumerable<string> excludedFields) where T : ISaveable
		{
			return null;
		}

		[Token(Token = "0x60042B9")]
		public static JSONNode Serialize<T>(this T instance, JSONClass dict) where T : ISaveable
		{
			return null;
		}

		[Token(Token = "0x60042BA")]
		public static JSONNode Serialize<T>(this T instance, IEnumerable<string> excludedFields, JSONClass dict) where T : ISaveable
		{
			return null;
		}

		[Token(Token = "0x60042BB")]
		[Address(RVA = "0xBB1118", Offset = "0xBB1118", VA = "0xBB1118")]
		private static JSONData CreatePrimitiveNode(object obj)
		{
			return null;
		}

		[Token(Token = "0x60042BC")]
		[Address(RVA = "0xBB13C8", Offset = "0xBB13C8", VA = "0xBB13C8")]
		private static JSONNode SerializeList(IList list, Type type)
		{
			return null;
		}

		[Token(Token = "0x60042BD")]
		[Address(RVA = "0xBB1714", Offset = "0xBB1714", VA = "0xBB1714")]
		private static JSONNode SerializeObject(ISaveable elem, Type type)
		{
			return null;
		}

		[Token(Token = "0x60042BE")]
		[Address(RVA = "0xBB0E30", Offset = "0xBB0E30", VA = "0xBB0E30")]
		private static bool IsArrayType(Type elemType)
		{
			return default(bool);
		}

		[Token(Token = "0x60042BF")]
		[Address(RVA = "0xBB02FC", Offset = "0xBB02FC", VA = "0xBB02FC")]
		private static Type GetElementType(Type type)
		{
			return null;
		}
	}
}
