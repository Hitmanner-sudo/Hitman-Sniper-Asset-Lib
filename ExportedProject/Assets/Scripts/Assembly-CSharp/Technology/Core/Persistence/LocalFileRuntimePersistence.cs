using Il2CppDummyDll;

namespace Technology.Core.Persistence
{
	[Token(Token = "0x2000D28")]
	public class LocalFileRuntimePersistence : AbstractPersistence
	{
		[Token(Token = "0x14000153")]
		private event SaveGameIsCorruptEvent _saveGameIsCorrupt
		{
			[Token(Token = "0x600513B")]
			[Address(RVA = "0x9D4D3C", Offset = "0x9D4D3C", VA = "0x9D4D3C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x629690", Offset = "0x629690")]
			add
			{
			}
			[Token(Token = "0x600513C")]
			[Address(RVA = "0x9D4DDC", Offset = "0x9D4DDC", VA = "0x9D4DDC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6296A0", Offset = "0x6296A0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000154")]
		public event SaveGameIsCorruptEvent SaveGameIsCorrupt
		{
			[Token(Token = "0x600513D")]
			[Address(RVA = "0x9D4E7C", Offset = "0x9D4E7C", VA = "0x9D4E7C")]
			add
			{
			}
			[Token(Token = "0x600513E")]
			[Address(RVA = "0x9D4E80", Offset = "0x9D4E80", VA = "0x9D4E80")]
			remove
			{
			}
		}

		[Token(Token = "0x600513F")]
		[Address(RVA = "0x9D4D30", Offset = "0x9D4D30", VA = "0x9D4D30")]
		internal LocalFileRuntimePersistence(IPersister persister)
		{
		}

		[Token(Token = "0x6005140")]
		[Address(RVA = "0x9D4E84", Offset = "0x9D4E84", VA = "0x9D4E84")]
		public LocalFileRuntimePersistence()
		{
		}

		[Token(Token = "0x6005141")]
		[Address(RVA = "0x9D4F40", Offset = "0x9D4F40", VA = "0x9D4F40", Slot = "5")]
		protected override void Write()
		{
		}

		[Token(Token = "0x6005142")]
		[Address(RVA = "0x9D581C", Offset = "0x9D581C", VA = "0x9D581C", Slot = "6")]
		protected override void Read()
		{
		}

		[Token(Token = "0x6005143")]
		[Address(RVA = "0x9D5F3C", Offset = "0x9D5F3C", VA = "0x9D5F3C")]
		private void SetPersistFileAsCorrupt()
		{
		}

		[Token(Token = "0x6005144")]
		[Address(RVA = "0x9D6314", Offset = "0x9D6314", VA = "0x9D6314", Slot = "4")]
		protected override void PostLoadFromDictionary()
		{
		}
	}
}
