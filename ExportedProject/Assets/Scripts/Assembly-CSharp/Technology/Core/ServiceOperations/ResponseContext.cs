using System;
using System.Net;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CBE")]
	public class ResponseContext : IResponseContext
	{
		[Token(Token = "0x4003DA5")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE114", Offset = "0x5BE114")]
		private SvcOp _003CRequestingServiceOperation_003Ek__BackingField;

		[Token(Token = "0x4003DA6")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE124", Offset = "0x5BE124")]
		private uint _003CStatusCode_003Ek__BackingField;

		[Token(Token = "0x4003DA7")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE134", Offset = "0x5BE134")]
		private string _003CStatusMessage_003Ek__BackingField;

		[Token(Token = "0x4003DA8")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE144", Offset = "0x5BE144")]
		private string _003CBody_003Ek__BackingField;

		[Token(Token = "0x4003DA9")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE154", Offset = "0x5BE154")]
		private WebHeaderCollection _003CHeaders_003Ek__BackingField;

		[Token(Token = "0x4003DAA")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE164", Offset = "0x5BE164")]
		private Action<IResponseContext> _003CResponseAction_003Ek__BackingField;

		[Token(Token = "0x17000A61")]
		public SvcOp RequestingServiceOperation
		{
			[Token(Token = "0x6004F25")]
			[Address(RVA = "0x9669D8", Offset = "0x9669D8", VA = "0x9669D8", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6291A0", Offset = "0x6291A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F26")]
			[Address(RVA = "0x9669E0", Offset = "0x9669E0", VA = "0x9669E0", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6291B0", Offset = "0x6291B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000A62")]
		public uint StatusCode
		{
			[Token(Token = "0x6004F27")]
			[Address(RVA = "0x9669E8", Offset = "0x9669E8", VA = "0x9669E8", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6291C0", Offset = "0x6291C0")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6004F28")]
			[Address(RVA = "0x9669F0", Offset = "0x9669F0", VA = "0x9669F0", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6291D0", Offset = "0x6291D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000A63")]
		public string StatusMessage
		{
			[Token(Token = "0x6004F29")]
			[Address(RVA = "0x9669F8", Offset = "0x9669F8", VA = "0x9669F8", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6291E0", Offset = "0x6291E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F2A")]
			[Address(RVA = "0x966A00", Offset = "0x966A00", VA = "0x966A00", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6291F0", Offset = "0x6291F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000A64")]
		public string Body
		{
			[Token(Token = "0x6004F2B")]
			[Address(RVA = "0x966A08", Offset = "0x966A08", VA = "0x966A08", Slot = "10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629200", Offset = "0x629200")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F2C")]
			[Address(RVA = "0x966A10", Offset = "0x966A10", VA = "0x966A10", Slot = "11")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629210", Offset = "0x629210")]
			set
			{
			}
		}

		[Token(Token = "0x17000A65")]
		public WebHeaderCollection Headers
		{
			[Token(Token = "0x6004F2D")]
			[Address(RVA = "0x966A18", Offset = "0x966A18", VA = "0x966A18", Slot = "12")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629220", Offset = "0x629220")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F2E")]
			[Address(RVA = "0x966A20", Offset = "0x966A20", VA = "0x966A20", Slot = "13")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629230", Offset = "0x629230")]
			set
			{
			}
		}

		[Token(Token = "0x17000A66")]
		public Action<IResponseContext> ResponseAction
		{
			[Token(Token = "0x6004F2F")]
			[Address(RVA = "0x966A28", Offset = "0x966A28", VA = "0x966A28", Slot = "14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629240", Offset = "0x629240")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F30")]
			[Address(RVA = "0x966A30", Offset = "0x966A30", VA = "0x966A30", Slot = "15")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629250", Offset = "0x629250")]
			set
			{
			}
		}

		[Token(Token = "0x6004F31")]
		[Address(RVA = "0x966A38", Offset = "0x966A38", VA = "0x966A38")]
		public ResponseContext()
		{
		}
	}
}
