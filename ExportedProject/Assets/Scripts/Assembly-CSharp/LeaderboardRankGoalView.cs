using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000681")]
public class LeaderboardRankGoalView : View
{
	[Token(Token = "0x400246A")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GameObject _visual;

	[Token(Token = "0x400246B")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private UITexture _currentRankTexture;

	[Token(Token = "0x400246C")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private UITexture _currentRankTextureTransparent;

	[Token(Token = "0x400246D")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private UITexture _nextRankTexture;

	[Token(Token = "0x400246E")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private UITexture _rewardTexture;

	[Token(Token = "0x400246F")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UILabel _nextRankName;

	[Token(Token = "0x4002470")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private UILabel _nextRankScore;

	[Token(Token = "0x4002471")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private UIPanel _nonChallengerSection;

	[Token(Token = "0x4002472")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private UIPanel _challengerSection;

	[Token(Token = "0x4002473")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private float _fadeInDuration;

	[Token(Token = "0x4002474")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private string _challengerGoalKey;

	[Token(Token = "0x6002A8E")]
	[Address(RVA = "0x9A5FDC", Offset = "0x9A5FDC", VA = "0x9A5FDC", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002A8F")]
	[Address(RVA = "0x9A6194", Offset = "0x9A6194", VA = "0x9A6194", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002A90")]
	[Address(RVA = "0x9A6300", Offset = "0x9A6300", VA = "0x9A6300")]
	private void RefreshVisual()
	{
	}

	[Token(Token = "0x6002A91")]
	[Address(RVA = "0x9A6048", Offset = "0x9A6048", VA = "0x9A6048")]
	private void UpdateVisibility()
	{
	}

	[Token(Token = "0x6002A92")]
	[Address(RVA = "0x9A6910", Offset = "0x9A6910", VA = "0x9A6910")]
	private static Texture2D GetTransparentIcon(Texture2D tierIcon)
	{
		return null;
	}

	[Token(Token = "0x6002A93")]
	[Address(RVA = "0x9A69D4", Offset = "0x9A69D4", VA = "0x9A69D4")]
	private void FadePanelIn(UIPanel panel)
	{
	}

	[Token(Token = "0x6002A94")]
	[Address(RVA = "0x9A6A44", Offset = "0x9A6A44", VA = "0x9A6A44")]
	public LeaderboardRankGoalView()
	{
	}
}
