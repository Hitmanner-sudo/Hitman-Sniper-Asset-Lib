using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001277")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ACE54", Offset = "0x5ACE54")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ACE54", Offset = "0x5ACE54")]
	public class Vector3Interpolate : FsmStateAction
	{
		[Token(Token = "0x4005858")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B43C", Offset = "0x60B43C")]
		public InterpolationType mode;

		[Token(Token = "0x4005859")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B474", Offset = "0x60B474")]
		[RequiredField]
		public FsmVector3 fromVector;

		[Token(Token = "0x400585A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B4C0", Offset = "0x60B4C0")]
		[RequiredField]
		public FsmVector3 toVector;

		[Token(Token = "0x400585B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B50C", Offset = "0x60B50C")]
		[RequiredField]
		public FsmFloat time;

		[Token(Token = "0x400585C")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60B558", Offset = "0x60B558")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B558", Offset = "0x60B558")]
		public FsmVector3 storeResult;

		[Token(Token = "0x400585D")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B5B8", Offset = "0x60B5B8")]
		public FsmEvent finishEvent;

		[Token(Token = "0x400585E")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B5F0", Offset = "0x60B5F0")]
		public bool realTime;

		[Token(Token = "0x400585F")]
		[FieldOffset(Offset = "0x7C")]
		private float startTime;

		[Token(Token = "0x4005860")]
		[FieldOffset(Offset = "0x80")]
		private float currentTime;

		[Token(Token = "0x6006BE1")]
		[Address(RVA = "0x13C814C", Offset = "0x13C814C", VA = "0x13C814C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006BE2")]
		[Address(RVA = "0x13C81FC", Offset = "0x13C81FC", VA = "0x13C81FC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006BE3")]
		[Address(RVA = "0x13C8260", Offset = "0x13C8260", VA = "0x13C8260", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006BE4")]
		[Address(RVA = "0x13C83C8", Offset = "0x13C83C8", VA = "0x13C83C8")]
		public Vector3Interpolate()
		{
		}
	}
}
