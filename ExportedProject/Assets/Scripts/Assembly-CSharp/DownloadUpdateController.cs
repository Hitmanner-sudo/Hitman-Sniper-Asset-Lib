using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology.Core.Auth;
using Technology.Distribution;
using Technology.Shop;

[Token(Token = "0x2000518")]
public class DownloadUpdateController : UIController
{
	[Token(Token = "0x2000519")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594F9C", Offset = "0x594F9C")]
	private sealed class _003CSetDownloadCompleted_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001AEE")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001AEF")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001AF0")]
		[FieldOffset(Offset = "0x20")]
		public DownloadUpdateController _003C_003E4__this;

		[Token(Token = "0x170004CF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001F78")]
			[Address(RVA = "0x86C458", Offset = "0x86C458", VA = "0x86C458", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001F7A")]
			[Address(RVA = "0x86C4A0", Offset = "0x86C4A0", VA = "0x86C4A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001F75")]
		[Address(RVA = "0x86C21C", Offset = "0x86C21C", VA = "0x86C21C")]
		[DebuggerHidden]
		public _003CSetDownloadCompleted_003Ed__23(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001F76")]
		[Address(RVA = "0x86C248", Offset = "0x86C248", VA = "0x86C248", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001F77")]
		[Address(RVA = "0x86C24C", Offset = "0x86C24C", VA = "0x86C24C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001F79")]
		[Address(RVA = "0x86C460", Offset = "0x86C460", VA = "0x86C460", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001AE9")]
	[FieldOffset(Offset = "0x0")]
	private static DownloadUpdateController _instance;

	[Token(Token = "0x4001AEA")]
	[FieldOffset(Offset = "0x50")]
	private bool _updating;

	[Token(Token = "0x4001AEB")]
	[FieldOffset(Offset = "0x54")]
	private int _notReadyOfferCount;

	[Token(Token = "0x4001AEC")]
	[FieldOffset(Offset = "0x58")]
	private int _allOffersCount;

	[Token(Token = "0x4001AED")]
	[FieldOffset(Offset = "0x60")]
	private readonly HashSet<string> _loadedBundle;

	[Token(Token = "0x170004CE")]
	private int ReadyOfferCount
	{
		[Token(Token = "0x6001F5D")]
		[Address(RVA = "0xC1C0FC", Offset = "0xC1C0FC", VA = "0xC1C0FC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6001F5E")]
	[Address(RVA = "0xC1C108", Offset = "0xC1C108", VA = "0xC1C108")]
	private static bool AllPreparingOffersFilter(Offer offer)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F5F")]
	[Address(RVA = "0xC1C128", Offset = "0xC1C128", VA = "0xC1C128", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6001F60")]
	[Address(RVA = "0xC1C2F0", Offset = "0xC1C2F0", VA = "0xC1C2F0", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6001F61")]
	[Address(RVA = "0xC1C3C4", Offset = "0xC1C3C4", VA = "0xC1C3C4")]
	private void StartDynamicUpdate()
	{
	}

	[Token(Token = "0x6001F62")]
	[Address(RVA = "0xC1C98C", Offset = "0xC1C98C", VA = "0xC1C98C")]
	private void OnSquareEnixConnected(object sender, AuthenticationEvent e)
	{
	}

	[Token(Token = "0x6001F63")]
	[Address(RVA = "0xC1CB60", Offset = "0xC1CB60", VA = "0xC1CB60", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6001F64")]
	[Address(RVA = "0xC1CC80", Offset = "0xC1CC80", VA = "0xC1CC80")]
	private void StopDynamicUpdate()
	{
	}

	[Token(Token = "0x6001F65")]
	[Address(RVA = "0xC1CEBC", Offset = "0xC1CEBC", VA = "0xC1CEBC", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6001F66")]
	[Address(RVA = "0xC1D024", Offset = "0xC1D024", VA = "0xC1D024")]
	private void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6001F67")]
	[Address(RVA = "0xC1D4B0", Offset = "0xC1D4B0", VA = "0xC1D4B0")]
	private void CheckDynamicUpdate()
	{
	}

	[Token(Token = "0x6001F68")]
	[Address(RVA = "0xC1D548", Offset = "0xC1D548", VA = "0xC1D548")]
	private void OnGameConfigurationInitialized()
	{
	}

	[Token(Token = "0x6001F69")]
	[Address(RVA = "0xC1D6B8", Offset = "0xC1D6B8", VA = "0xC1D6B8")]
	private void OnGameConfigurationError()
	{
	}

	[Token(Token = "0x6001F6A")]
	[Address(RVA = "0xC1D744", Offset = "0xC1D744", VA = "0xC1D744")]
	private void OnLoadedBundle(Bundle b)
	{
	}

	[Token(Token = "0x6001F6B")]
	[Address(RVA = "0xC1D874", Offset = "0xC1D874", VA = "0xC1D874")]
	private void OnAllShopsRefreshed(object sender, ShopEvent e)
	{
	}

	[Token(Token = "0x6001F6C")]
	[Address(RVA = "0xC1DBC0", Offset = "0xC1DBC0", VA = "0xC1DBC0")]
	private void OnOfferDownloadComplete(object sender, OfferEvent e)
	{
	}

	[Token(Token = "0x6001F6D")]
	[Address(RVA = "0xC1D238", Offset = "0xC1D238", VA = "0xC1D238")]
	private void OnCompletedObjectsChanged(int value)
	{
	}

	[Token(Token = "0x6001F6E")]
	[Address(RVA = "0xC1DD5C", Offset = "0xC1DD5C", VA = "0xC1DD5C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x619078", Offset = "0x619078")]
	private IEnumerator SetDownloadCompleted()
	{
		return null;
	}

	[Token(Token = "0x6001F6F")]
	[Address(RVA = "0xC1D2E4", Offset = "0xC1D2E4", VA = "0xC1D2E4")]
	private void OnDownloadCompleted()
	{
	}

	[Token(Token = "0x6001F70")]
	[Address(RVA = "0xC1DDC8", Offset = "0xC1DDC8", VA = "0xC1DDC8")]
	public static void ShowForceAppUpdatePopup()
	{
	}

	[Token(Token = "0x6001F71")]
	[Address(RVA = "0xC1DF7C", Offset = "0xC1DF7C", VA = "0xC1DF7C")]
	private void OnUpdateApp()
	{
	}

	[Token(Token = "0x6001F72")]
	[Address(RVA = "0xC1E104", Offset = "0xC1E104", VA = "0xC1E104")]
	public DownloadUpdateController()
	{
	}

	[Token(Token = "0x6001F73")]
	[Address(RVA = "0xC1E184", Offset = "0xC1E184", VA = "0xC1E184")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6190D8", Offset = "0x6190D8")]
	private void _003COnSquareEnixConnected_003Eb__11_0(GlobalConfigManager.VersionCheckResult result)
	{
	}

	[Token(Token = "0x6001F74")]
	[Address(RVA = "0xC1E24C", Offset = "0xC1E24C", VA = "0xC1E24C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6190E8", Offset = "0x6190E8")]
	private void _003COnSquareEnixConnected_003Eb__11_1(GlobalConfig.DocumentVersion latestPrivacyPolicyVersion, GlobalConfig.DocumentVersion latestTermsVersion)
	{
	}
}
