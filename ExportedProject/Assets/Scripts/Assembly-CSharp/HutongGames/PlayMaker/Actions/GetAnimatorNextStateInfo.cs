using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EE9")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A7A0", Offset = "0x59A7A0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A7A0", Offset = "0x59A7A0")]
	public class GetAnimatorNextStateInfo : FsmStateActionAnimatorBase
	{
		[Token(Token = "0x4004692")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6F10", Offset = "0x5C6F10")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C6F10", Offset = "0x5C6F10")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004693")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6FA4", Offset = "0x5C6FA4")]
		[RequiredField]
		public FsmInt layerIndex;

		[Token(Token = "0x4004694")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6FF0", Offset = "0x5C6FF0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C6FF0", Offset = "0x5C6FF0")]
		[Attribute(Name = "ActionSection", RVA = "0x5C6FF0", Offset = "0x5C6FF0")]
		public FsmString name;

		[Token(Token = "0x4004695")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C7064", Offset = "0x5C7064")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C7064", Offset = "0x5C7064")]
		public FsmInt nameHash;

		[Token(Token = "0x4004696")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C70B4", Offset = "0x5C70B4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C70B4", Offset = "0x5C70B4")]
		public FsmInt fullPathHash;

		[Token(Token = "0x4004697")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C7104", Offset = "0x5C7104")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C7104", Offset = "0x5C7104")]
		public FsmInt shortPathHash;

		[Token(Token = "0x4004698")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C7154", Offset = "0x5C7154")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C7154", Offset = "0x5C7154")]
		public FsmInt tagHash;

		[Token(Token = "0x4004699")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C71A4", Offset = "0x5C71A4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C71A4", Offset = "0x5C71A4")]
		public FsmBool isStateLooping;

		[Token(Token = "0x400469A")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C71F4", Offset = "0x5C71F4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C71F4", Offset = "0x5C71F4")]
		public FsmFloat length;

		[Token(Token = "0x400469B")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C7244", Offset = "0x5C7244")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C7244", Offset = "0x5C7244")]
		public FsmFloat normalizedTime;

		[Token(Token = "0x400469C")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C7294", Offset = "0x5C7294")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C7294", Offset = "0x5C7294")]
		public FsmInt loopCount;

		[Token(Token = "0x400469D")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C72E4", Offset = "0x5C72E4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C72E4", Offset = "0x5C72E4")]
		public FsmFloat currentLoopProgress;

		[Token(Token = "0x17000C16")]
		private Animator animator
		{
			[Token(Token = "0x6005BE2")]
			[Address(RVA = "0x105B61C", Offset = "0x105B61C", VA = "0x105B61C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005BE3")]
		[Address(RVA = "0x105B624", Offset = "0x105B624", VA = "0x105B624", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005BE4")]
		[Address(RVA = "0x105B658", Offset = "0x105B658", VA = "0x105B658", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005BE5")]
		[Address(RVA = "0x105B9C0", Offset = "0x105B9C0", VA = "0x105B9C0", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6005BE6")]
		[Address(RVA = "0x105B694", Offset = "0x105B694", VA = "0x105B694")]
		private void GetLayerInfo()
		{
		}

		[Token(Token = "0x6005BE7")]
		[Address(RVA = "0x105B9C4", Offset = "0x105B9C4", VA = "0x105B9C4")]
		public GetAnimatorNextStateInfo()
		{
		}
	}
}
