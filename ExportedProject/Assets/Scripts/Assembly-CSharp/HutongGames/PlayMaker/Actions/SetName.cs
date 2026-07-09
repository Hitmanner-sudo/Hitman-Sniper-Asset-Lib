using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FEC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F7B0", Offset = "0x59F7B0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F7B0", Offset = "0x59F7B0")]
	public class SetName : FsmStateAction
	{
		[Token(Token = "0x4004AD1")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8078", Offset = "0x5D8078")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004AD2")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D80C4", Offset = "0x5D80C4")]
		public FsmString name;

		[Token(Token = "0x6005FF1")]
		[Address(RVA = "0x10410A0", Offset = "0x10410A0", VA = "0x10410A0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005FF2")]
		[Address(RVA = "0x10410A8", Offset = "0x10410A8", VA = "0x10410A8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005FF3")]
		[Address(RVA = "0x10410D0", Offset = "0x10410D0", VA = "0x10410D0")]
		private void DoSetLayer()
		{
		}

		[Token(Token = "0x6005FF4")]
		[Address(RVA = "0x104118C", Offset = "0x104118C", VA = "0x104118C")]
		public SetName()
		{
		}
	}
}
