using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006AD")]
public class MissionTallyScreenNormal : View
{
	[Token(Token = "0x20006AE")]
	private enum MissionStatus
	{
		[Token(Token = "0x400253D")]
		Success = 0,
		[Token(Token = "0x400253E")]
		Incomplete = 1,
		[Token(Token = "0x400253F")]
		Failure = 2
	}

	[Token(Token = "0x400253B")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private UILabel _missionStatusLabel;

	[Token(Token = "0x6002BC9")]
	[Address(RVA = "0xA1CCFC", Offset = "0xA1CCFC", VA = "0xA1CCFC", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002BCA")]
	[Address(RVA = "0xA1CD24", Offset = "0xA1CD24", VA = "0xA1CD24")]
	private void SetupMissionStatus()
	{
	}

	[Token(Token = "0x6002BCB")]
	[Address(RVA = "0xA1CEEC", Offset = "0xA1CEEC", VA = "0xA1CEEC")]
	private void GetLocAndColor(MissionStatus status, out string text, out Color color)
	{
	}

	[Token(Token = "0x6002BCC")]
	[Address(RVA = "0xA1D038", Offset = "0xA1D038", VA = "0xA1D038")]
	public MissionTallyScreenNormal()
	{
	}
}
