﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Mike Krüger" email="mike@icsharpcode.net"/>
//     <version>$Revision: 1965 $</version>
// </file>

using System;

namespace ICSharpCode.TextEditor.Gui.CompletionWindow
{
	public interface ICompletionData : IComparable
	{
		int ImageIndex {
			get;
		}
		
		string Text {
			get;
			set;
		}
		
		string Description {
			get;
			set;
		}
		
		/// <summary>
		/// Gets a priority value for the completion data item.
		/// When selecting items by their start characters, the item with the highest
		/// priority is selected first.
		/// </summary>
		double Priority {
			get;
		}
		
		/// <summary>
		/// Insert the element represented by the completion data into the text
		/// editor.
		/// </summary>
		/// <param name="textArea">TextArea to insert the completion data in.</param>
		/// <param name="ch">Character that should be inserted after the completion data.
		/// \0 when no character should be inserted.</param>
		/// <returns>Returns true when the insert action has processed the character
		/// <paramref name="ch"/>; false when the character was not processed.</returns>
		bool InsertAction(TextArea textArea, char ch);
	}
	
	public class DefaultCompletionData : ICompletionData
	{
		string text;
		string description;
		int imageIndex;
		
		public int ImageIndex {
			get {
				return imageIndex;
			}
		}
		
		public string Text {
			get {
				return text;
			}
			set {
				text = value;
			}
		}
		
		public string Description {
			get {
				return description;
			}
			set
			{
				description = value;	
			}
		}
		
		double priority;
		
		public double Priority {
			get {
				return priority;
			}
			set {
				priority = value;
			}
		}
		
		public virtual bool InsertAction(TextArea textArea, char ch)
		{
			textArea.InsertString(text);
			return false;
		}
		
		public DefaultCompletionData(string text, string description, int imageIndex)
		{
			this.text        = text;
			this.description = description;
			this.imageIndex  = imageIndex;
		}
		
		public int CompareTo(object obj)
		{
			if (obj == null || !(obj is DefaultCompletionData)) {
				return -1;
			}
			return text.CompareTo(((DefaultCompletionData)obj).Text);
		}
	}
}
