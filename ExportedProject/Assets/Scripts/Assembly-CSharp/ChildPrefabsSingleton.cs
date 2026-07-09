using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000853")]
public class ChildPrefabsSingleton : MonoBehaviour
{
	[Token(Token = "0x4002EF3")]
	[FieldOffset(Offset = "0x0")]
	private static ChildPrefabsSingleton _instance;

	[Token(Token = "0x4002EF4")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] Children;

	[Token(Token = "0x6003653")]
	[Address(RVA = "0xB00870", Offset = "0xB00870", VA = "0xB00870")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003654")]
	[Address(RVA = "0xB00B70", Offset = "0xB00B70", VA = "0xB00B70")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6003655")]
	[Address(RVA = "0xB00C50", Offset = "0xB00C50", VA = "0xB00C50")]
	public ChildPrefabsSingleton()
	{
	}
}
