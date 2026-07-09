using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FC8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59EC08", Offset = "0x59EC08")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59EC08", Offset = "0x59EC08")]
	public class UseGUILayout : FsmStateAction
	{
		[Token(Token = "0x4004A46")]
		[FieldOffset(Offset = "0x49")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5C60", Offset = "0x5D5C60")]
		public bool turnOffGUIlayout;

		[Token(Token = "0x6005F52")]
		[Address(RVA = "0xBA23E8", Offset = "0xBA23E8", VA = "0xBA23E8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F53")]
		[Address(RVA = "0xBA23F4", Offset = "0xBA23F4", VA = "0xBA23F4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005F54")]
		[Address(RVA = "0xBA2440", Offset = "0xBA2440", VA = "0xBA2440")]
		public UseGUILayout()
		{
		}
	}
}
