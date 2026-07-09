using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CBD")]
	public struct PostRequestContext : IPostRequestContext, IRequestContext
	{
		[Token(Token = "0x4003D99")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE054", Offset = "0x5BE054")]
		private uint _003CStatusCode_003Ek__BackingField;

		[Token(Token = "0x4003D9A")]
		[FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE064", Offset = "0x5BE064")]
		private string _003CStatusMessage_003Ek__BackingField;

		[Token(Token = "0x4003D9B")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE074", Offset = "0x5BE074")]
		private string _003CPostData_003Ek__BackingField;

		[Token(Token = "0x4003D9C")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE084", Offset = "0x5BE084")]
		private string _003CUrl_003Ek__BackingField;

		[Token(Token = "0x4003D9D")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE094", Offset = "0x5BE094")]
		private TransportProtocolClient.Verb _003CTransportVerb_003Ek__BackingField;

		[Token(Token = "0x4003D9E")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE0A4", Offset = "0x5BE0A4")]
		private string _003CQueryString_003Ek__BackingField;

		[Token(Token = "0x4003D9F")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE0B4", Offset = "0x5BE0B4")]
		private SvcOpHeader _003CHeader_003Ek__BackingField;

		[Token(Token = "0x4003DA0")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE0C4", Offset = "0x5BE0C4")]
		private IRequiredUserDefined.PostBody _003CRequiredUserDefinedRuntimePostBody_003Ek__BackingField;

		[Token(Token = "0x4003DA1")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE0D4", Offset = "0x5BE0D4")]
		private Action<IResponseContext> _003CResponseAction_003Ek__BackingField;

		[Token(Token = "0x4003DA2")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE0E4", Offset = "0x5BE0E4")]
		private bool _003CIsAsyncMode_003Ek__BackingField;

		[Token(Token = "0x4003DA3")]
		[FieldOffset(Offset = "0x49")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE0F4", Offset = "0x5BE0F4")]
		private bool _003CVerbose_003Ek__BackingField;

		[Token(Token = "0x4003DA4")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE104", Offset = "0x5BE104")]
		private SvcOp _003CRequestingServiceOperation_003Ek__BackingField;

		[Token(Token = "0x17000A55")]
		public uint StatusCode
		{
			[Token(Token = "0x6004F0A")]
			[Address(RVA = "0x93F55C", Offset = "0x93F55C", VA = "0x93F55C", Slot = "8")]
			[System.Runtime.CompilerServices.IsReadOnly]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628E40", Offset = "0x628E40")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6004F0B")]
			[Address(RVA = "0x93F564", Offset = "0x93F564", VA = "0x93F564", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628E78", Offset = "0x628E78")]
			set
			{
			}
		}

		[Token(Token = "0x17000A56")]
		public string StatusMessage
		{
			[Token(Token = "0x6004F0C")]
			[Address(RVA = "0x93F56C", Offset = "0x93F56C", VA = "0x93F56C", Slot = "10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628E88", Offset = "0x628E88")]
			[System.Runtime.CompilerServices.IsReadOnly]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F0D")]
			[Address(RVA = "0x93F574", Offset = "0x93F574", VA = "0x93F574", Slot = "11")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628EC0", Offset = "0x628EC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000A57")]
		public string PostData
		{
			[Token(Token = "0x6004F0E")]
			[Address(RVA = "0x93F57C", Offset = "0x93F57C", VA = "0x93F57C", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628ED0", Offset = "0x628ED0")]
			[System.Runtime.CompilerServices.IsReadOnly]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F0F")]
			[Address(RVA = "0x93F584", Offset = "0x93F584", VA = "0x93F584", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628F08", Offset = "0x628F08")]
			set
			{
			}
		}

		[Token(Token = "0x17000A58")]
		public string Url
		{
			[Token(Token = "0x6004F10")]
			[Address(RVA = "0x93F58C", Offset = "0x93F58C", VA = "0x93F58C", Slot = "12")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628F18", Offset = "0x628F18")]
			[System.Runtime.CompilerServices.IsReadOnly]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F11")]
			[Address(RVA = "0x93F594", Offset = "0x93F594", VA = "0x93F594", Slot = "13")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628F50", Offset = "0x628F50")]
			set
			{
			}
		}

		[Token(Token = "0x17000A59")]
		public TransportProtocolClient.Verb TransportVerb
		{
			[Token(Token = "0x6004F12")]
			[Address(RVA = "0x93F59C", Offset = "0x93F59C", VA = "0x93F59C", Slot = "6")]
			[System.Runtime.CompilerServices.IsReadOnly]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628F60", Offset = "0x628F60")]
			get
			{
				return default(TransportProtocolClient.Verb);
			}
			[Token(Token = "0x6004F13")]
			[Address(RVA = "0x93F5A4", Offset = "0x93F5A4", VA = "0x93F5A4", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628F98", Offset = "0x628F98")]
			set
			{
			}
		}

		[Token(Token = "0x17000A5A")]
		public string QueryString
		{
			[Token(Token = "0x6004F14")]
			[Address(RVA = "0x93F5AC", Offset = "0x93F5AC", VA = "0x93F5AC", Slot = "14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628FA8", Offset = "0x628FA8")]
			[System.Runtime.CompilerServices.IsReadOnly]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F15")]
			[Address(RVA = "0x93F5B4", Offset = "0x93F5B4", VA = "0x93F5B4", Slot = "15")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628FE0", Offset = "0x628FE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000A5B")]
		public SvcOpHeader Header
		{
			[Token(Token = "0x6004F16")]
			[Address(RVA = "0x93F5BC", Offset = "0x93F5BC", VA = "0x93F5BC", Slot = "16")]
			[System.Runtime.CompilerServices.IsReadOnly]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628FF0", Offset = "0x628FF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F17")]
			[Address(RVA = "0x93F5C4", Offset = "0x93F5C4", VA = "0x93F5C4", Slot = "17")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629028", Offset = "0x629028")]
			set
			{
			}
		}

		[Token(Token = "0x17000A5C")]
		public IRequiredUserDefined.PostBody RequiredUserDefinedRuntimePostBody
		{
			[Token(Token = "0x6004F18")]
			[Address(RVA = "0x93F5CC", Offset = "0x93F5CC", VA = "0x93F5CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629038", Offset = "0x629038")]
			[System.Runtime.CompilerServices.IsReadOnly]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F19")]
			[Address(RVA = "0x93F5D4", Offset = "0x93F5D4", VA = "0x93F5D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629070", Offset = "0x629070")]
			set
			{
			}
		}

		[Token(Token = "0x17000A5D")]
		public Action<IResponseContext> ResponseAction
		{
			[Token(Token = "0x6004F1A")]
			[Address(RVA = "0x93F5DC", Offset = "0x93F5DC", VA = "0x93F5DC", Slot = "18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629080", Offset = "0x629080")]
			[System.Runtime.CompilerServices.IsReadOnly]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F1B")]
			[Address(RVA = "0x93F5E4", Offset = "0x93F5E4", VA = "0x93F5E4", Slot = "19")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6290B8", Offset = "0x6290B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000A5E")]
		public bool IsAsyncMode
		{
			[Token(Token = "0x6004F1C")]
			[Address(RVA = "0x93F5EC", Offset = "0x93F5EC", VA = "0x93F5EC", Slot = "20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6290C8", Offset = "0x6290C8")]
			[System.Runtime.CompilerServices.IsReadOnly]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004F1D")]
			[Address(RVA = "0x93F5F4", Offset = "0x93F5F4", VA = "0x93F5F4", Slot = "21")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629100", Offset = "0x629100")]
			set
			{
			}
		}

		[Token(Token = "0x17000A5F")]
		public bool Verbose
		{
			[Token(Token = "0x6004F1E")]
			[Address(RVA = "0x93F600", Offset = "0x93F600", VA = "0x93F600", Slot = "22")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629110", Offset = "0x629110")]
			[System.Runtime.CompilerServices.IsReadOnly]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004F1F")]
			[Address(RVA = "0x93F608", Offset = "0x93F608", VA = "0x93F608", Slot = "23")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629148", Offset = "0x629148")]
			set
			{
			}
		}

		[Token(Token = "0x17000A60")]
		public SvcOp RequestingServiceOperation
		{
			[Token(Token = "0x6004F20")]
			[Address(RVA = "0x93F614", Offset = "0x93F614", VA = "0x93F614", Slot = "24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629158", Offset = "0x629158")]
			[System.Runtime.CompilerServices.IsReadOnly]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F21")]
			[Address(RVA = "0x93F61C", Offset = "0x93F61C", VA = "0x93F61C", Slot = "25")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629190", Offset = "0x629190")]
			set
			{
			}
		}

		[Token(Token = "0x6004F22")]
		[Address(RVA = "0x93F624", Offset = "0x93F624", VA = "0x93F624", Slot = "28")]
		public void HandleCancelled()
		{
		}

		[Token(Token = "0x6004F23")]
		[Address(RVA = "0x93F6D8", Offset = "0x93F6D8", VA = "0x93F6D8", Slot = "26")]
		public void HandleResponse(IResponseContext response)
		{
		}

		[Token(Token = "0x6004F24")]
		[Address(RVA = "0x93F75C", Offset = "0x93F75C", VA = "0x93F75C", Slot = "27")]
		public void HandleError(IResponseContext response)
		{
		}
	}
}
