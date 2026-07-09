using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001076")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2300", Offset = "0x5A2300")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2300", Offset = "0x5A2300")]
	public class GetRaycastAllInfo : FsmStateAction
	{
		[Token(Token = "0x4004D5A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E26B0", Offset = "0x5E26B0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E26B0", Offset = "0x5E26B0")]
		[Attribute(Name = "ArrayEditorAttribute", RVA = "0x5E26B0", Offset = "0x5E26B0")]
		public FsmArray storeHitObjects;

		[Token(Token = "0x4004D5B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E2734", Offset = "0x5E2734")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E2734", Offset = "0x5E2734")]
		[Attribute(Name = "ArrayEditorAttribute", RVA = "0x5E2734", Offset = "0x5E2734")]
		public FsmArray points;

		[Token(Token = "0x4004D5C")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ArrayEditorAttribute", RVA = "0x5E27B8", Offset = "0x5E27B8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E27B8", Offset = "0x5E27B8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E27B8", Offset = "0x5E27B8")]
		public FsmArray normals;

		[Token(Token = "0x4004D5D")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E283C", Offset = "0x5E283C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E283C", Offset = "0x5E283C")]
		[Attribute(Name = "ArrayEditorAttribute", RVA = "0x5E283C", Offset = "0x5E283C")]
		public FsmArray distances;

		[Token(Token = "0x4004D5E")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E28C0", Offset = "0x5E28C0")]
		public bool everyFrame;

		[Token(Token = "0x6006261")]
		[Address(RVA = "0x106804C", Offset = "0x106804C", VA = "0x106804C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006262")]
		[Address(RVA = "0x106805C", Offset = "0x106805C", VA = "0x106805C")]
		private void StoreRaycastAllInfo()
		{
		}

		[Token(Token = "0x6006263")]
		[Address(RVA = "0x10683D0", Offset = "0x10683D0", VA = "0x10683D0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006264")]
		[Address(RVA = "0x106840C", Offset = "0x106840C", VA = "0x106840C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006265")]
		[Address(RVA = "0x1068410", Offset = "0x1068410", VA = "0x1068410")]
		public GetRaycastAllInfo()
		{
		}
	}
}
