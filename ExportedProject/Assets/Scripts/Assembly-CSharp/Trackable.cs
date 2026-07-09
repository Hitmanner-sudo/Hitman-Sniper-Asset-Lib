using System;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20002B3")]
public class Trackable : GameMonoBehaviour
{
	[Token(Token = "0x20002B4")]
	private enum TagState
	{
		[Token(Token = "0x4000F49")]
		Unknown = 0,
		[Token(Token = "0x4000F4A")]
		InProgress = 1,
		[Token(Token = "0x4000F4B")]
		Identified = 2
	}

	[Token(Token = "0x20002B5")]
	private enum IconDisplayState
	{
		[Token(Token = "0x4000F4D")]
		None = 0,
		[Token(Token = "0x4000F4E")]
		NotTagged = 1,
		[Token(Token = "0x4000F4F")]
		Tagged = 2
	}

	[Token(Token = "0x4000F1D")]
	[FieldOffset(Offset = "0x48")]
	public EventHandler<IndicatorView.SetupIndicatorEventArgs> OnSetupTagIndicator;

	[Token(Token = "0x4000F1E")]
	[FieldOffset(Offset = "0x50")]
	public EventHandler<IndicatorView.SetupIndicatorEventArgs> OnPostSetupTagIndicator;

	[Token(Token = "0x4000F1F")]
	[FieldOffset(Offset = "0x58")]
	public Color TaggedColor;

	[Token(Token = "0x4000F20")]
	[FieldOffset(Offset = "0x68")]
	public string TaggedIcon;

	[Token(Token = "0x4000F21")]
	[FieldOffset(Offset = "0x70")]
	public string PersistentIcon;

	[Token(Token = "0x4000F22")]
	[FieldOffset(Offset = "0x78")]
	public Color PersistentColorLight;

	[Token(Token = "0x4000F23")]
	[FieldOffset(Offset = "0x88")]
	public Color PersistentColorDark;

	[Token(Token = "0x4000F24")]
	[FieldOffset(Offset = "0x98")]
	public Color PersistentColor;

	[Token(Token = "0x4000F25")]
	[FieldOffset(Offset = "0xA8")]
	public Color IconColor;

	[Token(Token = "0x4000F26")]
	[FieldOffset(Offset = "0xB8")]
	public float WorldVerticalOffset;

	[Token(Token = "0x4000F27")]
	[FieldOffset(Offset = "0xBC")]
	public bool NeedsID;

	[Token(Token = "0x4000F28")]
	[FieldOffset(Offset = "0xC0")]
	public float IDDuration;

	[Token(Token = "0x4000F29")]
	[FieldOffset(Offset = "0xC4")]
	public bool TutorialTag;

	[Token(Token = "0x4000F2A")]
	[FieldOffset(Offset = "0xC5")]
	public bool AutoTag;

	[Token(Token = "0x4000F2B")]
	[FieldOffset(Offset = "0xC6")]
	public bool AutoTrack;

	[Token(Token = "0x4000F2C")]
	[FieldOffset(Offset = "0xC7")]
	public bool CanBeTagged;

	[Token(Token = "0x4000F2D")]
	[FieldOffset(Offset = "0xC8")]
	public bool ConsumeTag;

	[Token(Token = "0x4000F2E")]
	[FieldOffset(Offset = "0xC9")]
	public bool ShowWhenZoomOut;

	[Token(Token = "0x4000F2F")]
	[FieldOffset(Offset = "0xCA")]
	public bool OnlyShowComunicate;

	[Token(Token = "0x4000F30")]
	[FieldOffset(Offset = "0xCB")]
	public bool HideOutline;

	[Token(Token = "0x4000F31")]
	[FieldOffset(Offset = "0xCC")]
	public bool OnlyShowAlerted;

	[Token(Token = "0x4000F32")]
	[FieldOffset(Offset = "0xCD")]
	public bool AlwaysClickable;

	[Token(Token = "0x4000F33")]
	[FieldOffset(Offset = "0xCE")]
	public bool DontShowAlertIcon;

	[Token(Token = "0x4000F34")]
	[FieldOffset(Offset = "0xCF")]
	public bool DontShowBehaviourIcon;

	[Token(Token = "0x4000F35")]
	[FieldOffset(Offset = "0xD0")]
	public bool StartHidden;

	[Token(Token = "0x4000F36")]
	[FieldOffset(Offset = "0xD1")]
	public bool ShowAfterTakeDamage;

	[Token(Token = "0x4000F37")]
	[FieldOffset(Offset = "0xD2")]
	public bool ShowAfterInflictDamage;

	[Token(Token = "0x4000F38")]
	[FieldOffset(Offset = "0xD4")]
	public float ShowAfterTimeInSeconds;

	[Token(Token = "0x4000F39")]
	[FieldOffset(Offset = "0xD8")]
	public Health HealthComponent;

	[Token(Token = "0x4000F3A")]
	[FieldOffset(Offset = "0xE0")]
	public bool DontShowOutOfScope;

