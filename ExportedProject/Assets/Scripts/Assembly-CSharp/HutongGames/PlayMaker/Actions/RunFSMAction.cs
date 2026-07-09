using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001170")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A792C", Offset = "0x5A792C")]
	public abstract class RunFSMAction : FsmStateAction
	{
		[Token(Token = "0x40052CE")]
		[FieldOffset(Offset = "0x50")]
		protected Fsm runFsm;

		[Token(Token = "0x60066E5")]
		[Address(RVA = "0xBA5A98", Offset = "0xBA5A98", VA = "0xBA5A98", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60066E6")]
		[Address(RVA = "0xBA5AA0", Offset = "0xBA5AA0", VA = "0xBA5AA0", Slot = "31")]
		public override bool Event(FsmEvent fsmEvent)
		{
			return default(bool);
		}

		[Token(Token = "0x60066E7")]
		[Address(RVA = "0xBA5ADC", Offset = "0xBA5ADC", VA = "0xBA5ADC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60066E8")]
		[Address(RVA = "0xBA5B48", Offset = "0xBA5B48", VA = "0xBA5B48", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60066E9")]
		[Address(RVA = "0xBA5B98", Offset = "0xBA5B98", VA = "0xBA5B98", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x60066EA")]
		[Address(RVA = "0xBA5BE8", Offset = "0xBA5BE8", VA = "0xBA5BE8", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x60066EB")]
		[Address(RVA = "0xBA5C38", Offset = "0xBA5C38", VA = "0xBA5C38", Slot = "46")]
		public override void DoTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60066EC")]
		[Address(RVA = "0xBA5C60", Offset = "0xBA5C60", VA = "0xBA5C60", Slot = "47")]
		public override void DoTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x60066ED")]
		[Address(RVA = "0xBA5C88", Offset = "0xBA5C88", VA = "0xBA5C88", Slot = "48")]
		public override void DoTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60066EE")]
		[Address(RVA = "0xBA5CB0", Offset = "0xBA5CB0", VA = "0xBA5CB0", Slot = "43")]
		public override void DoCollisionEnter(Collision collisionInfo)
		{
		}

		[Token(Token = "0x60066EF")]
		[Address(RVA = "0xBA5CD8", Offset = "0xBA5CD8", VA = "0xBA5CD8", Slot = "44")]
		public override void DoCollisionStay(Collision collisionInfo)
		{
		}

		[Token(Token = "0x60066F0")]
		[Address(RVA = "0xBA5D00", Offset = "0xBA5D00", VA = "0xBA5D00", Slot = "45")]
		public override void DoCollisionExit(Collision collisionInfo)
		{
		}

		[Token(Token = "0x60066F1")]
		[Address(RVA = "0xBA5D28", Offset = "0xBA5D28", VA = "0xBA5D28", Slot = "49")]
		public override void DoParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x60066F2")]
		[Address(RVA = "0xBA5D50", Offset = "0xBA5D50", VA = "0xBA5D50", Slot = "56")]
		public override void DoControllerColliderHit(ControllerColliderHit collisionInfo)
		{
		}

		[Token(Token = "0x60066F3")]
		[Address(RVA = "0xBA5D78", Offset = "0xBA5D78", VA = "0xBA5D78", Slot = "53")]
		public override void DoTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x60066F4")]
		[Address(RVA = "0xBA5DA0", Offset = "0xBA5DA0", VA = "0xBA5DA0", Slot = "54")]
		public override void DoTriggerStay2D(Collider2D other)
		{
		}

		[Token(Token = "0x60066F5")]
		[Address(RVA = "0xBA5DC8", Offset = "0xBA5DC8", VA = "0xBA5DC8", Slot = "55")]
		public override void DoTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x60066F6")]
		[Address(RVA = "0xBA5DF0", Offset = "0xBA5DF0", VA = "0xBA5DF0", Slot = "50")]
		public override void DoCollisionEnter2D(Collision2D collisionInfo)
		{
		}

		[Token(Token = "0x60066F7")]
		[Address(RVA = "0xBA5E18", Offset = "0xBA5E18", VA = "0xBA5E18", Slot = "51")]
		public override void DoCollisionStay2D(Collision2D collisionInfo)
		{
		}

		[Token(Token = "0x60066F8")]
		[Address(RVA = "0xBA5E40", Offset = "0xBA5E40", VA = "0xBA5E40", Slot = "52")]
		public override void DoCollisionExit2D(Collision2D collisionInfo)
		{
		}

		[Token(Token = "0x60066F9")]
		[Address(RVA = "0xBA5E68", Offset = "0xBA5E68", VA = "0xBA5E68", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x60066FA")]
		[Address(RVA = "0xBA5E84", Offset = "0xBA5E84", VA = "0xBA5E84", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x60066FB")]
		[Address(RVA = "0xBA5E98", Offset = "0xBA5E98", VA = "0xBA5E98", Slot = "62")]
		protected virtual void CheckIfFinished()
		{
		}

		[Token(Token = "0x60066FC")]
		[Address(RVA = "0xBA5A90", Offset = "0xBA5A90", VA = "0xBA5A90")]
		protected RunFSMAction()
		{
		}
	}
}
