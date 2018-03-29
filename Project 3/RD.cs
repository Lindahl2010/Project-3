using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_3
{
    public partial class RD : Form
    {
        List<Student> studentList = new List<Student>();

        public RD()
        {
            InitializeComponent();

            studentList = readData();
            label12.Text = studentList.Count.ToString();

        }

        private void RD_Load(object sender, EventArgs e)
        {
            stdntTypeCmbBox.Items.Add("Worker");
            stdntTypeCmbBox.Items.Add("Athlete");
            stdntTypeCmbBox.Items.Add("Scholar");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectTab(0);
        }

        private void backBtn2_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectTab(0);
            //label5.ResetText();
            //label6.Text = 
            //label7.Text = 
            //label8.Text = 
            //label9.Text = 
            //label10.Text = 
            //label13.Text = 
        }

        private void newRdntBtn_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectTab(1);
        }

        private void rdntSearchBtn_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectTab(2);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            int rent;
            int idNumber = Convert.ToInt32(idSearchBox.Text);

            try
            {
                var stdntFile =
                    from stdnt in studentList
                    where idNumber == stdnt.idNum
                    select stdnt;

                foreach (var stdnt in stdntFile)
                {
                    if (stdnt.idNum == idNumber)
                    {
                        rent = stdnt.rent;
                        label5.Text = Convert.ToString(stdnt.idNum);
                        label6.Text = stdnt.fname;
                        label7.Text = stdnt.lname;
                        label8.Text = Convert.ToString(stdnt.dormNum);
                        label9.Text = Convert.ToString(stdnt.floor);
                        label10.Text = rent.ToString("c");
                        label13.Text = stdnt.studentGroup;
                    }
                    else if (stdnt.idNum != idNumber)
                    {
                        label5.Hide();
                        label6.Hide();
                        label7.Hide();
                        label8.Hide();
                        label9.Hide();
                        label10.Hide();
                        label13.Hide();
                    }

                    idSearchBox.Clear();
                }
            }catch(Exception i)
            {
                Console.WriteLine(i.StackTrace);
                MessageBox.Show("Please Enter an ID Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void idSearchBox_TextChanged(object sender, EventArgs e)
        {
            idSearchBox.MaxLength = 4;
        }

        public static List<Student> readData()
        {

            List<Student> students = new List<Student>();
            Scholar scholar;
            Athlete athlete;
            Worker worker;
            const string FILE = "Residence Hall.csv";
            const char DELIM = ',';
            string[] info;

            try
            {

                FileStream file = new FileStream(FILE, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                string headerLine = reader.ReadLine();

                while (!reader.EndOfStream)
                {

                    info = reader.ReadLine().Split(DELIM);

                    switch (info[6])
                    {
                        case "Scholar":
                            scholar = new Scholar(Convert.ToInt32(info[0]), info[1], info[2], Convert.ToInt32(info[3]), Convert.ToInt32(info[4]), Convert.ToInt32(info[5]), info[6]);
                            Console.WriteLine(scholar);
                            students.Add(scholar);
                            break;
                        case "Athlete":
                            athlete = new Athlete(Convert.ToInt32(info[0]), info[1], info[2], Convert.ToInt32(info[3]), Convert.ToInt32(info[4]), Convert.ToInt32(info[5]), info[6]);
                            Console.WriteLine(athlete);
                            students.Add(athlete);
                            break;
                        case "Worker":
                            worker = new Worker(Convert.ToInt32(info[0]), info[1], info[2], Convert.ToInt32(info[3]), Convert.ToInt32(info[4]), Convert.ToInt32(info[5]), info[6]);
                            Console.WriteLine(worker);
                            students.Add(worker);
                            break;
                        default:
                            break;
                    }
                }

                reader.Close();
                file.Close();

            }
            catch (Exception i)
            {
                Console.WriteLine(i.StackTrace);
            }

            return students;

        }

        private void fnameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void lnameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("Residence Hall.csv", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);

            try
            {
                string fname = fnameTxtBox.Text;
                string lname = lnameTxtBox.Text;
                string stdntGroup = stdntTypeCmbBox.SelectedItem.ToString();
                string floor = floorCmbBox.SelectedItem.ToString();
                string stdntID = stdntIDTxtBox.Text;
                string dormNum = dormNumTxtBox.Text;
                int rent = 0;

                if (stdntGroup == "Worker")
                {
                    rent = 1245;
                }
                else if (stdntGroup == "Athlete")
                {
                    rent = 1200;
                }
                else if (stdntGroup == "Scholar")
                {
                    rent = 100;
                }
                else
                {

                }

                writer.WriteLine("{0},{1},{2},{3},{4},{5},{6}",stdntID, fname, lname, dormNum, floor, rent, stdntGroup);

                writer.Close();
                file.Close();

                fnameTxtBox.Clear();
                lnameTxtBox.Clear();
                stdntIDTxtBox.Clear();
                dormNumTxtBox.Clear();
                stdntTypeCmbBox.ResetText();
                floorCmbBox.ResetText();
                floorCmbBox.Items.Clear();

            }
            catch (Exception i)
            {
                Console.WriteLine(i.StackTrace);
            }
        }

        private void floorCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stdntTypeCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            floorCmbBox.Items.Clear();
            if (stdntTypeCmbBox.SelectedItem == "Worker")
            {
                floorCmbBox.Items.Add("1");
                floorCmbBox.Items.Add("2");
                floorCmbBox.Items.Add("3");
            }
            else if (stdntTypeCmbBox.SelectedItem == "Athlete")
            {
                floorCmbBox.Items.Add("4");
                floorCmbBox.Items.Add("5");
                floorCmbBox.Items.Add("6");
            }
            else
            {
                floorCmbBox.Items.Add("7");
                floorCmbBox.Items.Add("8");
            }
        }

        private void stdntIDTxtBox_TextChanged(object sender, EventArgs e)
        {
            stdntIDTxtBox.MaxLength = 4;
        }

        private void dormNumTxtBox_TextChanged(object sender, EventArgs e)
        {
            dormNumTxtBox.MaxLength = 4;
        }
    }

    public abstract class Student : IRDFunctions
    {
        public int idNum { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public int dormNum { get; set; }
        public int floor { get; set; }
        public int rent { get; set; }
        public string studentGroup { get; set; }

        public Student()
        {

        }
        
        public Student(int idNum, string fname, string lname, int dormNum, int floor, int rent, string stdntGroup)
        {
            this.idNum = idNum;
            this.fname = fname;
            this.lname = lname;
            this.dormNum = dormNum;
            this.floor = floor;
            this.rent = rent;
            studentGroup = stdntGroup;
        }

        public abstract int Balance();
    }

    interface IRDFunctions
    {
        int Balance();
    }
}
