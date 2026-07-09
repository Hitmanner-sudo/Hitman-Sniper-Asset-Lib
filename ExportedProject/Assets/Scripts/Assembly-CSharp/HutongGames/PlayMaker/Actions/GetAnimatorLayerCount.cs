using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EE4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A610", Offset = "0x59A610")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A610", Offset = "0x59A610")]
	public class GetAnimatorLayerCount : ComponentAction<Animator>
	{
		[Token(Token = "0x4004683")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6858", Offset = "0x5C6858")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C6858", Offset = "0x5C6858")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004684")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C68EC", Offset = "0x5C68EC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C68EC", Offset = "0x5C68EC")]
		[RequiredField]
		[Attribute(Name = "ActionSection", RVA = "0x5C68EC", Offset = "0x5C68EC")]
		public FsmInt layerCount;

		[Token(Token = "0x6005BCD")]
		[Address(RVA = "0x105B094", Offset = "0x105B094", VA = "0x105B094", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005BCE")]
		[Address(RVA = "0x105B09C", Offset = "0x105B09C", VA = "0x105B09C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005BCF")]
		[Address(RVA = "0x105B130", Offset = "0x105B130", VA = "0x105B130")]
		public GetAnimatorLayerCount()
		{
		}
	}
}
