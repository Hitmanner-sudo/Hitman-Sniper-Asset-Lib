using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200068A")]
public class LoadingView : BaseLoadingView
{
	[Token(Token = "0x200068B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595988", Offset = "0x595988")]
	private sealed class _003CFadeMenuMusicAndStart_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40024B7")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40024B8")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40024B9")]
		[FieldOffset(Offset = "0x20")]
		public LoadingView _003C_003E4__this;

		[Token(Token = "0x40024BA")]
		[FieldOffset(Offset = "0x28")]
		private ContinuousTimer _003Ctimer_003E5__2;

		[Token(Token = "0x1700057F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002AE8")]
			[Address(RVA = "0x8C2794", Offset = "0x8C2794", VA = "0x8C2794", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000580")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002AEA")]
			[Address(RVA = "0x8C27DC", Offset = "0x8C27DC", VA = "0x8C27DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002AE5")]
		[Address(RVA = "0x8C25A4", Offset = "0x8C25A4", VA = "0x8C25A4")]
		[DebuggerHidden]
		public _003CFadeMenuMusicAndStart_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002AE6")]
		[Address(RVA = "0x8C25D0", Offset = "0x8C25D0", VA = "0x8C25D0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002AE7")]
		[Address(RVA = "0x8C25D4", Offset = "0x8C25D4", VA = "0x8C25D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002AE9")]
		[Address(RVA = "0x8C279C", Offset = "0x8C279C", VA = "0x8C279C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40024AE")]
	[FieldOffset(Offset = "0x90")]
	public UILabel TipLabel;

	[Token(Token = "0x40024AF")]
	[FieldOffset(Offset = "0x98")]
	public LazyGameObject LoadingBackgroundTipPrefab;

	[Token(Token = "0x40024B0")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private UISlider _loadingSlider;

	[Token(Token = "0x40024B1")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private UIAnchor _tipLoadingBarAnchor;

	[Token(Token = "0x40024B2")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private UIAnchor _noTipLoadingBarAnchor;

	[Token(Token = "0x40024B3")]
	[FieldOffset(Offset = "0xB8")]
	private GameObject _tipBackgroundNewGameObject;

	[Token(Token = "0x40024B4")]
	[FieldOffset(Offset = "0xC0")]
	private bool _canAdvanceLoadingBar;

	[Token(Token = "0x40024B5")]
	[FieldOffset(Offset = "0xC4")]
	private float _downloadPercentageWeight;

	[Token(Token = "0x40024B6")]
	[FieldOffset(Offset = "0xC8")]
	private float _levelLoadPercentageWeight;

	[Token(Token = "0x6002AD2")]
	[Address(RVA = "0x9D2DA4", Offset = "0x9D2DA4", VA = "0x9D2DA4", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002AD3")]
	[Address(RVA = "0x9D2F3C", Offset = "0x9D2F3C", VA = "0x9D2F3C", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002AD4")]
	[Address(RVA = "0x9D2FBC", Offset = "0x9D2FBC", VA = "0x9D2FBC", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002AD5")]
	[Address(RVA = "0x9D31FC", Offset = "0x9D31FC", VA = "0x9D31FC", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x6002AD6")]
	[Address(RVA = "0x9D3340", Offset = "0x9D3340", VA = "0x9D3340")]
	public void OnScreenTapped(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002AD7")]
	[Address(RVA = "0x9D33B4", Offset = "0x9D33B4", VA = "0x9D33B4")]
	public void OnLoadingDone(bool display)
	{
	}

	[Token(Token = "0x6002AD8")]
	[Address(RVA = "0x9D34C0", Offset = "0x9D34C0", VA = "0x9D34C0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61E6B8", Offset = "0x61E6B8")]
	private IEnumerator FadeMenuMusicAndStart()
	{
		return null;
	}

	[Token(Token = "0x6002AD9")]
	[Address(RVA = "0x9D352C", Offset = "0x9D352C", VA = "0x9D352C", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002ADA")]
	[Address(RVA = "0x9D377C", Offset = "0x9D377C", VA = "0x9D377C", Slot = "15")]
	protected override void SetUpBackground()
	{
	}

	[Token(Token = "0x6002ADB")]
	[Address(RVA = "0x9D3924", Offset = "0x9D3924", VA = "0x9D3924")]
	private void SetHint()
	{
	}

	[Token(Token = "0x6002ADC")]
	[Address(RVA = "0x9D3E14", Offset = "0x9D3E14", VA = "0x9D3E14")]
	private void FillBackgroundDetail(GameObject newGameObject, UIViewModel.LoadingBackgroundDetail backgroundHint)
	{
	}

	[Token(Token = "0x6002ADD")]
	[Address(RVA = "0x9D3BE8", Offset = "0x9D3BE8", VA = "0x9D3BE8")]
	private UIViewModel.LoadingBackgroundDetail SelectNewBackgroundHint()
	{
		return null;
	}

	[Token(Token = "0x6002ADE")]
	[Address(RVA = "0x9D4124", Offset = "0x9D4124", VA = "0x9D4124")]
	private int GetValidIndex(UIViewModel.LoadingBackgroundDetail[] backgroundDetails, ContractData.ModeTypeEnum currentContractType, int currentMissionID)
	{
		return default(int);
	}

	[Token(Token = "0x6002ADF")]
	[Address(RVA = "0x9D3D28", Offset = "0x9D3D28", VA = "0x9D3D28")]
	private string SelectNewHint()
	{
		return null;
	}

	[Token(Token = "0x6002AE0")]
	[Address(RVA = "0x9D4380", Offset = "0x9D4380", VA = "0x9D4380")]
	private string[] GetCurrentMissionHintKeys()
	{
		return null;
	}

	[Token(Token = "0x6002AE1")]
	[Address(RVA = "0x9D2EB4", Offset = "0x9D2EB4", VA = "0x9D2EB4")]
	private void OnDownloadCompleted(bool completed)
	{
	}

	[Token(Token = "0x6002AE2")]
	[Address(RVA = "0x9D440C", Offset = "0x9D440C", VA = "0x9D440C")]
	private void OnCanAdvanceLoadingBarChanged(bool canAdvance)
	{
	}

	[Token(Token = "0x6002AE3")]
	[Address(RVA = "0x9D3200", Offset = "0x9D3200", VA = "0x9D3200")]
	private void UpdateLoadingSlider()
	{
	}

	[Token(Token = "0x6002AE4")]
	[Address(RVA = "0x9D4418", Offset = "0x9D4418", VA = "0x9D4418")]
	public LoadingView()
	{
	}
}
