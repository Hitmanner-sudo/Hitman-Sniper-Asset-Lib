using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000867")]
public class GestureSystemGraphs : MonoBehaviour
{
	[Token(Token = "0x2000868")]
	public enum GraphID
	{
		[Token(Token = "0x4002F2E")]
		None = 0,
		[Token(Token = "0x4002F2F")]
		RawDragMagnitude = 1,
		[Token(Token = "0x4002F30")]
		RawDragX = 2,
		[Token(Token = "0x4002F31")]
		RawDragY = 3,
		[Token(Token = "0x4002F32")]
		DragMagnitude = 4,
		[Token(Token = "0x4002F33")]
		DragX = 5,
		[Token(Token = "0x4002F34")]
		DragY = 6,
		[Token(Token = "0x4002F35")]
		DragSpeed = 7,
		[Token(Token = "0x4002F36")]
		DragSpeedMultiplier = 8,
		[Token(Token = "0x4002F37")]
		Max = 9
	}

	[Token(Token = "0x4002F2A")]
	[FieldOffset(Offset = "0x18")]
	private GestureSystem _gestureSystem;

	[Token(Token = "0x4002F2B")]
	[FieldOffset(Offset = "0x20")]
	private GraphID _activeGraphId;

	[Token(Token = "0x4002F2C")]
	[FieldOffset(Offset = "0x28")]
	public DebugGraph _activeGraph;

	[Token(Token = "0x170006FE")]
	public GraphID ActiveGraph
	{
		[Token(Token = "0x60036F0")]
		[Address(RVA = "0xDA0EAC", Offset = "0xDA0EAC", VA = "0xDA0EAC")]
		get
		{
			return default(GraphID);
		}
	}

	[Token(Token = "0x60036F1")]
	[Address(RVA = "0xDA0EB4", Offset = "0xDA0EB4", VA = "0xDA0EB4")]
	private void Start()
	{
	}

	[Token(Token = "0x60036F2")]
	[Address(RVA = "0xDA0F18", Offset = "0xDA0F18", VA = "0xDA0F18")]
	public void ToggleActiveGraph()
	{
	}

	[Token(Token = "0x60036F3")]
	[Address(RVA = "0xDA0F2C", Offset = "0xDA0F2C", VA = "0xDA0F2C")]
	public void ActivateGraph(GraphID id)
	{
	}

	[Token(Token = "0x60036F4")]
	[Address(RVA = "0xDA178C", Offset = "0xDA178C", VA = "0xDA178C")]
	private void AddRawDragMagnitude(FingerInput.FingerID finger, Vector2 rawDrag)
	{
	}

	[Token(Token = "0x60036F5")]
	[Address(RVA = "0xDA17CC", Offset = "0xDA17CC", VA = "0xDA17CC")]
	private void AddRawDragX(FingerInput.FingerID finger, Vector2 rawDrag)
	{
	}

	[Token(Token = "0x60036F6")]
	[Address(RVA = "0xDA17E8", Offset = "0xDA17E8", VA = "0xDA17E8")]
	private void AddRawDragY(FingerInput.FingerID finger, Vector2 rawDrag)
	{
	}

	[Token(Token = "0x60036F7")]
	[Address(RVA = "0xDA1808", Offset = "0xDA1808", VA = "0xDA1808")]
	private void AddDragMagnitude(FingerInput.FingerID finger, Vector2 drag)
	{
	}

	[Token(Token = "0x60036F8")]
	[Address(RVA = "0xDA1848", Offset = "0xDA1848", VA = "0xDA1848")]
	private void AddDragX(FingerInput.FingerID finger, Vector2 drag)
	{
	}

	[Token(Token = "0x60036F9")]
	[Address(RVA = "0xDA1864", Offset = "0xDA1864", VA = "0xDA1864")]
	private void AddDragY(FingerInput.FingerID finger, Vector2 drag)
	{
	}

	[Token(Token = "0x60036FA")]
	[Address(RVA = "0xDA1884", Offset = "0xDA1884", VA = "0xDA1884")]
	private void AddDragExtraInfo(FingerInput.FingerID finger, float dragSpeed, float dragSpeedMultiplier)
	{
	}

	[Token(Token = "0x60036FB")]
	[Address(RVA = "0xDA18D0", Offset = "0xDA18D0", VA = "0xDA18D0")]
	public GestureSystemGraphs()
	{
	}
}