	[NonSerialized]
	[Token(Token = "0x4000F3B")]
	[FieldOffset(Offset = "0xE8")]
	public TagIndicatorView TagIndicator;

	[NonSerialized]
	[Token(Token = "0x4000F3C")]
	[FieldOffset(Offset = "0xF0")]
	public bool IsTagged;

	[NonSerialized]
	[Token(Token = "0x4000F3D")]
	[FieldOffset(Offset = "0xF1")]
	public bool IsTracked;

	[NonSerialized]
	[Token(Token = "0x4000F3E")]
	[FieldOffset(Offset = "0xF2")]
	public bool IsLockedOn;

	[NonSerialized]
	[Token(Token = "0x4000F3F")]
	[FieldOffset(Offset = "0xF3")]
	public bool EnableIcon;

	[NonSerialized]
	[Token(Token = "0x4000F40")]
	[FieldOffset(Offset = "0xF4")]
	public bool ByPassSetupTag;

	[NonSerialized]
	[Token(Token = "0x4000F41")]
	[FieldOffset(Offset = "0xF8")]
	public IndicatorView.IndicatorInfo indicator;

	[NonSerialized]
	[Token(Token = "0x4000F42")]
	[FieldOffset(Offset = "0x100")]
	public bool IsDirty;

	[Token(Token = "0x4000F43")]
	[FieldOffset(Offset = "0x104")]
	private TagState _state;

	[Token(Token = "0x4000F44")]
	[FieldOffset(Offset = "0x108")]
	private float _idProgress;

	[Token(Token = "0x4000F45")]
	[FieldOffset(Offset = "0x10C")]
	private IconDisplayState _iconDisplayState;

	[Token(Token = "0x4000F46")]
	[FieldOffset(Offset = "0x110")]
	protected GameTimer _showAfterTimeInSecondTimer;

	[Token(Token = "0x4000F47")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string IDENTIFY_TAG_ICON;

	[Token(Token = "0x1700028A")]
	public bool IsTaggable
	{
		[Token(Token = "0x600107D")]
		[Address(RVA = "0xAD76CC", Offset = "0xAD76CC", VA = "0xAD76CC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700028B")]
	public bool UseTagSlot
	{
		[Token(Token = "0x600107E")]
		[Address(RVA = "0xAD76EC", Offset = "0xAD76EC", VA = "0xAD76EC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600107F")]
	[Address(RVA = "0xAD770C", Offset = "0xAD770C", VA = "0xAD770C", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6001080")]
	[Address(RVA = "0xAD77D8", Offset = "0xAD77D8", VA = "0xAD77D8", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6001081")]
	[Address(RVA = "0xAD7A58", Offset = "0xAD7A58", VA = "0xAD7A58", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x6001082")]
	[Address(RVA = "0xAD7AC0", Offset = "0xAD7AC0", VA = "0xAD7AC0")]
	public bool IsIconShowing()
	{
		return default(bool);
	}

	[Token(Token = "0x6001083")]
	[Address(RVA = "0xAD7B98", Offset = "0xAD7B98", VA = "0xAD7B98")]
	private void OnTakeDamage(object sender, Health.TakeDamageEventArgs args)
	{
	}

	[Token(Token = "0x6001084")]
	[Address(RVA = "0xAD7D78", Offset = "0xAD7D78", VA = "0xAD7D78")]
	public void UpdateCurrentHealthRatio()
	{
	}

	[Token(Token = "0x6001085")]
	[Address(RVA = "0xAD7E60", Offset = "0xAD7E60", VA = "0xAD7E60", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6001086")]
	[Address(RVA = "0xAD80F8", Offset = "0xAD80F8", VA = "0xAD80F8")]
	private void SetupTagIndicator(object sender, IndicatorView.SetupIndicatorEventArgs args)
	{
	}

	[Token(Token = "0x6001087")]
	[Address(RVA = "0xAD88EC", Offset = "0xAD88EC", VA = "0xAD88EC")]
	private void DisplayPersistentIcon(TagIndicatorView tagIndicator)
	{
	}

	[Token(Token = "0x6001088")]
	[Address(RVA = "0xAD8380", Offset = "0xAD8380", VA = "0xAD8380")]
	private void SetupIdentificationProgress(TagIndicatorView tagIndicator)
	{
	}

	[Token(Token = "0x6001089")]
	[Address(RVA = "0xAD8530", Offset = "0xAD8530", VA = "0xAD8530")]
	private void DisplayIdentificationProgress(TagIndicatorView tagIndicator)
	{
	}

	[Token(Token = "0x600108A")]
	[Address(RVA = "0xAD85C8", Offset = "0xAD85C8", VA = "0xAD85C8")]
	private void DisplayTagged(TagIndicatorView tagIndicator)
	{
	}

	[Token(Token = "0x600108B")]
	[Address(RVA = "0xAD8AE0", Offset = "0xAD8AE0", VA = "0xAD8AE0")]
	public Trackable()
	{
	}
}
