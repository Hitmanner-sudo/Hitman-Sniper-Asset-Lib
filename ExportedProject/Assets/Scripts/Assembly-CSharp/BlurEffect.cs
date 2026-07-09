using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200091F")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x596F4C", Offset = "0x596F4C")]
public class BlurEffect : MonoBehaviour
{
	[Token(Token = "0x40031E2")]
	[FieldOffset(Offset = "0x18")]
	public int iterations;

	[Token(Token = "0x40031E3")]
	[FieldOffset(Offset = "0x1C")]
	public float blurSpread;

	[Token(Token = "0x40031E4")]
	[FieldOffset(Offset = "0x20")]
	public Shader blurShader;

	[Token(Token = "0x40031E5")]
	[FieldOffset(Offset = "0x0")]
	private static Material m_Material;

	[Token(Token = "0x17000751")]
	protected Material material
	{
		[Token(Token = "0x6003A2A")]
		[Address(RVA = "0xA7DB04", Offset = "0xA7DB04", VA = "0xA7DB04")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003A2B")]
	[Address(RVA = "0xA7DC50", Offset = "0xA7DC50", VA = "0xA7DC50")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x6003A2C")]
	[Address(RVA = "0xA7DD90", Offset = "0xA7DD90", VA = "0xA7DD90")]
	protected void Start()
	{
	}

	[Token(Token = "0x6003A2D")]
	[Address(RVA = "0xA7DE4C", Offset = "0xA7DE4C", VA = "0xA7DE4C")]
	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
	{
	}

	[Token(Token = "0x6003A2E")]
	[Address(RVA = "0xA7DF70", Offset = "0xA7DF70", VA = "0xA7DF70")]
	private void DownSample4x(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6003A2F")]
	[Address(RVA = "0xA7E080", Offset = "0xA7E080", VA = "0xA7E080")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6003A30")]
	[Address(RVA = "0xA7E1E8", Offset = "0xA7E1E8", VA = "0xA7E1E8")]
	public BlurEffect()
	{
	}
}
