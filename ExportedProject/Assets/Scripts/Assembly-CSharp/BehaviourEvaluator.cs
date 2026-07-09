using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000E5")]
public class BehaviourEvaluator : MonoBehaviour
{
	[Token(Token = "0x4000528")]
	[FieldOffset(Offset = "0x18")]
	public string Icon;

	[Token(Token = "0x60006A8")]
	[Address(RVA = "0xC0FED0", Offset = "0xC0FED0", VA = "0xC0FED0", Slot = "4")]
	public virtual AIBehaviour Evaluate(EvaluationComponent evaluator)
	{
		return null;
	}

	[Token(Token = "0x60006A9")]
	[Address(RVA = "0xBFF1B0", Offset = "0xBFF1B0", VA = "0xBFF1B0", Slot = "5")]
	public virtual void CleanUp()
	{
	}

	[Token(Token = "0x60006AA")]
	[Address(RVA = "0xBFF264", Offset = "0xBFF264", VA = "0xBFF264")]
	public BehaviourEvaluator()
	{
	}
}
