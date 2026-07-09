using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000799")]
[ExecuteInEditMode]
public class UIAlignedList : UIWidgetContainer
{
	[Serializable]
	[Token(Token = "0x200079A")]
	public class ListItem
	{
		[Token(Token = "0x4002AD6")]
		[FieldOffset(Offset = "0x10")]
		public UIWidget Widget;

		[Token(Token = "0x4002AD7")]
		[FieldOffset(Offset = "0x18")]
		public int Offset;

		[Token(Token = "0x6003255")]
		[Address(RVA = "0xA3A6A4", Offset = "0xA3A6A4", VA = "0xA3A6A4")]
		public ListItem(UIWidget widget, int offset)
		{
		}
	}

	[Token(Token = "0x200079B")]
	public enum PivotType
	{
		[Token(Token = "0x4002AD9")]
		Left = 0,
		[Token(Token = "0x4002ADA")]
		Right = 1,
		[Token(Token = "0x4002ADB")]
		Down = 2,
		[Token(Token = "0x4002ADC")]
		Up = 3
	}

	[Token(Token = "0x200079C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5960F8", Offset = "0x5960F8")]
	private sealed class _003Cget_ConsideredWidgets_003Ed__3 : IEnumerable<ListItem>, IEnumerable, IEnumerator<ListItem>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002ADD")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002ADE")]
		[FieldOffset(Offset = "0x18")]
		private ListItem _003C_003E2__current;

		[Token(Token = "0x4002ADF")]
		[FieldOffset(Offset = "0x20")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x4002AE0")]
		[FieldOffset(Offset = "0x28")]
		public UIAlignedList _003C_003E4__this;

		[Token(Token = "0x4002AE1")]
		[FieldOffset(Offset = "0x30")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x4002AE2")]
		[FieldOffset(Offset = "0x34")]
		private int _003Ccount_003E5__3;

		[Token(Token = "0x17000671")]
		private ListItem System_002ECollections_002EGeneric_002EIEnumerator_003CUIAlignedList_002EListItem_003E_002ECurrent
		{
			[Token(Token = "0x6003259")]
			[Address(RVA = "0xA3A5A8", Offset = "0xA3A5A8", VA = "0xA3A5A8", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000672")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600325B")]
			[Address(RVA = "0xA3A5F0", Offset = "0xA3A5F0", VA = "0xA3A5F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003256")]
		[Address(RVA = "0xA3A3F0", Offset = "0xA3A3F0", VA = "0xA3A3F0")]
		[DebuggerHidden]
		public _003Cget_ConsideredWidgets_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003257")]
		[Address(RVA = "0xA3A428", Offset = "0xA3A428", VA = "0xA3A428", Slot = "7")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003258")]
		[Address(RVA = "0xA3A42C", Offset = "0xA3A42C", VA = "0xA3A42C", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600325A")]
		[Address(RVA = "0xA3A5B0", Offset = "0xA3A5B0", VA = "0xA3A5B0", Slot = "10")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600325C")]
		[Address(RVA = "0xA3A5F8", Offset = "0xA3A5F8", VA = "0xA3A5F8", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ListItem> System_002ECollections_002EGeneric_002EIEnumerable_003CUIAlignedList_002EListItem_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600325D")]
		[Address(RVA = "0xA3A6A0", Offset = "0xA3A6A0", VA = "0xA3A6A0", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x4002ACC")]
	[FieldOffset(Offset = "0x18")]
	public List<ListItem> Widgets;

	[Token(Token = "0x4002ACD")]
	[FieldOffset(Offset = "0x20")]
	public PivotType Direction;

	[Token(Token = "0x4002ACE")]
	[FieldOffset(Offset = "0x24")]
	public bool Centered;

	[Token(Token = "0x4002ACF")]
	[FieldOffset(Offset = "0x25")]
	public bool OnlyApplyToActiveWidgets;

	[Token(Token = "0x4002AD0")]
	[FieldOffset(Offset = "0x26")]
	public bool ForceUpdate;

	[Token(Token = "0x4002AD1")]
	[FieldOffset(Offset = "0x28")]
	private PivotType _cachedPivot;

	[Token(Token = "0x4002AD2")]
	[FieldOffset(Offset = "0x2C")]
	private bool _cachedCentered;

	[Token(Token = "0x4002AD3")]
	[FieldOffset(Offset = "0x2D")]
	public bool LabelsAssumeNaturalSize;

	[Token(Token = "0x4002AD4")]
	[FieldOffset(Offset = "0x30")]
	public int MaxHeightPossible;

	[Token(Token = "0x1700066F")]
	public IEnumerable<ListItem> ConsideredWidgets
	{
		[Token(Token = "0x600324A")]
		[Address(RVA = "0x1576920", Offset = "0x1576920", VA = "0x1576920")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x622510", Offset = "0x622510")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000670")]
	public Color color
	{
		[Token(Token = "0x600324B")]
		[Address(RVA = "0x157698C", Offset = "0x157698C", VA = "0x157698C")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x600324C")]
		[Address(RVA = "0x1576A80", Offset = "0x1576A80", VA = "0x1576A80")]
		set
		{
		}
	}

	[Token(Token = "0x140000AA")]
	public event EventHandler OnUpdateDone
	{
		[Token(Token = "0x600324D")]
		[Address(RVA = "0x1576BAC", Offset = "0x1576BAC", VA = "0x1576BAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622570", Offset = "0x622570")]
		add
		{
		}
		[Token(Token = "0x600324E")]
		[Address(RVA = "0x1576C4C", Offset = "0x1576C4C", VA = "0x1576C4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622580", Offset = "0x622580")]
		remove
		{
		}
	}

	[Token(Token = "0x600324F")]
	[Address(RVA = "0x1576CEC", Offset = "0x1576CEC", VA = "0x1576CEC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003250")]
	[Address(RVA = "0x1576CF8", Offset = "0x1576CF8", VA = "0x1576CF8")]
	public void DoUpdateNow()
	{
	}

	[Token(Token = "0x6003251")]
	[Address(RVA = "0x1577DE4", Offset = "0x1577DE4", VA = "0x1577DE4")]
	private void Update()
	{
	}

	[Token(Token = "0x6003252")]
	[Address(RVA = "0x1576DB0", Offset = "0x1576DB0", VA = "0x1576DB0")]
	private void UpdateCentered()
	{
	}

	[Token(Token = "0x6003253")]
	[Address(RVA = "0x1577144", Offset = "0x1577144", VA = "0x1577144")]
	private void UpdateDirection()
	{
	}

	[Token(Token = "0x6003254")]
	[Address(RVA = "0x1577E24", Offset = "0x1577E24", VA = "0x1577E24")]
	public UIAlignedList()
	{
	}
}
