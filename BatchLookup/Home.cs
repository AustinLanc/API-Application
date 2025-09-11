using Newtonsoft.Json.Linq;
using System.Globalization;

namespace APIApp
{
    public partial class Home : Form
    {
        private readonly HttpClient client = new HttpClient();

        public Home()
        {
            InitializeComponent();
            searchBatchInput.Focus();
        }

        Dictionary<string, int> paddingMap = new Dictionary<string, int>()
        {
            { "qc", 15 },
            { "testing", 22 },
            { "retains", 9 },
            { "reminders", 12 },
            { "tests", 9 },
        };

        private async void searchSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string route = qcRouteOption.Checked ? "qc"
                             : testingRouteOption.Checked ? "testing"
                             : "retains";

                string batch = searchBatchInput.Text.Trim();

                if (string.IsNullOrEmpty(batch) && route != "retains")
                {
                    searchOutput.Text = "Please enter a batch number";
                    return;
                }

                string apiUrl = $"http://mspnkc/api/{route}/{batch}";
                string response = await client.GetStringAsync(apiUrl);
                JObject json = JObject.Parse(response);
                JArray data = (JArray?)json["data"];

                searchOutput.Clear();
                searchOutput.Font = new Font("Consolas", 15);

                if (data == null || data.Count == 0)
                {
                    searchOutput.Text = "No data found for batch";
                    return;
                }

