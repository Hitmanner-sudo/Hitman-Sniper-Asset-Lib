using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011B4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9478", Offset = "0x5A9478")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9478", Offset = "0x5A9478")]
	public class SmoothFollowAction : FsmStateAction
	{
		[Token(Token = "0x4005475")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD930", Offset = "0x5FD930")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005476")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD97C", Offset = "0x5FD97C")]
		public FsmGameObject targetObject;

		[Token(Token = "0x4005477")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD9B4", Offset = "0x5FD9B4")]
		public FsmFloat distance;

		[Token(Token = "0x4005478")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FDA00", Offset = "0x5FDA00")]
		[RequiredField]
		public FsmFloat height;

		[Token(Token = "0x4005479")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FDA4C", Offset = "0x5FDA4C")]
		public FsmFloat heightDamping;

		[Token(Token = "0x400547A")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FDA98", Offset = "0x5FDA98")]
		[RequiredField]
		public FsmFloat rotationDamping;

		[Token(Token = "0x400547B")]
		[FieldOffset(Offset = "0x80")]
		private GameObject cachedObject;

		[Token(Token = "0x400547C")]
		[FieldOffset(Offset = "0x88")]
		private Transform myTransform;

		[Token(Token = "0x400547D")]
		[FieldOffset(Offset = "0x90")]
		private GameObject cachedTarget;

		[Token(Token = "0x400547E")]
		[FieldOffset(Offset = "0x98")]
		private Transform targetTransform;

		[Token(Token = "0x6006841")]
		[Address(RVA = "0x847FC0", Offset = "0x847FC0", VA = "0x847FC0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006842")]
		[Address(RVA = "0x848020", Offset = "0x848020", VA = "0x848020", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x6006843")]
		[Address(RVA = "0x848040", Offset = "0x848040", VA = "0x848040", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6006844")]
		[Address(RVA = "0x848410", Offset = "0x848410", VA = "0x848410")]
		public SmoothFollowAction()
		{
		}
	}
}
