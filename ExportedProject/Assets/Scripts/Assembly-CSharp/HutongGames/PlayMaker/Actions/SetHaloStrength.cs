using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001105")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A52AC", Offset = "0x5A52AC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A52AC", Offset = "0x5A52AC")]
	public class SetHaloStrength : FsmStateAction
	{
		[Token(Token = "0x400508F")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0398", Offset = "0x5F0398")]
		public FsmFloat haloStrength;

		[Token(Token = "0x4005090")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F03E4", Offset = "0x5F03E4")]
		public bool everyFrame;

		[Token(Token = "0x6006535")]
		[Address(RVA = "0x103DEE8", Offset = "0x103DEE8", VA = "0x103DEE8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006536")]
		[Address(RVA = "0x103DF18", Offset = "0x103DF18", VA = "0x103DF18", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006537")]
		[Address(RVA = "0x103DF7C", Offset = "0x103DF7C", VA = "0x103DF7C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006538")]
		[Address(RVA = "0x103DF54", Offset = "0x103DF54", VA = "0x103DF54")]
		private void DoSetHaloStrength()
		{
		}

		[Token(Token = "0x6006539")]
		[Address(RVA = "0x103DF80", Offset = "0x103DF80", VA = "0x103DF80")]
		public SetHaloStrength()
		{
		}
	}
}
