using HutongGames.PlayMaker;
using Il2CppDummyDll;
using Technology;

[Token(Token = "0x2000466")]
[Attribute(Name = "TooltipAttribute", RVA = "0x594738", Offset = "0x594738")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x594738", Offset = "0x594738")]
public class PlayZombieVO : FsmStateAction
{
	[Token(Token = "0x4001822")]
	[FieldOffset(Offset = "0x50")]
	[RequiredField]
	public SoundContainer SoundContainer;

	[Token(Token = "0x6001A99")]
	[Address(RVA = "0xB8226C", Offset = "0xB8226C", VA = "0xB8226C", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001A9A")]
	[Address(RVA = "0xB82274", Offset = "0xB82274", VA = "0xB82274", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001A9B")]
	[Address(RVA = "0xB8229C", Offset = "0xB8229C", VA = "0xB8229C")]
	private void DoPlaySound()
	{
	}

	[Token(Token = "0x6001A9C")]
	[Address(RVA = "0xB8248C", Offset = "0xB8248C", VA = "0xB8248C")]
	public PlayZombieVO()
	{
	}
}
