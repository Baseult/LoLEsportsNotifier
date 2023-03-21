using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoLEsportsNotifier
{
    public partial class Power : Form
    {
        public Power()
        {
            InitializeComponent();
        }

        private const string LiveUrl = "https://lolesports.com/live";
        private string _slug = "";
        private string _parameter = "";
        private int _match = 0;
        private int _matchcount = 0;
        private bool _inback = false;

        private async void Load_data()
        {

            while (true)
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
                        var responseData = await streamReader.ReadToEndAsync();

                        // create a new JObject from the JSON string
                        var jsonData = JObject.Parse(responseData);

                        // access the schedule data
                        var scheduleData = (JObject)jsonData["data"]?["schedule"];

                        // access the events data
                        var eventsData = (JArray)scheduleData?["events"];

                        if (eventsData != null)
                        {
                            _matchcount = eventsData.Count;

                            if (_matchcount != 0)
                            {
                                // loop through the events
                                var evnt = eventsData[_match];

                                status.Text = evnt["state"]?.ToString();
                                time.Text = evnt["startTime"]?.ToString();

                                var leagueData = (JObject)evnt["league"];

                                // print the league info
                                _slug = leagueData?["slug"]?.ToString();
                                gameImage.ImageLocation = leagueData?["image"]?.ToString();
                                game.Text = leagueData?["name"]?.ToString() + " - " + (_match + 1) + " / " + _matchcount;

                                var matchData = (JObject)evnt["match"];

                                if (matchData != null)
                                {
                                    // access the teams data
                                    var teamsData = (JArray)matchData["teams"];
                                    teams.Text = teamsData?[0]["code"]?.ToString() + " vs " + teamsData?[1]["code"]?.ToString();

                                    // access the strategy data
                                    var strategyData = (JObject)matchData["strategy"];
                                    type.Text = strategyData?["type"]?.ToString() + " " + strategyData?["count"].ToString();

                                    // access the streams data
                                    var streamsData = (JArray)evnt["streams"];
                                    _parameter = streamsData[0]["parameter"].ToString();
                                }
                            }
                        }
                    }
                }
                catch
                {
                    // ignored
                }

                await Task.Delay(10000);
            }
        }


        private void Power_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Load_data();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Process.Start(LiveUrl + "/" + _slug + "/" + _parameter);
        }

        private void InfoImage_Click(object sender, EventArgs e)
        {
            if (!_inback)
            {
                gameImage.SendToBack();
                _inback = true;
            }
            else
            {
                gameImage.BringToFront();
                infoImage.BringToFront();
                _inback = false;
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (_match < _matchcount - 1)
            {
                _match++;
            }
            else
            {
                _match = 0;
            }

            Load_data();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (_match > 0)
            {
                _match--;
            }
            else
            {
                _match = _matchcount - 1;
            }

            Load_data();
        }

        private void Prev_MouseEnter(object sender, EventArgs e)
        {
            prev.ForeColor = Color.White;
        }

        private void Prev_MouseLeave(object sender, EventArgs e)
        {
            prev.ForeColor = Color.Yellow;
        }

        private void Next_MouseEnter(object sender, EventArgs e)
        {
            next.ForeColor = Color.White;
        }

        private void Next_MouseLeave(object sender, EventArgs e)
        {
            next.ForeColor = Color.Yellow;
        }

        private void Open_MouseEnter(object sender, EventArgs e)
        {
            open.ForeColor = Color.White;
        }

        private void Open_MouseLeave(object sender, EventArgs e)
        {
            open.ForeColor = Color.Chartreuse;
        }
    }
}
