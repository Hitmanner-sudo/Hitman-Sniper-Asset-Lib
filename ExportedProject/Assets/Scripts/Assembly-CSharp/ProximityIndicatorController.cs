using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20007D6")]
public class ProximityIndicatorController : GameMonoBehaviour
{
	[Token(Token = "0x4002BCA")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private MeshRenderer _renderer;

	[Token(Token = "0x4002BCB")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float _additionalIndicatorHeight;

	[Token(Token = "0x4002BCC")]
	[FieldOffset(Offset = "0x58")]
	private Material _material;

	[Token(Token = "0x600336F")]
	[Address(RVA = "0xB3B4A8", Offset = "0xB3B4A8", VA = "0xB3B4A8", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6003370")]
	[Address(RVA = "0xB3B550", Offset = "0xB3B550", VA = "0xB3B550", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x6003371")]
	[Address(RVA = "0xB3B5D8", Offset = "0xB3B5D8", VA = "0xB3B5D8", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6003372")]
	[Address(RVA = "0xB3B64C", Offset = "0xB3B64C", VA = "0xB3B64C")]
	public ProximityIndicatorController()
	{
	}
}
