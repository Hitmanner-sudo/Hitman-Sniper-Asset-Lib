using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Core
{
	[Token(Token = "0x2000C64")]
	public class ScriptableObjectUtility : ObjectUtility<ScriptableObject>
	{
		[Token(Token = "0x4003CBF")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, ScriptableObject> _scriptableObjectCache;

		[Token(Token = "0x6004D7E")]
		public static T Load<T>(string path, bool cache = false) where T : ScriptableObject
		{
			return null;
		}

		[Token(Token = "0x6004D7F")]
		[Address(RVA = "0xB67CB4", Offset = "0xB67CB4", VA = "0xB67CB4")]
		public ScriptableObjectUtility()
		{
		}
	}
}
