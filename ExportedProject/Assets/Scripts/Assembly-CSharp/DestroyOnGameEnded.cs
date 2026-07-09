using System;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000231")]
public class DestroyOnGameEnded : GameMonoBehaviour
{
	[Token(Token = "0x4000C61")]
	[FieldOffset(Offset = "0x48")]
	public GameObject[] ObjectsToDestroy;

	[Token(Token = "0x6000D12")]
	[Address(RVA = "0xC13428", Offset = "0xC13428", VA = "0xC13428", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000D13")]
	[Address(RVA = "0xC134B0", Offset = "0xC134B0", VA = "0xC134B0", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000D14")]
	[Address(RVA = "0xC13580", Offset = "0xC13580", VA = "0xC13580")]
	private void OnLevelCleanup(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6000D15")]
	[Address(RVA = "0xC13634", Offset = "0xC13634", VA = "0xC13634")]
	public DestroyOnGameEnded()
	{
	}
}
