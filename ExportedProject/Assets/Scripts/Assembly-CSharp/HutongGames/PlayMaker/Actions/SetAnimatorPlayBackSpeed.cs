using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EFD")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59ADE0", Offset = "0x59ADE0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59ADE0", Offset = "0x59ADE0")]
	public class SetAnimatorPlayBackSpeed : ComponentAction<Animator>
	{
		[Token(Token = "0x40046F5")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8C64", Offset = "0x5C8C64")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C8C64", Offset = "0x5C8C64")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40046F6")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8CF8", Offset = "0x5C8CF8")]
		public FsmFloat playBackSpeed;

		[Token(Token = "0x40046F7")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8D30", Offset = "0x5C8D30")]
		public bool everyFrame;

		[Token(Token = "0x6005C4C")]
		[Address(RVA = "0x1036CE4", Offset = "0x1036CE4", VA = "0x1036CE4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C4D")]
		[Address(RVA = "0x1036CF0", Offset = "0x1036CF0", VA = "0x1036CF0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C4E")]
		[Address(RVA = "0x1036DC8", Offset = "0x1036DC8", VA = "0x1036DC8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005C4F")]
		[Address(RVA = "0x1036D2C", Offset = "0x1036D2C", VA = "0x1036D2C")]
		private void DoPlayBackSpeed()
		{
		}

		[Token(Token = "0x6005C50")]
		[Address(RVA = "0x1036DCC", Offset = "0x1036DCC", VA = "0x1036DCC")]
		public SetAnimatorPlayBackSpeed()
		{
		}
	}
}
