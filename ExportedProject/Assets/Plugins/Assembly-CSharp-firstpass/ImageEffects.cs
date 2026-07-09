using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000015")]
[Attribute(Name = "AddComponentMenu", RVA = "0x6F8E98", Offset = "0x6F8E98")]
public class ImageEffects
{
	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x10EF638", Offset = "0x10EF638", VA = "0x10EF638")]
	public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x10EF884", Offset = "0x10EF884", VA = "0x10EF884")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x6F9CD0", Offset = "0x6F9CD0")]
	public static void Blit(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x10EF8F8", Offset = "0x10EF8F8", VA = "0x10EF8F8")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x6F9D08", Offset = "0x6F9D08")]
	public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x10EF974", Offset = "0x10EF974", VA = "0x10EF974")]
	public ImageEffects()
	{
	}
}
