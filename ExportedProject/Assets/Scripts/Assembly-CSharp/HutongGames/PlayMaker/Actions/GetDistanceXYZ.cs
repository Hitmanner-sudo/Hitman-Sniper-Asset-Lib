using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FDC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F2B0", Offset = "0x59F2B0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F2B0", Offset = "0x59F2B0")]
	public class GetDistanceXYZ : ComponentAction<Transform>
	{
		[Token(Token = "0x4004A97")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7050", Offset = "0x5D7050")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004A98")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D709C", Offset = "0x5D709C")]
		public FsmGameObject target;

		[Token(Token = "0x4004A99")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D70D4", Offset = "0x5D70D4")]
		public FsmVector3 position;

		[Token(Token = "0x4004A9A")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D710C", Offset = "0x5D710C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D710C", Offset = "0x5D710C")]
		public FsmFloat storeDistance;

		[Token(Token = "0x4004A9B")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D715C", Offset = "0x5D715C")]
		public Space space;

		[Token(Token = "0x4004A9C")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7194", Offset = "0x5D7194")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D7194", Offset = "0x5D7194")]
		public FsmFloat storeXDistance;

		[Token(Token = "0x4004A9D")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D71E4", Offset = "0x5D71E4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D71E4", Offset = "0x5D71E4")]
		public FsmFloat storeYDistance;

		[Token(Token = "0x4004A9E")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D7234", Offset = "0x5D7234")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7234", Offset = "0x5D7234")]
		public FsmFloat storeZDistance;

		[Token(Token = "0x4004A9F")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7284", Offset = "0x5D7284")]
		public bool everyFrame;

		[Token(Token = "0x4004AA0")]
		[FieldOffset(Offset = "0xB0")]
		private GameObject cachedTargetGameObject;

		[Token(Token = "0x4004AA1")]
		[FieldOffset(Offset = "0xB8")]
		private Transform targetTransform;

		[Token(Token = "0x17000C39")]
		private Transform gameObjectTransform
		{
			[Token(Token = "0x6005FAB")]
			[Address(RVA = "0x105F6F0", Offset = "0x105F6F0", VA = "0x105F6F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005FAC")]
		[Address(RVA = "0x105F6F8", Offset = "0x105F6F8", VA = "0x105F6F8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005FAD")]
		[Address(RVA = "0x105F71C", Offset = "0x105F71C", VA = "0x105F71C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005FAE")]
		[Address(RVA = "0x105FA64", Offset = "0x105FA64", VA = "0x105FA64", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005FAF")]
		[Address(RVA = "0x105F758", Offset = "0x105F758", VA = "0x105F758")]
		private void DoGetDistanceXYZ()
		{
		}

		[Token(Token = "0x6005FB0")]
		[Address(RVA = "0x105FA68", Offset = "0x105FA68", VA = "0x105FA68")]
		public GetDistanceXYZ()
		{
		}
	}
}
