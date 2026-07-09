using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000920")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x596F98", Offset = "0x596F98")]
public class GrayscaleEffect : ImageEffectBase
{
	[Token(Token = "0x40031E6")]
	[FieldOffset(Offset = "0x28")]
	public Texture TextureRamp;

	[Token(Token = "0x40031E7")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "RangeAttribute", RVA = "0x5BBBD4", Offset = "0x5BBBD4")]
	public float RampOffset;

	[Token(Token = "0x40031E8")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "RangeAttribute", RVA = "0x5BBBEC", Offset = "0x5BBBEC")]
	public float Ratio;

	[Token(Token = "0x6003A32")]
	[Address(RVA = "0xC89F40", Offset = "0xC89F40", VA = "0xC89F40")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6003A33")]
	[Address(RVA = "0xC8A070", Offset = "0xC8A070", VA = "0xC8A070")]
	public GrayscaleEffect()
	{
	}
}
