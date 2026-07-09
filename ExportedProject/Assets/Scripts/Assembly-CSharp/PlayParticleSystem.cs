using HutongGames.PlayMaker;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007D2")]
[Attribute(Name = "TooltipAttribute", RVA = "0x5962DC", Offset = "0x5962DC")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5962DC", Offset = "0x5962DC")]
public class PlayParticleSystem : FsmStateAction
{
	[Token(Token = "0x4002BBD")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5BAD8C", Offset = "0x5BAD8C")]
	[RequiredField]
	public FsmOwnerDefault gameObject;

	[Token(Token = "0x4002BBE")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5BADFC", Offset = "0x5BADFC")]
	public FsmFloat delay;

	[Token(Token = "0x4002BBF")]
	[FieldOffset(Offset = "0x60")]
	private GameObject _gameObject;

	[Token(Token = "0x4002BC0")]
	[FieldOffset(Offset = "0x68")]
	private float _timer;

	[Token(Token = "0x600335B")]
	[Address(RVA = "0xB80560", Offset = "0xB80560", VA = "0xB80560", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600335C")]
	[Address(RVA = "0xB80594", Offset = "0xB80594", VA = "0xB80594")]
	private void Play()
	{
	}

	[Token(Token = "0x600335D")]
	[Address(RVA = "0xB80648", Offset = "0xB80648", VA = "0xB80648", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600335E")]
	[Address(RVA = "0xB806B0", Offset = "0xB806B0", VA = "0xB806B0", Slot = "34")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x600335F")]
	[Address(RVA = "0xB80718", Offset = "0xB80718", VA = "0xB80718")]
	public PlayParticleSystem()
	{
	}
}
