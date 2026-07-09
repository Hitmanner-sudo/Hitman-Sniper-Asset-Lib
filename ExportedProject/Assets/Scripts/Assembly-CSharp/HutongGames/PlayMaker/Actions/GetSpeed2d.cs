using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200109A")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2ED0", Offset = "0x5A2ED0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2ED0", Offset = "0x5A2ED0")]
	public class GetSpeed2d : ComponentAction<Rigidbody2D>
	{
		[Token(Token = "0x4004E5B")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E6E90", Offset = "0x5E6E90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6E90", Offset = "0x5E6E90")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004E5C")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E6F24", Offset = "0x5E6F24")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6F24", Offset = "0x5E6F24")]
		public FsmFloat storeResult;

		[Token(Token = "0x4004E5D")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6F84", Offset = "0x5E6F84")]
		public bool everyFrame;

		[Token(Token = "0x6006328")]
		[Address(RVA = "0xC7F024", Offset = "0xC7F024", VA = "0xC7F024", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006329")]
		[Address(RVA = "0xC7F030", Offset = "0xC7F030", VA = "0xC7F030", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600632A")]
		[Address(RVA = "0xC7F144", Offset = "0xC7F144", VA = "0xC7F144", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600632B")]
		[Address(RVA = "0xC7F06C", Offset = "0xC7F06C", VA = "0xC7F06C")]
		private void DoGetSpeed()
		{
		}

		[Token(Token = "0x600632C")]
		[Address(RVA = "0xC7F148", Offset = "0xC7F148", VA = "0xC7F148")]
		public GetSpeed2d()
		{
		}
	}
}
