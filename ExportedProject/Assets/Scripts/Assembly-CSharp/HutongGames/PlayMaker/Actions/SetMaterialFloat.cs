using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001040")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1390", Offset = "0x5A1390")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1390", Offset = "0x5A1390")]
	public class SetMaterialFloat : ComponentAction<Renderer>
	{
		[Token(Token = "0x4004C56")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE5F8", Offset = "0x5DE5F8")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5DE5F8", Offset = "0x5DE5F8")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004C57")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE67C", Offset = "0x5DE67C")]
		public FsmInt materialIndex;

		[Token(Token = "0x4004C58")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE6B4", Offset = "0x5DE6B4")]
		public FsmMaterial material;

		[Token(Token = "0x4004C59")]
		[FieldOffset(Offset = "0x80")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE6EC", Offset = "0x5DE6EC")]
		public FsmString namedFloat;

		[Token(Token = "0x4004C5A")]
		[FieldOffset(Offset = "0x88")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE738", Offset = "0x5DE738")]
		public FsmFloat floatValue;

		[Token(Token = "0x4004C5B")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE784", Offset = "0x5DE784")]
		public bool everyFrame;

		[Token(Token = "0x600615F")]
		[Address(RVA = "0x10401BC", Offset = "0x10401BC", VA = "0x10401BC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006160")]
		[Address(RVA = "0x1040238", Offset = "0x1040238", VA = "0x1040238", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006161")]
		[Address(RVA = "0x1040560", Offset = "0x1040560", VA = "0x1040560", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006162")]
		[Address(RVA = "0x1040274", Offset = "0x1040274", VA = "0x1040274")]
		private void DoSetMaterialFloat()
		{
		}

		[Token(Token = "0x6006163")]
		[Address(RVA = "0x1040564", Offset = "0x1040564", VA = "0x1040564")]
		public SetMaterialFloat()
		{
		}
	}
}
