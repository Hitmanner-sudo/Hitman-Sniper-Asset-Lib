using Il2CppDummyDll;
using Technology;

[Token(Token = "0x20004E8")]
public abstract class PlayerSystem : GameMonoBehaviour
{
	[Token(Token = "0x4001A4D")]
	[FieldOffset(Offset = "0x48")]
	protected PlayerController _player;

	[Token(Token = "0x170004B1")]
	public PlayerController Player
	{
		[Token(Token = "0x6001E2B")]
		[Address(RVA = "0xABB1FC", Offset = "0xABB1FC", VA = "0xABB1FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001E2C")]
	[Address(RVA = "0xAB533C", Offset = "0xAB533C", VA = "0xAB533C", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6001E2D")]
	[Address(RVA = "0xAB8890", Offset = "0xAB8890", VA = "0xAB8890", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6001E2E")]
	[Address(RVA = "0xABB204", Offset = "0xABB204", VA = "0xABB204", Slot = "1")]
	~PlayerSystem()
	{
	}

	[Token(Token = "0x6001E2F")]
	[Address(RVA = "0xABB210", Offset = "0xABB210", VA = "0xABB210", Slot = "14")]
	public virtual void Execute()
	{
	}

	[Token(Token = "0x6001E30")]
	[Address(RVA = "0xABB214", Offset = "0xABB214", VA = "0xABB214", Slot = "15")]
	public virtual void ApplyToCharacter()
	{
	}

	[Token(Token = "0x6001E31")]
	[Address(RVA = "0xABB218", Offset = "0xABB218", VA = "0xABB218", Slot = "16")]
	public virtual void Reset()
	{
	}

	[Token(Token = "0x6001E32")]
	[Address(RVA = "0xAB57FC", Offset = "0xAB57FC", VA = "0xAB57FC")]
	protected PlayerSystem()
	{
	}
}
