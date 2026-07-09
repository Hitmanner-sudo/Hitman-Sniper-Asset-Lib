using System;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000414")]
public abstract class Perk : ScriptableObject, ISaveable
{
	[Token(Token = "0x40016D8")]
	[FieldOffset(Offset = "0x18")]
	public PerkReward PerkReward;

	[Token(Token = "0x40016D9")]
	[FieldOffset(Offset = "0x20")]
	public LazyTexture2D IconLazyUITexture;

	[Token(Token = "0x40016DA")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected int PurchasePrice;

	[Token(Token = "0x40016DB")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected string _titleLOC;

	[Token(Token = "0x40016DC")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected string _descriptionLOC;

	[Token(Token = "0x40016DD")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	protected int _maxProgress;

	[Token(Token = "0x40016DE")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	protected int _version;

	[NonSerialized]
	[Token(Token = "0x40016DF")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B5A34", Offset = "0x5B5A34")]
	public PerkSaveData SaveData;

	[Token(Token = "0x40016E0")]
	[FieldOffset(Offset = "0x50")]
	protected bool _started;

	[Token(Token = "0x17000401")]
	public virtual string GetTitle
	{
		[Token(Token = "0x6001927")]
		[Address(RVA = "0x8FD604", Offset = "0x8FD604", VA = "0x8FD604", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000402")]
	public virtual string GetDescription
	{
		[Token(Token = "0x6001928")]
		[Address(RVA = "0x8FD6B4", Offset = "0x8FD6B4", VA = "0x8FD6B4", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000403")]
	public string GetTitleKey
	{
		[Token(Token = "0x6001929")]
		[Address(RVA = "0x8FD764", Offset = "0x8FD764", VA = "0x8FD764")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000404")]
	public int GetVersion
	{
		[Token(Token = "0x600192A")]
		[Address(RVA = "0x8FD76C", Offset = "0x8FD76C", VA = "0x8FD76C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000405")]
	public virtual int GetMaxProgress
	{
		[Token(Token = "0x600192B")]
		[Address(RVA = "0x8FD774", Offset = "0x8FD774", VA = "0x8FD774", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000406")]
	public virtual int GetPurchasePrice
	{
		[Token(Token = "0x600192C")]
		[Address(RVA = "0x8FD77C", Offset = "0x8FD77C", VA = "0x8FD77C", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600192D")]
	[Address(RVA = "0x8FD784", Offset = "0x8FD784", VA = "0x8FD784")]
	public void DoFirstInit()
	{
	}

	[Token(Token = "0x600192E")]
	[Address(RVA = "0x8FD7E8", Offset = "0x8FD7E8", VA = "0x8FD7E8")]
	public void Start()
	{
	}

	[Token(Token = "0x600192F")]
	[Address(RVA = "0x8FD824", Offset = "0x8FD824", VA = "0x8FD824")]
	public void Stop()
	{
	}

	[Token(Token = "0x6001930")]
	public abstract void DoStart();

	[Token(Token = "0x6001931")]
	public abstract void DoStop();

	[Token(Token = "0x6001932")]
	[Address(RVA = "0x8FD85C", Offset = "0x8FD85C", VA = "0x8FD85C")]
	public void SetProgress(int value)
	{
	}

	[Token(Token = "0x6001933")]
	[Address(RVA = "0x8FD888", Offset = "0x8FD888", VA = "0x8FD888")]
	public void IncreaseProgress(int increaseValue)
	{
	}

	[Token(Token = "0x6001934")]
	[Address(RVA = "0x8FDB20", Offset = "0x8FDB20", VA = "0x8FDB20", Slot = "12")]
	public virtual void EnableReward()
	{
	}

	[Token(Token = "0x6001935")]
	[Address(RVA = "0x8FDC4C", Offset = "0x8FDC4C", VA = "0x8FDC4C", Slot = "13")]
	public virtual void DisableReward()
	{
	}

	[Token(Token = "0x6001936")]
	[Address(RVA = "0x8FDDF8", Offset = "0x8FDDF8", VA = "0x8FDDF8")]
	public void Claim()
	{
	}

	[Token(Token = "0x6001937")]
	[Address(RVA = "0x8FDF90", Offset = "0x8FDF90", VA = "0x8FDF90", Slot = "14")]
	public virtual void OnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6001938")]
	[Address(RVA = "0x8FE018", Offset = "0x8FE018", VA = "0x8FE018", Slot = "15")]
	public virtual JSONNode OnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x6001939")]
	[Address(RVA = "0x8FE090", Offset = "0x8FE090", VA = "0x8FE090")]
	protected Perk()
	{
	}
}
