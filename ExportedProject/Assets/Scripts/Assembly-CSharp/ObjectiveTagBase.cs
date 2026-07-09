using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000261")]
public class ObjectiveTagBase : GameMonoBehaviour
{
	[Token(Token = "0x2000262")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592E1C", Offset = "0x592E1C")]
	private sealed class _003CBlinkMaterial_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000D36")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000D37")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000D38")]
		[FieldOffset(Offset = "0x20")]
		public ObjectiveTagBase _003C_003E4__this;

		[Token(Token = "0x4000D39")]
		[FieldOffset(Offset = "0x28")]
		private GeneralConfig.ObjectiveTagInfo _003CtagInfo_003E5__2;

		[Token(Token = "0x4000D3A")]
		[FieldOffset(Offset = "0x30")]
		private Material _003CblinkMaterial_003E5__3;

		[Token(Token = "0x17000243")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000E64")]
			[Address(RVA = "0x8CD78C", Offset = "0x8CD78C", VA = "0x8CD78C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000244")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000E66")]
			[Address(RVA = "0x8CD7D4", Offset = "0x8CD7D4", VA = "0x8CD7D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000E61")]
		[Address(RVA = "0x8CD3B0", Offset = "0x8CD3B0", VA = "0x8CD3B0")]
		[DebuggerHidden]
		public _003CBlinkMaterial_003Ed__26(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000E62")]
		[Address(RVA = "0x8CD3DC", Offset = "0x8CD3DC", VA = "0x8CD3DC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000E63")]
		[Address(RVA = "0x8CD3E0", Offset = "0x8CD3E0", VA = "0x8CD3E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000E65")]
		[Address(RVA = "0x8CD794", Offset = "0x8CD794", VA = "0x8CD794", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000263")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592E2C", Offset = "0x592E2C")]
	private sealed class _003CChangeAlpha_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000D3B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000D3C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000D3D")]
		[FieldOffset(Offset = "0x20")]
		public Material material;

		[Token(Token = "0x4000D3E")]
		[FieldOffset(Offset = "0x28")]
		public float duration;

		[Token(Token = "0x4000D3F")]
		[FieldOffset(Offset = "0x2C")]
		public float startAlpha;

		[Token(Token = "0x4000D40")]
		[FieldOffset(Offset = "0x30")]
		public float endAlpha;

		[Token(Token = "0x4000D41")]
		[FieldOffset(Offset = "0x38")]
		public ObjectiveTagBase _003C_003E4__this;

		[Token(Token = "0x4000D42")]
		[FieldOffset(Offset = "0x40")]
		private Color _003Ccolor_003E5__2;

		[Token(Token = "0x4000D43")]
		[FieldOffset(Offset = "0x50")]
		private float _003CstartTime_003E5__3;

		[Token(Token = "0x4000D44")]
		[FieldOffset(Offset = "0x54")]
		private float _003CendTime_003E5__4;

		[Token(Token = "0x17000245")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000E6A")]
			[Address(RVA = "0x8CDA74", Offset = "0x8CDA74", VA = "0x8CDA74", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000246")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000E6C")]
			[Address(RVA = "0x8CDABC", Offset = "0x8CDABC", VA = "0x8CDABC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000E67")]
		[Address(RVA = "0x8CD7DC", Offset = "0x8CD7DC", VA = "0x8CD7DC")]
		[DebuggerHidden]
		public _003CChangeAlpha_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000E68")]
		[Address(RVA = "0x8CD808", Offset = "0x8CD808", VA = "0x8CD808", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000E69")]
		[Address(RVA = "0x8CD80C", Offset = "0x8CD80C", VA = "0x8CD80C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000E6B")]
		[Address(RVA = "0x8CDA7C", Offset = "0x8CDA7C", VA = "0x8CDA7C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000D2D")]
	[FieldOffset(Offset = "0x48")]
	public TargetType[] TargetTypes;

	[Token(Token = "0x4000D2E")]
	[FieldOffset(Offset = "0x50")]
	public Renderer _renderer;

	[Token(Token = "0x4000D2F")]
	[FieldOffset(Offset = "0x58")]
	public Health _health;

	[Token(Token = "0x4000D30")]
	[FieldOffset(Offset = "0x60")]
	public Trackable _trackable;

	[Token(Token = "0x4000D31")]
	[FieldOffset(Offset = "0x68")]
	public bool UseGeneralConfigTracker;

	[Token(Token = "0x4000D32")]
	[FieldOffset(Offset = "0x69")]
	protected bool _activate;

	[Token(Token = "0x4000D33")]
	[FieldOffset(Offset = "0x6A")]
	protected bool _isSceneTrackable;

	[Token(Token = "0x4000D34")]
	[FieldOffset(Offset = "0x70")]
	private Coroutine _blinkCoroutine;

	[Token(Token = "0x4000D35")]
	[FieldOffset(Offset = "0x78")]
	private TrackableBackup _trackableBackup;

	[Token(Token = "0x6000E4D")]
	[Address(RVA = "0x9EB6F8", Offset = "0x9EB6F8", VA = "0x9EB6F8", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000E4E")]
	[Address(RVA = "0x9EB3A8", Offset = "0x9EB3A8", VA = "0x9EB3A8", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000E4F")]
	[Address(RVA = "0x9EB82C", Offset = "0x9EB82C", VA = "0x9EB82C")]
	protected bool IsTypeUsed()
	{
		return default(bool);
	}

	[Token(Token = "0x6000E50")]
	[Address(RVA = "0x9EB934", Offset = "0x9EB934", VA = "0x9EB934", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000E51")]
	[Address(RVA = "0x9EBAF8", Offset = "0x9EBAF8", VA = "0x9EBAF8")]
	public Vector3 GetPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000E52")]
	[Address(RVA = "0x9EBB8C", Offset = "0x9EBB8C", VA = "0x9EBB8C", Slot = "14")]
	protected virtual void OnTakeDamage(object sender, Health.TakeDamageEventArgs args)
	{
	}

	[Token(Token = "0x6000E53")]
	[Address(RVA = "0x9EBC68", Offset = "0x9EBC68", VA = "0x9EBC68", Slot = "15")]
	protected virtual void ObjectiveTagDie()
	{
	}

	[Token(Token = "0x6000E54")]
	[Address(RVA = "0x9EBC6C", Offset = "0x9EBC6C", VA = "0x9EBC6C")]
	protected bool IsRegistered()
	{
		return default(bool);
	}

	[Token(Token = "0x6000E55")]
	[Address(RVA = "0x9EB5E4", Offset = "0x9EB5E4", VA = "0x9EB5E4")]
	protected void RegisterTag()
	{
	}

	[Token(Token = "0x6000E56")]
	[Address(RVA = "0x9EBA80", Offset = "0x9EBA80", VA = "0x9EBA80")]
	protected void UnregisterTag()
	{
	}

	[Token(Token = "0x6000E57")]
	[Address(RVA = "0x9EA7E4", Offset = "0x9EA7E4", VA = "0x9EA7E4")]
	public void Activate()
	{
	}

	[Token(Token = "0x6000E58")]
	[Address(RVA = "0x9EBCF8", Offset = "0x9EBCF8", VA = "0x9EBCF8", Slot = "16")]
	protected virtual void DoActivate()
	{
	}

	[Token(Token = "0x6000E59")]
	[Address(RVA = "0x9EB7BC", Offset = "0x9EB7BC", VA = "0x9EB7BC")]
	protected bool IsMainTarget()
	{
		return default(bool);
	}

	[Token(Token = "0x6000E5A")]
	[Address(RVA = "0x9EBE50", Offset = "0x9EBE50", VA = "0x9EBE50")]
	protected void ActiveTrackable()
	{
	}

	[Token(Token = "0x6000E5B")]
	[Address(RVA = "0x9EA4E8", Offset = "0x9EA4E8", VA = "0x9EA4E8")]
	public void Deactivate()
	{
	}

	[Token(Token = "0x6000E5C")]
	[Address(RVA = "0x9EC1D4", Offset = "0x9EC1D4", VA = "0x9EC1D4")]
	protected void DeactiveTrackable()
	{
	}

	[Token(Token = "0x6000E5D")]
	[Address(RVA = "0x9EC070", Offset = "0x9EC070", VA = "0x9EC070")]
	protected void CopyTrackableValue(object from, object to)
	{
	}

	[Token(Token = "0x6000E5E")]
	[Address(RVA = "0x9EC004", Offset = "0x9EC004", VA = "0x9EC004")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x614F14", Offset = "0x614F14")]
	private IEnumerator BlinkMaterial()
	{
		return null;
	}

	[Token(Token = "0x6000E5F")]
	[Address(RVA = "0x9EC3B4", Offset = "0x9EC3B4", VA = "0x9EC3B4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x614F74", Offset = "0x614F74")]
	private IEnumerator ChangeAlpha(Material material, float startAlpha, float endAlpha, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000E60")]
	[Address(RVA = "0x9EC454", Offset = "0x9EC454", VA = "0x9EC454")]
	public ObjectiveTagBase()
	{
	}
}
