using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001103")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A520C", Offset = "0x5A520C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A520C", Offset = "0x5A520C")]
	public class SetFogColor : FsmStateAction
	{
		[Token(Token = "0x400508B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0290", Offset = "0x5F0290")]
		[RequiredField]
		public FsmColor fogColor;

		[Token(Token = "0x400508C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F02DC", Offset = "0x5F02DC")]
		public bool everyFrame;

		[Token(Token = "0x600652B")]
		[Address(RVA = "0x1039AC0", Offset = "0x1039AC0", VA = "0x1039AC0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600652C")]
		[Address(RVA = "0x1039AF4", Offset = "0x1039AF4", VA = "0x1039AF4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600652D")]
		[Address(RVA = "0x1039B54", Offset = "0x1039B54", VA = "0x1039B54", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600652E")]
		[Address(RVA = "0x1039B30", Offset = "0x1039B30", VA = "0x1039B30")]
		private void DoSetFogColor()
		{
		}

		[Token(Token = "0x600652F")]
		[Address(RVA = "0x1039B58", Offset = "0x1039B58", VA = "0x1039B58")]
		public SetFogColor()
		{
		}
	}
}
