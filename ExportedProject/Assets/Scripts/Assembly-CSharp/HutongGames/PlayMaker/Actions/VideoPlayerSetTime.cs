using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012BE")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AE434", Offset = "0x5AE434")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AE434", Offset = "0x5AE434")]
	public class VideoPlayerSetTime : FsmStateAction
	{
		[Token(Token = "0x40059D5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6107F8", Offset = "0x6107F8")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x6107F8", Offset = "0x6107F8")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40059D6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x61088C", Offset = "0x61088C")]
		[RequiredField]
		public FsmFloat time;

		[Token(Token = "0x40059D7")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6108D8", Offset = "0x6108D8")]
		public FsmEvent canNotSetTime;

		[Token(Token = "0x40059D8")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x610910", Offset = "0x610910")]
		public bool everyFrame;

		[Token(Token = "0x40059D9")]
		[FieldOffset(Offset = "0x70")]
		private GameObject go;

		[Token(Token = "0x40059DA")]
		[FieldOffset(Offset = "0x78")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006D67")]
		[Address(RVA = "0x13D1B0C", Offset = "0x13D1B0C", VA = "0x13D1B0C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006D68")]
		[Address(RVA = "0x13D1B1C", Offset = "0x13D1B1C", VA = "0x13D1B1C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006D69")]
		[Address(RVA = "0x13D1D60", Offset = "0x13D1D60", VA = "0x13D1D60", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006D6A")]
		[Address(RVA = "0x13D1CA4", Offset = "0x13D1CA4", VA = "0x13D1CA4")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006D6B")]
		[Address(RVA = "0x13D1BEC", Offset = "0x13D1BEC", VA = "0x13D1BEC")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006D6C")]
		[Address(RVA = "0x13D1D64", Offset = "0x13D1D64", VA = "0x13D1D64")]
		public VideoPlayerSetTime()
		{
		}
	}
}
