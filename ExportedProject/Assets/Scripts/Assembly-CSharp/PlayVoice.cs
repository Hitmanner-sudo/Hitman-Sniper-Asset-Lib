using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000465")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5946E8", Offset = "0x5946E8")]
[Attribute(Name = "TooltipAttribute", RVA = "0x5946E8", Offset = "0x5946E8")]
public class PlayVoice : FsmStateAction
{
	[Token(Token = "0x400181E")]
	[FieldOffset(Offset = "0x50")]
	[RequiredField]
	public FsmGameObject AudioSource;

	[Token(Token = "0x400181F")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "ObjectTypeAttribute", RVA = "0x5B6964", Offset = "0x5B6964")]
	[RequiredField]
	public FsmObject Bark;

	[Token(Token = "0x4001820")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B69D4", Offset = "0x5B69D4")]
	public float EndWaitTime;

	[Token(Token = "0x4001821")]
	[FieldOffset(Offset = "0x68")]
	private GameTimer _barkTimer;

	[Token(Token = "0x6001A94")]
	[Address(RVA = "0xB81F6C", Offset = "0xB81F6C", VA = "0xB81F6C", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001A95")]
	[Address(RVA = "0xB81F78", Offset = "0xB81F78", VA = "0xB81F78", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001A96")]
	[Address(RVA = "0xB82220", Offset = "0xB82220", VA = "0xB82220", Slot = "34")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x6001A97")]
	[Address(RVA = "0xB81F7C", Offset = "0xB81F7C", VA = "0xB81F7C")]
	private void DoPlaySound()
	{
	}

	[Token(Token = "0x6001A98")]
	[Address(RVA = "0xB82264", Offset = "0xB82264", VA = "0xB82264")]
	public PlayVoice()
	{
	}
}
