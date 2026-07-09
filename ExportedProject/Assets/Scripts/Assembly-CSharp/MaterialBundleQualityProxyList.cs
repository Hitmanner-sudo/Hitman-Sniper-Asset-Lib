using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000886")]
public class MaterialBundleQualityProxyList : QualityProxy
{
	[Token(Token = "0x4002FC0")]
	[FieldOffset(Offset = "0x48")]
	public LazyMaterial[] High;

	[Token(Token = "0x4002FC1")]
	[FieldOffset(Offset = "0x50")]
	public LazyMaterial[] Low;

	[Token(Token = "0x4002FC2")]
	[FieldOffset(Offset = "0x58")]
	private bool _isLowQuality;

	[Token(Token = "0x4002FC3")]
	[FieldOffset(Offset = "0x60")]
	private MeshRenderer _meshRenderer;

	[Token(Token = "0x4002FC4")]
	[FieldOffset(Offset = "0x68")]
	private SkinnedMeshRenderer _skinnedMeshRenderer;

	[Token(Token = "0x60037B4")]
	[Address(RVA = "0x9B02C8", Offset = "0x9B02C8", VA = "0x9B02C8", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60037B5")]
	[Address(RVA = "0x9B03D4", Offset = "0x9B03D4", VA = "0x9B03D4")]
	private void AssignRenderer()
	{
	}

	[Token(Token = "0x60037B6")]
	[Address(RVA = "0x9B03A4", Offset = "0x9B03A4", VA = "0x9B03A4")]
	private void SetMaterialForQuality()
	{
	}

	[Token(Token = "0x60037B7")]
	[Address(RVA = "0x9B04CC", Offset = "0x9B04CC", VA = "0x9B04CC")]
	private void AssignMaterial(bool isLowQuality)
	{
	}

	[Token(Token = "0x60037B8")]
	[Address(RVA = "0x9B06B8", Offset = "0x9B06B8", VA = "0x9B06B8")]
	public MaterialBundleQualityProxyList()
	{
	}
}
