using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001273")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ACD14", Offset = "0x5ACD14")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ACD14", Offset = "0x5ACD14")]
	public class Vector3AddXYZ : FsmStateAction
	{
		[Token(Token = "0x4005849")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B064", Offset = "0x60B064")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60B064", Offset = "0x60B064")]
		[RequiredField]
		public FsmVector3 vector3Variable;

		[Token(Token = "0x400584A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B0C4", Offset = "0x60B0C4")]
		public FsmFloat addX;

		[Token(Token = "0x400584B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B0FC", Offset = "0x60B0FC")]
		public FsmFloat addY;

		[Token(Token = "0x400584C")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B134", Offset = "0x60B134")]
		public FsmFloat addZ;

		[Token(Token = "0x400584D")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B16C", Offset = "0x60B16C")]
		public bool everyFrame;

		[Token(Token = "0x400584E")]
		[FieldOffset(Offset = "0x71")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B1A4", Offset = "0x60B1A4")]
		public bool perSecond;

		[Token(Token = "0x6006BCE")]
		[Address(RVA = "0x13C79E8", Offset = "0x13C79E8", VA = "0x13C79E8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006BCF")]
		[Address(RVA = "0x13C7A3C", Offset = "0x13C7A3C", VA = "0x13C7A3C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006BD0")]
		[Address(RVA = "0x13C7B4C", Offset = "0x13C7B4C", VA = "0x13C7B4C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006BD1")]
		[Address(RVA = "0x13C7A78", Offset = "0x13C7A78", VA = "0x13C7A78")]
		private void DoVector3AddXYZ()
		{
		}

		[Token(Token = "0x6006BD2")]
		[Address(RVA = "0x13C7B50", Offset = "0x13C7B50", VA = "0x13C7B50")]
		public Vector3AddXYZ()
		{
		}
	}
}
