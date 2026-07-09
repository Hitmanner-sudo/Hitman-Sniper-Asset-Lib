using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000424")]
public class ZombieReward : PerkReward
{
	[Token(Token = "0x2000425")]
	public enum ZombieType
	{
		[Token(Token = "0x4001707")]
		Normal = 0,
		[Token(Token = "0x4001708")]
		Tank = 1,
		[Token(Token = "0x4001709")]
		Screamer = 2,
		[Token(Token = "0x400170A")]
		Hunter = 3
	}

	[Token(Token = "0x4001702")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ZombieType _type;

	[Token(Token = "0x4001703")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private int _tokenBonus;

	[Token(Token = "0x4001704")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int _scoreBonus;

	[Token(Token = "0x4001705")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ModelContainer _modelContainer;

	[Token(Token = "0x17000411")]
	public ZombieType GetZombieType
	{
		[Token(Token = "0x6001971")]
		[Address(RVA = "0x884958", Offset = "0x884958", VA = "0x884958")]
		get
		{
			return default(ZombieType);
		}
	}

	[Token(Token = "0x17000412")]
	public int GetScoreBonus
	{
		[Token(Token = "0x6001972")]
		[Address(RVA = "0x884960", Offset = "0x884960", VA = "0x884960")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000413")]
	public override string GetDescription
	{
		[Token(Token = "0x6001973")]
		[Address(RVA = "0x884968", Offset = "0x884968", VA = "0x884968", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001974")]
	[Address(RVA = "0x884A3C", Offset = "0x884A3C", VA = "0x884A3C", Slot = "5")]
	public override void Activate()
	{
	}

	[Token(Token = "0x6001975")]
	[Address(RVA = "0x884BC8", Offset = "0x884BC8", VA = "0x884BC8", Slot = "6")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x6001976")]
	[Address(RVA = "0x884AA4", Offset = "0x884AA4", VA = "0x884AA4")]
	private string GetVariableName()
	{
		return null;
	}

	[Token(Token = "0x6001977")]
	[Address(RVA = "0x884C00", Offset = "0x884C00", VA = "0x884C00")]
	public ZombieReward()
	{
	}
}
