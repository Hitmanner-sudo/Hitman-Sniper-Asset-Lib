using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010B5")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3764", Offset = "0x5A3764")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3764", Offset = "0x5A3764")]
	public class Trigger2dEvent : FsmStateAction
	{
		[Token(Token = "0x4004F1A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA2BC", Offset = "0x5EA2BC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004F1B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA2F4", Offset = "0x5EA2F4")]
		public Trigger2DType trigger;

		[Token(Token = "0x4004F1C")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA32C", Offset = "0x5EA32C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EA32C", Offset = "0x5EA32C")]
		public FsmString collideTag;

		[Token(Token = "0x4004F1D")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA37C", Offset = "0x5EA37C")]
		public FsmEvent sendEvent;

		[Token(Token = "0x4004F1E")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EA3B4", Offset = "0x5EA3B4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA3B4", Offset = "0x5EA3B4")]
		public FsmGameObject storeCollider;

		[Token(Token = "0x4004F1F")]
		[FieldOffset(Offset = "0x78")]
		private PlayMakerProxyBase cachedProxy;

		[Token(Token = "0x60063AC")]
		[Address(RVA = "0xC9CC60", Offset = "0xC9CC60", VA = "0xC9CC60", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60063AD")]
		[Address(RVA = "0xC9CCC0", Offset = "0xC9CCC0", VA = "0xC9CCC0", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x60063AE")]
		[Address(RVA = "0xC9CF20", Offset = "0xC9CF20", VA = "0xC9CF20", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60063AF")]
		[Address(RVA = "0xC9D188", Offset = "0xC9D188", VA = "0xC9D188", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x60063B0")]
		[Address(RVA = "0xC9D3A4", Offset = "0xC9D3A4", VA = "0xC9D3A4")]
		private void UpdateCallback()
		{
		}

		[Token(Token = "0x60063B1")]
		[Address(RVA = "0xC9CDB0", Offset = "0xC9CDB0", VA = "0xC9CDB0")]
		private void GetProxyComponent()
		{
		}

		[Token(Token = "0x60063B2")]
		[Address(RVA = "0xC9D030", Offset = "0xC9D030", VA = "0xC9D030")]
		private void AddCallback()
		{
		}

		[Token(Token = "0x60063B3")]
		[Address(RVA = "0xC9D24C", Offset = "0xC9D24C", VA = "0xC9D24C")]
		private void RemoveCallback()
		{
		}

		[Token(Token = "0x60063B4")]
		[Address(RVA = "0xC9D3D0", Offset = "0xC9D3D0", VA = "0xC9D3D0")]
		private void StoreCollisionInfo(Collider2D collisionInfo)
		{
		}

		[Token(Token = "0x60063B5")]
		[Address(RVA = "0xC9D410", Offset = "0xC9D410", VA = "0xC9D410", Slot = "53")]
		public override void DoTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x60063B6")]
		[Address(RVA = "0xC9D498", Offset = "0xC9D498", VA = "0xC9D498", Slot = "54")]
		public override void DoTriggerStay2D(Collider2D other)
		{
		}

		[Token(Token = "0x60063B7")]
		[Address(RVA = "0xC9D524", Offset = "0xC9D524", VA = "0xC9D524", Slot = "55")]
		public override void DoTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x60063B8")]
		[Address(RVA = "0xC9D434", Offset = "0xC9D434", VA = "0xC9D434")]
		private void TriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x60063B9")]
		[Address(RVA = "0xC9D4BC", Offset = "0xC9D4BC", VA = "0xC9D4BC")]
		private void TriggerStay2D(Collider2D other)
		{
		}

		[Token(Token = "0x60063BA")]
		[Address(RVA = "0xC9D548", Offset = "0xC9D548", VA = "0xC9D548")]
		private void TriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x60063BB")]
		[Address(RVA = "0xC9D5B0", Offset = "0xC9D5B0", VA = "0xC9D5B0", Slot = "61")]
		public override string ErrorCheck()
		{
			return null;
		}

		[Token(Token = "0x60063BC")]
		[Address(RVA = "0xC9D5E0", Offset = "0xC9D5E0", VA = "0xC9D5E0")]
		public Trigger2dEvent()
		{
		}
	}
}
