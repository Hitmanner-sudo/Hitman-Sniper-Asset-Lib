using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000D07")]
	public class SvcOpHeader
	{
		[Token(Token = "0x4003E6D")]
		[FieldOffset(Offset = "0x10")]
		private bool _needUpdate;

		[Token(Token = "0x4003E6E")]
		[FieldOffset(Offset = "0x0")]
		private static KeyValuePair<string, string>[] _definedOnce;

		[Token(Token = "0x4003E6F")]
		[FieldOffset(Offset = "0x18")]
		private KeyValuePair<string, string>[] _definedMultiple;

		[Token(Token = "0x4003E70")]
		[FieldOffset(Offset = "0x20")]
		private KeyValuePair<string, string>[] _definedRuntime;

		[Token(Token = "0x4003E71")]
		[FieldOffset(Offset = "0x28")]
		private KeyValuePair<string, string>[] _cachedValue;

		[Token(Token = "0x4003E72")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE2A4", Offset = "0x5BE2A4")]
		private KeyValuePair<string, string>[] _003CCustom_003Ek__BackingField;

		[Token(Token = "0x17000AA2")]
		public KeyValuePair<string, string>[] Value
		{
			[Token(Token = "0x600507D")]
			[Address(RVA = "0xD3AB84", Offset = "0xD3AB84", VA = "0xD3AB84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AA3")]
		public bool IsCached
		{
			[Token(Token = "0x600507E")]
			[Address(RVA = "0xD33A64", Offset = "0xD33A64", VA = "0xD33A64")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000AA4")]
		public KeyValuePair<string, string>[] CachedValue
		{
			[Token(Token = "0x600507F")]
			[Address(RVA = "0xD33C94", Offset = "0xD33C94", VA = "0xD33C94")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005080")]
			[Address(RVA = "0xD3AED4", Offset = "0xD3AED4", VA = "0xD3AED4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000AA5")]
		public KeyValuePair<string, string>[] Custom
		{
			[Token(Token = "0x6005081")]
			[Address(RVA = "0xD3AEDC", Offset = "0xD3AEDC", VA = "0xD3AEDC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x629520", Offset = "0x629520")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005082")]
			[Address(RVA = "0xD3AEE4", Offset = "0xD3AEE4", VA = "0xD3AEE4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x629530", Offset = "0x629530")]
			set
			{
			}
		}

		[Token(Token = "0x6005083")]
		[Address(RVA = "0xD33A74", Offset = "0xD33A74", VA = "0xD33A74")]
		public void Cache()
		{
		}

		[Token(Token = "0x6005084")]
		[Address(RVA = "0xD32844", Offset = "0xD32844", VA = "0xD32844")]
		public void ClearCache()
		{
		}

		[Token(Token = "0x6005085")]
		[Address(RVA = "0xD3AEEC", Offset = "0xD3AEEC", VA = "0xD3AEEC", Slot = "4")]
		protected virtual KeyValuePair<string, string>[] DefineOnce()
		{
			return null;
		}

		[Token(Token = "0x6005086")]
		[Address(RVA = "0xD3AEF4", Offset = "0xD3AEF4", VA = "0xD3AEF4", Slot = "5")]
		protected virtual KeyValuePair<string, string>[] DefineMultiple()
		{
			return null;
		}

		[Token(Token = "0x6005087")]
		[Address(RVA = "0xD3AEFC", Offset = "0xD3AEFC", VA = "0xD3AEFC", Slot = "6")]
		protected virtual KeyValuePair<string, string>[] DefineRuntime()
		{
			return null;
		}

		[Token(Token = "0x6005088")]
		[Address(RVA = "0xD3AF04", Offset = "0xD3AF04", VA = "0xD3AF04", Slot = "7")]
		protected virtual KeyValuePair<string, string>[] DefineAuthHeaders()
		{
			return null;
		}

		[Token(Token = "0x6005089")]
		[Address(RVA = "0xD3AF0C", Offset = "0xD3AF0C", VA = "0xD3AF0C")]
		private void Update()
		{
		}

		[Token(Token = "0x600508A")]
		[Address(RVA = "0xD3AB88", Offset = "0xD3AB88", VA = "0xD3AB88")]
		private KeyValuePair<string, string>[] Define()
		{
			return null;
		}

		[Token(Token = "0x600508B")]
		[Address(RVA = "0xD3AF18", Offset = "0xD3AF18", VA = "0xD3AF18")]
		public KeyValuePair<string, string>[] GetAuthHeaders()
		{
			return null;
		}

		[Token(Token = "0x600508C")]
		[Address(RVA = "0xD3AF24", Offset = "0xD3AF24", VA = "0xD3AF24")]
		public SvcOpHeader()
		{
		}
	}
}
