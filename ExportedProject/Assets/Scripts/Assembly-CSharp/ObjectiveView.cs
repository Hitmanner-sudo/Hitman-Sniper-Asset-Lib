using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20006AF")]
public class ObjectiveView : View
{
	[Token(Token = "0x20006B0")]
	private enum State
	{
		[Token(Token = "0x400254A")]
		NONE = 0,
		[Token(Token = "0x400254B")]
		InProgress = 1,
		[Token(Token = "0x400254C")]
		Completed = 2,
		[Token(Token = "0x400254D")]
		Failed = 3
	}

	[Token(Token = "0x20006B1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595AD8", Offset = "0x595AD8")]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		[Token(Token = "0x400254E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ObjectiveView _003C_003E4__this;

		[Token(Token = "0x400254F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action tweenFinishAction;

		[Token(Token = "0x6002BD6")]
		[Address(RVA = "0x8CDF44", Offset = "0x8CDF44", VA = "0x8CDF44")]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[Token(Token = "0x6002BD7")]
		[Address(RVA = "0x8CDF4C", Offset = "0x8CDF4C", VA = "0x8CDF4C")]
		internal void _003CSetData_003Eb__0()
		{
		}
	}

	[Token(Token = "0x4002540")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private UILabel _description;

	[Token(Token = "0x4002541")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject _checkBoxSuccessTickGO;

	[Token(Token = "0x4002542")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GameObject _checkBoxFailedTickGO;

	[Token(Token = "0x4002543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private SoundContainer _failedSoundContainer;

	[Token(Token = "0x4002544")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private SoundContainer _completedSoundContainer;

	[Token(Token = "0x4002545")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UISprite[] _checkBoxSprites;

	[Token(Token = "0x4002546")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private TweenColor[] _tweenColors;

	[Token(Token = "0x4002547")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private TweenNumber _tweenNumber;

	[Token(Token = "0x4002548")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private State _state;

	[Token(Token = "0x6002BCD")]
	[Address(RVA = "0x9ED290", Offset = "0x9ED290", VA = "0x9ED290")]
	public float GetDescriptionWidth()
	{
		return default(float);
	}

	[Token(Token = "0x6002BCE")]
	[Address(RVA = "0x9ED3B8", Offset = "0x9ED3B8", VA = "0x9ED3B8")]
	public void SetData(string description, bool completed, bool failed, [Optional][DefaultParameterValue(0)] int toValue, [Optional][DefaultParameterValue(false)] bool useTweenNumber, [Optional] Action tweenFinishAction)
	{
	}

	[Token(Token = "0x6002BCF")]
	[Address(RVA = "0x9ED6FC", Offset = "0x9ED6FC", VA = "0x9ED6FC")]
	private void GoToInProgressState()
	{
	}

	[Token(Token = "0x6002BD0")]
	[Address(RVA = "0x9ED708", Offset = "0x9ED708", VA = "0x9ED708")]
	private void GoToFailedState()
	{
	}

	[Token(Token = "0x6002BD1")]
	[Address(RVA = "0x9ED7DC", Offset = "0x9ED7DC", VA = "0x9ED7DC")]
	private void GoToCompletedState()
	{
	}

	[Token(Token = "0x6002BD2")]
	[Address(RVA = "0x9ED594", Offset = "0x9ED594", VA = "0x9ED594")]
	private void UpdateVisual()
	{
	}

	[Token(Token = "0x6002BD3")]
	[Address(RVA = "0x9ED8B0", Offset = "0x9ED8B0", VA = "0x9ED8B0")]
	private void FlashColors()
	{
	}

	[Token(Token = "0x6002BD4")]
	[Address(RVA = "0x9EDA28", Offset = "0x9EDA28", VA = "0x9EDA28")]
	public UISprite GetLeftmostCheckboxBorder()
	{
		return null;
	}

	[Token(Token = "0x6002BD5")]
	[Address(RVA = "0x9EDB00", Offset = "0x9EDB00", VA = "0x9EDB00")]
	public ObjectiveView()
	{
	}
}
