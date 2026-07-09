using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000329")]
public class InventoryItem : Interaction
{
	[NonSerialized]
	[Token(Token = "0x4001185")]
	[FieldOffset(Offset = "0x70")]
	private Inventory _inventory;

	[NonSerialized]
	[Token(Token = "0x4001186")]
	[FieldOffset(Offset = "0x78")]
	public bool Equipped;

	[Token(Token = "0x4001187")]
	[FieldOffset(Offset = "0x7C")]
	public Inventory.BoneID EquippedBoneID;

	[Token(Token = "0x4001188")]
	[FieldOffset(Offset = "0x80")]
	public Inventory.BoneID UnequippedBoneID;

	[Token(Token = "0x4001189")]
	[FieldOffset(Offset = "0x84")]
	public bool DropOnReact;

	[Token(Token = "0x400118A")]
	[FieldOffset(Offset = "0x88")]
	public AnimationConfig.IdleType PickUpAnimation;

	[Token(Token = "0x400118B")]
	[FieldOffset(Offset = "0x8C")]
	public int PropID;

	[Token(Token = "0x400118C")]
	[FieldOffset(Offset = "0x90")]
	private Breakable _breakable;

	[Token(Token = "0x400118D")]
	[FieldOffset(Offset = "0x98")]
	private GameTimer _interactionTimer;

	[Token(Token = "0x170002D2")]
	public Inventory Inventory
	{
		[Token(Token = "0x6001345")]
		[Address(RVA = "0xB1B220", Offset = "0xB1B220", VA = "0xB1B220")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001346")]
		[Address(RVA = "0xB18164", Offset = "0xB18164", VA = "0xB18164")]
		set
		{
		}
	}

	[Token(Token = "0x170002D3")]
	public bool Broken
	{
		[Token(Token = "0x6001347")]
		[Address(RVA = "0xB1B228", Offset = "0xB1B228", VA = "0xB1B228")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002D4")]
	public override float UserFacingLimit
	{
		[Token(Token = "0x600134C")]
		[Address(RVA = "0xB1B648", Offset = "0xB1B648", VA = "0xB1B648", Slot = "15")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6001348")]
	[Address(RVA = "0xB1B2B8", Offset = "0xB1B2B8", VA = "0xB1B2B8", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6001349")]
	[Address(RVA = "0xB1B350", Offset = "0xB1B350", VA = "0xB1B350", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600134A")]
	[Address(RVA = "0xB1B478", Offset = "0xB1B478", VA = "0xB1B478", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600134B")]
	[Address(RVA = "0xB1B620", Offset = "0xB1B620", VA = "0xB1B620")]
	private void OnBroken(object sender, Breakable.BreakEvent args)
	{
	}

	[Token(Token = "0x600134D")]
	[Address(RVA = "0xB1B6B0", Offset = "0xB1B6B0", VA = "0xB1B6B0", Slot = "19")]
	public override bool CanInteract(ThirdPersonCharacter agent)
	{
		return default(bool);
	}

	[Token(Token = "0x600134E")]
	[Address(RVA = "0xB1B6FC", Offset = "0xB1B6FC", VA = "0xB1B6FC", Slot = "20")]
	public override void StartInteracting(ThirdPersonCharacter character)
	{
	}

	[Token(Token = "0x600134F")]
	[Address(RVA = "0xB1B838", Offset = "0xB1B838", VA = "0xB1B838", Slot = "21")]
	public override bool UpdateInteracting(ThirdPersonCharacter character)
	{
		return default(bool);
	}

	[Token(Token = "0x6001350")]
	[Address(RVA = "0xB1B8A4", Offset = "0xB1B8A4", VA = "0xB1B8A4", Slot = "22")]
	public override void StopInteracting(ThirdPersonCharacter character)
	{
	}

	[Token(Token = "0x6001351")]
	[Address(RVA = "0xB1B948", Offset = "0xB1B948", VA = "0xB1B948")]
	private void OnAnimEvent(GameObject sender, AnimationEvent ev)
	{
	}

	[Token(Token = "0x6001352")]
	[Address(RVA = "0xB1B9E8", Offset = "0xB1B9E8", VA = "0xB1B9E8")]
	public InventoryItem()
	{
	}
}
