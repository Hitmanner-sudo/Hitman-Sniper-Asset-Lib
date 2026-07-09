using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001100")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A511C", Offset = "0x5A511C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A511C", Offset = "0x5A511C")]
	public class EnableFog : FsmStateAction
	{
		[Token(Token = "0x4005085")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0118", Offset = "0x5F0118")]
		public FsmBool enableFog;

		[Token(Token = "0x4005086")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0150", Offset = "0x5F0150")]
		public bool everyFrame;

		[Token(Token = "0x600651D")]
		[Address(RVA = "0xE0D934", Offset = "0xE0D934", VA = "0xE0D934", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600651E")]
		[Address(RVA = "0xE0D964", Offset = "0xE0D964", VA = "0xE0D964", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600651F")]
		[Address(RVA = "0xE0D9BC", Offset = "0xE0D9BC", VA = "0xE0D9BC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006520")]
		[Address(RVA = "0xE0D9E8", Offset = "0xE0D9E8", VA = "0xE0D9E8")]
		public EnableFog()
		{
		}
	}
}
