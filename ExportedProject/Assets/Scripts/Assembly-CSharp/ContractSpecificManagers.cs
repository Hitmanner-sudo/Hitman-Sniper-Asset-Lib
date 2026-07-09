using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200022B")]
public class ContractSpecificManagers : MonoBehaviour
{
	[Token(Token = "0x4000C30")]
	[FieldOffset(Offset = "0x18")]
	private readonly List<GameObject> _currentSpecificManagers;

	[Token(Token = "0x6000CEE")]
	[Address(RVA = "0xD7BB9C", Offset = "0xD7BB9C", VA = "0xD7BB9C")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6000CEF")]
	[Address(RVA = "0xD7BC18", Offset = "0xD7BC18", VA = "0xD7BC18")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x6000CF0")]
	[Address(RVA = "0xD7BCDC", Offset = "0xD7BCDC", VA = "0xD7BCDC")]
	private void OnContractChanged(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6000CF1")]
	[Address(RVA = "0xD7BEE8", Offset = "0xD7BEE8", VA = "0xD7BEE8")]
	public ContractSpecificManagers()
	{
	}
}
