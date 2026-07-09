using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000947")]
public class AnimatedTiledTextureUV : MonoBehaviour
{
	[Token(Token = "0x4003250")]
	[FieldOffset(Offset = "0x18")]
	public int _uvTieX;

	[Token(Token = "0x4003251")]
	[FieldOffset(Offset = "0x1C")]
	public int _uvTieY;

	[Token(Token = "0x4003252")]
	[FieldOffset(Offset = "0x20")]
	public int _fps;

	[Token(Token = "0x4003253")]
	[FieldOffset(Offset = "0x24")]
	private float _iX;

	[Token(Token = "0x4003254")]
	[FieldOffset(Offset = "0x28")]
	private float _iY;

	[Token(Token = "0x4003255")]
	[FieldOffset(Offset = "0x2C")]
	private Vector2 _size;

	[Token(Token = "0x4003256")]
	[FieldOffset(Offset = "0x38")]
	private Renderer _myRenderer;

	[Token(Token = "0x4003257")]
	[FieldOffset(Offset = "0x40")]
	private int _lastIndex;

	[Token(Token = "0x6003ABA")]
	[Address(RVA = "0xD44964", Offset = "0xD44964", VA = "0xD44964")]
	private void Start()
	{
	}

	[Token(Token = "0x6003ABB")]
	[Address(RVA = "0xD44A28", Offset = "0xD44A28", VA = "0xD44A28")]
	private void Update()
	{
	}

	[Token(Token = "0x6003ABC")]
	[Address(RVA = "0xD44B58", Offset = "0xD44B58", VA = "0xD44B58")]
	public AnimatedTiledTextureUV()
	{
	}
}
