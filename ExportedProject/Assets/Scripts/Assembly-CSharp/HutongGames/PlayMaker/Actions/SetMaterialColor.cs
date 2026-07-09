using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200103F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1340", Offset = "0x5A1340")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1340", Offset = "0x5A1340")]
	public class SetMaterialColor : ComponentAction<Renderer>
	{
		[Token(Token = "0x4004C50")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE430", Offset = "0x5DE430")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5DE430", Offset = "0x5DE430")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004C51")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE4B4", Offset = "0x5DE4B4")]
		public FsmInt materialIndex;

		[Token(Token = "0x4004C52")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE4EC", Offset = "0x5DE4EC")]
		public FsmMaterial material;

		[Token(Token = "0x4004C53")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DE524", Offset = "0x5DE524")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE524", Offset = "0x5DE524")]
		public FsmString namedColor;

		[Token(Token = "0x4004C54")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE574", Offset = "0x5DE574")]
		[RequiredField]
		public FsmColor color;

		[Token(Token = "0x4004C55")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE5C0", Offset = "0x5DE5C0")]
		public bool everyFrame;

		[Token(Token = "0x600615A")]
		[Address(RVA = "0x103FD94", Offset = "0x103FD94", VA = "0x103FD94", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600615B")]
		[Address(RVA = "0x103FE14", Offset = "0x103FE14", VA = "0x103FE14", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600615C")]
		[Address(RVA = "0x104016C", Offset = "0x104016C", VA = "0x104016C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600615D")]
		[Address(RVA = "0x103FE50", Offset = "0x103FE50", VA = "0x103FE50")]
		private void DoSetMaterialColor()
		{
		}

		[Token(Token = "0x600615E")]
		[Address(RVA = "0x1040170", Offset = "0x1040170", VA = "0x1040170")]
		public SetMaterialColor()
		{
		}
	}
}
