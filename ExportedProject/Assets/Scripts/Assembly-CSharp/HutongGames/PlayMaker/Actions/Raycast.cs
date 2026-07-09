using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200107E")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2580", Offset = "0x5A2580")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2580", Offset = "0x5A2580")]
	public class Raycast : FsmStateAction
	{
		[Token(Token = "0x4004D81")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E33B8", Offset = "0x5E33B8")]
		public FsmOwnerDefault fromGameObject;

		[Token(Token = "0x4004D82")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E33F0", Offset = "0x5E33F0")]
		public FsmVector3 fromPosition;

		[Token(Token = "0x4004D83")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3428", Offset = "0x5E3428")]
		public FsmVector3 direction;

		[Token(Token = "0x4004D84")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3460", Offset = "0x5E3460")]
		public Space space;

		[Token(Token = "0x4004D85")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3498", Offset = "0x5E3498")]
		public FsmFloat distance;

		[Token(Token = "0x4004D86")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E34D0", Offset = "0x5E34D0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E34D0", Offset = "0x5E34D0")]
		[Attribute(Name = "ActionSection", RVA = "0x5E34D0", Offset = "0x5E34D0")]
		public FsmEvent hitEvent;

		[Token(Token = "0x4004D87")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E3544", Offset = "0x5E3544")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3544", Offset = "0x5E3544")]
		public FsmBool storeDidHit;

		[Token(Token = "0x4004D88")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E3594", Offset = "0x5E3594")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3594", Offset = "0x5E3594")]
		public FsmGameObject storeHitObject;

		[Token(Token = "0x4004D89")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E35E4", Offset = "0x5E35E4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E35E4", Offset = "0x5E35E4")]
		public FsmVector3 storeHitPoint;

		[Token(Token = "0x4004D8A")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E3634", Offset = "0x5E3634")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3634", Offset = "0x5E3634")]
		public FsmVector3 storeHitNormal;

		[Token(Token = "0x4004D8B")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3684", Offset = "0x5E3684")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E3684", Offset = "0x5E3684")]
		public FsmFloat storeHitDistance;

		[Token(Token = "0x4004D8C")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E36D4", Offset = "0x5E36D4")]
		[Attribute(Name = "ActionSection", RVA = "0x5E36D4", Offset = "0x5E36D4")]
		public FsmInt repeatInterval;

		[Token(Token = "0x4004D8D")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3734", Offset = "0x5E3734")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E3734", Offset = "0x5E3734")]
		public FsmInt[] layerMask;

		[Token(Token = "0x4004D8E")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3784", Offset = "0x5E3784")]
		public FsmBool invertMask;

		[Token(Token = "0x4004D8F")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "ActionSection", RVA = "0x5E37BC", Offset = "0x5E37BC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E37BC", Offset = "0x5E37BC")]
		public FsmColor debugColor;

		[Token(Token = "0x4004D90")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E381C", Offset = "0x5E381C")]
		public FsmBool debug;

		[Token(Token = "0x4004D91")]
		[FieldOffset(Offset = "0xD0")]
		private int repeat;

		[Token(Token = "0x4004D92")]
		[FieldOffset(Offset = "0xD8")]
		private GameObject cachedGameObject;

		[Token(Token = "0x4004D93")]
		[FieldOffset(Offset = "0xE0")]
		private Transform cachedTransform;

		[Token(Token = "0x6006288")]
		[Address(RVA = "0xB40CE4", Offset = "0xB40CE4", VA = "0xB40CE4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006289")]
		[Address(RVA = "0xB40E0C", Offset = "0xB40E0C", VA = "0xB40E0C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600628A")]
		[Address(RVA = "0xB413D0", Offset = "0xB413D0", VA = "0xB413D0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600628B")]
		[Address(RVA = "0xB40E58", Offset = "0xB40E58", VA = "0xB40E58")]
		private void DoRaycast()
		{
		}

		[Token(Token = "0x600628C")]
		[Address(RVA = "0xB413E8", Offset = "0xB413E8", VA = "0xB413E8")]
		public Raycast()
		{
		}
	}
}
