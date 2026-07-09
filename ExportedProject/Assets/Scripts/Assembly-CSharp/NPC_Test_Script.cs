using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200086F")]
public class NPC_Test_Script : Controller
{
	[Token(Token = "0x4002F5B")]
	[FieldOffset(Offset = "0x50")]
	private Animator anim;

	[Token(Token = "0x4002F5C")]
	[FieldOffset(Offset = "0x58")]
	private int IdleState;

	[Token(Token = "0x4002F5D")]
	[FieldOffset(Offset = "0x5C")]
	private int NoReactionState;

	[Token(Token = "0x4002F5E")]
	[FieldOffset(Offset = "0x60")]
	private bool isRagdoll;

	[Token(Token = "0x4002F5F")]
	[FieldOffset(Offset = "0x64")]
	public float WalkSpeed;

	[Token(Token = "0x4002F60")]
	[FieldOffset(Offset = "0x68")]
	public float RunSpeed;

	[Token(Token = "0x4002F61")]
	[FieldOffset(Offset = "0x6C")]
	private float IdleBreakerStartTime;

	[Token(Token = "0x4002F62")]
	[FieldOffset(Offset = "0x70")]
	private bool InIdle;

	[Token(Token = "0x4002F63")]
	[FieldOffset(Offset = "0x74")]
	private float IdleBreakerMinTime;

	[Token(Token = "0x4002F64")]
	[FieldOffset(Offset = "0x78")]
	private float IdleBreakerDeltaTime;

	[Token(Token = "0x4002F65")]
	[FieldOffset(Offset = "0x7C")]
	private float IdleBreakerCount;

	[Token(Token = "0x4002F66")]
	[FieldOffset(Offset = "0x80")]
	private float ReactHurtIndex;

	[Token(Token = "0x4002F67")]
	[FieldOffset(Offset = "0x84")]
	private float ReactHurtCount;

	[Token(Token = "0x600373E")]
	[Address(RVA = "0xC55568", Offset = "0xC55568", VA = "0xC55568", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600373F")]
	[Address(RVA = "0xC55744", Offset = "0xC55744", VA = "0xC55744")]
	private void Update()
	{
	}

	[Token(Token = "0x6003740")]
	[Address(RVA = "0xC55E5C", Offset = "0xC55E5C", VA = "0xC55E5C")]
	public NPC_Test_Script()
	{
	}
}
