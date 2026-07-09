using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core
{
	[Token(Token = "0x2000C85")]
	internal static class ArmoryProvider
	{
		[Token(Token = "0x4003D17")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BDE8C", Offset = "0x5BDE8C")]
		private static Dictionary<Type, IArmoryProvider> _003CProviders_003Ek__BackingField;

		[Token(Token = "0x170009EF")]
		private static Dictionary<Type, IArmoryProvider> Providers
		{
			[Token(Token = "0x6004DF8")]
			[Address(RVA = "0xD501D8", Offset = "0xD501D8", VA = "0xD501D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6289F0", Offset = "0x6289F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004DF9")]
			[Address(RVA = "0xD5023C", Offset = "0xD5023C", VA = "0xD5023C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628A00", Offset = "0x628A00")]
			set
			{
			}
		}

		[Token(Token = "0x6004DFA")]
		[Address(RVA = "0xD502A4", Offset = "0xD502A4", VA = "0xD502A4")]
		static ArmoryProvider()
		{
		}

		[Token(Token = "0x6004DFB")]
		internal static void RegisterProvider<T>(T provider) where T : class, IArmoryProvider
		{
		}

		[Token(Token = "0x6004DFC")]
		internal static void UnregisterProvider<T>(T provider) where T : class, IArmoryProvider
		{
		}

		[Token(Token = "0x6004DFD")]
		internal static T Get<T>() where T : class, IArmoryProvider
		{
			return null;
		}
	}
}
