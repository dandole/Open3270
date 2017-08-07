#region License
/* 
 *
 * Open3270 - A C# implementation of the TN3270/TN3270E protocol
 *
 *   Copyright � 2004-2006 Michael Warriner. All rights reserved
 * 
 * This is free software; you can redistribute it and/or modify it
 * under the terms of the GNU Lesser General Public License as
 * published by the Free Software Foundation; either version 2.1 of
 * the License, or (at your option) any later version.
 *
 * This software is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with this software; if not, write to the Free
 * Software Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA
 * 02110-1301 USA, or see the FSF site: http://www.fsf.org.
 */
#endregion
using System;

namespace Open3270
{
	/// <summary>
	/// An exception occured navigating between two screens. TNRouteException can be generated by
	/// any code that is performing automatic navigation if a failure occurs.
	/// </summary>
	public class TNRouteException : Exception
	{
		private string mFrom;
		private string mTo;
		private string mText;
		/// <summary>
		/// Constructor for a routing exception. 
		/// </summary>
		/// <param name="from">Screen we are currently on</param>
		/// <param name="to">Scren we tried to move to</param>
		/// <param name="text">Error that occured when moving from 'from' to 'to'</param>
		/// <remarks>You can throw a routing exception in your client command handler if
		/// you what to indicate a routing error from your code.</remarks>
		public TNRouteException(string from, string to, string text)
		{
			mFrom = from;
			mTo	  = to;
			mText = text;
		}
		/// <summary>
		/// Displays a textual representation of the routing exception.
		/// </summary>
		/// <returns>The error string</returns>
		public override string ToString()
		{
			return "TNRouteException from screen '"+mFrom+"' to '"+mTo+"'. "+mText+".";
		}
	}
}