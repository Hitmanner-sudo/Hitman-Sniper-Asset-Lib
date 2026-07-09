using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000836")]
public class InitHandler : MonoBehaviour
{
	[Token(Token = "0x2000837")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596760", Offset = "0x596760")]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		[Token(Token = "0x4002EA1")]
		[FieldOffset(Offset = "0x10")]
		public InitHandler _003C_003E4__this;

		[Token(Token = "0x4002EA2")]
		[FieldOffset(Offset = "0x18")]
		public NetworkCheckConfiguration.NetworkCheck checkOnInitType;

		[Token(Token = "0x60035D6")]
		[Address(RVA = "0xB2743C", Offset = "0xB2743C", VA = "0xB2743C")]
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		[Token(Token = "0x60035D7")]
		[Address(RVA = "0xB27444", Offset = "0xB27444", VA = "0xB27444")]
		internal void _003CStart_003Eb__0(bool hasConnectivity)
		{
		}
	}

	[Token(Token = "0x2000838")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596770", Offset = "0x596770")]
	private sealed class _003CRecheckCoroutine_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002EA3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002EA4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002EA5")]
		[FieldOffset(Offset = "0x20")]
		public InitHandler _003C_003E4__this;

		[Token(Token = "0x170006D9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60035DB")]
			[Address(RVA = "0xB275B4", Offset = "0xB275B4", VA = "0xB275B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006DA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60035DD")]
			[Address(RVA = "0xB275FC", Offset = "0xB275FC", VA = "0xB275FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60035D8")]
		[Address(RVA = "0xB274E0", Offset = "0xB274E0", VA = "0xB274E0")]
		[DebuggerHidden]
		public _003CRecheckCoroutine_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60035D9")]
		[Address(RVA = "0xB2750C", Offset = "0xB2750C", VA = "0xB2750C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60035DA")]
		[Address(RVA = "0xB27510", Offset = "0xB27510", VA = "0xB27510", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60035DC")]
		[Address(RVA = "0xB275BC", Offset = "0xB275BC", VA = "0xB275BC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4002E9E")]
	[FieldOffset(Offset = "0x0")]
	internal static NetworkCheckConfiguration _NetworkCheckConfig;

	[Token(Token = "0x4002E9F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AutoLoadScene _sceneLoader;

	[Token(Token = "0x4002EA0")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UIAnchor _offlineWarning;

	[Token(Token = "0x60035D0")]
	[Address(RVA = "0xB12E08", Offset = "0xB12E08", VA = "0xB12E08")]
	private void Awake()
	{
	}

	[Token(Token = "0x60035D1")]
	[Address(RVA = "0xB12E4C", Offset = "0xB12E4C", VA = "0xB12E4C")]
	private void Start()
	{
	}

	[Token(Token = "0x60035D2")]
	[Address(RVA = "0xB13074", Offset = "0xB13074", VA = "0xB13074")]
	private void ActivateLoader(bool isOnline)
	{
	}

	[Token(Token = "0x60035D3")]
	[Address(RVA = "0xB130C8", Offset = "0xB130C8", VA = "0xB130C8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x623270", Offset = "0x623270")]
	private IEnumerator RecheckCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60035D4")]
	[Address(RVA = "0xB13134", Offset = "0xB13134", VA = "0xB13134")]
	public InitHandler()
	{
	}
}
