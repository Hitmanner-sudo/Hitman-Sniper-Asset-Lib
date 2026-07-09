using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FAB")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59E2F8", Offset = "0x59E2F8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59E2F8", Offset = "0x59E2F8")]
	public class GUILayoutBeginAreaFollowObject : FsmStateAction
	{
		[Token(Token = "0x40049E1")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4404", Offset = "0x5D4404")]
		public FsmGameObject gameObject;

		[Token(Token = "0x40049E2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4450", Offset = "0x5D4450")]
		[RequiredField]
		public FsmFloat offsetLeft;

		[Token(Token = "0x40049E3")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D449C", Offset = "0x5D449C")]
		public FsmFloat offsetTop;

		[Token(Token = "0x40049E4")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D44E8", Offset = "0x5D44E8")]
		public FsmFloat width;

		[Token(Token = "0x40049E5")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4534", Offset = "0x5D4534")]
		public FsmFloat height;

		[Token(Token = "0x40049E6")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4580", Offset = "0x5D4580")]
		public FsmBool normalized;

		[Token(Token = "0x40049E7")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D45B8", Offset = "0x5D45B8")]
		public FsmString style;

		[Token(Token = "0x6005EF7")]
		[Address(RVA = "0xD8F644", Offset = "0xD8F644", VA = "0xD8F644", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005EF8")]
		[Address(RVA = "0xD8F6F8", Offset = "0xD8F6F8", VA = "0xD8F6F8", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005EF9")]
		[Address(RVA = "0xD8FA30", Offset = "0xD8FA30", VA = "0xD8FA30")]
		private static void DummyBeginArea()
		{
		}

		[Token(Token = "0x6005EFA")]
		[Address(RVA = "0xD8FA48", Offset = "0xD8FA48", VA = "0xD8FA48")]
		public GUILayoutBeginAreaFollowObject()
		{
		}
	}
}
