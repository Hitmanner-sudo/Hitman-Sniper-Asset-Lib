using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002EB")]
public class InputMappingHandler
{
	[Token(Token = "0x4001017")]
	[FieldOffset(Offset = "0x10")]
	private readonly List<InputMapping> _mappings;

	[Token(Token = "0x4001018")]
	[FieldOffset(Offset = "0x18")]
	private GameObject _owner;

	[Token(Token = "0x170002A5")]
	public GameObject Owner
	{
		[Token(Token = "0x60011F3")]
		[Address(RVA = "0xB13150", Offset = "0xB13150", VA = "0xB13150")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60011F4")]
	[Address(RVA = "0xB13158", Offset = "0xB13158", VA = "0xB13158")]
	public InputMappingHandler(GameObject owner)
	{
	}

	[Token(Token = "0x60011F5")]
	[Address(RVA = "0xB131E4", Offset = "0xB131E4", VA = "0xB131E4")]
	public void PushMapping(InputMapping mapping)
	{
	}

	[Token(Token = "0x60011F6")]
	[Address(RVA = "0xB132B8", Offset = "0xB132B8", VA = "0xB132B8")]
	public void PopMapping(InputMapping mapping)
	{
	}

	[Token(Token = "0x60011F7")]
	[Address(RVA = "0xB133F8", Offset = "0xB133F8", VA = "0xB133F8")]
	public void ClearMappings()
	{
	}
}
