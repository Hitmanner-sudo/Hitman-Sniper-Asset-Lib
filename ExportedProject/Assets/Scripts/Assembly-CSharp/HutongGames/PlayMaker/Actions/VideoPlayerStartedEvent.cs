using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012C3")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AE5C4", Offset = "0x5AE5C4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AE5C4", Offset = "0x5AE5C4")]
	public class VideoPlayerStartedEvent : FsmStateAction
	{
		[Token(Token = "0x40059EC")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x610D84", Offset = "0x610D84")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x610D84", Offset = "0x610D84")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40059ED")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x610E18", Offset = "0x610E18")]
		public FsmEvent onStartedEvent;

		[Token(Token = "0x40059EE")]
		[FieldOffset(Offset = "0x60")]
		private GameObject go;

		[Token(Token = "0x40059EF")]
		[FieldOffset(Offset = "0x68")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006D80")]
		[Address(RVA = "0x13D252C", Offset = "0x13D252C", VA = "0x13D252C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006D81")]
		[Address(RVA = "0x13D2534", Offset = "0x13D2534", VA = "0x13D2534", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006D82")]
		[Address(RVA = "0x13D26DC", Offset = "0x13D26DC", VA = "0x13D26DC", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006D83")]
		[Address(RVA = "0x13D27C4", Offset = "0x13D27C4", VA = "0x13D27C4")]
		private void OnStarted(VideoPlayer source)
		{
		}

		[Token(Token = "0x6006D84")]
		[Address(RVA = "0x13D2624", Offset = "0x13D2624", VA = "0x13D2624")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006D85")]
		[Address(RVA = "0x13D2864", Offset = "0x13D2864", VA = "0x13D2864")]
		public VideoPlayerStartedEvent()
		{
		}
	}
}
