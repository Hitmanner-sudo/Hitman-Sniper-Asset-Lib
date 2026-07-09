using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011A9")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A90E4", Offset = "0x5A90E4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A90E4", Offset = "0x5A90E4")]
	public class LookAt : FsmStateAction
	{
		[Token(Token = "0x4005419")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC538", Offset = "0x5FC538")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400541A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC584", Offset = "0x5FC584")]
		public FsmGameObject targetObject;

		[Token(Token = "0x400541B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC5BC", Offset = "0x5FC5BC")]
		public FsmVector3 targetPosition;

		[Token(Token = "0x400541C")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC5F4", Offset = "0x5FC5F4")]
		public FsmVector3 upVector;

		[Token(Token = "0x400541D")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC62C", Offset = "0x5FC62C")]
		public FsmBool keepVertical;

		[Token(Token = "0x400541E")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TitleAttribute", RVA = "0x5FC664", Offset = "0x5FC664")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC664", Offset = "0x5FC664")]
		public FsmBool debug;

		[Token(Token = "0x400541F")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC6C4", Offset = "0x5FC6C4")]
		public FsmColor debugLineColor;

		[Token(Token = "0x4005420")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC6FC", Offset = "0x5FC6FC")]
		public bool everyFrame;

		[Token(Token = "0x4005421")]
		[FieldOffset(Offset = "0x90")]
		private GameObject go;

		[Token(Token = "0x4005422")]
		[FieldOffset(Offset = "0x98")]
		private GameObject goTarget;

		[Token(Token = "0x4005423")]
		[FieldOffset(Offset = "0xA0")]
		private Vector3 lookAtPos;

		[Token(Token = "0x4005424")]
		[FieldOffset(Offset = "0xAC")]
		private Vector3 lookAtPosWithVertical;

		[Token(Token = "0x60067F6")]
		[Address(RVA = "0x9DF200", Offset = "0x9DF200", VA = "0x9DF200", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60067F7")]
		[Address(RVA = "0x9DF2D0", Offset = "0x9DF2D0", VA = "0x9DF2D0", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x60067F8")]
		[Address(RVA = "0x9DF2F0", Offset = "0x9DF2F0", VA = "0x9DF2F0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60067F9")]
		[Address(RVA = "0x9DF4AC", Offset = "0x9DF4AC", VA = "0x9DF4AC", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x60067FA")]
		[Address(RVA = "0x9DF32C", Offset = "0x9DF32C", VA = "0x9DF32C")]
		private void DoLookAt()
		{
		}

		[Token(Token = "0x60067FB")]
		[Address(RVA = "0x9DF4B0", Offset = "0x9DF4B0", VA = "0x9DF4B0")]
		public bool UpdateLookAtPosition()
		{
			return default(bool);
		}

		[Token(Token = "0x60067FC")]
		[Address(RVA = "0x9DF69C", Offset = "0x9DF69C", VA = "0x9DF69C")]
		public Vector3 GetLookAtPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60067FD")]
		[Address(RVA = "0x9DF6A8", Offset = "0x9DF6A8", VA = "0x9DF6A8")]
		public Vector3 GetLookAtPositionWithVertical()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60067FE")]
		[Address(RVA = "0x9DF6B4", Offset = "0x9DF6B4", VA = "0x9DF6B4")]
		public LookAt()
		{
		}
	}
}
