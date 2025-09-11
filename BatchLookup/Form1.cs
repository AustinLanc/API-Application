using Newtonsoft.Json.Linq;
using System.Globalization;

namespace BatchLookup
{
    public partial class Form1 : Form
    {
        private readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        Dictionary<string, int> paddingMap = new Dictionary<string, int>()
        {
            { "qc", 15 },
            { "testing", 22 },
            { "retains", 9 },
            { "reminders", 12 },
            { "tests", 9 },
        };

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string route = radioButton1.Checked ? "qc"
                             : radioButton2.Checked ? "testing"
                             : "retains";

                string batch = textBox1.Text.Trim();

                if (string.IsNullOrEmpty(batch) && route != "retains")
                {
                    richTextBox1.Text = "Please enter a batch number";
                    return;
                }

                string apiUrl = $"http://mspnkc/api/{route}/{batch}";
                string response = await client.GetStringAsync(apiUrl);
                JObject json = JObject.Parse(response);
                JArray data = (JArray?)json["data"];

                richTextBox1.Clear();
                richTextBox1.Font = new Font("Consolas", 15);

                if (data == null || data.Count == 0)
                {
                    richTextBox1.Text = "No data found for batch";
                    return;
                }

                using (Font boldFont = new Font(richTextBox1.Font, FontStyle.Bold))
                using (Font regularFont = new Font(richTextBox1.Font, FontStyle.Regular))
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

                            richTextBox1.SelectionFont = boldFont;
                            richTextBox1.AppendText($"{niceName}:  ".PadLeft(paddingMap[route]));

                            richTextBox1.SelectionFont = regularFont;
                            richTextBox1.AppendText(valueToShow + "\n");
                        }

                        richTextBox1.AppendText("\n");
                    }
                }
            }
            catch (Exception ex)
            {
                richTextBox1.Text = ex.Message;
            }
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string route = "reminders";
                string batch = textBox2.Text.Trim();
                string apiUrl = $"http://mspnkc/api/{route}/{batch}";
                string response = await client.GetStringAsync(apiUrl);
                JObject json = JObject.Parse(response);
                JArray data = (JArray)json["data"];

                richTextBox2.Clear();
                richTextBox2.Font = new Font("Consolas", 15);

                if (data == null || data.Count == 0)
                {
                    richTextBox2.Text = "No reminders found";
                    return;
                }

                using (Font boldFont = new Font(richTextBox2.Font, FontStyle.Bold))
                using (Font regularFont = new Font(richTextBox2.Font, FontStyle.Regular))
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

                            richTextBox2.SelectionFont = boldFont;
                            richTextBox2.AppendText($"{niceName}:  ".PadLeft(paddingMap[route]));

                            richTextBox2.SelectionFont = regularFont;
                            richTextBox2.AppendText(valueToShow + "\n");
                        }
                        richTextBox2.AppendText("\n");
                    }
                }

                if (richTextBox2.Text == "")
                {
                    richTextBox2.Text = "No reminders found";
                }
            }
            catch (Exception ex)
            {
                richTextBox2.Text = ex.Message;
            }
        }
        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string route = "tests";
                string batch = textBox3.Text.Trim();
                string apiUrl = $"http://mspnkc/api/{route}/{batch}";
                string response = await client.GetStringAsync(apiUrl);
                JObject json = JObject.Parse(response);
                JArray data = (JArray)json["data"];

                richTextBox3.Clear();
                richTextBox3.Font = new Font("Consolas", 15);

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

                using (Font boldFont = new Font(richTextBox3.Font, FontStyle.Bold))
                using (Font regularFont = new Font(richTextBox3.Font, FontStyle.Regular))
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

                            richTextBox3.SelectionFont = boldFont;
                            richTextBox3.AppendText($"{niceName}:  ".PadLeft(paddingMap[route]));

                            richTextBox3.SelectionFont = regularFont;
                            richTextBox3.AppendText(valueToShow + "\n");
                        }

                        richTextBox3.AppendText("\n");
                    }
                }

                if (richTextBox3.Text == "" && batch != "")
                {
                    richTextBox3.Text = "No active tests for batch";
                }
                else if (richTextBox3.Text == "")
                {
                    richTextBox3.Text = "No active tests";
                }
            }
            catch (Exception ex)
            {
                richTextBox3.Text = ex.Message;
            }
        }
    }
}
