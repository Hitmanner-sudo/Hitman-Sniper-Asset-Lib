using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F2E")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59BE58", Offset = "0x59BE58")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59BE58", Offset = "0x59BE58")]
	public class PlayRandomSound : FsmStateAction
	{
		[Token(Token = "0x40047A8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CBCE0", Offset = "0x5CBCE0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40047A9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CBD18", Offset = "0x5CBD18")]
		public FsmVector3 position;

		[Token(Token = "0x40047AA")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CBD50", Offset = "0x5CBD50")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x5CBD50", Offset = "0x5CBD50")]
		[Attribute(Name = "CompoundArrayAttribute", RVA = "0x5CBD50", Offset = "0x5CBD50")]
		public FsmObject[] audioClips;

		[Token(Token = "0x40047AB")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CBE28", Offset = "0x5CBE28")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5CBE28", Offset = "0x5CBE28")]
		public FsmFloat[] weights;

		[Token(Token = "0x40047AC")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5CBE7C", Offset = "0x5CBE7C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CBE7C", Offset = "0x5CBE7C")]
		public FsmFloat volume;

		[Token(Token = "0x40047AD")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CBED0", Offset = "0x5CBED0")]
		public FsmBool noRepeat;

		[Token(Token = "0x40047AE")]
		[FieldOffset(Offset = "0x80")]
		private int randomIndex;

		[Token(Token = "0x40047AF")]
		[FieldOffset(Offset = "0x84")]
		private int lastIndex;

		[Token(Token = "0x6005D0D")]
		[Address(RVA = "0xB80CA0", Offset = "0xB80CA0", VA = "0xB80CA0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D0E")]
		[Address(RVA = "0xB80E44", Offset = "0xB80E44", VA = "0xB80E44", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005D0F")]
		[Address(RVA = "0xB80E6C", Offset = "0xB80E6C", VA = "0xB80E6C")]
		private void DoPlayRandomClip()
		{
		}

		[Token(Token = "0x6005D10")]
		[Address(RVA = "0xB810B8", Offset = "0xB810B8", VA = "0xB810B8")]
		public PlayRandomSound()
		{
		}
	}
}
