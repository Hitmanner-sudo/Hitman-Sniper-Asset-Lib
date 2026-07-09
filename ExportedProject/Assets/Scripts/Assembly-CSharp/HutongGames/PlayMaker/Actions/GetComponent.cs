using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001251")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC2C4", Offset = "0x5AC2C4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC2C4", Offset = "0x5AC2C4")]
	public class GetComponent : FsmStateAction
	{
		[Token(Token = "0x40057C4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609054", Offset = "0x609054")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40057C5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60908C", Offset = "0x60908C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60908C", Offset = "0x60908C")]
		[RequiredField]
		public FsmObject storeComponent;

		[Token(Token = "0x40057C6")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6090EC", Offset = "0x6090EC")]
		public bool everyFrame;

		[Token(Token = "0x6006B39")]
		[Address(RVA = "0x105EB2C", Offset = "0x105EB2C", VA = "0x105EB2C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B3A")]
		[Address(RVA = "0x105EB38", Offset = "0x105EB38", VA = "0x105EB38", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B3B")]
		[Address(RVA = "0x105EC54", Offset = "0x105EC54", VA = "0x105EC54", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006B3C")]
		[Address(RVA = "0x105EB74", Offset = "0x105EB74", VA = "0x105EB74")]
		private void DoGetComponent()
		{
		}

		[Token(Token = "0x6006B3D")]
		[Address(RVA = "0x105EC58", Offset = "0x105EC58", VA = "0x105EC58")]
		public GetComponent()
		{
		}
	}
}
