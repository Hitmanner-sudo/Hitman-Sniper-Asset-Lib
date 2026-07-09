using Il2CppDummyDll;

[Token(Token = "0x20004D6")]
public class PlayerInputSystem : PlayerSystem
{
	[Token(Token = "0x40019DA")]
	[FieldOffset(Offset = "0x50")]
	public InputMapping InScopeInput;

	[Token(Token = "0x40019DB")]
	[FieldOffset(Offset = "0x58")]
	public InputMapping OutOfScopeInput;

	[Token(Token = "0x40019DC")]
	[FieldOffset(Offset = "0x60")]
	private InputMappingHandler _inputHandler;

	[Token(Token = "0x40019DD")]
	[FieldOffset(Offset = "0x68")]
	private GestureSystem _gestureSystem;

	[Token(Token = "0x17000489")]
	public InputMappingHandler InputHandler
	{
		[Token(Token = "0x6001D9C")]
		[Address(RVA = "0xB8A658", Offset = "0xB8A658", VA = "0xB8A658")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700048A")]
	public GestureSystem GestureSystem
	{
		[Token(Token = "0x6001D9D")]
		[Address(RVA = "0xB8A660", Offset = "0xB8A660", VA = "0xB8A660")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001D9E")]
	[Address(RVA = "0xB8A668", Offset = "0xB8A668", VA = "0xB8A668", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6001D9F")]
	[Address(RVA = "0xB8A74C", Offset = "0xB8A74C", VA = "0xB8A74C", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6001DA0")]
	[Address(RVA = "0xB8A808", Offset = "0xB8A808", VA = "0xB8A808")]
	public void RemoveGestureSystem()
	{
	}

	[Token(Token = "0x6001DA1")]
	[Address(RVA = "0xB8A740", Offset = "0xB8A740", VA = "0xB8A740")]
	public void AddGestureSystem()
	{
	}

	[Token(Token = "0x6001DA2")]
	[Address(RVA = "0xB8A814", Offset = "0xB8A814", VA = "0xB8A814")]
	public void PushOutOfScopeInput()
	{
	}

	[Token(Token = "0x6001DA3")]
	[Address(RVA = "0xB8A838", Offset = "0xB8A838", VA = "0xB8A838")]
	public void PopOutOfScopeInput()
	{
	}

	[Token(Token = "0x6001DA4")]
	[Address(RVA = "0xB8A85C", Offset = "0xB8A85C", VA = "0xB8A85C")]
	public void PushInScopeInput()
	{
	}

	[Token(Token = "0x6001DA5")]
	[Address(RVA = "0xB8A880", Offset = "0xB8A880", VA = "0xB8A880")]
	public void PopInScopeInput()
	{
	}

	[Token(Token = "0x6001DA6")]
	[Address(RVA = "0xB8A8A4", Offset = "0xB8A8A4", VA = "0xB8A8A4")]
	public PlayerInputSystem()
	{
	}
}
