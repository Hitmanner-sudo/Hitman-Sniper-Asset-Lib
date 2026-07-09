using System;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;
using UnityEngine;

[Serializable]
[Token(Token = "0x20004A5")]
public class HackerPreventionData : ISaveable
{
	[Token(Token = "0x4001908")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B6D8C", Offset = "0x5B6D8C")]
	public int ScoreThreshold;

	[Token(Token = "0x4001909")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B6D9C", Offset = "0x5B6D9C")]
	private int _timeThresholdSeconds;

	[Token(Token = "0x17000465")]
	public TimeSpan TimeThreshold
	{
		[Token(Token = "0x6001C45")]
		[Address(RVA = "0xA08B3C", Offset = "0xA08B3C", VA = "0xA08B3C")]
		get
		{
			return default(TimeSpan);
		}
		[Token(Token = "0x6001C46")]
		[Address(RVA = "0xA08BA4", Offset = "0xA08BA4", VA = "0xA08BA4")]
		set
		{
		}
	}

	[Token(Token = "0x6001C47")]
	[Address(RVA = "0xA08BEC", Offset = "0xA08BEC", VA = "0xA08BEC", Slot = "4")]
	private void Technology_002EISaveable_002EOnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6001C48")]
	[Address(RVA = "0xA08C74", Offset = "0xA08C74", VA = "0xA08C74", Slot = "5")]
	private JSONNode Technology_002EISaveable_002EOnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x6001C49")]
	[Address(RVA = "0xA08CEC", Offset = "0xA08CEC", VA = "0xA08CEC")]
	public HackerPreventionData()
	{
	}
}
