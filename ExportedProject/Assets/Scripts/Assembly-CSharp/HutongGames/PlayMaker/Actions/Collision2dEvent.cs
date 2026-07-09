using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001090")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2BB0", Offset = "0x5A2BB0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2BB0", Offset = "0x5A2BB0")]
	public class Collision2dEvent : FsmStateAction
	{
		[Token(Token = "0x4004DE9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5198", Offset = "0x5E5198")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004DEA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E51D0", Offset = "0x5E51D0")]
		public Collision2DType collision;

		[Token(Token = "0x4004DEB")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5208", Offset = "0x5E5208")]
		public FsmBool ignoreDisabled;

		[Token(Token = "0x4004DEC")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E5240", Offset = "0x5E5240")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5240", Offset = "0x5E5240")]
		public FsmString collideTag;

		[Token(Token = "0x4004DED")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5290", Offset = "0x5E5290")]
		public FsmEvent sendEvent;

		[Token(Token = "0x4004DEE")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E52C8", Offset = "0x5E52C8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E52C8", Offset = "0x5E52C8")]
		public FsmGameObject storeCollider;

		[Token(Token = "0x4004DEF")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5318", Offset = "0x5E5318")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E5318", Offset = "0x5E5318")]
		public FsmFloat storeForce;

		[Token(Token = "0x4004DF0")]
		[FieldOffset(Offset = "0x88")]
		private PlayMakerProxyBase cachedProxy;

		[Token(Token = "0x60062EB")]
		[Address(RVA = "0x8D86A4", Offset = "0x8D86A4", VA = "0x8D86A4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60062EC")]
		[Address(RVA = "0x8D8710", Offset = "0x8D8710", VA = "0x8D8710", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x60062ED")]
		[Address(RVA = "0x8D89D4", Offset = "0x8D89D4", VA = "0x8D89D4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60062EE")]
		[Address(RVA = "0x8D8CAC", Offset = "0x8D8CAC", VA = "0x8D8CAC", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x60062EF")]
		[Address(RVA = "0x8D8F38", Offset = "0x8D8F38", VA = "0x8D8F38")]
		private void UpdateCallback()
		{
		}

		[Token(Token = "0x60062F0")]
		[Address(RVA = "0x8D8824", Offset = "0x8D8824", VA = "0x8D8824")]
		private void GetProxyComponent()
		{
		}

		[Token(Token = "0x60062F1")]
		[Address(RVA = "0x8D8AE4", Offset = "0x8D8AE4", VA = "0x8D8AE4")]
		private void AddCallback()
		{
		}

		[Token(Token = "0x60062F2")]
		[Address(RVA = "0x8D8D70", Offset = "0x8D8D70", VA = "0x8D8D70")]
		private void RemoveCallback()
		{
		}

		[Token(Token = "0x60062F3")]
		[Address(RVA = "0x8D8F64", Offset = "0x8D8F64", VA = "0x8D8F64")]
		private void StoreCollisionInfo(Collision2D collisionInfo)
		{
		}

		[Token(Token = "0x60062F4")]
		[Address(RVA = "0x8D8FE4", Offset = "0x8D8FE4", VA = "0x8D8FE4", Slot = "50")]
		public override void DoCollisionEnter2D(Collision2D collisionInfo)
		{
		}

		[Token(Token = "0x60062F5")]
		[Address(RVA = "0x8D9098", Offset = "0x8D9098", VA = "0x8D9098", Slot = "51")]
		public override void DoCollisionStay2D(Collision2D collisionInfo)
		{
		}

		[Token(Token = "0x60062F6")]
		[Address(RVA = "0x8D9150", Offset = "0x8D9150", VA = "0x8D9150", Slot = "52")]
		public override void DoCollisionExit2D(Collision2D collisionInfo)
		{
		}

		[Token(Token = "0x60062F7")]
		[Address(RVA = "0x8D9208", Offset = "0x8D9208", VA = "0x8D9208", Slot = "49")]
		public override void DoParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x60062F8")]
		[Address(RVA = "0x8D9008", Offset = "0x8D9008", VA = "0x8D9008")]
		private void CollisionEnter2D(Collision2D collisionInfo)
		{
		}

		[Token(Token = "0x60062F9")]
		[Address(RVA = "0x8D90BC", Offset = "0x8D90BC", VA = "0x8D90BC")]
		private void CollisionStay2D(Collision2D collisionInfo)
		{
		}

		[Token(Token = "0x60062FA")]
		[Address(RVA = "0x8D9174", Offset = "0x8D9174", VA = "0x8D9174")]
		private void CollisionExit2D(Collision2D collisionInfo)
		{
		}

		[Token(Token = "0x60062FB")]
		[Address(RVA = "0x8D922C", Offset = "0x8D922C", VA = "0x8D922C")]
		private void ParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x60062FC")]
		[Address(RVA = "0x8D92A8", Offset = "0x8D92A8", VA = "0x8D92A8", Slot = "61")]
		public override string ErrorCheck()
		{
			return null;
		}

		[Token(Token = "0x60062FD")]
		[Address(RVA = "0x8D92D8", Offset = "0x8D92D8", VA = "0x8D92D8")]
		public Collision2dEvent()
		{
		}
	}
}
