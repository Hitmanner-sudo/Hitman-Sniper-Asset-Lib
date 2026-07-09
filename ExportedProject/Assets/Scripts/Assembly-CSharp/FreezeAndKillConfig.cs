using Il2CppDummyDll;
using Technology;
using Technology.Core;
using UnityEngine;

[Token(Token = "0x20001E6")]
[Attribute(Name = "ResourcePathAttribute", RVA = "0x5929C4", Offset = "0x5929C4")]
public class FreezeAndKillConfig : ScriptableSingleton<FreezeAndKillConfig>
{
	[Token(Token = "0x4000AF2")]
	[FieldOffset(Offset = "0x18")]
	public LazyGameObject IceCharacterDestroyed;

	[Token(Token = "0x4000AF3")]
	[FieldOffset(Offset = "0x20")]
	public NPCFilter BodyDisposalNPCFilter;

	[Token(Token = "0x4000AF4")]
	[FieldOffset(Offset = "0x28")]
	public Material FreezeMaterial;

	[Token(Token = "0x4000AF5")]
	[FieldOffset(Offset = "0x30")]
	public GameObject EffectToSpawnAtCenter;

	[Token(Token = "0x4000AF6")]
	[FieldOffset(Offset = "0x38")]
	public float EffectDuration;

	[Token(Token = "0x4000AF7")]
	[FieldOffset(Offset = "0x40")]
	public SoundContainer FreezingSound;

	[Token(Token = "0x4000AF8")]
	[FieldOffset(Offset = "0x48")]
	public SoundContainer BreakSound;

	[Token(Token = "0x6000BFF")]
	[Address(RVA = "0x95B290", Offset = "0x95B290", VA = "0x95B290")]
	public FreezeAndKillConfig()
	{
	}
}
