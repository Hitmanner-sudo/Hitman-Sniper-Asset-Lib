using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Prime31
{
	[Token(Token = "0x2000080")]
	public class GoogleIABManager : AbstractManager
	{
		[Token(Token = "0x1400002C")]
		public static event Action billingSupportedEvent
		{
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x10EB0C4", Offset = "0x10EB0C4", VA = "0x10EB0C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FACE8", Offset = "0x6FACE8")]
			add
			{
			}
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x10EB1B8", Offset = "0x10EB1B8", VA = "0x10EB1B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FACF8", Offset = "0x6FACF8")]
			remove
			{
			}
		}

		[Token(Token = "0x1400002D")]
		public static event Action<string> billingNotSupportedEvent
		{
			[Token(Token = "0x600030B")]
			[Address(RVA = "0x10EB2AC", Offset = "0x10EB2AC", VA = "0x10EB2AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAD08", Offset = "0x6FAD08")]
			add
			{
			}
			[Token(Token = "0x600030C")]
			[Address(RVA = "0x10EB3A4", Offset = "0x10EB3A4", VA = "0x10EB3A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAD18", Offset = "0x6FAD18")]
			remove
			{
			}
		}

		[Token(Token = "0x1400002E")]
		public static event Action<List<GooglePurchase>, List<GoogleSkuInfo>> queryInventorySucceededEvent
		{
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x10EB49C", Offset = "0x10EB49C", VA = "0x10EB49C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAD28", Offset = "0x6FAD28")]
			add
			{
			}
			[Token(Token = "0x600030E")]
			[Address(RVA = "0x10EB594", Offset = "0x10EB594", VA = "0x10EB594")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAD38", Offset = "0x6FAD38")]
			remove
			{
			}
		}

		[Token(Token = "0x1400002F")]
		public static event Action<string> queryInventoryFailedEvent
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x10EB68C", Offset = "0x10EB68C", VA = "0x10EB68C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAD48", Offset = "0x6FAD48")]
			add
			{
			}
			[Token(Token = "0x6000310")]
			[Address(RVA = "0x10EB784", Offset = "0x10EB784", VA = "0x10EB784")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAD58", Offset = "0x6FAD58")]
			remove
			{
			}
		}

		[Token(Token = "0x14000030")]
		public static event Action<GooglePurchase> purchaseSucceededEvent
		{
			[Token(Token = "0x6000311")]
			[Address(RVA = "0x10EB87C", Offset = "0x10EB87C", VA = "0x10EB87C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAD68", Offset = "0x6FAD68")]
			add
			{
			}
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x10EB974", Offset = "0x10EB974", VA = "0x10EB974")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAD78", Offset = "0x6FAD78")]
			remove
			{
			}
		}

		[Token(Token = "0x14000031")]
		public static event Action<string, int> purchaseFailedEvent
		{
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x10EBA6C", Offset = "0x10EBA6C", VA = "0x10EBA6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAD88", Offset = "0x6FAD88")]
			add
			{
			}
			[Token(Token = "0x6000314")]
			[Address(RVA = "0x10EBB64", Offset = "0x10EBB64", VA = "0x10EBB64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAD98", Offset = "0x6FAD98")]
			remove
			{
			}
		}

		[Token(Token = "0x14000032")]
		public static event Action<GooglePurchase> consumePurchaseSucceededEvent
		{
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x10EBC5C", Offset = "0x10EBC5C", VA = "0x10EBC5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FADA8", Offset = "0x6FADA8")]
			add
			{
			}
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x10EBD54", Offset = "0x10EBD54", VA = "0x10EBD54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FADB8", Offset = "0x6FADB8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000033")]
		public static event Action<string> consumePurchaseFailedEvent
		{
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x10EBE4C", Offset = "0x10EBE4C", VA = "0x10EBE4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FADC8", Offset = "0x6FADC8")]
			add
			{
			}
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x10EBF44", Offset = "0x10EBF44", VA = "0x10EBF44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FADD8", Offset = "0x6FADD8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000034")]
		public static event Action<GooglePurchase> acknowledgePurchaseSucceededEvent
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x10EC03C", Offset = "0x10EC03C", VA = "0x10EC03C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FADE8", Offset = "0x6FADE8")]
			add
			{
			}
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x10EC134", Offset = "0x10EC134", VA = "0x10EC134")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FADF8", Offset = "0x6FADF8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000035")]
		public static event Action<string> acknowledgePurchaseFailedEvent
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x10EC22C", Offset = "0x10EC22C", VA = "0x10EC22C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAE08", Offset = "0x6FAE08")]
			add
			{
			}
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x10EC324", Offset = "0x10EC324", VA = "0x10EC324")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAE18", Offset = "0x6FAE18")]
			remove
			{
			}
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x10EC41C", Offset = "0x10EC41C", VA = "0x10EC41C")]
		static GoogleIABManager()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x10EC49C", Offset = "0x10EC49C", VA = "0x10EC49C")]
		public void billingSupported(string empty)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x10EC504", Offset = "0x10EC504", VA = "0x10EC504")]
		public void billingNotSupported(string error)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x10EC588", Offset = "0x10EC588", VA = "0x10EC588")]
		public void queryInventorySucceeded(string json)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x10ECB88", Offset = "0x10ECB88", VA = "0x10ECB88")]
		public void queryInventoryFailed(string error)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x10ECC0C", Offset = "0x10ECC0C", VA = "0x10ECC0C")]
		public void purchaseSucceeded(string json)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x10ED0C0", Offset = "0x10ED0C0", VA = "0x10ED0C0")]
		public void purchaseFailed(string json)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x10ED278", Offset = "0x10ED278", VA = "0x10ED278")]
		public void consumePurchaseSucceeded(string json)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x10ED37C", Offset = "0x10ED37C", VA = "0x10ED37C")]
		public void consumePurchaseFailed(string error)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x10ED400", Offset = "0x10ED400", VA = "0x10ED400")]
		public void acknowledgePurchaseSucceeded(string json)
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x10ED504", Offset = "0x10ED504", VA = "0x10ED504")]
		public void acknowledgePurchaseFailed(string error)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x10ED588", Offset = "0x10ED588", VA = "0x10ED588")]
		public GoogleIABManager()
		{
		}
	}
}
