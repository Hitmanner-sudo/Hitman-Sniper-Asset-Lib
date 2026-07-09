using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001151")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A68BC", Offset = "0x5A68BC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A68BC", Offset = "0x5A68BC")]
	public class GetEventVector2Data : FsmStateAction
	{
		[Token(Token = "0x4005222")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6118", Offset = "0x5F6118")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F6118", Offset = "0x5F6118")]
		public FsmVector2 getVector2Data;

		[Token(Token = "0x600665D")]
		[Address(RVA = "0x1060364", Offset = "0x1060364", VA = "0x1060364", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600665E")]
		[Address(RVA = "0x106036C", Offset = "0x106036C", VA = "0x106036C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600665F")]
		[Address(RVA = "0x10603FC", Offset = "0x10603FC", VA = "0x10603FC")]
		public GetEventVector2Data()
		{
		}
	}
}
