using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001295")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD764", Offset = "0x5AD764")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD764", Offset = "0x5AD764")]
	public class VideoPlayerGetControlledAudioTrackMaxCount : FsmStateAction
	{
		[Token(Token = "0x4005902")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60D834", Offset = "0x60D834")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D834", Offset = "0x60D834")]
		[RequiredField]
		public FsmInt controlledAudioTrackMaxCount;

		[Token(Token = "0x4005903")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D894", Offset = "0x60D894")]
		public bool everyFrame;

		[Token(Token = "0x6006C7B")]
		[Address(RVA = "0x13CCE08", Offset = "0x13CCE08", VA = "0x13CCE08", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C7C")]
		[Address(RVA = "0x13CCE14", Offset = "0x13CCE14", VA = "0x13CCE14", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006C7D")]
		[Address(RVA = "0x13CCE84", Offset = "0x13CCE84", VA = "0x13CCE84", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006C7E")]
		[Address(RVA = "0x13CCE50", Offset = "0x13CCE50", VA = "0x13CCE50")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006C7F")]
		[Address(RVA = "0x13CCE88", Offset = "0x13CCE88", VA = "0x13CCE88")]
		public VideoPlayerGetControlledAudioTrackMaxCount()
		{
		}
	}
}
