using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001A2")]
public class GameObjectActivator : MonoBehaviour
{
	[Token(Token = "0x40008D2")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x5B20BC", Offset = "0x5B20BC")]
	private float _activationChances;

	[Token(Token = "0x40008D3")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject[] _gameObjectsToActivate;

	[Token(Token = "0x6000B17")]
	[Address(RVA = "0xD995AC", Offset = "0xD995AC", VA = "0xD995AC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000B18")]
	[Address(RVA = "0xD995D8", Offset = "0xD995D8", VA = "0xD995D8")]
	public void DoActivation()
	{
	}

	[Token(Token = "0x6000B19")]
	[Address(RVA = "0xD99680", Offset = "0xD99680", VA = "0xD99680")]
	public GameObjectActivator()
	{
	}
}
