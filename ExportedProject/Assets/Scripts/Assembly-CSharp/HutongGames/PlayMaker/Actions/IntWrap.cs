using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200105A")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1B10", Offset = "0x5A1B10")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1B10", Offset = "0x5A1B10")]
	public class IntWrap : FsmStateAction
	{
		[Token(Token = "0x4004CC9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0298", Offset = "0x5E0298")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E0298", Offset = "0x5E0298")]
		public FsmInt intVariable;

		[Token(Token = "0x4004CCA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E02F8", Offset = "0x5E02F8")]
		[RequiredField]
		public FsmInt minValue;

		[Token(Token = "0x4004CCB")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0344", Offset = "0x5E0344")]
		[RequiredField]
		public FsmInt maxValue;

		[Token(Token = "0x4004CCC")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0390", Offset = "0x5E0390")]
		public bool everyFrame;

		[Token(Token = "0x60061CE")]
		[Address(RVA = "0xB16978", Offset = "0xB16978", VA = "0xB16978", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60061CF")]
		[Address(RVA = "0xB16988", Offset = "0xB16988", VA = "0xB16988", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60061D0")]
		[Address(RVA = "0xB16A6C", Offset = "0xB16A6C", VA = "0xB16A6C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60061D1")]
		[Address(RVA = "0xB169C4", Offset = "0xB169C4", VA = "0xB169C4")]
		private void DoWrap()
		{
		}

		[Token(Token = "0x60061D2")]
		[Address(RVA = "0xB16A70", Offset = "0xB16A70", VA = "0xB16A70")]
		public IntWrap()
		{
		}
	}
}
