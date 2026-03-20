using KnacksackSolver;
namespace WinFormsApp1;


public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        int capacity, seed, itemCount;

        //capacity
        try
        {
            capacity = int.Parse(textBox3.Text);
        }
        catch
        {
            textBox3.BackColor = Color.Red;
            return;
        }

        textBox3.BackColor = Color.White;

        //seed

        try
        {
            seed = int.Parse(textBox2.Text);
        }
        catch
        {
            textBox2.BackColor = Color.Red;
            return;
        }

        textBox2.BackColor = Color.White;

        //number of items

        try
        {
            itemCount = int.Parse(textBox1.Text);
        }
        catch
        {
            textBox1.BackColor = Color.Red;
            return;
        }

        textBox1.BackColor = Color.White;

        KnapsackProblem problem = new KnapsackProblem(capacity, seed, itemCount);
        textBox5.Text = problem.ToString();

        var result = problem.Solve();
        textBox4.Text = result.ToString();

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
}
