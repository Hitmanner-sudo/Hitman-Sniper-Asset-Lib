using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010CA")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3FDC", Offset = "0x5A3FDC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3FDC", Offset = "0x5A3FDC")]
	public class GetQuaternionFromRotation : QuaternionBaseAction
	{
		[Token(Token = "0x4004F50")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB348", Offset = "0x5EB348")]
		public FsmVector3 fromDirection;

		[Token(Token = "0x4004F51")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB394", Offset = "0x5EB394")]
		public FsmVector3 toDirection;

		[Token(Token = "0x4004F52")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB3E0", Offset = "0x5EB3E0")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EB3E0", Offset = "0x5EB3E0")]
		public FsmQuaternion result;

		[Token(Token = "0x600640C")]
		[Address(RVA = "0x10677B0", Offset = "0x10677B0", VA = "0x10677B0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600640D")]
		[Address(RVA = "0x10677C8", Offset = "0x10677C8", VA = "0x10677C8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600640E")]
		[Address(RVA = "0x1067890", Offset = "0x1067890", VA = "0x1067890", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600640F")]
		[Address(RVA = "0x10678A0", Offset = "0x10678A0", VA = "0x10678A0", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6006410")]
		[Address(RVA = "0x10678B4", Offset = "0x10678B4", VA = "0x10678B4", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6006411")]
		[Address(RVA = "0x1067804", Offset = "0x1067804", VA = "0x1067804")]
		private void DoQuatFromRotation()
		{
		}

		[Token(Token = "0x6006412")]
		[Address(RVA = "0x10678C8", Offset = "0x10678C8", VA = "0x10678C8")]
		public GetQuaternionFromRotation()
		{
		}
	}
}
