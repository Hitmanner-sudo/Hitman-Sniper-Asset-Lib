using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F62")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59CCD0", Offset = "0x59CCD0")]
	[Attribute(Name = "HelpUrlAttribute", RVA = "0x59CCD0", Offset = "0x59CCD0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59CCD0", Offset = "0x59CCD0")]
	public class ConvertSecondsToString : FsmStateAction
	{
		[Token(Token = "0x40048B4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D0058", Offset = "0x5D0058")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0058", Offset = "0x5D0058")]
		[RequiredField]
		public FsmFloat secondsVariable;

		[Token(Token = "0x40048B5")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D00B8", Offset = "0x5D00B8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D00B8", Offset = "0x5D00B8")]
		public FsmString stringVariable;

		[Token(Token = "0x40048B6")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0118", Offset = "0x5D0118")]
		[RequiredField]
		public FsmString format;

		[Token(Token = "0x40048B7")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0164", Offset = "0x5D0164")]
		public bool everyFrame;

		[Token(Token = "0x6005E02")]
		[Address(RVA = "0xD7F8F8", Offset = "0xD7F8F8", VA = "0xD7F8F8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E03")]
		[Address(RVA = "0xD7F954", Offset = "0xD7F954", VA = "0xD7F954", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E04")]
		[Address(RVA = "0xD7FE44", Offset = "0xD7FE44", VA = "0xD7FE44", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005E05")]
		[Address(RVA = "0xD7F990", Offset = "0xD7F990", VA = "0xD7F990")]
		private void DoConvertSecondsToString()
		{
		}

		[Token(Token = "0x6005E06")]
		[Address(RVA = "0xD7FE48", Offset = "0xD7FE48", VA = "0xD7FE48")]
		public ConvertSecondsToString()
		{
		}
	}
}
