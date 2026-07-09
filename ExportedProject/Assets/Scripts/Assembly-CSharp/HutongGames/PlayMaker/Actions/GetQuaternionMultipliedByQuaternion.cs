using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010CB")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A402C", Offset = "0x5A402C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A402C", Offset = "0x5A402C")]
	public class GetQuaternionMultipliedByQuaternion : QuaternionBaseAction
	{
		[Token(Token = "0x4004F53")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB440", Offset = "0x5EB440")]
		[RequiredField]
		public FsmQuaternion quaternionA;

		[Token(Token = "0x4004F54")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB48C", Offset = "0x5EB48C")]
		[RequiredField]
		public FsmQuaternion quaternionB;

		[Token(Token = "0x4004F55")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EB4D8", Offset = "0x5EB4D8")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB4D8", Offset = "0x5EB4D8")]
		public FsmQuaternion result;

		[Token(Token = "0x6006413")]
		[Address(RVA = "0x10678D0", Offset = "0x10678D0", VA = "0x10678D0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006414")]
		[Address(RVA = "0x10678E8", Offset = "0x10678E8", VA = "0x10678E8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006415")]
		[Address(RVA = "0x1067978", Offset = "0x1067978", VA = "0x1067978", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006416")]
		[Address(RVA = "0x1067988", Offset = "0x1067988", VA = "0x1067988", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6006417")]
		[Address(RVA = "0x106799C", Offset = "0x106799C", VA = "0x106799C", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6006418")]
		[Address(RVA = "0x1067924", Offset = "0x1067924", VA = "0x1067924")]
		private void DoQuatMult()
		{
		}

		[Token(Token = "0x6006419")]
		[Address(RVA = "0x10679B0", Offset = "0x10679B0", VA = "0x10679B0")]
		public GetQuaternionMultipliedByQuaternion()
		{
		}
	}
}
