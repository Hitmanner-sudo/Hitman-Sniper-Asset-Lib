using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000661")]
public class DailyRewardButtonView : View
{
	[Token(Token = "0x2000662")]
	private struct StaminaItem
	{
		[Token(Token = "0x4002365")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B8D9C", Offset = "0x5B8D9C")]
		private GameObject _003CDisabledObject_003Ek__BackingField;

		[Token(Token = "0x4002366")]
		[FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B8DAC", Offset = "0x5B8DAC")]
		private GameObject _003CActiveObject_003Ek__BackingField;

		[Token(Token = "0x17000559")]
		public GameObject DisabledObject
		{
			[Token(Token = "0x600296A")]
			[Address(RVA = "0x869FC0", Offset = "0x869FC0", VA = "0x869FC0")]
			[System.Runtime.CompilerServices.IsReadOnly]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61DC58", Offset = "0x61DC58")]
			get
			{
				return null;
			}
			[Token(Token = "0x600296B")]
			[Address(RVA = "0x869FC8", Offset = "0x869FC8", VA = "0x869FC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61DC90", Offset = "0x61DC90")]
			set
			{
			}
		}

		[Token(Token = "0x1700055A")]
		public GameObject ActiveObject
		{
			[Token(Token = "0x600296C")]
			[Address(RVA = "0x869FD0", Offset = "0x869FD0", VA = "0x869FD0")]
			[System.Runtime.CompilerServices.IsReadOnly]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61DCA0", Offset = "0x61DCA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600296D")]
			[Address(RVA = "0x869FD8", Offset = "0x869FD8", VA = "0x869FD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61DCD8", Offset = "0x61DCD8")]
			set
			{
			}
		}
	}

	[Token(Token = "0x2000663")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595838", Offset = "0x595838")]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		[Token(Token = "0x4002367")]
		[FieldOffset(Offset = "0x10")]
		public DailyRewardButtonView view;

		[Token(Token = "0x4002368")]
		[FieldOffset(Offset = "0x18")]
		public Action onVisualUpdated;

		[Token(Token = "0x4002369")]
		[FieldOffset(Offset = "0x20")]
		public MonoBehaviour coroutineObject;

		[Token(Token = "0x600296E")]
		[Address(RVA = "0x869F3C", Offset = "0x869F3C", VA = "0x869F3C")]
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		[Token(Token = "0x600296F")]
		[Address(RVA = "0x869F44", Offset = "0x869F44", VA = "0x869F44")]
		internal void _003CRefreshVisual_003Eb__0()
		{
		}
	}

	[Token(Token = "0x4002359")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private ButtonHandler _collectButton;

	[Token(Token = "0x400235A")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private UILabel _collectLabel;

	[Token(Token = "0x400235B")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private UILabel _noAdsTimer;

	[Token(Token = "0x400235C")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GameObject _notificationSprite;

	[Token(Token = "0x400235D")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private UILabel _timer;

	[Token(Token = "0x400235E")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UIAnchor _timerAnchor;

	[Token(Token = "0x400235F")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private UIAlignedList _adsStaminaBars;

	[Token(Token = "0x4002360")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private GameObject _adsStaminaBar;

	[Token(Token = "0x4002361")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private UILabel _adsStaminaCount;

	[Token(Token = "0x4002362")]
	[FieldOffset(Offset = "0xA8")]
	private DailyRewardsData _dailyRewardsData;

	[Token(Token = "0x4002363")]
	[FieldOffset(Offset = "0xB0")]
	private readonly List<StaminaItem> _adsHighlight;

	[Token(Token = "0x4002364")]
	[FieldOffset(Offset = "0x0")]
	private static readonly TimeSpan _timerOffset;

	[Token(Token = "0x17000558")]
	private DailyRewardsData DailyRewardsData
	{
		[Token(Token = "0x6002961")]
		[Address(RVA = "0xADD260", Offset = "0xADD260", VA = "0xADD260")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002962")]
	[Address(RVA = "0xADD360", Offset = "0xADD360", VA = "0xADD360", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002963")]
	[Address(RVA = "0xADD700", Offset = "0xADD700", VA = "0xADD700")]
	public static void RefreshVisual(DailyRewardButtonView view, Action onVisualUpdated, MonoBehaviour coroutineObject)
	{
	}

	[Token(Token = "0x6002964")]
	[Address(RVA = "0xADD41C", Offset = "0xADD41C", VA = "0xADD41C")]
	private void CreateAdsStamina()
	{
	}

	[Token(Token = "0x6002965")]
	[Address(RVA = "0xADD854", Offset = "0xADD854", VA = "0xADD854", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002966")]
	[Address(RVA = "0xADD908", Offset = "0xADD908", VA = "0xADD908")]
	private void RefreshCollectTimer()
	{
	}

	[Token(Token = "0x6002967")]
	[Address(RVA = "0xADD390", Offset = "0xADD390", VA = "0xADD390")]
	private void RefreshCollectTimerCallback()
	{
	}

	[Token(Token = "0x6002968")]
	[Address(RVA = "0xADDDCC", Offset = "0xADDDCC", VA = "0xADDDCC")]
	public DailyRewardButtonView()
	{
	}
}
