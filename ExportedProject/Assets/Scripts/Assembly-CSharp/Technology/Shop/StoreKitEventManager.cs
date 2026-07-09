using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Shop
{
	[Token(Token = "0x2000B17")]
	public class StoreKitEventManager
	{
		[Token(Token = "0x140000D0")]
		public static event Action<List<StoreKitProduct>> ProductListReceivedEvent
		{
			[Token(Token = "0x6004557")]
			[Address(RVA = "0xD2C27C", Offset = "0xD2C27C", VA = "0xD2C27C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626468", Offset = "0x626468")]
			add
			{
			}
			[Token(Token = "0x6004558")]
			[Address(RVA = "0xD2C338", Offset = "0xD2C338", VA = "0xD2C338")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626478", Offset = "0x626478")]
			remove
			{
			}
		}

		[Token(Token = "0x140000D1")]
		public static event Action<string> ProductListRequestFailedEvent
		{
			[Token(Token = "0x6004559")]
			[Address(RVA = "0xD2C3F4", Offset = "0xD2C3F4", VA = "0xD2C3F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626488", Offset = "0x626488")]
			add
			{
			}
			[Token(Token = "0x600455A")]
			[Address(RVA = "0xD2C4B4", Offset = "0xD2C4B4", VA = "0xD2C4B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626498", Offset = "0x626498")]
			remove
			{
			}
		}

		[Token(Token = "0x140000D2")]
		public static event Action<StoreKitTransaction> TransactionUpdatedEvent
		{
			[Token(Token = "0x600455B")]
			[Address(RVA = "0xD2C574", Offset = "0xD2C574", VA = "0xD2C574")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6264A8", Offset = "0x6264A8")]
			add
			{
			}
			[Token(Token = "0x600455C")]
			[Address(RVA = "0xD2C634", Offset = "0xD2C634", VA = "0xD2C634")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6264B8", Offset = "0x6264B8")]
			remove
			{
			}
		}

		[Token(Token = "0x140000D3")]
		public static event Action<StoreKitTransaction> PurchaseSuccessfulEvent
		{
			[Token(Token = "0x600455D")]
			[Address(RVA = "0xD2C6F4", Offset = "0xD2C6F4", VA = "0xD2C6F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6264C8", Offset = "0x6264C8")]
			add
			{
			}
			[Token(Token = "0x600455E")]
			[Address(RVA = "0xD2C7B4", Offset = "0xD2C7B4", VA = "0xD2C7B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6264D8", Offset = "0x6264D8")]
			remove
			{
			}
		}

		[Token(Token = "0x140000D4")]
		public static event Action<string> PurchaseFailedEvent
		{
			[Token(Token = "0x600455F")]
			[Address(RVA = "0xD2C874", Offset = "0xD2C874", VA = "0xD2C874")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6264E8", Offset = "0x6264E8")]
			add
			{
			}
			[Token(Token = "0x6004560")]
			[Address(RVA = "0xD2C934", Offset = "0xD2C934", VA = "0xD2C934")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6264F8", Offset = "0x6264F8")]
			remove
			{
			}
		}

		[Token(Token = "0x140000D5")]
		public static event Action<string> PurchaseCancelledEvent
		{
			[Token(Token = "0x6004561")]
			[Address(RVA = "0xD2C9F4", Offset = "0xD2C9F4", VA = "0xD2C9F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626508", Offset = "0x626508")]
			add
			{
			}
			[Token(Token = "0x6004562")]
			[Address(RVA = "0xD2CAB4", Offset = "0xD2CAB4", VA = "0xD2CAB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626518", Offset = "0x626518")]
			remove
			{
			}
		}

		[Token(Token = "0x140000D6")]
		public static event Action<StoreKitTransaction> ProductPurchaseAwaitingConfirmationEvent
		{
			[Token(Token = "0x6004563")]
			[Address(RVA = "0xD2CB74", Offset = "0xD2CB74", VA = "0xD2CB74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626528", Offset = "0x626528")]
			add
			{
			}
			[Token(Token = "0x6004564")]
			[Address(RVA = "0xD2CC34", Offset = "0xD2CC34", VA = "0xD2CC34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626538", Offset = "0x626538")]
			remove
			{
			}
		}

		[Token(Token = "0x140000D7")]
		public static event Action RestoreTransactionsFinishedEvent
		{
			[Token(Token = "0x6004565")]
			[Address(RVA = "0xD2CCF4", Offset = "0xD2CCF4", VA = "0xD2CCF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626548", Offset = "0x626548")]
			add
			{
			}
			[Token(Token = "0x6004566")]
			[Address(RVA = "0xD2CDB4", Offset = "0xD2CDB4", VA = "0xD2CDB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626558", Offset = "0x626558")]
			remove
			{
			}
		}

		[Token(Token = "0x140000D8")]
		public static event Action<string> RestoreTransactionsFailedEvent
		{
			[Token(Token = "0x6004567")]
			[Address(RVA = "0xD2CE74", Offset = "0xD2CE74", VA = "0xD2CE74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626568", Offset = "0x626568")]
			add
			{
			}
			[Token(Token = "0x6004568")]
			[Address(RVA = "0xD2CF34", Offset = "0xD2CF34", VA = "0xD2CF34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626578", Offset = "0x626578")]
			remove
			{
			}
		}

		[Token(Token = "0x6004569")]
		[Address(RVA = "0xD2BCCC", Offset = "0xD2BCCC", VA = "0xD2BCCC")]
		public void TransactionUpdated(StoreKitTransaction transaction)
		{
		}

		[Token(Token = "0x600456A")]
		[Address(RVA = "0xD2BC60", Offset = "0xD2BC60", VA = "0xD2BC60")]
		public void ProductPurchaseAwaitingConfirmation(StoreKitTransaction transaction)
		{
		}

		[Token(Token = "0x600456B")]
		[Address(RVA = "0xD2BB1C", Offset = "0xD2BB1C", VA = "0xD2BB1C")]
		public void ProductPurchased(StoreKitTransaction transaction)
		{
		}

		[Token(Token = "0x600456C")]
		[Address(RVA = "0xD2BBF4", Offset = "0xD2BBF4", VA = "0xD2BBF4")]
		public void ProductPurchaseFailed(string error)
		{
		}

		[Token(Token = "0x600456D")]
		[Address(RVA = "0xD2BB88", Offset = "0xD2BB88", VA = "0xD2BB88")]
		public void ProductPurchaseCancelled(string error)
		{
		}

		[Token(Token = "0x600456E")]
		[Address(RVA = "0xD2CFF4", Offset = "0xD2CFF4", VA = "0xD2CFF4")]
		public void ProductsReceived(string json)
		{
		}

		[Token(Token = "0x600456F")]
		[Address(RVA = "0xD2D1AC", Offset = "0xD2D1AC", VA = "0xD2D1AC")]
		public void ProductsRequestDidFail(string error)
		{
		}

		[Token(Token = "0x6004570")]
		[Address(RVA = "0xD2D218", Offset = "0xD2D218", VA = "0xD2D218")]
		public void RestoreCompletedTransactionsFailed(string error)
		{
		}

		[Token(Token = "0x6004571")]
		[Address(RVA = "0xD2D284", Offset = "0xD2D284", VA = "0xD2D284")]
		public void RestoreCompletedTransactionsFinished()
		{
		}

		[Token(Token = "0x6004572")]
		[Address(RVA = "0xD2B57C", Offset = "0xD2B57C", VA = "0xD2B57C")]
		public StoreKitEventManager()
		{
		}
	}
}
