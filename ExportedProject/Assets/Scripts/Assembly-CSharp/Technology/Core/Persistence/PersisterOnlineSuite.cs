using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Core.Auth;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Persistence
{
	[Token(Token = "0x2000D46")]
	public class PersisterOnlineSuite : IPersister
	{
		[Token(Token = "0x2000D47")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59887C", Offset = "0x59887C")]
		private sealed class _003C_003Ec__DisplayClass16_0
		{
			[Token(Token = "0x4003F4E")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpUpdateUserProfileGameSpecific svcOp;

			[Token(Token = "0x4003F4F")]
			[FieldOffset(Offset = "0x18")]
			public KeyValuePair<string, string>[] finalValuePair;

			[Token(Token = "0x6005207")]
			[Address(RVA = "0x8CFC00", Offset = "0x8CFC00", VA = "0x8CFC00")]
			public _003C_003Ec__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6005208")]
			[Address(RVA = "0x8CFC08", Offset = "0x8CFC08", VA = "0x8CFC08")]
			internal void _003CInternFlush_003Eb__0()
			{
			}
		}

		[Token(Token = "0x2000D48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59888C", Offset = "0x59888C")]
		private sealed class _003C_003Ec__DisplayClass24_0
		{
			[Token(Token = "0x4003F50")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpGetUserProfileGameSpecific svcOp;

			[Token(Token = "0x4003F51")]
			[FieldOffset(Offset = "0x18")]
			public PersisterOnlineSuite _003C_003E4__this;

			[Token(Token = "0x4003F52")]
			[FieldOffset(Offset = "0x20")]
			public IPersistableCache<int> intCache;

			[Token(Token = "0x4003F53")]
			[FieldOffset(Offset = "0x28")]
			public IPersistableCache<float> floatCache;

			[Token(Token = "0x4003F54")]
			[FieldOffset(Offset = "0x30")]
			public IPersistableCache<bool> boolCache;

			[Token(Token = "0x4003F55")]
			[FieldOffset(Offset = "0x38")]
			public IPersistableCache<long> longCache;

			[Token(Token = "0x4003F56")]
			[FieldOffset(Offset = "0x40")]
			public IPersistableCache<string> stringCache;

			[Token(Token = "0x6005209")]
			[Address(RVA = "0x8CFD08", Offset = "0x8CFD08", VA = "0x8CFD08")]
			public _003C_003Ec__DisplayClass24_0()
			{
			}

			[Token(Token = "0x600520A")]
			[Address(RVA = "0x8CFD10", Offset = "0x8CFD10", VA = "0x8CFD10")]
			internal void _003CRead_003Eb__0()
			{
			}

			[Token(Token = "0x600520B")]
			[Address(RVA = "0x8CFD68", Offset = "0x8CFD68", VA = "0x8CFD68")]
			internal void _003CRead_003Eb__1(IResponseContext response, IRequestContext request, OSRequestState state, Dictionary<string, object> meta)
			{
			}
		}

		[Token(Token = "0x4003F4C")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<KeyValuePair<string, string>> _writeKeyValuePairs;

		[Token(Token = "0x4003F4D")]
		[FieldOffset(Offset = "0x30")]
		private bool _isReading;

		[Token(Token = "0x1400015A")]
		internal event EventHandler<PersistenceLoadingEvent> OnReadSuccessInternal
		{
			[Token(Token = "0x60051EC")]
			[Address(RVA = "0x906358", Offset = "0x906358", VA = "0x906358")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629830", Offset = "0x629830")]
			add
			{
			}
			[Token(Token = "0x60051ED")]
			[Address(RVA = "0x9063F8", Offset = "0x9063F8", VA = "0x9063F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629840", Offset = "0x629840")]
			remove
			{
			}
		}

		[Token(Token = "0x1400015B")]
		internal event EventHandler<PersistenceLoadingEvent> OnSuccess
		{
			[Token(Token = "0x60051EE")]
			[Address(RVA = "0x906498", Offset = "0x906498", VA = "0x906498")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629850", Offset = "0x629850")]
			add
			{
			}
			[Token(Token = "0x60051EF")]
			[Address(RVA = "0x906538", Offset = "0x906538", VA = "0x906538")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629860", Offset = "0x629860")]
			remove
			{
			}
		}

		[Token(Token = "0x1400015C")]
		internal event EventHandler<PersistenceLoadingEvent> OnFailure
		{
			[Token(Token = "0x60051F0")]
			[Address(RVA = "0x9065D8", Offset = "0x9065D8", VA = "0x9065D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629870", Offset = "0x629870")]
			add
			{
			}
			[Token(Token = "0x60051F1")]
			[Address(RVA = "0x906678", Offset = "0x906678", VA = "0x906678")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629880", Offset = "0x629880")]
			remove
			{
			}
		}

		[Token(Token = "0x60051F2")]
		[Address(RVA = "0x906718", Offset = "0x906718", VA = "0x906718")]
		public PersisterOnlineSuite()
		{
		}

		[Token(Token = "0x60051F3")]
		[Address(RVA = "0x906798", Offset = "0x906798", VA = "0x906798")]
		public static string Key(string suffix)
		{
			return null;
		}

		[Token(Token = "0x60051F4")]
		[Address(RVA = "0x906800", Offset = "0x906800", VA = "0x906800")]
		private string Writer(string data)
		{
			return null;
		}

		[Token(Token = "0x60051F5")]
		[Address(RVA = "0x906808", Offset = "0x906808", VA = "0x906808", Slot = "16")]
		public void Clear()
		{
		}

		[Token(Token = "0x60051F6")]
		[Address(RVA = "0x90685C", Offset = "0x90685C", VA = "0x90685C", Slot = "15")]
		public void Flush()
		{
		}

		[Token(Token = "0x60051F7")]
		[Address(RVA = "0x90686C", Offset = "0x90686C", VA = "0x90686C", Slot = "17")]
		protected virtual void InternFlush()
		{
		}

		[Token(Token = "0x60051F8")]
		[Address(RVA = "0x906A2C", Offset = "0x906A2C", VA = "0x906A2C")]
		public KeyValuePair<string, string>[] GetFinalKeyPair()
		{
			return null;
		}

		[Token(Token = "0x60051F9")]
		[Address(RVA = "0x906CE8", Offset = "0x906CE8", VA = "0x906CE8", Slot = "11")]
		public void WriteBool(string name, Dictionary<string, bool> dictionary)
		{
		}

		[Token(Token = "0x60051FA")]
		[Address(RVA = "0x906DB4", Offset = "0x906DB4", VA = "0x906DB4", Slot = "10")]
		public void WriteInt(string name, Dictionary<string, int> dictionary)
		{
		}

		[Token(Token = "0x60051FB")]
		[Address(RVA = "0x906E80", Offset = "0x906E80", VA = "0x906E80", Slot = "12")]
		public void WriteFloat(string name, Dictionary<string, float> dictionary)
		{
		}

		[Token(Token = "0x60051FC")]
		[Address(RVA = "0x906F4C", Offset = "0x906F4C", VA = "0x906F4C", Slot = "13")]
		public void WriteLong(string name, Dictionary<string, long> dictionary)
		{
		}

		[Token(Token = "0x60051FD")]
		[Address(RVA = "0x907018", Offset = "0x907018", VA = "0x907018", Slot = "14")]
		public void WriteString(string name, Dictionary<string, string> dictionary)
		{
		}

		[Token(Token = "0x60051FE")]
		[Address(RVA = "0x907120", Offset = "0x907120", VA = "0x907120")]
		private void WriteSubscriberAction(IResponseContext responseContext, IRequestContext requestContext, OSRequestState state, Dictionary<string, object> meta)
		{
		}

		[Token(Token = "0x60051FF")]
		[Address(RVA = "0x9075A4", Offset = "0x9075A4", VA = "0x9075A4", Slot = "4")]
		public void Read(string name, IPersistableCache<int> intCache, IPersistableCache<float> floatCache, IPersistableCache<string> stringCache, IPersistableCache<bool> boolCache, IPersistableCache<long> longCache)
		{
		}

		[Token(Token = "0x6005200")]
		[Address(RVA = "0x90783C", Offset = "0x90783C", VA = "0x90783C", Slot = "9")]
		public void ReadBool(string value, IPersistableCache<bool> cache)
		{
		}

		[Token(Token = "0x6005201")]
		[Address(RVA = "0x9078C0", Offset = "0x9078C0", VA = "0x9078C0", Slot = "5")]
		public void ReadInt(string value, IPersistableCache<int> cache)
		{
		}

		[Token(Token = "0x6005202")]
		[Address(RVA = "0x907944", Offset = "0x907944", VA = "0x907944", Slot = "6")]
		public void ReadFloat(string value, IPersistableCache<float> cache)
		{
		}

		[Token(Token = "0x6005203")]
		[Address(RVA = "0x9079C8", Offset = "0x9079C8", VA = "0x9079C8", Slot = "7")]
		public void ReadLong(string value, IPersistableCache<long> cache)
		{
		}

		[Token(Token = "0x6005204")]
		[Address(RVA = "0x907A4C", Offset = "0x907A4C", VA = "0x907A4C", Slot = "8")]
		public void ReadString(string value, IPersistableCache<string> cache)
		{
		}

		[Token(Token = "0x6005205")]
		private void Decode<T>(string data, IPersistableCache<T> cache)
		{
		}

		[Token(Token = "0x6005206")]
		[Address(RVA = "0x907514", Offset = "0x907514", VA = "0x907514")]
		private void UpdateProfileLastUpdate(string dateTimeString)
		{
		}
	}
}
