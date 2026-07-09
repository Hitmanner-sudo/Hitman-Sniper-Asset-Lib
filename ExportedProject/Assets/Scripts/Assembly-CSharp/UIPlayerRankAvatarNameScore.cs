using Il2CppDummyDll;

[Token(Token = "0x20007A4")]
public class UIPlayerRankAvatarNameScore : UIWidgetContainer
{
	[Token(Token = "0x4002B05")]
	[FieldOffset(Offset = "0x18")]
	public UISprite PlayerRankIcon;

	[Token(Token = "0x4002B06")]
	[FieldOffset(Offset = "0x20")]
	public UISprite PlayerNoAvatar;

	[Token(Token = "0x4002B07")]
	[FieldOffset(Offset = "0x28")]
	public UITexture PlayerAvatar;

	[Token(Token = "0x4002B08")]
	[FieldOffset(Offset = "0x30")]
	public UILabel PlayerName;

	[Token(Token = "0x4002B09")]
	[FieldOffset(Offset = "0x38")]
	public UILabel PlayerScore;

	[Token(Token = "0x6003285")]
	[Address(RVA = "0x142A33C", Offset = "0x142A33C", VA = "0x142A33C")]
	public void SetAlpha(float alpha)
	{
	}

	[Token(Token = "0x6003286")]
	[Address(RVA = "0x142A3C4", Offset = "0x142A3C4", VA = "0x142A3C4")]
	public UIPlayerRankAvatarNameScore()
	{
	}
}
