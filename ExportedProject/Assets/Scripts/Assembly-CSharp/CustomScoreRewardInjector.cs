using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000441")]
[Attribute(Name = "TooltipAttribute", RVA = "0x593F60", Offset = "0x593F60")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x593F60", Offset = "0x593F60")]
public class CustomScoreRewardInjector : FsmStateAction
{
	[Token(Token = "0x400177D")]
	[FieldOffset(Offset = "0x50")]
	public string RewardName;

	[Token(Token = "0x400177E")]
	[FieldOffset(Offset = "0x58")]
	public string LazyRewardActionConfigPath;

	[Token(Token = "0x60019FC")]
	[Address(RVA = "0xD8DF5C", Offset = "0xD8DF5C", VA = "0xD8DF5C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60019FD")]
	[Address(RVA = "0xD8E0F4", Offset = "0xD8E0F4", VA = "0xD8E0F4", Slot = "61")]
	public override string ErrorCheck()
	{
		return null;
	}

	[Token(Token = "0x60019FE")]
	[Address(RVA = "0xD8E164", Offset = "0xD8E164", VA = "0xD8E164")]
	public CustomScoreRewardInjector()
	{
	}

	[Token(Token = "0x60019FF")]
	[Address(RVA = "0xD8E1B8", Offset = "0xD8E1B8", VA = "0xD8E1B8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6177F4", Offset = "0x6177F4")]
	private bool _003COnEnter_003Eb__2_0(RewardCustomScore r)
	{
		return default(bool);
	}
}
