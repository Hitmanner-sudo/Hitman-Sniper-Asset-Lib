using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001261")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC7C4", Offset = "0x5AC7C4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC7C4", Offset = "0x5AC7C4")]
	public class Vector2Lerp : FsmStateAction
	{
		[Token(Token = "0x40057FE")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609E74", Offset = "0x609E74")]
		public FsmVector2 fromVector;

		[Token(Token = "0x40057FF")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609EC0", Offset = "0x609EC0")]
		public FsmVector2 toVector;

		[Token(Token = "0x4005800")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609F0C", Offset = "0x609F0C")]
		public FsmFloat amount;

		[Token(Token = "0x4005801")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x609F58", Offset = "0x609F58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609F58", Offset = "0x609F58")]
		public FsmVector2 storeResult;

		[Token(Token = "0x4005802")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609FB8", Offset = "0x609FB8")]
		public bool everyFrame;

		[Token(Token = "0x6006B82")]
		[Address(RVA = "0x13C653C", Offset = "0x13C653C", VA = "0x13C653C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B83")]
		[Address(RVA = "0x13C65D8", Offset = "0x13C65D8", VA = "0x13C65D8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B84")]
		[Address(RVA = "0x13C6684", Offset = "0x13C6684", VA = "0x13C6684", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006B85")]
		[Address(RVA = "0x13C6614", Offset = "0x13C6614", VA = "0x13C6614")]
		private void DoVector2Lerp()
		{
		}

		[Token(Token = "0x6006B86")]
		[Address(RVA = "0x13C6688", Offset = "0x13C6688", VA = "0x13C6688")]
		public Vector2Lerp()
		{
		}
	}
}
