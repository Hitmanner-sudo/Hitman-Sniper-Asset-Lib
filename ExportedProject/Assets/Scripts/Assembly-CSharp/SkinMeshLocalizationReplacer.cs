using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000916")]
public class SkinMeshLocalizationReplacer : MonoBehaviour
{
	[Token(Token = "0x40031C5")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SkinnedMeshRenderer _renderer;

	[Token(Token = "0x40031C6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private MeshFilter _primaryMesh;

	[Token(Token = "0x40031C7")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private MeshFilter _alternativeMesh;

	[Token(Token = "0x60039FC")]
	[Address(RVA = "0x8468A8", Offset = "0x8468A8", VA = "0x8468A8")]
	private void Start()
	{
	}

	[Token(Token = "0x60039FD")]
	[Address(RVA = "0x8469BC", Offset = "0x8469BC", VA = "0x8469BC")]
	public SkinMeshLocalizationReplacer()
	{
	}
}
