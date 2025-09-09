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

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string route = "";
                if (radioButton1.Checked)
                {
                    route = "qc";
                }
                else if (radioButton2.Checked)
                {
                    route = "testing";
                }
                else
                {
                    route = "retains";
                }
                string batch = textBox1.Text.Trim();
                if (string.IsNullOrEmpty(batch) && route != "retains")
                {
                    richTextBox1.Text = "Please enter a batch number";
                    return;
                }
                string apiUrl = $"http://mspnkc/api/{route}/{batch}";
                string response = await client.GetStringAsync(apiUrl);
                JObject json = JObject.Parse(response);
                JArray data = (JArray)json["data"];

                richTextBox1.Clear();
                richTextBox1.Font = new Font("Consolas", 15);

                foreach (var item in data)
                {
                    foreach (var prop in item.Children<JProperty>())
                    {
                        string niceName = System.Globalization.CultureInfo.CurrentCulture.TextInfo
                                          .ToTitleCase(prop.Name.Replace("_", " "));

                        string valueToShow;

                        if (prop.Name == "date")
                        {
                            string dateStr = prop.Value?.ToString()?.Trim() ?? "";

                            if (string.IsNullOrEmpty(dateStr))
                            {
                                valueToShow = "";
                            }
                            else if (dateStr.Contains("-"))
                            {
                                var dates = dateStr.Split('-').Select(d => d.Trim()).ToArray();
                                if (dates.Length == 2 &&
                                    DateTime.TryParse(dates[0], out DateTime startDate) &&
                                    DateTime.TryParse(dates[1], out DateTime endDate))
                                {
                                    valueToShow = $"{startDate:yyyy-MM-dd} - {endDate:yyyy-MM-dd}";
                                }
                                else
                                {
                                    valueToShow = dateStr;
                                }
                            }
                            else
                            {
                                if (DateTime.TryParse(dateStr, out DateTime singleDate))
                                {
                                    valueToShow = singleDate.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    valueToShow = dateStr;
                                }
                            }
                        }
                        else
                        {
                            valueToShow = prop.Value?.ToString() ?? "";
                        }

                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                        richTextBox1.AppendText(niceName.PadRight(20));

                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
                        richTextBox1.AppendText(valueToShow + "\n");
                    }

                    richTextBox1.AppendText("\n");
                }

                if (richTextBox1.Text == "")
                {
                    richTextBox1.Text = "No data found for batch";
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
                string batch = textBox2.Text.Trim();
                string apiUrl = $"http://mspnkc/api/reminders/{batch}";
                string response = await client.GetStringAsync(apiUrl);
                JObject json = JObject.Parse(response);
                JArray data = (JArray)json["data"];

                richTextBox2.Clear();
                richTextBox2.Font = new Font("Consolas", 15);


                foreach (var item in data)
                {
                    foreach (var prop in item.Children<JProperty>())
                    {
                        if (prop.Name == "id" || prop.Name == "notified")
                            continue;

                        string valueToShow = prop.Name == "due"
                            ? DateTime.Parse(prop.Value.ToString()).ToString("yyyy-MM-dd")
                            : prop.Value.ToString();

                        string niceName = System.Globalization.CultureInfo.CurrentCulture.TextInfo
                                             .ToTitleCase(prop.Name.Replace("_", " ").Replace("-", " "));

                        richTextBox2.SelectionFont = new Font(richTextBox2.Font, FontStyle.Bold);
                        richTextBox2.AppendText(niceName.PadRight(20));

                        richTextBox2.SelectionFont = new Font(richTextBox2.Font, FontStyle.Regular);
                        richTextBox2.AppendText(valueToShow + "\n");
                    }

                    richTextBox2.AppendText("\n");
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
                string batch = textBox3.Text.Trim();
                string apiUrl = $"http://mspnkc/api/tests/{batch}";
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
                        { "rust-seawater", "Rust (Synthetic Seawater)"},
                        { "salt-fog", "Salt Fog" },
                        { "soak", "Soak Test" },
                        { "water-washout", "Water Washout" },
                    };
                foreach (var item in data)
                {
                    foreach (var prop in item.Children<JProperty>())
                    {
                        if (prop.Name == "id" || prop.Name == "notified")
                            continue;

                        string niceName = System.Globalization.CultureInfo.CurrentCulture.TextInfo
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

                        richTextBox3.SelectionFont = new Font(richTextBox3.Font, FontStyle.Bold);
                        richTextBox3.AppendText(niceName.PadRight(20));

                        richTextBox3.SelectionFont = new Font(richTextBox3.Font, FontStyle.Regular);
                        richTextBox3.AppendText(valueToShow + "\n");
                    }

                    richTextBox3.AppendText("\n");
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
