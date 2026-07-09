using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010A6")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3290", Offset = "0x5A3290")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3290", Offset = "0x5A3290")]
	public class RayCast2d : FsmStateAction
	{
		[Token(Token = "0x4004EAD")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ActionSection", RVA = "0x5E8528", Offset = "0x5E8528")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8528", Offset = "0x5E8528")]
		public FsmOwnerDefault fromGameObject;

		[Token(Token = "0x4004EAE")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8588", Offset = "0x5E8588")]
		public FsmVector2 fromPosition;

		[Token(Token = "0x4004EAF")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E85C0", Offset = "0x5E85C0")]
		public FsmVector2 direction;

		[Token(Token = "0x4004EB0")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E85F8", Offset = "0x5E85F8")]
		public Space space;

		[Token(Token = "0x4004EB1")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8630", Offset = "0x5E8630")]
		public FsmFloat distance;

		[Token(Token = "0x4004EB2")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8668", Offset = "0x5E8668")]
		public FsmInt minDepth;

		[Token(Token = "0x4004EB3")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E86A0", Offset = "0x5E86A0")]
		public FsmInt maxDepth;

		[Token(Token = "0x4004EB4")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E86D8", Offset = "0x5E86D8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E86D8", Offset = "0x5E86D8")]
		[Attribute(Name = "ActionSection", RVA = "0x5E86D8", Offset = "0x5E86D8")]
		public FsmEvent hitEvent;

		[Token(Token = "0x4004EB5")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E874C", Offset = "0x5E874C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E874C", Offset = "0x5E874C")]
		public FsmBool storeDidHit;

		[Token(Token = "0x4004EB6")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E879C", Offset = "0x5E879C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E879C", Offset = "0x5E879C")]
		public FsmGameObject storeHitObject;

		[Token(Token = "0x4004EB7")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E87EC", Offset = "0x5E87EC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E87EC", Offset = "0x5E87EC")]
		public FsmVector2 storeHitPoint;

		[Token(Token = "0x4004EB8")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E883C", Offset = "0x5E883C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E883C", Offset = "0x5E883C")]
		public FsmVector2 storeHitNormal;

		[Token(Token = "0x4004EB9")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E888C", Offset = "0x5E888C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E888C", Offset = "0x5E888C")]
		public FsmFloat storeHitDistance;

		[Token(Token = "0x4004EBA")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E88DC", Offset = "0x5E88DC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E88DC", Offset = "0x5E88DC")]
		public FsmFloat storeHitFraction;

		[Token(Token = "0x4004EBB")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E892C", Offset = "0x5E892C")]
		[Attribute(Name = "ActionSection", RVA = "0x5E892C", Offset = "0x5E892C")]
		public FsmInt repeatInterval;

		[Token(Token = "0x4004EBC")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E898C", Offset = "0x5E898C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E898C", Offset = "0x5E898C")]
		public FsmInt[] layerMask;

		[Token(Token = "0x4004EBD")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E89DC", Offset = "0x5E89DC")]
		public FsmBool invertMask;

		[Token(Token = "0x4004EBE")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "ActionSection", RVA = "0x5E8A14", Offset = "0x5E8A14")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8A14", Offset = "0x5E8A14")]
		public FsmColor debugColor;

		[Token(Token = "0x4004EBF")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8A74", Offset = "0x5E8A74")]
		public FsmBool debug;

		[Token(Token = "0x4004EC0")]
		[FieldOffset(Offset = "0xE8")]
		private Transform _transform;

		[Token(Token = "0x4004EC1")]
		[FieldOffset(Offset = "0xF0")]
		private int repeat;

		[Token(Token = "0x6006364")]
		[Address(RVA = "0xB40458", Offset = "0xB40458", VA = "0xB40458", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006365")]
		[Address(RVA = "0xB405B8", Offset = "0xB405B8", VA = "0xB405B8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006366")]
		[Address(RVA = "0xB40CC4", Offset = "0xB40CC4", VA = "0xB40CC4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006367")]
		[Address(RVA = "0xB4068C", Offset = "0xB4068C", VA = "0xB4068C")]
		private void DoRaycast()
		{
		}

		[Token(Token = "0x6006368")]
		[Address(RVA = "0xB40CDC", Offset = "0xB40CDC", VA = "0xB40CDC")]
		public RayCast2d()
		{
		}
	}
}
