using System;
using Il2CppDummyDll;

[Token(Token = "0x20003AE")]
public class WeaponMod : AttachmentsUnlockable
{
	[Token(Token = "0x40014FD")]
	[FieldOffset(Offset = "0x60")]
	public AttachmentInfo AttachmentUnlock;

	[Token(Token = "0x40014FE")]
	[FieldOffset(Offset = "0x68")]
	protected PlayerController _player;

	[Token(Token = "0x170003AC")]
	public override string Name
	{
		[Token(Token = "0x60016D6")]
		[Address(RVA = "0x98B960", Offset = "0x98B960", VA = "0x98B960", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003AD")]
	public override string Description
	{
		[Token(Token = "0x60016D7")]
		[Address(RVA = "0x98B9C8", Offset = "0x98B9C8", VA = "0x98B9C8", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60016D2")]
	[Address(RVA = "0x98B6D4", Offset = "0x98B6D4", VA = "0x98B6D4", Slot = "8")]
	public override void Equip(PlayerController player)
	{
	}

	[Token(Token = "0x60016D3")]
	[Address(RVA = "0x98B770", Offset = "0x98B770", VA = "0x98B770", Slot = "9")]
	public override void UnEquip()
	{
	}

	[Token(Token = "0x60016D4")]
	[Address(RVA = "0x98B848", Offset = "0x98B848", VA = "0x98B848", Slot = "10")]
	protected virtual void OnWeaponAttached(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x60016D5")]
	[Address(RVA = "0x98B93C", Offset = "0x98B93C", VA = "0x98B93C", Slot = "7")]
	public override void Unlock(bool showNewFeedback = true)
	{
	}

	[Token(Token = "0x60016D8")]
	[Address(RVA = "0x98BA30", Offset = "0x98BA30", VA = "0x98BA30")]
	public WeaponMod()
	{
	}
}
