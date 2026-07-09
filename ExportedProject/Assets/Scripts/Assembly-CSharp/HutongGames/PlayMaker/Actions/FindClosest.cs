using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FD6")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F0D0", Offset = "0x59F0D0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F0D0", Offset = "0x59F0D0")]
	public class FindClosest : FsmStateAction
	{
		[Token(Token = "0x4004A7F")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6934", Offset = "0x5D6934")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004A80")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6980", Offset = "0x5D6980")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D6980", Offset = "0x5D6980")]
		[RequiredField]
		public FsmString withTag;

		[Token(Token = "0x4004A81")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D69E0", Offset = "0x5D69E0")]
		public FsmBool ignoreOwner;

		[Token(Token = "0x4004A82")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6A18", Offset = "0x5D6A18")]
		public FsmBool mustBeVisible;

		[Token(Token = "0x4004A83")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D6A50", Offset = "0x5D6A50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6A50", Offset = "0x5D6A50")]
		public FsmGameObject storeObject;

		[Token(Token = "0x4004A84")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D6AA0", Offset = "0x5D6AA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6AA0", Offset = "0x5D6AA0")]
		public FsmFloat storeDistance;

		[Token(Token = "0x4004A85")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6AF0", Offset = "0x5D6AF0")]
		public bool everyFrame;

		[Token(Token = "0x6005F8E")]
		[Address(RVA = "0x954BEC", Offset = "0x954BEC", VA = "0x954BEC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F8F")]
		[Address(RVA = "0x954C6C", Offset = "0x954C6C", VA = "0x954C6C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005F90")]
		[Address(RVA = "0x95501C", Offset = "0x95501C", VA = "0x95501C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005F91")]
		[Address(RVA = "0x954CA8", Offset = "0x954CA8", VA = "0x954CA8")]
		private void DoFindClosest()
		{
		}

		[Token(Token = "0x6005F92")]
		[Address(RVA = "0x955020", Offset = "0x955020", VA = "0x955020")]
		public FindClosest()
		{
		}
	}
}
