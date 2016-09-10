﻿using System.Configuration;

namespace Jass
{
	public static class Settings
	{
		public static string InputFolder
		{
			get { return ConfigurationManager.AppSettings["input.folder"]; }
		}

		public static string OutputFolder
		{
			get { return ConfigurationManager.AppSettings["output.folder"]; }
		}

		public static string GlobalsTemplate
		{
			get { return ConfigurationManager.AppSettings["globals.tpl"]; }
		}

		public static string ApiTemplate
		{
			get { return ConfigurationManager.AppSettings["api.tpl"]; }
		}

		public static string ClassTemplate
		{
			get { return ConfigurationManager.AppSettings["class.tpl"]; }
		}

	}
}
