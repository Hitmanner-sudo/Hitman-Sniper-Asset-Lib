using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200062D")]
public class StretchQuadToViewFrustum : MonoBehaviour
{
	[Token(Token = "0x400221C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Camera _camera;

	[Token(Token = "0x400221D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _scaleHeight;

	[Token(Token = "0x400221E")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _meshAspect;

	[Token(Token = "0x600280A")]
	[Address(RVA = "0xD2DB24", Offset = "0xD2DB24", VA = "0xD2DB24")]
	protected void Start()
	{
	}

	[Token(Token = "0x600280B")]
	[Address(RVA = "0xD2DB94", Offset = "0xD2DB94", VA = "0xD2DB94")]
	public StretchQuadToViewFrustum()
	{
	}
}
