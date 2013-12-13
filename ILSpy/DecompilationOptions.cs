// Copyright (c) 2011 AlphaSierraPapa for the SharpDevelop Team
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this
// software and associated documentation files (the "Software"), to deal in the Software
// without restriction, including without limitation the rights to use, copy, modify, merge,
// publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
// to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or
// substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
// PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
// FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Threading;
using ICSharpCode.Decompiler;
using ICSharpCode.ILSpy.Options;

namespace ICSharpCode.ILSpy
{
	public interface ICacheXmlDocFindFailure
	{
		void ClearCache();

		bool HasLoadDocModFailedPreviously(Mono.Cecil.ModuleDefinition md);
		void FlagLoadDocModAsFail(Mono.Cecil.ModuleDefinition md);

		bool HasGetDocKeyFailedPreviously(string key);
		void FlagGetDocKeyAsFail(string key);
	}
	/// <summary>
	/// Options passed to the decompiler.
	/// </summary>
	public class DecompilationOptions
	{
		/// <summary>
		/// Gets whether a full decompilation (all members recursively) is desired.
		/// If this option is false, language bindings are allowed to show the only headers of the decompiled element's children.
		/// </summary>
		public bool FullDecompilation { get; set; }

		/// <summary>
		/// Gets/Sets the directory into which the project is saved.
		/// </summary>
		public string SaveAsProjectDirectory { get; set; }

		/// <summary>
		/// Gets the cancellation token that is used to abort the decompiler.
		/// </summary>
		/// <remarks>
		/// Decompilers should regularly call <c>options.CancellationToken.ThrowIfCancellationRequested();</c>
		/// to allow for cooperative cancellation of the decompilation task.
		/// </remarks>
		public CancellationToken CancellationToken { get; set; }

		/// <summary>
		/// Gets the settings for the decompiler.
		/// </summary>
		public DecompilerSettings DecompilerSettings { get; set; }

		/// <summary>
		/// Gets/sets an optional state of a decompiler text view.
		/// </summary>
		/// <remarks>
		/// This state is used to restore test view's state when decompilation is started by Go Back/Forward action.
		/// </remarks>
		public TextView.DecompilerTextViewState TextViewState { get; set; }

		public ICacheXmlDocFindFailure cacheOfFail { get; set; }
		public DecompilationOptions()
		{
			this.DecompilerSettings = DecompilerSettingsPanel.CurrentDecompilerSettings;
			this.cacheOfFail = new CacheXmlDocFindFailure_default();
		}
	}
	class CacheXmlDocFindFailure_default : ICacheXmlDocFindFailure
	{
		HashSet<string> m_hshFailedGetDocKey = new HashSet<string>();
		HashSet<string> m_hshFailedLoadDocKey = new HashSet<string>();
		int m_nGetDocSkipped;
		int m_nLoadDocSkipped;

		void CheckSignificantMilestone(int n, string name)
		{
			string str = n.ToString().Trim();
			// ignore 0 - 9
			if (str.Length == 1)
				return;
			// milestone is '30' or '500' but not '780'
			str = str.Replace("0", "");
			if (str.Length == 1)
				System.Diagnostics.Debug.WriteLine("Saved {0} {1}", n, name);

			return;
		}
		#region ICacheXmlDocFindFailure Members

		public void ClearCache()
		{
			m_hshFailedGetDocKey.Clear();
			m_hshFailedLoadDocKey.Clear();
			m_nGetDocSkipped = 0;
			m_nLoadDocSkipped = 0;
		}

		public bool HasLoadDocModFailedPreviously(Mono.Cecil.ModuleDefinition md)
		{
			string fqn = md.FullyQualifiedName;
			if (m_hshFailedLoadDocKey.Contains(fqn))
			{
				CheckSignificantMilestone(++m_nLoadDocSkipped, "LoadDocMod");
				return true;
			}
			return false;
		}

		public void FlagLoadDocModAsFail(Mono.Cecil.ModuleDefinition md)
		{
			string fqn = md.FullyQualifiedName;
			m_hshFailedLoadDocKey.Add(fqn);
		}

		public bool HasGetDocKeyFailedPreviously(string key)
		{
			if (m_hshFailedGetDocKey.Contains(key))
			{
				++m_nGetDocSkipped;
				return true;
			}
			return false;
		}

		public void FlagGetDocKeyAsFail(string key)
		{
			m_hshFailedGetDocKey.Add(key);
		}

		#endregion
	}
}
