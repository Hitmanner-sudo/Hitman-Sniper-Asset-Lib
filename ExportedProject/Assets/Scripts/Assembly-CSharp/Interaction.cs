using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000301")]
public class Interaction : GameMonoBehaviour
{
	[Token(Token = "0x4001097")]
	[FieldOffset(Offset = "0x48")]
	public float MaxInteractionDistance;

	[Token(Token = "0x4001098")]
	[FieldOffset(Offset = "0x4C")]
	public float IdealInteractionDistance;

	[Token(Token = "0x4001099")]
	[FieldOffset(Offset = "0x50")]
	public int MaxNumberOfUsers;

	[Token(Token = "0x400109A")]
	[FieldOffset(Offset = "0x58")]
	protected List<ThirdPersonCharacter> _users;

	[Token(Token = "0x400109B")]
	[FieldOffset(Offset = "0x60")]
	protected List<ThirdPersonCharacter> _incomingUsers;

	[Token(Token = "0x400109C")]
	[FieldOffset(Offset = "0x68")]
	public bool StopToInteract;

	[Token(Token = "0x170002AD")]
	protected virtual Vector3 Position
	{
		[Token(Token = "0x6001263")]
		[Address(RVA = "0xB16F14", Offset = "0xB16F14", VA = "0xB16F14", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x170002AE")]
	public virtual float UserFacingLimit
	{
		[Token(Token = "0x6001264")]
		[Address(RVA = "0xB16F30", Offset = "0xB16F30", VA = "0xB16F30", Slot = "15")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6001265")]
	[Address(RVA = "0xB16F38", Offset = "0xB16F38", VA = "0xB16F38", Slot = "16")]
	public virtual void GetInteractPosition(ThirdPersonCharacter character, out Vector3 position, out Vector3 direction)
	{
	}

	[Token(Token = "0x6001266")]
	[Address(RVA = "0xB17038", Offset = "0xB17038", VA = "0xB17038", Slot = "17")]
	protected virtual bool CharacterIsWithinInteractionAngle(ThirdPersonCharacter character)
	{
		return default(bool);
	}

	[Token(Token = "0x6001267")]
	[Address(RVA = "0xB17118", Offset = "0xB17118", VA = "0xB17118", Slot = "18")]
	public virtual bool IsAvailable(ThirdPersonCharacter character)
	{
		return default(bool);
	}

	[Token(Token = "0x6001268")]
	[Address(RVA = "0xB171D4", Offset = "0xB171D4", VA = "0xB171D4", Slot = "19")]
	public virtual bool CanInteract(ThirdPersonCharacter character)
	{
		return default(bool);
	}

	[Token(Token = "0x6001269")]
	[Address(RVA = "0xB172E8", Offset = "0xB172E8", VA = "0xB172E8")]
	public bool RegisterIncoming(ThirdPersonCharacter character)
	{
		return default(bool);
	}

	[Token(Token = "0x600126A")]
	[Address(RVA = "0xB17388", Offset = "0xB17388", VA = "0xB17388")]
	public void UnregisterIncoming(ThirdPersonCharacter character)
	{
	}

	[Token(Token = "0x600126B")]
	[Address(RVA = "0xB173EC", Offset = "0xB173EC", VA = "0xB173EC", Slot = "20")]
	public virtual void StartInteracting(ThirdPersonCharacter character)
	{
	}

	[Token(Token = "0x600126C")]
	[Address(RVA = "0xB1745C", Offset = "0xB1745C", VA = "0xB1745C", Slot = "21")]
	public virtual bool UpdateInteracting(ThirdPersonCharacter character)
	{
		return default(bool);
	}

	[Token(Token = "0x600126D")]
	[Address(RVA = "0xB17464", Offset = "0xB17464", VA = "0xB17464", Slot = "22")]
	public virtual void StopInteracting(ThirdPersonCharacter character)
	{
	}

	[Token(Token = "0x600126E")]
	[Address(RVA = "0xB174C8", Offset = "0xB174C8", VA = "0xB174C8")]
	public Interaction()
	{
	}
}
