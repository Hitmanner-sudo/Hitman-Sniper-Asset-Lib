using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010C9")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3F8C", Offset = "0x5A3F8C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3F8C", Offset = "0x5A3F8C")]
	public class GetQuaternionEulerAngles : QuaternionBaseAction
	{
		[Token(Token = "0x4004F4E")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB29C", Offset = "0x5EB29C")]
		public FsmQuaternion quaternion;

		[Token(Token = "0x4004F4F")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EB2E8", Offset = "0x5EB2E8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB2E8", Offset = "0x5EB2E8")]
		public FsmVector3 eulerAngles;

		[Token(Token = "0x6006405")]
		[Address(RVA = "0x10676CC", Offset = "0x10676CC", VA = "0x10676CC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006406")]
		[Address(RVA = "0x10676E0", Offset = "0x10676E0", VA = "0x10676E0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006407")]
		[Address(RVA = "0x1067770", Offset = "0x1067770", VA = "0x1067770", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006408")]
		[Address(RVA = "0x1067780", Offset = "0x1067780", VA = "0x1067780", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6006409")]
		[Address(RVA = "0x1067794", Offset = "0x1067794", VA = "0x1067794", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x600640A")]
		[Address(RVA = "0x106771C", Offset = "0x106771C", VA = "0x106771C")]
		private void GetQuatEuler()
		{
		}

		[Token(Token = "0x600640B")]
		[Address(RVA = "0x10677A8", Offset = "0x10677A8", VA = "0x10677A8")]
		public GetQuaternionEulerAngles()
		{
		}
	}
}
