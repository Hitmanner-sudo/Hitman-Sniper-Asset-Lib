using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200037D")]
public class BounceEffect : MonoBehaviour
{
	[Token(Token = "0x4001370")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ObjectsToSpawn;

	[Token(Token = "0x4001371")]
	[FieldOffset(Offset = "0x20")]
	public float Force;

	[Token(Token = "0x4001372")]
	[FieldOffset(Offset = "0x24")]
	public float SpawnDistance;

	[Token(Token = "0x600154A")]
	[Address(RVA = "0xA7F82C", Offset = "0xA7F82C", VA = "0xA7F82C")]
	private void Start()
	{
	}

	[Token(Token = "0x600154B")]
	[Address(RVA = "0xA7F9B8", Offset = "0xA7F9B8", VA = "0xA7F9B8")]
	public BounceEffect()
	{
	}
}
