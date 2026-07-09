using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F9C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59DDD0", Offset = "0x59DDD0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59DDD0", Offset = "0x59DDD0")]
	public class RotateGUI : FsmStateAction
	{
		[Token(Token = "0x40049B7")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3A80", Offset = "0x5D3A80")]
		public FsmFloat angle;

		[Token(Token = "0x40049B8")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3ACC", Offset = "0x5D3ACC")]
		public FsmFloat pivotX;

		[Token(Token = "0x40049B9")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3B18", Offset = "0x5D3B18")]
		public FsmFloat pivotY;

		[Token(Token = "0x40049BA")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3B64", Offset = "0x5D3B64")]
		public bool normalized;

		[Token(Token = "0x40049BB")]
		[FieldOffset(Offset = "0x69")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3B9C", Offset = "0x5D3B9C")]
		public bool applyGlobally;

		[Token(Token = "0x40049BC")]
		[FieldOffset(Offset = "0x6A")]
		private bool applied;

		[Token(Token = "0x6005ECC")]
		[Address(RVA = "0xBA4C74", Offset = "0xBA4C74", VA = "0xBA4C74", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005ECD")]
		[Address(RVA = "0xBA4CD4", Offset = "0xBA4CD4", VA = "0xBA4CD4", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005ECE")]
		[Address(RVA = "0xBA4EC8", Offset = "0xBA4EC8", VA = "0xBA4EC8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005ECF")]
		[Address(RVA = "0xBA4ED0", Offset = "0xBA4ED0", VA = "0xBA4ED0")]
		public RotateGUI()
		{
		}
	}
}
