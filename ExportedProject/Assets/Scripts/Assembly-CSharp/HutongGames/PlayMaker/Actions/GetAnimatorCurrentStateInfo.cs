using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000ED3")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A0C0", Offset = "0x59A0C0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A0C0", Offset = "0x59A0C0")]
	public class GetAnimatorCurrentStateInfo : FsmStateActionAnimatorBase
	{
		[Token(Token = "0x400462A")]
		[FieldOffset(Offset = "0x78")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C49F0", Offset = "0x5C49F0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C49F0", Offset = "0x5C49F0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400462B")]
		[FieldOffset(Offset = "0x80")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4A84", Offset = "0x5C4A84")]
		public FsmInt layerIndex;

		[Token(Token = "0x400462C")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ActionSection", RVA = "0x5C4AD0", Offset = "0x5C4AD0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C4AD0", Offset = "0x5C4AD0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4AD0", Offset = "0x5C4AD0")]
		public FsmString name;

		[Token(Token = "0x400462D")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4B44", Offset = "0x5C4B44")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C4B44", Offset = "0x5C4B44")]
		public FsmInt nameHash;

		[Token(Token = "0x400462E")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C4B94", Offset = "0x5C4B94")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4B94", Offset = "0x5C4B94")]
		public FsmInt fullPathHash;

		[Token(Token = "0x400462F")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4BE4", Offset = "0x5C4BE4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C4BE4", Offset = "0x5C4BE4")]
		public FsmInt shortPathHash;

		[Token(Token = "0x4004630")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C4C34", Offset = "0x5C4C34")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4C34", Offset = "0x5C4C34")]
		public FsmInt tagHash;

		[Token(Token = "0x4004631")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C4C84", Offset = "0x5C4C84")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4C84", Offset = "0x5C4C84")]
		public FsmBool isStateLooping;

		[Token(Token = "0x4004632")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C4CD4", Offset = "0x5C4CD4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4CD4", Offset = "0x5C4CD4")]
		public FsmFloat length;

		[Token(Token = "0x4004633")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4D24", Offset = "0x5C4D24")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C4D24", Offset = "0x5C4D24")]
		public FsmFloat normalizedTime;

		[Token(Token = "0x4004634")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C4D74", Offset = "0x5C4D74")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4D74", Offset = "0x5C4D74")]
		public FsmInt loopCount;

		[Token(Token = "0x4004635")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C4DC4", Offset = "0x5C4DC4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4DC4", Offset = "0x5C4DC4")]
		public FsmFloat currentLoopProgress;

		[Token(Token = "0x17000C08")]
		private Animator animator
		{
			[Token(Token = "0x6005B73")]
			[Address(RVA = "0xDA2694", Offset = "0xDA2694", VA = "0xDA2694")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B74")]
		[Address(RVA = "0xDA269C", Offset = "0xDA269C", VA = "0xDA269C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B75")]
		[Address(RVA = "0xDA26D4", Offset = "0xDA26D4", VA = "0xDA26D4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B76")]
		[Address(RVA = "0xDA2A3C", Offset = "0xDA2A3C", VA = "0xDA2A3C", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6005B77")]
		[Address(RVA = "0xDA2710", Offset = "0xDA2710", VA = "0xDA2710")]
		private void GetLayerInfo()
		{
		}

		[Token(Token = "0x6005B78")]
		[Address(RVA = "0xDA2A40", Offset = "0xDA2A40", VA = "0xDA2A40")]
		public GetAnimatorCurrentStateInfo()
		{
		}
	}
}
