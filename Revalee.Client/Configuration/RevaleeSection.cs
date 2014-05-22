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

using Revalee.Client.RecurringTasks;
using System.Configuration;

namespace Revalee.Client.Configuration
{
	internal class RevaleeSection : ConfigurationSection
	{
		public static RevaleeSection GetConfiguration()
		{
			return (RevaleeSection)System.Configuration.ConfigurationManager.GetSection("revalee");
		}

		[ConfigurationProperty("clientSettings", IsDefaultCollection = false, IsKey = false, IsRequired = false)]
		public ClientSettingsConfigurationElement ClientSettings
		{
			get { return (ClientSettingsConfigurationElement)this["clientSettings"]; }
		}

		[ConfigurationProperty("recurringTasks", IsDefaultCollection = true, IsKey = false, IsRequired = false)]
		[ConfigurationCollection(typeof(TaskConfigurationCollection), AddItemName = "task")]
		public TaskConfigurationCollection RecurringTasks
		{
			get { return (TaskConfigurationCollection)this["recurringTasks"]; }
		}
	}
}