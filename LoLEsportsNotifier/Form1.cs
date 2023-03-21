using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Microsoft.Toolkit.Uwp.Notifications;
using Newtonsoft.Json.Linq;

namespace LoLEsportsNotifier
{
    public partial class Form1 : Form
    {
        private Form _currentChildForm;
        private readonly Power _powerForm = new Power();
        private readonly Settings _settingsForm = new Settings();
        private string[] _checkmatches = Array.Empty<string>();
        private string[] _foundmatches = Array.Empty<string>();

        private const string LiveUrl = "https://lolesports.com/live";
        private string _slug;
        private string _parameter;

        private const int WmNclbuttondown = 0xA1;
        private const int HtCaption = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            ReleaseCapture();
            SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Properties.Resources.transparent.Save(Environment.CurrentDirectory + "\\transparent.png");
            bgw.RunWorkerAsync();
        }

        private void Open_child_form(Form form)
        {
            if (_currentChildForm == form)
            {
                _currentChildForm.Hide();
                _currentChildForm = null;
            }
            else if (_currentChildForm != form && _currentChildForm != null)
            {
                _currentChildForm.Hide();
                _currentChildForm = null;
                _currentChildForm = form;
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                form_panel.Controls.Add(form);
                form_panel.Tag = form;
                form.BringToFront();
                form.Show();
            }
            else if (_currentChildForm == null)
            {
                _currentChildForm = form;
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                form_panel.Controls.Add(form);
                form_panel.Tag = form;
                form.BringToFront();
                form.Show();
            }
        }

        private void Power_box_Click(object sender, EventArgs e)
        {
            Open_child_form(_powerForm);
        }

        private void Settings_box_Click(object sender, EventArgs e)
        {
            Open_child_form(_settingsForm);
        }

        private void Bgw_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var imageUri = Path.GetFullPath(@"transparent.png");

            while (true)
            {
                _checkmatches = Array.Empty<string>();
                System.Threading.Thread.Sleep(_settingsForm.CheckEachXSeconds * 1000);

                if (_settingsForm.GetDesktopNotifications)
                {
                    try
                    {
                        // Create the request
                        var request = (HttpWebRequest)WebRequest.Create("https://esports-api.lolesports.com/persisted/gw/getLive?hl=en-US");

                        // Set the request headers
                        request.Headers["x-api-key"] = "0TvQnueqKa5mxJntVWt0w4LpLfEkrV1Ta8rQBb9Z";
                        request.ContentType = "application/json";
                        var response = (HttpWebResponse)request.GetResponse();

                        using (var streamReader = new StreamReader(response.GetResponseStream()))
                        {
                            var responseData = streamReader.ReadToEnd();
                            var jsonData = JObject.Parse(responseData);
                            var scheduleData = (JObject)jsonData["data"]?["schedule"];
                            var eventsData = (JArray)scheduleData?["events"];

                            foreach (var evnt in eventsData)
                            {
                                var leagueData = (JObject)evnt["league"];
                                var streamsData = (JArray)evnt["streams"];
                                _slug = leagueData["slug"].ToString();
                                _parameter = streamsData[0]["parameter"].ToString();
                                Array.Resize(ref _checkmatches, _checkmatches.Length + 1);
                                _checkmatches[_checkmatches.Length - 1] = leagueData["name"].ToString();
                            }
                        }
                    }
                    catch
                    {
                        // ignored
                    }

                    if (_checkmatches != null && _checkmatches.Length != 0)
                    {
                        foreach (var match in _checkmatches)
                        {
                            if (!_foundmatches.Contains(match))
                            {
                                new ToastContentBuilder()
                                    .AddText("New Match Found:")
                                    .AddText(match)
                                    .AddAppLogoOverride(new Uri(imageUri))
                                    .AddButton(new ToastButton()
                                        .SetContent("Open Stream")
                                        .SetProtocolActivation(new Uri(LiveUrl + "/" + _slug + "/" + _parameter))
                                    )
                                    .Show();
                            }
                        }

                    }

                    _foundmatches = _checkmatches;
                }
            }
        }

        private void Power_box_MouseDown(object sender, MouseEventArgs e)
        {
            Open_child_form(_powerForm);

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
            }
        }

        private void Settings_box_MouseDown(object sender, MouseEventArgs e)
        {
            Open_child_form(_settingsForm);

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
            }
        }
    }
}
