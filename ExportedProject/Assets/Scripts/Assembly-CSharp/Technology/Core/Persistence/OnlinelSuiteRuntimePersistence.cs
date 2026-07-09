using System;
using Il2CppDummyDll;

namespace Technology.Core.Persistence
{
	[Token(Token = "0x2000D27")]
	public class OnlinelSuiteRuntimePersistence : AbstractPersistence
	{
		[Token(Token = "0x4003EE3")]
		[FieldOffset(Offset = "0x28")]
		private bool _isInitialized;

		[Token(Token = "0x6005132")]
		[Address(RVA = "0x9FC878", Offset = "0x9FC878", VA = "0x9FC878")]
		public OnlinelSuiteRuntimePersistence()
		{
		}

		[Token(Token = "0x6005133")]
		[Address(RVA = "0x9FC8F0", Offset = "0x9FC8F0", VA = "0x9FC8F0")]
		public OnlinelSuiteRuntimePersistence(IPersister specificIPersister)
		{
		}

		[Token(Token = "0x6005134")]
		[Address(RVA = "0x9FC8FC", Offset = "0x9FC8FC", VA = "0x9FC8FC")]
		public OnlinelSuiteRuntimePersistence(EventHandler<PersistenceLoadingEvent> onSuccess, EventHandler<PersistenceLoadingEvent> onFailure)
		{
		}

		[Token(Token = "0x6005135")]
		[Address(RVA = "0x9FC994", Offset = "0x9FC994", VA = "0x9FC994")]
		public void Initialize(EventHandler<PersistenceLoadingEvent> onSuccess, EventHandler<PersistenceLoadingEvent> onFailure)
		{
		}

		[Token(Token = "0x6005136")]
		[Address(RVA = "0x9FCA58", Offset = "0x9FCA58", VA = "0x9FCA58", Slot = "5")]
		protected override void Write()
		{
		}

		[Token(Token = "0x6005137")]
		[Address(RVA = "0x9FD4B4", Offset = "0x9FD4B4", VA = "0x9FD4B4", Slot = "6")]
		protected override void Read()
		{
		}

		[Token(Token = "0x6005138")]
		[Address(RVA = "0x9FD704", Offset = "0x9FD704", VA = "0x9FD704")]
		private void OnPersisterReadSuccess(object sender, PersistenceLoadingEvent args)
		{
		}

		[Token(Token = "0x6005139")]
		[Address(RVA = "0x9FD840", Offset = "0x9FD840", VA = "0x9FD840")]
		private void OnPersisterReadFailure(object sender, PersistenceLoadingEvent args)
		{
		}

		[Token(Token = "0x600513A")]
		[Address(RVA = "0x9FD97C", Offset = "0x9FD97C", VA = "0x9FD97C", Slot = "4")]
		protected override void PostLoadFromDictionary()
		{
		}
	}
}
