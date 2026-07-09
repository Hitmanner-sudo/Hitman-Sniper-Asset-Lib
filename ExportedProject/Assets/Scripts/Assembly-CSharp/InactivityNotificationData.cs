using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x200024E")]
public class InactivityNotificationData : LocalNotificationData
{
	[Token(Token = "0x4000CCE")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string[] _body;

	[Token(Token = "0x4000CCF")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private SerializableTimeSpan _delay;

	[Token(Token = "0x4000CD0")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private SerializableTimeSpan _promotionActiveDuration;

	[Token(Token = "0x4000CD1")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private MetaOfferReference[] _promotions;

	[Token(Token = "0x1700023A")]
	public override string Body
	{
		[Token(Token = "0x6000DEA")]
		[Address(RVA = "0xB0A6E4", Offset = "0xB0A6E4", VA = "0xB0A6E4", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700023B")]
	public TimeSpan Delay
	{
		[Token(Token = "0x6000DEB")]
		[Address(RVA = "0xB0A738", Offset = "0xB0A738", VA = "0xB0A738")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Token(Token = "0x1700023C")]
	public TimeSpan PromotionActiveDuration
	{
		[Token(Token = "0x6000DEC")]
		[Address(RVA = "0xB0A744", Offset = "0xB0A744", VA = "0xB0A744")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Token(Token = "0x1700023D")]
	public MetaOfferReference[] Promotions
	{
		[Token(Token = "0x6000DED")]
		[Address(RVA = "0xB0A750", Offset = "0xB0A750", VA = "0xB0A750")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000DEE")]
	[Address(RVA = "0xB0A758", Offset = "0xB0A758", VA = "0xB0A758")]
	public InactivityNotificationData()
	{
	}
}
