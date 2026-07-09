using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EEC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A890", Offset = "0x59A890")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A890", Offset = "0x59A890")]
	public class GetAnimatorPlayBackTime : ComponentAction<Animator>
	{
		[Token(Token = "0x40046A4")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C75B8", Offset = "0x5C75B8")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C75B8", Offset = "0x5C75B8")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40046A5")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C764C", Offset = "0x5C764C")]
		[Attribute(Name = "ActionSection", RVA = "0x5C764C", Offset = "0x5C764C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C764C", Offset = "0x5C764C")]
		public FsmFloat playBackTime;

		[Token(Token = "0x40046A6")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C76D0", Offset = "0x5C76D0")]
		public bool everyFrame;

		[Token(Token = "0x6005BF3")]
		[Address(RVA = "0x105BC54", Offset = "0x105BC54", VA = "0x105BC54", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005BF4")]
		[Address(RVA = "0x105BC60", Offset = "0x105BC60", VA = "0x105BC60", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005BF5")]
		[Address(RVA = "0x105BD28", Offset = "0x105BD28", VA = "0x105BD28", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005BF6")]
		[Address(RVA = "0x105BC9C", Offset = "0x105BC9C", VA = "0x105BC9C")]
		private void GetPlayBackTime()
		{
		}

		[Token(Token = "0x6005BF7")]
		[Address(RVA = "0x105BD2C", Offset = "0x105BD2C", VA = "0x105BD2C")]
		public GetAnimatorPlayBackTime()
		{
		}
	}
}
