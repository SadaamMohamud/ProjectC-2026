namespace ProjectC_2026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            HideAllPanels();
            panel1.Visible = true;
            panel2.Visible = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        void HideAllPanels()
        {
            //panel1.Visible = false;
            //panel2.Visible = false;

            panel3.Visible = false;
            panel4.Visible = false;

            panel11.Visible = false;
            panel12.Visible = false;

            //attendece
            panel13.Visible = false;
            panel14.Visible = false;

            panel18.Visible = false;
            panel20.Visible = false;

            panel15.Visible = false;
            panel17.Visible = false;

            panel21.Visible = false;
            panel22.Visible = false;

            panel21.Visible = false;
            panel22.Visible = false;
            panel23.Visible = false;
            panel25.Visible = false;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if username or password is empty
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text))
            {
                lblmessage.ForeColor = System.Drawing.Color.Red;
                lblmessage.Text = "Please enter the data";
                return;
            }
            string username = textBox1.Text;
            string password = textBox2.Text;
            lblmessage.Text = " ";
            if (username == "Admin" && password == "Qurbac6")
            {
                lblmessage.ForeColor = System.Drawing.Color.Green;
                lblmessage.Text = "Login Succesfully";
                panel1.Visible = false;
                panel2.Visible = false;
                panel11.Visible = true;
                panel12.Visible = true;


            }
            else
            {
                lblmessage.ForeColor = System.Drawing.Color.Red;
                lblmessage.Text = "Invalid Username or Paasword";

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            lblmessage.Text = " ";

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Add(stid.Text, stname.Text, Department.Text);
            lblstudent.Text = "Student Added Succesfully";
            lblstudent.ForeColor = System.Drawing.Color.Green;
            panel15.Visible = true;
            panel17.Visible = true;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            stid.Text = " ";
            stname.Text = " ";
            Department.Text = " ";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(attenid.Text, dateTimePicker1.Text, status.Text);
            lblattendence.Text = "Attendence Succesfully";
            lblattendence.ForeColor = System.Drawing.Color.Green;
            panel18.Visible = true;
            panel20.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            attenid.Text = " ";
            dateTimePicker1.Text = " ";
            status.Text = " ";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Add(gradesid.Text, subject.Text, grades.Text);
            lblgrades.ForeColor = System.Drawing.Color.Green;
            lblgrades.Text = "Grades Succesfully";
            panel3.Visible = true;
            panel4.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
            panel23.Visible = true;
            panel25.Visible = true;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            gradesid.Text = " ";
            subject.Text = " ";
            grades.Text = " ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView4.Rows.Add(facultyid.Text, facultyname.Text);

            lblgrades.ForeColor = System.Drawing.Color.Green;
            lblgrades.Text = "Succesfully Added";
            panel21.Visible = true;
            panel22.Visible = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            facultyid.Text = " ";
            facultyname.Text = " ";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dataGridView5.Rows.Add(course.Text, Hall.Text, dateTimePicker2.Text);
            schedule.Text = "Schedule succesfully";
            lblgrades.ForeColor = System.Drawing.Color.Green;
            panel13.Visible = true;
            panel14.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView6.Rows.Add(dname.Text);
            lbldepartm.Text = "Department Added";
            lblattendence.ForeColor = System.Drawing.Color.Green;
            panel13.Visible = true;
            panel14.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.RemoveAt(e.RowIndex);
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView6.Rows.RemoveAt(e.RowIndex);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Rows.RemoveAt(e.RowIndex);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView3.Rows.RemoveAt(e.RowIndex);
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView4.Rows.RemoveAt(e.RowIndex);
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView5.Rows.RemoveAt(e.RowIndex);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //HideAllPanels();
            //panel11.Visible = true;
            //panel12.Visible = true;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //HideAllPanels();
            //panel3.Visible = true;
            //panel4.Visible = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //HideAllPanels();
            //panel13.Visible = true;
            //panel14.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //HideAllPanels();
            //panel18.Visible = true;
            //panel20.Visible = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //HideAllPanels();
            //panel15.Visible = true;
            //panel17.Visible = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //HideAllPanels();
            //panel21.Visible = true;
            //panel22.Visible = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //HideAllPanels();
            //panel21.Visible = true;
            //panel22.Visible = true;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            dataGridView6.Rows.Add(dname.Text);
            panel13.Visible = true;
            panel14.Visible = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            dname.Clear();
        }
    }
}
