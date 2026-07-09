using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EB6")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5998A0", Offset = "0x5998A0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5998A0", Offset = "0x5998A0")]
	public class AddMixingTransform : BaseAnimationAction
	{
		[Token(Token = "0x40045AC")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C238C", Offset = "0x5C238C")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C238C", Offset = "0x5C238C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40045AD")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C2420", Offset = "0x5C2420")]
		public FsmString animationName;

		[Token(Token = "0x40045AE")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C246C", Offset = "0x5C246C")]
		[RequiredField]
		public FsmString transform;

		[Token(Token = "0x40045AF")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C24B8", Offset = "0x5C24B8")]
		public FsmBool recursive;

		[Token(Token = "0x6005AF0")]
		[Address(RVA = "0xD5CEA8", Offset = "0xD5CEA8", VA = "0xD5CEA8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005AF1")]
		[Address(RVA = "0xD5CF20", Offset = "0xD5CF20", VA = "0xD5CF20", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005AF2")]
		[Address(RVA = "0xD5CF48", Offset = "0xD5CF48", VA = "0xD5CF48")]
		private void DoAddMixingTransform()
		{
		}

		[Token(Token = "0x6005AF3")]
		[Address(RVA = "0xD5D09C", Offset = "0xD5D09C", VA = "0xD5D09C")]
		public AddMixingTransform()
		{
		}
	}
}
