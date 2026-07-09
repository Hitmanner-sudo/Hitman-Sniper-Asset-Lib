using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200106E")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A20D0", Offset = "0x5A20D0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A20D0", Offset = "0x5A20D0")]
	public class CollisionEvent : FsmStateAction
	{
		[Token(Token = "0x4004D25")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1A60", Offset = "0x5E1A60")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004D26")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1A98", Offset = "0x5E1A98")]
		public CollisionType collision;

		[Token(Token = "0x4004D27")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1AD0", Offset = "0x5E1AD0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E1AD0", Offset = "0x5E1AD0")]
		public FsmString collideTag;

		[Token(Token = "0x4004D28")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1B20", Offset = "0x5E1B20")]
		public FsmEvent sendEvent;

		[Token(Token = "0x4004D29")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E1B58", Offset = "0x5E1B58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1B58", Offset = "0x5E1B58")]
		public FsmGameObject storeCollider;

		[Token(Token = "0x4004D2A")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E1BA8", Offset = "0x5E1BA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1BA8", Offset = "0x5E1BA8")]
		public FsmFloat storeForce;

		[Token(Token = "0x4004D2B")]
		[FieldOffset(Offset = "0x80")]
		private PlayMakerProxyBase cachedProxy;

		[Token(Token = "0x6006222")]
		[Address(RVA = "0x8D92E0", Offset = "0x8D92E0", VA = "0x8D92E0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006223")]
		[Address(RVA = "0x8D9340", Offset = "0x8D9340", VA = "0x8D9340", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x6006224")]
		[Address(RVA = "0x8D9658", Offset = "0x8D9658", VA = "0x8D9658", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006225")]
		[Address(RVA = "0x8D9998", Offset = "0x8D9998", VA = "0x8D9998", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006226")]
		[Address(RVA = "0x8D9C8C", Offset = "0x8D9C8C", VA = "0x8D9C8C")]
		private void UpdateCallback()
		{
		}

		[Token(Token = "0x6006227")]
		[Address(RVA = "0x8D9470", Offset = "0x8D9470", VA = "0x8D9470")]
		private void GetProxyComponent()
		{
		}

		[Token(Token = "0x6006228")]
		[Address(RVA = "0x8D9768", Offset = "0x8D9768", VA = "0x8D9768")]
		private void AddCallback()
		{
		}

		[Token(Token = "0x6006229")]
		[Address(RVA = "0x8D9A5C", Offset = "0x8D9A5C", VA = "0x8D9A5C")]
		private void RemoveCallback()
		{
		}

		[Token(Token = "0x600622A")]
		[Address(RVA = "0x8D9CB8", Offset = "0x8D9CB8", VA = "0x8D9CB8")]
		private void StoreCollisionInfo(Collision collisionInfo)
		{
		}

		[Token(Token = "0x600622B")]
		[Address(RVA = "0x8D9D48", Offset = "0x8D9D48", VA = "0x8D9D48", Slot = "43")]
		public override void DoCollisionEnter(Collision collisionInfo)
		{
		}

		[Token(Token = "0x600622C")]
		[Address(RVA = "0x8D9DD0", Offset = "0x8D9DD0", VA = "0x8D9DD0", Slot = "44")]
		public override void DoCollisionStay(Collision collisionInfo)
		{
		}

		[Token(Token = "0x600622D")]
		[Address(RVA = "0x8D9E5C", Offset = "0x8D9E5C", VA = "0x8D9E5C", Slot = "45")]
		public override void DoCollisionExit(Collision collisionInfo)
		{
		}

		[Token(Token = "0x600622E")]
		[Address(RVA = "0x8D9EE8", Offset = "0x8D9EE8", VA = "0x8D9EE8", Slot = "56")]
		public override void DoControllerColliderHit(ControllerColliderHit collisionInfo)
		{
		}

		[Token(Token = "0x600622F")]
		[Address(RVA = "0x8D9FA8", Offset = "0x8D9FA8", VA = "0x8D9FA8", Slot = "49")]
		public override void DoParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x6006230")]
		[Address(RVA = "0x8D9D6C", Offset = "0x8D9D6C", VA = "0x8D9D6C")]
		private void CollisionEnter(Collision collisionInfo)
		{
		}

		[Token(Token = "0x6006231")]
		[Address(RVA = "0x8D9DF4", Offset = "0x8D9DF4", VA = "0x8D9DF4")]
		private void CollisionStay(Collision collisionInfo)
		{
		}

		[Token(Token = "0x6006232")]
		[Address(RVA = "0x8D9E80", Offset = "0x8D9E80", VA = "0x8D9E80")]
		private void CollisionExit(Collision collisionInfo)
		{
		}

		[Token(Token = "0x6006233")]
		[Address(RVA = "0x8D9F0C", Offset = "0x8D9F0C", VA = "0x8D9F0C")]
		private void ControllerColliderHit(ControllerColliderHit collisionInfo)
		{
		}

		[Token(Token = "0x6006234")]
		[Address(RVA = "0x8D9FCC", Offset = "0x8D9FCC", VA = "0x8D9FCC")]
		private void ParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x6006235")]
		[Address(RVA = "0x8DA048", Offset = "0x8DA048", VA = "0x8DA048", Slot = "61")]
		public override string ErrorCheck()
		{
			return null;
		}

		[Token(Token = "0x6006236")]
		[Address(RVA = "0x8DA078", Offset = "0x8DA078", VA = "0x8DA078")]
		public CollisionEvent()
		{
		}
	}
}
