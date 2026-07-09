using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F74")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D1C8", Offset = "0x59D1C8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D1C8", Offset = "0x59D1C8")]
	public class DrawDebugLine : FsmStateAction
	{
		[Token(Token = "0x40048E6")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0B38", Offset = "0x5D0B38")]
		public FsmGameObject fromObject;

		[Token(Token = "0x40048E7")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0B70", Offset = "0x5D0B70")]
		public FsmVector3 fromPosition;

		[Token(Token = "0x40048E8")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0BA8", Offset = "0x5D0BA8")]
		public FsmGameObject toObject;

		[Token(Token = "0x40048E9")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0BE0", Offset = "0x5D0BE0")]
		public FsmVector3 toPosition;

		[Token(Token = "0x40048EA")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0C18", Offset = "0x5D0C18")]
		public FsmColor color;

		[Token(Token = "0x6005E3C")]
		[Address(RVA = "0xC1F4E8", Offset = "0xC1F4E8", VA = "0xC1F4E8", Slot = "30")]
		public override void Awake()
		{
		}

		[Token(Token = "0x6005E3D")]
		[Address(RVA = "0xC1F4F0", Offset = "0xC1F4F0", VA = "0xC1F4F0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E3E")]
		[Address(RVA = "0xC1F5F8", Offset = "0xC1F5F8", VA = "0xC1F5F8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005E3F")]
		[Address(RVA = "0xC1F6E0", Offset = "0xC1F6E0", VA = "0xC1F6E0", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6005E40")]
		[Address(RVA = "0xC1F804", Offset = "0xC1F804", VA = "0xC1F804")]
		public DrawDebugLine()
		{
		}
	}
}
