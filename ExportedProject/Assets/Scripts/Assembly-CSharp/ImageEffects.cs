using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000922")]
[Attribute(Name = "AddComponentMenu", RVA = "0x597068", Offset = "0x597068")]
public class ImageEffects
{
	[Token(Token = "0x6003A38")]
	[Address(RVA = "0xA16B64", Offset = "0xA16B64", VA = "0xA16B64")]
	public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
	{
	}

	[Token(Token = "0x6003A39")]
	[Address(RVA = "0xA16DB0", Offset = "0xA16DB0", VA = "0xA16DB0")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x624910", Offset = "0x624910")]
	public static void Blit(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6003A3A")]
	[Address(RVA = "0xA16E24", Offset = "0xA16E24", VA = "0xA16E24")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x624948", Offset = "0x624948")]
	public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6003A3B")]
	[Address(RVA = "0xA16EA0", Offset = "0xA16EA0", VA = "0xA16EA0")]
	public ImageEffects()
	{
	}
}
