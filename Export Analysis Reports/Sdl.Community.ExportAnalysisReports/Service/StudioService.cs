﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml;
using Sdl.Community.ExportAnalysisReports.Helpers;
using Sdl.Community.ExportAnalysisReports.Interfaces;
using Sdl.Community.ExportAnalysisReports.Model;
using Sdl.Community.Toolkit.Core.Services;
using Sdl.ProjectAutomation.Core;
using Sdl.ProjectAutomation.FileBased;

namespace Sdl.Community.ExportAnalysisReports.Service
{
	public class StudioService : IStudioService
	{
		public static readonly Log Log = Log.Instance;

		public string GetStudioProjectsPath()
		{
			try
			{
				var shortStudioVersion = GetInstalledStudioShortVersion();
				if (string.IsNullOrEmpty(shortStudioVersion))
				{
					return string.Empty;
				}

				var projectsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $@"Studio {shortStudioVersion}\Projects\projects.xml");
				return projectsPath;
			}
			catch (Exception ex)
			{
				Log.Logger.Error($"GetStudioProjectsPath method: {ex.Message}\n {ex.StackTrace}");
			}
			return string.Empty;
		}

		public ProjectInfo GetProjectInfo(string projectPath)
		{
			var fileBasedProject = new FileBasedProject(projectPath);
			var projectInfo = fileBasedProject?.GetProjectInfo();

			return projectInfo;
		}

		public BindingList<ProjectDetails> SetProjects(List<ProjectDetails> projects, BindingList<ProjectDetails> newProjectDetails)
		{
			if (newProjectDetails != null)
			{
				foreach (var project in projects)
				{
					newProjectDetails.Add(project);
				}
			}
			return newProjectDetails;
		}

		public void SetLanguagesForProject(ProjectDetails project, Dictionary<string, LanguageDirection> languages)
		{
			try
			{
				foreach (var language in languages)
				{
					project?.LanguagesForPoject?.Add(language.Value.TargetLang.EnglishName, false);
				}
			}
			catch (Exception ex)
			{
				Log.Logger.Error($"SetLanguagesForProject method: {ex.Message}\n {ex.StackTrace}");
			}
		}

		public void RemoveLanguages(Dictionary<string,bool> languagesDictionary, BindingList<LanguageDetails> languages)
		{
			// remove also the language corresponding to the single file project, when the "Is single file project" option is unchecked.
			if (languagesDictionary.Count > languages.Count)
			{
				var languagesToRemove = languagesDictionary.Where(item => !languages.Any(a => a.LanguageName.Equals(item.Key))).ToList();

				foreach (var languageToRemove in languagesToRemove)
				{
					languagesDictionary.Remove(languageToRemove.Key);
				}
			}
		}

		public Dictionary<string, LanguageDirection> LoadLanguageDirections(XmlDocument doc)
		{
			var languages = new Dictionary<string, LanguageDirection>();
			try
			{
				var languagesDirectionNode = doc.SelectNodes("/Project/LanguageDirections/LanguageDirection");

				if (languagesDirectionNode == null) return languages;
				foreach (var item in languagesDirectionNode)
				{
					var node = (XmlNode)item;
					if (node.Attributes == null) continue;
					var lang = new LanguageDirection
					{
						Guid = node.Attributes["Guid"].Value,
						TargetLang = CultureInfo.GetCultureInfo(node.Attributes["TargetLanguageCode"].Value)
					};
					if (!languages.ContainsKey(lang.Guid))
					{
						languages.Add(lang.Guid, lang);
					}
				}
			}
			catch (Exception ex)
			{
				Log.Logger.Error($"LoadLanguageDirections method: {ex.Message}\n {ex.StackTrace}");
			}
			return languages;
		}

		private string GetInstalledStudioShortVersion()
		{
			var studioService = new StudioVersionService();
			return studioService.GetStudioVersion()?.ShortVersion;
		}
	}
}
