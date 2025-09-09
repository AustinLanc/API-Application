using Newtonsoft.Json.Linq;

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
                richTextBox1.Font = new Font("Consolas", 13);

                foreach (var item in data)
                {
                    foreach (var prop in item.Children<JProperty>())
                    {
                        // Convert field name from "pen_60x" -> "Pen 60x"
                        string niceName = System.Globalization.CultureInfo.CurrentCulture.TextInfo
                                          .ToTitleCase(prop.Name.Replace("_", " "));

                        string valueToShow = prop.Name == "date"
                            ? DateTime.Parse(prop.Value.ToString()).ToString("yyyy-MM-dd")
                            : prop.Value.ToString();

                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                        richTextBox1.AppendText(niceName.PadRight(20)); // 20 chars wide

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
                        richTextBox2.AppendText(niceName.PadRight(20)); // 20 chars wide

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
    }
}
