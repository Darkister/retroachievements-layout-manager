﻿using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json;
using Retro_Achievement_Tracker.Controllers;
using Retro_Achievement_Tracker.Models;
using Retro_Achievement_Tracker.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retro_Achievement_Tracker
{
    public partial class RecentUnlocksWindow : Form
    {
        public RecentUnlocksWindow()
        {
            InitializeComponent();
        }
        protected override async void OnShown(EventArgs e)
        {
            base.OnShown(e);

            await InitializeAsync();
        }
        private async Task InitializeAsync()
        {
            await webView21.EnsureCoreWebView2Async(null);

            webView21.CoreWebView2.SetVirtualHostNameToFolderMapping("appassets.tracker", @"images", CoreWebView2HostResourceAccessKind.DenyCors);
            webView21.NavigateToString(Resources.recent_achievements_window);
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            RecentUnlocksController.Instance.IsOpen = false;
        }
        public void AssignJavaScriptVariables()
        {
            webView21.ExecuteScriptAsync("assignJavaScriptVariables();");
        }
        public void SetWindowBackgroundColor(string value)
        {
            webView21.ExecuteScriptAsync(string.Format("setWindowBackgroundColor(\"{0}\");", value));
        }
        public void SetBorderBackgroundColor(string value)
        {
            webView21.ExecuteScriptAsync(string.Format("setBorderBackgroundColor(\"{0}\");", value));
        }
        public void SetSimpleFontFamily(FontFamily value)
        {
            int lineSpacing = value.GetLineSpacing(FontStyle.Regular) / value.GetEmHeight(FontStyle.Regular);

            webView21.ExecuteScriptAsync(string.Format("setSimpleFontFamily(\"{0}\", \"{1}\");", value.Name.Replace(":", "\\:"), (lineSpacing == 0 ? 1 : lineSpacing).ToString()));
        }
        public void SetSimpleFontColor(string value)
        {
            webView21.ExecuteScriptAsync(string.Format("setSimpleFontColor(\"{0}\");", value));
            SetLineColor(value);
        }
        public void SetSimpleFontOutline(string fontOutline, string borderOutline)
        {
            webView21.ExecuteScriptAsync(string.Format("setSimpleFontOutline(\"{0}\");", fontOutline));
            SetLineOutline(borderOutline);
        }
        public void EnableBorder()
        {
            webView21.ExecuteScriptAsync("enableBorder();");
        }
        public void EnableDescription()
        {
            webView21.ExecuteScriptAsync("enableDescription();");
        }
        public void EnableDate()
        {
            webView21.ExecuteScriptAsync("enableDate();");
        }
        public void EnablePoints()
        {
            webView21.ExecuteScriptAsync("enablePoints();");
        }
        public void DisableBorder()
        {
            webView21.ExecuteScriptAsync("disableBorder();");
        }
        public void DisableDescription()
        {
            webView21.ExecuteScriptAsync("disableDescription();");
        }
        public void DisableDate()
        {
            webView21.ExecuteScriptAsync("disableDate();");
        }
        public void DisablePoints()
        {
            webView21.ExecuteScriptAsync("disablePoints();");
        }
        public void SetTitleFontFamily(FontFamily value)
        {
            int lineSpacing = value.GetLineSpacing(FontStyle.Regular) / value.GetEmHeight(FontStyle.Regular);

            webView21.ExecuteScriptAsync(string.Format("setTitleFontFamily(\"{0}\", \"{1}\");", value.Name.Replace(":", "\\:"), (lineSpacing == 0 ? 1 : lineSpacing).ToString()));
        }
        public void SetTitleColor(string value)
        {
            webView21.ExecuteScriptAsync(string.Format("setTitleColor(\"{0}\");", value));
        }
        public void SetTitleOutline(string value)
        {
            webView21.ExecuteScriptAsync(string.Format("setTitleOutlineColor(\"{0}\");", value));
        }
        public void SetDateFontFamily(FontFamily value)
        {
            int lineSpacing = value.GetLineSpacing(FontStyle.Regular) / value.GetEmHeight(FontStyle.Regular);

            webView21.ExecuteScriptAsync(string.Format("setDateFontFamily(\"{0}\", \"{1}\");", value.Name.Replace(":", "\\:"), (lineSpacing == 0 ? 1 : lineSpacing).ToString()));
        }
        public void SetDateColor(string value)
        {
            webView21.ExecuteScriptAsync(string.Format("setDateColor(\"{0}\");", value));
        }
        public void SetDateOutline(string value)
        {
            webView21.ExecuteScriptAsync(string.Format("setDateOutlineColor(\"{0}\");", value));
        }
        public void SetDescriptionFontFamily(FontFamily value)
        {
            int lineSpacing = value.GetLineSpacing(FontStyle.Regular) / value.GetEmHeight(FontStyle.Regular);

            webView21.ExecuteScriptAsync(string.Format("setDescriptionFontFamily(\"{0}\", \"{1}\");", value.Name.Replace(":", "\\:"), (lineSpacing == 0 ? 1 : lineSpacing).ToString()));
        }
        public void SetDescriptionColor(string value)
        {
            webView21.ExecuteScriptAsync(string.Format("setDescriptionColor(\"{0}\");", value));
        }
        public void SetDescriptionOutline(string value)
        {
            webView21.ExecuteScriptAsync(string.Format("setDescriptionOutlineColor(\"{0}\");", value));
        }
        public void SetPointsFontFamily(FontFamily value)
        {
            int lineSpacing = value.GetLineSpacing(FontStyle.Regular) / value.GetEmHeight(FontStyle.Regular);

            webView21.ExecuteScriptAsync(string.Format("setPointsFontFamily(\"{0}\", \"{1}\");", value.Name.Replace(":", "\\:"), (lineSpacing == 0 ? 1 : lineSpacing).ToString()));
        }
        public void SetPointsColor(string value)
        {
            webView21.ExecuteScriptAsync(string.Format("setPointsColor(\"{0}\");", value));
        }
        public void SetPointsOutline(string value)
        {
            webView21.ExecuteScriptAsync(string.Format("setPointsOutlineColor(\"{0}\");", value));
        }
        public void SetLineColor(string value)
        {
            webView21.ExecuteScriptAsync(string.Format("setLineColor(\"{0}\");", value));
        }
        public void SetLineOutline(string value)
        {
            webView21.ExecuteScriptAsync(string.Format("setLineOutline(\"{0}\");", value));
        }
        public void StartScrolling()
        {
            webView21.ExecuteScriptAsync("startScrolling();");
        }
        public void StopScrolling()
        {
            webView21.ExecuteScriptAsync("stopScrolling();");
        }
        public void ShowRecentAchievements()
        {
            webView21.ExecuteScriptAsync("showRecentAchievements();");
        }
        public void HideRecentAchievements()
        {
            webView21.ExecuteScriptAsync("hideRecentAchievements();");
        }
        public void ClearRecentAchievements()
        {
            webView21.ExecuteScriptAsync("clearRecentAchievements();");
        }
        public void AddAchievements(List<Achievement> achievements)
        {
            for (int i = achievements.Count - 1; i >= 0; i--)
            {
                webView21.ExecuteScriptAsync($"addAchievement({JsonConvert.SerializeObject(achievements[i])});");
            }
        }
        public void SetClientSize()
        {
            Invoke(new Action(() =>
            {
                ClientSize = new Size(511, 600);
            }));
        }
        private void NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            RecentUnlocksController.Instance.IsOpen = true;
            RecentUnlocksController.Instance.SetAchievements();
        }
    }
}