using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010CC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A407C", Offset = "0x5A407C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A407C", Offset = "0x5A407C")]
	public class GetQuaternionMultipliedByVector : QuaternionBaseAction
	{
		[Token(Token = "0x4004F56")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB538", Offset = "0x5EB538")]
		[RequiredField]
		public FsmQuaternion quaternion;

		[Token(Token = "0x4004F57")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB584", Offset = "0x5EB584")]
		public FsmVector3 vector3;

		[Token(Token = "0x4004F58")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EB5D0", Offset = "0x5EB5D0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB5D0", Offset = "0x5EB5D0")]
		public FsmVector3 result;

		[Token(Token = "0x600641A")]
		[Address(RVA = "0x10679B8", Offset = "0x10679B8", VA = "0x10679B8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600641B")]
		[Address(RVA = "0x10679D0", Offset = "0x10679D0", VA = "0x10679D0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600641C")]
		[Address(RVA = "0x1067A90", Offset = "0x1067A90", VA = "0x1067A90", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600641D")]
		[Address(RVA = "0x1067AA0", Offset = "0x1067AA0", VA = "0x1067AA0", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x600641E")]
		[Address(RVA = "0x1067AB4", Offset = "0x1067AB4", VA = "0x1067AB4", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x600641F")]
		[Address(RVA = "0x1067A0C", Offset = "0x1067A0C", VA = "0x1067A0C")]
		private void DoQuatMult()
		{
		}

		[Token(Token = "0x6006420")]
		[Address(RVA = "0x1067AC8", Offset = "0x1067AC8", VA = "0x1067AC8")]
		public GetQuaternionMultipliedByVector()
		{
		}
	}
}
