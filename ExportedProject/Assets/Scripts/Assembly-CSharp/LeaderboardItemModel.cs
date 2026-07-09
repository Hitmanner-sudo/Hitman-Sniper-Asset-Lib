using Il2CppDummyDll;
using Technology.Social;
using UnityEngine;

[Token(Token = "0x20005AF")]
public class LeaderboardItemModel : DataModel
{
	[Token(Token = "0x4001E5A")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string PLAYER_NAME;

	[Token(Token = "0x4001E5B")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string PLAYER_RANK;

	[Token(Token = "0x4001E5C")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string PLAYER_SCORE;

	[Token(Token = "0x4001E5D")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string PLAYER_AVATAR;

	[Token(Token = "0x4001E5E")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string PLAYER_RECORD;

	[Token(Token = "0x4001E5F")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string SHOW_TIER_ICON;

	[Token(Token = "0x4001E60")]
	[FieldOffset(Offset = "0x48")]
	private string _playerName;

	[Token(Token = "0x4001E61")]
	[FieldOffset(Offset = "0x50")]
	private int _playerRank;

	[Token(Token = "0x4001E62")]
	[FieldOffset(Offset = "0x54")]
	private int _playerScore;

	[Token(Token = "0x4001E63")]
	[FieldOffset(Offset = "0x58")]
	private Texture _playerAvatar;

	[Token(Token = "0x4001E64")]
	[FieldOffset(Offset = "0x60")]
	private LeaderboardRecord _playerRecord;

	[Token(Token = "0x4001E65")]
	[FieldOffset(Offset = "0x68")]
	private bool _showTierIcon;

	[Token(Token = "0x60023F8")]
	[Address(RVA = "0x9A0AAC", Offset = "0x9A0AAC", VA = "0x9A0AAC", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x60023F9")]
	[Address(RVA = "0x9A0F44", Offset = "0x9A0F44", VA = "0x9A0F44")]
	private void SetPlayerRecord(object record)
	{
	}

	[Token(Token = "0x60023FA")]
	[Address(RVA = "0x9A11FC", Offset = "0x9A11FC", VA = "0x9A11FC")]
	public LeaderboardItemModel()
	{
	}

	[Token(Token = "0x60023FC")]
	[Address(RVA = "0x9A130C", Offset = "0x9A130C", VA = "0x9A130C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AC90", Offset = "0x61AC90")]
	private object _003CBindAllVariables_003Eb__12_0()
	{
		return null;
	}

	[Token(Token = "0x60023FD")]
	[Address(RVA = "0x9A1314", Offset = "0x9A1314", VA = "0x9A1314")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61ACA0", Offset = "0x61ACA0")]
	private void _003CBindAllVariables_003Eb__12_1(object s)
	{
	}

	[Token(Token = "0x60023FE")]
	[Address(RVA = "0x9A1384", Offset = "0x9A1384", VA = "0x9A1384")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61ACB0", Offset = "0x61ACB0")]
	private int _003CBindAllVariables_003Eb__12_2()
	{
		return default(int);
	}

	[Token(Token = "0x60023FF")]
	[Address(RVA = "0x9A138C", Offset = "0x9A138C", VA = "0x9A138C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61ACC0", Offset = "0x61ACC0")]
	private void _003CBindAllVariables_003Eb__12_3(int i)
	{
	}

	[Token(Token = "0x6002400")]
	[Address(RVA = "0x9A1394", Offset = "0x9A1394", VA = "0x9A1394")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61ACD0", Offset = "0x61ACD0")]
	private int _003CBindAllVariables_003Eb__12_4()
	{
		return default(int);
	}

	[Token(Token = "0x6002401")]
	[Address(RVA = "0x9A139C", Offset = "0x9A139C", VA = "0x9A139C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61ACE0", Offset = "0x61ACE0")]
	private void _003CBindAllVariables_003Eb__12_5(int i)
	{
	}

	[Token(Token = "0x6002402")]
	[Address(RVA = "0x9A13A4", Offset = "0x9A13A4", VA = "0x9A13A4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61ACF0", Offset = "0x61ACF0")]
	private object _003CBindAllVariables_003Eb__12_6()
	{
		return null;
	}

	[Token(Token = "0x6002403")]
	[Address(RVA = "0x9A13AC", Offset = "0x9A13AC", VA = "0x9A13AC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AD00", Offset = "0x61AD00")]
	private void _003CBindAllVariables_003Eb__12_7(object t)
	{
	}

	[Token(Token = "0x6002404")]
	[Address(RVA = "0x9A1438", Offset = "0x9A1438", VA = "0x9A1438")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AD10", Offset = "0x61AD10")]
	private object _003CBindAllVariables_003Eb__12_8()
	{
		return null;
	}

	[Token(Token = "0x6002405")]
	[Address(RVA = "0x9A1440", Offset = "0x9A1440", VA = "0x9A1440")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AD20", Offset = "0x61AD20")]
	private bool _003CBindAllVariables_003Eb__12_9()
	{
		return default(bool);
	}

	[Token(Token = "0x6002406")]
	[Address(RVA = "0x9A1448", Offset = "0x9A1448", VA = "0x9A1448")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AD30", Offset = "0x61AD30")]
	private void _003CBindAllVariables_003Eb__12_10(bool b)
	{
	}
}
