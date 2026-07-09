using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010DF")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A45DC", Offset = "0x5A45DC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A45DC", Offset = "0x5A45DC")]
	public class RectTransformFlipLayoutAxis : FsmStateAction
	{
		[Token(Token = "0x20010E0")]
		public enum RectTransformFlipOptions
		{
			[Token(Token = "0x4004FB3")]
			Horizontal = 0,
			[Token(Token = "0x4004FB4")]
			Vertical = 1,
			[Token(Token = "0x4004FB5")]
			Both = 2
		}

		[Token(Token = "0x4004FAE")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ECCB4", Offset = "0x5ECCB4")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5ECCB4", Offset = "0x5ECCB4")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004FAF")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ECD48", Offset = "0x5ECD48")]
		public RectTransformFlipOptions axis;

		[Token(Token = "0x4004FB0")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ECD80", Offset = "0x5ECD80")]
		public FsmBool keepPositioning;

		[Token(Token = "0x4004FB1")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ECDB8", Offset = "0x5ECDB8")]
		public FsmBool recursive;

		[Token(Token = "0x6006486")]
		[Address(RVA = "0xB447FC", Offset = "0xB447FC", VA = "0xB447FC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006487")]
		[Address(RVA = "0xB44810", Offset = "0xB44810", VA = "0xB44810", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006488")]
		[Address(RVA = "0xB44838", Offset = "0xB44838", VA = "0xB44838")]
		private void DoFlip()
		{
		}

		[Token(Token = "0x6006489")]
		[Address(RVA = "0xB44A94", Offset = "0xB44A94", VA = "0xB44A94")]
		public RectTransformFlipLayoutAxis()
		{
		}
	}
}
