using HutongGames.PlayMaker;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007D3")]
[Attribute(Name = "TooltipAttribute", RVA = "0x59633C", Offset = "0x59633C")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59633C", Offset = "0x59633C")]
public class StopParticleSystem : FsmStateAction
{
	[Token(Token = "0x4002BC1")]
	[FieldOffset(Offset = "0x50")]
	[RequiredField]
	[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5BAE34", Offset = "0x5BAE34")]
	public FsmOwnerDefault gameObject;

	[Token(Token = "0x4002BC2")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5BAEA4", Offset = "0x5BAEA4")]
	public FsmFloat delay;

	[Token(Token = "0x4002BC3")]
	[FieldOffset(Offset = "0x60")]
	private GameObject _gameObject;

	[Token(Token = "0x4002BC4")]
	[FieldOffset(Offset = "0x68")]
	private float _timer;

	[Token(Token = "0x6003360")]
	[Address(RVA = "0xD2B1B4", Offset = "0xD2B1B4", VA = "0xD2B1B4", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6003361")]
	[Address(RVA = "0xD2B1E8", Offset = "0xD2B1E8", VA = "0xD2B1E8")]
	private void Stop()
	{
	}

	[Token(Token = "0x6003362")]
	[Address(RVA = "0xD2B29C", Offset = "0xD2B29C", VA = "0xD2B29C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6003363")]
	[Address(RVA = "0xD2B304", Offset = "0xD2B304", VA = "0xD2B304", Slot = "34")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x6003364")]
	[Address(RVA = "0xD2B36C", Offset = "0xD2B36C", VA = "0xD2B36C")]
	public StopParticleSystem()
	{
	}
}
