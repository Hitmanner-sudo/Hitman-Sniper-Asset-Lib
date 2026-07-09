using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000557")]
public class SidePanelItemController : UIController
{
	[Token(Token = "0x2000558")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595264", Offset = "0x595264")]
	private sealed class _003CDelayClosePanel_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001C62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001C63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001C64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x4001C65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SidePanelItemController _003C_003E4__this;

		[Token(Token = "0x4001C66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameTimer _003Ctimer_003E5__2;

		[Token(Token = "0x170004E6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60021D0")]
			[Address(RVA = "0x8BFB28", Offset = "0x8BFB28", VA = "0x8BFB28", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60021D2")]
			[Address(RVA = "0x8BFB70", Offset = "0x8BFB70", VA = "0x8BFB70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60021CD")]
		[Address(RVA = "0x8BFA10", Offset = "0x8BFA10", VA = "0x8BFA10")]
		[DebuggerHidden]
		public _003CDelayClosePanel_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60021CE")]
		[Address(RVA = "0x8BFA3C", Offset = "0x8BFA3C", VA = "0x8BFA3C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60021CF")]
		[Address(RVA = "0x8BFA40", Offset = "0x8BFA40", VA = "0x8BFA40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60021D1")]
		[Address(RVA = "0x8BFB30", Offset = "0x8BFB30", VA = "0x8BFB30", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001C58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject CornersGameObjet;

	[Token(Token = "0x4001C59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public UISprite[] ContourUISprites;

	[Token(Token = "0x4001C5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public UISprite Icon;

	[Token(Token = "0x4001C5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Coroutine DelayCloseCoroutine;

	[Token(Token = "0x4001C5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool _closed;

	[Token(Token = "0x4001C5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private TweenPosition _tween;

	[Token(Token = "0x4001C5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Transform _transform;

	[Token(Token = "0x4001C5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3 _openPos;

	[Token(Token = "0x4001C60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private Vector3 _closedPos;

	[Token(Token = "0x4001C61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private bool _toggleOpen;

	[Token(Token = "0x60021C4")]
	[Address(RVA = "0x845128", Offset = "0x845128", VA = "0x845128", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60021C5")]
	[Address(RVA = "0x8451C4", Offset = "0x8451C4", VA = "0x8451C4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x619998", Offset = "0x619998")]
	protected IEnumerator DelayClosePanel(float delay)
	{
		return null;
	}

	[Token(Token = "0x60021C6")]
	[Address(RVA = "0x845240", Offset = "0x845240", VA = "0x845240")]
	public void SetOpenClosedPositions(Vector3 openPos, Vector3 closedPos)
	{
	}

	[Token(Token = "0x60021C7")]
	[Address(RVA = "0x845280", Offset = "0x845280", VA = "0x845280")]
	public void SetImage(UIAtlas atlas, string iconName)
	{
	}

	[Token(Token = "0x60021C8")]
	[Address(RVA = "0x8452C4", Offset = "0x8452C4", VA = "0x8452C4", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x60021C9")]
	[Address(RVA = "0x84543C", Offset = "0x84543C", VA = "0x84543C")]
	protected void ClosePanel([Optional] Action onFinished)
	{
	}

	[Token(Token = "0x60021CA")]
	[Address(RVA = "0x8452E8", Offset = "0x8452E8", VA = "0x8452E8")]
	protected void OpenPanel()
	{
	}

	[Token(Token = "0x60021CB")]
	[Address(RVA = "0x845510", Offset = "0x845510", VA = "0x845510")]
	public SidePanelItemController()
	{
	}

	[Token(Token = "0x60021CC")]
	[Address(RVA = "0x845574", Offset = "0x845574", VA = "0x845574")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6199F8", Offset = "0x6199F8")]
	private void _003COpenPanel_003Eb__16_0()
	{
	}
}
