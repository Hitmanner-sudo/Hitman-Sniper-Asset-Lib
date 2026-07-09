using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology.Shop;

[Token(Token = "0x2000540")]
public class RestorePurchaseController
{
	[Token(Token = "0x2000541")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5950F4", Offset = "0x5950F4")]
	private sealed class _003CWaitForOffersRestored_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001BCF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001BD0")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001BD1")]
		[FieldOffset(Offset = "0x20")]
		public RestorePurchaseController _003C_003E4__this;

		[Token(Token = "0x170004DB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60020DE")]
			[Address(RVA = "0x8B45D8", Offset = "0x8B45D8", VA = "0x8B45D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004DC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60020E0")]
			[Address(RVA = "0x8B4620", Offset = "0x8B4620", VA = "0x8B4620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60020DB")]
		[Address(RVA = "0x8B42DC", Offset = "0x8B42DC", VA = "0x8B42DC")]
		[DebuggerHidden]
		public _003CWaitForOffersRestored_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60020DC")]
		[Address(RVA = "0x8B4308", Offset = "0x8B4308", VA = "0x8B4308", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60020DD")]
		[Address(RVA = "0x8B430C", Offset = "0x8B430C", VA = "0x8B430C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60020DF")]
		[Address(RVA = "0x8B45E0", Offset = "0x8B45E0", VA = "0x8B45E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001BCC")]
	[FieldOffset(Offset = "0x10")]
	private BlockingOnlineRequestManager.ReqHandle _handle;

	[Token(Token = "0x4001BCD")]
	[FieldOffset(Offset = "0x18")]
	private readonly ContinuousTimer _timer;

	[Token(Token = "0x4001BCE")]
	[FieldOffset(Offset = "0x20")]
	private readonly Action _onCompleted;

	[Token(Token = "0x60020CE")]
	[Address(RVA = "0x966FEC", Offset = "0x966FEC", VA = "0x966FEC")]
	public RestorePurchaseController(Action onCompleted)
	{
	}

	[Token(Token = "0x60020CF")]
	[Address(RVA = "0x967064", Offset = "0x967064", VA = "0x967064")]
	public void StartRestorePurchases()
	{
	}

	[Token(Token = "0x60020D0")]
	[Address(RVA = "0x9671A8", Offset = "0x9671A8", VA = "0x9671A8")]
	private void RestorePurchases()
	{
	}

	[Token(Token = "0x60020D1")]
	[Address(RVA = "0x9672D4", Offset = "0x9672D4", VA = "0x9672D4")]
	private void OnOffersRestoredSuccess(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x60020D2")]
	[Address(RVA = "0x967620", Offset = "0x967620", VA = "0x967620")]
	private void OnOffersRestoredFailed(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x60020D3")]
	[Address(RVA = "0x967418", Offset = "0x967418", VA = "0x967418")]
	private void UnbindRestorePurchaseEvents()
	{
	}

	[Token(Token = "0x60020D4")]
	[Address(RVA = "0x9674EC", Offset = "0x9674EC", VA = "0x9674EC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x619548", Offset = "0x619548")]
	private IEnumerator WaitForOffersRestored()
	{
		return null;
	}

	[Token(Token = "0x60020D5")]
	[Address(RVA = "0x967710", Offset = "0x967710", VA = "0x967710")]
	private void OnOfferPurchase(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x60020D6")]
	[Address(RVA = "0x967558", Offset = "0x967558", VA = "0x967558")]
	private void UnregisterShopEvents()
	{
	}

	[Token(Token = "0x60020D7")]
	[Address(RVA = "0x96777C", Offset = "0x96777C", VA = "0x96777C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6195A8", Offset = "0x6195A8")]
	private void _003CStartRestorePurchases_003Eb__4_0(BlockingOnlineRequestManager.ReqHandle h)
	{
	}

	[Token(Token = "0x60020D8")]
	[Address(RVA = "0x967780", Offset = "0x967780", VA = "0x967780")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6195B8", Offset = "0x6195B8")]
	private void _003CStartRestorePurchases_003Eb__4_1(BlockingOnlineRequestManager.ReqHandle h)
	{
	}

	[Token(Token = "0x60020D9")]
	[Address(RVA = "0x967788", Offset = "0x967788", VA = "0x967788")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6195C8", Offset = "0x6195C8")]
	private void _003COnOffersRestoredFailed_003Eb__7_0()
	{
	}

	[Token(Token = "0x60020DA")]
	[Address(RVA = "0x967790", Offset = "0x967790", VA = "0x967790")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6195D8", Offset = "0x6195D8")]
	private void _003CWaitForOffersRestored_003Eb__9_0()
	{
	}
}
