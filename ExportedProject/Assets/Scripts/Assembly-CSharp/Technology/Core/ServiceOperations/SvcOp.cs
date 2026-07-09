using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000D04")]
	public abstract class SvcOp
	{
		[Token(Token = "0x2000D05")]
		private class RunParams
		{
			[Token(Token = "0x4003E69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IRequestContext RequestContext;

			[Token(Token = "0x4003E6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool Verbose;

			[Token(Token = "0x6005078")]
			[Address(RVA = "0xA53824", Offset = "0xA53824", VA = "0xA53824")]
			public RunParams(IRequestContext context, bool verbose)
			{
			}
		}

		[Token(Token = "0x4003E59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE264", Offset = "0x5BE264")]
		private byte _003CRetryAttempts_003Ek__BackingField;

		[Token(Token = "0x4003E5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool Verbose;

		[Token(Token = "0x4003E5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE274", Offset = "0x5BE274")]
		private bool _003CIsAsyncMode_003Ek__BackingField;

		[Token(Token = "0x4003E5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE284", Offset = "0x5BE284")]
		private bool _003CIsThreaded_003Ek__BackingField;

		[Token(Token = "0x4003E5D")]
		protected const int NOT_REQUIRED_LONG = -1;

		[Token(Token = "0x4003E5E")]
		protected const int NOT_REQUIRED_SBYTE = -1;

		[Token(Token = "0x4003E5F")]
		protected const int NOT_REQUIRED_INT = -1;

		[Token(Token = "0x4003E60")]
		protected const string[] NOT_REQUIRED_ARRAY_STRING = null;

		[Token(Token = "0x4003E61")]
		protected const int[] NOT_REQUIRED_ARRAY_INT = null;

		[Token(Token = "0x4003E62")]
		protected const byte[] NOT_REQUIRED_ARRAY_BYTE = null;

		[Token(Token = "0x4003E63")]
		protected const KeyValuePair<string, sbyte>[] NOT_REQUIRED_STRING_SBTYE_PAIRS = null;

		[Token(Token = "0x4003E64")]
		protected const KeyValuePair<string, string>[] NOT_REQUIRED_STRING_STRING_PAIRS = null;

		[Token(Token = "0x4003E65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Action<IResponseContext> _responseAction;

		[Token(Token = "0x4003E66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string _response;

		[Token(Token = "0x4003E67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static EventWaitHandle _responseWaitHandle;

		[Token(Token = "0x4003E68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SvcOpHeader _header;

		[Token(Token = "0x17000A95")]
		public SvcOpHeader Header
		{
			[Token(Token = "0x6005053")]
			[Address(RVA = "0xD31250", Offset = "0xD31250", VA = "0xD31250")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005054")]
			[Address(RVA = "0xD31258", Offset = "0xD31258", VA = "0xD31258")]
			set
			{
			}
		}

		[Token(Token = "0x17000A96")]
		public string Id
		{
			[Token(Token = "0x6005055")]
			[Address(RVA = "0xD31260", Offset = "0xD31260", VA = "0xD31260")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A97")]
		public byte RetryAttempts
		{
			[Token(Token = "0x6005056")]
			[Address(RVA = "0xD312C4", Offset = "0xD312C4", VA = "0xD312C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6294A0", Offset = "0x6294A0")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x6005057")]
			[Address(RVA = "0xD312CC", Offset = "0xD312CC", VA = "0xD312CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6294B0", Offset = "0x6294B0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000A98")]
		public abstract string SvcOpCmd
		{
			[Token(Token = "0x6005058")]
			get;
		}

		[Token(Token = "0x17000A99")]
		public bool IsAsyncMode
		{
			[Token(Token = "0x6005059")]
			[Address(RVA = "0xD312D4", Offset = "0xD312D4", VA = "0xD312D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6294C0", Offset = "0x6294C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600505A")]
			[Address(RVA = "0xD312DC", Offset = "0xD312DC", VA = "0xD312DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6294D0", Offset = "0x6294D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000A9A")]
		public bool IsThreaded
		{
			[Token(Token = "0x600505B")]
			[Address(RVA = "0xD312E8", Offset = "0xD312E8", VA = "0xD312E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6294E0", Offset = "0x6294E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600505C")]
			[Address(RVA = "0xD312F0", Offset = "0xD312F0", VA = "0xD312F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6294F0", Offset = "0x6294F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000A9B")]
		public bool RequiresAuthentication
		{
			[Token(Token = "0x600505D")]
			[Address(RVA = "0xD312FC", Offset = "0xD312FC", VA = "0xD312FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000A9C")]
		public static bool IsAuthenticated
		{
			[Token(Token = "0x600505E")]
			[Address(RVA = "0xD3139C", Offset = "0xD3139C", VA = "0xD3139C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000A9D")]
		public virtual List<HttpStatusCode> AcceptableNonSuccessCodes
		{
			[Token(Token = "0x600505F")]
			[Address(RVA = "0xD31448", Offset = "0xD31448", VA = "0xD31448", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A9E")]
		protected abstract string SvcOpCmdQueryString
		{
			[Token(Token = "0x6005060")]
			get;
			[Token(Token = "0x6005061")]
			set;
		}

		[Token(Token = "0x17000A9F")]
		protected SvcOpHeaderOnlineSuite HeaderOS
		{
			[Token(Token = "0x6005062")]
			[Address(RVA = "0xD3131C", Offset = "0xD3131C", VA = "0xD3131C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AA0")]
		protected virtual bool SkipOSFailureCheck
		{
			[Token(Token = "0x6005063")]
			[Address(RVA = "0xD31450", Offset = "0xD31450", VA = "0xD31450", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1400014D")]
		public event SvcOpResponseContextEventHandler OnAysncComplete
		{
			[Token(Token = "0x600504D")]
			[Address(RVA = "0xD30E90", Offset = "0xD30E90", VA = "0xD30E90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629440", Offset = "0x629440")]
			add
			{
			}
			[Token(Token = "0x600504E")]
			[Address(RVA = "0xD30F30", Offset = "0xD30F30", VA = "0xD30F30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629450", Offset = "0x629450")]
			remove
			{
			}
		}

		[Token(Token = "0x1400014E")]
		public event SvcOpResponseRequestContextEventHandler OnAsyncError
		{
			[Token(Token = "0x600504F")]
			[Address(RVA = "0xD30FD0", Offset = "0xD30FD0", VA = "0xD30FD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629460", Offset = "0x629460")]
			add
			{
			}
			[Token(Token = "0x6005050")]
			[Address(RVA = "0xD31070", Offset = "0xD31070", VA = "0xD31070")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629470", Offset = "0x629470")]
			remove
			{
			}
		}

		[Token(Token = "0x1400014F")]
		public event SvcOpRequestContextEventHandler OnAsyncCancelled
		{
			[Token(Token = "0x6005051")]
			[Address(RVA = "0xD31110", Offset = "0xD31110", VA = "0xD31110")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629480", Offset = "0x629480")]
			add
			{
			}
			[Token(Token = "0x6005052")]
			[Address(RVA = "0xD311B0", Offset = "0xD311B0", VA = "0xD311B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629490", Offset = "0x629490")]
			remove
			{
			}
		}

		[Token(Token = "0x6005064")]
		[Address(RVA = "0xD31458", Offset = "0xD31458", VA = "0xD31458")]
		protected SvcOp(bool requiresAuthentication, [Optional] Action<IResponseContext> responseAction, bool requiresEditorToken = false)
		{
		}

		[Token(Token = "0x6005065")]
		[Address(RVA = "0xD3179C", Offset = "0xD3179C", VA = "0xD3179C")]
		public void HandleError(IRequestContext requestContext, IResponseContext responseContext)
		{
		}

		[Token(Token = "0x6005066")]
		[Address(RVA = "0xD323C4", Offset = "0xD323C4", VA = "0xD323C4")]
		public void HandleResponse(IResponseContext response)
		{
		}

		[Token(Token = "0x6005067")]
		[Address(RVA = "0xD3284C", Offset = "0xD3284C", VA = "0xD3284C")]
		public void HandleCancelled(IRequestContext requestContext)
		{
		}

		[Token(Token = "0x6005068")]
		[Address(RVA = "0xD32D08", Offset = "0xD32D08", VA = "0xD32D08")]
		public Dictionary<string, string> GetQueryStringParameters()
		{
			return null;
		}

		[Token(Token = "0x6005069")]
		[Address(RVA = "0xD32EF4", Offset = "0xD32EF4", VA = "0xD32EF4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600506A")]
		[Address(RVA = "0xD332A4", Offset = "0xD332A4", VA = "0xD332A4")]
		public static string WaitForQuery(SvcOp svcOp)
		{
			return null;
		}

		[Token(Token = "0x600506B")]
		[Address(RVA = "0xD31F30", Offset = "0xD31F30", VA = "0xD31F30")]
		protected void Execute(GetRequestContext requestContext)
		{
		}

		[Token(Token = "0x600506C")]
		[Address(RVA = "0xD31FB0", Offset = "0xD31FB0", VA = "0xD31FB0")]
		protected void Execute(PostRequestContext requestContext)
		{
		}

		[Token(Token = "0x600506D")]
		[Address(RVA = "0xD33840", Offset = "0xD33840", VA = "0xD33840", Slot = "9")]
		public virtual void GenerateNewSessionId()
		{
		}

		[Token(Token = "0x600506E")]
		[Address(RVA = "0xD31B88", Offset = "0xD31B88", VA = "0xD31B88")]
		private void SetOSToken(IResponseContext response)
		{
		}

		[Token(Token = "0x600506F")]
		[Address(RVA = "0xD33450", Offset = "0xD33450", VA = "0xD33450")]
		private void Execute(IRequestContext requestContext)
		{
		}

		[Token(Token = "0x6005070")]
		[Address(RVA = "0xD33A98", Offset = "0xD33A98", VA = "0xD33A98")]
		private static void Run(object data)
		{
		}

		[Token(Token = "0x6005071")]
		[Address(RVA = "0xD33338", Offset = "0xD33338", VA = "0xD33338")]
		private static void AddEvents(SvcOp svcOp)
		{
		}

		[Token(Token = "0x6005072")]
		[Address(RVA = "0xD33DC8", Offset = "0xD33DC8", VA = "0xD33DC8")]
		private static void RemoveEvents(SvcOp svcOp)
		{
		}

		[Token(Token = "0x6005073")]
		[Address(RVA = "0xD33EE0", Offset = "0xD33EE0", VA = "0xD33EE0")]
		private static void OpOnAysncComplete(IResponseContext context)
		{
		}

		[Token(Token = "0x6005074")]
		[Address(RVA = "0xD34054", Offset = "0xD34054", VA = "0xD34054")]
		private static void OpOnAysncError(IRequestContext requestContext, IResponseContext responseContext)
		{
		}

		[Token(Token = "0x6005075")]
		[Address(RVA = "0xD341C8", Offset = "0xD341C8", VA = "0xD341C8")]
		private static void OpOnAsyncCancelled(IRequestContext requestContext)
		{
		}

		[Token(Token = "0x6005076")]
		[Address(RVA = "0xD339AC", Offset = "0xD339AC", VA = "0xD339AC")]
		private static void ThrowError(IRequestContext context, string message)
		{
		}
	}
}
