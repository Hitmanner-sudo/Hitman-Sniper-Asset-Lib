using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EC1")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599BC0", Offset = "0x599BC0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599BC0", Offset = "0x599BC0")]
	public class SetAnimationTime : BaseAnimationAction
	{
		[Token(Token = "0x40045E2")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C347C", Offset = "0x5C347C")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C347C", Offset = "0x5C347C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40045E3")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C3510", Offset = "0x5C3510")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3510", Offset = "0x5C3510")]
		public FsmString animName;

		[Token(Token = "0x40045E4")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3570", Offset = "0x5C3570")]
		public FsmFloat time;

		[Token(Token = "0x40045E5")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C35A8", Offset = "0x5C35A8")]
		public bool normalized;

		[Token(Token = "0x40045E6")]
		[FieldOffset(Offset = "0x81")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C35E0", Offset = "0x5C35E0")]
		public bool everyFrame;

		[Token(Token = "0x6005B29")]
		[Address(RVA = "0x1034D80", Offset = "0x1034D80", VA = "0x1034D80", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B2A")]
		[Address(RVA = "0x1034D90", Offset = "0x1034D90", VA = "0x1034D90", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B2B")]
		[Address(RVA = "0x1034FA8", Offset = "0x1034FA8", VA = "0x1034FA8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005B2C")]
		[Address(RVA = "0x1034E00", Offset = "0x1034E00", VA = "0x1034E00")]
		private void DoSetAnimationTime(GameObject go)
		{
		}

		[Token(Token = "0x6005B2D")]
		[Address(RVA = "0x1034FF8", Offset = "0x1034FF8", VA = "0x1034FF8")]
		public SetAnimationTime()
		{
		}
	}
}
