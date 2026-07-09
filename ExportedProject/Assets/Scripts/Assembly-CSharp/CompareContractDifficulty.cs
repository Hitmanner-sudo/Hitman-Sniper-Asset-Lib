using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x200043E")]
public class CompareContractDifficulty : FsmStateAction
{
	[Token(Token = "0x400176F")]
	[FieldOffset(Offset = "0x4C")]
	public ContractDataModel.DifficultyType DifficultyToCompare;

	[Token(Token = "0x4001770")]
	[FieldOffset(Offset = "0x50")]
	public FsmEvent Equal;

	[Token(Token = "0x4001771")]
	[FieldOffset(Offset = "0x58")]
	public FsmEvent NotEqual;

	[Token(Token = "0x60019F3")]
	[Address(RVA = "0x8DEB64", Offset = "0x8DEB64", VA = "0x8DEB64", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60019F4")]
	[Address(RVA = "0x8DEC8C", Offset = "0x8DEC8C", VA = "0x8DEC8C")]
	private void DoCompare(ChallengeData data)
	{
	}

	[Token(Token = "0x60019F5")]
	[Address(RVA = "0x8DECD4", Offset = "0x8DECD4", VA = "0x8DECD4")]
	public CompareContractDifficulty()
	{
	}
}
