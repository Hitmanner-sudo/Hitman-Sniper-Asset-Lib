using System;
using Il2CppDummyDll;
using SimpleJSON;

[Token(Token = "0x20003C5")]
public class LootBoxDroppedRankProgression : LootBoxDroppedItem
{
	[Token(Token = "0x20003C6")]
	public class ProgressionAwardedEventArgs : EventArgs
	{
		[Token(Token = "0x4001559")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B4ED8", Offset = "0x5B4ED8")]
		private int _003CProgression_003Ek__BackingField;

		[Token(Token = "0x170003CA")]
		public int Progression
		{
			[Token(Token = "0x6001788")]
			[Address(RVA = "0x8C487C", Offset = "0x8C487C", VA = "0x8C487C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6174A4", Offset = "0x6174A4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6001789")]
			[Address(RVA = "0x8C4884", Offset = "0x8C4884", VA = "0x8C4884")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6174B4", Offset = "0x6174B4")]
			private set
			{
			}
		}

		[Token(Token = "0x600178A")]
		[Address(RVA = "0x8C488C", Offset = "0x8C488C", VA = "0x8C488C")]
		public ProgressionAwardedEventArgs(int progression)
		{
		}
	}

	[Token(Token = "0x4001558")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B4EC8", Offset = "0x5B4EC8")]
	private int _progression;

	[Token(Token = "0x170003C9")]
	public int Progression
	{
		[Token(Token = "0x600177F")]
		[Address(RVA = "0x9E3414", Offset = "0x9E3414", VA = "0x9E3414")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1400005A")]
	public static event EventHandler<ProgressionAwardedEventArgs> OnProgressionAwarded
	{
		[Token(Token = "0x600177D")]
		[Address(RVA = "0x9E329C", Offset = "0x9E329C", VA = "0x9E329C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617484", Offset = "0x617484")]
		add
		{
		}
		[Token(Token = "0x600177E")]
		[Address(RVA = "0x9E3358", Offset = "0x9E3358", VA = "0x9E3358")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617494", Offset = "0x617494")]
		remove
		{
		}
	}

	[Token(Token = "0x6001780")]
	[Address(RVA = "0x9E341C", Offset = "0x9E341C", VA = "0x9E341C")]
	public LootBoxDroppedRankProgression(int progression)
	{
	}

	[Token(Token = "0x6001781")]
	[Address(RVA = "0x9E3448", Offset = "0x9E3448", VA = "0x9E3448")]
	private LootBoxDroppedRankProgression()
	{
	}

	[Token(Token = "0x6001782")]
	[Address(RVA = "0x9E3450", Offset = "0x9E3450", VA = "0x9E3450", Slot = "7")]
	public override void Claim()
	{
	}

	[Token(Token = "0x6001783")]
	[Address(RVA = "0x9E34FC", Offset = "0x9E34FC", VA = "0x9E34FC", Slot = "8")]
	public override bool Merge(LootBoxDroppedItem other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001784")]
	[Address(RVA = "0x9E35A4", Offset = "0x9E35A4", VA = "0x9E35A4", Slot = "9")]
	public override void OnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6001785")]
	[Address(RVA = "0x9E362C", Offset = "0x9E362C", VA = "0x9E362C", Slot = "10")]
	public override JSONNode OnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x6001786")]
	[Address(RVA = "0x9E36A4", Offset = "0x9E36A4", VA = "0x9E36A4", Slot = "11")]
	public override string GetAnalyticsName()
	{
		return null;
	}

	[Token(Token = "0x6001787")]
	[Address(RVA = "0x9E36E8", Offset = "0x9E36E8", VA = "0x9E36E8", Slot = "12")]
	public override int GetAnalyticsQuantity()
	{
		return default(int);
	}
}
