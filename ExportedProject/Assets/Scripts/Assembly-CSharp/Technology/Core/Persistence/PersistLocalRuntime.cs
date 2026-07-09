using Il2CppDummyDll;

namespace Technology.Core.Persistence
{
	[Token(Token = "0x2000D3A")]
	public class PersistLocalRuntime : AbstractFacadePersist<LocalFileRuntimePersistence>
	{
		[Token(Token = "0x14000159")]
		public static event AbstractPersistence.SaveGameIsCorruptEvent SaveGameIsCorrupt
		{
			[Token(Token = "0x6005186")]
			[Address(RVA = "0x90389C", Offset = "0x90389C", VA = "0x90389C")]
			add
			{
			}
			[Token(Token = "0x6005187")]
			[Address(RVA = "0x903924", Offset = "0x903924", VA = "0x903924")]
			remove
			{
			}
		}

		[Token(Token = "0x6005188")]
		[Address(RVA = "0x9039AC", Offset = "0x9039AC", VA = "0x9039AC")]
		public static void Propagate(bool clear = false)
		{
		}

		[Token(Token = "0x6005189")]
		[Address(RVA = "0x903B04", Offset = "0x903B04", VA = "0x903B04")]
		public static void ResetDeviceId()
		{
		}

		[Token(Token = "0x600518A")]
		[Address(RVA = "0x903B84", Offset = "0x903B84", VA = "0x903B84")]
		public PersistLocalRuntime()
		{
		}
	}
}
