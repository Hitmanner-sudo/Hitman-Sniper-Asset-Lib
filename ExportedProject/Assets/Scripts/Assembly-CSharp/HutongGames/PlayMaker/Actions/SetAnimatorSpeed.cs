using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EFF")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59AE80", Offset = "0x59AE80")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59AE80", Offset = "0x59AE80")]
	public class SetAnimatorSpeed : ComponentAction<Animator>
	{
		[Token(Token = "0x40046FB")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C8E6C", Offset = "0x5C8E6C")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8E6C", Offset = "0x5C8E6C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40046FC")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8F00", Offset = "0x5C8F00")]
		public FsmFloat speed;

		[Token(Token = "0x40046FD")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8F38", Offset = "0x5C8F38")]
		public bool everyFrame;

		[Token(Token = "0x6005C56")]
		[Address(RVA = "0x10373DC", Offset = "0x10373DC", VA = "0x10373DC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C57")]
		[Address(RVA = "0x10373E8", Offset = "0x10373E8", VA = "0x10373E8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C58")]
		[Address(RVA = "0x10374C0", Offset = "0x10374C0", VA = "0x10374C0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005C59")]
		[Address(RVA = "0x1037424", Offset = "0x1037424", VA = "0x1037424")]
		private void DoPlaybackSpeed()
		{
		}

		[Token(Token = "0x6005C5A")]
		[Address(RVA = "0x10374C4", Offset = "0x10374C4", VA = "0x10374C4")]
		public SetAnimatorSpeed()
		{
		}
	}
}
