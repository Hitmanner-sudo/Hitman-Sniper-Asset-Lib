using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200127F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD084", Offset = "0x5AD084")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD084", Offset = "0x5AD084")]
	public class Vector3PerSecond : FsmStateAction
	{
		[Token(Token = "0x4005883")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60BBF8", Offset = "0x60BBF8")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60BBF8", Offset = "0x60BBF8")]
		public FsmVector3 vector3Variable;

		[Token(Token = "0x4005884")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60BC58", Offset = "0x60BC58")]
		public bool everyFrame;

		[Token(Token = "0x6006BFF")]
		[Address(RVA = "0x13C8D44", Offset = "0x13C8D44", VA = "0x13C8D44", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C00")]
		[Address(RVA = "0x13C8D50", Offset = "0x13C8D50", VA = "0x13C8D50", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006C01")]
		[Address(RVA = "0x13C8DE0", Offset = "0x13C8DE0", VA = "0x13C8DE0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006C02")]
		[Address(RVA = "0x13C8E48", Offset = "0x13C8E48", VA = "0x13C8E48")]
		public Vector3PerSecond()
		{
		}
	}
}
