using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core
{
	[Token(Token = "0x2000C7F")]
	public static class TransportMail
	{
		[Token(Token = "0x2000C80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5986F0", Offset = "0x5986F0")]
		private sealed class _003C_003Ec__DisplayClass0_0
		{
			[Token(Token = "0x4003D0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<bool, List<Message>> subscriberAction;

			[Token(Token = "0x6004DEC")]
			[Address(RVA = "0xA389A4", Offset = "0xA389A4", VA = "0xA389A4")]
			public _003C_003Ec__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6004DED")]
			[Address(RVA = "0xA389AC", Offset = "0xA389AC", VA = "0xA389AC")]
			internal void _003CReceive_003Eb__0(IResponseContext responseContext, IRequestContext requestContext, OSRequestState state, Dictionary<string, object> meta)
			{
			}
		}

		[Token(Token = "0x2000C81")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598700", Offset = "0x598700")]
		private sealed class _003C_003Ec__DisplayClass0_1
		{
			[Token(Token = "0x4003D0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SvcOpGetAllValidUserMailMessages svcOpValid;

			[Token(Token = "0x6004DEE")]
			[Address(RVA = "0xA38AB4", Offset = "0xA38AB4", VA = "0xA38AB4")]
			public _003C_003Ec__DisplayClass0_1()
			{
			}

			[Token(Token = "0x6004DEF")]
			[Address(RVA = "0xA38ABC", Offset = "0xA38ABC", VA = "0xA38ABC")]
			internal void _003CReceive_003Eb__1()
			{
			}
		}

		[Token(Token = "0x2000C82")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598710", Offset = "0x598710")]
		private sealed class _003C_003Ec__DisplayClass0_2
		{
			[Token(Token = "0x4003D0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SvcOpGetAllUserMailMessages svcOpAll;

			[Token(Token = "0x6004DF0")]
			[Address(RVA = "0xA38B14", Offset = "0xA38B14", VA = "0xA38B14")]
			public _003C_003Ec__DisplayClass0_2()
			{
			}

			[Token(Token = "0x6004DF1")]
			[Address(RVA = "0xA38B1C", Offset = "0xA38B1C", VA = "0xA38B1C")]
			internal void _003CReceive_003Eb__2()
			{
			}
		}

		[Token(Token = "0x2000C83")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598720", Offset = "0x598720")]
		private sealed class _003C_003Ec__DisplayClass1_0
		{
			[Token(Token = "0x4003D10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SvcOpSendMailMessage svcOp;

			[Token(Token = "0x4003D11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Message message;

			[Token(Token = "0x4003D12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<bool, IResponseContext> subscriberAction;

			[Token(Token = "0x6004DF2")]
			[Address(RVA = "0xA38B74", Offset = "0xA38B74", VA = "0xA38B74")]
			public _003C_003Ec__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6004DF3")]
			[Address(RVA = "0xA38B7C", Offset = "0xA38B7C", VA = "0xA38B7C")]
			internal void _003CSend_003Eb__0()
			{
			}

			[Token(Token = "0x6004DF4")]
			[Address(RVA = "0xA38BC8", Offset = "0xA38BC8", VA = "0xA38BC8")]
			internal void _003CSend_003Eb__1(IResponseContext responseContext, IRequestContext requestContext, OSRequestState state, Dictionary<string, object> meta)
			{
			}
		}

		[Token(Token = "0x2000C84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598730", Offset = "0x598730")]
		private sealed class _003C_003Ec__DisplayClass2_0
		{
			[Token(Token = "0x4003D13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SvcOpSetMailMessageState svcOp;

			[Token(Token = "0x4003D14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Message message;

			[Token(Token = "0x4003D15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string messageState;

			[Token(Token = "0x4003D16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action action;

			[Token(Token = "0x6004DF5")]
			[Address(RVA = "0xA38C3C", Offset = "0xA38C3C", VA = "0xA38C3C")]
			public _003C_003Ec__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6004DF6")]
			[Address(RVA = "0xA38C44", Offset = "0xA38C44", VA = "0xA38C44")]
			internal void _003CSetMessageState_003Eb__0()
			{
			}

			[Token(Token = "0x6004DF7")]
			[Address(RVA = "0xA38C7C", Offset = "0xA38C7C", VA = "0xA38C7C")]
			internal void _003CSetMessageState_003Eb__1(IResponseContext responseContext, IRequestContext requestContext, OSRequestState state, Dictionary<string, object> meta)
			{
			}
		}

		[Token(Token = "0x6004DE8")]
		[Address(RVA = "0xC98110", Offset = "0xC98110", VA = "0xC98110")]
		public static void Receive([Optional] Action<bool, List<Message>> subscriberAction, bool onlyValid = true)
		{
		}

		[Token(Token = "0x6004DE9")]
		[Address(RVA = "0xC9835C", Offset = "0xC9835C", VA = "0xC9835C")]
		public static void Send(Message message, Action<bool, IResponseContext> subscriberAction)
		{
		}

		[Token(Token = "0x6004DEA")]
		[Address(RVA = "0xC984F8", Offset = "0xC984F8", VA = "0xC984F8")]
		public static void SetMessageState(Message message, string messageState, [Optional] Action action)
		{
		}

		[Token(Token = "0x6004DEB")]
		[Address(RVA = "0xC9869C", Offset = "0xC9869C", VA = "0xC9869C")]
		private static void ProcessMessageJSONResponse(string body, [Optional] Action<bool, List<Message>> subscriberAction)
		{
		}
	}
}
