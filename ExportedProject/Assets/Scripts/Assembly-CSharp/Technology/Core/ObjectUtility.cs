using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Core
{
	[Token(Token = "0x2000C62")]
	public class ObjectUtility<T> where T : Object
	{
		[Token(Token = "0x2000C63")]
		public delegate T LoadMethod(string id);

		[Token(Token = "0x4003CBE")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BDB54", Offset = "0x5BDB54")]
		private static LoadMethod _003CCustomLoadMethod_003Ek__BackingField;

		[Token(Token = "0x170009DD")]
		protected static LoadMethod CustomLoadMethod
		{
			[Token(Token = "0x6004D75")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6287F0", Offset = "0x6287F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D76")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x628800", Offset = "0x628800")]
			private set
			{
			}
		}

		[Token(Token = "0x6004D77")]
		public static void SetCustomLoadMethod(LoadMethod customLoadMethod)
		{
		}

		[Token(Token = "0x6004D78")]
		public static T Load(string path)
		{
			return null;
		}

		[Token(Token = "0x6004D79")]
		public ObjectUtility()
		{
		}
	}
}
