using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002F0")]
public class DestroyAfterTimer : MonoBehaviour
{
	[Token(Token = "0x4001028")]
	[FieldOffset(Offset = "0x18")]
	public float Duration;

	[Token(Token = "0x4001029")]
	[FieldOffset(Offset = "0x1C")]
	private float _destroyOnTime;

	[Token(Token = "0x6001211")]
	[Address(RVA = "0xC12BCC", Offset = "0xC12BCC", VA = "0xC12BCC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001212")]
	[Address(RVA = "0xC12C8C", Offset = "0xC12C8C", VA = "0xC12C8C")]
	private void Update()
	{
	}

	[Token(Token = "0x6001213")]
	[Address(RVA = "0xC12DB0", Offset = "0xC12DB0", VA = "0xC12DB0")]
	public DestroyAfterTimer()
	{
	}
}
