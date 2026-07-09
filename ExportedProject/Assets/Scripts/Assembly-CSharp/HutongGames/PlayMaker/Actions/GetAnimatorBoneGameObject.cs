using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000ED0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599FD0", Offset = "0x599FD0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599FD0", Offset = "0x599FD0")]
	public class GetAnimatorBoneGameObject : ComponentAction<Animator>
	{
		[Token(Token = "0x400461E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4588", Offset = "0x5C4588")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C4588", Offset = "0x5C4588")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400461F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C461C", Offset = "0x5C461C")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x5C461C", Offset = "0x5C461C")]
		public FsmEnum bone;

		[Token(Token = "0x4004620")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ActionSection", RVA = "0x5C46A0", Offset = "0x5C46A0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C46A0", Offset = "0x5C46A0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C46A0", Offset = "0x5C46A0")]
		public FsmGameObject boneGameObject;

		[Token(Token = "0x6005B67")]
		[Address(RVA = "0xDA2238", Offset = "0xDA2238", VA = "0xDA2238", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B68")]
		[Address(RVA = "0xDA22A4", Offset = "0xDA22A4", VA = "0xDA22A4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B69")]
		[Address(RVA = "0xDA23A8", Offset = "0xDA23A8", VA = "0xDA23A8")]
		public GetAnimatorBoneGameObject()
		{
		}
	}
}
