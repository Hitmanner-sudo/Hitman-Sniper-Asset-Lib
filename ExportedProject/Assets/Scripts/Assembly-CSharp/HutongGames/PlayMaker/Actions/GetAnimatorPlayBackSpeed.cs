using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EEB")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A840", Offset = "0x59A840")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A840", Offset = "0x59A840")]
	public class GetAnimatorPlayBackSpeed : ComponentAction<Animator>
	{
		[Token(Token = "0x40046A1")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C748C", Offset = "0x5C748C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C748C", Offset = "0x5C748C")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40046A2")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C7520", Offset = "0x5C7520")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C7520", Offset = "0x5C7520")]
		[RequiredField]
		public FsmFloat playBackSpeed;

		[Token(Token = "0x40046A3")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C7580", Offset = "0x5C7580")]
		public bool everyFrame;

		[Token(Token = "0x6005BEE")]
		[Address(RVA = "0x105BB30", Offset = "0x105BB30", VA = "0x105BB30", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005BEF")]
		[Address(RVA = "0x105BB3C", Offset = "0x105BB3C", VA = "0x105BB3C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005BF0")]
		[Address(RVA = "0x105BC04", Offset = "0x105BC04", VA = "0x105BC04", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005BF1")]
		[Address(RVA = "0x105BB78", Offset = "0x105BB78", VA = "0x105BB78")]
		private void GetPlayBackSpeed()
		{
		}

		[Token(Token = "0x6005BF2")]
		[Address(RVA = "0x105BC08", Offset = "0x105BC08", VA = "0x105BC08")]
		public GetAnimatorPlayBackSpeed()
		{
		}
	}
}
