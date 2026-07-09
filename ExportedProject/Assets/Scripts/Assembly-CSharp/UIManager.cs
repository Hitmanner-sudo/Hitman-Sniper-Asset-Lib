using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000634")]
[Scope]
public class UIManager : GameSingleton<UIManager>
{
	[Token(Token = "0x2000635")]
	public class AtlasInfo
	{
		[Token(Token = "0x4002236")]
		[FieldOffset(Offset = "0x10")]
		public UIAtlas Atlas;

		[Token(Token = "0x4002237")]
		[FieldOffset(Offset = "0x18")]
		public string SpriteName;

		[Token(Token = "0x6002827")]
		[Address(RVA = "0xA3D94C", Offset = "0xA3D94C", VA = "0xA3D94C")]
		public AtlasInfo(UIAtlas atlas, string spriteName)
		{
		}
	}

	[Token(Token = "0x4002235")]
	[FieldOffset(Offset = "0x48")]
	public ModelContainer ModelContainer;

	[Token(Token = "0x6002822")]
	[Address(RVA = "0x14243C0", Offset = "0x14243C0", VA = "0x14243C0")]
	public void SetTooltip(string text, UIAtlas atlas, string spriteName)
	{
	}

	[Token(Token = "0x6002823")]
	[Address(RVA = "0x1424528", Offset = "0x1424528", VA = "0x1424528")]
	public void SetTooltip(string text, Texture texture)
	{
	}

	[Token(Token = "0x6002824")]
	[Address(RVA = "0x142449C", Offset = "0x142449C", VA = "0x142449C")]
	public void SetTooltip(string text)
	{
	}

	[Token(Token = "0x6002825")]
	[Address(RVA = "0x14245C4", Offset = "0x14245C4", VA = "0x14245C4")]
	public void ResetTooltipText(string text)
	{
	}

	[Token(Token = "0x6002826")]
	[Address(RVA = "0x14246D8", Offset = "0x14246D8", VA = "0x14246D8")]
	public UIManager()
	{
	}
}
