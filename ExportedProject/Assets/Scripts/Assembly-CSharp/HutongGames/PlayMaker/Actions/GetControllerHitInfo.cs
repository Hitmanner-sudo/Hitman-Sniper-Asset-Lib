using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F4D")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C730", Offset = "0x59C730")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C730", Offset = "0x59C730")]
	public class GetControllerHitInfo : FsmStateAction
	{
		[Token(Token = "0x4004856")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CE7C4", Offset = "0x5CE7C4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE7C4", Offset = "0x5CE7C4")]
		public FsmGameObject gameObjectHit;

		[Token(Token = "0x4004857")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CE814", Offset = "0x5CE814")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE814", Offset = "0x5CE814")]
		public FsmVector3 contactPoint;

		[Token(Token = "0x4004858")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CE864", Offset = "0x5CE864")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE864", Offset = "0x5CE864")]
		public FsmVector3 contactNormal;

		[Token(Token = "0x4004859")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CE8B4", Offset = "0x5CE8B4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE8B4", Offset = "0x5CE8B4")]
		public FsmVector3 moveDirection;

		[Token(Token = "0x400485A")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CE904", Offset = "0x5CE904")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE904", Offset = "0x5CE904")]
		public FsmFloat moveLength;

		[Token(Token = "0x400485B")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CE954", Offset = "0x5CE954")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE954", Offset = "0x5CE954")]
		public FsmString physicsMaterialName;

		[Token(Token = "0x6005D95")]
		[Address(RVA = "0x105EDDC", Offset = "0x105EDDC", VA = "0x105EDDC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D96")]
		[Address(RVA = "0x105EDEC", Offset = "0x105EDEC", VA = "0x105EDEC", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x6005D97")]
		[Address(RVA = "0x105EE0C", Offset = "0x105EE0C", VA = "0x105EE0C")]
		private void StoreTriggerInfo()
		{
		}

		[Token(Token = "0x6005D98")]
		[Address(RVA = "0x105EF34", Offset = "0x105EF34", VA = "0x105EF34", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005D99")]
		[Address(RVA = "0x105EF5C", Offset = "0x105EF5C", VA = "0x105EF5C", Slot = "61")]
		public override string ErrorCheck()
		{
			return null;
		}

		[Token(Token = "0x6005D9A")]
		[Address(RVA = "0x105EF68", Offset = "0x105EF68", VA = "0x105EF68")]
		public GetControllerHitInfo()
		{
		}
	}
}
