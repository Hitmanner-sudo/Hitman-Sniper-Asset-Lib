using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x200012F")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x5924FC", Offset = "0x5924FC")]
public abstract class AISensor : GameMonoBehaviour
{
	[Token(Token = "0x4000694")]
	[FieldOffset(Offset = "0x47")]
	public bool CanDetectSound;

	[Token(Token = "0x4000695")]
	[FieldOffset(Offset = "0x48")]
	public bool CanDetectVision;

	[Token(Token = "0x4000696")]
	[FieldOffset(Offset = "0x49")]
	public bool IgnoreDeadBodies;

	[Token(Token = "0x4000697")]
	[FieldOffset(Offset = "0x4A")]
	public bool IgnoreRicochet;

	[NonSerialized]
	[Token(Token = "0x4000698")]
	[FieldOffset(Offset = "0x50")]
	public List<AudioVolume> AudioVolumes;

	[NonSerialized]
	[Token(Token = "0x4000699")]
	[FieldOffset(Offset = "0x58")]
	public Memory Memory;

	[Token(Token = "0x17000161")]
	public virtual Priority Priority
	{
		[Token(Token = "0x6000835")]
		[Address(RVA = "0xA96614", Offset = "0xA96614", VA = "0xA96614", Slot = "14")]
		get
		{
			return default(Priority);
		}
	}

	[Token(Token = "0x17000162")]
	public virtual Vector3 EarPosition
	{
		[Token(Token = "0x6000836")]
		[Address(RVA = "0xA9661C", Offset = "0xA9661C", VA = "0xA9661C", Slot = "15")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x6000837")]
	[Address(RVA = "0xA96638", Offset = "0xA96638", VA = "0xA96638", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000838")]
	[Address(RVA = "0xA96694", Offset = "0xA96694", VA = "0xA96694", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000839")]
	[Address(RVA = "0xA9674C", Offset = "0xA9674C", VA = "0xA9674C", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600083A")]
	[Address(RVA = "0xA96864", Offset = "0xA96864", VA = "0xA96864")]
	public void Handle(AIMemento memento)
	{
	}

	[Token(Token = "0x600083B")]
	[Address(RVA = "0xA9694C", Offset = "0xA9694C", VA = "0xA9694C", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600083C")]
	[Address(RVA = "0xA96A5C", Offset = "0xA96A5C", VA = "0xA96A5C", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600083D")]
	[Address(RVA = "0xA96BAC", Offset = "0xA96BAC", VA = "0xA96BAC")]
	protected AISensor()
	{
	}
}
