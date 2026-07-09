using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000885")]
public class MaterialBundleQualityProxy : QualityProxy
{
	[Token(Token = "0x4002FBB")]
	[FieldOffset(Offset = "0x48")]
	public LazyMaterial High;

	[Token(Token = "0x4002FBC")]
	[FieldOffset(Offset = "0x50")]
	public LazyMaterial Low;

	[Token(Token = "0x4002FBD")]
	[FieldOffset(Offset = "0x58")]
	private bool _isLowQuality;

	[Token(Token = "0x4002FBE")]
	[FieldOffset(Offset = "0x60")]
	private MeshRenderer _meshRenderer;

	[Token(Token = "0x4002FBF")]
	[FieldOffset(Offset = "0x68")]
	private SkinnedMeshRenderer _skinnedMeshRenderer;

	[Token(Token = "0x60037B0")]
	[Address(RVA = "0x9AFF58", Offset = "0x9AFF58", VA = "0x9AFF58", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60037B1")]
	[Address(RVA = "0x9B01C8", Offset = "0x9B01C8", VA = "0x9B01C8")]
	private void AssignRenderer()
	{
	}

	[Token(Token = "0x60037B2")]
	[Address(RVA = "0x9B0024", Offset = "0x9B0024", VA = "0x9B0024")]
	private void SetMaterialForQuality()
	{
	}

	[Token(Token = "0x60037B3")]
	[Address(RVA = "0x9B02C0", Offset = "0x9B02C0", VA = "0x9B02C0")]
	public MaterialBundleQualityProxy()
	{
	}
}
