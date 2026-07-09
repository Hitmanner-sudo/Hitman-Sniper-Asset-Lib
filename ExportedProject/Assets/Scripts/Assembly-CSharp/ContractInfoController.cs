using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200050E")]
public class ContractInfoController : UIController
{
	[Token(Token = "0x200050F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594F3C", Offset = "0x594F3C")]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		[Token(Token = "0x4001AD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public WeaponUnlockable equippedWeapon;

		[Token(Token = "0x6001F2E")]
		[Address(RVA = "0x863A08", Offset = "0x863A08", VA = "0x863A08")]
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6001F2F")]
		[Address(RVA = "0x863A10", Offset = "0x863A10", VA = "0x863A10")]
		internal bool _003Cget_ShouldShowSuggestedWeaponPopup_003Eb__0(WeaponUnlockable w)
		{
			return default(bool);
		}
	}

	[Serializable]
	[Token(Token = "0x2000510")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594F4C", Offset = "0x594F4C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001AD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001AD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<MissionData.WeaponSuggestionData.WeaponPromoSuggestion, WeaponUnlockable> _003C_003E9__11_0;

		[Token(Token = "0x4001AD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<WeaponUnlockable, bool> _003C_003E9__11_1;

		[Token(Token = "0x6001F31")]
		[Address(RVA = "0x863838", Offset = "0x863838", VA = "0x863838")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001F32")]
		[Address(RVA = "0x863840", Offset = "0x863840", VA = "0x863840")]
		internal WeaponUnlockable _003CValidWeaponSuggestion_003Eb__11_0(MissionData.WeaponSuggestionData.WeaponPromoSuggestion w)
		{
			return null;
		}

		[Token(Token = "0x6001F33")]
		[Address(RVA = "0x86384C", Offset = "0x86384C", VA = "0x86384C")]
		internal bool _003CValidWeaponSuggestion_003Eb__11_1(WeaponUnlockable w)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000511")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594F5C", Offset = "0x594F5C")]
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		[Token(Token = "0x4001AD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Wallet.CurrencyAmount reward;

		[Token(Token = "0x6001F34")]
		[Address(RVA = "0x863940", Offset = "0x863940", VA = "0x863940")]
		public _003C_003Ec__DisplayClass19_0()
		{
		}

		[Token(Token = "0x6001F35")]
		[Address(RVA = "0x863948", Offset = "0x863948", VA = "0x863948")]
		internal void _003COnApplicationPause_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000512")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594F6C", Offset = "0x594F6C")]
	private sealed class _003CLoadLevelCoroutine_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001AD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001AD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001ADA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ContractInfoController _003C_003E4__this;

		[Token(Token = "0x4001ADB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AsyncOperation _003CasyncOp_003E5__2;

		[Token(Token = "0x170004C9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001F39")]
			[Address(RVA = "0x863B94", Offset = "0x863B94", VA = "0x863B94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004CA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001F3B")]
			[Address(RVA = "0x863BDC", Offset = "0x863BDC", VA = "0x863BDC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001F36")]
		[Address(RVA = "0x863A88", Offset = "0x863A88", VA = "0x863A88")]
		[DebuggerHidden]
		public _003CLoadLevelCoroutine_003Ed__28(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001F37")]
		[Address(RVA = "0x863AB4", Offset = "0x863AB4", VA = "0x863AB4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001F38")]
		[Address(RVA = "0x863AB8", Offset = "0x863AB8", VA = "0x863AB8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001F3A")]
		[Address(RVA = "0x863B9C", Offset = "0x863B9C", VA = "0x863B9C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000513")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594F7C", Offset = "0x594F7C")]
	private sealed class _003CShowWeaponSuggestionsCoroutine_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001ADC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001ADD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001ADE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ContractInfoController _003C_003E4__this;

		[Token(Token = "0x4001ADF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public WeaponUnlockable[] validWeapons;

		[Token(Token = "0x170004CB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001F3F")]
			[Address(RVA = "0x863CF0", Offset = "0x863CF0", VA = "0x863CF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004CC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001F41")]
			[Address(RVA = "0x863D38", Offset = "0x863D38", VA = "0x863D38", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001F3C")]
		[Address(RVA = "0x863BE4", Offset = "0x863BE4", VA = "0x863BE4")]
		[DebuggerHidden]
		public _003CShowWeaponSuggestionsCoroutine_003Ed__31(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001F3D")]
		[Address(RVA = "0x863C10", Offset = "0x863C10", VA = "0x863C10", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001F3E")]
		[Address(RVA = "0x863C14", Offset = "0x863C14", VA = "0x863C14", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001F40")]
		[Address(RVA = "0x863CF8", Offset = "0x863CF8", VA = "0x863CF8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001ACB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public BlinkButtonHandler AcceptButton;

	[Token(Token = "0x4001ACC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public ButtonHandler DisplayEventVisualButton;

	[Token(Token = "0x4001ACD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public BlinkButtonHandler FacebookLikeButton;

	[Token(Token = "0x4001ACE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject _startButton;

	[Token(Token = "0x4001ACF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private LazyWeaponSuggestionPopupView _weaponSuggestionPopupPrefab;

	[Token(Token = "0x4001AD0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly Dictionary<string, ShopCampaignManager.Promotion> _promotions;

	[Token(Token = "0x4001AD1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool _waitingForFacebookReward;

	[Token(Token = "0x4001AD2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	private bool _doLoad;

	[Token(Token = "0x170004C8")]
	private bool ShouldShowSuggestedWeaponPopup
	{
		[Token(Token = "0x6001F12")]
		[Address(RVA = "0x8E7068", Offset = "0x8E7068", VA = "0x8E7068")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001F13")]
	[Address(RVA = "0x8E757C", Offset = "0x8E757C", VA = "0x8E757C", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6001F14")]
	[Address(RVA = "0x8E729C", Offset = "0x8E729C", VA = "0x8E729C")]
	private static IEnumerable<WeaponUnlockable> ValidWeaponSuggestion(MissionData.WeaponSuggestionData.WeaponPromoSuggestion[] suggestedWeapons)
	{
		return null;
	}

	[Token(Token = "0x6001F15")]
	[Address(RVA = "0x8E75A4", Offset = "0x8E75A4", VA = "0x8E75A4", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6001F16")]
	[Address(RVA = "0x8E78F8", Offset = "0x8E78F8", VA = "0x8E78F8")]
	private void RefreshSuggestedWeaponPromotion()
	{
	}

	[Token(Token = "0x6001F17")]
	[Address(RVA = "0x8E7C9C", Offset = "0x8E7C9C", VA = "0x8E7C9C")]
	private static void ValidateRankProgression()
	{
	}

	[Token(Token = "0x6001F18")]
	[Address(RVA = "0x8E7DC0", Offset = "0x8E7DC0", VA = "0x8E7DC0")]
	private void ClearPromotions(bool skipSave = false)
	{
	}

	[Token(Token = "0x6001F19")]
	[Address(RVA = "0x8E7FA8", Offset = "0x8E7FA8", VA = "0x8E7FA8")]
	private static void RefreshBlueprintViewPromotions()
	{
	}

	[Token(Token = "0x6001F1A")]
	[Address(RVA = "0x8E81C8", Offset = "0x8E81C8", VA = "0x8E81C8", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6001F1B")]
	[Address(RVA = "0x8E83F0", Offset = "0x8E83F0", VA = "0x8E83F0", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6001F1C")]
	[Address(RVA = "0x8E841C", Offset = "0x8E841C", VA = "0x8E841C")]
	protected void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x6001F1D")]
	[Address(RVA = "0x8E8668", Offset = "0x8E8668", VA = "0x8E8668")]
	private void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs e)
	{
	}

	[Token(Token = "0x6001F1E")]
	[Address(RVA = "0x8E870C", Offset = "0x8E870C", VA = "0x8E870C")]
	private void OnMissionChanged()
	{
	}

	[Token(Token = "0x6001F1F")]
	[Address(RVA = "0x8E8794", Offset = "0x8E8794", VA = "0x8E8794")]
	private void OnFacebookLikeButtonBlinkFinished(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6001F20")]
	[Address(RVA = "0x8E8AAC", Offset = "0x8E8AAC", VA = "0x8E8AAC")]
	private void GoToFacebookPage()
	{
	}

	[Token(Token = "0x6001F21")]
	[Address(RVA = "0x8E8CD4", Offset = "0x8E8CD4", VA = "0x8E8CD4")]
	private void OnAcceptClickFinished(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6001F22")]
	[Address(RVA = "0x8E8EFC", Offset = "0x8E8EFC", VA = "0x8E8EFC")]
	private void OnInternetReachabilityTestComplete(bool isReachable, Action actionOnContinue, [Optional] Action actionWhenBlocked)
	{
	}

	[Token(Token = "0x6001F23")]
	[Address(RVA = "0x8E9038", Offset = "0x8E9038", VA = "0x8E9038")]
	private void OnMissionShallBeLoaded(bool isReachable)
	{
	}

	[Token(Token = "0x6001F24")]
	[Address(RVA = "0x8E90C4", Offset = "0x8E90C4", VA = "0x8E90C4")]
	private void LoadLevel()
	{
	}

	[Token(Token = "0x6001F25")]
	[Address(RVA = "0x8E90FC", Offset = "0x8E90FC", VA = "0x8E90FC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x618ED8", Offset = "0x618ED8")]
	private IEnumerator LoadLevelCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6001F26")]
	[Address(RVA = "0x8E9168", Offset = "0x8E9168", VA = "0x8E9168")]
	private void OnWeaponShallBeSuggested(bool isReachable)
	{
	}

	[Token(Token = "0x6001F27")]
	[Address(RVA = "0x8E91F4", Offset = "0x8E91F4", VA = "0x8E91F4")]
	private void SuggestWeaponForMission()
	{
	}

	[Token(Token = "0x6001F28")]
	[Address(RVA = "0x8E92C4", Offset = "0x8E92C4", VA = "0x8E92C4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x618F38", Offset = "0x618F38")]
	private IEnumerator ShowWeaponSuggestionsCoroutine(WeaponUnlockable[] validWeapons)
	{
		return null;
	}

	[Token(Token = "0x6001F29")]
	[Address(RVA = "0x8E933C", Offset = "0x8E933C", VA = "0x8E933C")]
	private void ShowWeaponSuggestions(WeaponUnlockable[] weapons)
	{
	}

	[Token(Token = "0x6001F2A")]
	[Address(RVA = "0x8E963C", Offset = "0x8E963C", VA = "0x8E963C")]
	private void OnDisplayEventVisualButtonClicked(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6001F2B")]
	[Address(RVA = "0x8E97B4", Offset = "0x8E97B4", VA = "0x8E97B4", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x6001F2C")]
	[Address(RVA = "0x8E9870", Offset = "0x8E9870", VA = "0x8E9870")]
	public ContractInfoController()
	{
	}

	[Token(Token = "0x6001F2D")]
	[Address(RVA = "0x8E98E8", Offset = "0x8E98E8", VA = "0x8E98E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618F98", Offset = "0x618F98")]
	private void _003CShowWeaponSuggestions_003Eb__32_0()
	{
	}
}
