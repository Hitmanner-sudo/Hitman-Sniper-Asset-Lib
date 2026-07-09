using Il2CppDummyDll;
using Technology.Social;
using UnityEngine;

[Token(Token = "0x2000680")]
public class LeaderboardItem : View
{
	[Token(Token = "0x4002450")]
	[FieldOffset(Offset = "0x60")]
	public UITexture AvatarTexture;

	[Token(Token = "0x4002451")]
	[FieldOffset(Offset = "0x68")]
	public UISprite NoAvatarSprite;

	[Token(Token = "0x4002452")]
	[FieldOffset(Offset = "0x70")]
	public UITexture TierIconTexture;

	[Token(Token = "0x4002453")]
	[FieldOffset(Offset = "0x78")]
	public UILabel PlayerNameLabel;

	[Token(Token = "0x4002454")]
	[FieldOffset(Offset = "0x80")]
	public UILabel PlayerScoreLabel;

	[Token(Token = "0x4002455")]
	[FieldOffset(Offset = "0x88")]
	public Color PlayerNameColor;

	[Token(Token = "0x4002456")]
	[FieldOffset(Offset = "0x98")]
	public Color OtherNameColor;

	[Token(Token = "0x4002457")]
	[FieldOffset(Offset = "0xA8")]
	public UISprite BackDropSprite;

	[Token(Token = "0x4002458")]
	[FieldOffset(Offset = "0xB0")]
	public UIDragPanelContentsOnAxis PageDrag;

	[Token(Token = "0x4002459")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject FriendFilter;

	[Token(Token = "0x400245A")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel FriendRankLabel;

	[Token(Token = "0x400245B")]
	[FieldOffset(Offset = "0xC8")]
	public UITexture FriendTierTexture;

	[Token(Token = "0x400245C")]
	[FieldOffset(Offset = "0xD0")]
	public UILabel FriendTierLabel;

	[Token(Token = "0x400245D")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject GlobalFilter;

	[Token(Token = "0x400245E")]
	[FieldOffset(Offset = "0xE0")]
	public UILabel GlobalRankLabel;

	[Token(Token = "0x400245F")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject GlobalDownArrow;

	[Token(Token = "0x4002460")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject GlobalUpArrow;

	[Token(Token = "0x4002461")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject GlobalNeutralArrow;

	[Token(Token = "0x4002462")]
	[FieldOffset(Offset = "0x100")]
	public Color PlayerBgColor;

	[Token(Token = "0x4002463")]
	[FieldOffset(Offset = "0x110")]
	public Color OtherOddBgColor;

	[Token(Token = "0x4002464")]
	[FieldOffset(Offset = "0x120")]
	public Color OtherEvenBgColor;

	[Token(Token = "0x4002465")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	private UIGrid _interractionGrid;

	[Token(Token = "0x4002466")]
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	private GameObject _friendInterraction;

	[Token(Token = "0x4002467")]
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	private GameObject _removeFriend;

	[Token(Token = "0x4002468")]
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	private GameObject _facebookFriend;

	[Token(Token = "0x4002469")]
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	private BlinkButtonHandler _removeFriendButton;

	[Token(Token = "0x17000574")]
	public Texture Avatar
	{
		[Token(Token = "0x6002A7B")]
		[Address(RVA = "0x99FCB4", Offset = "0x99FCB4", VA = "0x99FCB4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002A7C")]
		[Address(RVA = "0x99FCD4", Offset = "0x99FCD4", VA = "0x99FCD4")]
		set
		{
		}
	}

	[Token(Token = "0x17000575")]
	public string PlayerName
	{
		[Token(Token = "0x6002A7D")]
		[Address(RVA = "0x99FCF4", Offset = "0x99FCF4", VA = "0x99FCF4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002A7E")]
		[Address(RVA = "0x99FD10", Offset = "0x99FD10", VA = "0x99FD10")]
		set
		{
		}
	}

	[Token(Token = "0x17000576")]
	public int PlayerScore
	{
		[Token(Token = "0x6002A7F")]
		[Address(RVA = "0x99FE18", Offset = "0x99FE18", VA = "0x99FE18")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002A80")]
		[Address(RVA = "0x99FE38", Offset = "0x99FE38", VA = "0x99FE38")]
		set
		{
		}
	}

	[Token(Token = "0x6002A81")]
	[Address(RVA = "0x99FF1C", Offset = "0x99FF1C", VA = "0x99FF1C", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002A82")]
	[Address(RVA = "0x9A0310", Offset = "0x9A0310", VA = "0x9A0310", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002A83")]
	[Address(RVA = "0x9A03F0", Offset = "0x9A03F0", VA = "0x9A03F0", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002A84")]
	[Address(RVA = "0x9A049C", Offset = "0x9A049C", VA = "0x9A049C", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002A85")]
	[Address(RVA = "0x9A0594", Offset = "0x9A0594", VA = "0x9A0594")]
	public void SetPlayerScoreLabelColor(Color color)
	{
	}

	[Token(Token = "0x6002A86")]
	[Address(RVA = "0x9A05B4", Offset = "0x9A05B4", VA = "0x9A05B4")]
	public void SetComponentsActive(bool isActive)
	{
	}

	[Token(Token = "0x6002A87")]
	[Address(RVA = "0x9A06EC", Offset = "0x9A06EC", VA = "0x9A06EC", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002A88")]
	[Address(RVA = "0x9A0104", Offset = "0x9A0104", VA = "0x9A0104")]
	private void OnPlayerNameChanged(string playerName)
	{
	}

	[Token(Token = "0x6002A89")]
	[Address(RVA = "0x9A0108", Offset = "0x9A0108", VA = "0x9A0108")]
	private void OnPlayerScoreChanged(int score)
	{
	}

	[Token(Token = "0x6002A8A")]
	[Address(RVA = "0x9A010C", Offset = "0x9A010C", VA = "0x9A010C")]
	private void OnAvatarChanged(Texture avatar)
	{
	}

	[Token(Token = "0x6002A8B")]
	[Address(RVA = "0x9A09E8", Offset = "0x9A09E8", VA = "0x9A09E8")]
	private void OnRemoveFriendClicked(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs e)
	{
	}

	[Token(Token = "0x6002A8C")]
	[Address(RVA = "0x9A01DC", Offset = "0x9A01DC", VA = "0x9A01DC")]
	private void OnPlayerRecordChanged(LeaderboardRecord record)
	{
	}

	[Token(Token = "0x6002A8D")]
	[Address(RVA = "0x9A0AA4", Offset = "0x9A0AA4", VA = "0x9A0AA4")]
	public LeaderboardItem()
	{
	}
}
