using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001259")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC544", Offset = "0x5AC544")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC544", Offset = "0x5AC544")]
	public class SetVector2Value : FsmStateAction
	{
		[Token(Token = "0x40057DC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6095DC", Offset = "0x6095DC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x6095DC", Offset = "0x6095DC")]
		[RequiredField]
		public FsmVector2 vector2Variable;

		[Token(Token = "0x40057DD")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60963C", Offset = "0x60963C")]
		[RequiredField]
		public FsmVector2 vector2Value;

		[Token(Token = "0x40057DE")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609688", Offset = "0x609688")]
		public bool everyFrame;

		[Token(Token = "0x6006B5E")]
		[Address(RVA = "0x83C270", Offset = "0x83C270", VA = "0x83C270", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B5F")]
		[Address(RVA = "0x83C27C", Offset = "0x83C27C", VA = "0x83C27C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B60")]
		[Address(RVA = "0x83C2BC", Offset = "0x83C2BC", VA = "0x83C2BC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006B61")]
		[Address(RVA = "0x83C2E8", Offset = "0x83C2E8", VA = "0x83C2E8")]
		public SetVector2Value()
		{
		}
	}
}
