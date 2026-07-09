using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FD9")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F1C0", Offset = "0x59F1C0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F1C0", Offset = "0x59F1C0")]
	public class GetChildCount : FsmStateAction
	{
		[Token(Token = "0x4004A8D")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6D44", Offset = "0x5D6D44")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004A8E")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6D90", Offset = "0x5D6D90")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D6D90", Offset = "0x5D6D90")]
		public FsmInt storeResult;

		[Token(Token = "0x4004A8F")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6DF0", Offset = "0x5D6DF0")]
		public bool everyFrame;

		[Token(Token = "0x6005F9D")]
		[Address(RVA = "0x105E198", Offset = "0x105E198", VA = "0x105E198", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F9E")]
		[Address(RVA = "0x105E1A4", Offset = "0x105E1A4", VA = "0x105E1A4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005F9F")]
		[Address(RVA = "0x105E298", Offset = "0x105E298", VA = "0x105E298", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005FA0")]
		[Address(RVA = "0x105E1E0", Offset = "0x105E1E0", VA = "0x105E1E0")]
		private void DoGetChildCount()
		{
		}

		[Token(Token = "0x6005FA1")]
		[Address(RVA = "0x105E29C", Offset = "0x105E29C", VA = "0x105E29C")]
		public GetChildCount()
		{
		}
	}
}
