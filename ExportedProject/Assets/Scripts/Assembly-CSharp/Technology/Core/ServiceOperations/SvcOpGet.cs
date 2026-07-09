using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000D06")]
	public abstract class SvcOpGet : SvcOp
	{
		[Token(Token = "0x4003E6B")]
		private const TransportProtocolClient.Verb _verb = TransportProtocolClient.Verb.GET;

		[Token(Token = "0x4003E6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE294", Offset = "0x5BE294")]
		private string _003CSvcOpCmdQueryString_003Ek__BackingField;

		[Token(Token = "0x17000AA1")]
		protected override string SvcOpCmdQueryString
		{
			[Token(Token = "0x600507B")]
			[Address(RVA = "0xD36D24", Offset = "0xD36D24", VA = "0xD36D24", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629500", Offset = "0x629500")]
			get
			{
				return null;
			}
			[Token(Token = "0x600507C")]
			[Address(RVA = "0xD36D2C", Offset = "0xD36D2C", VA = "0xD36D2C", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629510", Offset = "0x629510")]
			set
			{
			}
		}

		[Token(Token = "0x6005079")]
		[Address(RVA = "0xD30408", Offset = "0xD30408", VA = "0xD30408")]
		protected SvcOpGet(bool requiresAuthentication, [Optional] Action<IResponseContext> responseAction, bool requiresEditorToken = false)
		{
		}

		[Token(Token = "0x600507A")]
		[Address(RVA = "0xD305F8", Offset = "0xD305F8", VA = "0xD305F8", Slot = "10")]
		protected virtual void Get()
		{
		}
	}
}
