using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x20008E1")]
public class LazyGameObject : LazyReference<GameObject>
{
	[Token(Token = "0x6003910")]
	[Address(RVA = "0x996EE8", Offset = "0x996EE8", VA = "0x996EE8", Slot = "9")]
	protected override GameObject LoadValue(string path)
	{
		return null;
	}

	[Token(Token = "0x6003911")]
	[Address(RVA = "0x996F34", Offset = "0x996F34", VA = "0x996F34")]
	public LazyGameObject()
	{
	}
}
