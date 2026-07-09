using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008C2")]
public class FindAndAttachObject : MonoBehaviour
{
	[Token(Token = "0x400302D")]
	[FieldOffset(Offset = "0x18")]
	public string ObjectName;

	[Token(Token = "0x400302E")]
	[FieldOffset(Offset = "0x20")]
	public bool AlignWithPlayer;

	[Token(Token = "0x400302F")]
	[FieldOffset(Offset = "0x28")]
	private GameObject _objectToAttach;

	[Token(Token = "0x6003853")]
	[Address(RVA = "0x954774", Offset = "0x954774", VA = "0x954774")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003854")]
	[Address(RVA = "0x9547A0", Offset = "0x9547A0", VA = "0x9547A0")]
	private void Update()
	{
	}

	[Token(Token = "0x6003855")]
	[Address(RVA = "0x954A0C", Offset = "0x954A0C", VA = "0x954A0C")]
	public FindAndAttachObject()
	{
	}
}
