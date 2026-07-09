using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Core
{
	[Token(Token = "0x2000C60")]
	public abstract class ScriptableObjectWithPath : ScriptableObject
	{
		[Token(Token = "0x6004D70")]
		public abstract string GetScriptableObjectPath();

		[Token(Token = "0x6004D71")]
		[Address(RVA = "0xB67D8C", Offset = "0xB67D8C", VA = "0xB67D8C")]
		protected ScriptableObjectWithPath()
		{
		}
	}
}
