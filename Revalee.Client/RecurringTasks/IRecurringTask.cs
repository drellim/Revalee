﻿#region License

/*
The MIT License (MIT)

Copyright (c) 2014 Sage Analytic Technologies, LLC

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

#endregion License

using System;

namespace Revalee.Client.RecurringTasks
{
	/// <summary>
	/// Represents a recurring task.
	/// </summary>
	public interface IRecurringTask
	{
		/// <summary>
		/// Gets the unique identifier of the scheduled task.
		/// </summary>
		string Identifier { get; }

		/// <summary>
		/// Gets the <see cref="T:Revalee.Client.RecurringTasks.PeriodicityType" /> of the scheduled task.
		/// </summary>
		PeriodicityType Periodicity { get; }

		/// <summary>
		/// Gets the <see cref="T:System.Int32" /> value of the scheduled hour (0-23).
		/// </summary>
		int HourOffset { get; }

		/// <summary>
		/// Gets the <see cref="T:System.Int32" /> value of the scheduled minute (0-59).
		/// /// </summary>
		int MinuteOffset { get; }

		/// <summary>
		/// Gets the <see cref="T:System.Uri" /> defining the target of the callback.
		/// </summary>
		Uri Url { get; }
	}
}