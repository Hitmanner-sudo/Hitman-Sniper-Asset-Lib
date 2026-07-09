using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000DF9")]
	public class SharedProfile
	{
		[Token(Token = "0x2000DFA")]
		public class SharedProfileEvent : EventArgs
		{
			[Token(Token = "0x400423D")]
			[FieldOffset(Offset = "0x10")]
			public SharedData Data;

			[Token(Token = "0x400423E")]
			[FieldOffset(Offset = "0x18")]
			public string ErrorMessage;

			[Token(Token = "0x60055FD")]
			[Address(RVA = "0x8BC448", Offset = "0x8BC448", VA = "0x8BC448")]
			public SharedProfileEvent(SharedData data, string errMsg)
			{
			}
		}

		[Token(Token = "0x2000DFB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598B2C", Offset = "0x598B2C")]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			[Token(Token = "0x400423F")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpUpdateProfileSharedData svcop;

			[Token(Token = "0x4004240")]
			[FieldOffset(Offset = "0x18")]
			public SharedProfile _003C_003E4__this;

			[Token(Token = "0x4004241")]
			[FieldOffset(Offset = "0x20")]
			public bool overrideValues;

			[Token(Token = "0x4004242")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<string, object> keyValues;

			[Token(Token = "0x60055FE")]
			[Address(RVA = "0x8BC1B4", Offset = "0x8BC1B4", VA = "0x8BC1B4")]
			public _003C_003Ec__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60055FF")]
			[Address(RVA = "0x8BC1BC", Offset = "0x8BC1BC", VA = "0x8BC1BC")]
			internal void _003CSet_003Eb__0()
			{
			}

			[Token(Token = "0x6005600")]
			[Address(RVA = "0x8BC1F4", Offset = "0x8BC1F4", VA = "0x8BC1F4")]
			internal void _003CSet_003Eb__1(IResponseContext responseContext, IRequestContext requestContext, OSRequestState state, Dictionary<string, object> meta)
			{
			}
		}

		[Token(Token = "0x2000DFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598B3C", Offset = "0x598B3C")]
		private sealed class _003C_003Ec__DisplayClass6_0
		{
			[Token(Token = "0x4004243")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpGetProfileSharedData svcop;

			[Token(Token = "0x4004244")]
			[FieldOffset(Offset = "0x18")]
			public SharedProfile _003C_003E4__this;

			[Token(Token = "0x4004245")]
			[FieldOffset(Offset = "0x20")]
			public bool requireDataNode;

			[Token(Token = "0x6005601")]
			[Address(RVA = "0x8BC4C4", Offset = "0x8BC4C4", VA = "0x8BC4C4")]
			public _003C_003Ec__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6005602")]
			[Address(RVA = "0x8BC4CC", Offset = "0x8BC4CC", VA = "0x8BC4CC")]
			internal void _003CGet_003Eb__0()
			{
			}

			[Token(Token = "0x6005603")]
			[Address(RVA = "0x8BC4F8", Offset = "0x8BC4F8", VA = "0x8BC4F8")]
			internal void _003CGet_003Eb__1(IResponseContext responseContext, IRequestContext requestContext, OSRequestState state, Dictionary<string, object> meta)
			{
			}
		}

		[Token(Token = "0x400423C")]
		[FieldOffset(Offset = "0x18")]
		private readonly string _sid;

		[Token(Token = "0x1400016E")]
		public event EventHandler<SharedProfileEvent> OnComplete
		{
			[Token(Token = "0x60055F7")]
			[Address(RVA = "0x83DF98", Offset = "0x83DF98", VA = "0x83DF98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B140", Offset = "0x62B140")]
			add
			{
			}
			[Token(Token = "0x60055F8")]
			[Address(RVA = "0x83E038", Offset = "0x83E038", VA = "0x83E038")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B150", Offset = "0x62B150")]
			remove
			{
			}
		}

		[Token(Token = "0x60055F9")]
		[Address(RVA = "0x83E0D8", Offset = "0x83E0D8", VA = "0x83E0D8")]
		public SharedProfile(string sid)
		{
		}

		[Token(Token = "0x60055FA")]
		[Address(RVA = "0x83E104", Offset = "0x83E104", VA = "0x83E104")]
		public void Set(Dictionary<string, object> keyValues, bool overrideValues)
		{
		}

		[Token(Token = "0x60055FB")]
		[Address(RVA = "0x83E2AC", Offset = "0x83E2AC", VA = "0x83E2AC")]
		public void Get(bool requireDataNode = true)
		{
		}

		[Token(Token = "0x60055FC")]
		[Address(RVA = "0x83E450", Offset = "0x83E450", VA = "0x83E450")]
		private JSONNode ProcessDefault(IResponseContext responseContext, IRequestContext requestContext, OSRequestState state, Dictionary<string, object> meta)
		{
			return null;
		}
	}
}
