using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200106D")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2080", Offset = "0x5A2080")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2080", Offset = "0x5A2080")]
	public class AddTorque : ComponentAction<Rigidbody>
	{
		[Token(Token = "0x4004D1D")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E182C", Offset = "0x5E182C")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E182C", Offset = "0x5E182C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004D1E")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E18C0", Offset = "0x5E18C0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E18C0", Offset = "0x5E18C0")]
		public FsmVector3 vector;

		[Token(Token = "0x4004D1F")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1910", Offset = "0x5E1910")]
		public FsmFloat x;

		[Token(Token = "0x4004D20")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1948", Offset = "0x5E1948")]
		public FsmFloat y;

		[Token(Token = "0x4004D21")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1980", Offset = "0x5E1980")]
		public FsmFloat z;

		[Token(Token = "0x4004D22")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E19B8", Offset = "0x5E19B8")]
		public Space space;

		[Token(Token = "0x4004D23")]
		[FieldOffset(Offset = "0x94")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E19F0", Offset = "0x5E19F0")]
		public ForceMode forceMode;

		[Token(Token = "0x4004D24")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1A28", Offset = "0x5E1A28")]
		public bool everyFrame;

		[Token(Token = "0x600621C")]
		[Address(RVA = "0xD5D634", Offset = "0xD5D634", VA = "0xD5D634", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600621D")]
		[Address(RVA = "0xD5D6F4", Offset = "0xD5D6F4", VA = "0xD5D6F4", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x600621E")]
		[Address(RVA = "0xD5D714", Offset = "0xD5D714", VA = "0xD5D714", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600621F")]
		[Address(RVA = "0xD5D928", Offset = "0xD5D928", VA = "0xD5D928", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6006220")]
		[Address(RVA = "0xD5D750", Offset = "0xD5D750", VA = "0xD5D750")]
		private void DoAddTorque()
		{
		}

		[Token(Token = "0x6006221")]
		[Address(RVA = "0xD5D92C", Offset = "0xD5D92C", VA = "0xD5D92C")]
		public AddTorque()
		{
		}
	}
}
