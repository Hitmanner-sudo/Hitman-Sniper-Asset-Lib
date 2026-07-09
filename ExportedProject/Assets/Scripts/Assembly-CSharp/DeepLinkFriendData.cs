using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;

[Token(Token = "0x2000497")]
public class DeepLinkFriendData : ISaveable
{
	[NonSerialized]
	[Token(Token = "0x40018D4")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B6C4C", Offset = "0x5B6C4C")]
	public bool AddedFriendFromConversionData;

	[Token(Token = "0x40018D5")]
	[FieldOffset(Offset = "0x20")]
	private readonly HashSet<string> _friends;

	[Token(Token = "0x40018D6")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B6C5C", Offset = "0x5B6C5C")]
	private readonly List<string> _friendsSaveData;

	[Token(Token = "0x1700044A")]
	public int Count
	{
		[Token(Token = "0x6001BD3")]
		[Address(RVA = "0xAEC614", Offset = "0xAEC614", VA = "0xAEC614")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1400006B")]
	public event Action FriendCountChanged
	{
		[Token(Token = "0x6001BD1")]
		[Address(RVA = "0xAEC4D4", Offset = "0xAEC4D4", VA = "0xAEC4D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618460", Offset = "0x618460")]
		add
		{
		}
		[Token(Token = "0x6001BD2")]
		[Address(RVA = "0xAEC574", Offset = "0xAEC574", VA = "0xAEC574")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618470", Offset = "0x618470")]
		remove
		{
		}
	}

	[Token(Token = "0x6001BD4")]
	[Address(RVA = "0xAEC660", Offset = "0xAEC660", VA = "0xAEC660")]
	public void Add(string friendSid)
	{
	}

	[Token(Token = "0x6001BD5")]
	[Address(RVA = "0xAEC798", Offset = "0xAEC798", VA = "0xAEC798")]
	public void Remove(string friendSid)
	{
	}

	[Token(Token = "0x6001BD6")]
	[Address(RVA = "0xAEC870", Offset = "0xAEC870", VA = "0xAEC870")]
	public bool Contains(string friendSid)
	{
		return default(bool);
	}

	[Token(Token = "0x6001BD7")]
	[Address(RVA = "0xAEC8D4", Offset = "0xAEC8D4", VA = "0xAEC8D4")]
	public HashSet<string> GetFriends()
	{
		return null;
	}

	[Token(Token = "0x6001BD8")]
	[Address(RVA = "0xAEC94C", Offset = "0xAEC94C", VA = "0xAEC94C", Slot = "4")]
	private void Technology_002EISaveable_002EOnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6001BD9")]
	[Address(RVA = "0xAECAA8", Offset = "0xAECAA8", VA = "0xAECAA8", Slot = "5")]
	private JSONNode Technology_002EISaveable_002EOnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x6001BDA")]
	[Address(RVA = "0xAECB90", Offset = "0xAECB90", VA = "0xAECB90")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x618480", Offset = "0x618480")]
	public void ForceAdd(string friendSid)
	{
	}

	[Token(Token = "0x6001BDB")]
	[Address(RVA = "0xAECC68", Offset = "0xAECC68", VA = "0xAECC68")]
	public DeepLinkFriendData()
	{
	}
}
