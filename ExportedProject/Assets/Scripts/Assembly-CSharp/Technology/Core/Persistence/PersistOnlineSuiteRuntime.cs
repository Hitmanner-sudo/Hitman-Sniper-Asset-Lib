using System;
using Il2CppDummyDll;

namespace Technology.Core.Persistence
{
	[Token(Token = "0x2000D39")]
	public class PersistOnlineSuiteRuntime : AbstractFacadePersist<OnlinelSuiteRuntimePersistence>
	{
		[Token(Token = "0x14000155")]
		private static event EventHandler<PersistenceLoadingEvent> _onLoadingSucess
		{
			[Token(Token = "0x6005179")]
			[Address(RVA = "0x903BFC", Offset = "0x903BFC", VA = "0x903BFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629790", Offset = "0x629790")]
			add
			{
			}
			[Token(Token = "0x600517A")]
			[Address(RVA = "0x903CB8", Offset = "0x903CB8", VA = "0x903CB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6297A0", Offset = "0x6297A0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000156")]
		public static event EventHandler<PersistenceLoadingEvent> OnLoadingSuccess
		{
			[Token(Token = "0x600517B")]
			[Address(RVA = "0x903D74", Offset = "0x903D74", VA = "0x903D74")]
			add
			{
			}
			[Token(Token = "0x600517C")]
			[Address(RVA = "0x903EAC", Offset = "0x903EAC", VA = "0x903EAC")]
			remove
			{
			}
		}

		[Token(Token = "0x14000157")]
		private static event EventHandler<PersistenceLoadingEvent> _onLoadingFailure
		{
			[Token(Token = "0x600517D")]
			[Address(RVA = "0x903EB0", Offset = "0x903EB0", VA = "0x903EB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6297B0", Offset = "0x6297B0")]
			add
			{
			}
			[Token(Token = "0x600517E")]
			[Address(RVA = "0x903F70", Offset = "0x903F70", VA = "0x903F70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6297C0", Offset = "0x6297C0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000158")]
		public static event EventHandler<PersistenceLoadingEvent> OnLoadingFailure
		{
			[Token(Token = "0x600517F")]
			[Address(RVA = "0x904030", Offset = "0x904030", VA = "0x904030")]
			add
			{
			}
			[Token(Token = "0x6005180")]
			[Address(RVA = "0x904168", Offset = "0x904168", VA = "0x904168")]
			remove
			{
			}
		}

		[Token(Token = "0x6005181")]
		[Address(RVA = "0x90416C", Offset = "0x90416C", VA = "0x90416C")]
		public static void Propagate(bool clear = false)
		{
		}

		[Token(Token = "0x6005182")]
		[Address(RVA = "0x9042C4", Offset = "0x9042C4", VA = "0x9042C4")]
		public static void PropagateSIDAndUUIDOnly()
		{
		}

		[Token(Token = "0x6005183")]
		[Address(RVA = "0x904418", Offset = "0x904418", VA = "0x904418")]
		private static void PersisterOnSuccess(object sender, PersistenceLoadingEvent persistenceLoadingEvent)
		{
		}

		[Token(Token = "0x6005184")]
		[Address(RVA = "0x904494", Offset = "0x904494", VA = "0x904494")]
		private static void PersisterOnFailure(object sender, PersistenceLoadingEvent persistenceLoadingEvent)
		{
		}

		[Token(Token = "0x6005185")]
		[Address(RVA = "0x904510", Offset = "0x904510", VA = "0x904510")]
		public PersistOnlineSuiteRuntime()
		{
		}
	}
}
