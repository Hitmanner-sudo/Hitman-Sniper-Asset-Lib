using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;

[Token(Token = "0x20008D6")]
[Scope]
public class GameScheduler : GameSingleton<GameScheduler>
{
	[Token(Token = "0x20008D7")]
	public enum UpdateType
	{
		[Token(Token = "0x400311A")]
		UPDATE = 0,
		[Token(Token = "0x400311B")]
		LATE_UPDATE = 1,
		[Token(Token = "0x400311C")]
		FIXED_UPDATE = 2,
		[Token(Token = "0x400311D")]
		COUNT = 3
	}

	[Token(Token = "0x20008D8")]
	public enum ExecutionOrder
	{
		[Token(Token = "0x400311F")]
		Inputs = 0,
		[Token(Token = "0x4003120")]
		Default = 1,
		[Token(Token = "0x4003121")]
		UI = 2,
		[Token(Token = "0x4003122")]
		Max = 3
	}

	[Token(Token = "0x20008D9")]
	public delegate void GameUpdateDelegate();

	[Token(Token = "0x4003112")]
	[FieldOffset(Offset = "0x0")]
	public static bool Paused;

	[Token(Token = "0x4003113")]
	[FieldOffset(Offset = "0x4")]
	private static int _currentUpdateType;

	[Token(Token = "0x4003114")]
	[FieldOffset(Offset = "0x8")]
	private static LinkedListNode<GameUpdateDelegate> _currentUpdateNode;

	[Token(Token = "0x4003115")]
	[FieldOffset(Offset = "0x10")]
	private static LinkedList<GameUpdateDelegate> _currentUpdateList;

	[Token(Token = "0x4003116")]
	[FieldOffset(Offset = "0x18")]
	private static readonly LinkedList<GameUpdateDelegate>[][] _updates;

	[Token(Token = "0x4003117")]
	[FieldOffset(Offset = "0x20")]
	private static bool _incCurrentUpdateNode;

	[Token(Token = "0x4003118")]
	private const int MAX_EXECUTION_ORDER = 3;

	[Token(Token = "0x60038DD")]
	[Address(RVA = "0xD9911C", Offset = "0xD9911C", VA = "0xD9911C")]
	public static void RegisterGameUpdate(GameUpdateDelegate update, ExecutionOrder order = ExecutionOrder.Default)
	{
	}

	[Token(Token = "0x60038DE")]
	[Address(RVA = "0xD990A8", Offset = "0xD990A8", VA = "0xD990A8")]
	public static void RegisterFixedGameUpdate(GameUpdateDelegate update, ExecutionOrder order = ExecutionOrder.Default)
	{
	}

	[Token(Token = "0x60038DF")]
	[Address(RVA = "0xD99190", Offset = "0xD99190", VA = "0xD99190")]
	public static void RegisterLateGameUpdate(GameUpdateDelegate update, ExecutionOrder order = ExecutionOrder.Default)
	{
	}

	[Token(Token = "0x60038E0")]
	[Address(RVA = "0xD99370", Offset = "0xD99370", VA = "0xD99370")]
	public static void UnregisterGameUpdate(GameUpdateDelegate update, ExecutionOrder order = ExecutionOrder.Default)
	{
	}

	[Token(Token = "0x60038E1")]
	[Address(RVA = "0xD992FC", Offset = "0xD992FC", VA = "0xD992FC")]
	public static void UnregisterFixedGameUpdate(GameUpdateDelegate update, ExecutionOrder order = ExecutionOrder.Default)
	{
	}

	[Token(Token = "0x60038E2")]
	[Address(RVA = "0xD993E4", Offset = "0xD993E4", VA = "0xD993E4")]
	public static void UnregisterLateGameUpdate(GameUpdateDelegate update, ExecutionOrder order = ExecutionOrder.Default)
	{
	}

	[Token(Token = "0x60038E3")]
	[Address(RVA = "0xD9A71C", Offset = "0xD9A71C", VA = "0xD9A71C")]
	private static void Register(UpdateType updateType, GameUpdateDelegate newDelegate, ExecutionOrder order)
	{
	}

	[Token(Token = "0x60038E4")]
	[Address(RVA = "0xD9A9A4", Offset = "0xD9A9A4", VA = "0xD9A9A4")]
	private static void Unregister(UpdateType updateType, GameUpdateDelegate newDelegate, ExecutionOrder order)
	{
	}

	[Token(Token = "0x60038E5")]
	[Address(RVA = "0xD9AC08", Offset = "0xD9AC08", VA = "0xD9AC08")]
	protected void FixedUpdate()
	{
	}

	[Token(Token = "0x60038E6")]
	[Address(RVA = "0xD9AE58", Offset = "0xD9AE58", VA = "0xD9AE58")]
	protected void Update()
	{
	}

	[Token(Token = "0x60038E7")]
	[Address(RVA = "0xD9AEE4", Offset = "0xD9AEE4", VA = "0xD9AEE4")]
	protected void LateUpdate()
	{
	}

	[Token(Token = "0x60038E8")]
	[Address(RVA = "0xD9AC98", Offset = "0xD9AC98", VA = "0xD9AC98")]
	private void Update(LinkedList<GameUpdateDelegate>[] updates)
	{
	}

	[Token(Token = "0x60038E9")]
	[Address(RVA = "0xD9AF74", Offset = "0xD9AF74", VA = "0xD9AF74")]
	private void Update(LinkedList<GameUpdateDelegate> updateDelegates)
	{
	}

	[Token(Token = "0x60038EA")]
	[Address(RVA = "0xD9B0F8", Offset = "0xD9B0F8", VA = "0xD9B0F8")]
	public GameScheduler()
	{
	}
}
