using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000ED5")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A160", Offset = "0x59A160")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A160", Offset = "0x59A160")]
	public class GetAnimatorCurrentStateInfoIsTag : FsmStateActionAnimatorBase
	{
		[Token(Token = "0x400463C")]
		[FieldOffset(Offset = "0x78")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C5010", Offset = "0x5C5010")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C5010", Offset = "0x5C5010")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400463D")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C50A4", Offset = "0x5C50A4")]
		[RequiredField]
		public FsmInt layerIndex;

		[Token(Token = "0x400463E")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C50F0", Offset = "0x5C50F0")]
		public FsmString tag;

		[Token(Token = "0x400463F")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C5128", Offset = "0x5C5128")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C5128", Offset = "0x5C5128")]
		[Attribute(Name = "ActionSection", RVA = "0x5C5128", Offset = "0x5C5128")]
		public FsmBool tagMatch;

		[Token(Token = "0x4004640")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C519C", Offset = "0x5C519C")]
		public FsmEvent tagMatchEvent;

		[Token(Token = "0x4004641")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C51D4", Offset = "0x5C51D4")]
		public FsmEvent tagDoNotMatchEvent;

		[Token(Token = "0x17000C0A")]
		private Animator animator
		{
			[Token(Token = "0x6005B7F")]
			[Address(RVA = "0xDA2C2C", Offset = "0xDA2C2C", VA = "0xDA2C2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B80")]
		[Address(RVA = "0xDA2C34", Offset = "0xDA2C34", VA = "0xDA2C34", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B81")]
		[Address(RVA = "0xDA2C68", Offset = "0xDA2C68", VA = "0xDA2C68", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B82")]
		[Address(RVA = "0xDA2DD4", Offset = "0xDA2DD4", VA = "0xDA2DD4", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6005B83")]
		[Address(RVA = "0xDA2CA4", Offset = "0xDA2CA4", VA = "0xDA2CA4")]
		private void IsTag()
		{
		}

		[Token(Token = "0x6005B84")]
		[Address(RVA = "0xDA2DD8", Offset = "0xDA2DD8", VA = "0xDA2DD8")]
		public GetAnimatorCurrentStateInfoIsTag()
		{
		}
	}
}
