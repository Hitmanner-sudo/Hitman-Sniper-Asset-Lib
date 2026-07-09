using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000618")]
public class RenderQueueUIWidgetRelative : MonoBehaviour
{
	[Token(Token = "0x2000619")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595600", Offset = "0x595600")]
	private sealed class _003CSetRenderQueue_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400219B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400219C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400219D")]
		[FieldOffset(Offset = "0x20")]
		public RenderQueueUIWidgetRelative _003C_003E4__this;

		[Token(Token = "0x1700052F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600278C")]
			[Address(RVA = "0x8B428C", Offset = "0x8B428C", VA = "0x8B428C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000530")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600278E")]
			[Address(RVA = "0x8B42D4", Offset = "0x8B42D4", VA = "0x8B42D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002789")]
		[Address(RVA = "0x8B4104", Offset = "0x8B4104", VA = "0x8B4104")]
		[DebuggerHidden]
		public _003CSetRenderQueue_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600278A")]
		[Address(RVA = "0x8B4130", Offset = "0x8B4130", VA = "0x8B4130", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600278B")]
		[Address(RVA = "0x8B4134", Offset = "0x8B4134", VA = "0x8B4134", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600278D")]
		[Address(RVA = "0x8B4294", Offset = "0x8B4294", VA = "0x8B4294", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4002199")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UIWidget _widget;

	[Token(Token = "0x400219A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int _offset;

	[Token(Token = "0x1700052E")]
	protected int RenderQueue
	{
		[Token(Token = "0x6002785")]
		[Address(RVA = "0x965F58", Offset = "0x965F58", VA = "0x965F58")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002786")]
	[Address(RVA = "0x965FF8", Offset = "0x965FF8", VA = "0x965FF8")]
	protected void OnEnable()
	{
	}

	[Token(Token = "0x6002787")]
	[Address(RVA = "0x966024", Offset = "0x966024", VA = "0x966024")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61D280", Offset = "0x61D280")]
	private IEnumerator SetRenderQueue()
	{
		return null;
	}

	[Token(Token = "0x6002788")]
	[Address(RVA = "0x966090", Offset = "0x966090", VA = "0x966090")]
	public RenderQueueUIWidgetRelative()
	{
	}
}
