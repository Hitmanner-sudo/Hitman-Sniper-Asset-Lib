using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x2001309")]
	internal class EngageCache
	{
		[Serializable]
		[Token(Token = "0x200130A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE81C", Offset = "0x5AE81C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4005B3C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4005B3D")]
			[FieldOffset(Offset = "0x8")]
			public static Func<string, string> _003C_003E9__6_0;

			[Token(Token = "0x4005B3E")]
			[FieldOffset(Offset = "0x10")]
			public static Func<string, string> _003C_003E9__6_1;

			[Token(Token = "0x4005B3F")]
			[FieldOffset(Offset = "0x18")]
			public static Func<string, string> _003C_003E9__6_2;

			[Token(Token = "0x4005B40")]
			[FieldOffset(Offset = "0x20")]
			public static Func<string, DateTime> _003C_003E9__6_3;

			[Token(Token = "0x4005B41")]
			[FieldOffset(Offset = "0x28")]
			public static Func<KeyValuePair<string, DateTime>, string> _003C_003E9__9_0;

			[Token(Token = "0x6006FCD")]
			[Address(RVA = "0x86E530", Offset = "0x86E530", VA = "0x86E530")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6006FCE")]
			[Address(RVA = "0x86E538", Offset = "0x86E538", VA = "0x86E538")]
			internal string _003C_002Ector_003Eb__6_0(string e)
			{
				return null;
			}

			[Token(Token = "0x6006FCF")]
			[Address(RVA = "0x86E59C", Offset = "0x86E59C", VA = "0x86E59C")]
			internal string _003C_002Ector_003Eb__6_1(string e)
			{
				return null;
			}

			[Token(Token = "0x6006FD0")]
			[Address(RVA = "0x86E5A8", Offset = "0x86E5A8", VA = "0x86E5A8")]
			internal string _003C_002Ector_003Eb__6_2(string e)
			{
				return null;
			}

			[Token(Token = "0x6006FD1")]
			[Address(RVA = "0x86E640", Offset = "0x86E640", VA = "0x86E640")]
			internal DateTime _003C_002Ector_003Eb__6_3(string e)
			{
				return default(DateTime);
			}

			[Token(Token = "0x6006FD2")]
			[Address(RVA = "0x86E738", Offset = "0x86E738", VA = "0x86E738")]
			internal string _003CSave_003Eb__9_0(KeyValuePair<string, DateTime> e)
			{
				return null;
			}
		}

		[Token(Token = "0x4005B36")]
		private const string TIMES = "times";

		[Token(Token = "0x4005B37")]
		[FieldOffset(Offset = "0x0")]
		private static object LOCK;

		[Token(Token = "0x4005B38")]
		[FieldOffset(Offset = "0x10")]
		private readonly Settings settings;

		[Token(Token = "0x4005B39")]
		[FieldOffset(Offset = "0x18")]
		private readonly string location;

		[Token(Token = "0x4005B3A")]
		[FieldOffset(Offset = "0x20")]
		private readonly IDictionary<string, string> cache;

		[Token(Token = "0x4005B3B")]
		[FieldOffset(Offset = "0x28")]
		private readonly IDictionary<string, DateTime> times;

		[Token(Token = "0x6006FC4")]
		[Address(RVA = "0xE12EE0", Offset = "0xE12EE0", VA = "0xE12EE0")]
		internal EngageCache(Settings settings)
		{
		}

		[Token(Token = "0x6006FC5")]
		[Address(RVA = "0xE1343C", Offset = "0xE1343C", VA = "0xE1343C")]
		internal void Put(string decisionPoint, string flavour, string data)
		{
		}

		[Token(Token = "0x6006FC6")]
		[Address(RVA = "0xE137B8", Offset = "0xE137B8", VA = "0xE137B8")]
		internal string Get(string decisionPoint, string flavour)
		{
			return null;
		}

		[Token(Token = "0x6006FC7")]
		[Address(RVA = "0xE13E0C", Offset = "0xE13E0C", VA = "0xE13E0C")]
		internal void Save()
		{
		}

		[Token(Token = "0x6006FC8")]
		[Address(RVA = "0xE14340", Offset = "0xE14340", VA = "0xE14340")]
		internal void Clear()
		{
		}

		[Token(Token = "0x6006FC9")]
		[Address(RVA = "0xE133FC", Offset = "0xE133FC", VA = "0xE133FC")]
		private void CreateDirectory()
		{
		}

		[Token(Token = "0x6006FCA")]
		[Address(RVA = "0xE13758", Offset = "0xE13758", VA = "0xE13758")]
		private static string Key(string decisionPoint, string flavour)
		{
			return null;
		}
	}
}
