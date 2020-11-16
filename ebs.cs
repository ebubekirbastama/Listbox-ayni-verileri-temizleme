listBox1.DataSource = listBox1.Items.Cast<string>().GroupBy(s => s.Split('-').Last()).Select(x => x.First()).ToArray();
