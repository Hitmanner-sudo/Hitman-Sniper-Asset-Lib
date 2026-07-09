using System;
using Il2CppDummyDll;

[Token(Token = "0x2000482")]
public abstract class PlayerFSM : FSM
{
	[Token(Token = "0x2000483")]
	public abstract class BaseState : FSMState
	{
		[Token(Token = "0x40018AD")]
		[FieldOffset(Offset = "0x18")]
		protected PlayerController _player;

		[Token(Token = "0x6001B67")]
		[Address(RVA = "0x8D3A24", Offset = "0x8D3A24", VA = "0x8D3A24", Slot = "4")]
		public override void Init(FSM parentFSM)
		{
		}

		[Token(Token = "0x6001B68")]
		[Address(RVA = "0x8D3ABC", Offset = "0x8D3ABC", VA = "0x8D3ABC", Slot = "7")]
		public override void Exit()
		{
		}

		[Token(Token = "0x6001B69")]
		[Address(RVA = "0x8D3AC4", Offset = "0x8D3AC4", VA = "0x8D3AC4", Slot = "1")]
		~BaseState()
		{
		}

		[Token(Token = "0x6001B6A")]
		[Address(RVA = "0x8D3AD0", Offset = "0x8D3AD0", VA = "0x8D3AD0")]
		protected BaseState()
		{
		}
	}

	[Token(Token = "0x40018AC")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B6BDC", Offset = "0x5B6BDC")]
	private PlayerController _003CPlayer_003Ek__BackingField;

	[Token(Token = "0x17000444")]
	public PlayerController Player
	{
		[Token(Token = "0x6001B64")]
		[Address(RVA = "0xB8974C", Offset = "0xB8974C", VA = "0xB8974C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617CB4", Offset = "0x617CB4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B65")]
		[Address(RVA = "0xB89754", Offset = "0xB89754", VA = "0xB89754")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617CC4", Offset = "0x617CC4")]
		private set
		{
		}
	}

	[Token(Token = "0x6001B66")]
	[Address(RVA = "0xB8975C", Offset = "0xB8975C", VA = "0xB8975C")]
	public PlayerFSM(Type initialState, PlayerController player)
	{
	}
}
