using System;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;
using Technology.Ads;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000496")]
public class DailyRewardsData : ISaveable
{
	[Token(Token = "0x40018CF")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B6BFC", Offset = "0x5B6BFC")]
	private long _lastStaminaRegen;

	[Token(Token = "0x40018D0")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B6C0C", Offset = "0x5B6C0C")]
	private int _maxAdsAvailable;

	[Token(Token = "0x40018D1")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B6C1C", Offset = "0x5B6C1C")]
	private long _timePerAdRegen;

	[Token(Token = "0x40018D2")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private LazyDailyRewardModel _rewardModel;

	[Token(Token = "0x17000445")]
	public TimeSpan TimePerAdRegen
	{
		[Token(Token = "0x6001BC5")]
		[Address(RVA = "0xADD1D4", Offset = "0xADD1D4", VA = "0xADD1D4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Token(Token = "0x17000446")]
	public int MaxAdsAvailable
	{
		[Token(Token = "0x6001BC6")]
		[Address(RVA = "0xADE8E8", Offset = "0xADE8E8", VA = "0xADE8E8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000447")]
	public DateTime NextAdRegen
	{
		[Token(Token = "0x6001BC7")]
		[Address(RVA = "0xADD048", Offset = "0xADD048", VA = "0xADD048")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x17000448")]
	public int CurrentAdsAvailable
	{
		[Token(Token = "0x6001BC8")]
		[Address(RVA = "0xADD13C", Offset = "0xADD13C", VA = "0xADD13C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000449")]
	public string AdStaminaItemId
	{
		[Token(Token = "0x6001BC9")]
		[Address(RVA = "0xADEC68", Offset = "0xADEC68", VA = "0xADEC68")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001BCA")]
	[Address(RVA = "0xADEE44", Offset = "0xADEE44", VA = "0xADEE44")]
	public void RegisterAdView()
	{
	}

	[Token(Token = "0x6001BCB")]
	[Address(RVA = "0xADE8F0", Offset = "0xADE8F0", VA = "0xADE8F0")]
	public void RefreshAdsHistory()
	{
	}

	[Token(Token = "0x6001BCC")]
	[Address(RVA = "0xADCDA4", Offset = "0xADCDA4", VA = "0xADCDA4")]
	public bool TryGetAd(out Ad ad)
	{
		return default(bool);
	}

	[Token(Token = "0x6001BCD")]
	[Address(RVA = "0xADF01C", Offset = "0xADF01C", VA = "0xADF01C")]
	public void DeserializeFromJson(JSONNode data)
	{
	}

	[Token(Token = "0x6001BCE")]
	[Address(RVA = "0xADF0AC", Offset = "0xADF0AC", VA = "0xADF0AC", Slot = "4")]
	private void Technology_002EISaveable_002EOnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6001BCF")]
	[Address(RVA = "0xADF134", Offset = "0xADF134", VA = "0xADF134", Slot = "5")]
	public JSONNode OnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x6001BD0")]
	[Address(RVA = "0xADF1AC", Offset = "0xADF1AC", VA = "0xADF1AC")]
	public DailyRewardsData()
	{
	}
}
