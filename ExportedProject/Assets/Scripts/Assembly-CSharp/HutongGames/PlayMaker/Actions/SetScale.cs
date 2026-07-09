using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011B2")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A93D8", Offset = "0x5A93D8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A93D8", Offset = "0x5A93D8")]
	public class SetScale : FsmStateAction
	{
		[Token(Token = "0x4005461")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD46C", Offset = "0x5FD46C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005462")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FD4B8", Offset = "0x5FD4B8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD4B8", Offset = "0x5FD4B8")]
		public FsmVector3 vector;

		[Token(Token = "0x4005463")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD508", Offset = "0x5FD508")]
		public FsmFloat x;

		[Token(Token = "0x4005464")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD540", Offset = "0x5FD540")]
		public FsmFloat y;

		[Token(Token = "0x4005465")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD578", Offset = "0x5FD578")]
		public FsmFloat z;

		[Token(Token = "0x4005466")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD5B0", Offset = "0x5FD5B0")]
		public bool everyFrame;

		[Token(Token = "0x4005467")]
		[FieldOffset(Offset = "0x79")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD5E8", Offset = "0x5FD5E8")]
		public bool lateUpdate;

		[Token(Token = "0x6006832")]
		[Address(RVA = "0x1044918", Offset = "0x1044918", VA = "0x1044918", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006833")]
		[Address(RVA = "0x10449D8", Offset = "0x10449D8", VA = "0x10449D8", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x6006834")]
		[Address(RVA = "0x1044A04", Offset = "0x1044A04", VA = "0x1044A04", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006835")]
		[Address(RVA = "0x1044BE0", Offset = "0x1044BE0", VA = "0x1044BE0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006836")]
		[Address(RVA = "0x1044BF0", Offset = "0x1044BF0", VA = "0x1044BF0", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6006837")]
		[Address(RVA = "0x1044A40", Offset = "0x1044A40", VA = "0x1044A40")]
		private void DoSetScale()
		{
		}

		[Token(Token = "0x6006838")]
		[Address(RVA = "0x1044C38", Offset = "0x1044C38", VA = "0x1044C38")]
		public SetScale()
		{
		}
	}
}
