using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000721")]
public class PopupAddCurrencies : PopupOverlayView
{
	[Token(Token = "0x2000722")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595EB8", Offset = "0x595EB8")]
	private sealed class _003CDelayPositionPopup_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002864")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002865")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002866")]
		[FieldOffset(Offset = "0x20")]
		public PopupAddCurrencies _003C_003E4__this;

		[Token(Token = "0x4002867")]
		[FieldOffset(Offset = "0x28")]
		public bool startAtTokens;

		[Token(Token = "0x4002868")]
		[FieldOffset(Offset = "0x30")]
		private UIPanel _003Cpanel_003E5__2;

		[Token(Token = "0x17000623")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002FA1")]
			[Address(RVA = "0x8AC874", Offset = "0x8AC874", VA = "0x8AC874", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000624")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002FA3")]
			[Address(RVA = "0x8AC8BC", Offset = "0x8AC8BC", VA = "0x8AC8BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002F9E")]
		[Address(RVA = "0x8AC740", Offset = "0x8AC740", VA = "0x8AC740")]
		[DebuggerHidden]
		public _003CDelayPositionPopup_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002F9F")]
		[Address(RVA = "0x8AC76C", Offset = "0x8AC76C", VA = "0x8AC76C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002FA0")]
		[Address(RVA = "0x8AC770", Offset = "0x8AC770", VA = "0x8AC770", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002FA2")]
		[Address(RVA = "0x8AC87C", Offset = "0x8AC87C", VA = "0x8AC87C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400285F")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private UIGrid _tokenGrid;

	[Token(Token = "0x4002860")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	private UIGrid _cashGrid;

	[Token(Token = "0x4002861")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	private UIDraggablePanel _draggablePanel;

	[Token(Token = "0x4002862")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	private GameObject _currencyItemPrefab;

	[Token(Token = "0x4002863")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	private float _additionalOffset;

	[Token(Token = "0x6002F97")]
	[Address(RVA = "0x92CDA8", Offset = "0x92CDA8", VA = "0x92CDA8")]
	public void SetupPopupOverlay(string title, Action cancelCallback, Action exitCallback, bool startAtTokens)
	{
	}

	[Token(Token = "0x6002F98")]
	[Address(RVA = "0x92CFD4", Offset = "0x92CFD4", VA = "0x92CFD4")]
	private static void CreateCurrencyItems(List<CurrencyItemModel> models, UIGrid grid, GameObject prefab)
	{
	}

	[Token(Token = "0x6002F99")]
	[Address(RVA = "0x92D1D0", Offset = "0x92D1D0", VA = "0x92D1D0")]
	private static void CreateCurrencyItem(CurrencyItemModel currencyItemModel, GameObject parent, GameObject prefab)
	{
	}

	[Token(Token = "0x6002F9A")]
	[Address(RVA = "0x92D0A8", Offset = "0x92D0A8", VA = "0x92D0A8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x621810", Offset = "0x621810")]
	private IEnumerator DelayPositionPopup(bool startAtTokens)
	{
		return null;
	}

	[Token(Token = "0x6002F9B")]
	[Address(RVA = "0x92D300", Offset = "0x92D300", VA = "0x92D300")]
	private void PositionPopup(bool startAtTokens)
	{
	}

	[Token(Token = "0x6002F9C")]
	[Address(RVA = "0x92D4A4", Offset = "0x92D4A4", VA = "0x92D4A4")]
	private bool FitsOnScreenHorizontal()
	{
		return default(bool);
	}

	[Token(Token = "0x6002F9D")]
	[Address(RVA = "0x92D530", Offset = "0x92D530", VA = "0x92D530")]
	public PopupAddCurrencies()
	{
	}
}
