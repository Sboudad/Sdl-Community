﻿using System;
using System.Windows;

namespace Sdl.Community.XLIFF.Manager.Extensions
{
	public static class WindowsControlUtils
	{
		public static void ForWindowFromFrameworkElement(this object frameworkElement, Action<Window> action)
		{
			var element = frameworkElement as FrameworkElement;

			while (!(element is Window))
			{
				if (element == null)
					break;
				element = element.Parent as FrameworkElement;
			}

			action(element as Window);
		}
	}
}
