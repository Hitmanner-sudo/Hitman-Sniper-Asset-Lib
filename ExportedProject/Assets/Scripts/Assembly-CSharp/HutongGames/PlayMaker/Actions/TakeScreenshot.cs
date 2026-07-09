using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F09")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B1A0", Offset = "0x59B1A0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B1A0", Offset = "0x59B1A0")]
	public class TakeScreenshot : FsmStateAction
	{
		[Token(Token = "0x2000F0A")]
		public enum Destination
		{
			[Token(Token = "0x400471A")]
			MyPictures = 0,
			[Token(Token = "0x400471B")]
			PersistentDataPath = 1,
			[Token(Token = "0x400471C")]
			CustomPath = 2
		}

		[Token(Token = "0x4004712")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C95D0", Offset = "0x5C95D0")]
		public Destination destination;

		[Token(Token = "0x4004713")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9608", Offset = "0x5C9608")]
		public FsmString customPath;

		[Token(Token = "0x4004714")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9640", Offset = "0x5C9640")]
		[RequiredField]
		public FsmString filename;

		[Token(Token = "0x4004715")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C968C", Offset = "0x5C968C")]
		public FsmBool autoNumber;

		[Token(Token = "0x4004716")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C96C4", Offset = "0x5C96C4")]
		public FsmInt superSize;

		[Token(Token = "0x4004717")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C96FC", Offset = "0x5C96FC")]
		public FsmBool debugLog;

		[Token(Token = "0x4004718")]
		[FieldOffset(Offset = "0x78")]
		private int screenshotCount;

		[Token(Token = "0x6005C7E")]
		[Address(RVA = "0xB4E994", Offset = "0xB4E994", VA = "0xB4E994", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C7F")]
		[Address(RVA = "0xB4E9F0", Offset = "0xB4E9F0", VA = "0xB4E9F0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C80")]
		[Address(RVA = "0xB4EC7C", Offset = "0xB4EC7C", VA = "0xB4EC7C")]
		public TakeScreenshot()
		{
		}
	}
}
