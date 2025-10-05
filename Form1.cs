namespace TicketSyte
{
    public partial class Form1 : Form
    {
        private List<Movies> movies;
        private Ticket ticket;
        private Movies selectedMovie ;
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            movies = new List<Movies>
            {
                new Movies(1, "Heloo", new DateTime(2025, 10, 1, 19, 0, 0), 50.0),
                new Movies(2, "The Dark Night", new DateTime(2026, 10, 1, 21, 0, 0), 60.0),
                new Movies(3, "Mo", new DateTime(2024, 10, 2, 18, 30, 0), 55.0),
                new Movies(4, "The Unique", new DateTime(2026, 10, 2, 20, 30, 0), 45.0)
            };
            comboBox1.DataSource = movies;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            int choice = Convert.ToInt32(numericUpDown1.Value);
            selectedMovie = movies.FirstOrDefault(m => m.number == choice);
            labelPrice.Text = selectedMovie != null ? $"{selectedMovie.price} Dh" : "N/A";

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ticket = new Ticket(selectedMovie.number, selectedMovie.title, selectedMovie.showtime, selectedMovie.price, textBox1.Text);
            ticket.DisplayInfo();
            Form2 form2 = new Form2(ticket);
            form2.Show();
            this.Hide();

        }
    }
}
