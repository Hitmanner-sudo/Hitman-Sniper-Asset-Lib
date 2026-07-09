using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007DA")]
public class ScopeLOD : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20007DB")]
	public enum ActiveState
	{
		[Token(Token = "0x4002BDD")]
		ActiveInScope = 0,
		[Token(Token = "0x4002BDE")]
		ActiveOutOfScope = 1
	}

	[Token(Token = "0x20007DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5963BC", Offset = "0x5963BC")]
	private sealed class _003CTwoFrames_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002BDF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002BE0")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002BE1")]
		[FieldOffset(Offset = "0x20")]
		public ScopeLOD _003C_003E4__this;

		[Token(Token = "0x170006A3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003384")]
			[Address(RVA = "0x8B6B30", Offset = "0x8B6B30", VA = "0x8B6B30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006A4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003386")]
			[Address(RVA = "0x8B6B78", Offset = "0x8B6B78", VA = "0x8B6B78", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003381")]
		[Address(RVA = "0x8B6AA8", Offset = "0x8B6AA8", VA = "0x8B6AA8")]
		[DebuggerHidden]
		public _003CTwoFrames_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003382")]
		[Address(RVA = "0x8B6AD4", Offset = "0x8B6AD4", VA = "0x8B6AD4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003383")]
		[Address(RVA = "0x8B6AD8", Offset = "0x8B6AD8", VA = "0x8B6AD8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003385")]
		[Address(RVA = "0x8B6B38", Offset = "0x8B6B38", VA = "0x8B6B38", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4002BD6")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ActiveState _activeState;

	[Token(Token = "0x4002BD7")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private ActiveState _defaultState;

	[Token(Token = "0x4002BD8")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _toggleActive;

	[Token(Token = "0x4002BD9")]
	[FieldOffset(Offset = "0x21")]
	[SerializeField]
	private bool _toggleRenderers;

	[Token(Token = "0x4002BDA")]
	[FieldOffset(Offset = "0x22")]
	[SerializeField]
	private bool _onlyForHighRes;

	[Token(Token = "0x4002BDB")]
	[FieldOffset(Offset = "0x28")]
	private Renderer _cachedRenderer;

	[Token(Token = "0x6003378")]
	[Address(RVA = "0xBB314C", Offset = "0xBB314C", VA = "0xBB314C")]
	private bool IsEnable()
	{
		return default(bool);
	}

	[Token(Token = "0x6003379")]
	[Address(RVA = "0xBB317C", Offset = "0xBB317C", VA = "0xBB317C")]
	public void Awake()
	{
	}

	[Token(Token = "0x600337A")]
	[Address(RVA = "0xBB3238", Offset = "0xBB3238", VA = "0xBB3238")]
	private void Start()
	{
	}

	[Token(Token = "0x600337B")]
	[Address(RVA = "0xBB3288", Offset = "0xBB3288", VA = "0xBB3288")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x622BC0", Offset = "0x622BC0")]
	private IEnumerator TwoFrames()
	{
		return null;
	}

	[Token(Token = "0x600337C")]
	[Address(RVA = "0xBB32F4", Offset = "0xBB32F4", VA = "0xBB32F4")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x600337D")]
	[Address(RVA = "0xBB33C0", Offset = "0xBB33C0", VA = "0xBB33C0")]
	public void SetDefaultLOD()
	{
	}

	[Token(Token = "0x600337E")]
	[Address(RVA = "0xBB33C8", Offset = "0xBB33C8", VA = "0xBB33C8")]
	public void SetLOD(ActiveState lod)
	{
	}

	[Token(Token = "0x600337F")]
	[Address(RVA = "0xBB34A4", Offset = "0xBB34A4", VA = "0xBB34A4")]
	public static void SetInScopeForAllObjects(bool inScope)
	{
	}

	[Token(Token = "0x6003380")]
	[Address(RVA = "0xBB35BC", Offset = "0xBB35BC", VA = "0xBB35BC")]
	public ScopeLOD()
	{
	}
}
