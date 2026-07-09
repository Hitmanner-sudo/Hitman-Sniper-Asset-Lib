using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001BF")]
public class PropsActivator : MonoBehaviour
{
	[Token(Token = "0x400097E")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "RangeAttribute", RVA = "0x5B2238", Offset = "0x5B2238")]
	[SerializeField]
	private float _activationChances;

	[Token(Token = "0x400097F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject[] _gameObject;

	[Token(Token = "0x4000980")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject[] _attachTo;

	[Token(Token = "0x4000981")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Vector3 _position;

	[Token(Token = "0x4000982")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private Vector3 _positionVariation;

	[Token(Token = "0x4000983")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Vector3 _rotationVariation;

	[Token(Token = "0x6000B90")]
	[Address(RVA = "0xB3B174", Offset = "0xB3B174", VA = "0xB3B174")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000B91")]
	[Address(RVA = "0xB3B178", Offset = "0xB3B178", VA = "0xB3B178")]
	private void ActiveGameObject()
	{
	}

	[Token(Token = "0x6000B92")]
	[Address(RVA = "0xB3B44C", Offset = "0xB3B44C", VA = "0xB3B44C")]
	public PropsActivator()
	{
	}
}
