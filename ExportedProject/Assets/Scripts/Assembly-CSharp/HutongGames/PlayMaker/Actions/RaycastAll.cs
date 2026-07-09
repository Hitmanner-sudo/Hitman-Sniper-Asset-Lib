using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200107F")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A25D0", Offset = "0x5A25D0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A25D0", Offset = "0x5A25D0")]
	public class RaycastAll : FsmStateAction
	{
		[Token(Token = "0x4004D94")]
		[FieldOffset(Offset = "0x0")]
		public static RaycastHit[] RaycastAllHitInfo;

		[Token(Token = "0x4004D95")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3854", Offset = "0x5E3854")]
		public FsmOwnerDefault fromGameObject;

		[Token(Token = "0x4004D96")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E388C", Offset = "0x5E388C")]
		public FsmVector3 fromPosition;

		[Token(Token = "0x4004D97")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E38C4", Offset = "0x5E38C4")]
		public FsmVector3 direction;

		[Token(Token = "0x4004D98")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E38FC", Offset = "0x5E38FC")]
		public Space space;

		[Token(Token = "0x4004D99")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3934", Offset = "0x5E3934")]
		public FsmFloat distance;

		[Token(Token = "0x4004D9A")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E396C", Offset = "0x5E396C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E396C", Offset = "0x5E396C")]
		[Attribute(Name = "ActionSection", RVA = "0x5E396C", Offset = "0x5E396C")]
		public FsmEvent hitEvent;

		[Token(Token = "0x4004D9B")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E39E0", Offset = "0x5E39E0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E39E0", Offset = "0x5E39E0")]
		public FsmBool storeDidHit;

		[Token(Token = "0x4004D9C")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3A30", Offset = "0x5E3A30")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E3A30", Offset = "0x5E3A30")]
		[Attribute(Name = "ArrayEditorAttribute", RVA = "0x5E3A30", Offset = "0x5E3A30")]
		public FsmArray storeHitObjects;

		[Token(Token = "0x4004D9D")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E3AB4", Offset = "0x5E3AB4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3AB4", Offset = "0x5E3AB4")]
		public FsmVector3 storeHitPoint;

		[Token(Token = "0x4004D9E")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E3B04", Offset = "0x5E3B04")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3B04", Offset = "0x5E3B04")]
		public FsmVector3 storeHitNormal;

		[Token(Token = "0x4004D9F")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E3B54", Offset = "0x5E3B54")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3B54", Offset = "0x5E3B54")]
		public FsmFloat storeHitDistance;

		[Token(Token = "0x4004DA0")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3BA4", Offset = "0x5E3BA4")]
		[Attribute(Name = "ActionSection", RVA = "0x5E3BA4", Offset = "0x5E3BA4")]
		public FsmInt repeatInterval;

		[Token(Token = "0x4004DA1")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3C04", Offset = "0x5E3C04")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E3C04", Offset = "0x5E3C04")]
		public FsmInt[] layerMask;

		[Token(Token = "0x4004DA2")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3C54", Offset = "0x5E3C54")]
		public FsmBool invertMask;

		[Token(Token = "0x4004DA3")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "ActionSection", RVA = "0x5E3C8C", Offset = "0x5E3C8C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3C8C", Offset = "0x5E3C8C")]
		public FsmColor debugColor;

		[Token(Token = "0x4004DA4")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3CEC", Offset = "0x5E3CEC")]
		public FsmBool debug;

		[Token(Token = "0x4004DA5")]
		[FieldOffset(Offset = "0xD0")]
		private int repeat;

		[Token(Token = "0x600628D")]
		[Address(RVA = "0xB413F0", Offset = "0xB413F0", VA = "0xB413F0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600628E")]
		[Address(RVA = "0xB4156C", Offset = "0xB4156C", VA = "0xB4156C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600628F")]
		[Address(RVA = "0xB41AE4", Offset = "0xB41AE4", VA = "0xB41AE4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006290")]
		[Address(RVA = "0xB415B8", Offset = "0xB415B8", VA = "0xB415B8")]
		private void DoRaycast()
		{
		}

		[Token(Token = "0x6006291")]
		[Address(RVA = "0xB41AFC", Offset = "0xB41AFC", VA = "0xB41AFC")]
		public RaycastAll()
		{
		}
	}
}
