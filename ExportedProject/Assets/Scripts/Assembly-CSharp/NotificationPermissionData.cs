using System;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;
using UnityEngine;

[Token(Token = "0x20004AC")]
public class NotificationPermissionData : ISaveable
{
	[NonSerialized]
	[Token(Token = "0x400191C")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B6ED4", Offset = "0x5B6ED4")]
	public bool HasSeenPopup;

	[NonSerialized]
	[Token(Token = "0x400191D")]
	[FieldOffset(Offset = "0x11")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B6EE4", Offset = "0x5B6EE4")]
	public bool HasAcceptedPopup;

	[Token(Token = "0x400191E")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B6EF4", Offset = "0x5B6EF4")]
	private long _popupLastShownBinary;

	[Token(Token = "0x400191F")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B6F04", Offset = "0x5B6F04")]
	[SerializeField]
	private int _missionIdToShow;

	[Token(Token = "0x4001920")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B6F3C", Offset = "0x5B6F3C")]
	private long _timeBetweenShowPopupsTicks;

	[Token(Token = "0x1700046B")]
	public DateTime PopupLastShown
	{
		[Token(Token = "0x6001C69")]
		[Address(RVA = "0x9E5748", Offset = "0x9E5748", VA = "0x9E5748")]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x6001C6A")]
		[Address(RVA = "0x9E57B0", Offset = "0x9E57B0", VA = "0x9E57B0")]
		set
		{
		}
	}

	[Token(Token = "0x1700046C")]
	public int MissionIdToShow
	{
		[Token(Token = "0x6001C6B")]
		[Address(RVA = "0x9E5854", Offset = "0x9E5854", VA = "0x9E5854")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700046D")]
	public bool CanShowPopup
	{
		[Token(Token = "0x6001C6C")]
		[Address(RVA = "0x9E585C", Offset = "0x9E585C", VA = "0x9E585C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700046E")]
	private TimeSpan TimeBetweenShowPopups
	{
		[Token(Token = "0x6001C6D")]
		[Address(RVA = "0x9E5964", Offset = "0x9E5964", VA = "0x9E5964")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Token(Token = "0x6001C6E")]
	[Address(RVA = "0x9E59CC", Offset = "0x9E59CC", VA = "0x9E59CC", Slot = "4")]
	public void OnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6001C6F")]
	[Address(RVA = "0x9E5A54", Offset = "0x9E5A54", VA = "0x9E5A54", Slot = "5")]
	public JSONNode OnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x6001C70")]
	[Address(RVA = "0x9E5ACC", Offset = "0x9E5ACC", VA = "0x9E5ACC")]
	public NotificationPermissionData()
	{
	}
}
