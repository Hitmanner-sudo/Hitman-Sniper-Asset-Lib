using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001160")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A72A4", Offset = "0x5A72A4")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A72A4", Offset = "0x5A72A4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A72A4", Offset = "0x5A72A4")]
	public class GetFsmVariable : FsmStateAction
	{
		[Token(Token = "0x400528A")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7600", Offset = "0x5F7600")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400528B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F764C", Offset = "0x5F764C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F764C", Offset = "0x5F764C")]
		public FsmString fsmName;

		[Token(Token = "0x400528C")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F769C", Offset = "0x5F769C")]
		[RequiredField]
		[HideTypeFilter]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F769C", Offset = "0x5F769C")]
		public FsmVar storeValue;

		[Token(Token = "0x400528D")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F770C", Offset = "0x5F770C")]
		public bool everyFrame;

		[Token(Token = "0x400528E")]
		[FieldOffset(Offset = "0x70")]
		private GameObject cachedGO;

		[Token(Token = "0x400528F")]
		[FieldOffset(Offset = "0x78")]
		private string cachedFsmName;

		[Token(Token = "0x4005290")]
		[FieldOffset(Offset = "0x80")]
		private PlayMakerFSM sourceFsm;

		[Token(Token = "0x4005291")]
		[FieldOffset(Offset = "0x88")]
		private INamedVariable sourceVariable;

		[Token(Token = "0x4005292")]
		[FieldOffset(Offset = "0x90")]
		private NamedVariable targetVariable;

		[Token(Token = "0x60066A4")]
		[Address(RVA = "0x1062B6C", Offset = "0x1062B6C", VA = "0x1062B6C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60066A5")]
		[Address(RVA = "0x1062BF0", Offset = "0x1062BF0", VA = "0x1062BF0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60066A6")]
		[Address(RVA = "0x1062EA4", Offset = "0x1062EA4", VA = "0x1062EA4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60066A7")]
		[Address(RVA = "0x1062C34", Offset = "0x1062C34", VA = "0x1062C34")]
		private void InitFsmVar()
		{
		}

		[Token(Token = "0x60066A8")]
		[Address(RVA = "0x1062E38", Offset = "0x1062E38", VA = "0x1062E38")]
		private void DoGetFsmVariable()
		{
		}

		[Token(Token = "0x60066A9")]
		[Address(RVA = "0x1062EA8", Offset = "0x1062EA8", VA = "0x1062EA8")]
		public GetFsmVariable()
		{
		}
	}
}
