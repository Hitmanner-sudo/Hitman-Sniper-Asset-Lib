using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000D0D")]
	internal class OSRequest : IOSCommunication
	{
		[Token(Token = "0x2000D0E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5987EC", Offset = "0x5987EC")]
		private sealed class _003C_003Ec__DisplayClass17_0
		{
			[Token(Token = "0x4003E85")]
			[FieldOffset(Offset = "0x10")]
			public OSRequest _003C_003E4__this;

			[Token(Token = "0x4003E86")]
			[FieldOffset(Offset = "0x18")]
			public IRequestContext request;

			[Token(Token = "0x60050AF")]
			[Address(RVA = "0x8CCB7C", Offset = "0x8CCB7C", VA = "0x8CCB7C")]
			public _003C_003Ec__DisplayClass17_0()
			{
			}

			[Token(Token = "0x60050B0")]
			[Address(RVA = "0x8CCB84", Offset = "0x8CCB84", VA = "0x8CCB84")]
			internal OSResponse _003CSvcOpOnOnAsyncCancelled_003Eb__0()
			{
				return null;
			}
		}

		[Token(Token = "0x2000D0F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5987FC", Offset = "0x5987FC")]
		private sealed class _003C_003Ec__DisplayClass18_0
		{
			[Token(Token = "0x4003E87")]
			[FieldOffset(Offset = "0x10")]
			public OSRequest _003C_003E4__this;

			[Token(Token = "0x4003E88")]
			[FieldOffset(Offset = "0x18")]
			public IRequestContext request;

			[Token(Token = "0x4003E89")]
			[FieldOffset(Offset = "0x20")]
			public IResponseContext response;

			[Token(Token = "0x60050B1")]
			[Address(RVA = "0x8CCBD4", Offset = "0x8CCBD4", VA = "0x8CCBD4")]
			public _003C_003Ec__DisplayClass18_0()
			{
			}

			[Token(Token = "0x60050B2")]
			[Address(RVA = "0x8CCBDC", Offset = "0x8CCBDC", VA = "0x8CCBDC")]
			internal OSResponse _003CSvcOpOnOnAsyncError_003Eb__0()
			{
				return null;
			}
		}

		[Token(Token = "0x2000D10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59880C", Offset = "0x59880C")]
		private sealed class _003C_003Ec__DisplayClass19_0
		{
			[Token(Token = "0x4003E8A")]
			[FieldOffset(Offset = "0x10")]
			public OSRequest _003C_003E4__this;

			[Token(Token = "0x4003E8B")]
			[FieldOffset(Offset = "0x18")]
			public IResponseContext response;

			[Token(Token = "0x60050B3")]
			[Address(RVA = "0x8CCC44", Offset = "0x8CCC44", VA = "0x8CCC44")]
			public _003C_003Ec__DisplayClass19_0()
			{
			}

			[Token(Token = "0x60050B4")]
			[Address(RVA = "0x8CCC4C", Offset = "0x8CCC4C", VA = "0x8CCC4C")]
			internal OSResponse _003CSvcOpOnOnAysncComplete_003Eb__0()
			{
				return null;
			}
		}

		[Token(Token = "0x4003E82")]
		[FieldOffset(Offset = "0x28")]
		private readonly SvcOp _svcOp;

		[Token(Token = "0x4003E83")]
		[FieldOffset(Offset = "0x30")]
		private readonly Action _runAction;

		[Token(Token = "0x4003E84")]
		[FieldOffset(Offset = "0x38")]
		private readonly OSResponse _osResponse;

		[Token(Token = "0x17000AA9")]
		public SvcOp ServiceOperation
		{
			[Token(Token = "0x60050A7")]
			[Address(RVA = "0x9E8CB0", Offset = "0x9E8CB0", VA = "0x9E8CB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000150")]
		public event EventHandler<OSResponse> OnComplete
		{
			[Token(Token = "0x60050A1")]
			[Address(RVA = "0x9E88F0", Offset = "0x9E88F0", VA = "0x9E88F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629580", Offset = "0x629580")]
			add
			{
			}
			[Token(Token = "0x60050A2")]
			[Address(RVA = "0x9E8990", Offset = "0x9E8990", VA = "0x9E8990")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629590", Offset = "0x629590")]
			remove
			{
			}
		}

		[Token(Token = "0x14000151")]
		public event EventHandler<OSResponse> OnError
		{
			[Token(Token = "0x60050A3")]
			[Address(RVA = "0x9E8A30", Offset = "0x9E8A30", VA = "0x9E8A30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6295A0", Offset = "0x6295A0")]
			add
			{
			}
			[Token(Token = "0x60050A4")]
			[Address(RVA = "0x9E8AD0", Offset = "0x9E8AD0", VA = "0x9E8AD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6295B0", Offset = "0x6295B0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000152")]
		public event EventHandler<OSResponse> OnCancelled
		{
			[Token(Token = "0x60050A5")]
			[Address(RVA = "0x9E8B70", Offset = "0x9E8B70", VA = "0x9E8B70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6295C0", Offset = "0x6295C0")]
			add
			{
			}
			[Token(Token = "0x60050A6")]
			[Address(RVA = "0x9E8C10", Offset = "0x9E8C10", VA = "0x9E8C10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6295D0", Offset = "0x6295D0")]
			remove
			{
			}
		}

		[Token(Token = "0x60050A8")]
		[Address(RVA = "0x9E8CB8", Offset = "0x9E8CB8", VA = "0x9E8CB8")]
		private OSRequest()
		{
		}

		[Token(Token = "0x60050A9")]
		[Address(RVA = "0x9E8CC0", Offset = "0x9E8CC0", VA = "0x9E8CC0")]
		internal OSRequest(SvcOp svcOp, Action runAction, Action<IResponseContext, IRequestContext, OSRequestState, Dictionary<string, object>> subscriberAction, Dictionary<string, object> additionalRequestMeta)
		{
		}

		[Token(Token = "0x60050AA")]
		[Address(RVA = "0x9E8DBC", Offset = "0x9E8DBC", VA = "0x9E8DBC", Slot = "4")]
		public void Run()
		{
		}

		[Token(Token = "0x60050AB")]
		[Address(RVA = "0x9E8F18", Offset = "0x9E8F18", VA = "0x9E8F18")]
		private void SvcOpOnOnAsyncCancelled(IRequestContext request)
		{
		}

		[Token(Token = "0x60050AC")]
		[Address(RVA = "0x9E915C", Offset = "0x9E915C", VA = "0x9E915C")]
		private void SvcOpOnOnAsyncError(IRequestContext request, IResponseContext response)
		{
		}

		[Token(Token = "0x60050AD")]
		[Address(RVA = "0x9E925C", Offset = "0x9E925C", VA = "0x9E925C")]
		private void SvcOpOnOnAysncComplete(IResponseContext response)
		{
		}

		[Token(Token = "0x60050AE")]
		[Address(RVA = "0x9E9010", Offset = "0x9E9010", VA = "0x9E9010")]
		private void RemoveEvents()
		{
		}
	}
}
