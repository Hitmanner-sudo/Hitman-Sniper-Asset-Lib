using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology.Social;
using UnityEngine;

[Token(Token = "0x200066D")]
public class HUDView : View
{
	[Token(Token = "0x200066E")]
	public class CompletionPanelDisplayChangedArgs : EventArgs
	{
		[Token(Token = "0x40023E1")]
		[FieldOffset(Offset = "0x10")]
		public bool Displayed;

		[Token(Token = "0x6002A06")]
		[Address(RVA = "0xB1FE50", Offset = "0xB1FE50", VA = "0xB1FE50")]
		public CompletionPanelDisplayChangedArgs()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200066F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595898", Offset = "0x595898")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40023E2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40023E3")]
		[FieldOffset(Offset = "0x8")]
		public static Func<CalenderModel.AlternateLevel, bool> _003C_003E9__89_0;

		[Token(Token = "0x40023E4")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<UITweener> _003C_003E9__124_0;

		[Token(Token = "0x40023E5")]
		[FieldOffset(Offset = "0x18")]
		public static Predicate<UITweener> _003C_003E9__124_1;

		[Token(Token = "0x40023E6")]
		[FieldOffset(Offset = "0x20")]
		public static Func<UITweener, bool> _003C_003E9__139_0;

		[Token(Token = "0x6002A08")]
		[Address(RVA = "0xB1EB04", Offset = "0xB1EB04", VA = "0xB1EB04")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002A09")]
		[Address(RVA = "0xB1EB0C", Offset = "0xB1EB0C", VA = "0xB1EB0C")]
		internal bool _003CAwake_003Eb__89_0(CalenderModel.AlternateLevel l)
		{
			return default(bool);
		}

		[Token(Token = "0x6002A0A")]
		[Address(RVA = "0xB1EBA0", Offset = "0xB1EBA0", VA = "0xB1EBA0")]
		internal bool _003CVerifyTweenerCache_003Eb__124_0(UITweener t)
		{
			return default(bool);
		}

		[Token(Token = "0x6002A0B")]
		[Address(RVA = "0xB1EC08", Offset = "0xB1EC08", VA = "0xB1EC08")]
		internal bool _003CVerifyTweenerCache_003Eb__124_1(UITweener t)
		{
			return default(bool);
		}

		[Token(Token = "0x6002A0C")]
		[Address(RVA = "0xB1EC70", Offset = "0xB1EC70", VA = "0xB1EC70")]
		internal bool _003CDelayOnAlertLevelChanged_003Eb__139_0(UITweener x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000670")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5958A8", Offset = "0x5958A8")]
	private sealed class _003C_003Ec__DisplayClass91_0
	{
		[Token(Token = "0x40023E7")]
		[FieldOffset(Offset = "0x10")]
		public HUDView _003C_003E4__this;

		[Token(Token = "0x40023E8")]
		[FieldOffset(Offset = "0x18")]
		public RogueArrivalTimerController controller;

		[Token(Token = "0x6002A0D")]
		[Address(RVA = "0xB1ED08", Offset = "0xB1ED08", VA = "0xB1ED08")]
		public _003C_003Ec__DisplayClass91_0()
		{
		}

		[Token(Token = "0x6002A0E")]
		[Address(RVA = "0xB1ED10", Offset = "0xB1ED10", VA = "0xB1ED10")]
		internal void _003CInstantiateRogueArrivalTimer_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000671")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5958B8", Offset = "0x5958B8")]
	private sealed class _003CUpdateExtraction_003Ed__103 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40023E9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40023EA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40023EB")]
		[FieldOffset(Offset = "0x20")]
		public float totalTimeLeft;

		[Token(Token = "0x40023EC")]
		[FieldOffset(Offset = "0x28")]
		public HUDView _003C_003E4__this;

		[Token(Token = "0x40023ED")]
		[FieldOffset(Offset = "0x30")]
		public string plurialText;

		[Token(Token = "0x40023EE")]
		[FieldOffset(Offset = "0x38")]
		public string singularText;

		[Token(Token = "0x40023EF")]
		[FieldOffset(Offset = "0x40")]
		private float _003CstartTime_003E5__2;

		[Token(Token = "0x17000565")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002A12")]
			[Address(RVA = "0xB1FE00", Offset = "0xB1FE00", VA = "0xB1FE00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000566")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002A14")]
			[Address(RVA = "0xB1FE48", Offset = "0xB1FE48", VA = "0xB1FE48", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002A0F")]
		[Address(RVA = "0xB1FC3C", Offset = "0xB1FC3C", VA = "0xB1FC3C")]
		[DebuggerHidden]
		public _003CUpdateExtraction_003Ed__103(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002A10")]
		[Address(RVA = "0xB1FC68", Offset = "0xB1FC68", VA = "0xB1FC68", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002A11")]
		[Address(RVA = "0xB1FC6C", Offset = "0xB1FC6C", VA = "0xB1FC6C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002A13")]
		[Address(RVA = "0xB1FE08", Offset = "0xB1FE08", VA = "0xB1FE08", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000672")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5958C8", Offset = "0x5958C8")]
	private sealed class _003CDisplayMissionInfo_003Ed__111 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40023F0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40023F1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40023F2")]
		[FieldOffset(Offset = "0x20")]
		public HUDView _003C_003E4__this;

		[Token(Token = "0x17000567")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002A18")]
			[Address(RVA = "0xB1F4E0", Offset = "0xB1F4E0", VA = "0xB1F4E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000568")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002A1A")]
			[Address(RVA = "0xB1F528", Offset = "0xB1F528", VA = "0xB1F528", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002A15")]
		[Address(RVA = "0xB1F2AC", Offset = "0xB1F2AC", VA = "0xB1F2AC")]
		[DebuggerHidden]
		public _003CDisplayMissionInfo_003Ed__111(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002A16")]
		[Address(RVA = "0xB1F2D8", Offset = "0xB1F2D8", VA = "0xB1F2D8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002A17")]
		[Address(RVA = "0xB1F2DC", Offset = "0xB1F2DC", VA = "0xB1F2DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002A19")]
		[Address(RVA = "0xB1F4E8", Offset = "0xB1F4E8", VA = "0xB1F4E8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000673")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5958D8", Offset = "0x5958D8")]
	private sealed class _003CGotoTallyScreen_003Ed__112 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40023F3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40023F4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40023F5")]
		[FieldOffset(Offset = "0x20")]
		public HUDView _003C_003E4__this;

		[Token(Token = "0x17000569")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002A1E")]
			[Address(RVA = "0xB1FA74", Offset = "0xB1FA74", VA = "0xB1FA74", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700056A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002A20")]
			[Address(RVA = "0xB1FABC", Offset = "0xB1FABC", VA = "0xB1FABC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002A1B")]
		[Address(RVA = "0xB1F8AC", Offset = "0xB1F8AC", VA = "0xB1F8AC")]
		[DebuggerHidden]
		public _003CGotoTallyScreen_003Ed__112(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002A1C")]
		[Address(RVA = "0xB1F8D8", Offset = "0xB1F8D8", VA = "0xB1F8D8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002A1D")]
		[Address(RVA = "0xB1F8DC", Offset = "0xB1F8DC", VA = "0xB1F8DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002A1F")]
		[Address(RVA = "0xB1FA7C", Offset = "0xB1FA7C", VA = "0xB1FA7C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000674")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5958E8", Offset = "0x5958E8")]
	private sealed class _003CDelayOnAlertLevelChanged_003Ed__139 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40023F6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40023F7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40023F8")]
		[FieldOffset(Offset = "0x20")]
		public HUDView _003C_003E4__this;

		[Token(Token = "0x40023F9")]
		[FieldOffset(Offset = "0x28")]
		public AlertLevelUIConfig alertLevelUIConfig;

		[Token(Token = "0x1700056B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002A24")]
			[Address(RVA = "0xB1F25C", Offset = "0xB1F25C", VA = "0xB1F25C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700056C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002A26")]
			[Address(RVA = "0xB1F2A4", Offset = "0xB1F2A4", VA = "0xB1F2A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002A21")]
		[Address(RVA = "0xB1ED34", Offset = "0xB1ED34", VA = "0xB1ED34")]
		[DebuggerHidden]
		public _003CDelayOnAlertLevelChanged_003Ed__139(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002A22")]
		[Address(RVA = "0xB1ED60", Offset = "0xB1ED60", VA = "0xB1ED60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002A23")]
		[Address(RVA = "0xB1ED64", Offset = "0xB1ED64", VA = "0xB1ED64", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002A25")]
		[Address(RVA = "0xB1F264", Offset = "0xB1F264", VA = "0xB1F264", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000675")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5958F8", Offset = "0x5958F8")]
	private sealed class _003CUpdateAmmoBar_003Ed__147 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40023FA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40023FB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40023FC")]
		[FieldOffset(Offset = "0x20")]
		public HUDView _003C_003E4__this;

		[Token(Token = "0x1700056D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002A2A")]
			[Address(RVA = "0xB1FBEC", Offset = "0xB1FBEC", VA = "0xB1FBEC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700056E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002A2C")]
			[Address(RVA = "0xB1FC34", Offset = "0xB1FC34", VA = "0xB1FC34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002A27")]
		[Address(RVA = "0xB1FAC4", Offset = "0xB1FAC4", VA = "0xB1FAC4")]
		[DebuggerHidden]
		public _003CUpdateAmmoBar_003Ed__147(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002A28")]
		[Address(RVA = "0xB1FAF0", Offset = "0xB1FAF0", VA = "0xB1FAF0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002A29")]
		[Address(RVA = "0xB1FAF4", Offset = "0xB1FAF4", VA = "0xB1FAF4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002A2B")]
		[Address(RVA = "0xB1FBF4", Offset = "0xB1FBF4", VA = "0xB1FBF4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000676")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595908", Offset = "0x595908")]
	private sealed class _003CEnableTaps_003Ed__150 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40023FD")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40023FE")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40023FF")]
		[FieldOffset(Offset = "0x20")]
		private float _003CendTime_003E5__2;

		[Token(Token = "0x1700056F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002A30")]
			[Address(RVA = "0xB1F85C", Offset = "0xB1F85C", VA = "0xB1F85C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000570")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002A32")]
			[Address(RVA = "0xB1F8A4", Offset = "0xB1F8A4", VA = "0xB1F8A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002A2D")]
		[Address(RVA = "0xB1F530", Offset = "0xB1F530", VA = "0xB1F530")]
		[DebuggerHidden]
		public _003CEnableTaps_003Ed__150(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002A2E")]
		[Address(RVA = "0xB1F55C", Offset = "0xB1F55C", VA = "0xB1F55C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002A2F")]
		[Address(RVA = "0xB1F560", Offset = "0xB1F560", VA = "0xB1F560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002A31")]
		[Address(RVA = "0xB1F864", Offset = "0xB1F864", VA = "0xB1F864", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4002395")]
	[FieldOffset(Offset = "0x60")]
	public UILabel TotalScoreLabel;

	[Token(Token = "0x4002396")]
	[FieldOffset(Offset = "0x68")]
	public GameObject CompletionPanel;

	[Token(Token = "0x4002397")]
	[FieldOffset(Offset = "0x70")]
	public UILabel ContractCompletionLabel;

	[Token(Token = "0x4002398")]
	[FieldOffset(Offset = "0x78")]
	public UITweener ContractCompletionTweener;

	[Token(Token = "0x4002399")]
	[FieldOffset(Offset = "0x80")]
	public GameObject[] ControlsToHideOnGameFinished;

	[Token(Token = "0x400239A")]
	[FieldOffset(Offset = "0x88")]
	public UITweener[] ContractCompletionEaseIn;

	[Token(Token = "0x400239B")]
	[FieldOffset(Offset = "0x90")]
	public UITweener[] ContractCompletionEaseOut;

	[Token(Token = "0x400239C")]
	[FieldOffset(Offset = "0x98")]
	public ScoreToBeatWidget ScoreToBeatWidget;

	[Token(Token = "0x400239D")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject ScorePanelGO;

	[Token(Token = "0x400239E")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject ScorePanelArrowGO;

	[Token(Token = "0x400239F")]
	[FieldOffset(Offset = "0xB0")]
	public ScoreAnimation ScoreAnimation;

	[Token(Token = "0x40023A0")]
	[FieldOffset(Offset = "0xB8")]
	public ScoreToBeatWidget NextRivalWidget;

	[Token(Token = "0x40023A1")]
	[FieldOffset(Offset = "0xC0")]
	public TweenPosition ScoreToBeatExtraMovement;

	[Token(Token = "0x40023A2")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject GameTimerGO;

	[Token(Token = "0x40023A3")]
	[FieldOffset(Offset = "0xD0")]
	public UISprite GameTimerSprite;

	[Token(Token = "0x40023A4")]
	[FieldOffset(Offset = "0xD8")]
	public UILabel GameTimerLabel;

	[Token(Token = "0x40023A5")]
	[FieldOffset(Offset = "0xE0")]
	public UILabel SubtitleLabel;

	[Token(Token = "0x40023A6")]
	[FieldOffset(Offset = "0xE8")]
	public UISprite TooltipBackground;

	[Token(Token = "0x40023A7")]
	[FieldOffset(Offset = "0xF0")]
	public UISprite TooltipBackgroundHighlight;

	[Token(Token = "0x40023A8")]
	[FieldOffset(Offset = "0xF8")]
	public UILabel TooltipLabel;

	[Token(Token = "0x40023A9")]
	[FieldOffset(Offset = "0x100")]
	public UITexture TooltipTexture;

	[Token(Token = "0x40023AA")]
	[FieldOffset(Offset = "0x108")]
	public UISprite TooltipSprite;

	[Token(Token = "0x40023AB")]
	[FieldOffset(Offset = "0x110")]
	public Transform AmmunitionLabels;

	[Token(Token = "0x40023AC")]
	[FieldOffset(Offset = "0x118")]
	public UILabel CurrentAmmunitionLabel;

	[Token(Token = "0x40023AD")]
	[FieldOffset(Offset = "0x120")]
	public UILabel MaxAmmunitionLabel;

	[Token(Token = "0x40023AE")]
	[FieldOffset(Offset = "0x128")]
	public UICircleProgressBar AmmoBar;

	[Token(Token = "0x40023AF")]
	[FieldOffset(Offset = "0x130")]
	public Transform AmmoBarContainer;

	[Token(Token = "0x40023B0")]
	[FieldOffset(Offset = "0x138")]
	public UILayoutElement NoAmmoReload;

	[Token(Token = "0x40023B1")]
	[FieldOffset(Offset = "0x140")]
	public UISprite NoAmmoPrompt;

	[Token(Token = "0x40023B2")]
	[FieldOffset(Offset = "0x148")]
	public ButtonHandler ReloadButton;

	[Token(Token = "0x40023B3")]
	[FieldOffset(Offset = "0x150")]
	public Transform ReloadTooltipAnchor;

	[Token(Token = "0x40023B4")]
	[FieldOffset(Offset = "0x158")]
	public Transform SmallReloadButton;

	[Token(Token = "0x40023B5")]
	[FieldOffset(Offset = "0x160")]
	public Transform SmallReloadTooltipAnchor;

	[Token(Token = "0x40023B6")]
	[FieldOffset(Offset = "0x168")]
	public ButtonHandler ShootButton;

	[Token(Token = "0x40023B7")]
	[FieldOffset(Offset = "0x170")]
	public PointyTooltip ReloadTooltip;

	[Token(Token = "0x40023B8")]
	[FieldOffset(Offset = "0x178")]
	public PointyTooltip RivalScoreTooltip;

	[Token(Token = "0x40023B9")]
	[FieldOffset(Offset = "0x180")]
	public PointyTooltip KillingTheMarkTooltip;

	[Token(Token = "0x40023BA")]
	[FieldOffset(Offset = "0x188")]
	public AlertLevelTransition AlertLevelTransition;

	[Token(Token = "0x40023BB")]
	[FieldOffset(Offset = "0x190")]
	public Transform AlertLevelParent;

	[Token(Token = "0x40023BC")]
	[FieldOffset(Offset = "0x198")]
	public UISprite AlertLevelBackground;

	[Token(Token = "0x40023BD")]
	[FieldOffset(Offset = "0x1A0")]
	public UISprite AlertLevelIcon;

	[Token(Token = "0x40023BE")]
	[FieldOffset(Offset = "0x1A8")]
	public UISprite AlertLevelTag;

	[Token(Token = "0x40023BF")]
	[FieldOffset(Offset = "0x1B0")]
	public UILabel AlertLevelLabel;

	[Token(Token = "0x40023C0")]
	[FieldOffset(Offset = "0x1B8")]
	public GameObject AmmoCounterGO;

	[Token(Token = "0x40023C1")]
	[FieldOffset(Offset = "0x1C0")]
	public UISprite EndGameBackgroundOverlaySprite;

	[Token(Token = "0x40023C2")]
	[FieldOffset(Offset = "0x1C8")]
	public TweenAlpha EndGameBackgroundOverlay;

	[Token(Token = "0x40023C3")]
	[FieldOffset(Offset = "0x1D0")]
	public GameObject RogueArrivalTimerParent;

	[Token(Token = "0x40023C4")]
	[FieldOffset(Offset = "0x1D8")]
	public UIGrid RogueArrivalTimerGrid;

	[Token(Token = "0x40023C5")]
	[FieldOffset(Offset = "0x1E0")]
	public UIAnchor RogueArrivalTimerAnchor;

	[Token(Token = "0x40023C6")]
	[FieldOffset(Offset = "0x1E8")]
	public DimmedBackgroundView DimmedBackground;

	[Token(Token = "0x40023C7")]
	[FieldOffset(Offset = "0x1F0")]
	public float DimmedBackgroundFadeTime;

	[Token(Token = "0x40023C8")]
	[FieldOffset(Offset = "0x1F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B8E1C", Offset = "0x5B8E1C")]
	private InScopeHUDView _003CInScopeHUDView_003Ek__BackingField;

	[Token(Token = "0x40023C9")]
	[FieldOffset(Offset = "0x200")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B8E2C", Offset = "0x5B8E2C")]
	private OutScopeHUDView _003COutScopeHUDView_003Ek__BackingField;

	[Token(Token = "0x40023CA")]
	[FieldOffset(Offset = "0x208")]
	private GameTimer _gameTimer;

	[Token(Token = "0x40023CB")]
	[FieldOffset(Offset = "0x210")]
	private float _missionDuration;

	[Token(Token = "0x40023CC")]
	[FieldOffset(Offset = "0x214")]
	private float _ammunitionCounterDuration;

	[Token(Token = "0x40023CD")]
	[FieldOffset(Offset = "0x218")]
	private UITweener[] _ammoCounterTweenerCache;

	[Token(Token = "0x40023CE")]
	[FieldOffset(Offset = "0x220")]
	private UITweener[] _ammoBarTweenerCache;

	[Token(Token = "0x40023CF")]
	[FieldOffset(Offset = "0x228")]
	private Coroutine _extractionCoroutine;

	[Token(Token = "0x40023D0")]
	[FieldOffset(Offset = "0x230")]
	private string _missionCompletedResult;

	[Token(Token = "0x40023D1")]
	[FieldOffset(Offset = "0x238")]
	private Coroutine _onAlertLevelChangeCoroutine;

	[Token(Token = "0x40023D2")]
	[FieldOffset(Offset = "0x240")]
	private bool _wasAmmoCounterActive;

	[Token(Token = "0x40023D3")]
	[FieldOffset(Offset = "0x241")]
	private bool _wasGameTimerActive;

	[Token(Token = "0x40023D4")]
	[FieldOffset(Offset = "0x248")]
	private AlertLevelUIConfig _lastAlertUIConfig;

	[Token(Token = "0x40023D5")]
	[FieldOffset(Offset = "0x250")]
	private readonly GameTimer _timer;

	[Token(Token = "0x40023D6")]
	[FieldOffset(Offset = "0x258")]
	private readonly GameTimer _timer2;

	[Token(Token = "0x40023D7")]
	[FieldOffset(Offset = "0x260")]
	private bool _timerTweenStarted;

	[Token(Token = "0x40023D8")]
	[FieldOffset(Offset = "0x264")]
	private int _cachedDisplayTime;

	[Token(Token = "0x40023D9")]
	[FieldOffset(Offset = "0x268")]
	private float _extractionTimeLeft;

	[Token(Token = "0x40023DA")]
	[FieldOffset(Offset = "0x270")]
	private Coroutine _tapsCoroutine;

	[Token(Token = "0x40023DB")]
	private const float DURATION_BEFORE_ENDGAME_MISSION_INFO = 0.3f;

	[Token(Token = "0x40023DC")]
	private const float DURATION_AFTER_ENDGAME_MISSION_INFO = 0.5f;

	[Token(Token = "0x40023DD")]
	private const float DURATION_TIMER_ALMOST_DONE_TWEEN = 0.4f;

	[Token(Token = "0x40023DE")]
	private const int ALERT_BACKGROUND_EXTRA_WIDTH = 200;

	[Token(Token = "0x40023DF")]
	[FieldOffset(Offset = "0x278")]
	private bool _mustDisableRechargeEffects;

	[Token(Token = "0x17000561")]
	public InScopeHUDView InScopeHUDView
	{
		[Token(Token = "0x60029AA")]
		[Address(RVA = "0xA009CC", Offset = "0xA009CC", VA = "0xA009CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61DEF8", Offset = "0x61DEF8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60029AB")]
		[Address(RVA = "0xA009D4", Offset = "0xA009D4", VA = "0xA009D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61DF08", Offset = "0x61DF08")]
		private set
		{
		}
	}

	[Token(Token = "0x17000562")]
	public OutScopeHUDView OutScopeHUDView
	{
		[Token(Token = "0x60029AC")]
		[Address(RVA = "0xA009DC", Offset = "0xA009DC", VA = "0xA009DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61DF18", Offset = "0x61DF18")]
		get
		{
			return null;
		}
		[Token(Token = "0x60029AD")]
		[Address(RVA = "0xA009E4", Offset = "0xA009E4", VA = "0xA009E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61DF28", Offset = "0x61DF28")]
		private set
		{
		}
	}

	[Token(Token = "0x17000563")]
	private UITweener[] AmmoCounterTweener
	{
		[Token(Token = "0x60029AE")]
		[Address(RVA = "0xA009EC", Offset = "0xA009EC", VA = "0xA009EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000564")]
	private UITweener[] AmmoBarTweener
	{
		[Token(Token = "0x60029AF")]
		[Address(RVA = "0xA00A60", Offset = "0xA00A60", VA = "0xA00A60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1400009C")]
	public static event EventHandler<CompletionPanelDisplayChangedArgs> OnCompletionPanelDisplayChanged
	{
		[Token(Token = "0x60029B0")]
		[Address(RVA = "0xA00AC8", Offset = "0xA00AC8", VA = "0xA00AC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61DF38", Offset = "0x61DF38")]
		add
		{
		}
		[Token(Token = "0x60029B1")]
		[Address(RVA = "0xA00B84", Offset = "0xA00B84", VA = "0xA00B84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61DF48", Offset = "0x61DF48")]
		remove
		{
		}
	}

	[Token(Token = "0x60029B2")]
	[Address(RVA = "0xA00C40", Offset = "0xA00C40", VA = "0xA00C40", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60029B3")]
	[Address(RVA = "0xA011D4", Offset = "0xA011D4", VA = "0xA011D4")]
	private void InstantiateExtraHudGameObjects()
	{
	}

	[Token(Token = "0x60029B4")]
	[Address(RVA = "0xA01030", Offset = "0xA01030", VA = "0xA01030")]
	private void InstantiateRogueArrivalTimer(RogueData rogueData, ContractData.RogueArrivalTimerData rogueArrivalTimer)
	{
	}

	[Token(Token = "0x60029B5")]
	[Address(RVA = "0xA0134C", Offset = "0xA0134C", VA = "0xA0134C")]
	private void SetRogueArrivalTimerPositions(SidePanelItemController controller)
	{
	}

	[Token(Token = "0x60029B6")]
	[Address(RVA = "0xA01508", Offset = "0xA01508", VA = "0xA01508", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60029B7")]
	[Address(RVA = "0xA033C8", Offset = "0xA033C8", VA = "0xA033C8", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60029B8")]
	[Address(RVA = "0xA03658", Offset = "0xA03658", VA = "0xA03658", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60029B9")]
	[Address(RVA = "0xA03854", Offset = "0xA03854", VA = "0xA03854", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x60029BA")]
	[Address(RVA = "0xA0662C", Offset = "0xA0662C", VA = "0xA0662C")]
	private void OnGlobalAlertChanged(object sender, AISensorManager.AlertLevelChangedArgs e)
	{
	}

	[Token(Token = "0x60029BB")]
	[Address(RVA = "0xA066E4", Offset = "0xA066E4", VA = "0xA066E4")]
	private void OnSpawn(object sender, Spawner.SpawnerEventArgs e)
	{
	}

	[Token(Token = "0x60029BC")]
	[Address(RVA = "0xA068DC", Offset = "0xA068DC", VA = "0xA068DC")]
	private void ShowAlarmRaisedLabel()
	{
	}

	[Token(Token = "0x60029BD")]
	[Address(RVA = "0xA04FA8", Offset = "0xA04FA8", VA = "0xA04FA8")]
	private void EnterTallyView()
	{
	}

	[Token(Token = "0x60029BE")]
	[Address(RVA = "0xA04D3C", Offset = "0xA04D3C", VA = "0xA04D3C")]
	private void HandleGameFinished()
	{
	}

	[Token(Token = "0x60029BF")]
	[Address(RVA = "0xA06ED0", Offset = "0xA06ED0", VA = "0xA06ED0")]
	private void CreateExtractionCoroutine(float totalTimeLeft, string plurialText, string singularText, bool skipTweens)
	{
	}

	[Token(Token = "0x60029C0")]
	[Address(RVA = "0xA06F44", Offset = "0xA06F44", VA = "0xA06F44")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61DF58", Offset = "0x61DF58")]
	private IEnumerator UpdateExtraction(float totalTimeLeft, string plurialText, string singularText)
	{
		return null;
	}

	[Token(Token = "0x60029C1")]
	[Address(RVA = "0xA06FD4", Offset = "0xA06FD4", VA = "0xA06FD4")]
	private static int GetTimeLeft(float startTime, float totalTime)
	{
		return default(int);
	}

	[Token(Token = "0x60029C2")]
	[Address(RVA = "0xA01F10", Offset = "0xA01F10", VA = "0xA01F10")]
	private void StopExtractionCoroutine()
	{
	}

	[Token(Token = "0x60029C3")]
	[Address(RVA = "0xA06A7C", Offset = "0xA06A7C", VA = "0xA06A7C")]
	private void ActivateCompletionPanel(bool activate, bool skipTweens)
	{
	}

	[Token(Token = "0x60029C4")]
	[Address(RVA = "0xA06914", Offset = "0xA06914", VA = "0xA06914")]
	private void SetContractCompletedLabel(bool? completed)
	{
	}

	[Token(Token = "0x60029C5")]
	[Address(RVA = "0xA07104", Offset = "0xA07104", VA = "0xA07104")]
	private void SetContractCompletionLabel(string locMessage, ColorModel.ColorModelEnum colorEnum)
	{
	}

	[Token(Token = "0x60029C6")]
	[Address(RVA = "0xA0722C", Offset = "0xA0722C", VA = "0xA0722C")]
	private void OnGameEnded(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x60029C7")]
	[Address(RVA = "0xA07454", Offset = "0xA07454", VA = "0xA07454")]
	private void OnCompletionBonusCompleted(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x60029C8")]
	[Address(RVA = "0xA073E8", Offset = "0xA073E8", VA = "0xA073E8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61DFB8", Offset = "0x61DFB8")]
	private IEnumerator DisplayMissionInfo()
	{
		return null;
	}

	[Token(Token = "0x60029C9")]
	[Address(RVA = "0xA074FC", Offset = "0xA074FC", VA = "0xA074FC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61E018", Offset = "0x61E018")]
	private IEnumerator GotoTallyScreen()
	{
		return null;
	}

	[Token(Token = "0x60029CA")]
	[Address(RVA = "0xA07568", Offset = "0xA07568", VA = "0xA07568")]
	private void TriggerEndGameBackgroundOverlay(float delay)
	{
	}

	[Token(Token = "0x60029CB")]
	[Address(RVA = "0xA06BBC", Offset = "0xA06BBC", VA = "0xA06BBC")]
	private void FadeOutControls(GameObject obj)
	{
	}

	[Token(Token = "0x60029CC")]
	[Address(RVA = "0xA02CC4", Offset = "0xA02CC4", VA = "0xA02CC4")]
	private void OnGameScoreInit(int value)
	{
	}

	[Token(Token = "0x60029CD")]
	[Address(RVA = "0xA07764", Offset = "0xA07764", VA = "0xA07764")]
	private void OnScoreAnimationCompleted(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x60029CE")]
	[Address(RVA = "0xA050E4", Offset = "0xA050E4", VA = "0xA050E4")]
	private void OnScoreChanged(ScoreDetail s)
	{
	}

	[Token(Token = "0x60029CF")]
	[Address(RVA = "0xA02A08", Offset = "0xA02A08", VA = "0xA02A08")]
	private void OnScoreToBeatChanged(LeaderboardRecord record)
	{
	}

	[Token(Token = "0x60029D0")]
	[Address(RVA = "0xA07A64", Offset = "0xA07A64", VA = "0xA07A64")]
	private void ActivateScoreToBeatArrow(bool activate)
	{
	}

	[Token(Token = "0x60029D1")]
	[Address(RVA = "0xA0521C", Offset = "0xA0521C", VA = "0xA0521C")]
	private void OnShowScoreToBeatChanged(bool isVisible)
	{
	}

	[Token(Token = "0x60029D2")]
	[Address(RVA = "0xA031D8", Offset = "0xA031D8", VA = "0xA031D8")]
	private void HandleScopeState(bool isInScope)
	{
	}

	[Token(Token = "0x60029D3")]
	[Address(RVA = "0xA02344", Offset = "0xA02344", VA = "0xA02344")]
	private void OnCurrentAmmunitionCountChanged(int value)
	{
	}

	[Token(Token = "0x60029D4")]
	[Address(RVA = "0xA064F0", Offset = "0xA064F0", VA = "0xA064F0")]
	private void OnHideNoAmmoVisualsChanged(bool shouldHide)
	{
	}

	[Token(Token = "0x60029D5")]
	[Address(RVA = "0xA07BA8", Offset = "0xA07BA8", VA = "0xA07BA8")]
	private void VerifyTweenerCache()
	{
	}

	[Token(Token = "0x60029D6")]
	[Address(RVA = "0xA07E68", Offset = "0xA07E68", VA = "0xA07E68")]
	private void EnableAmmunitionCounterTweener(UITweener tweener)
	{
	}

	[Token(Token = "0x60029D7")]
	[Address(RVA = "0xA07EA8", Offset = "0xA07EA8", VA = "0xA07EA8")]
	private void DisableAmmunitionCounterTweener(UITweener tweener)
	{
	}

	[Token(Token = "0x60029D8")]
	[Address(RVA = "0xA021FC", Offset = "0xA021FC", VA = "0xA021FC")]
	private void OnMaxAmmunitionCountChanged(int value)
	{
	}

	[Token(Token = "0x60029D9")]
	[Address(RVA = "0xA058F4", Offset = "0xA058F4", VA = "0xA058F4")]
	private void OnShowShootButtonChanged(bool showShootButton)
	{
	}

	[Token(Token = "0x60029DA")]
	[Address(RVA = "0xA07B6C", Offset = "0xA07B6C", VA = "0xA07B6C")]
	private void OnShootButtonVisibilityChanged(bool isActive)
	{
	}

	[Token(Token = "0x60029DB")]
	[Address(RVA = "0xA02E58", Offset = "0xA02E58", VA = "0xA02E58")]
	private void OnRogueArrivalTimerVisibilityChanged(bool isActive)
	{
	}

	[Token(Token = "0x60029DC")]
	[Address(RVA = "0xA020B8", Offset = "0xA020B8", VA = "0xA020B8")]
	private void OnReloadButtonVisibilityChanged(bool isVisible)
	{
	}

	[Token(Token = "0x60029DD")]
	[Address(RVA = "0xA06024", Offset = "0xA06024", VA = "0xA06024")]
	private void OnReloadEnabledChanged(bool isEnabled)
	{
	}

	[Token(Token = "0x60029DE")]
	[Address(RVA = "0xA020F4", Offset = "0xA020F4", VA = "0xA020F4")]
	private void OnReloadTooltipVisibilityChanged(bool isVisible)
	{
	}

	[Token(Token = "0x60029DF")]
	[Address(RVA = "0xA08058", Offset = "0xA08058", VA = "0xA08058")]
	private void UpdateReloadTooltip(bool showShootButton)
	{
	}

	[Token(Token = "0x60029E0")]
	[Address(RVA = "0xA02FFC", Offset = "0xA02FFC", VA = "0xA02FFC")]
	private void OnSetReloadTooltipTextChanged(string text)
	{
	}

	[Token(Token = "0x60029E1")]
	[Address(RVA = "0xA04CD8", Offset = "0xA04CD8", VA = "0xA04CD8")]
	private void HandleReload()
	{
	}

	[Token(Token = "0x60029E2")]
	[Address(RVA = "0xA052A4", Offset = "0xA052A4", VA = "0xA052A4")]
	private void OnAlertLevelChanged(AlertLevel alertLevel)
	{
	}

	[Token(Token = "0x60029E3")]
	[Address(RVA = "0xA0821C", Offset = "0xA0821C", VA = "0xA0821C")]
	private void ChangeAlertLevelDisplay(AlertLevelUIConfig alertLevelUIConfig)
	{
	}

	[Token(Token = "0x60029E4")]
	[Address(RVA = "0xA03350", Offset = "0xA03350", VA = "0xA03350")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61E078", Offset = "0x61E078")]
	private IEnumerator DelayOnAlertLevelChanged(AlertLevelUIConfig alertLevelUIConfig)
	{
		return null;
	}

	[Token(Token = "0x60029E5")]
	[Address(RVA = "0xA02D40", Offset = "0xA02D40", VA = "0xA02D40")]
	private void OnSubtitleTextChanged(string subtitle)
	{
	}

	[Token(Token = "0x60029E6")]
	[Address(RVA = "0xA053DC", Offset = "0xA053DC", VA = "0xA053DC")]
	private void OnTooltipTextChanged(string tooltip)
	{
	}

	[Token(Token = "0x60029E7")]
	[Address(RVA = "0xA08274", Offset = "0xA08274", VA = "0xA08274")]
	private void FadeOut(TweenAlpha tweener, float fadeDuration)
	{
	}

	[Token(Token = "0x60029E8")]
	[Address(RVA = "0xA08388", Offset = "0xA08388", VA = "0xA08388")]
	private void OnTooltipFadeOutDone()
	{
	}

	[Token(Token = "0x60029E9")]
	[Address(RVA = "0xA056EC", Offset = "0xA056EC", VA = "0xA056EC")]
	private void OnTooltipTextureChanged(Texture texture)
	{
	}

	[Token(Token = "0x60029EA")]
	[Address(RVA = "0xA057E4", Offset = "0xA057E4", VA = "0xA057E4")]
	private void OnTooltipAtlasInfoChanged(UIManager.AtlasInfo atlasInfo)
	{
	}

	[Token(Token = "0x60029EB")]
	[Address(RVA = "0xA05A04", Offset = "0xA05A04", VA = "0xA05A04")]
	private void OnShowPauseMenuChanged(HUDModel.PauseMenuState newState, HUDModel.PauseMenuState oldState)
	{
	}

	[Token(Token = "0x60029EC")]
	[Address(RVA = "0xA081B0", Offset = "0xA081B0", VA = "0xA081B0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61E0D8", Offset = "0x61E0D8")]
	private IEnumerator UpdateAmmoBar()
	{
		return null;
	}

	[Token(Token = "0x60029ED")]
	[Address(RVA = "0xA08460", Offset = "0xA08460", VA = "0xA08460", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x60029EE")]
	[Address(RVA = "0xA086DC", Offset = "0xA086DC", VA = "0xA086DC")]
	public static string GetFormatedTimeFromSecond(int timeInSeconds)
	{
		return null;
	}

	[Token(Token = "0x60029EF")]
	[Address(RVA = "0xA08404", Offset = "0xA08404", VA = "0xA08404")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61E138", Offset = "0x61E138")]
	private static IEnumerator EnableTaps()
	{
		return null;
	}

	[Token(Token = "0x60029F0")]
	[Address(RVA = "0xA02D5C", Offset = "0xA02D5C", VA = "0xA02D5C")]
	private void OnScoreDisplayedChanged(bool displayed)
	{
	}

	[Token(Token = "0x60029F1")]
	[Address(RVA = "0xA02DD4", Offset = "0xA02DD4", VA = "0xA02DD4")]
	private void OnTimerDisplayedChanged(bool displayed)
	{
	}

	[Token(Token = "0x60029F2")]
	[Address(RVA = "0xA02F4C", Offset = "0xA02F4C", VA = "0xA02F4C")]
	private void OnAmmoCounterDisplayedChanged(bool displayed)
	{
	}

	[Token(Token = "0x60029F3")]
	[Address(RVA = "0xA03018", Offset = "0xA03018", VA = "0xA03018")]
	private void OnShowRivalScoreTooltipChanged(bool show)
	{
	}

	[Token(Token = "0x60029F4")]
	[Address(RVA = "0xA03038", Offset = "0xA03038", VA = "0xA03038")]
	private void OnSetRivalScoreTooltipTextChanged(string text)
	{
	}

	[Token(Token = "0x60029F5")]
	[Address(RVA = "0xA03054", Offset = "0xA03054", VA = "0xA03054")]
	private void OnShowKillingTheMarkTooltipChanged(bool show)
	{
	}

	[Token(Token = "0x60029F6")]
	[Address(RVA = "0xA03074", Offset = "0xA03074", VA = "0xA03074")]
	private void OnSetKillingTheMarkTooltipTextChanged(string text)
	{
	}

	[Token(Token = "0x60029F7")]
	[Address(RVA = "0xA05D08", Offset = "0xA05D08", VA = "0xA05D08")]
	private void OnSpecialAlertDisplayChanged(HUDModel.SpecialAlertUIConfig specialAlertDisplay)
	{
	}

	[Token(Token = "0x60029F8")]
	[Address(RVA = "0xA03090", Offset = "0xA03090", VA = "0xA03090")]
	private void OnRogueArrivalTimerAnchorChanged(GameObject anchorGO)
	{
	}

	[Token(Token = "0x60029F9")]
	[Address(RVA = "0xA087A4", Offset = "0xA087A4", VA = "0xA087A4")]
	private void OnMovingAimingCameraChanged(object sender, PlayerCameraSystem.MovingAimingCamera e)
	{
	}

	[Token(Token = "0x60029FA")]
	[Address(RVA = "0xA01F50", Offset = "0xA01F50", VA = "0xA01F50")]
	private void SetButtonToShoot()
	{
	}

	[Token(Token = "0x60029FB")]
	[Address(RVA = "0xA07DA8", Offset = "0xA07DA8", VA = "0xA07DA8")]
	private static void MapShootElementsLayout(bool showShootButton)
	{
	}

	[Token(Token = "0x60029FC")]
	[Address(RVA = "0xA06DD4", Offset = "0xA06DD4", VA = "0xA06DD4")]
	private float GetExtractionTime(bool completed, bool extractionRunning)
	{
		return default(float);
	}

	[Token(Token = "0x60029FD")]
	[Address(RVA = "0xA05DC8", Offset = "0xA05DC8", VA = "0xA05DC8")]
	private void OnHighlightActiveChanged(bool isActive)
	{
	}

	[Token(Token = "0x60029FE")]
	[Address(RVA = "0xA087E4", Offset = "0xA087E4", VA = "0xA087E4")]
	private void HighlightTarget(GameObject target)
	{
	}

	[Token(Token = "0x60029FF")]
	[Address(RVA = "0xA08860", Offset = "0xA08860", VA = "0xA08860")]
	private void UnhighlightTarget()
	{
	}

	[Token(Token = "0x6002A00")]
	[Address(RVA = "0xA05F10", Offset = "0xA05F10", VA = "0xA05F10")]
	private void OnAmmoCounterHighlightActiveChanged(bool isActive)
	{
	}

	[Token(Token = "0x6002A01")]
	[Address(RVA = "0xA05FD0", Offset = "0xA05FD0", VA = "0xA05FD0")]
	private void OnBlockAllInputChanged(bool blockInput)
	{
	}

	[Token(Token = "0x6002A02")]
	[Address(RVA = "0xA064CC", Offset = "0xA064CC", VA = "0xA064CC")]
	private void OnShootIconsOnLeftChanged(bool isOnLeft)
	{
	}

	[Token(Token = "0x6002A03")]
	[Address(RVA = "0xA08928", Offset = "0xA08928", VA = "0xA08928")]
	public HUDView()
	{
	}

	[Token(Token = "0x6002A04")]
	[Address(RVA = "0xA089BC", Offset = "0xA089BC", VA = "0xA089BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61E198", Offset = "0x61E198")]
	private void _003COnScoreToBeatChanged_003Eb__118_0()
	{
	}

	[Token(Token = "0x6002A05")]
	[Address(RVA = "0xA08B0C", Offset = "0xA08B0C", VA = "0xA08B0C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61E1A8", Offset = "0x61E1A8")]
	private void _003CUnhighlightTarget_003Eb__166_0()
	{
	}
}
