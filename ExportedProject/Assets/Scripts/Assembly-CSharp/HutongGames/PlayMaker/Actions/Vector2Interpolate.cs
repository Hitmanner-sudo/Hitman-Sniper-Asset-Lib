using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200125F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC724", Offset = "0x5AC724")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC724", Offset = "0x5AC724")]
	public class Vector2Interpolate : FsmStateAction
	{
		[Token(Token = "0x40057F3")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609BF0", Offset = "0x609BF0")]
		public InterpolationType mode;

		[Token(Token = "0x40057F4")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609C28", Offset = "0x609C28")]
		public FsmVector2 fromVector;

		[Token(Token = "0x40057F5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609C74", Offset = "0x609C74")]
		[RequiredField]
		public FsmVector2 toVector;

		[Token(Token = "0x40057F6")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609CC0", Offset = "0x609CC0")]
		public FsmFloat time;

		[Token(Token = "0x40057F7")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609D0C", Offset = "0x609D0C")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x609D0C", Offset = "0x609D0C")]
		public FsmVector2 storeResult;

		[Token(Token = "0x40057F8")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609D6C", Offset = "0x609D6C")]
		public FsmEvent finishEvent;

		[Token(Token = "0x40057F9")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609DA4", Offset = "0x609DA4")]
		public bool realTime;

		[Token(Token = "0x40057FA")]
		[FieldOffset(Offset = "0x7C")]
		private float startTime;

		[Token(Token = "0x40057FB")]
		[FieldOffset(Offset = "0x80")]
		private float currentTime;

		[Token(Token = "0x6006B7A")]
		[Address(RVA = "0x13C62A8", Offset = "0x13C62A8", VA = "0x13C62A8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B7B")]
		[Address(RVA = "0x13C6358", Offset = "0x13C6358", VA = "0x13C6358", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B7C")]
		[Address(RVA = "0x13C63B4", Offset = "0x13C63B4", VA = "0x13C63B4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006B7D")]
		[Address(RVA = "0x13C64C8", Offset = "0x13C64C8", VA = "0x13C64C8")]
		public Vector2Interpolate()
		{
		}
	}
}
