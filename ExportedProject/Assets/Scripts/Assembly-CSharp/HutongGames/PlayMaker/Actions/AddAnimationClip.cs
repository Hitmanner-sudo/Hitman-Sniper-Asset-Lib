using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EB5")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599850", Offset = "0x599850")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599850", Offset = "0x599850")]
	public class AddAnimationClip : FsmStateAction
	{
		[Token(Token = "0x40045A6")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C2148", Offset = "0x5C2148")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C2148", Offset = "0x5C2148")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40045A7")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x5C21DC", Offset = "0x5C21DC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C21DC", Offset = "0x5C21DC")]
		public FsmObject animationClip;

		[Token(Token = "0x40045A8")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C2270", Offset = "0x5C2270")]
		public FsmString animationName;

		[Token(Token = "0x40045A9")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C22BC", Offset = "0x5C22BC")]
		[Attribute(Name = "ActionSection", RVA = "0x5C22BC", Offset = "0x5C22BC")]
		public FsmInt firstFrame;

		[Token(Token = "0x40045AA")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C231C", Offset = "0x5C231C")]
		public FsmInt lastFrame;

		[Token(Token = "0x40045AB")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C2354", Offset = "0x5C2354")]
		public FsmBool addLoopFrame;

		[Token(Token = "0x6005AEC")]
		[Address(RVA = "0xD5BF28", Offset = "0xD5BF28", VA = "0xD5BF28", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005AED")]
		[Address(RVA = "0xD5BFB0", Offset = "0xD5BFB0", VA = "0xD5BFB0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005AEE")]
		[Address(RVA = "0xD5BFD8", Offset = "0xD5BFD8", VA = "0xD5BFD8")]
		private void DoAddAnimationClip()
		{
		}

		[Token(Token = "0x6005AEF")]
		[Address(RVA = "0xD5C1FC", Offset = "0xD5C1FC", VA = "0xD5C1FC")]
		public AddAnimationClip()
		{
		}
	}
}