                using (Font boldFont = new Font(searchOutput.Font, FontStyle.Bold))
                using (Font regularFont = new Font(searchOutput.Font, FontStyle.Regular))
                {
                    foreach (var item in data)
                    {
                        foreach (var prop in item.Children<JProperty>())
                        {
                            if (prop.Name == "id" || prop.Name == "notified")
                                continue;

                            string valueToShow = prop.Name == "due" && !string.IsNullOrWhiteSpace(prop.Value?.ToString())
                                ? DateTime.TryParse(prop.Value.ToString(), out DateTime dt) ? dt.ToString("yyyy-MM-dd") : prop.Value.ToString()
                                : prop.Value?.ToString() ?? "";

                            string niceName = System.Globalization.CultureInfo.CurrentCulture.TextInfo
                                                 .ToTitleCase(prop.Name.Replace("_", " ").Replace("-", " "));

                            searchOutput.SelectionFont = boldFont;
                            searchOutput.AppendText($"{niceName}:  ".PadLeft(paddingMap[route]));

                            searchOutput.SelectionFont = regularFont;
                            searchOutput.AppendText(valueToShow + "\n");
                        }

                        searchOutput.AppendText("\n");
                    }
                }
            }
            catch (Exception ex)
            {
                searchOutput.Text = ex.Message;
            }
        }
        private async void remindersSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string route = "reminders";
                string batch = reminderBatchInput.Text.Trim();
                string apiUrl = $"http://mspnkc/api/{route}/{batch}";
                string response = await client.GetStringAsync(apiUrl);
                JObject json = JObject.Parse(response);
                JArray data = (JArray)json["data"];

                reminderOutput.Clear();
                reminderOutput.Font = new Font("Consolas", 15);

                if (data == null || data.Count == 0)
                {
                    reminderOutput.Text = "No reminders found";
                    return;
                }

                using (Font boldFont = new Font(reminderOutput.Font, FontStyle.Bold))
                using (Font regularFont = new Font(reminderOutput.Font, FontStyle.Regular))
                {
                    foreach (var item in data)
                    {
                        foreach (var prop in item.Children<JProperty>())
                        {
                            if (prop.Name == "id" || prop.Name == "notified")
                                continue;

                            string valueToShow = prop.Name == "due" && !string.IsNullOrWhiteSpace(prop.Value?.ToString())
                                ? DateTime.TryParse(prop.Value.ToString(), out DateTime dt) ? dt.ToString("yyyy-MM-dd") : prop.Value.ToString()
                                : prop.Value?.ToString() ?? "";

                            string niceName = System.Globalization.CultureInfo.CurrentCulture.TextInfo
                                                 .ToTitleCase(prop.Name.Replace("_", " ").Replace("-", " "));

                            reminderOutput.SelectionFont = boldFont;
                            reminderOutput.AppendText($"{niceName}:  ".PadLeft(paddingMap[route]));

                            reminderOutput.SelectionFont = regularFont;
                            reminderOutput.AppendText(valueToShow + "\n");
                        }
                        reminderOutput.AppendText("\n");
                    }
                }

                if (reminderOutput.Text == "")
                {
                    reminderOutput.Text = "No reminders found";
                }
            }
            catch (Exception ex)
            {
                reminderOutput.Text = ex.Message;
            }
        }
        private async void testsSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string route = "tests";
                string batch = testsBatchInput.Text.Trim();
                string apiUrl = $"http://mspnkc/api/{route}/{batch}";
                string response = await client.GetStringAsync(apiUrl);
                JObject json = JObject.Parse(response);
                JArray data = (JArray)json["data"];

                testsOutput.Clear();
                testsOutput.Font = new Font("Consolas", 15);

                var testNameMap = new Dictionary<string, string>()
                {
                    { "copper-corrosion", "Copper Corrosion" },
                    { "oil-bleed-24", "Oil Bleed (24 hrs)" },
                    { "oil-bleed-30", "Oil Bleed (30 hrs)" },
                    { "oxidation", "Oxidation" },
                    { "pressure-bleed", "Pressure Bleed" },
                    { "rust", "Rust" },
                    { "rust-seawater", "Rust (Synthetic Seawater)" },
                    { "salt-fog", "Salt Fog" },
                    { "soak", "Soak Test" },
                    { "water-washout", "Water Washout" },
                };

                using (Font boldFont = new Font(testsOutput.Font, FontStyle.Bold))
                using (Font regularFont = new Font(testsOutput.Font, FontStyle.Regular))
                {
                    foreach (var item in data)
                    {
                        foreach (var prop in item.Children<JProperty>())
                        {
                            if (prop.Name == "id" || prop.Name == "notified")
                                continue;

                            string niceName = CultureInfo.CurrentCulture.TextInfo
                                                 .ToTitleCase(prop.Name.Replace("_", " ").Replace("-", " "));

                            string valueToShow = "";

                            if (prop.Name == "due")
                            {
                                DateTime utcDate = DateTime.Parse(prop.Value.ToString(), null, DateTimeStyles.AdjustToUniversal);
                                DateTime chicagoDate = TimeZoneInfo.ConvertTimeFromUtc(
                                    utcDate,
                                    TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time")
                                );
                                valueToShow = chicagoDate.ToString("yyyy-MM-dd hh:mm:ss tt");
                            }
                            else if (prop.Name == "test")
                            {
                                string rawTest = prop.Value.ToString();
                                valueToShow = testNameMap.ContainsKey(rawTest)
                                    ? testNameMap[rawTest]
                                    : CultureInfo.CurrentCulture.TextInfo
                                        .ToTitleCase(rawTest.Replace("_", " ").Replace("-", " "));
                            }
                            else
                            {
                                valueToShow = prop.Value.ToString();
                            }

                            testsOutput.SelectionFont = boldFont;
                            testsOutput.AppendText($"{niceName}:  ".PadLeft(paddingMap[route]));

                            testsOutput.SelectionFont = regularFont;
                            testsOutput.AppendText(valueToShow + "\n");
                        }

                        testsOutput.AppendText("\n");
                    }
                }

                if (testsOutput.Text == "" && batch != "")
                {
                    testsOutput.Text = "No active tests for batch";
                }
                else if (testsOutput.Text == "")
                {
                    testsOutput.Text = "No active tests";
                }
            }
            catch (Exception ex)
            {
                testsOutput.Text = ex.Message;
            }
        }
    }
}
