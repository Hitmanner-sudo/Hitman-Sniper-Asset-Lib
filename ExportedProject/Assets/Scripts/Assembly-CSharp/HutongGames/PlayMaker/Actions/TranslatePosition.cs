using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001088")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A28C4", Offset = "0x5A28C4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A28C4", Offset = "0x5A28C4")]
	public class TranslatePosition : ComponentAction<Rigidbody>
	{
		[Token(Token = "0x4004DC3")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E46EC", Offset = "0x5E46EC")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E46EC", Offset = "0x5E46EC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004DC4")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E4780", Offset = "0x5E4780")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4780", Offset = "0x5E4780")]
		public FsmVector3 vector;

		[Token(Token = "0x4004DC5")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E47D0", Offset = "0x5E47D0")]
		public FsmFloat x;

		[Token(Token = "0x4004DC6")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4808", Offset = "0x5E4808")]
		public FsmFloat y;

		[Token(Token = "0x4004DC7")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4840", Offset = "0x5E4840")]
		public FsmFloat z;

		[Token(Token = "0x4004DC8")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4878", Offset = "0x5E4878")]
		public Space space;

		[Token(Token = "0x4004DC9")]
		[FieldOffset(Offset = "0x94")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E48B0", Offset = "0x5E48B0")]
		public bool perSecond;

		[Token(Token = "0x4004DCA")]
		[FieldOffset(Offset = "0x95")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E48E8", Offset = "0x5E48E8")]
		public bool everyFrame;

		[Token(Token = "0x60062B6")]
		[Address(RVA = "0xC97A2C", Offset = "0xC97A2C", VA = "0xC97A2C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60062B7")]
		[Address(RVA = "0xC97AF4", Offset = "0xC97AF4", VA = "0xC97AF4", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x60062B8")]
		[Address(RVA = "0xC97B14", Offset = "0xC97B14", VA = "0xC97B14", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x60062B9")]
		[Address(RVA = "0xC97B50", Offset = "0xC97B50", VA = "0xC97B50")]
		private void DoMovePosition()
		{
		}

		[Token(Token = "0x60062BA")]
		[Address(RVA = "0xC97DA8", Offset = "0xC97DA8", VA = "0xC97DA8")]
		public TranslatePosition()
		{
		}
	}
}
