using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000416")]
public abstract class PerkReward : ScriptableObject
{
	[Token(Token = "0x40016E5")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected string _descriptionLOC;

	[Token(Token = "0x17000407")]
	public virtual string GetDescription
	{
		[Token(Token = "0x600193E")]
		[Address(RVA = "0x901954", Offset = "0x901954", VA = "0x901954", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600193F")]
	public abstract void Activate();

	[Token(Token = "0x6001940")]
	public abstract void Deactivate();

	[Token(Token = "0x6001941")]
	[Address(RVA = "0x9019BC", Offset = "0x9019BC", VA = "0x9019BC")]
	protected PerkReward()
	{
	}
}
