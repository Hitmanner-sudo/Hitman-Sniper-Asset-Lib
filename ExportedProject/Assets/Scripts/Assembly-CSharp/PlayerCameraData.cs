using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001C2")]
public class PlayerCameraData : MonoBehaviour
{
	[Token(Token = "0x4000992")]
	[FieldOffset(Offset = "0x18")]
	public float NearClip;

	[Token(Token = "0x4000993")]
	[FieldOffset(Offset = "0x1C")]
	public float FarClip;

	[Token(Token = "0x4000994")]
	[FieldOffset(Offset = "0x20")]
	public Texture2D LutTexture;

	[Token(Token = "0x4000995")]
	[FieldOffset(Offset = "0x28")]
	public float LutBlendAmount;

	[Token(Token = "0x4000996")]
	[FieldOffset(Offset = "0x30")]
	public LazyMaterial VignetteMaterial;

	[Token(Token = "0x4000997")]
	[FieldOffset(Offset = "0x38")]
	public float VignetteSpeedYaw;

	[Token(Token = "0x4000998")]
	[FieldOffset(Offset = "0x3C")]
	public float VignetteSpeedPitch;

	[Token(Token = "0x4000999")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "RangeAttribute", RVA = "0x5B22D8", Offset = "0x5B22D8")]
	public float VignetteCenteredYaw;

	[Token(Token = "0x400099A")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "RangeAttribute", RVA = "0x5B22F8", Offset = "0x5B22F8")]
	public float VignetteCenteredPitch;

	[Token(Token = "0x6000BA2")]
	[Address(RVA = "0xB846D8", Offset = "0xB846D8", VA = "0xB846D8")]
	public PlayerCameraData()
	{
	}
}
