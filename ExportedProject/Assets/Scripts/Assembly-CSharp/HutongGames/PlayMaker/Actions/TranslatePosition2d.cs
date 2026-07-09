using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010B4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3714", Offset = "0x5A3714")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3714", Offset = "0x5A3714")]
	public class TranslatePosition2d : ComponentAction<Rigidbody2D>
	{
		[Token(Token = "0x4004F13")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA0C0", Offset = "0x5EA0C0")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EA0C0", Offset = "0x5EA0C0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004F14")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EA154", Offset = "0x5EA154")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA154", Offset = "0x5EA154")]
		public FsmVector2 vector;

		[Token(Token = "0x4004F15")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA1A4", Offset = "0x5EA1A4")]
		public FsmFloat x;

		[Token(Token = "0x4004F16")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA1DC", Offset = "0x5EA1DC")]
		public FsmFloat y;

		[Token(Token = "0x4004F17")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA214", Offset = "0x5EA214")]
		public Space space;

		[Token(Token = "0x4004F18")]
		[FieldOffset(Offset = "0x8C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA24C", Offset = "0x5EA24C")]
		public bool perSecond;

		[Token(Token = "0x4004F19")]
		[FieldOffset(Offset = "0x8D")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA284", Offset = "0x5EA284")]
		public bool everyFrame;

		[Token(Token = "0x60063A7")]
		[Address(RVA = "0xC97DF4", Offset = "0xC97DF4", VA = "0xC97DF4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60063A8")]
		[Address(RVA = "0xC97E98", Offset = "0xC97E98", VA = "0xC97E98", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x60063A9")]
		[Address(RVA = "0xC97EB8", Offset = "0xC97EB8", VA = "0xC97EB8", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x60063AA")]
		[Address(RVA = "0xC97EF4", Offset = "0xC97EF4", VA = "0xC97EF4")]
		private void DoTranslatePosition2d()
		{
		}

		[Token(Token = "0x60063AB")]
		[Address(RVA = "0xC980C4", Offset = "0xC980C4", VA = "0xC980C4")]
		public TranslatePosition2d()
		{
		}
	}
}
