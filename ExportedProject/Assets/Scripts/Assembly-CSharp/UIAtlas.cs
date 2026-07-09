using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200007F")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x591A90", Offset = "0x591A90")]
public class UIAtlas : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000080")]
	private class Sprite
	{
		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x18")]
		public Rect outer;

		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x28")]
		public Rect inner;

		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x38")]
		public bool rotated;

		[Token(Token = "0x40002C2")]
		[FieldOffset(Offset = "0x3C")]
		public float paddingLeft;

		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x40")]
		public float paddingRight;

		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x44")]
		public float paddingTop;

		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x48")]
		public float paddingBottom;

		[Token(Token = "0x170000A5")]
		public bool hasPadding
		{
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0xA3A774", Offset = "0xA3A774", VA = "0xA3A774")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xA3A7B0", Offset = "0xA3A7B0", VA = "0xA3A7B0")]
		public Sprite()
		{
		}
	}

	[Token(Token = "0x2000081")]
	private enum Coordinates
	{
		[Token(Token = "0x40002C7")]
		Pixels = 0,
		[Token(Token = "0x40002C8")]
		TexCoords = 1
	}

	[Serializable]
	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591AC8", Offset = "0x591AC8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<UISpriteData> _003C_003E9__26_0;

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xA3A740", Offset = "0xA3A740", VA = "0xA3A740")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xA3A748", Offset = "0xA3A748", VA = "0xA3A748")]
		internal int _003CSortAlphabetically_003Eb__26_0(UISpriteData s1, UISpriteData s2)
		{
			return default(int);
		}
	}

	[Token(Token = "0x40002B7")]
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	private Material material;

	[Token(Token = "0x40002B8")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[HideInInspector]
	private List<UISpriteData> mSprites;

	[Token(Token = "0x40002B9")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	[SerializeField]
	private float mPixelSize;

	[Token(Token = "0x40002BA")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	[SerializeField]
	private UIAtlas mReplacement;

	[Token(Token = "0x40002BB")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[HideInInspector]
	private Coordinates mCoordinates;

	[Token(Token = "0x40002BC")]
	[FieldOffset(Offset = "0x40")]
	[HideInInspector]
	[SerializeField]
	private List<Sprite> sprites;

	[Token(Token = "0x40002BD")]
	[FieldOffset(Offset = "0x48")]
	private int mPMA;

	[Token(Token = "0x1700009F")]
	public Material spriteMaterial
	{
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x1578D88", Offset = "0x1578D88", VA = "0x1578D88")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x1578E18", Offset = "0x1578E18", VA = "0x1578E18")]
		set
		{
		}
	}

	[Token(Token = "0x170000A0")]
	public bool premultipliedAlpha
	{
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x1579260", Offset = "0x1579260", VA = "0x1579260")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000A1")]
	public List<UISpriteData> spriteList
	{
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x15793C8", Offset = "0x15793C8", VA = "0x15793C8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x15798A0", Offset = "0x15798A0", VA = "0x15798A0")]
		set
		{
		}
	}

	[Token(Token = "0x170000A2")]
	public Texture texture
	{
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1579934", Offset = "0x1579934", VA = "0x1579934")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A3")]
	public float pixelSize
	{
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x1579A14", Offset = "0x1579A14", VA = "0x1579A14")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1579AA4", Offset = "0x1579AA4", VA = "0x1579AA4")]
		set
		{
		}
	}

	[Token(Token = "0x170000A4")]
	public UIAtlas replacement
	{
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x1579B7C", Offset = "0x1579B7C", VA = "0x1579B7C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x1579B84", Offset = "0x1579B84", VA = "0x1579B84")]
		set
		{
		}
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x1579CF8", Offset = "0x1579CF8", VA = "0x1579CF8")]
	public UISpriteData GetSprite(string name)
	{
		return null;
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x1579E60", Offset = "0x1579E60", VA = "0x1579E60")]
	public void SortAlphabetically()
	{
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x1579F84", Offset = "0x1579F84", VA = "0x1579F84")]
	public BetterList<string> GetListOfSprites()
	{
		return null;
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x157A120", Offset = "0x157A120", VA = "0x157A120")]
	public BetterList<string> GetListOfSprites(string match)
	{
		return null;
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x157A4E0", Offset = "0x157A4E0", VA = "0x157A4E0")]
	private bool References(UIAtlas atlas)
	{
		return default(bool);
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x157A5D4", Offset = "0x157A5D4", VA = "0x157A5D4")]
	public static bool CheckIfRelated(UIAtlas a, UIAtlas b)
	{
		return default(bool);
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x1578F0C", Offset = "0x1578F0C", VA = "0x1578F0C")]
	public void MarkAsDirty()
	{
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x1579480", Offset = "0x1579480", VA = "0x1579480")]
	private bool Upgrade()
	{
		return default(bool);
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x157A6E8", Offset = "0x157A6E8", VA = "0x157A6E8")]
	public UIAtlas()
	{
	}
}
