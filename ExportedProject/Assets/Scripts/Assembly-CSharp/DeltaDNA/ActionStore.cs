using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x20012FE")]
	internal class ActionStore
	{
		[Token(Token = "0x20012FF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE7DC", Offset = "0x5AE7DC")]
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			[Token(Token = "0x4005B0C")]
			[FieldOffset(Offset = "0x10")]
			public byte[] hash;

			[Token(Token = "0x6006F85")]
			[Address(RVA = "0x91240C", Offset = "0x91240C", VA = "0x91240C")]
			public _003C_003Ec__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6006F86")]
			[Address(RVA = "0x912414", Offset = "0x912414", VA = "0x912414")]
			internal bool _003CGet_003Eb__0(byte t, int i)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2001300")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE7EC", Offset = "0x5AE7EC")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4005B0D")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4005B0E")]
			[FieldOffset(Offset = "0x8")]
			public static Func<byte, bool> _003C_003E9__8_0;

			[Token(Token = "0x6006F88")]
			[Address(RVA = "0x9123F8", Offset = "0x9123F8", VA = "0x9123F8")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6006F89")]
			[Address(RVA = "0x912400", Offset = "0x912400", VA = "0x912400")]
			internal bool _003CInitialiseSalt_003Eb__8_0(byte e)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4005B09")]
		[FieldOffset(Offset = "0x0")]
		private static object LOCK;

		[Token(Token = "0x4005B0A")]
		[FieldOffset(Offset = "0x10")]
		private readonly string location;

		[Token(Token = "0x4005B0B")]
		[FieldOffset(Offset = "0x18")]
		private byte[] salt;

		[Token(Token = "0x6006F7D")]
		[Address(RVA = "0xD578CC", Offset = "0xD578CC", VA = "0xD578CC")]
		internal ActionStore(string location)
		{
		}

		[Token(Token = "0x6006F7E")]
		[Address(RVA = "0xD57C70", Offset = "0xD57C70", VA = "0xD57C70", Slot = "4")]
		internal virtual Dictionary<string, object> Get(EventTrigger trigger)
		{
			return null;
		}

		[Token(Token = "0x6006F7F")]
		[Address(RVA = "0xD583D8", Offset = "0xD583D8", VA = "0xD583D8", Slot = "5")]
		internal virtual void Put(EventTrigger trigger, Dictionary<string, object> action)
		{
		}

		[Token(Token = "0x6006F80")]
		[Address(RVA = "0xD587D0", Offset = "0xD587D0", VA = "0xD587D0", Slot = "6")]
		internal virtual void Remove(EventTrigger trigger)
		{
		}

		[Token(Token = "0x6006F81")]
		[Address(RVA = "0xD58950", Offset = "0xD58950", VA = "0xD58950", Slot = "7")]
		internal virtual void Clear()
		{
		}

		[Token(Token = "0x6006F82")]
		[Address(RVA = "0xD57A38", Offset = "0xD57A38", VA = "0xD57A38")]
		private void InitialiseSalt()
		{
		}

		[Token(Token = "0x6006F83")]
		[Address(RVA = "0xD58280", Offset = "0xD58280", VA = "0xD58280")]
		private static byte[] GeneratedSaltedHash(byte[] text, byte[] salt)
		{
			return null;
		}
	}
}
