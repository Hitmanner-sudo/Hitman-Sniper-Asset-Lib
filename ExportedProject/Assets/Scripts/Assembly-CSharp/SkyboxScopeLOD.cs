using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x20007DE")]
public class SkyboxScopeLOD : MonoBehaviour
{
	[Token(Token = "0x20007DF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5963E0", Offset = "0x5963E0")]
	private sealed class _003CShowSkybox_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002BEA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002BEB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002BEC")]
		[FieldOffset(Offset = "0x20")]
		public SkyboxScopeLOD _003C_003E4__this;

		[Token(Token = "0x170006A5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003394")]
			[Address(RVA = "0x8BFFD0", Offset = "0x8BFFD0", VA = "0x8BFFD0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006A6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003396")]
			[Address(RVA = "0x8C0018", Offset = "0x8C0018", VA = "0x8C0018", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003391")]
		[Address(RVA = "0x8BFF18", Offset = "0x8BFF18", VA = "0x8BFF18")]
		[DebuggerHidden]
		public _003CShowSkybox_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003392")]
		[Address(RVA = "0x8BFF44", Offset = "0x8BFF44", VA = "0x8BFF44", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003393")]
		[Address(RVA = "0x8BFF48", Offset = "0x8BFF48", VA = "0x8BFF48", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003395")]
		[Address(RVA = "0x8BFFD8", Offset = "0x8BFFD8", VA = "0x8BFFD8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4002BE8")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ScopeLOD _scopeLod;

	[Token(Token = "0x4002BE9")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Renderer _renderer;

	[Token(Token = "0x600338C")]
	[Address(RVA = "0x8469C4", Offset = "0x8469C4", VA = "0x8469C4")]
	protected void Start()
	{
	}

	[Token(Token = "0x600338D")]
	[Address(RVA = "0x846A40", Offset = "0x846A40", VA = "0x846A40")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x600338E")]
	[Address(RVA = "0x846ABC", Offset = "0x846ABC", VA = "0x846ABC")]
	private void OnLoadingViewDisabled(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x600338F")]
	[Address(RVA = "0x846AE8", Offset = "0x846AE8", VA = "0x846AE8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x622C70", Offset = "0x622C70")]
	private IEnumerator ShowSkybox()
	{
		return null;
	}

	[Token(Token = "0x6003390")]
	[Address(RVA = "0x846B54", Offset = "0x846B54", VA = "0x846B54")]
	public SkyboxScopeLOD()
	{
	}
}
