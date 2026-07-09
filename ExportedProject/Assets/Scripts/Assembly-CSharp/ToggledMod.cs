using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x200042F")]
public abstract class ToggledMod : ScriptableObject
{
	[Token(Token = "0x4001721")]
	[FieldOffset(Offset = "0x18")]
	public LazyTexture2D IconLazyUITexture;

	[Token(Token = "0x4001722")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected string _titleLOC;

	[Token(Token = "0x4001723")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected string _descriptionLOC;

	[Token(Token = "0x4001724")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int _normalCost;

	[Token(Token = "0x4001725")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private int _hardCost;

	[Token(Token = "0x4001726")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private int _expertCost;

	[Token(Token = "0x1700041A")]
	protected PlayerController _player
	{
		[Token(Token = "0x60019AA")]
		[Address(RVA = "0xAD051C", Offset = "0xAD051C", VA = "0xAD051C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700041B")]
	public virtual string GetDescription
	{
		[Token(Token = "0x60019AB")]
		[Address(RVA = "0xAD0568", Offset = "0xAD0568", VA = "0xAD0568", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700041C")]
	public virtual string GetTitle
	{
		[Token(Token = "0x60019AC")]
		[Address(RVA = "0xAD05D0", Offset = "0xAD05D0", VA = "0xAD05D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60019AD")]
	public abstract void Activate();

	[Token(Token = "0x60019AE")]
	[Address(RVA = "0xAD0638", Offset = "0xAD0638", VA = "0xAD0638")]
	public int GetCost()
	{
		return default(int);
	}

	[Token(Token = "0x60019AF")]
	[Address(RVA = "0xAD0738", Offset = "0xAD0738", VA = "0xAD0738")]
	protected ToggledMod()
	{
	}
}
