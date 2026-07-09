using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007D4")]
public class PrecacheTextures : MonoBehaviour
{
	[Token(Token = "0x20007D5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59639C", Offset = "0x59639C")]
	private sealed class _003CShowTextures_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002BC7")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002BC8")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002BC9")]
		[FieldOffset(Offset = "0x20")]
		public PrecacheTextures _003C_003E4__this;

		[Token(Token = "0x170006A0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600336C")]
			[Address(RVA = "0x8B19B8", Offset = "0x8B19B8", VA = "0x8B19B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006A1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600336E")]
			[Address(RVA = "0x8B1A00", Offset = "0x8B1A00", VA = "0x8B1A00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003369")]
		[Address(RVA = "0x8B1824", Offset = "0x8B1824", VA = "0x8B1824")]
		[DebuggerHidden]
		public _003CShowTextures_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600336A")]
		[Address(RVA = "0x8B1850", Offset = "0x8B1850", VA = "0x8B1850", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600336B")]
		[Address(RVA = "0x8B1854", Offset = "0x8B1854", VA = "0x8B1854", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600336D")]
		[Address(RVA = "0x8B19C0", Offset = "0x8B19C0", VA = "0x8B19C0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4002BC5")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UITexture _texture;

	[Token(Token = "0x4002BC6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ModelContainer _modelContainer;

	[Token(Token = "0x6003365")]
	[Address(RVA = "0xB384B8", Offset = "0xB384B8", VA = "0xB384B8")]
	protected void Start()
	{
	}

	[Token(Token = "0x6003366")]
	[Address(RVA = "0xB38534", Offset = "0xB38534", VA = "0xB38534")]
	private void OnLoadingViewDisabled(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6003367")]
	[Address(RVA = "0xB385C8", Offset = "0xB385C8", VA = "0xB385C8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x622B10", Offset = "0x622B10")]
	private IEnumerator ShowTextures()
	{
		return null;
	}

	[Token(Token = "0x6003368")]
	[Address(RVA = "0xB38634", Offset = "0xB38634", VA = "0xB38634")]
	public PrecacheTextures()
	{
	}
}
