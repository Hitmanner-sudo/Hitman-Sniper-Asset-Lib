using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006B6")]
public class PauseMenuView : View
{
	[Serializable]
	[Token(Token = "0x20006B7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595AE8", Offset = "0x595AE8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002592")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002593")]
		[FieldOffset(Offset = "0x8")]
		public static Func<GameObject, bool> _003C_003E9__40_0;

		[Token(Token = "0x4002594")]
		[FieldOffset(Offset = "0x10")]
		public static Func<RogueData, bool> _003C_003E9__46_0;

		[Token(Token = "0x4002595")]
		[FieldOffset(Offset = "0x18")]
		public static Func<RogueData, int> _003C_003E9__46_1;

		[Token(Token = "0x6002C24")]
		[Address(RVA = "0x8CF198", Offset = "0x8CF198", VA = "0x8CF198")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002C25")]
		[Address(RVA = "0x8CF1A0", Offset = "0x8CF1A0", VA = "0x8CF1A0")]
		internal bool _003CSetElementTweeners_003Eb__40_0(GameObject b)
		{
			return default(bool);
		}

		[Token(Token = "0x6002C26")]
		[Address(RVA = "0x8CF1CC", Offset = "0x8CF1CC", VA = "0x8CF1CC")]
		internal bool _003CPopulateRogueIconGrid_003Eb__46_0(RogueData r)
		{
			return default(bool);
		}

		[Token(Token = "0x6002C27")]
		[Address(RVA = "0x8CF1E8", Offset = "0x8CF1E8", VA = "0x8CF1E8")]
		internal int _003CPopulateRogueIconGrid_003Eb__46_1(RogueData r)
		{
			return default(int);
		}
	}

	[Token(Token = "0x20006B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595AF8", Offset = "0x595AF8")]
	private sealed class _003C_003Ec__DisplayClass47_0
	{
		[Token(Token = "0x4002596")]
		[FieldOffset(Offset = "0x10")]
		public RogueData data;

		[Token(Token = "0x6002C28")]
		[Address(RVA = "0x8CF200", Offset = "0x8CF200", VA = "0x8CF200")]
		public _003C_003Ec__DisplayClass47_0()
		{
		}

		[Token(Token = "0x6002C29")]
		[Address(RVA = "0x8CF208", Offset = "0x8CF208", VA = "0x8CF208")]
		internal bool _003CCheckForRogueDeath_003Eb__0(KeyValuePair<string, PauseMenuRogueIcon> x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4002576")]
	[FieldOffset(Offset = "0x60")]
	public GameObject[] Buttons;

	[Token(Token = "0x4002577")]
	[FieldOffset(Offset = "0x68")]
	public TweenAlpha[] ButtonsTweener;

	[Token(Token = "0x4002578")]
	[FieldOffset(Offset = "0x70")]
	public TweenAlpha OverlayTweener;

	[Token(Token = "0x4002579")]
	[FieldOffset(Offset = "0x78")]
	public TweenAlpha[] PauseButtonTweener;

	[Token(Token = "0x400257A")]
	[FieldOffset(Offset = "0x80")]
	public GameObject MenuPanel;

	[Token(Token = "0x400257B")]
	[FieldOffset(Offset = "0x88")]
	public GameObject PauseMenuInfoContainer;

	[Token(Token = "0x400257C")]
	[FieldOffset(Offset = "0x90")]
	public TweenPosition SlidingTweener;

	[Token(Token = "0x400257D")]
	[FieldOffset(Offset = "0x98")]
	public Transform MainRogueAnchor;

	[Token(Token = "0x400257E")]
	[FieldOffset(Offset = "0xA0")]
	public UIGrid RogueIconGrid;

	[Token(Token = "0x400257F")]
	[FieldOffset(Offset = "0xA8")]
	public PauseMenuRogueIcon RogueIconPrefab;

	[Token(Token = "0x4002580")]
	[FieldOffset(Offset = "0xB0")]
	public UILabel RoguesLabel;

	[Token(Token = "0x4002581")]
	[FieldOffset(Offset = "0xB8")]
	public ContractMissionInfoView MissionInfo;

	[Token(Token = "0x4002582")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject RoguesAnchor;

	[Token(Token = "0x4002583")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject QuitButton;

	[Token(Token = "0x4002584")]
	[FieldOffset(Offset = "0xD0")]
	public UILabel MarkNameLabel;

	[Token(Token = "0x4002585")]
	[FieldOffset(Offset = "0xD8")]
	public UIWidget MainContainerSprite;

	[Token(Token = "0x4002586")]
	[FieldOffset(Offset = "0xE0")]
	public float MaxPanelSlideDistance;

	[Token(Token = "0x4002587")]
	[FieldOffset(Offset = "0xE4")]
	public float ProgressSlideDistance;

	[Token(Token = "0x4002588")]
	[FieldOffset(Offset = "0xE8")]
	public float OverlayMaxAlpha;

	[Token(Token = "0x4002589")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private GameObject _settingsPanel;

	[Token(Token = "0x400258A")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private OptionsItemView _musicVolumeOption;

	[Token(Token = "0x400258B")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private OptionsItemView _sfxVolumeOption;

	[Token(Token = "0x400258C")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	private OptionsItemView _leftHandedOption;

	[Token(Token = "0x400258D")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	private OptionsItemView _shootButtonOption;

	[Token(Token = "0x400258E")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	private OptionsItemView _goreOption;

	[Token(Token = "0x400258F")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	private OptionsItemView _invertAxisOption;

	[Token(Token = "0x4002590")]
	[FieldOffset(Offset = "0x128")]
	private readonly Dictionary<string, PauseMenuRogueIcon> _rogueIcons;

	[Token(Token = "0x4002591")]
	[FieldOffset(Offset = "0x130")]
	private Color _mainContainerSpriteOriginalColor;

	[Token(Token = "0x170005B5")]
	protected GameObject SettingsPanel
	{
		[Token(Token = "0x6002C0D")]
		[Address(RVA = "0x8FA93C", Offset = "0x8FA93C", VA = "0x8FA93C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002C0E")]
	[Address(RVA = "0x8FA944", Offset = "0x8FA944", VA = "0x8FA944", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002C0F")]
	[Address(RVA = "0x8FA9A0", Offset = "0x8FA9A0", VA = "0x8FA9A0", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6002C10")]
	[Address(RVA = "0x8FACA0", Offset = "0x8FACA0", VA = "0x8FACA0", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002C11")]
	[Address(RVA = "0x8FADFC", Offset = "0x8FADFC", VA = "0x8FADFC", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002C12")]
	[Address(RVA = "0x8FAED8", Offset = "0x8FAED8", VA = "0x8FAED8", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002C13")]
	[Address(RVA = "0x8FB1D0", Offset = "0x8FB1D0", VA = "0x8FB1D0", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002C14")]
	[Address(RVA = "0x8FB3BC", Offset = "0x8FB3BC", VA = "0x8FB3BC", Slot = "15")]
	protected virtual void OnPauseMenuStateChanged(HUDModel.PauseMenuState newState, HUDModel.PauseMenuState oldState)
	{
	}

	[Token(Token = "0x6002C15")]
	[Address(RVA = "0x8FB520", Offset = "0x8FB520", VA = "0x8FB520", Slot = "16")]
	protected virtual void SetSlidingPanelPos(HUDModel.PauseMenuState newState, ref Vector3 slidingPanelPos)
	{
	}

	[Token(Token = "0x6002C16")]
	[Address(RVA = "0x8FB53C", Offset = "0x8FB53C", VA = "0x8FB53C")]
	protected void SetSlidingPanelPos(out Vector3 slidingPanelPos)
	{
	}

	[Token(Token = "0x6002C17")]
	[Address(RVA = "0x8FB5F0", Offset = "0x8FB5F0", VA = "0x8FB5F0", Slot = "17")]
	protected virtual void SetPauseMenuActive(HUDModel.PauseMenuState newState)
	{
	}

	[Token(Token = "0x6002C18")]
	[Address(RVA = "0x8FB640", Offset = "0x8FB640", VA = "0x8FB640", Slot = "18")]
	protected virtual void SetElementTweeners(HUDModel.PauseMenuState newState, HUDModel.PauseMenuState oldState, float duration)
	{
	}

	[Token(Token = "0x6002C19")]
	[Address(RVA = "0x8FBCAC", Offset = "0x8FBCAC", VA = "0x8FBCAC", Slot = "19")]
	protected virtual HashSet<HUDModel.PauseMenuState> GetVisibleStates()
	{
		return null;
	}

	[Token(Token = "0x6002C1A")]
	[Address(RVA = "0x8FBACC", Offset = "0x8FBACC", VA = "0x8FBACC")]
	private void SetButtonsColliders(bool enable)
	{
	}

	[Token(Token = "0x6002C1B")]
	[Address(RVA = "0x8FBA70", Offset = "0x8FBA70", VA = "0x8FBA70")]
	protected void SetTweenerValues(TweenAlpha tweener, float fromAlpha, float toAlpha, float duration)
	{
	}

	[Token(Token = "0x6002C1C")]
	[Address(RVA = "0x8FBD64", Offset = "0x8FBD64", VA = "0x8FBD64")]
	private void OnChangeMissionCompleted(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6002C1D")]
	[Address(RVA = "0x8FAFC4", Offset = "0x8FAFC4", VA = "0x8FAFC4")]
	protected void ClearRogueIcons()
	{
	}

	[Token(Token = "0x6002C1E")]
	[Address(RVA = "0x8FBE68", Offset = "0x8FBE68", VA = "0x8FBE68", Slot = "20")]
	protected virtual void PopulateRogueIconGrid()
	{
	}

	[Token(Token = "0x6002C1F")]
	[Address(RVA = "0x8FC838", Offset = "0x8FC838", VA = "0x8FC838", Slot = "21")]
	protected virtual void CheckForRogueDeath(object sender, TargetDamagedEventArgs args)
	{
	}

	[Token(Token = "0x6002C20")]
	[Address(RVA = "0x8FCA48", Offset = "0x8FCA48", VA = "0x8FCA48", Slot = "22")]
	protected virtual void OnPanelSlideFinished()
	{
	}

	[Token(Token = "0x6002C21")]
	[Address(RVA = "0x8FAD84", Offset = "0x8FAD84", VA = "0x8FAD84")]
	private void OnPauseMenuQuitButtonDisplayedChanged(bool displayed)
	{
	}

	[Token(Token = "0x6002C22")]
	[Address(RVA = "0x8FCAEC", Offset = "0x8FCAEC", VA = "0x8FCAEC")]
	public PauseMenuView()
	{
	}
}
