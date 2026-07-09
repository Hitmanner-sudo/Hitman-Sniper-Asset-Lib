using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001099")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2E80", Offset = "0x5A2E80")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2E80", Offset = "0x5A2E80")]
	public class GetRayCastHit2dInfo : FsmStateAction
	{
		[Token(Token = "0x4004E56")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6CF4", Offset = "0x5E6CF4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E6CF4", Offset = "0x5E6CF4")]
		public FsmGameObject gameObjectHit;

		[Token(Token = "0x4004E57")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E6D44", Offset = "0x5E6D44")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6D44", Offset = "0x5E6D44")]
		[Attribute(Name = "TitleAttribute", RVA = "0x5E6D44", Offset = "0x5E6D44")]
		public FsmVector2 point;

		[Token(Token = "0x4004E58")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E6DB8", Offset = "0x5E6DB8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6DB8", Offset = "0x5E6DB8")]
		public FsmVector3 normal;

		[Token(Token = "0x4004E59")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E6E08", Offset = "0x5E6E08")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6E08", Offset = "0x5E6E08")]
		public FsmFloat distance;

		[Token(Token = "0x4004E5A")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6E58", Offset = "0x5E6E58")]
		public bool everyFrame;

		[Token(Token = "0x6006323")]
		[Address(RVA = "0x1067E88", Offset = "0x1067E88", VA = "0x1067E88", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006324")]
		[Address(RVA = "0x1067E98", Offset = "0x1067E98", VA = "0x1067E98", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006325")]
		[Address(RVA = "0x1068040", Offset = "0x1068040", VA = "0x1068040", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006326")]
		[Address(RVA = "0x1067ED4", Offset = "0x1067ED4", VA = "0x1067ED4")]
		private void StoreRaycastInfo()
		{
		}

		[Token(Token = "0x6006327")]
		[Address(RVA = "0x1068044", Offset = "0x1068044", VA = "0x1068044")]
		public GetRayCastHit2dInfo()
		{
		}
	}
}
