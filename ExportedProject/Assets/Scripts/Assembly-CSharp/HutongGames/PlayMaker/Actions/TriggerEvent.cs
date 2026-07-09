using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001089")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2914", Offset = "0x5A2914")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2914", Offset = "0x5A2914")]
	public class TriggerEvent : FsmStateAction
	{
		[Token(Token = "0x4004DCB")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4920", Offset = "0x5E4920")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004DCC")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4958", Offset = "0x5E4958")]
		public TriggerType trigger;

		[Token(Token = "0x4004DCD")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E4990", Offset = "0x5E4990")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4990", Offset = "0x5E4990")]
		public FsmString collideTag;

		[Token(Token = "0x4004DCE")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E49E0", Offset = "0x5E49E0")]
		public FsmEvent sendEvent;

		[Token(Token = "0x4004DCF")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E4A18", Offset = "0x5E4A18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4A18", Offset = "0x5E4A18")]
		public FsmGameObject storeCollider;

		[Token(Token = "0x4004DD0")]
		[FieldOffset(Offset = "0x78")]
		private PlayMakerProxyBase cachedProxy;

		[Token(Token = "0x60062BB")]
		[Address(RVA = "0xC9DE98", Offset = "0xC9DE98", VA = "0xC9DE98", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60062BC")]
		[Address(RVA = "0xC9DEF8", Offset = "0xC9DEF8", VA = "0xC9DEF8", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x60062BD")]
		[Address(RVA = "0xC9E158", Offset = "0xC9E158", VA = "0xC9E158", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60062BE")]
		[Address(RVA = "0xC9E3C0", Offset = "0xC9E3C0", VA = "0xC9E3C0", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x60062BF")]
		[Address(RVA = "0xC9E5DC", Offset = "0xC9E5DC", VA = "0xC9E5DC")]
		private void UpdateCallback()
		{
		}

		[Token(Token = "0x60062C0")]
		[Address(RVA = "0xC9DFE8", Offset = "0xC9DFE8", VA = "0xC9DFE8")]
		private void GetProxyComponent()
		{
		}

		[Token(Token = "0x60062C1")]
		[Address(RVA = "0xC9E268", Offset = "0xC9E268", VA = "0xC9E268")]
		private void AddCallback()
		{
		}

		[Token(Token = "0x60062C2")]
		[Address(RVA = "0xC9E484", Offset = "0xC9E484", VA = "0xC9E484")]
		private void RemoveCallback()
		{
		}

		[Token(Token = "0x60062C3")]
		[Address(RVA = "0xC9E608", Offset = "0xC9E608", VA = "0xC9E608")]
		private void StoreCollisionInfo(Collider collisionInfo)
		{
		}

		[Token(Token = "0x60062C4")]
		[Address(RVA = "0xC9E648", Offset = "0xC9E648", VA = "0xC9E648", Slot = "46")]
		public override void DoTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60062C5")]
		[Address(RVA = "0xC9E6D0", Offset = "0xC9E6D0", VA = "0xC9E6D0", Slot = "47")]
		public override void DoTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x60062C6")]
		[Address(RVA = "0xC9E75C", Offset = "0xC9E75C", VA = "0xC9E75C", Slot = "48")]
		public override void DoTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60062C7")]
		[Address(RVA = "0xC9E66C", Offset = "0xC9E66C", VA = "0xC9E66C")]
		private void TriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60062C8")]
		[Address(RVA = "0xC9E6F4", Offset = "0xC9E6F4", VA = "0xC9E6F4")]
		private void TriggerStay(Collider other)
		{
		}

		[Token(Token = "0x60062C9")]
		[Address(RVA = "0xC9E780", Offset = "0xC9E780", VA = "0xC9E780")]
		private void TriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60062CA")]
		[Address(RVA = "0xC9E7E8", Offset = "0xC9E7E8", VA = "0xC9E7E8", Slot = "61")]
		public override string ErrorCheck()
		{
			return null;
		}

		[Token(Token = "0x60062CB")]
		[Address(RVA = "0xC9E818", Offset = "0xC9E818", VA = "0xC9E818")]
		public TriggerEvent()
		{
		}
	}
}
