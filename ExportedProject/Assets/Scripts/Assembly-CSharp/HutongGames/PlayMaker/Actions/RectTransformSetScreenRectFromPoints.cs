using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010FD")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A4FFC", Offset = "0x5A4FFC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A4FFC", Offset = "0x5A4FFC")]
	public class RectTransformSetScreenRectFromPoints : BaseUpdateAction
	{
		[Token(Token = "0x400506E")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EFBE8", Offset = "0x5EFBE8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EFBE8", Offset = "0x5EFBE8")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400506F")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EFC7C", Offset = "0x5EFC7C")]
		public FsmVector2 point1;

		[Token(Token = "0x4005070")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EFCC8", Offset = "0x5EFCC8")]
		[RequiredField]
		public FsmVector2 point2;

		[Token(Token = "0x4005071")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EFD14", Offset = "0x5EFD14")]
		public FsmBool normalized;

		[Token(Token = "0x4005072")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EFD4C", Offset = "0x5EFD4C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EFD4C", Offset = "0x5EFD4C")]
		public FsmRect storeScreenRect;

		[Token(Token = "0x4005073")]
		[FieldOffset(Offset = "0x78")]
		private GameObject cachedGameObject;

		[Token(Token = "0x4005074")]
		[FieldOffset(Offset = "0x80")]
		private RectTransform _rt;

		[Token(Token = "0x4005075")]
		[FieldOffset(Offset = "0x88")]
		private Canvas rootCanvas;

		[Token(Token = "0x4005076")]
		[FieldOffset(Offset = "0x90")]
		private RectTransform rootRectTransform;

		[Token(Token = "0x4005077")]
		[FieldOffset(Offset = "0x98")]
		private Camera canvasCamera;

		[Token(Token = "0x600650D")]
		[Address(RVA = "0x961ED4", Offset = "0x961ED4", VA = "0x961ED4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600650E")]
		[Address(RVA = "0x961F7C", Offset = "0x961F7C", VA = "0x961F7C")]
		private bool UpdateCache()
		{
			return default(bool);
		}

		[Token(Token = "0x600650F")]
		[Address(RVA = "0x96210C", Offset = "0x96210C", VA = "0x96210C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006510")]
		[Address(RVA = "0x96238C", Offset = "0x96238C", VA = "0x96238C", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6006511")]
		[Address(RVA = "0x962154", Offset = "0x962154", VA = "0x962154")]
		private void DoSetValues()
		{
		}

		[Token(Token = "0x6006512")]
		[Address(RVA = "0x962390", Offset = "0x962390", VA = "0x962390")]
		public RectTransformSetScreenRectFromPoints()
		{
		}
	}
}
