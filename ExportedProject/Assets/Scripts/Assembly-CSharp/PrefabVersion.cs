using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008F4")]
public class PrefabVersion : MonoBehaviour
{
	[Token(Token = "0x400314A")]
	[FieldOffset(Offset = "0x18")]
	public string ID;

	[Token(Token = "0x400314B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int _version;

	[Token(Token = "0x400314C")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private bool _autoReplace;

	[Token(Token = "0x6003957")]
	[Address(RVA = "0xB38684", Offset = "0xB38684", VA = "0xB38684")]
	private void Start()
	{
	}

	[Token(Token = "0x6003958")]
	[Address(RVA = "0xB38974", Offset = "0xB38974", VA = "0xB38974")]
	public PrefabVersion()
	{
	}
}
