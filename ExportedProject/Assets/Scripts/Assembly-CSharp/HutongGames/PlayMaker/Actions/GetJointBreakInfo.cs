using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001073")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2210", Offset = "0x5A2210")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2210", Offset = "0x5A2210")]
	public class GetJointBreakInfo : FsmStateAction
	{
		[Token(Token = "0x4004D56")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E251C", Offset = "0x5E251C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E251C", Offset = "0x5E251C")]
		public FsmFloat breakForce;

		[Token(Token = "0x6006256")]
		[Address(RVA = "0x10639B0", Offset = "0x10639B0", VA = "0x10639B0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006257")]
		[Address(RVA = "0x10639B8", Offset = "0x10639B8", VA = "0x10639B8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006258")]
		[Address(RVA = "0x10639E8", Offset = "0x10639E8", VA = "0x10639E8")]
		public GetJointBreakInfo()
		{
		}
	}
}
