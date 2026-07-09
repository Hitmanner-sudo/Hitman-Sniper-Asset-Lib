using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FF6")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59FAE8", Offset = "0x59FAE8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59FAE8", Offset = "0x59FAE8")]
	public class GetButtonDown : FsmStateAction
	{
		[Token(Token = "0x4004AF5")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D886C", Offset = "0x5D886C")]
		public FsmString buttonName;

		[Token(Token = "0x4004AF6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D88B8", Offset = "0x5D88B8")]
		public FsmEvent sendEvent;

		[Token(Token = "0x4004AF7")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D88F0", Offset = "0x5D88F0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D88F0", Offset = "0x5D88F0")]
		public FsmBool storeResult;

		[Token(Token = "0x6006013")]
		[Address(RVA = "0x105D9CC", Offset = "0x105D9CC", VA = "0x105D9CC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006014")]
		[Address(RVA = "0x105DA24", Offset = "0x105DA24", VA = "0x105DA24", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006015")]
		[Address(RVA = "0x105DA8C", Offset = "0x105DA8C", VA = "0x105DA8C")]
		public GetButtonDown()
		{
		}
	}
}
