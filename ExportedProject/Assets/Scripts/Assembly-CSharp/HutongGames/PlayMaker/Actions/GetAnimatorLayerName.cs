using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EE5")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A660", Offset = "0x59A660")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A660", Offset = "0x59A660")]
	public class GetAnimatorLayerName : ComponentAction<Animator>
	{
		[Token(Token = "0x4004685")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6970", Offset = "0x5C6970")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C6970", Offset = "0x5C6970")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004686")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6A04", Offset = "0x5C6A04")]
		[RequiredField]
		public FsmInt layerIndex;

		[Token(Token = "0x4004687")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C6A50", Offset = "0x5C6A50")]
		[Attribute(Name = "ActionSection", RVA = "0x5C6A50", Offset = "0x5C6A50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6A50", Offset = "0x5C6A50")]
		[RequiredField]
		public FsmString layerName;

		[Token(Token = "0x6005BD0")]
		[Address(RVA = "0x105B17C", Offset = "0x105B17C", VA = "0x105B17C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005BD1")]
		[Address(RVA = "0x105B188", Offset = "0x105B188", VA = "0x105B188", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005BD2")]
		[Address(RVA = "0x105B23C", Offset = "0x105B23C", VA = "0x105B23C")]
		public GetAnimatorLayerName()
		{
		}
	}
}
