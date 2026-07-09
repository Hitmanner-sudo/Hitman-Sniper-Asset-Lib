using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001278")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ACEA4", Offset = "0x5ACEA4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ACEA4", Offset = "0x5ACEA4")]
	public class Vector3Invert : FsmStateAction
	{
		[Token(Token = "0x4005861")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60B628", Offset = "0x60B628")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B628", Offset = "0x60B628")]
		public FsmVector3 vector3Variable;

		[Token(Token = "0x4005862")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B688", Offset = "0x60B688")]
		public bool everyFrame;

		[Token(Token = "0x6006BE5")]
		[Address(RVA = "0x13C83D0", Offset = "0x13C83D0", VA = "0x13C83D0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006BE6")]
		[Address(RVA = "0x13C83DC", Offset = "0x13C83DC", VA = "0x13C83DC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006BE7")]
		[Address(RVA = "0x13C8440", Offset = "0x13C8440", VA = "0x13C8440", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006BE8")]
		[Address(RVA = "0x13C8484", Offset = "0x13C8484", VA = "0x13C8484")]
		public Vector3Invert()
		{
		}
	}
}
