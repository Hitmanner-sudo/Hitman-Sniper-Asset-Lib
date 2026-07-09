using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CB8")]
	public struct GetRequestContext : IGetRequestContext, IRequestContext
	{
		[Token(Token = "0x4003D8F")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BDFB4", Offset = "0x5BDFB4")]
		private uint _003CStatusCode_003Ek__BackingField;

		[Token(Token = "0x4003D90")]
		[FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BDFC4", Offset = "0x5BDFC4")]
		private string _003CStatusMessage_003Ek__BackingField;

		[Token(Token = "0x4003D91")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BDFD4", Offset = "0x5BDFD4")]
		private string _003CUrl_003Ek__BackingField;

		[Token(Token = "0x4003D92")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BDFE4", Offset = "0x5BDFE4")]
		private TransportProtocolClient.Verb _003CTransportVerb_003Ek__BackingField;

		[Token(Token = "0x4003D93")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BDFF4", Offset = "0x5BDFF4")]
		private string _003CQueryString_003Ek__BackingField;

		[Token(Token = "0x4003D94")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE004", Offset = "0x5BE004")]
		private SvcOpHeader _003CHeader_003Ek__BackingField;

		[Token(Token = "0x4003D95")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE014", Offset = "0x5BE014")]
		private Action<IResponseContext> _003CResponseAction_003Ek__BackingField;

		[Token(Token = "0x4003D96")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE024", Offset = "0x5BE024")]
		private bool _003CIsAsyncMode_003Ek__BackingField;

		[Token(Token = "0x4003D97")]
		[FieldOffset(Offset = "0x39")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE034", Offset = "0x5BE034")]
		private bool _003CVerbose_003Ek__BackingField;

		[Token(Token = "0x4003D98")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE044", Offset = "0x5BE044")]
		private SvcOp _003CRequestingServiceOperation_003Ek__BackingField;

		[Token(Token = "0x17000A3A")]
		public uint StatusCode
		{
			[Token(Token = "0x6004ECE")]
			[Address(RVA = "0x1068804", Offset = "0x1068804", VA = "0x1068804", Slot = "6")]
			[System.Runtime.CompilerServices.IsReadOnly]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628B70", Offset = "0x628B70")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6004ECF")]
			[Address(RVA = "0x106880C", Offset = "0x106880C", VA = "0x106880C", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628BA8", Offset = "0x628BA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000A3B")]
		public string StatusMessage
		{
			[Token(Token = "0x6004ED0")]
			[Address(RVA = "0x1068814", Offset = "0x1068814", VA = "0x1068814", Slot = "8")]
			[System.Runtime.CompilerServices.IsReadOnly]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628BB8", Offset = "0x628BB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004ED1")]
			[Address(RVA = "0x106881C", Offset = "0x106881C", VA = "0x106881C", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628BF0", Offset = "0x628BF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000A3C")]
		public string Url
		{
			[Token(Token = "0x6004ED2")]
			[Address(RVA = "0x1068824", Offset = "0x1068824", VA = "0x1068824", Slot = "10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628C00", Offset = "0x628C00")]
			[System.Runtime.CompilerServices.IsReadOnly]
			get
			{
				return null;
			}
			[Token(Token = "0x6004ED3")]
			[Address(RVA = "0x106882C", Offset = "0x106882C", VA = "0x106882C", Slot = "11")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628C38", Offset = "0x628C38")]
			set
			{
			}
		}

		[Token(Token = "0x17000A3D")]
		public TransportProtocolClient.Verb TransportVerb
		{
			[Token(Token = "0x6004ED4")]
			[Address(RVA = "0x1068834", Offset = "0x1068834", VA = "0x1068834", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628C48", Offset = "0x628C48")]
			[System.Runtime.CompilerServices.IsReadOnly]
			get
			{
				return default(TransportProtocolClient.Verb);
			}
			[Token(Token = "0x6004ED5")]
			[Address(RVA = "0x106883C", Offset = "0x106883C", VA = "0x106883C", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628C80", Offset = "0x628C80")]
			set
			{
			}
		}

		[Token(Token = "0x17000A3E")]
		public string QueryString
		{
			[Token(Token = "0x6004ED6")]
			[Address(RVA = "0x1068844", Offset = "0x1068844", VA = "0x1068844", Slot = "12")]
			[System.Runtime.CompilerServices.IsReadOnly]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628C90", Offset = "0x628C90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004ED7")]
			[Address(RVA = "0x106884C", Offset = "0x106884C", VA = "0x106884C", Slot = "13")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628CC8", Offset = "0x628CC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000A3F")]
		public SvcOpHeader Header
		{
			[Token(Token = "0x6004ED8")]
			[Address(RVA = "0x1068854", Offset = "0x1068854", VA = "0x1068854", Slot = "14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628CD8", Offset = "0x628CD8")]
			[System.Runtime.CompilerServices.IsReadOnly]
			get
			{
				return null;
			}
			[Token(Token = "0x6004ED9")]
			[Address(RVA = "0x106885C", Offset = "0x106885C", VA = "0x106885C", Slot = "15")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628D10", Offset = "0x628D10")]
			set
			{
			}
		}

		[Token(Token = "0x17000A40")]
		public Action<IResponseContext> ResponseAction
		{
			[Token(Token = "0x6004EDA")]
			[Address(RVA = "0x1068864", Offset = "0x1068864", VA = "0x1068864", Slot = "16")]
			[System.Runtime.CompilerServices.IsReadOnly]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628D20", Offset = "0x628D20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004EDB")]
			[Address(RVA = "0x106886C", Offset = "0x106886C", VA = "0x106886C", Slot = "17")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628D58", Offset = "0x628D58")]
			set
			{
			}
		}

		[Token(Token = "0x17000A41")]
		public bool IsAsyncMode
		{
			[Token(Token = "0x6004EDC")]
			[Address(RVA = "0x1068874", Offset = "0x1068874", VA = "0x1068874", Slot = "18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628D68", Offset = "0x628D68")]
			[System.Runtime.CompilerServices.IsReadOnly]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004EDD")]
			[Address(RVA = "0x106887C", Offset = "0x106887C", VA = "0x106887C", Slot = "19")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628DA0", Offset = "0x628DA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000A42")]
		public bool Verbose
		{
			[Token(Token = "0x6004EDE")]
			[Address(RVA = "0x1068888", Offset = "0x1068888", VA = "0x1068888", Slot = "20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628DB0", Offset = "0x628DB0")]
			[System.Runtime.CompilerServices.IsReadOnly]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004EDF")]
			[Address(RVA = "0x1068890", Offset = "0x1068890", VA = "0x1068890", Slot = "21")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628DE8", Offset = "0x628DE8")]
			set
			{
			}
		}

		[Token(Token = "0x17000A43")]
		public SvcOp RequestingServiceOperation
		{
			[Token(Token = "0x6004EE0")]
			[Address(RVA = "0x106889C", Offset = "0x106889C", VA = "0x106889C", Slot = "22")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628DF8", Offset = "0x628DF8")]
			[System.Runtime.CompilerServices.IsReadOnly]
			get
			{
				return null;
			}
			[Token(Token = "0x6004EE1")]
			[Address(RVA = "0x10688A4", Offset = "0x10688A4", VA = "0x10688A4", Slot = "23")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628E30", Offset = "0x628E30")]
			set
			{
			}
		}

		[Token(Token = "0x6004EE2")]
		[Address(RVA = "0x10688AC", Offset = "0x10688AC", VA = "0x10688AC", Slot = "26")]
		public void HandleCancelled()
		{
		}

		[Token(Token = "0x6004EE3")]
		[Address(RVA = "0x1068960", Offset = "0x1068960", VA = "0x1068960", Slot = "24")]
		public void HandleResponse(IResponseContext response)
		{
		}

		[Token(Token = "0x6004EE4")]
		[Address(RVA = "0x10689E4", Offset = "0x10689E4", VA = "0x10689E4", Slot = "25")]
		public void HandleError(IResponseContext response)
		{
		}
	}
}
