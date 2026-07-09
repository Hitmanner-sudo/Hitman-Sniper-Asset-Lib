using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200019F")]
public class FirstPersonCharacter : Character
{
	[Token(Token = "0x40008BF")]
	[FieldOffset(Offset = "0x88")]
	public string ArmsTransform;

	[Token(Token = "0x40008C0")]
	[FieldOffset(Offset = "0x90")]
	private Transform _arms;

	[Token(Token = "0x40008C1")]
	[FieldOffset(Offset = "0x98")]
	public string HeadTransform;

	[Token(Token = "0x40008C2")]
	[FieldOffset(Offset = "0xA0")]
	private Transform _head;

	[Token(Token = "0x40008C3")]
	[FieldOffset(Offset = "0xA8")]
	public string LensTransform;

	[Token(Token = "0x40008C4")]
	[FieldOffset(Offset = "0xB0")]
	private Transform _lens;

	[Token(Token = "0x40008C5")]
	[FieldOffset(Offset = "0xB8")]
	public string WeaponTransform;

	[Token(Token = "0x40008C6")]
	[FieldOffset(Offset = "0xC0")]
	private Transform _weapon;

	[Token(Token = "0x170001C3")]
	public Transform Arms
	{
		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x957EA0", Offset = "0x957EA0", VA = "0x957EA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001C4")]
	public Transform Head
	{
		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x957EA8", Offset = "0x957EA8", VA = "0x957EA8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001C5")]
	public Transform Lens
	{
		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x957EB0", Offset = "0x957EB0", VA = "0x957EB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001C6")]
	public Transform Weapon
	{
		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x957EB8", Offset = "0x957EB8", VA = "0x957EB8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001C7")]
	public override Vector3 EyePosition
	{
		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x958010", Offset = "0x958010", VA = "0x958010", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x170001C8")]
	public override Vector3 EyeDirection
	{
		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x95803C", Offset = "0x95803C", VA = "0x95803C", Slot = "15")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x6000B04")]
	[Address(RVA = "0x957EC0", Offset = "0x957EC0", VA = "0x957EC0", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000B05")]
	[Address(RVA = "0x957FBC", Offset = "0x957FBC", VA = "0x957FBC")]
	public void AttachWeapon(Weapon weapon)
	{
	}

	[Token(Token = "0x6000B08")]
	[Address(RVA = "0x958068", Offset = "0x958068", VA = "0x958068")]
	public FirstPersonCharacter()
	{
	}
}
