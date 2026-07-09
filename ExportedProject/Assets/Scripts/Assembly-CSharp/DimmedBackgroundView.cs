using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200070E")]
public class DimmedBackgroundView : View
{
	[Token(Token = "0x200070F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595E08", Offset = "0x595E08")]
	private sealed class _003CDoFade_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40027FF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002800")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002801")]
		[FieldOffset(Offset = "0x20")]
		public float duration;

		[Token(Token = "0x4002802")]
		[FieldOffset(Offset = "0x24")]
		public float from;

		[Token(Token = "0x4002803")]
		[FieldOffset(Offset = "0x28")]
		public float to;

		[Token(Token = "0x4002804")]
		[FieldOffset(Offset = "0x30")]
		public DimmedBackgroundView _003C_003E4__this;

		[Token(Token = "0x4002805")]
		[FieldOffset(Offset = "0x38")]
		public Action onFinished;

		[Token(Token = "0x4002806")]
		[FieldOffset(Offset = "0x40")]
		private float _003Ctime_003E5__2;

		[Token(Token = "0x17000616")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002F13")]
			[Address(RVA = "0x86BC28", Offset = "0x86BC28", VA = "0x86BC28", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000617")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002F15")]
			[Address(RVA = "0x86BC70", Offset = "0x86BC70", VA = "0x86BC70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002F10")]
		[Address(RVA = "0x86BA88", Offset = "0x86BA88", VA = "0x86BA88")]
		[DebuggerHidden]
		public _003CDoFade_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002F11")]
		[Address(RVA = "0x86BAB4", Offset = "0x86BAB4", VA = "0x86BAB4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002F12")]
		[Address(RVA = "0x86BAB8", Offset = "0x86BAB8", VA = "0x86BAB8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002F14")]
		[Address(RVA = "0x86BC30", Offset = "0x86BC30", VA = "0x86BC30", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40027F3")]
	private const int PRIMARY_DEPTH_OFFSET = 20;

	[Token(Token = "0x40027F4")]
	private const int SECONDARY_DEPTH_OFFSET = 10;

	[Token(Token = "0x40027F5")]
	[FieldOffset(Offset = "0x60")]
	public UIPanel DimmedBackgroundPanel;

	[Token(Token = "0x40027F6")]
	[FieldOffset(Offset = "0x68")]
	public ButtonHandler ClickableBackground;

	[Token(Token = "0x40027F7")]
	[FieldOffset(Offset = "0x70")]
	public Action OnMountCallback;

	[Token(Token = "0x40027F8")]
	[FieldOffset(Offset = "0x78")]
	public UISprite Sprite;

	[Token(Token = "0x40027F9")]
	[FieldOffset(Offset = "0x80")]
	private Transform _oldParent;

	[Token(Token = "0x40027FA")]
	[FieldOffset(Offset = "0x88")]
	private GameObject _highlightedGameObject;

	[Token(Token = "0x40027FB")]
	[FieldOffset(Offset = "0x90")]
	private float _startingAlpha;

	[Token(Token = "0x40027FC")]
	[FieldOffset(Offset = "0x98")]
	private Collider _collider;

	[Token(Token = "0x40027FD")]
	[FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B9D7C", Offset = "0x5B9D7C")]
	private bool _003CCanClickOnBackground_003Ek__BackingField;

	[Token(Token = "0x40027FE")]
	[FieldOffset(Offset = "0xA8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B9D8C", Offset = "0x5B9D8C")]
	private ButtonHandler _003CHighlightedButton_003Ek__BackingField;

	[Token(Token = "0x17000613")]
	public bool CanClickOnBackground
	{
		[Token(Token = "0x6002F01")]
		[Address(RVA = "0xC14DB4", Offset = "0xC14DB4", VA = "0xC14DB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6215B0", Offset = "0x6215B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002F02")]
		[Address(RVA = "0xC14DBC", Offset = "0xC14DBC", VA = "0xC14DBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6215C0", Offset = "0x6215C0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000614")]
	public ButtonHandler HighlightedButton
	{
		[Token(Token = "0x6002F03")]
		[Address(RVA = "0xC14DC8", Offset = "0xC14DC8", VA = "0xC14DC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6215D0", Offset = "0x6215D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002F04")]
		[Address(RVA = "0xC14DD0", Offset = "0xC14DD0", VA = "0xC14DD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6215E0", Offset = "0x6215E0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000615")]
	public bool IsGameObjectMounted
	{
		[Token(Token = "0x6002F05")]
		[Address(RVA = "0xC14DD8", Offset = "0xC14DD8", VA = "0xC14DD8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002F06")]
	[Address(RVA = "0xC14E6C", Offset = "0xC14E6C", VA = "0xC14E6C")]
	public void Setup(GameObject highlightedGameObject, ButtonHandler highlightedButton, ModeView viewToLatchOnTo, float mountDelay = 0f, bool canClickOnBackground = false)
	{
	}

	[Token(Token = "0x6002F07")]
	[Address(RVA = "0xC150B0", Offset = "0xC150B0", VA = "0xC150B0")]
	private void MountButton()
	{
	}

	[Token(Token = "0x6002F08")]
	[Address(RVA = "0xC151F8", Offset = "0xC151F8", VA = "0xC151F8")]
	public void Restore()
	{
	}

	[Token(Token = "0x6002F09")]
	[Address(RVA = "0xC153B4", Offset = "0xC153B4", VA = "0xC153B4")]
	public void FadeIn(float time, Action onFinished)
	{
	}

	[Token(Token = "0x6002F0A")]
	[Address(RVA = "0xC154E8", Offset = "0xC154E8", VA = "0xC154E8")]
	public void FadeOut(float time, Action onFinished)
	{
	}

	[Token(Token = "0x6002F0B")]
	[Address(RVA = "0xC1553C", Offset = "0xC1553C", VA = "0xC1553C")]
	public void SetAlpha(float alpha)
	{
	}

	[Token(Token = "0x6002F0C")]
	[Address(RVA = "0xC15090", Offset = "0xC15090", VA = "0xC15090")]
	public void SetColliderEnabled(bool isEnabled)
	{
	}

	[Token(Token = "0x6002F0D")]
	[Address(RVA = "0xC1544C", Offset = "0xC1544C", VA = "0xC1544C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6215F0", Offset = "0x6215F0")]
	private IEnumerator DoFade(float from, float to, float duration, Action onFinished)
	{
		return null;
	}

	[Token(Token = "0x6002F0E")]
	[Address(RVA = "0xC15408", Offset = "0xC15408", VA = "0xC15408")]
	private void CacheStartingAlpha()
	{
	}

	[Token(Token = "0x6002F0F")]
	[Address(RVA = "0xC1557C", Offset = "0xC1557C", VA = "0xC1557C")]
	public DimmedBackgroundView()
	{
	}
}
