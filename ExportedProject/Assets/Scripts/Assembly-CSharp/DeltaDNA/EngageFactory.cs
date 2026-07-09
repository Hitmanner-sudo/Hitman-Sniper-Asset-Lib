using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x20012F6")]
	public class EngageFactory
	{
		[Token(Token = "0x20012F7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE784", Offset = "0x5AE784")]
		private sealed class _003C_003Ec__DisplayClass3_0
		{
			[Token(Token = "0x4005AFD")]
			[FieldOffset(Offset = "0x10")]
			public Action<Dictionary<string, object>> callback;

			[Token(Token = "0x6006F5C")]
			[Address(RVA = "0x86E7DC", Offset = "0x86E7DC", VA = "0x86E7DC")]
			public _003C_003Ec__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6006F5D")]
			[Address(RVA = "0x86E7E4", Offset = "0x86E7E4", VA = "0x86E7E4")]
			internal void _003CRequestGameParameters_003Eb__0(Engagement response)
			{
			}

			[Token(Token = "0x6006F5E")]
			[Address(RVA = "0x86E948", Offset = "0x86E948", VA = "0x86E948")]
			internal void _003CRequestGameParameters_003Eb__1(Exception exception)
			{
			}
		}

		[Token(Token = "0x20012F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE794", Offset = "0x5AE794")]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			[Token(Token = "0x4005AFE")]
			[FieldOffset(Offset = "0x10")]
			public Action<ImageMessage> callback;

			[Token(Token = "0x6006F5F")]
			[Address(RVA = "0x86E9E0", Offset = "0x86E9E0", VA = "0x86E9E0")]
			public _003C_003Ec__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6006F60")]
			[Address(RVA = "0x86E9E8", Offset = "0x86E9E8", VA = "0x86E9E8")]
			internal void _003CRequestImageMessage_003Eb__0(Engagement response)
			{
			}

			[Token(Token = "0x6006F61")]
			[Address(RVA = "0x86EA5C", Offset = "0x86EA5C", VA = "0x86EA5C")]
			internal void _003CRequestImageMessage_003Eb__1(Exception exception)
			{
			}
		}

		[Token(Token = "0x4005AFC")]
		[FieldOffset(Offset = "0x10")]
		private readonly DDNABase ddna;

		[Token(Token = "0x6006F56")]
		[Address(RVA = "0xE145D4", Offset = "0xE145D4", VA = "0xE145D4")]
		internal EngageFactory(DDNABase ddna)
		{
		}

		[Token(Token = "0x6006F57")]
		[Address(RVA = "0xE14600", Offset = "0xE14600", VA = "0xE14600")]
		public void RequestGameParameters(string decisionPoint, Action<Dictionary<string, object>> callback)
		{
		}

		[Token(Token = "0x6006F58")]
		[Address(RVA = "0xE1460C", Offset = "0xE1460C", VA = "0xE1460C")]
		public void RequestGameParameters(string decisionPoint, Params parameters, Action<Dictionary<string, object>> callback)
		{
		}

		[Token(Token = "0x6006F59")]
		[Address(RVA = "0xE148BC", Offset = "0xE148BC", VA = "0xE148BC")]
		public void RequestImageMessage(string decisionPoint, Action<ImageMessage> callback)
		{
		}

		[Token(Token = "0x6006F5A")]
		[Address(RVA = "0xE148C8", Offset = "0xE148C8", VA = "0xE148C8")]
		public void RequestImageMessage(string decisionPoint, Params parameters, Action<ImageMessage> callback)
		{
		}

		[Token(Token = "0x6006F5B")]
		[Address(RVA = "0xE14774", Offset = "0xE14774", VA = "0xE14774")]
		protected static Engagement BuildEngagement(string decisionPoint, Params parameters)
		{
			return null;
		}
	}
}
