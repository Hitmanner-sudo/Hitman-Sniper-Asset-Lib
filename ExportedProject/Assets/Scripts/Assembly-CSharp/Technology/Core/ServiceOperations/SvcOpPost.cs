using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000D0A")]
	public abstract class SvcOpPost : SvcOp
	{
		[Token(Token = "0x4003E7B")]
		private const TransportProtocolClient.Verb _verb = TransportProtocolClient.Verb.POST;

		[Token(Token = "0x4003E7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE2B4", Offset = "0x5BE2B4")]
		private string _003CSvcOpCmdQueryString_003Ek__BackingField;

		[Token(Token = "0x4003E7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE2C4", Offset = "0x5BE2C4")]
		private string _003CPostBody_003Ek__BackingField;

		[Token(Token = "0x17000AA7")]
		protected override string SvcOpCmdQueryString
		{
			[Token(Token = "0x6005098")]
			[Address(RVA = "0xD3CE6C", Offset = "0xD3CE6C", VA = "0xD3CE6C", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629540", Offset = "0x629540")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005099")]
			[Address(RVA = "0xD3CE74", Offset = "0xD3CE74", VA = "0xD3CE74", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629550", Offset = "0x629550")]
			set
			{
			}
		}

		[Token(Token = "0x17000AA8")]
		protected virtual string PostBody
		{
			[Token(Token = "0x600509A")]
			[Address(RVA = "0xD3CE7C", Offset = "0xD3CE7C", VA = "0xD3CE7C", Slot = "10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629560", Offset = "0x629560")]
			get
			{
				return null;
			}
			[Token(Token = "0x600509B")]
			[Address(RVA = "0xD3CE84", Offset = "0xD3CE84", VA = "0xD3CE84", Slot = "11")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629570", Offset = "0x629570")]
			set
			{
			}
		}

		[Token(Token = "0x600509C")]
		[Address(RVA = "0xD347B0", Offset = "0xD347B0", VA = "0xD347B0")]
		protected SvcOpPost([Optional][DefaultParameterValue(true)] bool requiresAuthentication, [Optional] Action<IResponseContext> responseAction, bool requiresEditorToken = false)
		{
		}

		[Token(Token = "0x600509D")]
		[Address(RVA = "0xD34DEC", Offset = "0xD34DEC", VA = "0xD34DEC", Slot = "12")]
		protected virtual void Post()
		{
		}

		[Token(Token = "0x600509E")]
		[Address(RVA = "0xD3CE8C", Offset = "0xD3CE8C", VA = "0xD3CE8C", Slot = "13")]
		protected virtual void Post(string postData, KeyValuePair<string, string> runtimeHeaders)
		{
		}

		[Token(Token = "0x600509F")]
		[Address(RVA = "0xD34A1C", Offset = "0xD34A1C", VA = "0xD34A1C")]
		public static string MergeRequiredPostDataAndPostData(string postData, IRequiredUserDefined.PostBody requiredUserDefinedRuntimePostBody)
		{
			return null;
		}
	}
}
