using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FE0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F3F0", Offset = "0x59F3F0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F3F0", Offset = "0x59F3F0")]
	public class GetOwner : FsmStateAction
	{
		[Token(Token = "0x4004AAF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D75F0", Offset = "0x5D75F0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D75F0", Offset = "0x5D75F0")]
		[RequiredField]
		public FsmGameObject storeGameObject;

		[Token(Token = "0x6005FBF")]
		[Address(RVA = "0x1066F90", Offset = "0x1066F90", VA = "0x1066F90", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005FC0")]
		[Address(RVA = "0x1066F98", Offset = "0x1066F98", VA = "0x1066F98", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005FC1")]
		[Address(RVA = "0x1066FD4", Offset = "0x1066FD4", VA = "0x1066FD4")]
		public GetOwner()
		{
		}
	}
}
