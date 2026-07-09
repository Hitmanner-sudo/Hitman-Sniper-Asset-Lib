using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001075")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A22B0", Offset = "0x5A22B0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A22B0", Offset = "0x5A22B0")]
	public class GetParticleCollisionInfo : FsmStateAction
	{
		[Token(Token = "0x4004D59")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E2660", Offset = "0x5E2660")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E2660", Offset = "0x5E2660")]
		public FsmGameObject gameObjectHit;

		[Token(Token = "0x600625D")]
		[Address(RVA = "0x106712C", Offset = "0x106712C", VA = "0x106712C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600625E")]
		[Address(RVA = "0x1067134", Offset = "0x1067134", VA = "0x1067134")]
		private void StoreCollisionInfo()
		{
		}

		[Token(Token = "0x600625F")]
		[Address(RVA = "0x1067160", Offset = "0x1067160", VA = "0x1067160", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006260")]
		[Address(RVA = "0x1067188", Offset = "0x1067188", VA = "0x1067188")]
		public GetParticleCollisionInfo()
		{
		}
	}
}
